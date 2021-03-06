-- USE [CS2]
GO
/****** Object:  StoredProcedure [dbo].[HBH_SP_GreatStar_GetSOBom]    Script Date: 2015/05/22 9:17:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


alter proc [dbo].[HBH_SP_GreatStar_GetSOBom] (
	@SO bigint = -1
	,@SOLines varchar(max) = ''
) as 
	set nocount on ;
	

	declare @MaxLevel int = 20
	declare @Level int = 1
	-- 数据中心
	declare @DataCenterOrgCode varchar(125) = 'J001'


	
If OBJECT_ID('tempdb..#hbh_tmp_SOLineBom') is not null
	Drop Table #hbh_tmp_SOLineBom
	

	select 
		bom.ID
		,bom.ItemMaster
		,so.BusinessDate
		,@Level as Level
	into #hbh_tmp_SOLineBom
	from SM_SO so
		inner join  SM_SOLine soline
		on so.ID = soline.SO
		inner join CBO_ItemMaster soItem
		on soline.ItemInfo_ItemID = soItem.ID
		inner join Base_Organization orgBom
		on orgBom.Code = @DataCenterOrgCode
		inner join CBO_ItemMaster bomItem
		on soItem.Code = bomItem.Code 
			and bomItem.Org = orgBom.ID
		inner join CBO_BomMaster bom
		on bomItem.ID = bom.ItemMaster
	where
		(so.ID = @SO
			-- 或者行匹配
		  or ',' + @SOLines + ',' like '%,' + cast(soline.ID as char(16)) + ',%'
		  )
		-- ItemMaster.Code=@ItemCode and Org.Code=@Org and Status=2 and @Date >=EffectiveDate and @Date <=DisableDate and ProductUOM=@UOM
		and bom.Status = 2 
		-- soline.SO.BusinessDate
		and so.BusinessDate between bom.EffectiveDate and bom.DisableDate


-- 循环下层，逐层展开
while (@Level <= @MaxLevel 
	and exists(select count(1) from #hbh_tmp_SOLineBom where Level = @Level)
	)

	--and exists(select 1 from CBO_BOMMaster 
	--		where ID in (select comp.ItemMaster 
	--					from CBO_BOMComponent comp
	--					where comp.BomMaster in (select ID from #hbh_tmp_SOLineBom tmp 
	--											where Level = @Level
	--											)
	--					) 
	--					) )

begin

	set @Level = @Level + 1
	
	
	insert into #hbh_tmp_SOLineBom (
		ID
		,ItemMaster
		,BusinessDate
		,Level
	)
	select 
		bom.ID
		,bom.ItemMaster
		,parentBom.BusinessDate
		,@Level as Level
	from #hbh_tmp_SOLineBom parentBom
		inner join CBO_BOMComponent comp
		on parentBom.ID = comp.BOMMaster
		inner join CBO_BomMaster bom
		on comp.ItemMaster = bom.ItemMaster
			-- Bom 的一些条件，待定
			-- and 
	where
		-- 上层Bom子件的Bom
		parentBom.Level = @Level - 1

		-- ItemMaster.Code=@ItemCode and Org.Code=@Org and Status=2 and @Date >=EffectiveDate and @Date <=DisableDate and ProductUOM=@UOM
		and bom.Status = 2 
		-- soline.SO.BusinessDate
		and parentBom.BusinessDate between bom.EffectiveDate and bom.DisableDate

end



select *
from #hbh_tmp_SOLineBom



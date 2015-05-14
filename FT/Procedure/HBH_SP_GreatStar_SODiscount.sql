
create proc [dbo].[HBH_SP_GreatStar_SODiscount] (
	@SOID bigint = -1
) as 
	set nocount on ;
	
	--declare @Now datetime = GetDate()
	---- declare @YearMonth int
	--declare @FromDate datetime 
	--declare @ToDate datetime
	declare @DefaultID bigint = -1
	declare @DefaultDecimal decimal(18,9) = 0
	--declare @IsCalcOnlyNewItem bit = 0
	

-- 1、取  有效的订单

If OBJECT_ID('tempdb..#hbh_tmp_SOLineCalcDis') is not null
	Drop Table #hbh_tmp_SOLineCalcDis
	
select 
	soline.ID as SOLine
	-- 外贸价
	,case when dbo.hbh_GetDecimal(subline.DescFlexField_PrivateDescSeg5,0) = 0 then soline.OrderPriceTC
		else dbo.hbh_GetDecimal(subline.DescFlexField_PrivateDescSeg5,0) 
		end as soPrice
	,@DefaultDecimal as DiscountedPrice
into #hbh_tmp_SOLineCalcDis
from SM_SO so
	inner join SM_SOLine soline
	on so.ID = soline.SO
	inner join SM_SOShipline subline
	on soline.ID = subline.SOLine
where 1=1
	--审核前
	and so.Status < 2
	-- 匹配订单ID
	and so.ID = @SOID
	-- 1.1	折扣备损件行、正常的赠品行，属于免费品行，不需要计算佣金折扣
	-- Present 0  赠品		SparePart 1  备损品 
	and (soline.FreeType is null or soline.FreeType not in (0,1))


-- 2、匹配  有效的客户产品折扣关系表 ; 计算订单折扣 

update #hbh_tmp_SOLineCalcDis
set
	DiscountedPrice = 
				-- 折后价
				-- DiscountType : FixedValues 0 固定值		PercentValues 3  百分比
				Round
					(case disLine.DiscountType 
						-- 点击生成折扣，当固定值＞外销价时(币种相同)，应予以提示，不允许进行折扣生成
						when 0 then case when tmpSO.soPrice > disLine.Prices
									then disLine.Prices
									else tmpSO.soPrice end
						when 3 then tmpSO.soPrice * disLine.Discount
						else tmpSO.soPrice
						end
							,currency.PriceRound_Precision)
						

--select 
--	tmpSO.ID as SOShiplineID
--	,soline.ID as SOLineID
--	,so.ID as SOID

--	,disLine.ID as DisLineID
--	,disHead.ID as DisHeadID

--	-- FixedValues 0 固定值		PercentValues 3  百分比
--	,disLine.DiscountType

--	--,disLine.Prices
--	--,disLine.Discount

--	-- 订单外销价
--	,tmpSO.soPrice

--	-- 折后价
--	-- DiscountType : FixedValues 0 固定值		PercentValues 3  百分比
--	,Round
--	(case disLine.DiscountType 
--		-- 点击生成折扣，当固定值＞外销价时(币种相同)，应予以提示，不允许进行折扣生成
--		when 0 then case when tmpSO.soPrice > disLine.Prices
--					then disLine.Prices
--					else tmpSO.soPrice end
--		when 3 then tmpSO.soPrice * disLine.Discount
--		else tmpSO.soPrice
--		end
--			,currency.PriceRound_Precision)
--		 as DiscountedPrice

--	-- 折扣额		DescFlexField.PrivateDescSeg21
	

from #hbh_tmp_SOLineCalcDis tmpSOLine
	--inner join SM_SOShipline subline
	--on tmpSO.ID = subline.ID
	--inner join SM_SOLine soline
	--on soline.ID = subline.SOLine
	inner join SM_SOLine soline
	on tmpSOLine.SOLine = subline.SOLine
	inner join SM_SO so
	on so.ID = soline.SO
	inner join Base_Currency currency
	on currency.ID = so.TC

	inner join GS_FT_DiscountHead disHead
	on disHead.Custmor = so.OrderBy_Customer
	inner join GS_FT_DiscountLine disLine
	on disLine.DiscountHead = disHead.ID
		-- 生效
		and so.BusinessDate between disLine.ValidDate and disLine.UnValidDate
		-- FixedValues 0 固定值		PercentValues 3  百分比
		-- 固定值,币种必须相同
		and (disLine.DiscountType != 0
			or currency.ID = disLine.CurrencyType
			)
where
	-- OpenState 0	开立		ApprovingState 1	审核中		ApprovedSate 2		已审核 
	disHead.Status = 2
	-- 组织条件
	and disHead.Org = so.Org



-- 3、
-- （涉及到订单金额、最终价计算，所以需要在实体、或BP中做修改订单价格金额，这里只是查出）
-- 方案改为 折扣额、折后价 更新订单行的公共段；
update SM_SOLine
set
	--折后价 (未定)
	DescFlexField_PublicDescSeg5 = tmpSOLine.DiscountedPrice
	-- 折扣额 (未定)
	,DescFlexField_PublicDescSeg6 = soline.TotalMoneyTC - (tmpSOLine.DiscountedPrice * soline.OrderQtyTU)
	-- 折后金额 (未定)
	,DescFlexField_PublicDescSeg7 = (tmpSOLine.DiscountedPrice * soline.OrderQtyTU)
from 
	#hbh_tmp_SOLineCalcDis tmpSOLine
	inner join SM_SOLine soline
	on tmpSOLine.SOLine = subline.SOLine



---- // 4、生成订单折扣子表







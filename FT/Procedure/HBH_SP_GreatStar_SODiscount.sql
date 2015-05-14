
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
	

-- 1��ȡ  ��Ч�Ķ���

If OBJECT_ID('tempdb..#hbh_tmp_SOLineCalcDis') is not null
	Drop Table #hbh_tmp_SOLineCalcDis
	
select 
	soline.ID as SOLine
	-- ��ó��
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
	--���ǰ
	and so.Status < 2
	-- ƥ�䶩��ID
	and so.ID = @SOID
	-- 1.1	�ۿ۱�����С���������Ʒ�У��������Ʒ�У�����Ҫ����Ӷ���ۿ�
	-- Present 0  ��Ʒ		SparePart 1  ����Ʒ 
	and (soline.FreeType is null or soline.FreeType not in (0,1))


-- 2��ƥ��  ��Ч�Ŀͻ���Ʒ�ۿ۹�ϵ�� ; ���㶩���ۿ� 

update #hbh_tmp_SOLineCalcDis
set
	DiscountedPrice = 
				-- �ۺ��
				-- DiscountType : FixedValues 0 �̶�ֵ		PercentValues 3  �ٷֱ�
				Round
					(case disLine.DiscountType 
						-- ��������ۿۣ����̶�ֵ��������ʱ(������ͬ)��Ӧ������ʾ������������ۿ�����
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

--	-- FixedValues 0 �̶�ֵ		PercentValues 3  �ٷֱ�
--	,disLine.DiscountType

--	--,disLine.Prices
--	--,disLine.Discount

--	-- ����������
--	,tmpSO.soPrice

--	-- �ۺ��
--	-- DiscountType : FixedValues 0 �̶�ֵ		PercentValues 3  �ٷֱ�
--	,Round
--	(case disLine.DiscountType 
--		-- ��������ۿۣ����̶�ֵ��������ʱ(������ͬ)��Ӧ������ʾ������������ۿ�����
--		when 0 then case when tmpSO.soPrice > disLine.Prices
--					then disLine.Prices
--					else tmpSO.soPrice end
--		when 3 then tmpSO.soPrice * disLine.Discount
--		else tmpSO.soPrice
--		end
--			,currency.PriceRound_Precision)
--		 as DiscountedPrice

--	-- �ۿ۶�		DescFlexField.PrivateDescSeg21
	

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
		-- ��Ч
		and so.BusinessDate between disLine.ValidDate and disLine.UnValidDate
		-- FixedValues 0 �̶�ֵ		PercentValues 3  �ٷֱ�
		-- �̶�ֵ,���ֱ�����ͬ
		and (disLine.DiscountType != 0
			or currency.ID = disLine.CurrencyType
			)
where
	-- OpenState 0	����		ApprovingState 1	�����		ApprovedSate 2		����� 
	disHead.Status = 2
	-- ��֯����
	and disHead.Org = so.Org



-- 3��
-- ���漰�����������ռۼ��㣬������Ҫ��ʵ�塢��BP�����޸Ķ����۸������ֻ�ǲ����
-- ������Ϊ �ۿ۶�ۺ�� ���¶����еĹ����Σ�
update SM_SOLine
set
	--�ۺ�� (δ��)
	DescFlexField_PublicDescSeg5 = tmpSOLine.DiscountedPrice
	-- �ۿ۶� (δ��)
	,DescFlexField_PublicDescSeg6 = soline.TotalMoneyTC - (tmpSOLine.DiscountedPrice * soline.OrderQtyTU)
	-- �ۺ��� (δ��)
	,DescFlexField_PublicDescSeg7 = (tmpSOLine.DiscountedPrice * soline.OrderQtyTU)
from 
	#hbh_tmp_SOLineCalcDis tmpSOLine
	inner join SM_SOLine soline
	on tmpSOLine.SOLine = subline.SOLine



---- // 4�����ɶ����ۿ��ӱ�







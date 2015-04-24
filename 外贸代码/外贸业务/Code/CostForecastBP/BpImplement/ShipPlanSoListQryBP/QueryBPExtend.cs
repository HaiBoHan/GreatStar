namespace ShipPlanSoListQryBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// QueryBP partial 
	/// </summary>	
	public partial class QueryBP 
	{	
		internal BaseStrategy Select()
		{
			return new QueryBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class QueryBPImpementStrategy : BaseStrategy
	{
		public QueryBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			QueryBP bpObj = (QueryBP)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}		
	}
    
    #region QueryBP Stereotype
    internal partial class QueryBPImpementStrategy
    {
       //实体FullName
        private string GetEntityFullName()
        {
             //TODO:
             return string.Empty;
        }
        /// <summary>
        /// 分页内部是否需要使用临时表机制，对于数据量比较小的查询，没有必要采用临时表
        /// 缓存第一次查询的结果，每次重查就行了，否则第一次查询时页面加载会慢些。由BP
        /// 开发人员自己判断。
        /// </summary>
        /// <returns></returns>
        private bool isNeedTempTable()
        {
            return true;
        }//end isTempTable 

        /// <summary>
        /// 是否基于临时表构造的OQL,对于基于临时表的查询，分页服务内部不需要多语的处理；
        /// 基于业务表的查询，则需要。此处由BP开发人员根据实际情况返回正确的值。
        /// </summary>
        /// <returns></returns>
        private bool oqlBuildByTempTable()
        {
            return false;
        }//end isNeedMultiLang

        /// <summary>
        /// 执行业务逻辑，返回OQL串，由BP开发人员添加代码。
        /// 参数bpParameter中带有已选栏目、过滤及排序信息
        /// </summary>
        /// <returns></returns>
        private string DoLogic(UFIDA.U9.Query.QueryCaseBP.QryCommonParaObj bpParameter)
        {
           //TODO:
           
           /* 以下为例子代码段
           DoMap();
           //必须引用UFIDA.UBF.Report.App.Data.dll
           UFIDA.UBF.Report.App.Data.SimpleOqlTool simpleTool = new UFIDA.UBF.Report.App.Data.SimpleOqlTool();
           
           //处理栏目，形成Select子句
           foreach (QryColumnItem columnitem in bpParameter.QryColumnItems)
           {
               simpleTool.AddSelect(this.map[columnitem.ColumnAlias], columnitem.ColumnAlias);
           }
           //处理条件，形成Where子句
           foreach (QryFilterItem filterItem in bpParameter.QryFilterITems)
           {
                
               string leftExpr = filterItem.LeftExpr.Replace(filterItem.Name, map[filterItem.Name]);

               simpleTool.AddCondition(leftExpr, filterItem.DataType, filterItem.Operation, filterItem.RightValues, filterItem.ValueType);

           }
           //处理From部份，形成From子句
           simpleTool.SetFromClause(" UFIDA::U9::SM::SO::SO as SO ");
            
           //获取OQL串 
           string selectResult = simpleTool.GetOqlString();
            */
           
           
           return string.Empty;
        } //end DoLogic 


        /// <summary>
        /// 这部份代码查询开发人员不要作修改
        /// 删除Do方法中的
        /// throw new NotImplementedException();
        /// 在Do方法中直接加上一句:
        /// return DoProcess(bpObj.QryInParameter);
        /// </summary>
        /// <param name="bpParameter"></param>
        /// <returns></returns>
        private object DoProcess(UFIDA.U9.Query.QueryCaseBP.QryCommonParaObj bpParameter)
        {
            UFIDA.UBF.Query.CommonService.QryPaginateService<ShipPlanSoListQryBP.ShipPlanSoListQryDTO> ps = new UFIDA.UBF.Query.CommonService.QryPaginateService<ShipPlanSoListQryBP.ShipPlanSoListQryDTO>(bpParameter, isNeedTempTable());
            if (ps.isProcessBusiness)
            {
                string oql = DoLogic(bpParameter);
                return ps.FindDataByPage(GetEntityFullName(), oqlBuildByTempTable(), oql);
            }
            else
            {
                return ps.FindDataByPage();
            }
        }
    }
    
    internal partial class QueryBPImpementStrategy
    {
         private  IDictionary<String, String> map = new Dictionary<String, String>();
         
         #region 实体属性对应的别名定义
         
         //public readonly static string SO_BusinessDate = "SO_BusinessDate";
         
         #endregion
         
         private void DoMap()
         {
            //map.Add(SO_BusinessDate, "SO.BusinessDate");
         }
    }
    #endregion
    
	#endregion
	
	
}
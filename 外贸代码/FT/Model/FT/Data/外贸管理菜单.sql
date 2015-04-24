	--此脚本用于二级应用
	declare @YY0 nvarchar(10)
	declare @YY1 nvarchar(10)
    
	declare @YYID0 bigint
	declare @YYID1 bigint
	
	declare @YYShortName0 nvarchar(10)
	declare @YYShortName1 nvarchar(10)	
 
	declare @YYName0 nvarchar(10)
	declare @YYName1 nvarchar(10)	
 
	declare @CreatedBy nvarchar(20)
		
	set @YY0='80004'
	set @YY1='80005'
 
   	set @YYShortName0='FTPar'
	set @YYShortName1='FT'
    
	set @YYName0='外贸管理'
	set @YYName1='外贸管理'
	
	set @YYID0 =(select top 1 id from Base_Application where Code=@YY0)
	set @YYID1 =(select top 1 ID from Base_Application where Code=@YY1)
	set @CreatedBy ='YuNeng'
	
	if (@YYID0 is null)
	set @YYID0=(CAST (@yy0 as bigint))
	if (@YYID1 is null)
	set @YYID1=(CAST (@yy1 as bigint))
	
	--Base_Application 菜单应用
	DELETE FROM Base_Application_TRL WHERE ID in(@YYID0 ,@YYID1)
	DELETE FROM Base_Application WHERE ID in(@YYID0,@YYID1)
	--第一级0
	INSERT INTO Base_Application(ID,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy,Code,ShortName,Effective_IsEffective,Effective_EffectiveDate,Effective_DisableDate,[Level],IsLeaf,ParentNode,SysVersion)
	VALUES(@YYID0 ,GETDATE(),@CreatedBy ,NULL,NULL,@YY0 ,@YYShortName0 ,1,DATEADD(DAY,-1,GETDATE ()),'9999-12-31',1,0,NULL,0)
	INSERT INTO Base_Application_TRL(ID,SysMLFlag,[Name])
	VALUES(@YYID0,'zh-CN',@YYName0)
	INSERT INTO Base_Application_TRL(ID,SysMLFlag,[Name])
	VALUES(@YYID0,'en-US',@YYShortName0)
	--第二级1
	INSERT INTO Base_Application(ID,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy,Code,ShortName,Effective_IsEffective,Effective_EffectiveDate,Effective_DisableDate,[Level],IsLeaf,ParentNode,SysVersion)
	VALUES(@YYID1,GETDATE(),@CreatedBy,NULL,NULL,@YY1,@YYShortName1,1,DATEADD(DAY,-1,GETDATE()),'9999-12-31',2,1,@YYID0,0)
	INSERT INTO Base_Application_TRL(ID,SysMLFlag,[Name])
	VALUES(@YYID1,'zh-CN',@YYName1)
	INSERT INTO Base_Application_TRL(ID,SysMLFlag,[Name])
	VALUES(@YYID1,'en-US',@YYShortName1)
		
	
	--UBF_SM_AppOperatorMap 应用控制类分布
	--仅末级需要预置
	DELETE FROM UBF_SM_AppOperatorMap WHERE [Application] IN (@YYID1)
	
	INSERT INTO UBF_SM_AppOperatorMap (ID,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy,SysVersion,[Application],OperatorLocation,EnableAppOperatorFullName,DisableAppOperatorFullName,LockAppOperatorFullName,UnlockAppOperatorFullName,EnableCheckOperatorFullName,MataDataState,MenuState,AuthorityState) 
	VALUES ( (select isnull(max(id),0)+1 from ubf_sm_appoperatormap), getdate(), @createdby, NULL, NULL, 0
	,@YYID1
	,'UFIDA.U9.BS.AppController.AppControllerBP.dll'
	,'UFIDA.U9.BS.AppController.EnableAppOperator'
	,'UFIDA.U9.BS.AppController.DisableAppOperator'
	,'UFIDA.U9.BS.AppController.LockAppOperator'
	,'UFIDA.U9.BS.AppController.UnlockAppOperator'
	,'','false','false','false'); 
		
	--启用时不检查脚本
	update UBF_SM_AppOperatorMap set MataDataState=1 ,MenuState=1 where [Application] in (@YYID1)
	 
	
	--UBF_SM_OrgTypeAppMap 组织性质与应用
	--仅末级需要预置
	DELETE FROM UBF_SM_OrgTypeAppMap WHERE [Application] in (@YYID1)
	
	INSERT INTO UBF_SM_OrgTypeAppMap ([ID],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy],[SysVersion],[OrgType],[Application])
	VALUES((select isnull(max(id),0)+1 from UBF_SM_OrgTypeAppMap)
	,GETDATE(),@CreatedBy,NUll,NULL,0,1,@YYID1)
	
	INSERT INTO UBF_SM_OrgTypeAppMap ([ID],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy],[SysVersion],[OrgType],[Application])
	VALUES((select isnull(max(id),0)+1 from UBF_SM_OrgTypeAppMap)
	,GETDATE(),@CreatedBy,NUll,NULL,0,2,@YYID1)
	
	INSERT INTO UBF_SM_OrgTypeAppMap ([ID],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy],[SysVersion],[OrgType],[Application])
	VALUES((select isnull(max(id),0)+1 from UBF_SM_OrgTypeAppMap)
	,GETDATE(),@CreatedBy,NUll,NULL,0,3,@YYID1)
	
	INSERT INTO UBF_SM_OrgTypeAppMap ([ID],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy],[SysVersion],[OrgType],[Application])
	VALUES((select isnull(max(id),0)+1 from UBF_SM_OrgTypeAppMap)
	,GETDATE(),@CreatedBy,NUll,NULL,0,4,@YYID1)
	
	INSERT INTO UBF_SM_OrgTypeAppMap ([ID],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy],[SysVersion],[OrgType],[Application])
	VALUES((select isnull(max(id),0)+1 from UBF_SM_OrgTypeAppMap)
	,GETDATE(),@CreatedBy,NUll,NULL,0,5,@YYID1)
	
	INSERT INTO UBF_SM_OrgTypeAppMap ([ID],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy],[SysVersion],[OrgType],[Application])
	VALUES((select isnull(max(id),0)+1 from UBF_SM_OrgTypeAppMap)
	,GETDATE(),@CreatedBy,NUll,NULL,0,6,@YYID1)
	
	INSERT INTO UBF_SM_OrgTypeAppMap ([ID],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy],[SysVersion],[OrgType],[Application])
	VALUES((select isnull(max(id),0)+1 from UBF_SM_OrgTypeAppMap)
	,GETDATE(),@CreatedBy,NUll,NULL,0,7,@YYID1)
	
	INSERT INTO UBF_SM_OrgTypeAppMap ([ID],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy],[SysVersion],[OrgType],[Application])
	VALUES((select isnull(max(id),0)+1 from UBF_SM_OrgTypeAppMap)
	,GETDATE(),@CreatedBy,NUll,NULL,0,8,@YYID1)
	
	INSERT INTO UBF_SM_OrgTypeAppMap ([ID],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy],[SysVersion],[OrgType],[Application])
	VALUES((select isnull(max(id),0)+1 from UBF_SM_OrgTypeAppMap)
	,GETDATE(),@CreatedBy,NUll,NULL,0,9,@YYID1)
	
	INSERT INTO UBF_SM_OrgTypeAppMap ([ID],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy],[SysVersion],[OrgType],[Application])
	VALUES((select isnull(max(id),0)+1 from UBF_SM_OrgTypeAppMap)
	,GETDATE(),@CreatedBy,NUll,NULL,0,10,@YYID1)
	
		
	--Base_Role 角色
	--仅末级需要预置
	--DELETE FROM Base_Role_trl WHERE  id in (SELECT id FROM Base_Role WHERE [Application] in (@YYID1,@YYID2,@YYID3,@YYID4,@YYID5,@YYID6))
	--DELETE FROM Base_Role WHERE [Application] in (@YYID1,@YYID2,@YYID3,@YYID4,@YYID5,@YYID6)
	
	DELETE FROM Base_Role_trl WHERE  id in (SELECT id FROM Base_Role WHERE Code  in (@YYShortName1+'AppLVAdmin'))
	DELETE FROM Base_Role WHERE Code  in (@YYShortName1+'AppLVAdmin')
	
		
	INSERT INTO Base_Role (ID, CreatedOn, CreatedBy, ModifiedOn,ModifiedBy,Code,ShortName,[Type],Effective_IsEffective,Effective_EffectiveDate,Effective_DisableDate,[Application],IsPrefab) 
	VALUES((select isnull(max(id),0)+1 from Base_Role),getdate(),@createdby,NULL,NULL,@YYShortName1+'AppLVAdmin',@YYShortName1,4,1,DATEADD(DAY,-1,GETDATE()),'9999-12-31',@YYID1,3)
	INSERT INTO Base_Role_trl (ID,SysMLFlag,[Name])
	VALUES((select top 1 id from Base_Role where Code  in (@YYShortName1+'AppLVAdmin') ),'zh-CN',@yyname1+'应用管理员角色')
	INSERT INTO Base_Role_trl (ID,SysMLFlag,[Name]) 
	VALUES((select top 1 id from Base_Role where Code  in (@YYShortName1+'AppLVAdmin') ),'en-US',@YYShortName1+' Manage Application Administrator')
	

	--v2.1补充
	--2.1版本一个角色可对应多个应用，所以2.1新增了角色应用表，角色-角色应用为组合关系
	--所以需增加一条角色应用记录
	--删除该应用的角色记录
	DELETE FROM Base_RoleApplication WHERE [Application] in (@YYID1)
	--新增该应用的角色
	INSERT INTO Base_RoleApplication (ID,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy,SysVersion,[Application],[Role])
	VALUES((select isnull(max(id),0)+1 from Base_RoleApplication),getdate(),@createdby,NULL,NULL,0,@YYID1,(select top 1 id from Base_Role where Code  in (@YYShortName1+'AppLVAdmin') ))
	
	GO

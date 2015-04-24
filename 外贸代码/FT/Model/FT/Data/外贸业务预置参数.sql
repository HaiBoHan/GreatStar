declare @Application bigint
declare @CreatedBy nvarchar(20)
declare @ID bigint

 --1、柜子的额定重量 
--设置应用的ID
set @Application=80005
--设置创建名称
set @CreatedBy ='YuNeng'
--预置参数的初始ID(年月日时分秒+01纯数字)
set @ID=201410291553
--为了可重复执行，创建前先删除
--删除参数值表中关于本应用的数据(此参数值表区分多组织)
DELETE FROM Base_ProfileValue WHERE profile in (SELECT ID FROM Base_Profile WHERE [ID] = @ID )
--删除参数表中关于本应用的数据(所有组织共用此参数表)
DELETE FROM Base_Profile WHERE [ID] = @ID
--删除参数(多语)表中关于本应用的数据
DELETE FROM Base_Profile_Trl WHERE ID not in (select ID from Base_Profile )
 --进行参数预置
--ProfileValueType 参数值类型 (可查classview)
--0string 1int 2decimal 3bool 4date 6enum 7entity
--SubTypeName 子类型名称 当ProfileValueType=7时，此处填入实体名称，如UFIDA.U9.Base.Organization.Organization
--DefaultValue 缺省值，字串
--Code 编码，字串
--[Application]，所属应用
--ControlScope，作用范围(0站点1组织2角色3用户4实体角色)
--SensitiveType 敏感性类型(0厂商修改1设置后不可改2使用后不可改3可追朔修改4可前向修改)
--ReferenceID，参照ID，字串（未知）
--ProfileGroup,参数分组，字串

INSERT INTO Base_Profile (ID, CreatedOn, CreatedBy, ModifiedOn,ModifiedBy,ProfileValueType,SubTypeName,DefaultValue,Code,[Application],ControlScope,SensitiveType ,ReferenceID)
VALUES (@ID ,GETDATE(),@CreatedBy ,NULL,NULL ,2,'','0','FTCabinetRough',@Application,1,4,'')
 
INSERT INTO Base_Profile_Trl (SysMLFlag,ID, [Description],[Name],ProfileGroup)
VALUES ('zh-CN',@ID,'订单成本预测使用','柜子的额定重量','外贸业务')

 --2、柜子的额定体积
--多条参数时，@ID自增
set @ID=@ID+1
--为了可重复执行，创建前先删除
--删除参数值表中关于本应用的数据(此参数值表区分多组织)
DELETE FROM Base_ProfileValue WHERE profile in (SELECT ID FROM Base_Profile WHERE [ID] = @ID )
--删除参数表中关于本应用的数据(所有组织共用此参数表)
DELETE FROM Base_Profile WHERE [ID] = @ID
--删除参数(多语)表中关于本应用的数据
DELETE FROM Base_Profile_Trl WHERE ID not in (select ID from Base_Profile )
 
--进行参数预置
INSERT INTO Base_Profile (ID, CreatedOn, CreatedBy, ModifiedOn,ModifiedBy,ProfileValueType,SubTypeName,DefaultValue,Code,[Application],ControlScope,SensitiveType ,ReferenceID)
VALUES (@ID ,GETDATE(),@CreatedBy ,NULL,NULL ,2,'','0','FTCabinetVolume',@Application,1,4,'')
 
INSERT INTO Base_Profile_Trl (SysMLFlag,ID, [Description],[Name],ProfileGroup)
VALUES ('zh-CN',@ID,'订单成本预测使用','柜子的额定体积','外贸业务')

 --3、管理费比例
--多条参数时，@ID自增
set @ID=@ID+1
--为了可重复执行，创建前先删除
--删除参数值表中关于本应用的数据(此参数值表区分多组织)
DELETE FROM Base_ProfileValue WHERE profile in (SELECT ID FROM Base_Profile WHERE [ID] = @ID )
--删除参数表中关于本应用的数据(所有组织共用此参数表)
DELETE FROM Base_Profile WHERE [ID] = @ID
--删除参数(多语)表中关于本应用的数据
DELETE FROM Base_Profile_Trl WHERE ID not in (select ID from Base_Profile )
 
--进行参数预置
INSERT INTO Base_Profile (ID, CreatedOn, CreatedBy, ModifiedOn,ModifiedBy,ProfileValueType,SubTypeName,DefaultValue,Code,[Application],ControlScope,SensitiveType ,ReferenceID)
VALUES (@ID ,GETDATE(),@CreatedBy ,NULL,NULL ,2,'','0','FTManagementFee',@Application,1,4,'')
 
INSERT INTO Base_Profile_Trl (SysMLFlag,ID, [Description],[Name],ProfileGroup)
VALUES ('zh-CN',@ID,'订单成本预测使用','管理费比例','外贸业务')

 --4、年息
--多条参数时，@ID自增
set @ID=@ID+1
--为了可重复执行，创建前先删除
--删除参数值表中关于本应用的数据(此参数值表区分多组织)
DELETE FROM Base_ProfileValue WHERE profile in (SELECT ID FROM Base_Profile WHERE [ID] = @ID )
--删除参数表中关于本应用的数据(所有组织共用此参数表)
DELETE FROM Base_Profile WHERE [ID] = @ID
--删除参数(多语)表中关于本应用的数据
DELETE FROM Base_Profile_Trl WHERE ID not in (select ID from Base_Profile )
 
--进行参数预置
INSERT INTO Base_Profile (ID, CreatedOn, CreatedBy, ModifiedOn,ModifiedBy,ProfileValueType,SubTypeName,DefaultValue,Code,[Application],ControlScope,SensitiveType ,ReferenceID)
VALUES (@ID ,GETDATE(),@CreatedBy ,NULL,NULL ,2,'','0','FTAnnualInterest',@Application,1,4,'')
 
INSERT INTO Base_Profile_Trl (SysMLFlag,ID, [Description],[Name],ProfileGroup)
VALUES ('zh-CN',@ID,'订单成本预测使用','年息比例','外贸业务')

 --5、质检评估控制出运
--多条参数时，@ID自增
set @ID=@ID+1
--为了可重复执行，创建前先删除
--删除参数值表中关于本应用的数据(此参数值表区分多组织)
DELETE FROM Base_ProfileValue WHERE profile in (SELECT ID FROM Base_Profile WHERE [ID] = @ID )
--删除参数表中关于本应用的数据(所有组织共用此参数表)
DELETE FROM Base_Profile WHERE [ID] = @ID
--删除参数(多语)表中关于本应用的数据
DELETE FROM Base_Profile_Trl WHERE ID not in (select ID from Base_Profile )

INSERT INTO Base_Profile (ID, CreatedOn, CreatedBy, ModifiedOn,ModifiedBy,ProfileValueType,SubTypeName,DefaultValue,Code,[Application],ControlScope,SensitiveType ,ReferenceID)
  VALUES (@ID ,GETDATE(),@CreatedBy ,NULL,NULL ,3,NULL,'','FT_Ship',@Application ,1,4,null)				 
INSERT INTO Base_Profile_Trl (SysMLFlag,ID, [Description],[Name],ProfileGroup)
                      VALUES ('zh-CN',@ID,'评估单使用','质检评估控制出运','外贸业务')
	 --6、质检评估控制收货
--多条参数时，@ID自增
set @ID=@ID+1
--为了可重复执行，创建前先删除
--删除参数值表中关于本应用的数据(此参数值表区分多组织)
DELETE FROM Base_ProfileValue WHERE profile in (SELECT ID FROM Base_Profile WHERE [ID] = @ID )
--删除参数表中关于本应用的数据(所有组织共用此参数表)
DELETE FROM Base_Profile WHERE [ID] = @ID
--删除参数(多语)表中关于本应用的数据
DELETE FROM Base_Profile_Trl WHERE ID not in (select ID from Base_Profile )				  	 

					  INSERT INTO Base_Profile (ID, CreatedOn, CreatedBy, ModifiedOn,ModifiedBy,ProfileValueType,SubTypeName,DefaultValue,Code,[Application],ControlScope,SensitiveType ,ReferenceID)
                 VALUES (@ID ,GETDATE(),@CreatedBy ,NULL,NULL ,3,NULL,'','FT_TabkeGood',@Application ,1,4,null)				 
INSERT INTO Base_Profile_Trl (SysMLFlag,ID, [Description],[Name],ProfileGroup)
                      VALUES ('zh-CN',@ID,'评估单使用','质检评估控制收货','外贸业务')
 --7、质检评估控制发货
--多条参数时，@ID自增
set @ID=@ID+1
--为了可重复执行，创建前先删除
--删除参数值表中关于本应用的数据(此参数值表区分多组织)
DELETE FROM Base_ProfileValue WHERE profile in (SELECT ID FROM Base_Profile WHERE [ID] = @ID )
--删除参数表中关于本应用的数据(所有组织共用此参数表)
DELETE FROM Base_Profile WHERE [ID] = @ID
--删除参数(多语)表中关于本应用的数据
DELETE FROM Base_Profile_Trl WHERE ID not in (select ID from Base_Profile )		
					
					  INSERT INTO Base_Profile (ID, CreatedOn, CreatedBy, ModifiedOn,ModifiedBy,ProfileValueType,SubTypeName,DefaultValue,Code,[Application],ControlScope,SensitiveType ,ReferenceID)
                 VALUES (@ID ,GETDATE(),@CreatedBy ,NULL,NULL ,3,NULL,'','FT_Shipments',@Application ,1,4,null)				 
INSERT INTO Base_Profile_Trl (SysMLFlag,ID, [Description],[Name],ProfileGroup)
                      VALUES ('zh-CN',@ID,'评估单使用','质检评估控制发货','外贸业务')
--8、质检评估控制领料
--多条参数时，@ID自增
set @ID=@ID+1
--为了可重复执行，创建前先删除
--删除参数值表中关于本应用的数据(此参数值表区分多组织)
DELETE FROM Base_ProfileValue WHERE profile in (SELECT ID FROM Base_Profile WHERE [ID] = @ID )
--删除参数表中关于本应用的数据(所有组织共用此参数表)
DELETE FROM Base_Profile WHERE [ID] = @ID
--删除参数(多语)表中关于本应用的数据
DELETE FROM Base_Profile_Trl WHERE ID not in (select ID from Base_Profile )						    

 INSERT INTO Base_Profile (ID, CreatedOn, CreatedBy, ModifiedOn,ModifiedBy,ProfileValueType,SubTypeName,DefaultValue,Code,[Application],ControlScope,SensitiveType ,ReferenceID)
                 VALUES (@ID ,GETDATE(),@CreatedBy ,NULL,NULL ,3,NULL,'','FT_Picking',@Application ,1,4,null)				 
INSERT INTO Base_Profile_Trl (SysMLFlag,ID, [Description],[Name],ProfileGroup)
                      VALUES ('zh-CN',@ID,'评估单使用','质检评估控制领料','外贸业务')
 

GO


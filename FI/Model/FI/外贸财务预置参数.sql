declare @Application bigint
declare @CreatedBy nvarchar(20)
declare @ID bigint

 --1、奖金系数 
--设置应用的ID
set @Application=80011
--设置创建名称
set @CreatedBy ='YuNeng'
--预置参数的初始ID(年月日时分秒+01纯数字)
set @ID=201412290913
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
VALUES (@ID ,GETDATE(),@CreatedBy ,NULL,NULL ,2,'','0','FIBonusCoefficient',@Application,1,4,'')
 
INSERT INTO Base_Profile_Trl (SysMLFlag,ID, [Description],[Name],ProfileGroup)
VALUES ('zh-CN',@ID,'计算采购业务员奖金时需要','奖金系数','外贸财务')


 --2、降价系数
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
VALUES (@ID ,GETDATE(),@CreatedBy ,NULL,NULL ,2,'','0','FIDegradationCoefficient',@Application,1,4,'')
 
INSERT INTO Base_Profile_Trl (SysMLFlag,ID, [Description],[Name],ProfileGroup)
VALUES ('zh-CN',@ID,'计算采购业务员奖金时需要','降价系数','外贸财务')

 --3、包装业务员奖金系数
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
VALUES (@ID ,GETDATE(),@CreatedBy ,NULL,NULL ,2,'','0','FIPackaingBonusCoefficient',@Application,1,4,'')
 
INSERT INTO Base_Profile_Trl (SysMLFlag,ID, [Description],[Name],ProfileGroup)
VALUES ('zh-CN',@ID,'计算包装业务员奖金时需求','包装奖金系数','外贸业务')

 --4、交货基准交期
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
VALUES (@ID ,GETDATE(),@CreatedBy ,NULL,NULL ,1,'','0','FIDeliveryExpectDay',@Application,1,4,'')
 
INSERT INTO Base_Profile_Trl (SysMLFlag,ID, [Description],[Name],ProfileGroup)
VALUES ('zh-CN',@ID,'计算业务员奖金时需要','交货基准交期','外贸财务')


GO


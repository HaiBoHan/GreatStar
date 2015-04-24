declare @Application bigint
declare @CreatedBy nvarchar(20)
declare @ID bigint

 --1�����ӵĶ���� 
--����Ӧ�õ�ID
set @Application=80005
--���ô�������
set @CreatedBy ='YuNeng'
--Ԥ�ò����ĳ�ʼID(������ʱ����+01������)
set @ID=201410291553
--Ϊ�˿��ظ�ִ�У�����ǰ��ɾ��
--ɾ������ֵ���й��ڱ�Ӧ�õ�����(�˲���ֵ�����ֶ���֯)
DELETE FROM Base_ProfileValue WHERE profile in (SELECT ID FROM Base_Profile WHERE [ID] = @ID )
--ɾ���������й��ڱ�Ӧ�õ�����(������֯���ô˲�����)
DELETE FROM Base_Profile WHERE [ID] = @ID
--ɾ������(����)���й��ڱ�Ӧ�õ�����
DELETE FROM Base_Profile_Trl WHERE ID not in (select ID from Base_Profile )
 --���в���Ԥ��
--ProfileValueType ����ֵ���� (�ɲ�classview)
--0string 1int 2decimal 3bool 4date 6enum 7entity
--SubTypeName ���������� ��ProfileValueType=7ʱ���˴�����ʵ�����ƣ���UFIDA.U9.Base.Organization.Organization
--DefaultValue ȱʡֵ���ִ�
--Code ���룬�ִ�
--[Application]������Ӧ��
--ControlScope�����÷�Χ(0վ��1��֯2��ɫ3�û�4ʵ���ɫ)
--SensitiveType ����������(0�����޸�1���ú󲻿ɸ�2ʹ�ú󲻿ɸ�3��׷˷�޸�4��ǰ���޸�)
--ReferenceID������ID���ִ���δ֪��
--ProfileGroup,�������飬�ִ�

INSERT INTO Base_Profile (ID, CreatedOn, CreatedBy, ModifiedOn,ModifiedBy,ProfileValueType,SubTypeName,DefaultValue,Code,[Application],ControlScope,SensitiveType ,ReferenceID)
VALUES (@ID ,GETDATE(),@CreatedBy ,NULL,NULL ,2,'','0','FTCabinetRough',@Application,1,4,'')
 
INSERT INTO Base_Profile_Trl (SysMLFlag,ID, [Description],[Name],ProfileGroup)
VALUES ('zh-CN',@ID,'�����ɱ�Ԥ��ʹ��','���ӵĶ����','��óҵ��')

 --2�����ӵĶ���
--��������ʱ��@ID����
set @ID=@ID+1
--Ϊ�˿��ظ�ִ�У�����ǰ��ɾ��
--ɾ������ֵ���й��ڱ�Ӧ�õ�����(�˲���ֵ�����ֶ���֯)
DELETE FROM Base_ProfileValue WHERE profile in (SELECT ID FROM Base_Profile WHERE [ID] = @ID )
--ɾ���������й��ڱ�Ӧ�õ�����(������֯���ô˲�����)
DELETE FROM Base_Profile WHERE [ID] = @ID
--ɾ������(����)���й��ڱ�Ӧ�õ�����
DELETE FROM Base_Profile_Trl WHERE ID not in (select ID from Base_Profile )
 
--���в���Ԥ��
INSERT INTO Base_Profile (ID, CreatedOn, CreatedBy, ModifiedOn,ModifiedBy,ProfileValueType,SubTypeName,DefaultValue,Code,[Application],ControlScope,SensitiveType ,ReferenceID)
VALUES (@ID ,GETDATE(),@CreatedBy ,NULL,NULL ,2,'','0','FTCabinetVolume',@Application,1,4,'')
 
INSERT INTO Base_Profile_Trl (SysMLFlag,ID, [Description],[Name],ProfileGroup)
VALUES ('zh-CN',@ID,'�����ɱ�Ԥ��ʹ��','���ӵĶ���','��óҵ��')

 --3������ѱ���
--��������ʱ��@ID����
set @ID=@ID+1
--Ϊ�˿��ظ�ִ�У�����ǰ��ɾ��
--ɾ������ֵ���й��ڱ�Ӧ�õ�����(�˲���ֵ�����ֶ���֯)
DELETE FROM Base_ProfileValue WHERE profile in (SELECT ID FROM Base_Profile WHERE [ID] = @ID )
--ɾ���������й��ڱ�Ӧ�õ�����(������֯���ô˲�����)
DELETE FROM Base_Profile WHERE [ID] = @ID
--ɾ������(����)���й��ڱ�Ӧ�õ�����
DELETE FROM Base_Profile_Trl WHERE ID not in (select ID from Base_Profile )
 
--���в���Ԥ��
INSERT INTO Base_Profile (ID, CreatedOn, CreatedBy, ModifiedOn,ModifiedBy,ProfileValueType,SubTypeName,DefaultValue,Code,[Application],ControlScope,SensitiveType ,ReferenceID)
VALUES (@ID ,GETDATE(),@CreatedBy ,NULL,NULL ,2,'','0','FTManagementFee',@Application,1,4,'')
 
INSERT INTO Base_Profile_Trl (SysMLFlag,ID, [Description],[Name],ProfileGroup)
VALUES ('zh-CN',@ID,'�����ɱ�Ԥ��ʹ��','����ѱ���','��óҵ��')

 --4����Ϣ
--��������ʱ��@ID����
set @ID=@ID+1
--Ϊ�˿��ظ�ִ�У�����ǰ��ɾ��
--ɾ������ֵ���й��ڱ�Ӧ�õ�����(�˲���ֵ�����ֶ���֯)
DELETE FROM Base_ProfileValue WHERE profile in (SELECT ID FROM Base_Profile WHERE [ID] = @ID )
--ɾ���������й��ڱ�Ӧ�õ�����(������֯���ô˲�����)
DELETE FROM Base_Profile WHERE [ID] = @ID
--ɾ������(����)���й��ڱ�Ӧ�õ�����
DELETE FROM Base_Profile_Trl WHERE ID not in (select ID from Base_Profile )
 
--���в���Ԥ��
INSERT INTO Base_Profile (ID, CreatedOn, CreatedBy, ModifiedOn,ModifiedBy,ProfileValueType,SubTypeName,DefaultValue,Code,[Application],ControlScope,SensitiveType ,ReferenceID)
VALUES (@ID ,GETDATE(),@CreatedBy ,NULL,NULL ,2,'','0','FTAnnualInterest',@Application,1,4,'')
 
INSERT INTO Base_Profile_Trl (SysMLFlag,ID, [Description],[Name],ProfileGroup)
VALUES ('zh-CN',@ID,'�����ɱ�Ԥ��ʹ��','��Ϣ����','��óҵ��')

 --5���ʼ��������Ƴ���
--��������ʱ��@ID����
set @ID=@ID+1
--Ϊ�˿��ظ�ִ�У�����ǰ��ɾ��
--ɾ������ֵ���й��ڱ�Ӧ�õ�����(�˲���ֵ�����ֶ���֯)
DELETE FROM Base_ProfileValue WHERE profile in (SELECT ID FROM Base_Profile WHERE [ID] = @ID )
--ɾ���������й��ڱ�Ӧ�õ�����(������֯���ô˲�����)
DELETE FROM Base_Profile WHERE [ID] = @ID
--ɾ������(����)���й��ڱ�Ӧ�õ�����
DELETE FROM Base_Profile_Trl WHERE ID not in (select ID from Base_Profile )

INSERT INTO Base_Profile (ID, CreatedOn, CreatedBy, ModifiedOn,ModifiedBy,ProfileValueType,SubTypeName,DefaultValue,Code,[Application],ControlScope,SensitiveType ,ReferenceID)
  VALUES (@ID ,GETDATE(),@CreatedBy ,NULL,NULL ,3,NULL,'','FT_Ship',@Application ,1,4,null)				 
INSERT INTO Base_Profile_Trl (SysMLFlag,ID, [Description],[Name],ProfileGroup)
                      VALUES ('zh-CN',@ID,'������ʹ��','�ʼ��������Ƴ���','��óҵ��')
	 --6���ʼ����������ջ�
--��������ʱ��@ID����
set @ID=@ID+1
--Ϊ�˿��ظ�ִ�У�����ǰ��ɾ��
--ɾ������ֵ���й��ڱ�Ӧ�õ�����(�˲���ֵ�����ֶ���֯)
DELETE FROM Base_ProfileValue WHERE profile in (SELECT ID FROM Base_Profile WHERE [ID] = @ID )
--ɾ���������й��ڱ�Ӧ�õ�����(������֯���ô˲�����)
DELETE FROM Base_Profile WHERE [ID] = @ID
--ɾ������(����)���й��ڱ�Ӧ�õ�����
DELETE FROM Base_Profile_Trl WHERE ID not in (select ID from Base_Profile )				  	 

					  INSERT INTO Base_Profile (ID, CreatedOn, CreatedBy, ModifiedOn,ModifiedBy,ProfileValueType,SubTypeName,DefaultValue,Code,[Application],ControlScope,SensitiveType ,ReferenceID)
                 VALUES (@ID ,GETDATE(),@CreatedBy ,NULL,NULL ,3,NULL,'','FT_TabkeGood',@Application ,1,4,null)				 
INSERT INTO Base_Profile_Trl (SysMLFlag,ID, [Description],[Name],ProfileGroup)
                      VALUES ('zh-CN',@ID,'������ʹ��','�ʼ����������ջ�','��óҵ��')
 --7���ʼ��������Ʒ���
--��������ʱ��@ID����
set @ID=@ID+1
--Ϊ�˿��ظ�ִ�У�����ǰ��ɾ��
--ɾ������ֵ���й��ڱ�Ӧ�õ�����(�˲���ֵ�����ֶ���֯)
DELETE FROM Base_ProfileValue WHERE profile in (SELECT ID FROM Base_Profile WHERE [ID] = @ID )
--ɾ���������й��ڱ�Ӧ�õ�����(������֯���ô˲�����)
DELETE FROM Base_Profile WHERE [ID] = @ID
--ɾ������(����)���й��ڱ�Ӧ�õ�����
DELETE FROM Base_Profile_Trl WHERE ID not in (select ID from Base_Profile )		
					
					  INSERT INTO Base_Profile (ID, CreatedOn, CreatedBy, ModifiedOn,ModifiedBy,ProfileValueType,SubTypeName,DefaultValue,Code,[Application],ControlScope,SensitiveType ,ReferenceID)
                 VALUES (@ID ,GETDATE(),@CreatedBy ,NULL,NULL ,3,NULL,'','FT_Shipments',@Application ,1,4,null)				 
INSERT INTO Base_Profile_Trl (SysMLFlag,ID, [Description],[Name],ProfileGroup)
                      VALUES ('zh-CN',@ID,'������ʹ��','�ʼ��������Ʒ���','��óҵ��')
--8���ʼ�������������
--��������ʱ��@ID����
set @ID=@ID+1
--Ϊ�˿��ظ�ִ�У�����ǰ��ɾ��
--ɾ������ֵ���й��ڱ�Ӧ�õ�����(�˲���ֵ�����ֶ���֯)
DELETE FROM Base_ProfileValue WHERE profile in (SELECT ID FROM Base_Profile WHERE [ID] = @ID )
--ɾ���������й��ڱ�Ӧ�õ�����(������֯���ô˲�����)
DELETE FROM Base_Profile WHERE [ID] = @ID
--ɾ������(����)���й��ڱ�Ӧ�õ�����
DELETE FROM Base_Profile_Trl WHERE ID not in (select ID from Base_Profile )						    

 INSERT INTO Base_Profile (ID, CreatedOn, CreatedBy, ModifiedOn,ModifiedBy,ProfileValueType,SubTypeName,DefaultValue,Code,[Application],ControlScope,SensitiveType ,ReferenceID)
                 VALUES (@ID ,GETDATE(),@CreatedBy ,NULL,NULL ,3,NULL,'','FT_Picking',@Application ,1,4,null)				 
INSERT INTO Base_Profile_Trl (SysMLFlag,ID, [Description],[Name],ProfileGroup)
                      VALUES ('zh-CN',@ID,'������ʹ��','�ʼ�������������','��óҵ��')
 

GO


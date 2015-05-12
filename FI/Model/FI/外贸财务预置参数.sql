declare @Application bigint
declare @CreatedBy nvarchar(20)
declare @ID bigint

 --1������ϵ�� 
--����Ӧ�õ�ID
set @Application=80011
--���ô�������
set @CreatedBy ='YuNeng'
--Ԥ�ò����ĳ�ʼID(������ʱ����+01������)
set @ID=201412290913
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
VALUES (@ID ,GETDATE(),@CreatedBy ,NULL,NULL ,2,'','0','FIBonusCoefficient',@Application,1,4,'')
 
INSERT INTO Base_Profile_Trl (SysMLFlag,ID, [Description],[Name],ProfileGroup)
VALUES ('zh-CN',@ID,'����ɹ�ҵ��Ա����ʱ��Ҫ','����ϵ��','��ó����')


 --2������ϵ��
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
VALUES (@ID ,GETDATE(),@CreatedBy ,NULL,NULL ,2,'','0','FIDegradationCoefficient',@Application,1,4,'')
 
INSERT INTO Base_Profile_Trl (SysMLFlag,ID, [Description],[Name],ProfileGroup)
VALUES ('zh-CN',@ID,'����ɹ�ҵ��Ա����ʱ��Ҫ','����ϵ��','��ó����')

 --3����װҵ��Ա����ϵ��
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
VALUES (@ID ,GETDATE(),@CreatedBy ,NULL,NULL ,2,'','0','FIPackaingBonusCoefficient',@Application,1,4,'')
 
INSERT INTO Base_Profile_Trl (SysMLFlag,ID, [Description],[Name],ProfileGroup)
VALUES ('zh-CN',@ID,'�����װҵ��Ա����ʱ����','��װ����ϵ��','��óҵ��')

 --4��������׼����
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
VALUES (@ID ,GETDATE(),@CreatedBy ,NULL,NULL ,1,'','0','FIDeliveryExpectDay',@Application,1,4,'')
 
INSERT INTO Base_Profile_Trl (SysMLFlag,ID, [Description],[Name],ProfileGroup)
VALUES ('zh-CN',@ID,'����ҵ��Ա����ʱ��Ҫ','������׼����','��ó����')


GO


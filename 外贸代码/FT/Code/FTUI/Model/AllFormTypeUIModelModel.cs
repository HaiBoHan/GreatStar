#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.GS.FT.AllFormTypeUIModel
{
	[Serializable]
	public partial class AllFormTypeUIModelModel : UIModel
	{
		#region Constructor
		public AllFormTypeUIModelModel() : base("AllFormTypeUIModel")
		{
			InitClass();
			this.SetResourceInfo("b41f3463-b0d8-4b2f-af65-c956f5930979");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private AllFormTypeUIModelModel(bool isInit) : base("AllFormTypeUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new AllFormTypeUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private AllFormTypeView viewAllFormType;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public AllFormTypeView AllFormType
		{
			get { return (AllFormTypeView)this["AllFormType"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewAllFormType = new AllFormTypeView(this);
			this.viewAllFormType.SetResourceInfo("7f5487ca-1593-4a44-b641-16a009974c1e");
			this.Views.Add(this.viewAllFormType);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.GS.FT.FTUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class AllFormTypeView : UIView
	{
		#region Constructor
		public AllFormTypeView(IUIModel model) : base(model,"AllFormType","UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private AllFormTypeView():base(null,"AllFormType","UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new AllFormTypeView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}
		public IUIField FieldCreatedOn
		{
			get { return this.Fields["CreatedOn"]; }
		}
		public IUIField FieldCreatedBy
		{
			get { return this.Fields["CreatedBy"]; }
		}
		public IUIField FieldModifiedOn
		{
			get { return this.Fields["ModifiedOn"]; }
		}
		public IUIField FieldModifiedBy
		{
			get { return this.Fields["ModifiedBy"]; }
		}
		public IUIField FieldSysVersion
		{
			get { return this.Fields["SysVersion"]; }
		}
		public IUIField FieldConfirmType
		{
			get { return this.Fields["ConfirmType"]; }
		}
		public IUIField FieldWorkFlowCode
		{
			get { return this.Fields["WorkFlowCode"]; }
		}
		public IUIField FieldIsRAMADoc
		{
			get { return this.Fields["IsRAMADoc"]; }
		}
		public IUIField FieldIsAMADoc
		{
			get { return this.Fields["IsAMADoc"]; }
		}
		public IUIField FieldIsRMADoc
		{
			get { return this.Fields["IsRMADoc"]; }
		}
		public IUIField FieldDocHeaderSequenceStyle
		{
			get { return this.Fields["DocHeaderSequenceStyle"]; }
		}
		public IUIField FieldDocHeaderSequence
		{
			get { return this.Fields["DocHeaderSequence"]; }
		}
		public IUIField FieldDocHeaderSequence_Code
		{
			get { return this.Fields["DocHeaderSequence_Code"]; }
		}
		public IUIField FieldDocHeaderSequence_Name
		{
			get { return this.Fields["DocHeaderSequence_Name"]; }
		}
		public IUIField FieldPrintStyle
		{
			get { return this.Fields["PrintStyle"]; }
		}
		public IUIField FieldMaxAmountOfPrint
		{
			get { return this.Fields["MaxAmountOfPrint"]; }
		}
		public IUIField FieldIsCopyPrinted
		{
			get { return this.Fields["IsCopyPrinted"]; }
		}
		public IUIField FieldPrintTemplate
		{
			get { return this.Fields["PrintTemplate"]; }
		}
		public IUIField FieldBusinessType
		{
			get { return this.Fields["BusinessType"]; }
		}
		public IUIField FieldCode
		{
			get { return this.Fields["Code"]; }
		}
		public IUIField FieldName
		{
			get { return this.Fields["Name"]; }
		}
		public IUIField FieldShortName
		{
			get { return this.Fields["ShortName"]; }
		}
		public IUIField FieldDescription
		{
			get { return this.Fields["Description"]; }
		}
		public IUIField FieldEffective_IsEffective
		{
			get { return this.Fields["Effective_IsEffective"]; }
		}
		public IUIField FieldEffective_EffectiveDate
		{
			get { return this.Fields["Effective_EffectiveDate"]; }
		}
		public IUIField FieldEffective_DisableDate
		{
			get { return this.Fields["Effective_DisableDate"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg1
		{
			get { return this.Fields["DescFlexField_PubDescSeg1"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg2
		{
			get { return this.Fields["DescFlexField_PubDescSeg2"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg3
		{
			get { return this.Fields["DescFlexField_PubDescSeg3"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg4
		{
			get { return this.Fields["DescFlexField_PubDescSeg4"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg5
		{
			get { return this.Fields["DescFlexField_PubDescSeg5"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg6
		{
			get { return this.Fields["DescFlexField_PubDescSeg6"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg7
		{
			get { return this.Fields["DescFlexField_PubDescSeg7"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg8
		{
			get { return this.Fields["DescFlexField_PubDescSeg8"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg9
		{
			get { return this.Fields["DescFlexField_PubDescSeg9"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg10
		{
			get { return this.Fields["DescFlexField_PubDescSeg10"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg11
		{
			get { return this.Fields["DescFlexField_PubDescSeg11"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg12
		{
			get { return this.Fields["DescFlexField_PubDescSeg12"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg13
		{
			get { return this.Fields["DescFlexField_PubDescSeg13"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg14
		{
			get { return this.Fields["DescFlexField_PubDescSeg14"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg15
		{
			get { return this.Fields["DescFlexField_PubDescSeg15"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg16
		{
			get { return this.Fields["DescFlexField_PubDescSeg16"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg17
		{
			get { return this.Fields["DescFlexField_PubDescSeg17"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg18
		{
			get { return this.Fields["DescFlexField_PubDescSeg18"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg19
		{
			get { return this.Fields["DescFlexField_PubDescSeg19"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg20
		{
			get { return this.Fields["DescFlexField_PubDescSeg20"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg21
		{
			get { return this.Fields["DescFlexField_PubDescSeg21"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg22
		{
			get { return this.Fields["DescFlexField_PubDescSeg22"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg23
		{
			get { return this.Fields["DescFlexField_PubDescSeg23"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg24
		{
			get { return this.Fields["DescFlexField_PubDescSeg24"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg25
		{
			get { return this.Fields["DescFlexField_PubDescSeg25"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg26
		{
			get { return this.Fields["DescFlexField_PubDescSeg26"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg27
		{
			get { return this.Fields["DescFlexField_PubDescSeg27"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg28
		{
			get { return this.Fields["DescFlexField_PubDescSeg28"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg29
		{
			get { return this.Fields["DescFlexField_PubDescSeg29"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg30
		{
			get { return this.Fields["DescFlexField_PubDescSeg30"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg31
		{
			get { return this.Fields["DescFlexField_PubDescSeg31"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg32
		{
			get { return this.Fields["DescFlexField_PubDescSeg32"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg33
		{
			get { return this.Fields["DescFlexField_PubDescSeg33"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg34
		{
			get { return this.Fields["DescFlexField_PubDescSeg34"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg35
		{
			get { return this.Fields["DescFlexField_PubDescSeg35"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg36
		{
			get { return this.Fields["DescFlexField_PubDescSeg36"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg37
		{
			get { return this.Fields["DescFlexField_PubDescSeg37"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg38
		{
			get { return this.Fields["DescFlexField_PubDescSeg38"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg39
		{
			get { return this.Fields["DescFlexField_PubDescSeg39"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg40
		{
			get { return this.Fields["DescFlexField_PubDescSeg40"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg41
		{
			get { return this.Fields["DescFlexField_PubDescSeg41"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg42
		{
			get { return this.Fields["DescFlexField_PubDescSeg42"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg43
		{
			get { return this.Fields["DescFlexField_PubDescSeg43"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg44
		{
			get { return this.Fields["DescFlexField_PubDescSeg44"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg45
		{
			get { return this.Fields["DescFlexField_PubDescSeg45"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg46
		{
			get { return this.Fields["DescFlexField_PubDescSeg46"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg47
		{
			get { return this.Fields["DescFlexField_PubDescSeg47"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg48
		{
			get { return this.Fields["DescFlexField_PubDescSeg48"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg49
		{
			get { return this.Fields["DescFlexField_PubDescSeg49"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg50
		{
			get { return this.Fields["DescFlexField_PubDescSeg50"]; }
		}
		public IUIField FieldDescFlexField_ContextValue
		{
			get { return this.Fields["DescFlexField_ContextValue"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg1
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg1"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg2
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg2"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg3
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg3"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg4
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg4"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg5
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg5"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg6
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg6"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg7
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg7"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg8
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg8"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg9
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg9"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg10
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg10"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg11
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg11"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg12
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg12"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg13
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg13"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg14
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg14"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg15
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg15"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg16
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg16"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg17
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg17"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg18
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg18"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg19
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg19"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg20
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg20"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg21
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg21"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg22
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg22"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg23
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg23"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg24
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg24"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg25
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg25"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg26
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg26"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg27
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg27"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg28
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg28"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg29
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg29"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg30
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg30"]; }
		}
		public IUIField FieldDescFlexField_CombineName
		{
			get { return this.Fields["DescFlexField_CombineName"]; }
		}
		public IUIField FieldOrg
		{
			get { return this.Fields["Org"]; }
		}
		public IUIField FieldOrg_Code
		{
			get { return this.Fields["Org_Code"]; }
		}
		public IUIField FieldOrg_Name
		{
			get { return this.Fields["Org_Name"]; }
		}
		public IUIField FieldIsCreatedByPush
		{
			get { return this.Fields["IsCreatedByPush"]; }
		}
		public IUIField FieldIsDocNoEditable
		{
			get { return this.Fields["IsDocNoEditable"]; }
		}
		public IUIField FieldIsSaveSubmit
		{
			get { return this.Fields["IsSaveSubmit"]; }
		}
		public IUIField FieldPrintMode
		{
			get { return this.Fields["PrintMode"]; }
		}
		public IUIField FieldNetPrinterCode
		{
			get { return this.Fields["NetPrinterCode"]; }
		}
		public IUIField FieldNetPrinterName
		{
			get { return this.Fields["NetPrinterName"]; }
		}
		public IUIField FieldMasterSite
		{
			get { return this.Fields["MasterSite"]; }
		}
		public IUIField FieldApproveType
		{
			get { return this.Fields["ApproveType"]; }
		}
		public IUIField FieldIsApprovingCanModify
		{
			get { return this.Fields["IsApprovingCanModify"]; }
		}
		public IUIField FieldDocumentsType
		{
			get { return this.Fields["DocumentsType"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public AllFormTypeDefaultFilterFilter DefaultFilter
		{
			get { return (AllFormTypeDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","c1f85cae-aeb9-4b2b-bdf3-613b6c7e8ada");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","f675a2e4-daac-42cf-9bc3-46632445d656");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","efb5a311-32b5-4da0-8458-00bbf49e840f");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","8e41025b-14df-4a07-95bb-a07556df6c6c");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","92f3e8ce-05b2-4ab5-9bcf-c7310f28209a");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","90a34c6d-3c9b-45d7-bb69-c9d83f7c0375");
			UIModelRuntimeFactory.AddNewUIField(this,"ConfirmType", typeof(Int32), false,"0","UFIDA.U9.Base.Doc.ConfirmTypeEnum", "ConfirmType", true,true, false, "",false,(UIFieldType)2,"d232b8fb-1938-4ebe-a90c-41c911c0bc10","eea8a6b7-da6b-44f8-ae5b-48d9b63adbd0");
			UIModelRuntimeFactory.AddNewUIField(this,"WorkFlowCode", typeof(Guid), true,"","System.Guid", "WorkFlowCode", true,true, false, "",false,(UIFieldType)1,"2b057235-c58e-441e-9477-5e52fcb7f95b","72ba1902-dd55-42cb-89aa-ee4652e84395");
			UIModelRuntimeFactory.AddNewUIField(this,"IsRAMADoc", typeof(Boolean), true,"true","System.Boolean", "IsRAMADoc", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","cddc5895-d342-4788-b871-d7f10fe7cec0");
			UIModelRuntimeFactory.AddNewUIField(this,"IsAMADoc", typeof(Boolean), true,"false","System.Boolean", "IsAMADoc", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","d1e982ef-6144-4e9f-a1ac-fbedca0fdbb9");
			UIModelRuntimeFactory.AddNewUIField(this,"IsRMADoc", typeof(Boolean), true,"false","System.Boolean", "IsRMADoc", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","bf25a85d-64d4-4dad-8f64-fd1ef9220697");
			UIModelRuntimeFactory.AddNewUIField(this,"DocHeaderSequenceStyle", typeof(Int32), false,"0","UFIDA.U9.Base.Doc.DocHeaderSequenceStyleEnum", "DocHeaderSequenceStyle", true,true, false, "",false,(UIFieldType)2,"dcf65e0a-1554-447b-b4c6-b3ec2951d965","5d10e4b8-6c1b-4f5a-9579-34ee6ddc65f2");
			UIModelRuntimeFactory.AddNewUIField(this,"DocHeaderSequence", typeof(Int64), true,"","UFIDA.U9.Base.Sequence.SequenceDef", "DocHeaderSequence", true,true, false, "",false,(UIFieldType)4,"b2c49db4-e8ac-4ff3-955c-aae5a203ecef","1a22f0e8-de2d-43f7-9b3a-938d32eda721");
			UIModelRuntimeFactory.AddNewUIField(this,"DocHeaderSequence_Code", typeof(String), false,"","System.String", "DocHeaderSequence.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2d246ccb-5188-4416-aedf-90be684c7512");
			UIModelRuntimeFactory.AddNewUIField(this,"DocHeaderSequence_Name", typeof(String), true,"","System.String", "DocHeaderSequence.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","03c1e6dc-2c94-4dd4-a7a0-54da09a077ab");
			UIModelRuntimeFactory.AddNewUIField(this,"PrintStyle", typeof(Int32), false,"0","UFIDA.U9.Base.Doc.PrintStyleEnum", "PrintStyle", true,true, false, "",false,(UIFieldType)2,"25989155-e5ec-47c2-9347-2d789440602f","b3acbfa6-b0f4-43a0-b215-9aa7c782f2d9");
			UIModelRuntimeFactory.AddNewUIField(this,"MaxAmountOfPrint", typeof(Int32), false,"0","System.Int32", "MaxAmountOfPrint", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","42bce408-784c-44cb-b289-8f90ef76a737");
			UIModelRuntimeFactory.AddNewUIField(this,"IsCopyPrinted", typeof(Boolean), false,"false","System.Boolean", "IsCopyPrinted", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","e5dae238-2e62-4e41-afd0-9665e858c66f");
			UIModelRuntimeFactory.AddNewUIField(this,"PrintTemplate", typeof(Int64), true,"","UFSoft.UBF.ExportService.PrintReferenceBE.PrintTemplate", "PrintTemplate", true,true, false, "",false,(UIFieldType)4,"dd17d05e-e2c0-48c5-802a-f1be67ee311e","3d7c519d-e46d-4863-b0b3-745f8621f064");
			UIModelRuntimeFactory.AddNewUIField(this,"BusinessType", typeof(Int32), true,"-1","UFIDA.U9.Base.Doc.BusinessTypeEnum", "BusinessType", true,true, false, "",false,(UIFieldType)2,"fc998dce-aa68-4d34-8557-a0afdf601afe","32cd06ab-302d-4184-8498-dd8e2d34ad4c");
			UIModelRuntimeFactory.AddNewUIField(this,"Code", typeof(String), false,"","System.String", "Code", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6ab0f2ff-d66a-4de4-814f-611290814dc8");
			UIModelRuntimeFactory.AddNewUIField(this,"Name", typeof(String), true,"","System.String", "Name", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","15589a37-26f9-447c-b026-53922285fd4c");
			UIModelRuntimeFactory.AddNewUIField(this,"ShortName", typeof(String), true,"","System.String", "ShortName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a3f9853d-9742-45bc-9712-1fa0be855f2d");
			UIModelRuntimeFactory.AddNewUIField(this,"Description", typeof(String), true,"","System.String", "Description", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f8b65dd4-93c1-479e-af45-c26b12634bfe");
			UIModelRuntimeFactory.AddNewUIField(this,"Effective_IsEffective", typeof(Boolean), true,"true","System.Boolean", "Effective.IsEffective", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","e39f6af9-91f4-43e4-bb57-2a3d931ea23b");
			UIModelRuntimeFactory.AddNewUIField(this,"Effective_EffectiveDate", typeof(DateTime), true,"2000-01-01","System.Date", "Effective.EffectiveDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","1df085a9-f5c2-453d-bb7e-7d5ab3b724f2");
			UIModelRuntimeFactory.AddNewUIField(this,"Effective_DisableDate", typeof(DateTime), true,"9999-12-31","System.Date", "Effective.DisableDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","a88b338f-dcc7-41da-af64-c2e36e61ad84");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","390a09af-10c0-4b4b-a27a-8fb8d025fc0c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5c9503ec-ff2d-4f9b-85dc-f7b1a70843a8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","718e828d-f522-436e-a49e-66ebd17c6839");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","66a081e7-a24d-4750-86eb-5bbfd68c0796");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8930ee71-0500-4c9f-b0b5-afb8e67daba8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1ff1232e-e140-4e24-9974-c533da4a0648");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4218c801-a05c-4575-8ae0-a82a2081fa0e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","39bccb87-dd95-487f-895c-ce2ed85d1a53");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c399ed0b-a64c-4481-b544-f053e3435510");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f271984b-2b35-4832-808a-9425936c6341");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","67d47bed-9c83-43e9-8165-5e0535c06502");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dbaaacb5-490b-4629-93f4-569293e1f905");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b68b1d66-89b5-4669-b664-d68d7e6184d4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a5ecf7d0-aad3-4070-a69c-d62f463efa83");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","77073b55-6234-4fd7-8e53-45541da51d1b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","69cc0dc8-301c-4d22-ad0a-97096a1a69cc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c05c9eb6-312b-4cfe-acdb-ab961e1ef848");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0919d282-353c-49a6-b8ce-02ea96799b8f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2d9364e3-6ada-4e80-ba04-83d00e82a992");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4979c859-4000-4e5e-b699-5941c272a7fc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","37497d0d-d08b-4bc9-8f08-81866816c456");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e2ad0528-8365-4bab-9f26-e17a147578c5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","24a0cbc5-1929-4639-84d9-340cc372fd29");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","25c220bb-de47-4aef-a2a1-91d71e22355d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","07ed507c-b450-4367-acec-f895efde8329");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7adbebc7-b2f1-469a-a6b6-2c62ad2052c8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","587e957a-5856-42fa-90b8-c24ac2379fc8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6c8c714a-e4a3-45d9-b7e4-a1291a44a34a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","68bd19c7-c41c-4952-96db-10b035a49e68");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8bbf5365-6bfb-4e3d-853d-9c7042644ac6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg31", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg31", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5be04cdc-ccd6-4970-b96b-91459b9272c3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg32", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg32", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3811c378-6029-4ac3-a944-24c1ce4b1986");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg33", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg33", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0b20e4d8-4e1c-4bb1-b457-2c7c9754caee");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg34", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg34", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7fcd3142-d121-42e2-84d3-b659d48cb91c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg35", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg35", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b1b4c356-d953-48b7-842e-b0a046937bba");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg36", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg36", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0b17205d-a131-40be-9962-8b13de658f36");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg37", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg37", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7236c62c-4fba-4e40-a634-a225b456a459");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg38", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg38", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","49a080d8-2e0b-4978-91cf-6ef4ca365ece");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg39", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg39", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","aa9e953d-7ba7-4971-9a53-7ba1481a852b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg40", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg40", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ce9930de-960a-44a9-9d01-3edd4857b823");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg41", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg41", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","25c28be4-b759-4fef-9cba-655f53e19686");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg42", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg42", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5259bb5a-39a3-4a14-8913-580a1b974100");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg43", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg43", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bac3137b-6e8b-4cba-8415-56901c724d18");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg44", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg44", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5a17e3fa-100c-431c-a6dd-e7bfb176f5eb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg45", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg45", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9d12b5d0-873c-467f-a24e-dae0e131298f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg46", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg46", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f81041ca-b2d1-4ea1-aa5c-9b0d17b91fdd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg47", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg47", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","07ae326d-e22a-4e76-9dbe-3d66679abee8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg48", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg48", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b2008ceb-bd09-41eb-93f8-6d19d29a442c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg49", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg49", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a3e54cb5-af42-48e9-b135-5490545a0f31");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg50", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg50", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6d151590-ce7a-4cb9-948f-709448da5c4d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_ContextValue", typeof(String), true,"","System.String", "DescFlexField.ContextValue", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7854cab2-eb50-4c14-93f8-f2e030494449");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","25c24548-b83f-4e7e-8e37-2eb0f855d118");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","28659893-a5a1-4db3-87c1-8c02e754a610");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","14826a7c-4657-4f8b-b8db-827b0785b814");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","47ef573a-e98c-491a-a9e5-3332f9b3112d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8356f66e-ef55-400f-a7f0-d124bfdaf08b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f3588f35-6690-41c7-8760-54283528c051");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c7faad74-b7d4-4a5b-9c50-ede93a266e6f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b8df287f-4369-4cec-9021-b242ef608474");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2ca13883-e61a-480e-a79a-f2212acec6d3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8e12b54b-a6fb-4132-985f-c00102590160");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4606f767-0cf6-46b1-8609-9cbabdea9d4c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b8fb3877-cdd4-4edc-bd2f-35aede565ec2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ff12810d-36bc-492f-b161-22fcad5e7697");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d66c1176-832d-4410-9d11-9dbbb9cb5b1e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","784d87fc-9414-4588-9dd9-cb97124d7fbd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b5268830-26c2-4153-8943-e06b417abb65");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","186d7166-e131-4c53-872d-9ec42998608d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","451bab1b-93e3-4799-9fe1-4ea2ff91e495");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ddbf4abc-4396-4ee3-8888-5cbd547f0f28");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d29fec64-186f-4de1-b63c-28a7a7ca3a58");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e5b5e70d-8913-4bb1-8569-5adce778242b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c935cad8-00e8-4962-928c-9d50f72b8c57");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","67a25f27-8813-47be-a091-00de016c59b0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5d921334-75fe-41d4-aa1c-c49a4ef0becb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","299e6956-4c3a-4049-93d0-24bae8f1d82b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7b99764f-0d38-4b26-a160-eb426322df37");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b2f890c8-b944-4942-b78d-43777b7283b4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","60851134-6854-4d33-9e63-261289b9826f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","173dba2e-9359-49ca-89e0-38a621da2c95");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fbb60e80-0e89-4521-8a86-750d5a6ef79b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_CombineName", typeof(String), true,"","System.String", "DescFlexField.CombineName", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","19b6bee3-3b84-40d1-8056-f5419c9d8837");
			UIModelRuntimeFactory.AddNewUIField(this,"Org", typeof(Int64), false,"","UFIDA.U9.Base.Organization.Organization", "Org", true,true, false, "",false,(UIFieldType)4,"73eb56da-f25a-4636-94e7-61b0cb4b7784","cc59eaf9-7af8-4a09-9901-6eb2418ac2f2");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Code", typeof(String), false,"","System.String", "Org.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b289bfb9-acac-4382-8382-829a84b5169f");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Name", typeof(String), true,"","System.String", "Org.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f0ef02e7-eb17-4ddd-b4d1-e605c608ebf7");
			UIModelRuntimeFactory.AddNewUIField(this,"IsCreatedByPush", typeof(Boolean), true,"false","System.Boolean", "IsCreatedByPush", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","69f41bea-f61f-4fb2-9a1f-611362814137");
			UIModelRuntimeFactory.AddNewUIField(this,"IsDocNoEditable", typeof(Boolean), true,"false","System.Boolean", "IsDocNoEditable", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","234df76e-e248-409c-bba7-64f4bb68f91f");
			UIModelRuntimeFactory.AddNewUIField(this,"IsSaveSubmit", typeof(Boolean), true,"false","System.Boolean", "IsSaveSubmit", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","287ae189-f782-4b08-a331-717c8a06c38d");
			UIModelRuntimeFactory.AddNewUIField(this,"PrintMode", typeof(Int32), false,"0","UFIDA.U9.Base.Doc.PrintModeEnum", "PrintMode", true,true, false, "",false,(UIFieldType)2,"6862b23e-62fb-4453-9eed-4a2fad986a9f","f589993f-395c-4c48-babd-12e5a27111e3");
			UIModelRuntimeFactory.AddNewUIField(this,"NetPrinterCode", typeof(String), true,"","System.String", "NetPrinterCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","369efb28-3ca7-46bd-9a32-c3ef93615ecc");
			UIModelRuntimeFactory.AddNewUIField(this,"NetPrinterName", typeof(String), true,"","System.String", "NetPrinterName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c87c6a47-f600-4dd4-8cb7-1c22be7a1f12");
			UIModelRuntimeFactory.AddNewUIField(this,"MasterSite", typeof(String), true,"","System.String", "MasterSite", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","73dad923-11e1-4a0e-9aa2-fc98353d1c46");
			UIModelRuntimeFactory.AddNewUIField(this,"ApproveType", typeof(Int32), true,"-1","UFIDA.U9.Base.Doc.ApproveTypeEnum", "ApproveType", true,true, false, "",false,(UIFieldType)2,"d4b6e1a9-d80d-4516-8316-4b1d436cd449","cfa2ad5f-9897-4607-8cdb-fb282d0910f5");
			UIModelRuntimeFactory.AddNewUIField(this,"IsApprovingCanModify", typeof(Boolean), false,"true","System.Boolean", "IsApprovingCanModify", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","80434f05-3c5d-4ed3-bc80-52452b7d90a3");
			UIModelRuntimeFactory.AddNewUIField(this,"DocumentsType", typeof(Int32), true,"0","UFIDA.U9.Cust.GS.FT.AllEnumBE.DocTypeEnum", "DocumentsType", true,true, false, "",false,(UIFieldType)2,"70a50214-07e3-4d20-88f7-0f05b4ce1221","592c4640-20c6-414a-9e2b-b861fb15eb1b");


			this.CurrentFilter = new AllFormTypeDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new AllFormTypeRecord(builder);
		}
		#endregion

		#region new method
		public new AllFormTypeRecord FocusedRecord
		{
			get { return (AllFormTypeRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new AllFormTypeRecord AddNewUIRecord()
		{	
			return (AllFormTypeRecord)base.AddNewUIRecord();
		}
		public new AllFormTypeRecord NewUIRecord()
		{	
			return (AllFormTypeRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class AllFormTypeRecord : UIRecord
	{
		#region Constructor
		public AllFormTypeRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private AllFormTypeView uiviewAllFormType
		{
			get { return (AllFormTypeView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new AllFormTypeRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewAllFormType.FieldID);
			}
			set{
				this[this.uiviewAllFormType.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewAllFormType.FieldCreatedOn);
			}
			set{
				this[this.uiviewAllFormType.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldCreatedBy);
			}
			set{
				this[this.uiviewAllFormType.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewAllFormType.FieldModifiedOn);
			}
			set{
				this[this.uiviewAllFormType.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldModifiedBy);
			}
			set{
				this[this.uiviewAllFormType.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewAllFormType.FieldSysVersion);
			}
			set{
				this[this.uiviewAllFormType.FieldSysVersion] = value;
			}
		}
		
		
		public  Int32 ConfirmType
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldConfirmType] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewAllFormType.FieldConfirmType);
			}
			set{
				this[this.uiviewAllFormType.FieldConfirmType] = value;
			}
		}
		
		
		public  Guid WorkFlowCode
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldWorkFlowCode] ;
				//return (Guid)value;
				return GetValue<Guid>(this.uiviewAllFormType.FieldWorkFlowCode);
			}
			set{
				this[this.uiviewAllFormType.FieldWorkFlowCode] = value;
			}
		}
		
		
		public  Boolean? IsRAMADoc
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldIsRAMADoc] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewAllFormType.FieldIsRAMADoc);
			}
			set{
				this[this.uiviewAllFormType.FieldIsRAMADoc] = value;
			}
		}
		
		
		public  Boolean? IsAMADoc
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldIsAMADoc] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewAllFormType.FieldIsAMADoc);
			}
			set{
				this[this.uiviewAllFormType.FieldIsAMADoc] = value;
			}
		}
		
		
		public  Boolean? IsRMADoc
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldIsRMADoc] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewAllFormType.FieldIsRMADoc);
			}
			set{
				this[this.uiviewAllFormType.FieldIsRMADoc] = value;
			}
		}
		
		
		public  Int32 DocHeaderSequenceStyle
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDocHeaderSequenceStyle] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewAllFormType.FieldDocHeaderSequenceStyle);
			}
			set{
				this[this.uiviewAllFormType.FieldDocHeaderSequenceStyle] = value;
			}
		}
		
		
		public  Int64? DocHeaderSequence
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDocHeaderSequence] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewAllFormType.FieldDocHeaderSequence);
			}
			set{
				this[this.uiviewAllFormType.FieldDocHeaderSequence] = value;
			}
		}
		
		
		public  String DocHeaderSequence_Code
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDocHeaderSequence_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDocHeaderSequence_Code);
			}
			set{
				this[this.uiviewAllFormType.FieldDocHeaderSequence_Code] = value;
			}
		}
		
		
		public  String DocHeaderSequence_Name
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDocHeaderSequence_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDocHeaderSequence_Name);
			}
			set{
				this[this.uiviewAllFormType.FieldDocHeaderSequence_Name] = value;
			}
		}
		
		
		public  Int32 PrintStyle
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldPrintStyle] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewAllFormType.FieldPrintStyle);
			}
			set{
				this[this.uiviewAllFormType.FieldPrintStyle] = value;
			}
		}
		
		
		public  Int32 MaxAmountOfPrint
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldMaxAmountOfPrint] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewAllFormType.FieldMaxAmountOfPrint);
			}
			set{
				this[this.uiviewAllFormType.FieldMaxAmountOfPrint] = value;
			}
		}
		
		
		public  Boolean IsCopyPrinted
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldIsCopyPrinted] ;
				//return (Boolean)value;
				return GetValue<Boolean>(this.uiviewAllFormType.FieldIsCopyPrinted);
			}
			set{
				this[this.uiviewAllFormType.FieldIsCopyPrinted] = value;
			}
		}
		
		
		public  Int64? PrintTemplate
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldPrintTemplate] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewAllFormType.FieldPrintTemplate);
			}
			set{
				this[this.uiviewAllFormType.FieldPrintTemplate] = value;
			}
		}
		
		
		public  Int32? BusinessType
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldBusinessType] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewAllFormType.FieldBusinessType);
			}
			set{
				this[this.uiviewAllFormType.FieldBusinessType] = value;
			}
		}
		
		
		public  String Code
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldCode);
			}
			set{
				this[this.uiviewAllFormType.FieldCode] = value;
			}
		}
		
		
		public new String Name
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldName);
			}
			set{
				this[this.uiviewAllFormType.FieldName] = value;
			}
		}
		
		
		public  String ShortName
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldShortName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldShortName);
			}
			set{
				this[this.uiviewAllFormType.FieldShortName] = value;
			}
		}
		
		
		public  String Description
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescription] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescription);
			}
			set{
				this[this.uiviewAllFormType.FieldDescription] = value;
			}
		}
		
		
		public  Boolean? Effective_IsEffective
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldEffective_IsEffective] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewAllFormType.FieldEffective_IsEffective);
			}
			set{
				this[this.uiviewAllFormType.FieldEffective_IsEffective] = value;
			}
		}
		
		
		public  DateTime? Effective_EffectiveDate
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldEffective_EffectiveDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewAllFormType.FieldEffective_EffectiveDate);
			}
			set{
				this[this.uiviewAllFormType.FieldEffective_EffectiveDate] = value;
			}
		}
		
		
		public  DateTime? Effective_DisableDate
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldEffective_DisableDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewAllFormType.FieldEffective_DisableDate);
			}
			set{
				this[this.uiviewAllFormType.FieldEffective_DisableDate] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg1
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg1);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg2
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg2);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg3
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg3);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg4
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg4);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg5
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg5);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg6
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg6);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg7
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg7);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg8
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg8);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg9
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg9);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg10
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg10);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg11
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg11);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg12
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg12);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg13
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg13);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg14
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg14);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg15
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg15);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg16
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg16);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg17
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg17);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg18
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg18);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg19
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg19);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg20
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg20);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg21
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg21);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg22
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg22);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg23
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg23);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg24
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg24);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg25
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg25);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg26
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg26);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg27
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg27);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg28
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg28);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg29
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg29);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg30
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg30);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg31
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg31] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg31);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg31] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg32
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg32] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg32);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg32] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg33
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg33] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg33);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg33] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg34
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg34] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg34);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg34] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg35
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg35] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg35);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg35] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg36
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg36] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg36);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg36] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg37
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg37] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg37);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg37] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg38
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg38] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg38);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg38] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg39
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg39] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg39);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg39] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg40
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg40] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg40);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg40] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg41
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg41] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg41);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg41] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg42
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg42] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg42);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg42] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg43
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg43] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg43);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg43] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg44
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg44] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg44);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg44] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg45
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg45] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg45);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg45] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg46
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg46] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg46);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg46] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg47
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg47] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg47);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg47] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg48
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg48] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg48);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg48] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg49
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg49] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg49);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg49] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg50
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg50] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PubDescSeg50);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PubDescSeg50] = value;
			}
		}
		
		
		public  String DescFlexField_ContextValue
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_ContextValue] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_ContextValue);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_ContextValue] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg1
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg1);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg2
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg2);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg3
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg3);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg4
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg4);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg5
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg5);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg6
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg6);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg7
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg7);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg8
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg8);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg9
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg9);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg10
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg10);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg11
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg11);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg12
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg12);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg13
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg13);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg14
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg14);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg15
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg15);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg16
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg16);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg17
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg17);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg18
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg18);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg19
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg19);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg20
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg20);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg21
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg21);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg22
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg22);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg23
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg23);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg24
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg24);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg25
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg25);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg26
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg26);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg27
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg27);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg28
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg28);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg29
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg29);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg30
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg30);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_PrivateDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_CombineName
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDescFlexField_CombineName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldDescFlexField_CombineName);
			}
			set{
				this[this.uiviewAllFormType.FieldDescFlexField_CombineName] = value;
			}
		}
		
		
		public  Int64 Org
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldOrg] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewAllFormType.FieldOrg);
			}
			set{
				this[this.uiviewAllFormType.FieldOrg] = value;
			}
		}
		
		
		public  String Org_Code
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldOrg_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldOrg_Code);
			}
			set{
				this[this.uiviewAllFormType.FieldOrg_Code] = value;
			}
		}
		
		
		public  String Org_Name
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldOrg_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldOrg_Name);
			}
			set{
				this[this.uiviewAllFormType.FieldOrg_Name] = value;
			}
		}
		
		
		public  Boolean? IsCreatedByPush
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldIsCreatedByPush] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewAllFormType.FieldIsCreatedByPush);
			}
			set{
				this[this.uiviewAllFormType.FieldIsCreatedByPush] = value;
			}
		}
		
		
		public  Boolean? IsDocNoEditable
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldIsDocNoEditable] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewAllFormType.FieldIsDocNoEditable);
			}
			set{
				this[this.uiviewAllFormType.FieldIsDocNoEditable] = value;
			}
		}
		
		
		public  Boolean? IsSaveSubmit
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldIsSaveSubmit] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewAllFormType.FieldIsSaveSubmit);
			}
			set{
				this[this.uiviewAllFormType.FieldIsSaveSubmit] = value;
			}
		}
		
		
		public  Int32 PrintMode
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldPrintMode] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewAllFormType.FieldPrintMode);
			}
			set{
				this[this.uiviewAllFormType.FieldPrintMode] = value;
			}
		}
		
		
		public  String NetPrinterCode
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldNetPrinterCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldNetPrinterCode);
			}
			set{
				this[this.uiviewAllFormType.FieldNetPrinterCode] = value;
			}
		}
		
		
		public  String NetPrinterName
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldNetPrinterName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldNetPrinterName);
			}
			set{
				this[this.uiviewAllFormType.FieldNetPrinterName] = value;
			}
		}
		
		
		public  String MasterSite
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldMasterSite] ;
				//return (String)value;
				return GetValue<String>(this.uiviewAllFormType.FieldMasterSite);
			}
			set{
				this[this.uiviewAllFormType.FieldMasterSite] = value;
			}
		}
		
		
		public  Int32? ApproveType
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldApproveType] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewAllFormType.FieldApproveType);
			}
			set{
				this[this.uiviewAllFormType.FieldApproveType] = value;
			}
		}
		
		
		public  Boolean IsApprovingCanModify
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldIsApprovingCanModify] ;
				//return (Boolean)value;
				return GetValue<Boolean>(this.uiviewAllFormType.FieldIsApprovingCanModify);
			}
			set{
				this[this.uiviewAllFormType.FieldIsApprovingCanModify] = value;
			}
		}
		
		
		public  Int32? DocumentsType
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldDocumentsType] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewAllFormType.FieldDocumentsType);
			}
			set{
				this[this.uiviewAllFormType.FieldDocumentsType] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class AllFormTypeDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public AllFormTypeDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private AllFormTypeDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new AllFormTypeDefaultFilterFilter();
		}
		#endregion

		#region property
		#endregion
		
		#region function
		private void InitClass()
		{
		}
		#endregion

	}



}
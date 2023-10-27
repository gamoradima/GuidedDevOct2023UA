namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyServiceSchema

	/// <exclude/>
	public class UsrRealtyServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyServiceSchema(UsrRealtyServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("01f69425-1aa6-48f9-ada3-4e1e12c80cfd");
			Name = "UsrRealtyService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("15b617c3-e473-4cbd-82ea-9a014ae25fb3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,187,216,116,177,249,98,147,194,133,141,23,155,47,108,185,176,21,196,220,123,97,195,197,14,133,11,187,46,236,187,176,69,193,89,153,43,47,49,55,181,184,32,49,57,85,33,36,181,168,40,177,56,63,173,68,207,57,63,47,45,51,189,180,40,177,36,51,63,79,161,154,139,179,180,56,51,47,93,33,184,178,184,36,53,215,154,139,147,171,22,0,115,10,57,112,89,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("01f69425-1aa6-48f9-ada3-4e1e12c80cfd"));
		}

		#endregion

	}

	#endregion

}


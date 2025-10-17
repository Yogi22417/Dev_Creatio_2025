namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrYachtEventSchema

	/// <exclude/>
	public class UsrYachtEventSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrYachtEventSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrYachtEventSchema(UsrYachtEventSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cdd2e6f8-0909-452e-abc6-ba0fca0dbc1c");
			Name = "UsrYachtEvent";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8e2fdced-bc24-4eba-9a94-c9fc0149d902");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,81,107,219,48,16,199,223,11,253,14,135,159,108,8,162,125,109,183,194,146,166,165,80,182,49,59,131,49,246,160,200,23,71,197,146,140,36,187,203,70,191,251,78,82,146,166,78,6,61,8,177,164,191,126,119,255,211,105,174,208,117,92,32,84,104,45,119,102,229,217,204,232,149,108,122,203,189,52,250,252,236,239,249,25,80,244,78,234,6,202,141,243,168,174,15,183,14,47,42,101,244,127,15,45,178,185,246,210,75,116,239,209,176,249,128,218,239,164,63,227,246,38,238,61,74,42,66,163,205,75,177,70,197,63,147,7,248,8,217,194,217,31,92,172,125,86,252,74,119,186,126,217,74,1,162,229,206,65,60,58,1,129,43,152,114,135,39,78,18,100,107,255,128,103,6,42,88,214,8,131,145,53,124,209,37,31,200,70,110,150,79,40,60,56,212,53,218,9,36,224,20,87,228,41,98,63,217,198,1,22,175,184,3,114,136,37,85,193,246,180,29,6,139,235,183,178,196,133,77,176,67,174,243,180,46,146,126,164,173,81,72,197,91,232,172,20,161,69,241,18,187,71,95,109,58,172,103,166,237,149,254,206,219,30,63,108,149,55,121,232,226,215,32,207,198,137,7,110,161,23,123,202,194,161,165,73,209,228,89,238,31,125,23,114,5,121,74,122,3,151,23,49,138,183,138,145,249,16,200,30,220,140,107,129,45,214,148,198,219,30,9,123,172,115,222,134,177,161,193,117,188,193,10,85,215,114,31,236,105,124,134,71,35,120,43,255,240,101,139,101,212,229,167,202,101,223,208,153,222,10,210,24,75,144,201,113,150,16,251,145,138,15,152,77,32,59,194,59,22,27,248,224,42,99,166,178,73,171,172,96,149,217,166,47,222,225,129,106,79,27,236,206,88,197,125,62,242,70,137,47,129,122,24,127,139,242,246,232,109,66,248,181,53,207,177,7,243,223,2,187,96,115,199,25,203,95,94,151,219,79,250,123,249,7,114,211,160,208,12,4,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a18e76ab-8fcd-606c-eccf-945d27158014"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("8e2fdced-bc24-4eba-9a94-c9fc0149d902"),
				CreatedInSchemaUId = new Guid("cdd2e6f8-0909-452e-abc6-ba0fca0dbc1c"),
				ModifiedInSchemaUId = new Guid("cdd2e6f8-0909-452e-abc6-ba0fca0dbc1c")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cdd2e6f8-0909-452e-abc6-ba0fca0dbc1c"));
		}

		#endregion

	}

	#endregion

}


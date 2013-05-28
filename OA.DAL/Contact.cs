using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
namespace CanYou.OA.DAL
{
	/// <summary>
	/// Strongly-typed collection for the Contact class.
	/// </summary>
    [Serializable]
	public partial class ContactCollection : ActiveList<Contact, ContactCollection>
	{	   
		public ContactCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ContactCollection</returns>
		public ContactCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Contact o = this[i];
                foreach (SubSonic.Where w in this.wheres)
                {
                    bool remove = false;
                    System.Reflection.PropertyInfo pi = o.GetType().GetProperty(w.ColumnName);
                    if (pi.CanRead)
                    {
                        object val = pi.GetValue(o, null);
                        switch (w.Comparison)
                        {
                            case SubSonic.Comparison.Equals:
                                if (!val.Equals(w.ParameterValue))
                                {
                                    remove = true;
                                }
                                break;
                        }
                    }
                    if (remove)
                    {
                        this.Remove(o);
                        break;
                    }
                }
            }
            return this;
        }
		
		
	}
	/// <summary>
	/// This is an ActiveRecord class which wraps the Contact_tb table.
	/// </summary>
	[Serializable]
	public partial class Contact : ActiveRecord<Contact>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Contact()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Contact(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Contact(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Contact(string columnName, object columnValue)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByParam(columnName,columnValue);
		}
		
		protected static void SetSQLProps() { GetTableSchema(); }
		
		#endregion
		
		#region Schema and Query Accessor	
		public static Query CreateQuery() { return new Query(Schema); }
		public static TableSchema.Table Schema
		{
			get
			{
				if (BaseSchema == null)
					SetSQLProps();
				return BaseSchema;
			}
		}
		
		private static void GetTableSchema() 
		{
			if(!IsSchemaInitialized)
			{
				//Schema declaration
				TableSchema.Table schema = new TableSchema.Table("Contact_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarContactId = new TableSchema.TableColumn(schema);
				colvarContactId.ColumnName = "ContactId";
				colvarContactId.DataType = DbType.Int32;
				colvarContactId.MaxLength = 0;
				colvarContactId.AutoIncrement = true;
				colvarContactId.IsNullable = false;
				colvarContactId.IsPrimaryKey = true;
				colvarContactId.IsForeignKey = false;
				colvarContactId.IsReadOnly = false;
				colvarContactId.DefaultSetting = @"";
				colvarContactId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarContactId);
				
				TableSchema.TableColumn colvarMobile = new TableSchema.TableColumn(schema);
				colvarMobile.ColumnName = "Mobile";
				colvarMobile.DataType = DbType.String;
				colvarMobile.MaxLength = 50;
				colvarMobile.AutoIncrement = false;
				colvarMobile.IsNullable = true;
				colvarMobile.IsPrimaryKey = false;
				colvarMobile.IsForeignKey = false;
				colvarMobile.IsReadOnly = false;
				colvarMobile.DefaultSetting = @"";
				colvarMobile.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMobile);
				
				TableSchema.TableColumn colvarOfficephone = new TableSchema.TableColumn(schema);
				colvarOfficephone.ColumnName = "Officephone";
				colvarOfficephone.DataType = DbType.String;
				colvarOfficephone.MaxLength = 50;
				colvarOfficephone.AutoIncrement = false;
				colvarOfficephone.IsNullable = true;
				colvarOfficephone.IsPrimaryKey = false;
				colvarOfficephone.IsForeignKey = false;
				colvarOfficephone.IsReadOnly = false;
				colvarOfficephone.DefaultSetting = @"";
				colvarOfficephone.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOfficephone);
				
				TableSchema.TableColumn colvarPhoneExt = new TableSchema.TableColumn(schema);
				colvarPhoneExt.ColumnName = "PhoneExt";
				colvarPhoneExt.DataType = DbType.String;
				colvarPhoneExt.MaxLength = 50;
				colvarPhoneExt.AutoIncrement = false;
				colvarPhoneExt.IsNullable = true;
				colvarPhoneExt.IsPrimaryKey = false;
				colvarPhoneExt.IsForeignKey = false;
				colvarPhoneExt.IsReadOnly = false;
				colvarPhoneExt.DefaultSetting = @"";
				colvarPhoneExt.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPhoneExt);
				
				TableSchema.TableColumn colvarHomephone = new TableSchema.TableColumn(schema);
				colvarHomephone.ColumnName = "Homephone";
				colvarHomephone.DataType = DbType.String;
				colvarHomephone.MaxLength = 50;
				colvarHomephone.AutoIncrement = false;
				colvarHomephone.IsNullable = true;
				colvarHomephone.IsPrimaryKey = false;
				colvarHomephone.IsForeignKey = false;
				colvarHomephone.IsReadOnly = false;
				colvarHomephone.DefaultSetting = @"";
				colvarHomephone.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHomephone);
				
				TableSchema.TableColumn colvarEmail = new TableSchema.TableColumn(schema);
				colvarEmail.ColumnName = "Email";
				colvarEmail.DataType = DbType.String;
				colvarEmail.MaxLength = 50;
				colvarEmail.AutoIncrement = false;
				colvarEmail.IsNullable = true;
				colvarEmail.IsPrimaryKey = false;
				colvarEmail.IsForeignKey = false;
				colvarEmail.IsReadOnly = false;
				colvarEmail.DefaultSetting = @"";
				colvarEmail.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEmail);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("Contact_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("ContactId")]
		[Bindable(true)]
		public int ContactId 
		{
			get { return GetColumnValue<int>(Columns.ContactId); }
			set { SetColumnValue(Columns.ContactId, value); }
		}
		  
		[XmlAttribute("Mobile")]
		[Bindable(true)]
		public string Mobile 
		{
			get { return GetColumnValue<string>(Columns.Mobile); }
			set { SetColumnValue(Columns.Mobile, value); }
		}
		  
		[XmlAttribute("Officephone")]
		[Bindable(true)]
		public string Officephone 
		{
			get { return GetColumnValue<string>(Columns.Officephone); }
			set { SetColumnValue(Columns.Officephone, value); }
		}
		  
		[XmlAttribute("PhoneExt")]
		[Bindable(true)]
		public string PhoneExt 
		{
			get { return GetColumnValue<string>(Columns.PhoneExt); }
			set { SetColumnValue(Columns.PhoneExt, value); }
		}
		  
		[XmlAttribute("Homephone")]
		[Bindable(true)]
		public string Homephone 
		{
			get { return GetColumnValue<string>(Columns.Homephone); }
			set { SetColumnValue(Columns.Homephone, value); }
		}
		  
		[XmlAttribute("Email")]
		[Bindable(true)]
		public string Email 
		{
			get { return GetColumnValue<string>(Columns.Email); }
			set { SetColumnValue(Columns.Email, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		public CanYou.OA.DAL.EmployeeCollection EmployeeRecords()
		{
			return new CanYou.OA.DAL.EmployeeCollection().Where(Employee.Columns.ContactId, ContactId).Load();
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varMobile,string varOfficephone,string varPhoneExt,string varHomephone,string varEmail)
		{
			Contact item = new Contact();
			
			item.Mobile = varMobile;
			
			item.Officephone = varOfficephone;
			
			item.PhoneExt = varPhoneExt;
			
			item.Homephone = varHomephone;
			
			item.Email = varEmail;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varContactId,string varMobile,string varOfficephone,string varPhoneExt,string varHomephone,string varEmail)
		{
			Contact item = new Contact();
			
				item.ContactId = varContactId;
			
				item.Mobile = varMobile;
			
				item.Officephone = varOfficephone;
			
				item.PhoneExt = varPhoneExt;
			
				item.Homephone = varHomephone;
			
				item.Email = varEmail;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ContactIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn MobileColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn OfficephoneColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn PhoneExtColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn HomephoneColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn EmailColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ContactId = @"ContactId";
			 public static string Mobile = @"Mobile";
			 public static string Officephone = @"Officephone";
			 public static string PhoneExt = @"PhoneExt";
			 public static string Homephone = @"Homephone";
			 public static string Email = @"Email";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
}
        #endregion
	}
}

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
	/// Strongly-typed collection for the ToolNum class.
	/// </summary>
    [Serializable]
	public partial class ToolNumCollection : ActiveList<ToolNum, ToolNumCollection>
	{	   
		public ToolNumCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ToolNumCollection</returns>
		public ToolNumCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                ToolNum o = this[i];
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
	/// This is an ActiveRecord class which wraps the ToolNum_tb table.
	/// </summary>
	[Serializable]
	public partial class ToolNum : ActiveRecord<ToolNum>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public ToolNum()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public ToolNum(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public ToolNum(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public ToolNum(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("ToolNum_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarToolNumId = new TableSchema.TableColumn(schema);
				colvarToolNumId.ColumnName = "ToolNumId";
				colvarToolNumId.DataType = DbType.Int32;
				colvarToolNumId.MaxLength = 0;
				colvarToolNumId.AutoIncrement = true;
				colvarToolNumId.IsNullable = false;
				colvarToolNumId.IsPrimaryKey = true;
				colvarToolNumId.IsForeignKey = false;
				colvarToolNumId.IsReadOnly = false;
				colvarToolNumId.DefaultSetting = @"";
				colvarToolNumId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarToolNumId);
				
				TableSchema.TableColumn colvarNum1 = new TableSchema.TableColumn(schema);
				colvarNum1.ColumnName = "Num1";
				colvarNum1.DataType = DbType.String;
				colvarNum1.MaxLength = 20;
				colvarNum1.AutoIncrement = false;
				colvarNum1.IsNullable = true;
				colvarNum1.IsPrimaryKey = false;
				colvarNum1.IsForeignKey = false;
				colvarNum1.IsReadOnly = false;
				colvarNum1.DefaultSetting = @"";
				colvarNum1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum1);
				
				TableSchema.TableColumn colvarNum2 = new TableSchema.TableColumn(schema);
				colvarNum2.ColumnName = "Num2";
				colvarNum2.DataType = DbType.String;
				colvarNum2.MaxLength = 20;
				colvarNum2.AutoIncrement = false;
				colvarNum2.IsNullable = true;
				colvarNum2.IsPrimaryKey = false;
				colvarNum2.IsForeignKey = false;
				colvarNum2.IsReadOnly = false;
				colvarNum2.DefaultSetting = @"";
				colvarNum2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum2);
				
				TableSchema.TableColumn colvarNum3 = new TableSchema.TableColumn(schema);
				colvarNum3.ColumnName = "Num3";
				colvarNum3.DataType = DbType.String;
				colvarNum3.MaxLength = 20;
				colvarNum3.AutoIncrement = false;
				colvarNum3.IsNullable = true;
				colvarNum3.IsPrimaryKey = false;
				colvarNum3.IsForeignKey = false;
				colvarNum3.IsReadOnly = false;
				colvarNum3.DefaultSetting = @"";
				colvarNum3.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum3);
				
				TableSchema.TableColumn colvarNum4 = new TableSchema.TableColumn(schema);
				colvarNum4.ColumnName = "Num4";
				colvarNum4.DataType = DbType.String;
				colvarNum4.MaxLength = 20;
				colvarNum4.AutoIncrement = false;
				colvarNum4.IsNullable = true;
				colvarNum4.IsPrimaryKey = false;
				colvarNum4.IsForeignKey = false;
				colvarNum4.IsReadOnly = false;
				colvarNum4.DefaultSetting = @"";
				colvarNum4.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum4);
				
				TableSchema.TableColumn colvarNum5 = new TableSchema.TableColumn(schema);
				colvarNum5.ColumnName = "Num5";
				colvarNum5.DataType = DbType.String;
				colvarNum5.MaxLength = 20;
				colvarNum5.AutoIncrement = false;
				colvarNum5.IsNullable = true;
				colvarNum5.IsPrimaryKey = false;
				colvarNum5.IsForeignKey = false;
				colvarNum5.IsReadOnly = false;
				colvarNum5.DefaultSetting = @"";
				colvarNum5.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum5);
				
				TableSchema.TableColumn colvarNum6 = new TableSchema.TableColumn(schema);
				colvarNum6.ColumnName = "Num6";
				colvarNum6.DataType = DbType.String;
				colvarNum6.MaxLength = 20;
				colvarNum6.AutoIncrement = false;
				colvarNum6.IsNullable = true;
				colvarNum6.IsPrimaryKey = false;
				colvarNum6.IsForeignKey = false;
				colvarNum6.IsReadOnly = false;
				colvarNum6.DefaultSetting = @"";
				colvarNum6.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum6);
				
				TableSchema.TableColumn colvarNum7 = new TableSchema.TableColumn(schema);
				colvarNum7.ColumnName = "Num7";
				colvarNum7.DataType = DbType.String;
				colvarNum7.MaxLength = 20;
				colvarNum7.AutoIncrement = false;
				colvarNum7.IsNullable = true;
				colvarNum7.IsPrimaryKey = false;
				colvarNum7.IsForeignKey = false;
				colvarNum7.IsReadOnly = false;
				colvarNum7.DefaultSetting = @"";
				colvarNum7.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum7);
				
				TableSchema.TableColumn colvarNum8 = new TableSchema.TableColumn(schema);
				colvarNum8.ColumnName = "Num8";
				colvarNum8.DataType = DbType.String;
				colvarNum8.MaxLength = 20;
				colvarNum8.AutoIncrement = false;
				colvarNum8.IsNullable = true;
				colvarNum8.IsPrimaryKey = false;
				colvarNum8.IsForeignKey = false;
				colvarNum8.IsReadOnly = false;
				colvarNum8.DefaultSetting = @"";
				colvarNum8.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum8);
				
				TableSchema.TableColumn colvarNum9 = new TableSchema.TableColumn(schema);
				colvarNum9.ColumnName = "Num9";
				colvarNum9.DataType = DbType.String;
				colvarNum9.MaxLength = 20;
				colvarNum9.AutoIncrement = false;
				colvarNum9.IsNullable = true;
				colvarNum9.IsPrimaryKey = false;
				colvarNum9.IsForeignKey = false;
				colvarNum9.IsReadOnly = false;
				colvarNum9.DefaultSetting = @"";
				colvarNum9.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum9);
				
				TableSchema.TableColumn colvarNum10 = new TableSchema.TableColumn(schema);
				colvarNum10.ColumnName = "Num10";
				colvarNum10.DataType = DbType.String;
				colvarNum10.MaxLength = 20;
				colvarNum10.AutoIncrement = false;
				colvarNum10.IsNullable = true;
				colvarNum10.IsPrimaryKey = false;
				colvarNum10.IsForeignKey = false;
				colvarNum10.IsReadOnly = false;
				colvarNum10.DefaultSetting = @"";
				colvarNum10.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum10);
				
				TableSchema.TableColumn colvarNum11 = new TableSchema.TableColumn(schema);
				colvarNum11.ColumnName = "Num11";
				colvarNum11.DataType = DbType.String;
				colvarNum11.MaxLength = 20;
				colvarNum11.AutoIncrement = false;
				colvarNum11.IsNullable = true;
				colvarNum11.IsPrimaryKey = false;
				colvarNum11.IsForeignKey = false;
				colvarNum11.IsReadOnly = false;
				colvarNum11.DefaultSetting = @"";
				colvarNum11.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum11);
				
				TableSchema.TableColumn colvarNum12 = new TableSchema.TableColumn(schema);
				colvarNum12.ColumnName = "Num12";
				colvarNum12.DataType = DbType.String;
				colvarNum12.MaxLength = 20;
				colvarNum12.AutoIncrement = false;
				colvarNum12.IsNullable = true;
				colvarNum12.IsPrimaryKey = false;
				colvarNum12.IsForeignKey = false;
				colvarNum12.IsReadOnly = false;
				colvarNum12.DefaultSetting = @"";
				colvarNum12.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum12);
				
				TableSchema.TableColumn colvarNum13 = new TableSchema.TableColumn(schema);
				colvarNum13.ColumnName = "Num13";
				colvarNum13.DataType = DbType.String;
				colvarNum13.MaxLength = 20;
				colvarNum13.AutoIncrement = false;
				colvarNum13.IsNullable = true;
				colvarNum13.IsPrimaryKey = false;
				colvarNum13.IsForeignKey = false;
				colvarNum13.IsReadOnly = false;
				colvarNum13.DefaultSetting = @"";
				colvarNum13.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum13);
				
				TableSchema.TableColumn colvarNum14 = new TableSchema.TableColumn(schema);
				colvarNum14.ColumnName = "Num14";
				colvarNum14.DataType = DbType.String;
				colvarNum14.MaxLength = 20;
				colvarNum14.AutoIncrement = false;
				colvarNum14.IsNullable = true;
				colvarNum14.IsPrimaryKey = false;
				colvarNum14.IsForeignKey = false;
				colvarNum14.IsReadOnly = false;
				colvarNum14.DefaultSetting = @"";
				colvarNum14.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum14);
				
				TableSchema.TableColumn colvarNum15 = new TableSchema.TableColumn(schema);
				colvarNum15.ColumnName = "Num15";
				colvarNum15.DataType = DbType.String;
				colvarNum15.MaxLength = 20;
				colvarNum15.AutoIncrement = false;
				colvarNum15.IsNullable = true;
				colvarNum15.IsPrimaryKey = false;
				colvarNum15.IsForeignKey = false;
				colvarNum15.IsReadOnly = false;
				colvarNum15.DefaultSetting = @"";
				colvarNum15.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum15);
				
				TableSchema.TableColumn colvarNum16 = new TableSchema.TableColumn(schema);
				colvarNum16.ColumnName = "Num16";
				colvarNum16.DataType = DbType.String;
				colvarNum16.MaxLength = 20;
				colvarNum16.AutoIncrement = false;
				colvarNum16.IsNullable = true;
				colvarNum16.IsPrimaryKey = false;
				colvarNum16.IsForeignKey = false;
				colvarNum16.IsReadOnly = false;
				colvarNum16.DefaultSetting = @"";
				colvarNum16.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum16);
				
				TableSchema.TableColumn colvarNum17 = new TableSchema.TableColumn(schema);
				colvarNum17.ColumnName = "Num17";
				colvarNum17.DataType = DbType.String;
				colvarNum17.MaxLength = 20;
				colvarNum17.AutoIncrement = false;
				colvarNum17.IsNullable = true;
				colvarNum17.IsPrimaryKey = false;
				colvarNum17.IsForeignKey = false;
				colvarNum17.IsReadOnly = false;
				colvarNum17.DefaultSetting = @"";
				colvarNum17.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum17);
				
				TableSchema.TableColumn colvarNum18 = new TableSchema.TableColumn(schema);
				colvarNum18.ColumnName = "Num18";
				colvarNum18.DataType = DbType.String;
				colvarNum18.MaxLength = 20;
				colvarNum18.AutoIncrement = false;
				colvarNum18.IsNullable = true;
				colvarNum18.IsPrimaryKey = false;
				colvarNum18.IsForeignKey = false;
				colvarNum18.IsReadOnly = false;
				colvarNum18.DefaultSetting = @"";
				colvarNum18.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum18);
				
				TableSchema.TableColumn colvarNum19 = new TableSchema.TableColumn(schema);
				colvarNum19.ColumnName = "Num19";
				colvarNum19.DataType = DbType.String;
				colvarNum19.MaxLength = 20;
				colvarNum19.AutoIncrement = false;
				colvarNum19.IsNullable = true;
				colvarNum19.IsPrimaryKey = false;
				colvarNum19.IsForeignKey = false;
				colvarNum19.IsReadOnly = false;
				colvarNum19.DefaultSetting = @"";
				colvarNum19.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum19);
				
				TableSchema.TableColumn colvarNum20 = new TableSchema.TableColumn(schema);
				colvarNum20.ColumnName = "Num20";
				colvarNum20.DataType = DbType.String;
				colvarNum20.MaxLength = 20;
				colvarNum20.AutoIncrement = false;
				colvarNum20.IsNullable = true;
				colvarNum20.IsPrimaryKey = false;
				colvarNum20.IsForeignKey = false;
				colvarNum20.IsReadOnly = false;
				colvarNum20.DefaultSetting = @"";
				colvarNum20.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum20);
				
				TableSchema.TableColumn colvarNum21 = new TableSchema.TableColumn(schema);
				colvarNum21.ColumnName = "Num21";
				colvarNum21.DataType = DbType.String;
				colvarNum21.MaxLength = 20;
				colvarNum21.AutoIncrement = false;
				colvarNum21.IsNullable = true;
				colvarNum21.IsPrimaryKey = false;
				colvarNum21.IsForeignKey = false;
				colvarNum21.IsReadOnly = false;
				colvarNum21.DefaultSetting = @"";
				colvarNum21.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum21);
				
				TableSchema.TableColumn colvarNum22 = new TableSchema.TableColumn(schema);
				colvarNum22.ColumnName = "Num22";
				colvarNum22.DataType = DbType.String;
				colvarNum22.MaxLength = 20;
				colvarNum22.AutoIncrement = false;
				colvarNum22.IsNullable = true;
				colvarNum22.IsPrimaryKey = false;
				colvarNum22.IsForeignKey = false;
				colvarNum22.IsReadOnly = false;
				colvarNum22.DefaultSetting = @"";
				colvarNum22.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum22);
				
				TableSchema.TableColumn colvarNum23 = new TableSchema.TableColumn(schema);
				colvarNum23.ColumnName = "Num23";
				colvarNum23.DataType = DbType.String;
				colvarNum23.MaxLength = 20;
				colvarNum23.AutoIncrement = false;
				colvarNum23.IsNullable = true;
				colvarNum23.IsPrimaryKey = false;
				colvarNum23.IsForeignKey = false;
				colvarNum23.IsReadOnly = false;
				colvarNum23.DefaultSetting = @"";
				colvarNum23.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum23);
				
				TableSchema.TableColumn colvarNum24 = new TableSchema.TableColumn(schema);
				colvarNum24.ColumnName = "Num24";
				colvarNum24.DataType = DbType.String;
				colvarNum24.MaxLength = 20;
				colvarNum24.AutoIncrement = false;
				colvarNum24.IsNullable = true;
				colvarNum24.IsPrimaryKey = false;
				colvarNum24.IsForeignKey = false;
				colvarNum24.IsReadOnly = false;
				colvarNum24.DefaultSetting = @"";
				colvarNum24.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum24);
				
				TableSchema.TableColumn colvarNum25 = new TableSchema.TableColumn(schema);
				colvarNum25.ColumnName = "Num25";
				colvarNum25.DataType = DbType.String;
				colvarNum25.MaxLength = 20;
				colvarNum25.AutoIncrement = false;
				colvarNum25.IsNullable = true;
				colvarNum25.IsPrimaryKey = false;
				colvarNum25.IsForeignKey = false;
				colvarNum25.IsReadOnly = false;
				colvarNum25.DefaultSetting = @"";
				colvarNum25.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum25);
				
				TableSchema.TableColumn colvarNum26 = new TableSchema.TableColumn(schema);
				colvarNum26.ColumnName = "Num26";
				colvarNum26.DataType = DbType.String;
				colvarNum26.MaxLength = 20;
				colvarNum26.AutoIncrement = false;
				colvarNum26.IsNullable = true;
				colvarNum26.IsPrimaryKey = false;
				colvarNum26.IsForeignKey = false;
				colvarNum26.IsReadOnly = false;
				colvarNum26.DefaultSetting = @"";
				colvarNum26.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum26);
				
				TableSchema.TableColumn colvarNum27 = new TableSchema.TableColumn(schema);
				colvarNum27.ColumnName = "Num27";
				colvarNum27.DataType = DbType.String;
				colvarNum27.MaxLength = 20;
				colvarNum27.AutoIncrement = false;
				colvarNum27.IsNullable = true;
				colvarNum27.IsPrimaryKey = false;
				colvarNum27.IsForeignKey = false;
				colvarNum27.IsReadOnly = false;
				colvarNum27.DefaultSetting = @"";
				colvarNum27.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum27);
				
				TableSchema.TableColumn colvarNum28 = new TableSchema.TableColumn(schema);
				colvarNum28.ColumnName = "Num28";
				colvarNum28.DataType = DbType.String;
				colvarNum28.MaxLength = 20;
				colvarNum28.AutoIncrement = false;
				colvarNum28.IsNullable = true;
				colvarNum28.IsPrimaryKey = false;
				colvarNum28.IsForeignKey = false;
				colvarNum28.IsReadOnly = false;
				colvarNum28.DefaultSetting = @"";
				colvarNum28.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum28);
				
				TableSchema.TableColumn colvarNum29 = new TableSchema.TableColumn(schema);
				colvarNum29.ColumnName = "Num29";
				colvarNum29.DataType = DbType.String;
				colvarNum29.MaxLength = 20;
				colvarNum29.AutoIncrement = false;
				colvarNum29.IsNullable = true;
				colvarNum29.IsPrimaryKey = false;
				colvarNum29.IsForeignKey = false;
				colvarNum29.IsReadOnly = false;
				colvarNum29.DefaultSetting = @"";
				colvarNum29.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum29);
				
				TableSchema.TableColumn colvarNum30 = new TableSchema.TableColumn(schema);
				colvarNum30.ColumnName = "Num30";
				colvarNum30.DataType = DbType.String;
				colvarNum30.MaxLength = 20;
				colvarNum30.AutoIncrement = false;
				colvarNum30.IsNullable = true;
				colvarNum30.IsPrimaryKey = false;
				colvarNum30.IsForeignKey = false;
				colvarNum30.IsReadOnly = false;
				colvarNum30.DefaultSetting = @"";
				colvarNum30.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum30);
				
				TableSchema.TableColumn colvarNum31 = new TableSchema.TableColumn(schema);
				colvarNum31.ColumnName = "Num31";
				colvarNum31.DataType = DbType.String;
				colvarNum31.MaxLength = 20;
				colvarNum31.AutoIncrement = false;
				colvarNum31.IsNullable = true;
				colvarNum31.IsPrimaryKey = false;
				colvarNum31.IsForeignKey = false;
				colvarNum31.IsReadOnly = false;
				colvarNum31.DefaultSetting = @"";
				colvarNum31.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum31);
				
				TableSchema.TableColumn colvarNum32 = new TableSchema.TableColumn(schema);
				colvarNum32.ColumnName = "Num32";
				colvarNum32.DataType = DbType.String;
				colvarNum32.MaxLength = 20;
				colvarNum32.AutoIncrement = false;
				colvarNum32.IsNullable = true;
				colvarNum32.IsPrimaryKey = false;
				colvarNum32.IsForeignKey = false;
				colvarNum32.IsReadOnly = false;
				colvarNum32.DefaultSetting = @"";
				colvarNum32.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum32);
				
				TableSchema.TableColumn colvarNum33 = new TableSchema.TableColumn(schema);
				colvarNum33.ColumnName = "Num33";
				colvarNum33.DataType = DbType.String;
				colvarNum33.MaxLength = 20;
				colvarNum33.AutoIncrement = false;
				colvarNum33.IsNullable = true;
				colvarNum33.IsPrimaryKey = false;
				colvarNum33.IsForeignKey = false;
				colvarNum33.IsReadOnly = false;
				colvarNum33.DefaultSetting = @"";
				colvarNum33.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum33);
				
				TableSchema.TableColumn colvarNum34 = new TableSchema.TableColumn(schema);
				colvarNum34.ColumnName = "Num34";
				colvarNum34.DataType = DbType.String;
				colvarNum34.MaxLength = 20;
				colvarNum34.AutoIncrement = false;
				colvarNum34.IsNullable = true;
				colvarNum34.IsPrimaryKey = false;
				colvarNum34.IsForeignKey = false;
				colvarNum34.IsReadOnly = false;
				colvarNum34.DefaultSetting = @"";
				colvarNum34.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum34);
				
				TableSchema.TableColumn colvarNum35 = new TableSchema.TableColumn(schema);
				colvarNum35.ColumnName = "Num35";
				colvarNum35.DataType = DbType.String;
				colvarNum35.MaxLength = 20;
				colvarNum35.AutoIncrement = false;
				colvarNum35.IsNullable = true;
				colvarNum35.IsPrimaryKey = false;
				colvarNum35.IsForeignKey = false;
				colvarNum35.IsReadOnly = false;
				colvarNum35.DefaultSetting = @"";
				colvarNum35.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum35);
				
				TableSchema.TableColumn colvarNum36 = new TableSchema.TableColumn(schema);
				colvarNum36.ColumnName = "Num36";
				colvarNum36.DataType = DbType.String;
				colvarNum36.MaxLength = 20;
				colvarNum36.AutoIncrement = false;
				colvarNum36.IsNullable = true;
				colvarNum36.IsPrimaryKey = false;
				colvarNum36.IsForeignKey = false;
				colvarNum36.IsReadOnly = false;
				colvarNum36.DefaultSetting = @"";
				colvarNum36.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum36);
				
				TableSchema.TableColumn colvarNum37 = new TableSchema.TableColumn(schema);
				colvarNum37.ColumnName = "Num37";
				colvarNum37.DataType = DbType.String;
				colvarNum37.MaxLength = 20;
				colvarNum37.AutoIncrement = false;
				colvarNum37.IsNullable = true;
				colvarNum37.IsPrimaryKey = false;
				colvarNum37.IsForeignKey = false;
				colvarNum37.IsReadOnly = false;
				colvarNum37.DefaultSetting = @"";
				colvarNum37.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum37);
				
				TableSchema.TableColumn colvarNum38 = new TableSchema.TableColumn(schema);
				colvarNum38.ColumnName = "Num38";
				colvarNum38.DataType = DbType.String;
				colvarNum38.MaxLength = 20;
				colvarNum38.AutoIncrement = false;
				colvarNum38.IsNullable = true;
				colvarNum38.IsPrimaryKey = false;
				colvarNum38.IsForeignKey = false;
				colvarNum38.IsReadOnly = false;
				colvarNum38.DefaultSetting = @"";
				colvarNum38.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum38);
				
				TableSchema.TableColumn colvarNum39 = new TableSchema.TableColumn(schema);
				colvarNum39.ColumnName = "Num39";
				colvarNum39.DataType = DbType.String;
				colvarNum39.MaxLength = 20;
				colvarNum39.AutoIncrement = false;
				colvarNum39.IsNullable = true;
				colvarNum39.IsPrimaryKey = false;
				colvarNum39.IsForeignKey = false;
				colvarNum39.IsReadOnly = false;
				colvarNum39.DefaultSetting = @"";
				colvarNum39.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum39);
				
				TableSchema.TableColumn colvarNum40 = new TableSchema.TableColumn(schema);
				colvarNum40.ColumnName = "Num40";
				colvarNum40.DataType = DbType.String;
				colvarNum40.MaxLength = 20;
				colvarNum40.AutoIncrement = false;
				colvarNum40.IsNullable = true;
				colvarNum40.IsPrimaryKey = false;
				colvarNum40.IsForeignKey = false;
				colvarNum40.IsReadOnly = false;
				colvarNum40.DefaultSetting = @"";
				colvarNum40.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum40);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("ToolNum_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("ToolNumId")]
		[Bindable(true)]
		public int ToolNumId 
		{
			get { return GetColumnValue<int>(Columns.ToolNumId); }
			set { SetColumnValue(Columns.ToolNumId, value); }
		}
		  
		[XmlAttribute("Num1")]
		[Bindable(true)]
		public string Num1 
		{
			get { return GetColumnValue<string>(Columns.Num1); }
			set { SetColumnValue(Columns.Num1, value); }
		}
		  
		[XmlAttribute("Num2")]
		[Bindable(true)]
		public string Num2 
		{
			get { return GetColumnValue<string>(Columns.Num2); }
			set { SetColumnValue(Columns.Num2, value); }
		}
		  
		[XmlAttribute("Num3")]
		[Bindable(true)]
		public string Num3 
		{
			get { return GetColumnValue<string>(Columns.Num3); }
			set { SetColumnValue(Columns.Num3, value); }
		}
		  
		[XmlAttribute("Num4")]
		[Bindable(true)]
		public string Num4 
		{
			get { return GetColumnValue<string>(Columns.Num4); }
			set { SetColumnValue(Columns.Num4, value); }
		}
		  
		[XmlAttribute("Num5")]
		[Bindable(true)]
		public string Num5 
		{
			get { return GetColumnValue<string>(Columns.Num5); }
			set { SetColumnValue(Columns.Num5, value); }
		}
		  
		[XmlAttribute("Num6")]
		[Bindable(true)]
		public string Num6 
		{
			get { return GetColumnValue<string>(Columns.Num6); }
			set { SetColumnValue(Columns.Num6, value); }
		}
		  
		[XmlAttribute("Num7")]
		[Bindable(true)]
		public string Num7 
		{
			get { return GetColumnValue<string>(Columns.Num7); }
			set { SetColumnValue(Columns.Num7, value); }
		}
		  
		[XmlAttribute("Num8")]
		[Bindable(true)]
		public string Num8 
		{
			get { return GetColumnValue<string>(Columns.Num8); }
			set { SetColumnValue(Columns.Num8, value); }
		}
		  
		[XmlAttribute("Num9")]
		[Bindable(true)]
		public string Num9 
		{
			get { return GetColumnValue<string>(Columns.Num9); }
			set { SetColumnValue(Columns.Num9, value); }
		}
		  
		[XmlAttribute("Num10")]
		[Bindable(true)]
		public string Num10 
		{
			get { return GetColumnValue<string>(Columns.Num10); }
			set { SetColumnValue(Columns.Num10, value); }
		}
		  
		[XmlAttribute("Num11")]
		[Bindable(true)]
		public string Num11 
		{
			get { return GetColumnValue<string>(Columns.Num11); }
			set { SetColumnValue(Columns.Num11, value); }
		}
		  
		[XmlAttribute("Num12")]
		[Bindable(true)]
		public string Num12 
		{
			get { return GetColumnValue<string>(Columns.Num12); }
			set { SetColumnValue(Columns.Num12, value); }
		}
		  
		[XmlAttribute("Num13")]
		[Bindable(true)]
		public string Num13 
		{
			get { return GetColumnValue<string>(Columns.Num13); }
			set { SetColumnValue(Columns.Num13, value); }
		}
		  
		[XmlAttribute("Num14")]
		[Bindable(true)]
		public string Num14 
		{
			get { return GetColumnValue<string>(Columns.Num14); }
			set { SetColumnValue(Columns.Num14, value); }
		}
		  
		[XmlAttribute("Num15")]
		[Bindable(true)]
		public string Num15 
		{
			get { return GetColumnValue<string>(Columns.Num15); }
			set { SetColumnValue(Columns.Num15, value); }
		}
		  
		[XmlAttribute("Num16")]
		[Bindable(true)]
		public string Num16 
		{
			get { return GetColumnValue<string>(Columns.Num16); }
			set { SetColumnValue(Columns.Num16, value); }
		}
		  
		[XmlAttribute("Num17")]
		[Bindable(true)]
		public string Num17 
		{
			get { return GetColumnValue<string>(Columns.Num17); }
			set { SetColumnValue(Columns.Num17, value); }
		}
		  
		[XmlAttribute("Num18")]
		[Bindable(true)]
		public string Num18 
		{
			get { return GetColumnValue<string>(Columns.Num18); }
			set { SetColumnValue(Columns.Num18, value); }
		}
		  
		[XmlAttribute("Num19")]
		[Bindable(true)]
		public string Num19 
		{
			get { return GetColumnValue<string>(Columns.Num19); }
			set { SetColumnValue(Columns.Num19, value); }
		}
		  
		[XmlAttribute("Num20")]
		[Bindable(true)]
		public string Num20 
		{
			get { return GetColumnValue<string>(Columns.Num20); }
			set { SetColumnValue(Columns.Num20, value); }
		}
		  
		[XmlAttribute("Num21")]
		[Bindable(true)]
		public string Num21 
		{
			get { return GetColumnValue<string>(Columns.Num21); }
			set { SetColumnValue(Columns.Num21, value); }
		}
		  
		[XmlAttribute("Num22")]
		[Bindable(true)]
		public string Num22 
		{
			get { return GetColumnValue<string>(Columns.Num22); }
			set { SetColumnValue(Columns.Num22, value); }
		}
		  
		[XmlAttribute("Num23")]
		[Bindable(true)]
		public string Num23 
		{
			get { return GetColumnValue<string>(Columns.Num23); }
			set { SetColumnValue(Columns.Num23, value); }
		}
		  
		[XmlAttribute("Num24")]
		[Bindable(true)]
		public string Num24 
		{
			get { return GetColumnValue<string>(Columns.Num24); }
			set { SetColumnValue(Columns.Num24, value); }
		}
		  
		[XmlAttribute("Num25")]
		[Bindable(true)]
		public string Num25 
		{
			get { return GetColumnValue<string>(Columns.Num25); }
			set { SetColumnValue(Columns.Num25, value); }
		}
		  
		[XmlAttribute("Num26")]
		[Bindable(true)]
		public string Num26 
		{
			get { return GetColumnValue<string>(Columns.Num26); }
			set { SetColumnValue(Columns.Num26, value); }
		}
		  
		[XmlAttribute("Num27")]
		[Bindable(true)]
		public string Num27 
		{
			get { return GetColumnValue<string>(Columns.Num27); }
			set { SetColumnValue(Columns.Num27, value); }
		}
		  
		[XmlAttribute("Num28")]
		[Bindable(true)]
		public string Num28 
		{
			get { return GetColumnValue<string>(Columns.Num28); }
			set { SetColumnValue(Columns.Num28, value); }
		}
		  
		[XmlAttribute("Num29")]
		[Bindable(true)]
		public string Num29 
		{
			get { return GetColumnValue<string>(Columns.Num29); }
			set { SetColumnValue(Columns.Num29, value); }
		}
		  
		[XmlAttribute("Num30")]
		[Bindable(true)]
		public string Num30 
		{
			get { return GetColumnValue<string>(Columns.Num30); }
			set { SetColumnValue(Columns.Num30, value); }
		}
		  
		[XmlAttribute("Num31")]
		[Bindable(true)]
		public string Num31 
		{
			get { return GetColumnValue<string>(Columns.Num31); }
			set { SetColumnValue(Columns.Num31, value); }
		}
		  
		[XmlAttribute("Num32")]
		[Bindable(true)]
		public string Num32 
		{
			get { return GetColumnValue<string>(Columns.Num32); }
			set { SetColumnValue(Columns.Num32, value); }
		}
		  
		[XmlAttribute("Num33")]
		[Bindable(true)]
		public string Num33 
		{
			get { return GetColumnValue<string>(Columns.Num33); }
			set { SetColumnValue(Columns.Num33, value); }
		}
		  
		[XmlAttribute("Num34")]
		[Bindable(true)]
		public string Num34 
		{
			get { return GetColumnValue<string>(Columns.Num34); }
			set { SetColumnValue(Columns.Num34, value); }
		}
		  
		[XmlAttribute("Num35")]
		[Bindable(true)]
		public string Num35 
		{
			get { return GetColumnValue<string>(Columns.Num35); }
			set { SetColumnValue(Columns.Num35, value); }
		}
		  
		[XmlAttribute("Num36")]
		[Bindable(true)]
		public string Num36 
		{
			get { return GetColumnValue<string>(Columns.Num36); }
			set { SetColumnValue(Columns.Num36, value); }
		}
		  
		[XmlAttribute("Num37")]
		[Bindable(true)]
		public string Num37 
		{
			get { return GetColumnValue<string>(Columns.Num37); }
			set { SetColumnValue(Columns.Num37, value); }
		}
		  
		[XmlAttribute("Num38")]
		[Bindable(true)]
		public string Num38 
		{
			get { return GetColumnValue<string>(Columns.Num38); }
			set { SetColumnValue(Columns.Num38, value); }
		}
		  
		[XmlAttribute("Num39")]
		[Bindable(true)]
		public string Num39 
		{
			get { return GetColumnValue<string>(Columns.Num39); }
			set { SetColumnValue(Columns.Num39, value); }
		}
		  
		[XmlAttribute("Num40")]
		[Bindable(true)]
		public string Num40 
		{
			get { return GetColumnValue<string>(Columns.Num40); }
			set { SetColumnValue(Columns.Num40, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varNum1,string varNum2,string varNum3,string varNum4,string varNum5,string varNum6,string varNum7,string varNum8,string varNum9,string varNum10,string varNum11,string varNum12,string varNum13,string varNum14,string varNum15,string varNum16,string varNum17,string varNum18,string varNum19,string varNum20,string varNum21,string varNum22,string varNum23,string varNum24,string varNum25,string varNum26,string varNum27,string varNum28,string varNum29,string varNum30,string varNum31,string varNum32,string varNum33,string varNum34,string varNum35,string varNum36,string varNum37,string varNum38,string varNum39,string varNum40)
		{
			ToolNum item = new ToolNum();
			
			item.Num1 = varNum1;
			
			item.Num2 = varNum2;
			
			item.Num3 = varNum3;
			
			item.Num4 = varNum4;
			
			item.Num5 = varNum5;
			
			item.Num6 = varNum6;
			
			item.Num7 = varNum7;
			
			item.Num8 = varNum8;
			
			item.Num9 = varNum9;
			
			item.Num10 = varNum10;
			
			item.Num11 = varNum11;
			
			item.Num12 = varNum12;
			
			item.Num13 = varNum13;
			
			item.Num14 = varNum14;
			
			item.Num15 = varNum15;
			
			item.Num16 = varNum16;
			
			item.Num17 = varNum17;
			
			item.Num18 = varNum18;
			
			item.Num19 = varNum19;
			
			item.Num20 = varNum20;
			
			item.Num21 = varNum21;
			
			item.Num22 = varNum22;
			
			item.Num23 = varNum23;
			
			item.Num24 = varNum24;
			
			item.Num25 = varNum25;
			
			item.Num26 = varNum26;
			
			item.Num27 = varNum27;
			
			item.Num28 = varNum28;
			
			item.Num29 = varNum29;
			
			item.Num30 = varNum30;
			
			item.Num31 = varNum31;
			
			item.Num32 = varNum32;
			
			item.Num33 = varNum33;
			
			item.Num34 = varNum34;
			
			item.Num35 = varNum35;
			
			item.Num36 = varNum36;
			
			item.Num37 = varNum37;
			
			item.Num38 = varNum38;
			
			item.Num39 = varNum39;
			
			item.Num40 = varNum40;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varToolNumId,string varNum1,string varNum2,string varNum3,string varNum4,string varNum5,string varNum6,string varNum7,string varNum8,string varNum9,string varNum10,string varNum11,string varNum12,string varNum13,string varNum14,string varNum15,string varNum16,string varNum17,string varNum18,string varNum19,string varNum20,string varNum21,string varNum22,string varNum23,string varNum24,string varNum25,string varNum26,string varNum27,string varNum28,string varNum29,string varNum30,string varNum31,string varNum32,string varNum33,string varNum34,string varNum35,string varNum36,string varNum37,string varNum38,string varNum39,string varNum40)
		{
			ToolNum item = new ToolNum();
			
				item.ToolNumId = varToolNumId;
			
				item.Num1 = varNum1;
			
				item.Num2 = varNum2;
			
				item.Num3 = varNum3;
			
				item.Num4 = varNum4;
			
				item.Num5 = varNum5;
			
				item.Num6 = varNum6;
			
				item.Num7 = varNum7;
			
				item.Num8 = varNum8;
			
				item.Num9 = varNum9;
			
				item.Num10 = varNum10;
			
				item.Num11 = varNum11;
			
				item.Num12 = varNum12;
			
				item.Num13 = varNum13;
			
				item.Num14 = varNum14;
			
				item.Num15 = varNum15;
			
				item.Num16 = varNum16;
			
				item.Num17 = varNum17;
			
				item.Num18 = varNum18;
			
				item.Num19 = varNum19;
			
				item.Num20 = varNum20;
			
				item.Num21 = varNum21;
			
				item.Num22 = varNum22;
			
				item.Num23 = varNum23;
			
				item.Num24 = varNum24;
			
				item.Num25 = varNum25;
			
				item.Num26 = varNum26;
			
				item.Num27 = varNum27;
			
				item.Num28 = varNum28;
			
				item.Num29 = varNum29;
			
				item.Num30 = varNum30;
			
				item.Num31 = varNum31;
			
				item.Num32 = varNum32;
			
				item.Num33 = varNum33;
			
				item.Num34 = varNum34;
			
				item.Num35 = varNum35;
			
				item.Num36 = varNum36;
			
				item.Num37 = varNum37;
			
				item.Num38 = varNum38;
			
				item.Num39 = varNum39;
			
				item.Num40 = varNum40;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ToolNumIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn Num1Column
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn Num2Column
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn Num3Column
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn Num4Column
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn Num5Column
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn Num6Column
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn Num7Column
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn Num8Column
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn Num9Column
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn Num10Column
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn Num11Column
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn Num12Column
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn Num13Column
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn Num14Column
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn Num15Column
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn Num16Column
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn Num17Column
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn Num18Column
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn Num19Column
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn Num20Column
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn Num21Column
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn Num22Column
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn Num23Column
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn Num24Column
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn Num25Column
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        public static TableSchema.TableColumn Num26Column
        {
            get { return Schema.Columns[26]; }
        }
        
        
        
        public static TableSchema.TableColumn Num27Column
        {
            get { return Schema.Columns[27]; }
        }
        
        
        
        public static TableSchema.TableColumn Num28Column
        {
            get { return Schema.Columns[28]; }
        }
        
        
        
        public static TableSchema.TableColumn Num29Column
        {
            get { return Schema.Columns[29]; }
        }
        
        
        
        public static TableSchema.TableColumn Num30Column
        {
            get { return Schema.Columns[30]; }
        }
        
        
        
        public static TableSchema.TableColumn Num31Column
        {
            get { return Schema.Columns[31]; }
        }
        
        
        
        public static TableSchema.TableColumn Num32Column
        {
            get { return Schema.Columns[32]; }
        }
        
        
        
        public static TableSchema.TableColumn Num33Column
        {
            get { return Schema.Columns[33]; }
        }
        
        
        
        public static TableSchema.TableColumn Num34Column
        {
            get { return Schema.Columns[34]; }
        }
        
        
        
        public static TableSchema.TableColumn Num35Column
        {
            get { return Schema.Columns[35]; }
        }
        
        
        
        public static TableSchema.TableColumn Num36Column
        {
            get { return Schema.Columns[36]; }
        }
        
        
        
        public static TableSchema.TableColumn Num37Column
        {
            get { return Schema.Columns[37]; }
        }
        
        
        
        public static TableSchema.TableColumn Num38Column
        {
            get { return Schema.Columns[38]; }
        }
        
        
        
        public static TableSchema.TableColumn Num39Column
        {
            get { return Schema.Columns[39]; }
        }
        
        
        
        public static TableSchema.TableColumn Num40Column
        {
            get { return Schema.Columns[40]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ToolNumId = @"ToolNumId";
			 public static string Num1 = @"Num1";
			 public static string Num2 = @"Num2";
			 public static string Num3 = @"Num3";
			 public static string Num4 = @"Num4";
			 public static string Num5 = @"Num5";
			 public static string Num6 = @"Num6";
			 public static string Num7 = @"Num7";
			 public static string Num8 = @"Num8";
			 public static string Num9 = @"Num9";
			 public static string Num10 = @"Num10";
			 public static string Num11 = @"Num11";
			 public static string Num12 = @"Num12";
			 public static string Num13 = @"Num13";
			 public static string Num14 = @"Num14";
			 public static string Num15 = @"Num15";
			 public static string Num16 = @"Num16";
			 public static string Num17 = @"Num17";
			 public static string Num18 = @"Num18";
			 public static string Num19 = @"Num19";
			 public static string Num20 = @"Num20";
			 public static string Num21 = @"Num21";
			 public static string Num22 = @"Num22";
			 public static string Num23 = @"Num23";
			 public static string Num24 = @"Num24";
			 public static string Num25 = @"Num25";
			 public static string Num26 = @"Num26";
			 public static string Num27 = @"Num27";
			 public static string Num28 = @"Num28";
			 public static string Num29 = @"Num29";
			 public static string Num30 = @"Num30";
			 public static string Num31 = @"Num31";
			 public static string Num32 = @"Num32";
			 public static string Num33 = @"Num33";
			 public static string Num34 = @"Num34";
			 public static string Num35 = @"Num35";
			 public static string Num36 = @"Num36";
			 public static string Num37 = @"Num37";
			 public static string Num38 = @"Num38";
			 public static string Num39 = @"Num39";
			 public static string Num40 = @"Num40";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}

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
	#region Tables Struct
	public partial struct Tables
	{
		
		public static string Action = @"Action_tb";
        
		public static string ActionMaster = @"ActionMaster_tb";
        
		public static string Asset = @"Asset_tb";
        
		public static string AssistantScore = @"AssistantScore_tb";
        
		public static string BasEmScore = @"BasEmScore_tb";
        
		public static string BusinessExp = @"BusinessExp_tb";
        
		public static string CarApply = @"CarApply_tb";
        
		public static string Client = @"Client_tb";
        
		public static string ClientLevel = @"ClientLevel_tb";
        
		public static string ClientType = @"ClientType_tb";
        
		public static string Contact = @"Contact_tb";
        
		public static string Contract = @"Contract_tb";
        
		public static string ContractApply = @"ContractApply_tb";
        
		public static string ContractFile = @"ContractFile_tb";
        
		public static string ContractType = @"ContractType_tb";
        
		public static string Day = @"Day_tb";
        
		public static string DayRole = @"DayRole_tb";
        
		public static string DayScore = @"DayScore_tb";
        
		public static string Depart = @"Depart_tb";
        
		public static string DriverScore = @"DriverScore_tb";
        
		public static string Education = @"Education_tb";
        
		public static string EmDang = @"EmDang_tb";
        
		public static string EmLevel = @"EmLevel_tb";
        
		public static string Employee = @"Employee_tb";
        
		public static string EmployeeBExp = @"EmployeeBExp_tb";
        
		public static string EvaluateLevel = @"EvaluateLevel_tb";
        
		public static string Execute = @"Execute_tb";
        
		public static string File = @"File_tb";
        
		public static string FileEmployee = @"FileEmployee_tb";
        
		public static string FilePermission = @"FilePermission_tb";
        
		public static string FileType = @"FileType_tb";
        
		public static string FrontScore = @"FrontScore_tb";
        
		public static string HolidayApply = @"HolidayApply_tb";
        
		public static string HolidayType = @"HolidayType_tb";
        
		public static string Language = @"Language_tb";
        
		public static string MainBusinessExp = @"MainBusinessExp_tb";
        
		public static string MainContractApply = @"MainContractApply_tb";
        
		public static string MainHolidayApply = @"MainHolidayApply_tb";
        
		public static string MainOfferPrice = @"MainOfferPrice_tb";
        
		public static string MainProject = @"MainProject_tb";
        
		public static string MainProjectCreate = @"MainProjectCreate_tb";
        
		public static string MainProjectExecute = @"MainProjectExecute_tb";
        
		public static string MainSpecialExp = @"MainSpecialExp_tb";
        
		public static string MainStamp = @"MainStamp_tb";
        
		public static string MainTool = @"MainTool_tb";
        
		public static string MainWorkSheet = @"MainWorkSheet_tb";
        
		public static string MainWorkToolSum = @"MainWorkToolSum_tb";
        
		public static string MarketScore = @"MarketScore_tb";
        
		public static string Master = @"Master_tb";
        
		public static string Message = @"Message_tb";
        
		public static string Month = @"Month_tb";
        
		public static string Notice = @"Notice_tb";
        
		public static string NurseScore = @"NurseScore_tb";
        
		public static string OfferFile = @"OfferFile_tb";
        
		public static string OfferPrice = @"OfferPrice_tb";
        
		public static string OfferPriceType = @"OfferPriceType_tb";
        
		public static string Operation = @"Operation_tb";
        
		public static string OpProRole = @"OpProRole_tb";
        
		public static string OtGroup = @"OtGroup_tb";
        
		public static string OverTime = @"OverTime_tb";
        
		public static string Politics = @"Politics_tb";
        
		public static string Position = @"Position_tb";
        
		public static string Process = @"Process_tb";
        
		public static string ProcessMaster = @"ProcessMaster_tb";
        
		public static string ProductType = @"ProductType_tb";
        
		public static string ProjectCarry = @"ProjectCarry_tb";
        
		public static string ProjectCreate = @"ProjectCreate_tb";
        
		public static string ProjectExecute = @"ProjectExecute_tb";
        
		public static string ProjectExecuteType = @"ProjectExecuteType_tb";
        
		public static string ProjectLevel = @"ProjectLevel_tb";
        
		public static string ProjectStep = @"ProjectStep_tb";
        
		public static string ProjectType = @"ProjectType_tb";
        
		public static string Relate = @"Relate_tb";
        
		public static string RelateBExp = @"RelateBExp_tb";
        
		public static string Role = @"Role_tb";
        
		public static string RoleMaster = @"RoleMaster_tb";
        
		public static string Site = @"Site_tb";
        
		public static string SpecialExp = @"SpecialExp_tb";
        
		public static string Stamp = @"Stamp_tb";
        
		public static string StampFileType = @"StampFileType_tb";
        
		public static string StampType = @"StampType_tb";
        
		public static string State = @"State_tb";
        
		public static string Supply = @"Supply_tb";
        
		public static string Task = @"Task_tb";
        
		public static string Teacher = @"Teacher_tb";
        
		public static string TechEmScore = @"TechEmScore_tb";
        
		public static string TechMaScore = @"TechMaScore_tb";
        
		public static string Tool = @"Tool_tb";
        
		public static string ToolNum = @"ToolNum_tb";
        
		public static string Unit = @"Unit_tb";
        
		public static string UseDepart = @"UseDepart_tb";
        
		public static string Week = @"Week_tb";
        
		public static string WeekScore = @"WeekScore_tb";
        
		public static string WeekSum = @"WeekSum_tb";
        
		public static string WorkPlan = @"WorkPlan_tb";
        
		public static string WorkSheet = @"WorkSheet_tb";
        
		public static string WorkSheetType = @"WorkSheetType_tb";
        
		public static string WorkToolSum = @"WorkToolSum_tb";
        
		public static string Year = @"Year_tb";
        
	}
	#endregion
    #region Schemas
    public partial class Schemas {
		
		public static TableSchema.Table Action{
            get { return DataService.GetSchema("Action_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table ActionMaster{
            get { return DataService.GetSchema("ActionMaster_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Asset{
            get { return DataService.GetSchema("Asset_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table AssistantScore{
            get { return DataService.GetSchema("AssistantScore_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table BasEmScore{
            get { return DataService.GetSchema("BasEmScore_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table BusinessExp{
            get { return DataService.GetSchema("BusinessExp_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table CarApply{
            get { return DataService.GetSchema("CarApply_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Client{
            get { return DataService.GetSchema("Client_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table ClientLevel{
            get { return DataService.GetSchema("ClientLevel_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table ClientType{
            get { return DataService.GetSchema("ClientType_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Contact{
            get { return DataService.GetSchema("Contact_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Contract{
            get { return DataService.GetSchema("Contract_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table ContractApply{
            get { return DataService.GetSchema("ContractApply_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table ContractFile{
            get { return DataService.GetSchema("ContractFile_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table ContractType{
            get { return DataService.GetSchema("ContractType_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Day{
            get { return DataService.GetSchema("Day_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table DayRole{
            get { return DataService.GetSchema("DayRole_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table DayScore{
            get { return DataService.GetSchema("DayScore_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Depart{
            get { return DataService.GetSchema("Depart_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table DriverScore{
            get { return DataService.GetSchema("DriverScore_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Education{
            get { return DataService.GetSchema("Education_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table EmDang{
            get { return DataService.GetSchema("EmDang_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table EmLevel{
            get { return DataService.GetSchema("EmLevel_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Employee{
            get { return DataService.GetSchema("Employee_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table EmployeeBExp{
            get { return DataService.GetSchema("EmployeeBExp_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table EvaluateLevel{
            get { return DataService.GetSchema("EvaluateLevel_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Execute{
            get { return DataService.GetSchema("Execute_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table File{
            get { return DataService.GetSchema("File_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table FileEmployee{
            get { return DataService.GetSchema("FileEmployee_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table FilePermission{
            get { return DataService.GetSchema("FilePermission_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table FileType{
            get { return DataService.GetSchema("FileType_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table FrontScore{
            get { return DataService.GetSchema("FrontScore_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table HolidayApply{
            get { return DataService.GetSchema("HolidayApply_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table HolidayType{
            get { return DataService.GetSchema("HolidayType_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Language{
            get { return DataService.GetSchema("Language_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table MainBusinessExp{
            get { return DataService.GetSchema("MainBusinessExp_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table MainContractApply{
            get { return DataService.GetSchema("MainContractApply_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table MainHolidayApply{
            get { return DataService.GetSchema("MainHolidayApply_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table MainOfferPrice{
            get { return DataService.GetSchema("MainOfferPrice_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table MainProject{
            get { return DataService.GetSchema("MainProject_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table MainProjectCreate{
            get { return DataService.GetSchema("MainProjectCreate_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table MainProjectExecute{
            get { return DataService.GetSchema("MainProjectExecute_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table MainSpecialExp{
            get { return DataService.GetSchema("MainSpecialExp_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table MainStamp{
            get { return DataService.GetSchema("MainStamp_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table MainTool{
            get { return DataService.GetSchema("MainTool_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table MainWorkSheet{
            get { return DataService.GetSchema("MainWorkSheet_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table MainWorkToolSum{
            get { return DataService.GetSchema("MainWorkToolSum_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table MarketScore{
            get { return DataService.GetSchema("MarketScore_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Master{
            get { return DataService.GetSchema("Master_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Message{
            get { return DataService.GetSchema("Message_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Month{
            get { return DataService.GetSchema("Month_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Notice{
            get { return DataService.GetSchema("Notice_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table NurseScore{
            get { return DataService.GetSchema("NurseScore_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table OfferFile{
            get { return DataService.GetSchema("OfferFile_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table OfferPrice{
            get { return DataService.GetSchema("OfferPrice_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table OfferPriceType{
            get { return DataService.GetSchema("OfferPriceType_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Operation{
            get { return DataService.GetSchema("Operation_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table OpProRole{
            get { return DataService.GetSchema("OpProRole_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table OtGroup{
            get { return DataService.GetSchema("OtGroup_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table OverTime{
            get { return DataService.GetSchema("OverTime_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Politics{
            get { return DataService.GetSchema("Politics_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Position{
            get { return DataService.GetSchema("Position_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Process{
            get { return DataService.GetSchema("Process_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table ProcessMaster{
            get { return DataService.GetSchema("ProcessMaster_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table ProductType{
            get { return DataService.GetSchema("ProductType_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table ProjectCarry{
            get { return DataService.GetSchema("ProjectCarry_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table ProjectCreate{
            get { return DataService.GetSchema("ProjectCreate_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table ProjectExecute{
            get { return DataService.GetSchema("ProjectExecute_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table ProjectExecuteType{
            get { return DataService.GetSchema("ProjectExecuteType_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table ProjectLevel{
            get { return DataService.GetSchema("ProjectLevel_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table ProjectStep{
            get { return DataService.GetSchema("ProjectStep_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table ProjectType{
            get { return DataService.GetSchema("ProjectType_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Relate{
            get { return DataService.GetSchema("Relate_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table RelateBExp{
            get { return DataService.GetSchema("RelateBExp_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Role{
            get { return DataService.GetSchema("Role_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table RoleMaster{
            get { return DataService.GetSchema("RoleMaster_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Site{
            get { return DataService.GetSchema("Site_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table SpecialExp{
            get { return DataService.GetSchema("SpecialExp_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Stamp{
            get { return DataService.GetSchema("Stamp_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table StampFileType{
            get { return DataService.GetSchema("StampFileType_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table StampType{
            get { return DataService.GetSchema("StampType_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table State{
            get { return DataService.GetSchema("State_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Supply{
            get { return DataService.GetSchema("Supply_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Task{
            get { return DataService.GetSchema("Task_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Teacher{
            get { return DataService.GetSchema("Teacher_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table TechEmScore{
            get { return DataService.GetSchema("TechEmScore_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table TechMaScore{
            get { return DataService.GetSchema("TechMaScore_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Tool{
            get { return DataService.GetSchema("Tool_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table ToolNum{
            get { return DataService.GetSchema("ToolNum_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Unit{
            get { return DataService.GetSchema("Unit_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table UseDepart{
            get { return DataService.GetSchema("UseDepart_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Week{
            get { return DataService.GetSchema("Week_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table WeekScore{
            get { return DataService.GetSchema("WeekScore_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table WeekSum{
            get { return DataService.GetSchema("WeekSum_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table WorkPlan{
            get { return DataService.GetSchema("WorkPlan_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table WorkSheet{
            get { return DataService.GetSchema("WorkSheet_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table WorkSheetType{
            get { return DataService.GetSchema("WorkSheetType_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table WorkToolSum{
            get { return DataService.GetSchema("WorkToolSum_tb","SubsonicProvider"); }
		}
        
		public static TableSchema.Table Year{
            get { return DataService.GetSchema("Year_tb","SubsonicProvider"); }
		}
        
	
    }
    #endregion
    #region View Struct
    public partial struct Views 
    {
		
		public static string Vw_AssetList = @"vw_AssetList";
        
		public static string Vw_AssisM = @"vw_AssisM";
        
		public static string Vw_BasM = @"vw_BasM";
        
		public static string Vw_Client = @"vw_Client";
        
		public static string Vw_ContactList = @"vw_ContactList";
        
		public static string Vw_Contract = @"vw_Contract";
        
		public static string Vw_Driveds = @"vw_Driveds";
        
		public static string Vw_EmployeeIdOfAdmin = @"vw_EmployeeIdOfAdmin";
        
		public static string Vw_EmployeeIdOfDriver = @"vw_EmployeeIdOfDriver";
        
		public static string Vw_EmployeeIdOfFinaceManager = @"vw_EmployeeIdOfFinaceManager";
        
		public static string Vw_EmployeeIdOfManager = @"vw_EmployeeIdOfManager";
        
		public static string Vw_EmployeeIdOfMarket = @"vw_EmployeeIdOfMarket";
        
		public static string Vw_EmployeeIdOfTechManager = @"vw_EmployeeIdOfTechManager";
        
		public static string Vw_EmployeeInfo = @"vw_EmployeeInfo";
        
		public static string Vw_ExAsset = @"vw_ExAsset";
        
		public static string Vw_FrontM = @"vw_FrontM";
        
		public static string Vw_MarketScore = @"vw_MarketScore";
        
		public static string Vw_MasterList = @"vw_MasterList";
        
		public static string Vw_MaxNoticId = @"vw_MaxNoticId";
        
		public static string Vw_MsgGv = @"vw_MsgGv";
        
		public static string Vw_Notice = @"vw_Notice";
        
		public static string Vw_Nureseds = @"vw_Nureseds";
        
		public static string Vw_ProcessRole = @"vw_ProcessRole";
        
        
		public static string Vw_RecvMaster = @"vw_RecvMaster";
        
		public static string Vw_SumOfContract = @"vw_SumOfContract";
        
		public static string Vw_TechEmScore = @"vw_TechEmScore";
        
		public static string Vw_TechScore = @"vw_TechScore";
        
		public static string Vw_UserRoleList = @"vw_UserRoleList";
        
		public static string Vw_WksofTech = @"vw_WksofTech";
        
        
    }
    #endregion
    
    #region Query Factories
	public static partial class DB
	{
        public static DataProvider _provider = DataService.Providers["SubsonicProvider"];
        static ISubSonicRepository _repository;
        public static ISubSonicRepository Repository {
            get {
                if (_repository == null)
                    return new SubSonicRepository(_provider);
                return _repository; 
            }
            set { _repository = value; }
        }
	
        public static Select SelectAllColumnsFrom<T>() where T : RecordBase<T>, new()
	    {
            return Repository.SelectAllColumnsFrom<T>();
            
	    }
	    public static Select Select()
	    {
            return Repository.Select();
	    }
	    
		public static Select Select(params string[] columns)
		{
            return Repository.Select(columns);
        }
	    
		public static Select Select(params Aggregate[] aggregates)
		{
            return Repository.Select(aggregates);
        }
   
	    public static Update Update<T>() where T : RecordBase<T>, new()
	    {
            return Repository.Update<T>();
	    }
     
	    
	    public static Insert Insert()
	    {
            return Repository.Insert();
	    }
	    
	    public static Delete Delete()
	    {
            
            return Repository.Delete();
	    }
	    
	    public static InlineQuery Query()
	    {
            
            return Repository.Query();
	    }
	    	    
	    
	}
    #endregion
    
}
#region Databases
public partial struct Databases 
{
	
	public static string SubsonicProvider = @"SubsonicProvider";
    
}
#endregion
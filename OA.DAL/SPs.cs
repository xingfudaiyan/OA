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
namespace CanYou.OA.DAL{
    public partial class SPs{
        
        /// <summary>
        /// Creates an object wrapper for the AssistantScoregv_sp Procedure
        /// </summary>
        public static StoredProcedure AssistantScoregv_Sp(int? EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("AssistantScoregv_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmployeeId", EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the BasEmScoregv_sp Procedure
        /// </summary>
        public static StoredProcedure BasEmScoregv_Sp(int? EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("BasEmScoregv_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmployeeId", EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the BExpEmployee_sp Procedure
        /// </summary>
        public static StoredProcedure BExpEmployee_Sp(int? BusinessExpId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("BExpEmployee_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@BusinessExpId", BusinessExpId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the BExpRelate_sp Procedure
        /// </summary>
        public static StoredProcedure BExpRelate_Sp(int? BusinessExpId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("BExpRelate_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@BusinessExpId", BusinessExpId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the BothNameOfPrice_sp Procedure
        /// </summary>
        public static StoredProcedure BothNameOfPrice_Sp(string SheetNum, string ProjectName, string PreEmployeeName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("BothNameOfPrice_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@SheetNum", SheetNum, DbType.String, null, null);
        	
            sp.Command.AddParameter("@ProjectName", ProjectName, DbType.String, null, null);
        	
            sp.Command.AddParameter("@PreEmployeeName", PreEmployeeName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the BothNameOfPrice1_sp Procedure
        /// </summary>
        public static StoredProcedure BothNameOfPrice1_Sp(string SheetNum, string ProjectName, string SendEmployeeName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("BothNameOfPrice1_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@SheetNum", SheetNum, DbType.String, null, null);
        	
            sp.Command.AddParameter("@ProjectName", ProjectName, DbType.String, null, null);
        	
            sp.Command.AddParameter("@SendEmployeeName", SendEmployeeName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the BothNameOfPrice2_sp Procedure
        /// </summary>
        public static StoredProcedure BothNameOfPrice2_Sp(string SheetNum, string ProjectName, int? RecvEmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("BothNameOfPrice2_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@SheetNum", SheetNum, DbType.String, null, null);
        	
            sp.Command.AddParameter("@ProjectName", ProjectName, DbType.String, null, null);
        	
            sp.Command.AddParameter("@RecvEmployeeId", RecvEmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the BothNameOfPrice3_sp Procedure
        /// </summary>
        public static StoredProcedure BothNameOfPrice3_Sp(string SheetNum, string ProjectName, int? Recv1EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("BothNameOfPrice3_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@SheetNum", SheetNum, DbType.String, null, null);
        	
            sp.Command.AddParameter("@ProjectName", ProjectName, DbType.String, null, null);
        	
            sp.Command.AddParameter("@Recv1EmployeeId", Recv1EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the BothNameOfPrice4_sp Procedure
        /// </summary>
        public static StoredProcedure BothNameOfPrice4_Sp(string SheetNum, string ProjectName, int? Recv2EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("BothNameOfPrice4_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@SheetNum", SheetNum, DbType.String, null, null);
        	
            sp.Command.AddParameter("@ProjectName", ProjectName, DbType.String, null, null);
        	
            sp.Command.AddParameter("@Recv2EmployeeId", Recv2EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the BothNameOfSpecial_sp Procedure
        /// </summary>
        public static StoredProcedure BothNameOfSpecial_Sp(string SheetNum, int? MainProjectCreateId, int? PreEmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("BothNameOfSpecial_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@SheetNum", SheetNum, DbType.String, null, null);
        	
            sp.Command.AddParameter("@MainProjectCreateId", MainProjectCreateId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@PreEmployeeId", PreEmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the BothNameOfSpecial1_sp Procedure
        /// </summary>
        public static StoredProcedure BothNameOfSpecial1_Sp(string SheetNum, int? MainProjectCreateId, int? SendEmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("BothNameOfSpecial1_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@SheetNum", SheetNum, DbType.String, null, null);
        	
            sp.Command.AddParameter("@MainProjectCreateId", MainProjectCreateId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@SendEmployeeId", SendEmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the BothNameOfSpecial2_sp Procedure
        /// </summary>
        public static StoredProcedure BothNameOfSpecial2_Sp(string SheetNum, int? MainProjectCreateId, int? RecvEmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("BothNameOfSpecial2_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@SheetNum", SheetNum, DbType.String, null, null);
        	
            sp.Command.AddParameter("@MainProjectCreateId", MainProjectCreateId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@RecvEmployeeId", RecvEmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the BothNameOfSpecial3_sp Procedure
        /// </summary>
        public static StoredProcedure BothNameOfSpecial3_Sp(string SheetNum, int? MainProjectCreateId, int? Recv1EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("BothNameOfSpecial3_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@SheetNum", SheetNum, DbType.String, null, null);
        	
            sp.Command.AddParameter("@MainProjectCreateId", MainProjectCreateId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@Recv1EmployeeId", Recv1EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the BothNameOfSpecial4_sp Procedure
        /// </summary>
        public static StoredProcedure BothNameOfSpecial4_Sp(string SheetNum, int? MainProjectCreateId, int? Recv2EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("BothNameOfSpecial4_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@SheetNum", SheetNum, DbType.String, null, null);
        	
            sp.Command.AddParameter("@MainProjectCreateId", MainProjectCreateId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@Recv2EmployeeId", Recv2EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the BothOfClient_sp Procedure
        /// </summary>
        public static StoredProcedure BothOfClient_Sp(string ClientName, int? ClientLevelId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("BothOfClient_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@ClientName", ClientName, DbType.String, null, null);
        	
            sp.Command.AddParameter("@ClientLevelId", ClientLevelId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the BothOfProject_sp Procedure
        /// </summary>
        public static StoredProcedure BothOfProject_Sp(string ProjectName, string ProjectLevelName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("BothOfProject_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@ProjectName", ProjectName, DbType.String, null, null);
        	
            sp.Command.AddParameter("@ProjectLevelName", ProjectLevelName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the BsListOfApprove_sp Procedure
        /// </summary>
        public static StoredProcedure BsListOfApprove_Sp(int? RecvEmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("BsListOfApprove_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@RecvEmployeeId", RecvEmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the BsListOfApprove1_sp Procedure
        /// </summary>
        public static StoredProcedure BsListOfApprove1_Sp(int? Recv1EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("BsListOfApprove1_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@Recv1EmployeeId", Recv1EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the BsListOfApprove2_sp Procedure
        /// </summary>
        public static StoredProcedure BsListOfApprove2_Sp(int? Recv2EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("BsListOfApprove2_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@Recv2EmployeeId", Recv2EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the BsListOfApproves_sp Procedure
        /// </summary>
        public static StoredProcedure BsListOfApproves_Sp(int? RecvEmployeeId, int? MainBusinessExpId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("BsListOfApproves_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@RecvEmployeeId", RecvEmployeeId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@MainBusinessExpId", MainBusinessExpId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the BsListOfApproves1_sp Procedure
        /// </summary>
        public static StoredProcedure BsListOfApproves1_Sp(int? Recv1EmployeeId, int? MainBusinessExpId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("BsListOfApproves1_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@Recv1EmployeeId", Recv1EmployeeId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@MainBusinessExpId", MainBusinessExpId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the BsListOfApproves2_sp Procedure
        /// </summary>
        public static StoredProcedure BsListOfApproves2_Sp(int? Recv2EmployeeId, int? MainBusinessExpId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("BsListOfApproves2_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@Recv2EmployeeId", Recv2EmployeeId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@MainBusinessExpId", MainBusinessExpId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the BsListOfEmployee_sp Procedure
        /// </summary>
        public static StoredProcedure BsListOfEmployee_Sp(int? SendEmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("BsListOfEmployee_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@SendEmployeeId", SendEmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the BsListOfEmployee2_sp Procedure
        /// </summary>
        public static StoredProcedure BsListOfEmployee2_Sp(int? SendEmployeeId, int? MainBusinessExpId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("BsListOfEmployee2_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@SendEmployeeId", SendEmployeeId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@MainBusinessExpId", MainBusinessExpId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the BsListOfPreEmployee_sp Procedure
        /// </summary>
        public static StoredProcedure BsListOfPreEmployee_Sp(int? PreEmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("BsListOfPreEmployee_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@PreEmployeeId", PreEmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the BsListOfPreEmployee2_sp Procedure
        /// </summary>
        public static StoredProcedure BsListOfPreEmployee2_Sp(int? PreEmployeeId, int? MainBusinessExpId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("BsListOfPreEmployee2_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@PreEmployeeId", PreEmployeeId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@MainBusinessExpId", MainBusinessExpId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the BusinessExpListOfEmployee_sp Procedure
        /// </summary>
        public static StoredProcedure BusinessExpListOfEmployee_Sp(int? LoginEmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("BusinessExpListOfEmployee_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@LoginEmployeeId", LoginEmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the BusinessExpOfApprove1_sp Procedure
        /// </summary>
        public static StoredProcedure BusinessExpOfApprove1_Sp(int? Recv1EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("BusinessExpOfApprove1_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@Recv1EmployeeId", Recv1EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the BusinessExpOfApprove2_sp Procedure
        /// </summary>
        public static StoredProcedure BusinessExpOfApprove2_Sp(int? Recv2EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("BusinessExpOfApprove2_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@Recv2EmployeeId", Recv2EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the CarApply_sp Procedure
        /// </summary>
        public static StoredProcedure CarApply_Sp(int? ApplyEmId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("CarApply_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@ApplyEmId", ApplyEmId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the CarApplys_sp Procedure
        /// </summary>
        public static StoredProcedure CarApplys_Sp(int? ApplyEmId, int? MainApplyId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("CarApplys_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@ApplyEmId", ApplyEmId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@MainApplyId", MainApplyId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the CarApprove1_sp Procedure
        /// </summary>
        public static StoredProcedure CarApprove1_Sp(int? Recv1EmId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("CarApprove1_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@Recv1EmId", Recv1EmId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the CarApprove2_sp Procedure
        /// </summary>
        public static StoredProcedure CarApprove2_Sp(int? Recv2EmId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("CarApprove2_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@Recv2EmId", Recv2EmId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the CarApprove3_sp Procedure
        /// </summary>
        public static StoredProcedure CarApprove3_Sp(int? Recv3EmId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("CarApprove3_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@Recv3EmId", Recv3EmId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the CarApproves1_sp Procedure
        /// </summary>
        public static StoredProcedure CarApproves1_Sp(int? Recv1EmId, int? MainApplyId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("CarApproves1_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@Recv1EmId", Recv1EmId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@MainApplyId", MainApplyId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the CarApproves2_sp Procedure
        /// </summary>
        public static StoredProcedure CarApproves2_Sp(int? Recv2EmId, int? MainApplyId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("CarApproves2_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@Recv2EmId", Recv2EmId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@MainApplyId", MainApplyId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the CarApproves3_sp Procedure
        /// </summary>
        public static StoredProcedure CarApproves3_Sp(int? Recv3EmId, int? MainApplyId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("CarApproves3_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@Recv3EmId", Recv3EmId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@MainApplyId", MainApplyId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the ConctractFileSame_sp Procedure
        /// </summary>
        public static StoredProcedure ConctractFileSame_Sp(string FileName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ConctractFileSame_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@FileName", FileName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the ContactOfBoth_sp Procedure
        /// </summary>
        public static StoredProcedure ContactOfBoth_Sp(int? DepartId, string EmployeeName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ContactOfBoth_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@DepartId", DepartId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@EmployeeName", EmployeeName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the ContactOfDepart_sp Procedure
        /// </summary>
        public static StoredProcedure ContactOfDepart_Sp(int? DepartId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ContactOfDepart_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@DepartId", DepartId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the ContractApplyOfEm Procedure
        /// </summary>
        public static StoredProcedure ContractApplyOfEm(string ApplyName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ContractApplyOfEm", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@ApplyName", ApplyName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the ContractOfDepart Procedure
        /// </summary>
        public static StoredProcedure ContractOfDepart(string DepartName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ContractOfDepart", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@DepartName", DepartName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the DayListOfWK_sp Procedure
        /// </summary>
        public static StoredProcedure DayListOfWK_Sp(int? WeekSumId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("DayListOfWK_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@WeekSumId", WeekSumId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the DayScore_sp Procedure
        /// </summary>
        public static StoredProcedure DayScore_Sp(int? weekscoreid)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("DayScore_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@weekscoreid", weekscoreid, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the DelActionMaster_sp Procedure
        /// </summary>
        public static StoredProcedure DelActionMaster_Sp(int? masterid)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("DelActionMaster_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@masterid", masterid, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the DelDocumentOf_sp Procedure
        /// </summary>
        public static StoredProcedure DelDocumentOf_Sp(int? FileId, int? EmId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("DelDocumentOf_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@FileId", FileId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@EmId", EmId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the DepartGv_sp Procedure
        /// </summary>
        public static StoredProcedure DepartGv_Sp(string DepartName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("DepartGv_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@DepartName", DepartName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the DepartGvOfHoliday_sp Procedure
        /// </summary>
        public static StoredProcedure DepartGvOfHoliday_Sp(string DepartName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("DepartGvOfHoliday_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@DepartName", DepartName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the DepartGvOfOffice_sp Procedure
        /// </summary>
        public static StoredProcedure DepartGvOfOffice_Sp(string DepartName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("DepartGvOfOffice_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@DepartName", DepartName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the DepartGvOfTool_sp Procedure
        /// </summary>
        public static StoredProcedure DepartGvOfTool_Sp(string DepartName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("DepartGvOfTool_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@DepartName", DepartName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the DepartIdOfEmployee_sp Procedure
        /// </summary>
        public static StoredProcedure DepartIdOfEmployee_Sp(int? EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("DepartIdOfEmployee_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmployeeId", EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the Document_sp Procedure
        /// </summary>
        public static StoredProcedure Document_Sp(string PerMissionName, int? EmId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("Document_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@PerMissionName", PerMissionName, DbType.AnsiString, null, null);
        	
            sp.Command.AddParameter("@EmId", EmId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the DriverScoregv_sp Procedure
        /// </summary>
        public static StoredProcedure DriverScoregv_Sp(int? EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("DriverScoregv_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmployeeId", EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the EmIdOfLeadDepart_sp Procedure
        /// </summary>
        public static StoredProcedure EmIdOfLeadDepart_Sp(string RoleName, int? DepartId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("EmIdOfLeadDepart_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@RoleName", RoleName, DbType.String, null, null);
        	
            sp.Command.AddParameter("@DepartId", DepartId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the EmployeeAll_sp Procedure
        /// </summary>
        public static StoredProcedure EmployeeAll_Sp(int? EmId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("EmployeeAll_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmId", EmId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the EmployeeIdOfName_sp Procedure
        /// </summary>
        public static StoredProcedure EmployeeIdOfName_Sp(string EmployeeName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("EmployeeIdOfName_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmployeeName", EmployeeName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the EmployeeList_sp Procedure
        /// </summary>
        public static StoredProcedure EmployeeList_Sp(int? employeeid)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("EmployeeList_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@employeeid", employeeid, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the EmployeeOfDepart_sp Procedure
        /// </summary>
        public static StoredProcedure EmployeeOfDepart_Sp(int? DepartId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("EmployeeOfDepart_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@DepartId", DepartId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the EmployeeOfWeekSum_sp Procedure
        /// </summary>
        public static StoredProcedure EmployeeOfWeekSum_Sp(int? DepartId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("EmployeeOfWeekSum_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@DepartId", DepartId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the EmployeePermission_sp Procedure
        /// </summary>
        public static StoredProcedure EmployeePermission_Sp(int? EmId, string PerMissionName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("EmployeePermission_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmId", EmId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@PerMissionName", PerMissionName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the EmployeePermission1_sp Procedure
        /// </summary>
        public static StoredProcedure EmployeePermission1_Sp(string PerMissionName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("EmployeePermission1_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@PerMissionName", PerMissionName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the FrontScoregv_sp Procedure
        /// </summary>
        public static StoredProcedure FrontScoregv_Sp(int? EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("FrontScoregv_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmployeeId", EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the getFileApply_sp Procedure
        /// </summary>
        public static StoredProcedure GetFileApply_Sp(string EmName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("getFileApply_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmName", EmName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the getHolidayApply_sp Procedure
        /// </summary>
        public static StoredProcedure GetHolidayApply_Sp(string EmName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("getHolidayApply_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmName", EmName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the getOfficeApply_sp Procedure
        /// </summary>
        public static StoredProcedure GetOfficeApply_Sp(string EmName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("getOfficeApply_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmName", EmName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the getTaskIdFromWkId_sp Procedure
        /// </summary>
        public static StoredProcedure GetTaskIdFromWkId_Sp(int? WorkSheetId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("getTaskIdFromWkId_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@WorkSheetId", WorkSheetId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the getTaskList_sp Procedure
        /// </summary>
        public static StoredProcedure GetTaskList_Sp(int? EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("getTaskList_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmployeeId", EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the getToolApply_sp Procedure
        /// </summary>
        public static StoredProcedure GetToolApply_Sp(string EmName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("getToolApply_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmName", EmName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the HolidyApply_sp Procedure
        /// </summary>
        public static StoredProcedure HolidyApply_Sp(int? Emid)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("HolidyApply_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@Emid", Emid, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the IsActionNameOfMaster_sp Procedure
        /// </summary>
        public static StoredProcedure IsActionNameOfMaster_Sp(int? EmployeeId, string ActionName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("IsActionNameOfMaster_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmployeeId", EmployeeId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@ActionName", ActionName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the IsClientOfSheetNum_sp Procedure
        /// </summary>
        public static StoredProcedure IsClientOfSheetNum_Sp(int? ClientTypeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("IsClientOfSheetNum_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@ClientTypeId", ClientTypeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the IsDocumentExit_sp Procedure
        /// </summary>
        public static StoredProcedure IsDocumentExit_Sp(string FileName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("IsDocumentExit_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@FileName", FileName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the IsFileExit_sp Procedure
        /// </summary>
        public static StoredProcedure IsFileExit_Sp(string FileName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("IsFileExit_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@FileName", FileName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the IsNumOfContract_sp Procedure
        /// </summary>
        public static StoredProcedure IsNumOfContract_Sp(string SignName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("IsNumOfContract_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@SignName", SignName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the IsSheetNumOfBE_sp Procedure
        /// </summary>
        public static StoredProcedure IsSheetNumOfBE_Sp(string strToday)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("IsSheetNumOfBE_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@strToday", strToday, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the IsSheetNumOfCA_sp Procedure
        /// </summary>
        public static StoredProcedure IsSheetNumOfCA_Sp(string strToday)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("IsSheetNumOfCA_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@strToday", strToday, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the IsSheetNumOfCC_sp Procedure
        /// </summary>
        public static StoredProcedure IsSheetNumOfCC_Sp(string strToday)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("IsSheetNumOfCC_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@strToday", strToday, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the IsSheetNumOfOP_sp Procedure
        /// </summary>
        public static StoredProcedure IsSheetNumOfOP_Sp(string strToday)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("IsSheetNumOfOP_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@strToday", strToday, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the IsSheetNumOfPC_sp Procedure
        /// </summary>
        public static StoredProcedure IsSheetNumOfPC_Sp(string strToday)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("IsSheetNumOfPC_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@strToday", strToday, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the IsSheetNumOfSE_sp Procedure
        /// </summary>
        public static StoredProcedure IsSheetNumOfSE_Sp(string strToday)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("IsSheetNumOfSE_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@strToday", strToday, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the IsSheetNumOfWS_sp Procedure
        /// </summary>
        public static StoredProcedure IsSheetNumOfWS_Sp(string strToday)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("IsSheetNumOfWS_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@strToday", strToday, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the LevelOfClient_sp Procedure
        /// </summary>
        public static StoredProcedure LevelOfClient_Sp(int? ClientLevelId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("LevelOfClient_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@ClientLevelId", ClientLevelId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the LevelOfProject_sp Procedure
        /// </summary>
        public static StoredProcedure LevelOfProject_Sp(string ProjectLevelName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("LevelOfProject_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@ProjectLevelName", ProjectLevelName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the MarketScoregv_sp Procedure
        /// </summary>
        public static StoredProcedure MarketScoregv_Sp(int? EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("MarketScoregv_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmployeeId", EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the MessageOfEm_sp Procedure
        /// </summary>
        public static StoredProcedure MessageOfEm_Sp(int? EmId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("MessageOfEm_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmId", EmId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the MsgOfEmAndType_sp Procedure
        /// </summary>
        public static StoredProcedure MsgOfEmAndType_Sp(int? EmId, string Type)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("MsgOfEmAndType_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmId", EmId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@Type", Type, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the NameOfClient_sp Procedure
        /// </summary>
        public static StoredProcedure NameOfClient_Sp(string ClientName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("NameOfClient_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@ClientName", ClientName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the NameOfProject_sp Procedure
        /// </summary>
        public static StoredProcedure NameOfProject_Sp(string ProjectName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("NameOfProject_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@ProjectName", ProjectName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the NumOfContract_sp Procedure
        /// </summary>
        public static StoredProcedure NumOfContract_Sp(string PreIndex, string MidNum, string Today, string SignName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("NumOfContract_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@PreIndex", PreIndex, DbType.String, null, null);
        	
            sp.Command.AddParameter("@MidNum", MidNum, DbType.String, null, null);
        	
            sp.Command.AddParameter("@Today", Today, DbType.String, null, null);
        	
            sp.Command.AddParameter("@SignName", SignName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the NurseScoregv_sp Procedure
        /// </summary>
        public static StoredProcedure NurseScoregv_Sp(int? EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("NurseScoregv_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmployeeId", EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the OfferFileSame_sp Procedure
        /// </summary>
        public static StoredProcedure OfferFileSame_Sp(string FileName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("OfferFileSame_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@FileName", FileName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the OfferPriceListOfApprove_sp Procedure
        /// </summary>
        public static StoredProcedure OfferPriceListOfApprove_Sp(int? RecvEmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("OfferPriceListOfApprove_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@RecvEmployeeId", RecvEmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the OfferPriceListOfApprove1_sp Procedure
        /// </summary>
        public static StoredProcedure OfferPriceListOfApprove1_Sp(int? Recv1EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("OfferPriceListOfApprove1_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@Recv1EmployeeId", Recv1EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the OfferPriceListOfApprove2_sp Procedure
        /// </summary>
        public static StoredProcedure OfferPriceListOfApprove2_Sp(int? Recv2EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("OfferPriceListOfApprove2_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@Recv2EmployeeId", Recv2EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the OfferPriceListOfApproves_sp Procedure
        /// </summary>
        public static StoredProcedure OfferPriceListOfApproves_Sp(int? RecvEmployeeId, int? MainOfferPriceId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("OfferPriceListOfApproves_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@RecvEmployeeId", RecvEmployeeId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@MainOfferPriceId", MainOfferPriceId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the OfferPriceListOfApproves1_sp Procedure
        /// </summary>
        public static StoredProcedure OfferPriceListOfApproves1_Sp(int? Recv1EmployeeId, int? MainOfferPriceId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("OfferPriceListOfApproves1_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@Recv1EmployeeId", Recv1EmployeeId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@MainOfferPriceId", MainOfferPriceId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the OfferPriceListOfApproves2_sp Procedure
        /// </summary>
        public static StoredProcedure OfferPriceListOfApproves2_Sp(int? Recv2EmployeeId, int? MainOfferPriceId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("OfferPriceListOfApproves2_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@Recv2EmployeeId", Recv2EmployeeId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@MainOfferPriceId", MainOfferPriceId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the OfferPriceListOfEmployee_sp Procedure
        /// </summary>
        public static StoredProcedure OfferPriceListOfEmployee_Sp(int? SendEmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("OfferPriceListOfEmployee_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@SendEmployeeId", SendEmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the OfferPriceListOfEmployee2_sp Procedure
        /// </summary>
        public static StoredProcedure OfferPriceListOfEmployee2_Sp(int? SendEmployeeId, int? MainOfferPriceId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("OfferPriceListOfEmployee2_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@SendEmployeeId", SendEmployeeId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@MainOfferPriceId", MainOfferPriceId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the OfferPriceListOfPreEmployee_sp Procedure
        /// </summary>
        public static StoredProcedure OfferPriceListOfPreEmployee_Sp(int? PreEmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("OfferPriceListOfPreEmployee_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@PreEmployeeId", PreEmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the OfferPriceListOfPreEmployee2_sp Procedure
        /// </summary>
        public static StoredProcedure OfferPriceListOfPreEmployee2_Sp(int? PreEmployeeId, int? MainOfferPriceId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("OfferPriceListOfPreEmployee2_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@PreEmployeeId", PreEmployeeId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@MainOfferPriceId", MainOfferPriceId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the OfferPriceMoneySun_sp Procedure
        /// </summary>
        public static StoredProcedure OfferPriceMoneySun_Sp(int? OfferPriceId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("OfferPriceMoneySun_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@OfferPriceId", OfferPriceId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the OutRegistApply_sp Procedure
        /// </summary>
        public static StoredProcedure OutRegistApply_Sp(string EmployeeName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("OutRegistApply_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmployeeName", EmployeeName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the OutRegistApprove_sp Procedure
        /// </summary>
        public static StoredProcedure OutRegistApprove_Sp(string DepartName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("OutRegistApprove_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@DepartName", DepartName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the ProjectApplyOfClientEm_sp Procedure
        /// </summary>
        public static StoredProcedure ProjectApplyOfClientEm_Sp(string ClientName, string ApplyName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ProjectApplyOfClientEm_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@ClientName", ClientName, DbType.String, null, null);
        	
            sp.Command.AddParameter("@ApplyName", ApplyName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the ProjectApplyOfDepart Procedure
        /// </summary>
        public static StoredProcedure ProjectApplyOfDepart(string DepartName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ProjectApplyOfDepart", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@DepartName", DepartName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the ProjectApplyOfEm Procedure
        /// </summary>
        public static StoredProcedure ProjectApplyOfEm(string ApplyName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ProjectApplyOfEm", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@ApplyName", ApplyName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the ProjectApplyOfTech Procedure
        /// </summary>
        public static StoredProcedure ProjectApplyOfTech(string DepartName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ProjectApplyOfTech", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@DepartName", DepartName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the ProjectIdOfSpecial_sp Procedure
        /// </summary>
        public static StoredProcedure ProjectIdOfSpecial_Sp(int? MainProjectCreateId, int? PreEmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ProjectIdOfSpecial_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@MainProjectCreateId", MainProjectCreateId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@PreEmployeeId", PreEmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the ProjectIdOfSpecial1_sp Procedure
        /// </summary>
        public static StoredProcedure ProjectIdOfSpecial1_Sp(int? MainProjectCreateId, int? SendEmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ProjectIdOfSpecial1_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@MainProjectCreateId", MainProjectCreateId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@SendEmployeeId", SendEmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the ProjectIdOfSpecial2_sp Procedure
        /// </summary>
        public static StoredProcedure ProjectIdOfSpecial2_Sp(int? MainProjectCreateId, int? RecvEmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ProjectIdOfSpecial2_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@MainProjectCreateId", MainProjectCreateId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@RecvEmployeeId", RecvEmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the ProjectIdOfSpecial3_sp Procedure
        /// </summary>
        public static StoredProcedure ProjectIdOfSpecial3_Sp(int? MainProjectCreateId, int? Recv1EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ProjectIdOfSpecial3_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@MainProjectCreateId", MainProjectCreateId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@Recv1EmployeeId", Recv1EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the ProjectIdOfSpecial4_sp Procedure
        /// </summary>
        public static StoredProcedure ProjectIdOfSpecial4_Sp(int? MainProjectCreateId, int? Recv2EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ProjectIdOfSpecial4_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@MainProjectCreateId", MainProjectCreateId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@Recv2EmployeeId", Recv2EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the ProjectOfPrice_sp Procedure
        /// </summary>
        public static StoredProcedure ProjectOfPrice_Sp(string ProjectName, string PreEmployeeName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ProjectOfPrice_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@ProjectName", ProjectName, DbType.String, null, null);
        	
            sp.Command.AddParameter("@PreEmployeeName", PreEmployeeName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the ProjectOfPrice1_sp Procedure
        /// </summary>
        public static StoredProcedure ProjectOfPrice1_Sp(string ProjectName, string SendEmployeeName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ProjectOfPrice1_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@ProjectName", ProjectName, DbType.String, null, null);
        	
            sp.Command.AddParameter("@SendEmployeeName", SendEmployeeName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the ProjectOfPrice2_sp Procedure
        /// </summary>
        public static StoredProcedure ProjectOfPrice2_Sp(string ProjectName, int? RecvEmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ProjectOfPrice2_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@ProjectName", ProjectName, DbType.String, null, null);
        	
            sp.Command.AddParameter("@RecvEmployeeId", RecvEmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the ProjectOfPrice3_sp Procedure
        /// </summary>
        public static StoredProcedure ProjectOfPrice3_Sp(string ProjectName, int? Recv1EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ProjectOfPrice3_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@ProjectName", ProjectName, DbType.String, null, null);
        	
            sp.Command.AddParameter("@Recv1EmployeeId", Recv1EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the ProjectOfPrice4_sp Procedure
        /// </summary>
        public static StoredProcedure ProjectOfPrice4_Sp(string ProjectName, int? Recv2EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ProjectOfPrice4_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@ProjectName", ProjectName, DbType.String, null, null);
        	
            sp.Command.AddParameter("@Recv2EmployeeId", Recv2EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the RecvFile_sp Procedure
        /// </summary>
        public static StoredProcedure RecvFile_Sp(int? RecvEmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("RecvFile_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@RecvEmployeeId", RecvEmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the RelateOfClient_sp Procedure
        /// </summary>
        public static StoredProcedure RelateOfClient_Sp(int? ClientId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("RelateOfClient_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@ClientId", ClientId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the RoleNameOfMaster_sp Procedure
        /// </summary>
        public static StoredProcedure RoleNameOfMaster_Sp(string MasterName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("RoleNameOfMaster_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@MasterName", MasterName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the ScoreByNameAndDate_sp Procedure
        /// </summary>
        public static StoredProcedure ScoreByNameAndDate_Sp(int? EmployeeId, string Date1, string Date2)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ScoreByNameAndDate_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmployeeId", EmployeeId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@Date1", Date1, DbType.String, null, null);
        	
            sp.Command.AddParameter("@Date2", Date2, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the ScoreGv_sp Procedure
        /// </summary>
        public static StoredProcedure ScoreGv_Sp(int? EmployeeId, string Date1, string Date2)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ScoreGv_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmployeeId", EmployeeId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@Date1", Date1, DbType.String, null, null);
        	
            sp.Command.AddParameter("@Date2", Date2, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SendFile_sp Procedure
        /// </summary>
        public static StoredProcedure SendFile_Sp(int? EmId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SendFile_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmId", EmId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SheetNumOfBE_sp Procedure
        /// </summary>
        public static StoredProcedure SheetNumOfBE_Sp(string PreIndex, string MidToday)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SheetNumOfBE_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@PreIndex", PreIndex, DbType.String, null, null);
        	
            sp.Command.AddParameter("@MidToday", MidToday, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SheetNumOfCA_sp Procedure
        /// </summary>
        public static StoredProcedure SheetNumOfCA_Sp(string PreIndex, string MidToday)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SheetNumOfCA_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@PreIndex", PreIndex, DbType.String, null, null);
        	
            sp.Command.AddParameter("@MidToday", MidToday, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SheetNumOfCar_sp Procedure
        /// </summary>
        public static StoredProcedure SheetNumOfCar_Sp(string PreIndex, string MidToday)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SheetNumOfCar_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@PreIndex", PreIndex, DbType.String, null, null);
        	
            sp.Command.AddParameter("@MidToday", MidToday, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SheetNumOfClient_sp Procedure
        /// </summary>
        public static StoredProcedure SheetNumOfClient_Sp(string PreIndex, int? ClientTypeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SheetNumOfClient_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@PreIndex", PreIndex, DbType.String, null, null);
        	
            sp.Command.AddParameter("@ClientTypeId", ClientTypeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SheetNumOfCreate_sp Procedure
        /// </summary>
        public static StoredProcedure SheetNumOfCreate_Sp(int? ProjectCreateId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SheetNumOfCreate_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@ProjectCreateId", ProjectCreateId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SheetNumOfOP_sp Procedure
        /// </summary>
        public static StoredProcedure SheetNumOfOP_Sp(string PreIndex, string MidToday)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SheetNumOfOP_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@PreIndex", PreIndex, DbType.String, null, null);
        	
            sp.Command.AddParameter("@MidToday", MidToday, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SheetNumOfPC_sp Procedure
        /// </summary>
        public static StoredProcedure SheetNumOfPC_Sp(string PreIndex, string MidToday)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SheetNumOfPC_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@PreIndex", PreIndex, DbType.String, null, null);
        	
            sp.Command.AddParameter("@MidToday", MidToday, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SheetNumOfPrice_sp Procedure
        /// </summary>
        public static StoredProcedure SheetNumOfPrice_Sp(string SheetNum, string PreEmployeeName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SheetNumOfPrice_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@SheetNum", SheetNum, DbType.String, null, null);
        	
            sp.Command.AddParameter("@PreEmployeeName", PreEmployeeName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SheetNumOfPrice1_sp Procedure
        /// </summary>
        public static StoredProcedure SheetNumOfPrice1_Sp(string SheetNum, string SendEmployeeName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SheetNumOfPrice1_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@SheetNum", SheetNum, DbType.String, null, null);
        	
            sp.Command.AddParameter("@SendEmployeeName", SendEmployeeName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SheetNumOfPrice2_sp Procedure
        /// </summary>
        public static StoredProcedure SheetNumOfPrice2_Sp(string SheetNum, int? RecvEmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SheetNumOfPrice2_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@SheetNum", SheetNum, DbType.String, null, null);
        	
            sp.Command.AddParameter("@RecvEmployeeId", RecvEmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SheetNumOfPrice3_sp Procedure
        /// </summary>
        public static StoredProcedure SheetNumOfPrice3_Sp(string SheetNum, int? Recv1EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SheetNumOfPrice3_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@SheetNum", SheetNum, DbType.String, null, null);
        	
            sp.Command.AddParameter("@Recv1EmployeeId", Recv1EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SheetNumOfPrice4_sp Procedure
        /// </summary>
        public static StoredProcedure SheetNumOfPrice4_Sp(string SheetNum, int? Recv2EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SheetNumOfPrice4_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@SheetNum", SheetNum, DbType.String, null, null);
        	
            sp.Command.AddParameter("@Recv2EmployeeId", Recv2EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SheetNumOfProject_sp Procedure
        /// </summary>
        public static StoredProcedure SheetNumOfProject_Sp(string PreIndex, string MidNum, string Today)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SheetNumOfProject_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@PreIndex", PreIndex, DbType.String, null, null);
        	
            sp.Command.AddParameter("@MidNum", MidNum, DbType.String, null, null);
        	
            sp.Command.AddParameter("@Today", Today, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SheetNumOfSE_sp Procedure
        /// </summary>
        public static StoredProcedure SheetNumOfSE_Sp(string PreIndex, string MidToday)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SheetNumOfSE_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@PreIndex", PreIndex, DbType.String, null, null);
        	
            sp.Command.AddParameter("@MidToday", MidToday, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SheetNumOfSpecial_sp Procedure
        /// </summary>
        public static StoredProcedure SheetNumOfSpecial_Sp(string SheetNum, int? PreEmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SheetNumOfSpecial_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@SheetNum", SheetNum, DbType.String, null, null);
        	
            sp.Command.AddParameter("@PreEmployeeId", PreEmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SheetNumOfSpecial1_sp Procedure
        /// </summary>
        public static StoredProcedure SheetNumOfSpecial1_Sp(string SheetNum, int? SendEmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SheetNumOfSpecial1_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@SheetNum", SheetNum, DbType.String, null, null);
        	
            sp.Command.AddParameter("@SendEmployeeId", SendEmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SheetNumOfSpecial2_sp Procedure
        /// </summary>
        public static StoredProcedure SheetNumOfSpecial2_Sp(string SheetNum, int? RecvEmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SheetNumOfSpecial2_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@SheetNum", SheetNum, DbType.String, null, null);
        	
            sp.Command.AddParameter("@RecvEmployeeId", RecvEmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SheetNumOfSpecial3_sp Procedure
        /// </summary>
        public static StoredProcedure SheetNumOfSpecial3_Sp(string SheetNum, int? Recv1EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SheetNumOfSpecial3_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@SheetNum", SheetNum, DbType.String, null, null);
        	
            sp.Command.AddParameter("@Recv1EmployeeId", Recv1EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SheetNumOfSpecial4_sp Procedure
        /// </summary>
        public static StoredProcedure SheetNumOfSpecial4_Sp(string SheetNum, int? Recv2EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SheetNumOfSpecial4_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@SheetNum", SheetNum, DbType.String, null, null);
        	
            sp.Command.AddParameter("@Recv2EmployeeId", Recv2EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SheetNumOfWS_sp Procedure
        /// </summary>
        public static StoredProcedure SheetNumOfWS_Sp(string PreIndex, string MidToday)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SheetNumOfWS_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@PreIndex", PreIndex, DbType.String, null, null);
        	
            sp.Command.AddParameter("@MidToday", MidToday, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SpecialExpListOfEmployee_sp Procedure
        /// </summary>
        public static StoredProcedure SpecialExpListOfEmployee_Sp(int? LoginEmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SpecialExpListOfEmployee_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@LoginEmployeeId", LoginEmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SpecialExpOfApprove_sp Procedure
        /// </summary>
        public static StoredProcedure SpecialExpOfApprove_Sp(int? RecvEmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SpecialExpOfApprove_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@RecvEmployeeId", RecvEmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SpecialExpOfApprove1_sp Procedure
        /// </summary>
        public static StoredProcedure SpecialExpOfApprove1_Sp(int? Recv1EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SpecialExpOfApprove1_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@Recv1EmployeeId", Recv1EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SpecialExpOfApprove2_sp Procedure
        /// </summary>
        public static StoredProcedure SpecialExpOfApprove2_Sp(int? Recv2EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SpecialExpOfApprove2_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@Recv2EmployeeId", Recv2EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SpecialExpOfApproves_sp Procedure
        /// </summary>
        public static StoredProcedure SpecialExpOfApproves_Sp(int? RecvEmployeeId, int? MainSpecialExpId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SpecialExpOfApproves_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@RecvEmployeeId", RecvEmployeeId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@MainSpecialExpId", MainSpecialExpId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SpecialExpOfApproves1_sp Procedure
        /// </summary>
        public static StoredProcedure SpecialExpOfApproves1_Sp(int? Recv1EmployeeId, int? MainSpecialExpId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SpecialExpOfApproves1_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@Recv1EmployeeId", Recv1EmployeeId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@MainSpecialExpId", MainSpecialExpId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SpecialExpOfApproves2_sp Procedure
        /// </summary>
        public static StoredProcedure SpecialExpOfApproves2_Sp(int? Recv2EmployeeId, int? MainSpecialExpId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SpecialExpOfApproves2_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@Recv2EmployeeId", Recv2EmployeeId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@MainSpecialExpId", MainSpecialExpId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SpecialExpOfEmployee_sp Procedure
        /// </summary>
        public static StoredProcedure SpecialExpOfEmployee_Sp(int? SendEmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SpecialExpOfEmployee_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@SendEmployeeId", SendEmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SpecialExpOfEmployee2_sp Procedure
        /// </summary>
        public static StoredProcedure SpecialExpOfEmployee2_Sp(int? SendEmployeeId, int? MainSpecialExpId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SpecialExpOfEmployee2_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@SendEmployeeId", SendEmployeeId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@MainSpecialExpId", MainSpecialExpId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SpecialExpOfPreEmployee_sp Procedure
        /// </summary>
        public static StoredProcedure SpecialExpOfPreEmployee_Sp(int? PreEmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SpecialExpOfPreEmployee_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@PreEmployeeId", PreEmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the SpecialExpOfPreEmployee2_sp Procedure
        /// </summary>
        public static StoredProcedure SpecialExpOfPreEmployee2_Sp(int? PreEmployeeId, int? MainSpecialExpId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("SpecialExpOfPreEmployee2_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@PreEmployeeId", PreEmployeeId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@MainSpecialExpId", MainSpecialExpId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the StampApply_sp Procedure
        /// </summary>
        public static StoredProcedure StampApply_Sp(string EmName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("StampApply_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmName", EmName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the StampApprove1_sp Procedure
        /// </summary>
        public static StoredProcedure StampApprove1_Sp(string DepartName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("StampApprove1_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@DepartName", DepartName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the TechEmScoregv_sp Procedure
        /// </summary>
        public static StoredProcedure TechEmScoregv_Sp(int? EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("TechEmScoregv_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmployeeId", EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the Techgv_sp Procedure
        /// </summary>
        public static StoredProcedure Techgv_Sp(string DepartName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("Techgv_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@DepartName", DepartName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the TechMaScoregv_sp Procedure
        /// </summary>
        public static StoredProcedure TechMaScoregv_Sp(int? EmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("TechMaScoregv_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmployeeId", EmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the ToolApply_sp Procedure
        /// </summary>
        public static StoredProcedure ToolApply_Sp(int? EmId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ToolApply_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmId", EmId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the ToolApplys_sp Procedure
        /// </summary>
        public static StoredProcedure ToolApplys_Sp(int? EmId, int? MainId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ToolApplys_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmId", EmId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@MainId", MainId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the ToolApprove1_sp Procedure
        /// </summary>
        public static StoredProcedure ToolApprove1_Sp(int? EmId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ToolApprove1_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmId", EmId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the ToolApprove2_sp Procedure
        /// </summary>
        public static StoredProcedure ToolApprove2_Sp(int? EmId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ToolApprove2_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmId", EmId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the ToolApproves1_sp Procedure
        /// </summary>
        public static StoredProcedure ToolApproves1_Sp(int? EmId, int? MainId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ToolApproves1_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmId", EmId, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@MainId", MainId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the ToolSum_sp Procedure
        /// </summary>
        public static StoredProcedure ToolSum_Sp(int? EmId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ToolSum_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmId", EmId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the UploadDocument_sp Procedure
        /// </summary>
        public static StoredProcedure UploadDocument_Sp(int? EmId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("UploadDocument_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@EmId", EmId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the UserFileEmployee_sp Procedure
        /// </summary>
        public static StoredProcedure UserFileEmployee_Sp(string PermissionName)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("UserFileEmployee_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@PermissionName", PermissionName, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the UserLogin_sp Procedure
        /// </summary>
        public static StoredProcedure UserLogin_Sp(string UserName, string UserPassword)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("UserLogin_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@UserName", UserName, DbType.String, null, null);
        	
            sp.Command.AddParameter("@UserPassword", UserPassword, DbType.String, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the WeekSumListOfApprove_sp Procedure
        /// </summary>
        public static StoredProcedure WeekSumListOfApprove_Sp(int? RecvEmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("WeekSumListOfApprove_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@RecvEmployeeId", RecvEmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the WeekSumListOfEmployee_sp Procedure
        /// </summary>
        public static StoredProcedure WeekSumListOfEmployee_Sp(int? LoginEmployeeId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("WeekSumListOfEmployee_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@LoginEmployeeId", LoginEmployeeId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the WorkToolListOfWTSum_sp Procedure
        /// </summary>
        public static StoredProcedure WorkToolListOfWTSum_Sp(int? WorkToolSumId)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("WorkToolListOfWTSum_sp", DataService.GetInstance("SubsonicProvider"), "dbo");
        	
            sp.Command.AddParameter("@WorkToolSumId", WorkToolSumId, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
    }
    
}

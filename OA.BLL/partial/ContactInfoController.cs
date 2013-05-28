// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： ContactInfo.cs
// createDate：2012-3-29

// ===================================================================
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using CanYouLib.Exceptions;
using CanYou.OA.DAL;
using SubSonic;
using CanYouLib;


namespace CanYou.OA.BLL
{
   /// <summary>
    /// ???ContactInfoController?ObjectDataSource???
    /// </summary>
 	public partial class ContactInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(ContactInfo pContactInfo)
		{
			ContactInfo contactInfo = new ContactInfo(pContactInfo.ContactId);
            contactInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public ContactInfo GetContactInfoById(int ContactId)
        {
			   
			ContactInfo contactInfo  = null;//
            try
            {
                 contactInfo = new ContactInfo(ContactId);

            }
            catch (AppException)
            {
                return null;
            }

            return  contactInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ContactInfo> GetContactInfoList()
        {
            return ContactInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ContactInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return ContactInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveContactInfo(ContactInfo contactInfo)
        {
            contactInfo.Save();
			return contactInfo . ContactId;
        }
		
	}
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMH.Common;
using AMH.Common.Paging;
using AMH.Entities.Contract;
namespace AMH.Services.Contract
{
    public abstract class AbstractAdminServices
    {
        public abstract bool Admin_SignOut();
        //public abstract SuccessResult<AbstractAdmin> Admin_ChangePassword(long Id, string OldPassword, string NewPassword, string ConfirmPassword);
        public abstract SuccessResult<AbstractAdmin> Admin_SignIn(string Email, string Password);
        public abstract SuccessResult<AbstractAdmin> Admin_ById(int Admin_Id);
        public abstract PagedList<AbstractAdmin> Admin_All(PageParam pageParam, string search,int IsVisibleAll);
        public abstract SuccessResult<AbstractAdmin> Admin_Upsert(AbstractAdmin abstractAdmin);
        public abstract SuccessResult<AbstractAdmin> Admin_ActInact(int Admin_Id, int Updatedby);
        public abstract SuccessResult<AbstractAdmin> Admin_Delete(int Admin_Id, int Deletedby);
        public abstract SuccessResult<AbstractAdmin> Home_All();

      

    }
}

﻿using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Interface
{
    interface IAdminService
    {
        IEnumerable<AdminPivot> GetALL();
        AdminPivot GetAdmin(long id);
       void DeleteAdminPivot(AdminPivot admin);
        void UpdateAdminPivot(AdminPivot admin);
        void CreateAdminPivot(AdminPivot admin);
        void SaveAdminPivot();
    }
}

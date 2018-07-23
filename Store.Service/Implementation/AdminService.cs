﻿using AutoMapper;
using Store.Data.Infrastructure;
using Store.Data.Repositories;
using Store.Model;
using Store.Service.Interface;
using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Implementation
{
    class AdminService : IAdminService
    {
        private readonly IAdminRepository adminRepository;
        private readonly IUnitOfWork unitOfWork;

        public AdminService(IAdminRepository adminRepository, IUnitOfWork unitOfWork)
        {
            this.adminRepository = adminRepository;
            this.unitOfWork = unitOfWork;
        }
        public void CreateAdminPivot(AdminPivot adminPivot)
        {
            GES_Admin admin = Mapper.Map<AdminPivot, GES_Admin>(adminPivot);
            adminRepository.Add(admin);
        }

        public void DeleteAdminPivot(AdminPivot admin)
        {
            adminRepository.Delete(Mapper.Map<AdminPivot, GES_Admin>(admin));
        }

        public AdminPivot GetAdmin(long id)
        {
            var admin= adminRepository.GetById((int)id);
            AdminPivot itemPivot = Mapper.Map<GES_Admin, AdminPivot>(admin);
            return itemPivot;
        }

        public IEnumerable<AdminPivot> GetALL()
        {
            IEnumerable<GES_Admin> admins = adminRepository.GetAll().ToList();
            IEnumerable<AdminPivot> adminPivots = Mapper.Map<IEnumerable<GES_Admin>, IEnumerable<AdminPivot>>(admins);
            return adminPivots;
        }

        public void SaveAdminPivot()
        {
            unitOfWork.Commit();
        }

        public void UpdateAdminPivot(AdminPivot admin)
        {
            adminRepository.Update(Mapper.Map<AdminPivot, GES_Admin>(admin));
        }
    }
}

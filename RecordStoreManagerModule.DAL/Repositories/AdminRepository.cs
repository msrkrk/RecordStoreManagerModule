using RecordStoreManagerModule.DAL.Context;
using RecordStoreManagerModule.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStoreManagerModule.DAL.Repositories
{
    public class AdminRepository : GenericRepository<Admin>, IAdminRepository
    {
        public AdminRepository(AppDbContext context) : base(context)
        {
        }

        public Admin GetAdminByUserName(string userName)
        {
            var admins = _entities.ToList();
            var admin = admins.FirstOrDefault(x=> x.UserName == userName);
            return admin;
        }
    }
}

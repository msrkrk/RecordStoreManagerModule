using RecordStoreManagerModule.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStoreManagerModule.DAL.Repositories
{
    public interface IAdminRepository : IGenericRepository<Admin>
    {
        Admin GetAdminByUserName(string userName);

  
    }
}

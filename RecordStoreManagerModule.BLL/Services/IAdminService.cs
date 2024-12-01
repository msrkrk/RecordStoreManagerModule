using RecordStoreManagerModule.BLL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStoreManagerModule.BLL.Services
{
    public interface IAdminService
    {
        AdminDto Login(string username, string password);

        void Register(AdminDto registerAdminDto);

        AdminDto GetAdminByUserName(string userName);
    }
}

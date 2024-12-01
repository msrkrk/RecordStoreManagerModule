using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStoreManagerModule.BLL.Services
{
    public interface IHashService
    {
        string GetHashCode(string password);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStoreManagerModule.DAL.Entities
{
    public class Admin:BaseClass
    {
        public string UserName { get; set; }

        public string Password { get; set; }
    }
}

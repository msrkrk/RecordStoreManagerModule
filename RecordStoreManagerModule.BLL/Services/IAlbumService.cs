using RecordStoreManagerModule.BLL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStoreManagerModule.BLL.Services
{
    public interface IAlbumService
    {
        List<AlbumDto> GetAll();
        void Add(AlbumDto album);
        void Update(AlbumDto album);
        void Delete(int id);
    }
}

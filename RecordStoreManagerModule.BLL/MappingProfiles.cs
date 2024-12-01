using AutoMapper;
using RecordStoreManagerModule.BLL.Dtos;
using RecordStoreManagerModule.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStoreManagerModule.BLL
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<AdminDto, Admin>().ReverseMap();
            CreateMap<AlbumDto, Album>().ReverseMap();
        }
    }
}

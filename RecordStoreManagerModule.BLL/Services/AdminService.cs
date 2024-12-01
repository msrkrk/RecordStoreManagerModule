using AutoMapper;
using RecordStoreManagerModule.BLL.Dtos;
using RecordStoreManagerModule.DAL.Entities;
using RecordStoreManagerModule.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStoreManagerModule.BLL.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Admin> _genericRepository;

        public AdminService(IAdminRepository adminRepository, IMapper mapper, IGenericRepository<Admin> genericRepository)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
            _adminRepository = adminRepository;
        }

        public AdminDto? GetAdminByUserName(string userName)
        {
            var admin = _adminRepository.GetAdminByUserName(userName);
            if (admin != null)
            {
                return _mapper.Map<AdminDto>(admin);
            }

            return null;

        }

        public AdminDto Login(string username, string password)
        {
           var admin = _genericRepository.GetAll().FirstOrDefault(x => x.UserName == username && x.Password == password);

            return _mapper.Map<AdminDto>(admin);
        }

        public void Register(AdminDto registerAdminDto)
        {
            _genericRepository.Add(_mapper.Map<Admin>(registerAdminDto));
        }
    }
}

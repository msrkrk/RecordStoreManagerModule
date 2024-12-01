﻿using AutoMapper;
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
    public class AlbumService : IAlbumService
    {
        private readonly IMapper _mapper;

        private readonly IGenericRepository<Album> _genericRepository;
        public AlbumService(
            IMapper mapper,
            IGenericRepository<Album> genericRepository
            )
        {
            _mapper = mapper;
            _genericRepository = genericRepository;
        }

        public void Add(AlbumDto dto)
        {
            var album = _mapper.Map<Album>(dto);
            _genericRepository.Add(album);
        }

        public void Delete(int id)
        {
            _genericRepository.Delete(id);
        }

        public List<AlbumDto> GetAll()
        {
            var allAlbums = _genericRepository.GetAll();

            return allAlbums.Select(a => _mapper.Map<AlbumDto>(a)).ToList();
        }

        public void Update(AlbumDto dto)
        {
            var album = _mapper.Map<Album>(dto);
            _genericRepository.Update(album);
        }
    }
}
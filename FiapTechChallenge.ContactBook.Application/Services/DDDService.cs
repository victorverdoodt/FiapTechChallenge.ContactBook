﻿using AutoMapper;
using FiapTechChallenge.ContactBook.Application.Interfaces;
using FiapTechChallenge.ContactBook.Domain.Core.Entities;
using FiapTechChallenge.ContactBook.Domain.Core.Interfaces.Repositories;
using FiapTechChallenge.ContactBook.Domain.Services;

namespace FiapTechChallenge.ContactBook.Application.Services
{
    public class DDDService : AsyncService<DDD>, IDDDService
    {
        private readonly IDDDRepository _repository;
        public DDDService(IDDDRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
        }

        public async Task<DDD> GetDDDByCodeAsync(string code)
        {
            var result = await _repository.Find(x => x.Code == code);

            return result.Single();
        }
    }
}

using FiapTechChallenge.ContactBook.Application.Interfaces;
using FiapTechChallenge.ContactBook.Application.Services;
using FiapTechChallenge.ContactBook.Domain.Core.Entities;
using FiapTechChallenge.ContactBook.Domain.Core.Interfaces.Default;
using FiapTechChallenge.ContactBook.Domain.Core.Interfaces.Repositories;
using FiapTechChallenge.ContactBook.Domain.Core.Validators;
using FiapTechChallenge.ContactBook.Domain.Repositories;
using FiapTechChallenge.ContactBook.Domain.Services;
using FiapTechChallenge.ContactBook.Infrastructure.Data.Repositories;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FiapTechChallenge.ContactBook.Infrastructure.IOC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IValidator<Contact>, ContactValidator>();
            //Abstractions
            services.AddScoped(typeof(IAsyncService<>), typeof(AsyncService<>));
            services.AddScoped(typeof(IAsyncRepository<>), typeof(AsyncRepository<>));

            //Repositories
            services.AddScoped<IDDDRepository, DDDRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IRegionRepository, RegionRepository>();

            //Services
            services.AddScoped<IDDDService, DDDService>();
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IRegionService, RegionService>();
        }
    }
}

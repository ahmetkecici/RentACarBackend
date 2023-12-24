using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using Business.Mapping.Automapper;
using Dal.Abstract;
using Dal.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Business.DependencyResolvers
{
    public static class ServiceColections
    {
        public static IServiceCollection AddDependencies(this IServiceCollection serviceCollection)
        {

            serviceCollection.AddDbContext<RentACarContext>();
            serviceCollection.AddAutoMapper(opt =>
            {
                opt.AddProfile(new UserMappingProfile());
                opt.AddProfile(new CarMappingProfile());
            });
            serviceCollection.AddScoped<IAccountService, AccounService>();
            serviceCollection.AddScoped<IUserDal, EfUserDal>();
            serviceCollection.AddScoped<IUserService, UserService>();

            serviceCollection.AddScoped<ICarDal, EfCarDal>();
            serviceCollection.AddScoped<ICarService, CarService>();
            return serviceCollection;
        }
    }
}

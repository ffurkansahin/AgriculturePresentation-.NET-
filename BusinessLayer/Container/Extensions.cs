using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependecies(this IServiceCollection services)
        {
            services.AddScoped<IServiceService, ServiceManager>();
            services.AddScoped<IServiceDAL, EfServiceDAL>();
            services.AddScoped<ITeamService, TeamManager>();
            services.AddScoped<ITeamDAL, EfTeamDAL>();
            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnnouncementDAL, EfAnnouncementDAL>();
            services.AddScoped<IImageService, ImageManager>();
            services.AddScoped<IImageDAL, EfImageDAL>();
            services.AddScoped<IAddressService, AddressManager>();
            services.AddScoped<IAddressDAL, EfAddressDAL>();
            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IContactDAL, EfContactDAL>();
            services.AddScoped<ISocialMediaService, SocialMediaManager>();
            services.AddScoped<ISocialMediaDAL, EfSocialMediaDAL>();
            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IAboutDAL, EfAboutDAL>();
            services.AddScoped<IAdminService, AdminManager>();
            services.AddScoped<IAdminDAL, EfAdminDAL>();
        }
    }
}

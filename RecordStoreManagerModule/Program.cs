using AutoMapper;
using RecordStoreManagerModule.BLL;
using RecordStoreManagerModule.BLL.Services;
using RecordStoreManagerModule.DAL.Context;
using RecordStoreManagerModule.DAL.Entities;
using RecordStoreManagerModule.DAL.Repositories;

namespace RecordStoreManagerModule
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfiles());
            });

            IMapper mapper = new Mapper(mapperConfig);

            var context = new AppDbContext();
            var hashService = new HashService();
            var adminGenericRepository = new GenericRepository<Admin>(context);
            var adminRepository = new AdminRepository(context);
            var adminService = new AdminService(adminRepository, mapper, adminGenericRepository);

            var albumGenericRepository = new GenericRepository<Album>(context);
            var albumService = new AlbumService(mapper, albumGenericRepository);

            Application.Run(new LoginForm(adminService, mapper, hashService, albumService));
        }
    }
}
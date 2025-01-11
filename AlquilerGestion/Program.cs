using Microsoft.Extensions.DependencyInjection;
using BussinessLogic.Services;
using DataLayer.Repositories;
using DataLayer.Interfaces;
using BussinessLogic.Interfaces;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using Departamento = AlquilerGestion.Windows.Departamentos;
using Inquilino = AlquilerGestion.Windows.Inquilinos;
using Pagos = AlquilerGestion.Windows.Pagos;
using HistorialAlquilercs = AlquilerGestion.Windows.HistorialAlquilercs;
using AlquilerGestion.SecondWindows;

namespace AlquilerGestion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static IServiceProvider ServiceProvider;
        [STAThread]
        static void Main()
        {
            // Aqui configuramos la inyección de dependencias
            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(ServiceProvider.GetRequiredService<Form1>());
        }

        private static void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlite("Data Source = MalvinasDB.sqlite");
            });

            RegistrarRepositoriosYServicios(services);

            // Registrar formularios
            services.AddTransient<Form1>();
            services.AddTransient<Departamento>();
            services.AddTransient<Inquilino>();
            services.AddTransient<Pagos>();
            services.AddTransient<HistorialAlquilercs>();
            services.AddTransient<FormInquilinos>();
        }

        private static void RegistrarRepositoriosYServicios(IServiceCollection services)
        {

            // Registrar repositorios genéricos
            services.AddTransient<IGenericRepositry<Departamentos>, GenericRepository<Departamentos>>();
            services.AddTransient<IGenericRepositry<Inquilinos>, GenericRepository<Inquilinos>>();
            services.AddTransient<IGenericRepositry<HistorialAlquiler>, GenericRepository<HistorialAlquiler>>();
            services.AddTransient<IGenericRepositry<Pago>, GenericRepository<Pago>>();
            services.AddTransient<IGenericRelations<Pago>, PagoRepository>();
            services.AddTransient<IGenericRelations<HistorialAlquiler>, AlquilerRepository>();

            // Registrar servicios
            services.AddTransient<IDepartamentosServices, DepartamentosServices>();
            services.AddTransient<IInquilinosService, InquilinosServices>();
            services.AddTransient<IAlquilerService, AlquilerService>();
            services.AddTransient<IPagosService, PagosServices>();
            services.AddTransient<GlobalSearch>();
            services.AddTransient<IGlobalSearch, GlobalSearch>();
            services.AddTransient<IGlobalSearchServices, GlobalSearchService>();

        }

    }
}
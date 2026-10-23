using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Context;
using DevExpress.XtraRichEdit.Import.OpenXml;
using Microsoft.Extensions.DependencyInjection;
using UI;
using UI.Forms;

namespace UI
{
    internal static class Program
    {
        public static IServiceProvider serviceProvider { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            ConfigureService(services);
            serviceProvider = services.BuildServiceProvider();

            //var homeform = serviceProvider.GetRequiredService<OrderForm>();
            //Application.Run(homeform);

            Application.Run(new LoginForm());
        }
        private static void ConfigureService(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>();

            //Data Access katmanı
            services.AddScoped<ICategoryRepository, EfCategoryRepository>();
            services.AddScoped<IItemRepository, EfItemRepository>();
            services.AddScoped<IStockOnHandRepository, EfStockOnHandRepository>();
            services.AddScoped<ICustomerTypeRepository, EfCustomerTypeRepository>();
            services.AddScoped<IProvinceRepository, EfProvinceRepository>();
            services.AddScoped<IDistrictRepository, EfDistrictRepository>();
            services.AddScoped<ICustomerRepository, EfCustomerRepository>();
            services.AddScoped<IOrderRepository, EfOrderRepository>();
            services.AddScoped<IOrderLineRepository, EfOrderLineRepository>();
            services.AddScoped<IPaymentRepository, EfPaymentRepository>();
            services.AddScoped<IOrderStatusRepository, EfOrderStatusRepository>();
            services.AddScoped<IOrderTypeRepository, EfOrderTypeRepository>();
            services.AddScoped<IOrderStockReservationRepository, EfOrderStockReservationRepository>();

            //Business Katmanı
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IItemService, ItemManager>();
            services.AddScoped<IStockOnHandService, StockOnHandManager>();
            services.AddScoped<ICustomerTypeService, CustomerTypeManager>();
            services.AddScoped<IProvinceService, ProvinceManager>();
            services.AddScoped<IDistrictService, DistrictManager>();
            services.AddScoped<ICustomerService, CustomerManager>();
            services.AddScoped<IOrderService, OrderManager>();
            services.AddScoped<IOrderLineService, OrderLineManager>();
            services.AddScoped<IPaymentService, PaymentManager>();
            services.AddScoped<IOrderStatusService, OrderStatusManager>();
            services.AddScoped<IOrderTypeService, OrderTypeManager>();
            services.AddScoped<IOrderStockReservationService, OrderStockReservationManager>();

            //Form ekranları
            services.AddTransient<ItemManagementForm>();
            services.AddTransient<StockForm>();
            services.AddTransient<CustomerForm>();
            services.AddTransient<OrderForm>();
            services.AddTransient<OrderStockForm>();
        }
    }
}
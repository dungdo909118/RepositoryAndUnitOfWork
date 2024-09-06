using Microsoft.EntityFrameworkCore;
using OM.Business.Customer;
using OM.Business.Order;
using OM.Business.OrderDetail;
using OM.Business.Product;
using OM.Data.DBContext;
using OM.Data.Repository.Implements;
using OM.Data.Repository.Interfaces;

namespace OM.API
{
    public static class IoC
    {
        public static void RegistrationIoc(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICustomerBo, CustomerBo>();
            services.AddScoped<IProductBo, ProductBo>();
            services.AddScoped<IOrderBo, OrderBo>();
            services.AddScoped<IOrderDetailBo, OrderDetailBo>();
            services.AddDbContext<OMDBContext>(options => options.UseMySql("server=localhost;database=ordermanager;user id=root;password=1234@1234aS", new MySqlServerVersion(new Version(8, 0, 38))));
        }
    }
}

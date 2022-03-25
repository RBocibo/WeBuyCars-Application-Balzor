using Microsoft.EntityFrameworkCore;
using WeSellCars.Shared;

namespace WeSellCars.Server
{
    public class WeSellCarsDataContext :DbContext
    {
        public WeSellCarsDataContext(DbContextOptions<WeSellCarsDataContext> options)
            : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<Customer> Customers { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var carEntity = modelBuilder.Entity<Car>();

            //Car entity
            carEntity.HasKey(c => c.CarId);
            carEntity.Property(c => c.Name).HasMaxLength(50);
            carEntity.Property(c => c.Model).HasMaxLength(50);
            carEntity.Property(c => c.Price).HasColumnType("money");
            carEntity.Property(c => c.CarType).HasConversion<string>();

            var ordersEntity = modelBuilder.Entity<Order>();
            ordersEntity.HasKey(order => order.Id);
            ordersEntity.HasOne(order => order.Customer);
            ordersEntity.HasMany(order => order.Cars).WithMany(c => c.Orders);

            var customerEntity = modelBuilder.Entity<Customer>();
            customerEntity.HasKey(customer => customer.CustomerId);
            customerEntity.Property(customer => customer.CustomerName).HasMaxLength(100);
            customerEntity.Property(customer => customer.CustomerEmail).HasMaxLength(100);
            customerEntity.Property(customer => customer.Street).HasMaxLength(50);
            customerEntity.Property(customer => customer.City).HasMaxLength(50);
            customerEntity.Property(cus => cus.Province).HasMaxLength(50);
        }
    }
}

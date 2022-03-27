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

            carEntity.HasKey(car => car.CarId);
            carEntity.Property(car => car.Price)
              .HasColumnType("money");

            var customerEntity = modelBuilder.Entity<Customer>();
            customerEntity.HasKey(customer => customer.CustomerId);
            customerEntity.HasOne(customer => customer.Order)
                          .WithOne(order => order.Customer)
                          .HasForeignKey<Order>(
                             order => order.CustomerId);

            var orderEntity = modelBuilder.Entity<Order>();
            orderEntity.HasKey(order => order.Id);
            orderEntity.HasMany(order => order.CarOrders)
                       .WithOne(carOrder => carOrder.Order);

            modelBuilder.Entity<CarOrder>()
              .HasOne(co => co.Car)
              .WithMany();
        }
    }
}

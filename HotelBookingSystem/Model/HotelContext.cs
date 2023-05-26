using HotelBookingSystem.Model;
using HotelManagement.Model;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingSystem.Model
{
    public class HotelContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }

        

        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {

        }
    }
}


   


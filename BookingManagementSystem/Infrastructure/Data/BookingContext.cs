using BookingManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace BookingManagementSystem.Infrastructure.Data;

public class BookingContext : DbContext   // ← inherit DbContext
{
    public BookingContext(DbContextOptions<BookingContext> options) : base(options)
    {
    }
    
    public DbSet<Booking> Bookings { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Property> Properties { get; set; } = null!;
}
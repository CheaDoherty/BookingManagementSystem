using BookingManagementSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookingManagementSystem.Infrastructure.Data;

public class BookingContext : IdentityDbContext
{
    public BookingContext(DbContextOptions<BookingContext> options) : base(options)
    {
    }
    
    public DbSet<Booking> Bookings { get; set; } = null!;
    public DbSet<Property> Properties { get; set; } = null!;
}
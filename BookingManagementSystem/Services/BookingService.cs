using BookingManagementSystem.Infrastructure.Data;
using BookingManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace BookingManagementSystem.Services;

//TODO - Add validation,null handling & error handling
//TODO - Change return types to something with 'Status' and 'Result'
public class BookingService : IBookingService
{
    private readonly BookingContext _context;

    public BookingService(BookingContext context)
    {
        _context = context;
    }

    public async Task<Booking> GetBookingAsync(Guid id)
    {
        return await _context.Bookings.FindAsync(id);
    }

    public async Task<IEnumerable<Booking>> GetBookingsAsync()
    {
        return await _context.Bookings.ToListAsync();
    }

    public async Task<IEnumerable<Booking>> GetBookingsByUserId(string userId)
    {
        return await _context.Bookings.Where(b => b.UserId == userId).ToListAsync();
    }

    public async Task<Booking> CreateBookingAsync(Booking booking)
    {
        _context.Bookings.Add(booking);
        await _context.SaveChangesAsync();

        return booking;
    }

    public async Task<Booking> UpdateBookingAsync(Booking booking)
    {
        _context.Bookings.Update(booking);
        await _context.SaveChangesAsync();
        return booking;
    }

    public async Task<Booking> DeleteBookingAsync(Booking booking)
    {
        _context.Bookings.Remove(booking);
        await _context.SaveChangesAsync();
        return booking;
    }
}
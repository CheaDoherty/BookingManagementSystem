using BookingManagementSystem.Models;

namespace BookingManagementSystem.Services;

public interface IBookingService
{
    public Task<Booking> GetBookingAsync(Guid id);
    public Task<IEnumerable<Booking>> GetBookingsAsync();
    public Task<IEnumerable<Booking>> GetBookingsByUserId(string userId);
    public Task<Booking> CreateBookingAsync(Booking booking);
    public Task<Booking> UpdateBookingAsync(Booking booking);
    public Task<Booking> DeleteBookingAsync(Booking booking);
    
}
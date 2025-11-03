using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BookingManagementSystem.Models;

public class Booking
{
    public Guid Id { get; set; }
    public DateTime StartDate  { get; set; }
    public DateTime EndDate { get; set; }
    public Guid UserId { get; set; }
    public User  User { get; set; }
    public int PropertyId { get; set; }
    public Property  Property { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime UpdatedOn { get; set; }
    
}
using BookingManagementSystem.Models;
using Microsoft.AspNetCore.Identity;

namespace BookingManagementSystem.Services;

//TODO - Decide design of user system: e.g. Will users be added/managed through the system or manually added separately
public interface IUserService
{
    public Task<IdentityUser> GetUserAsync(string id);
    
    public Task<Boolean> ExistUserAsync(string id);
    
}
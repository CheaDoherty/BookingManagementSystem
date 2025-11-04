using BookingManagementSystem.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;

namespace BookingManagementSystem.Services;

public class UserService : IUserService
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly BookingContext _context;

    public UserService(UserManager<IdentityUser> userManager, BookingContext context)
    {
        _userManager = userManager;
        _context = context;
    }
    
    public async Task<IdentityUser> GetUserAsync(string id)
    {
        return await _userManager.FindByIdAsync(id);
    }

    public async Task<bool> ExistUserAsync(string id)
    {
        return await _userManager.FindByNameAsync(id) != null;
    }
}
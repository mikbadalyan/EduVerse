using EduVerse.ViewModels;
using Microsoft.AspNetCore.Identity;
using EduVerse.Data;
using Microsoft.EntityFrameworkCore;

namespace EduVerse.Services
{
    public class AccountService
    {
        private AppDbContext _dbContext;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        //private readonly IEmailSender _emailSender;
        private readonly ILogger<AccountService> _logger;

        public AccountService(AppDbContext appDbContext,
                              SignInManager<User> signInManager,
                              UserManager<User> userManager,
                              //IEmailSender emailSender,
                              ILogger<AccountService> logger)
        {
            _dbContext = appDbContext;
            _signInManager = signInManager;
            _userManager = userManager;
            //_emailSender = emailSender;
            _logger = logger;
        }

        public async Task<(bool IsSuccess, IEnumerable<string> Errors)> LoginAsync(LoginViewModel model)
        {
            // Find user by email
            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == model.Email);

            if (user == null)
            {
                return (false, new[] { "Invalid email or password." });
            }

            // Verify the password
            if (!BCrypt.Net.BCrypt.Verify(model.Password, user.PasswordHash))
            {
                return (false, new[] { "Invalid email or password." });
            }

            return (true, Enumerable.Empty<string>());
        }


        public async Task<(bool IsSuccess, IEnumerable<string> Errors)> ChangePasswordAsync(ChangePasswordViewModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return (false, new[] { "User not found." });
            }

            var result = await _userManager.ChangePasswordAsync(user, user.PasswordHash, model.NewPassword);
            if (result.Succeeded)
            {
                return (true, Enumerable.Empty<string>());
            }

            return (false, result.Errors.Select(e => e.Description));
        }

        
        //public async Task<(bool IsSuccess, IEnumerable<string> Errors)> VerifyEmailAsync(string userId, string token)
        //{
        //    var user = await _userManager.FindByIdAsync(userId);
        //    if (user == null)
        //    {
        //        return (false, new[] { "User not found." });
        //    }

        //    // Confirm the email using the token
        //    var result = await _userManager.ConfirmEmailAsync(user, token);
        //    if (result.Succeeded)
        //    {
        //        return (true, Enumerable.Empty<string>());
        //    }

        //    return (false, result.Errors.Select(e => e.Description));
        //}
    }
}

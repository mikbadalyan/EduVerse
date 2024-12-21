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
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
            if (result.Succeeded)
            {
                return (true, Enumerable.Empty<string>());
            }
            else
            {
                return (false, new[] { "Invalid email or password." });
            }
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

        public async Task<(bool IsSuccess, IEnumerable<string> Errors)> RegisterAsync(RegisterViewModel model)
        {
            var errors = new List<string>();

            // Check if the user already exists
            if (await _dbContext.Users.AnyAsync(u => u.Email == model.Email))
            {
                errors.Add("Email is already registered.");
                return (false, errors);
            }

            // Hash the password
            var passwordHash = BCrypt.Net.BCrypt.HashPassword(model.Password);

            // Create a new user
            var user = new User
            {
                Name = model.Name,
                Email = model.Email,
                PasswordHash = passwordHash,
            };

            // Save to the database
            try
            {
                _dbContext.Users.Add(user);
                await _dbContext.SaveChangesAsync();
                return (true, Enumerable.Empty<string>());
            }
            catch (Exception ex)
            {
                errors.Add($"Error saving user: {ex.Message}");
                return (false, errors);
            }
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

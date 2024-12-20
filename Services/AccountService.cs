using EduVerse.ViewModels;
using EduVerse.Models;
using EduVerse.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace EduVerse.Services
{
    public class AccountService
    {
        private readonly SignInManager<Users> _signInManager;
        private readonly UserManager<Users> _userManager;
        //private readonly IEmailSender _emailSender;
        private readonly ILogger<AccountService> _logger;

        public AccountService(SignInManager<Users> signInManager,
                              UserManager<Users> userManager,
                              //IEmailSender emailSender,
                              ILogger<AccountService> logger)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            //_emailSender = emailSender;
            _logger = logger;
        }

        // Login Method (no changes needed)
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

        // Change Password Method (no changes needed)
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

        // Register User and Send Email Verification Token
        public async Task<(bool IsSuccess, IEnumerable<string> Errors)> RegisterAsync(RegisterViewModel model)
        {
            var user = new Users
            {
                UserName = model.Email,
                Email = model.Email,
                FullName = model.Name
            };

            // Create User
            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                return (false, result.Errors.Select(e => e.Description));
            }

            // Generate Email Confirmation Token
            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var confirmationLink = $"https://yourdomain.com/verifyemail?userId={user.Id}&token={Uri.EscapeDataString(token)}";

            // Send Email Confirmation Link
            //try
            //{
            //    await _emailSender.SendEmailAsync(
            //        user.Email,
            //        "Please confirm your email",
            //        $"Click the following link to confirm your email: <a href='{confirmationLink}'>Confirm Email</a>"
            //    );
            //}
            //catch (Exception ex)
            //{
            //    _logger.LogError(ex, "Error sending confirmation email.");
            //    return (false, new[] { "Error sending confirmation email." });
            //}

            return (true, Enumerable.Empty<string>());
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

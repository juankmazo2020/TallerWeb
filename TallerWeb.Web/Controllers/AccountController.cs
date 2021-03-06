﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TallerWeb.Common.Entities;
using TallerWeb.Common.Enums;
using TallerWeb.Common.Responses;
using TallerWeb.Web.Data;
using TallerWeb.Web.Data.Entities;
using TallerWeb.Web.Helpers;
using TallerWeb.Web.Models;

namespace TallerWeb.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;
        private readonly ICombosHelper _combosHelper;
        private readonly IBlobHelper _blobHelper;
        private readonly IMailHelper _mailHelper;
        public AccountController(
            DataContext context, 
            IUserHelper userHelper,
            ICombosHelper combosHelper,
            IBlobHelper blobHelper,
            IMailHelper mailHelper)
        {
            _context = context;
            _userHelper = userHelper;
            _combosHelper = combosHelper;
            _blobHelper = blobHelper;
            _mailHelper = mailHelper;

        }

        [Authorize(Roles = "Admin, Teacher")]
        public async Task<IActionResult> Index()
        {
            User user = await _userHelper.GetUserAsync(User.Identity.Name);
            if (user == null)
            {
                return NotFound();
            }


            District district = await _context.Districts.FirstOrDefaultAsync(d => d.Churches.FirstOrDefault(c => c.Id == user.Church.Id) != null);
            if (district == null)
            {
                district = await _context.Districts.FirstOrDefaultAsync();
            }

            Field field = await _context.Fields.FirstOrDefaultAsync(c => c.Districts.FirstOrDefault(d => d.Id == district.Id) != null);
            if (field == null)
            {
                field = await _context.Fields.FirstOrDefaultAsync();
            }

            ViewData["ChurchId"] = user.Church.Id;

            return View(await _context.Users
                .Include(u => u.Church)
                .ToListAsync());
        }


        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Create()
        {
            AddUserViewModel model = new AddUserViewModel
            {
                Fields = _combosHelper.GetComboFields(),
                Districts = _combosHelper.GetComboDistricts(0),
                Churches = _combosHelper.GetComboChurches(0),
                Professions = _combosHelper.GetComboProfessions(),
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AddUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                Guid imageId = Guid.Empty;

                if (model.ImageFile != null)
                {
                    imageId = await _blobHelper.UploadBlobAsync(model.ImageFile, "users");
                }

                User user = await _userHelper.AddUserAsync(model, imageId, UserType.Teacher);
                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "This email is already used.");
                    model.Fields = _combosHelper.GetComboFields();
                    model.Districts = _combosHelper.GetComboDistricts(model.FieldId);
                    model.Churches = _combosHelper.GetComboChurches(model.DistrictId);
                    model.Professions = _combosHelper.GetComboProfessions();
                    return View(model);
                }

                await _userHelper.AddUserToRoleAsync(user, UserType.Teacher.ToString());

                string myToken = await _userHelper.GenerateEmailConfirmationTokenAsync(user);
                string tokenLink = Url.Action("ConfirmEmail", "Account", new
                {
                    userid = user.Id,
                    token = myToken
                }, protocol: HttpContext.Request.Scheme);

                Response response = _mailHelper.SendMail(model.Username, "Email confirmation", $"<h1>Email Confirmation</h1>" +
                    $"To allow the user, " +
                    $"plase click in this link:</br></br><a href = \"{tokenLink}\">Confirm Email</a>");
                if (response.IsSuccess)
                {
                    ViewBag.Message = "The instructions to allow your user has been sent to email.";
                    return View(model);
                }

                ModelState.AddModelError(string.Empty, response.Message);
            }

            model.Fields = _combosHelper.GetComboFields();
            model.Districts = _combosHelper.GetComboDistricts(model.FieldId);
            model.Churches = _combosHelper.GetComboChurches(model.DistrictId);
            return View(model);
        }


        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(new LoginViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                Microsoft.AspNetCore.Identity.SignInResult result = await _userHelper.LoginAsync(model);
                if (result.Succeeded)
                {
                    if (Request.Query.Keys.Contains("ReturnUrl"))
                    {
                        return Redirect(Request.Query["ReturnUrl"].First());
                    }

                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Email or password incorrect.");
            }

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _userHelper.LogoutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult NotAuthorized()
        {
            return View();
        }
        public IActionResult Register()
        {
            AddUserViewModel model = new AddUserViewModel
            {
                Professions = _combosHelper.GetComboProfessions(),
                Fields = _combosHelper.GetComboFields(),
                Districts = _combosHelper.GetComboDistricts(0),
                Churches = _combosHelper.GetComboChurches(0),
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(AddUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                Guid imageId = Guid.Empty;

                if (model.ImageFile != null)
                {
                    imageId = await _blobHelper.UploadBlobAsync(model.ImageFile, "users");
                }

                User user = await _userHelper.AddUserAsync(model, imageId, UserType.User);
                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "This email is already used.");
                    model.Professions = _combosHelper.GetComboProfessions();
                    model.Fields = _combosHelper.GetComboFields();
                    model.Districts = _combosHelper.GetComboDistricts(model.FieldId);
                    model.Churches = _combosHelper.GetComboChurches(model.DistrictId);
                    return View(model);
                }

                string myToken = await _userHelper.GenerateEmailConfirmationTokenAsync(user);
                string tokenLink = Url.Action("ConfirmEmail", "Account", new
                {
                    userid = user.Id,
                    token = myToken
                }, protocol: HttpContext.Request.Scheme);

                Response response = _mailHelper.SendMail(model.Username, "Email confirmation", $"<h1>Email Confirmation</h1>" +
                    $"To allow the user, " +
                    $"plase click in this link:<p><a href = \"{tokenLink}\">Confirm Email</a></p>");
                if (response.IsSuccess)
                {
                    ViewBag.Message = "The instructions to allow your user has been sent to email.";
                    return View(model);
                }

                ModelState.AddModelError(string.Empty, response.Message);

            }

            model.Professions = _combosHelper.GetComboProfessions();
            model.Fields = _combosHelper.GetComboFields();
            model.Districts = _combosHelper.GetComboDistricts(model.FieldId);
            model.Churches = _combosHelper.GetComboChurches(model.DistrictId);
            return View(model);
        }


        public JsonResult GetDistricts(int fieldId)
        {
            Field field = _context.Fields
                .Include(c => c.Districts)
                .FirstOrDefault(c => c.Id == fieldId);
            if (field == null)
            {
                return null;
            }

            return Json(field.Districts.OrderBy(d => d.Name));
        }

        public JsonResult GetChurches(int districtId)
        {
            District district = _context.Districts
                .Include(d => d.Churches)
                .FirstOrDefault(d => d.Id == districtId);
            if (district == null)
            {
                return null;
            }

            return Json(district.Churches.OrderBy(c => c.Name));
        }

        public async Task<IActionResult> ChangeUser()
        {
            User user = await _userHelper.GetUserAsync(User.Identity.Name);
            if (user == null)
            {
                return NotFound();
            }


            District district = await _context.Districts.FirstOrDefaultAsync(d => d.Churches.FirstOrDefault(c => c.Id == user.Church.Id) != null);
            if (district == null)
            {
                district = await _context.Districts.FirstOrDefaultAsync();
            }

            Field field = await _context.Fields.FirstOrDefaultAsync(c => c.Districts.FirstOrDefault(d => d.Id == district.Id) != null);
            if (field == null)
            {
                field = await _context.Fields.FirstOrDefaultAsync();
            }

            EditUserViewModel model = new EditUserViewModel
            {
                Address = user.Address,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                ImageId = user.ImageId,
                Churches = _combosHelper.GetComboChurches(district.Id),
                ChurchId = user.Church.Id,
                Fields = _combosHelper.GetComboFields(),
                FieldId = field.Id,
                DistrictId = district.Id,
                Districts = _combosHelper.GetComboDistricts(field.Id),
                Professions = _combosHelper.GetComboProfessions(),
                ProfessionId = user.Profession.Id,
                Id = user.Id,
                Document = user.Document
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeUser(EditUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                Guid imageId = model.ImageId;

                if (model.ImageFile != null)
                {
                    imageId = await _blobHelper.UploadBlobAsync(model.ImageFile, "users");
                }

                User user = await _userHelper.GetUserAsync(User.Identity.Name);

                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.Address = model.Address;
                user.PhoneNumber = model.PhoneNumber;
                user.ImageId = imageId;
                user.Church = await _context.Churches.FindAsync(model.ChurchId);
                user.Profession = await _context.Professions.FindAsync(model.ProfessionId);
                user.Document = model.Document;

                await _userHelper.UpdateUserAsync(user);
                return RedirectToAction("Index", "Home");
            }
            model.Professions = _combosHelper.GetComboProfessions();
            model.Churches = _combosHelper.GetComboChurches(model.DistrictId);
            model.Fields = _combosHelper.GetComboFields();
            model.Districts = _combosHelper.GetComboDistricts(model.ChurchId);
            return View(model);
        }
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userHelper.GetUserAsync(User.Identity.Name);
                if (user != null)
                {
                    var result = await _userHelper.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("ChangeUser");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, result.Errors.FirstOrDefault().Description);
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "User no found.");
                }
            }

            return View(model);
        }
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(token))
            {
                return NotFound();
            }

            User user = await _userHelper.GetUserAsync(new Guid(userId));
            if (user == null)
            {
                return NotFound();
            }

            IdentityResult result = await _userHelper.ConfirmEmailAsync(user, token);
            if (!result.Succeeded)
            {
                return NotFound();
            }

            return View();
        }
        public IActionResult RecoverPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RecoverPassword(RecoverPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _userHelper.GetUserAsync(model.Email);
                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "The email doesn't correspont to a registered user.");
                    return View(model);
                }

                string myToken = await _userHelper.GeneratePasswordResetTokenAsync(user);
                string link = Url.Action(
                    "ResetPassword",
                    "Account",
                    new { token = myToken }, protocol: HttpContext.Request.Scheme);
                _mailHelper.SendMail(model.Email, "Password Reset", $"<h1>Password Reset</h1>" +
                    $"To reset the password click in this link:</br></br>" +
                    $"<a href = \"{link}\">Reset Password</a>");
                ViewBag.Message = "The instructions to recover your password has been sent to email.";
                return View();

            }

            return View(model);
        }

        public IActionResult ResetPassword(string token)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            User user = await _userHelper.GetUserAsync(model.UserName);
            if (user != null)
            {
                IdentityResult result = await _userHelper.ResetPasswordAsync(user, model.Token, model.Password);
                if (result.Succeeded)
                {
                    ViewBag.Message = "Password reset successful.";
                    return View();
                }

                ViewBag.Message = "Error while resetting the password.";
                return View(model);
            }

            ViewBag.Message = "User not found.";
            return View(model);
        }
    }

}

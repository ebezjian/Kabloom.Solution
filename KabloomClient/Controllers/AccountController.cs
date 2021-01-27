using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using KabloomClient.Models;
using System.Threading.Tasks;
using KabloomClient.ViewModels;

namespace KabloomClient.Controllers
{
	public class AccountController : Controller
    {
        private readonly KabloomClientContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController (UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, KabloomClientContext db)
        {
        _userManager = userManager;
        _signInManager = signInManager;
        _db = db;
        }

        public IActionResult Index()
        {
        return View();
        }

        public IActionResult Register()
        {
        return View();
        }

        [HttpPost]
        public async Task<ActionResult> Register (RegisterViewModel model)
        {
        var user = new ApplicationUser { UserName = model.UserName };
        IdentityResult result = await _userManager.CreateAsync(user, model.Password);
        if (result.Succeeded)
        {
            return RedirectToAction("Index");
        }
        else
        {
            return View("UnsuccessfulRegister");
        }
        }

        public ActionResult Login()
        {
        return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
        Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure : false);
        if (result.Succeeded)
        {
            return RedirectToAction("Index");
        }
        else
        {
            return View("UnsuccessfulLogin");
        }
        }

        [HttpPost]
        public async Task<ActionResult> Logoff()
        {
        await _signInManager.SignOutAsync();
        return RedirectToAction("Index");
        }
    }
}
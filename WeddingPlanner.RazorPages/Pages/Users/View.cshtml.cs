using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WeddingPlanner.RazorPages.Pages.Auth;
using WeddingPlannerApplication.Services.ServicesImplementation;
using WeddingPlannerDomain;
using WeddingPlannerDomain.Entities;

namespace WeddingPlanner.RazorPages.Pages.Users
{
    public class ViewModel : PageModel
    {
        private readonly UserServiceR _userService;
        private readonly SessionManager _sessionManager;

        public ViewModel(UserServiceR userService, SessionManager sessionManager)
        {
            _userService = userService;
            _sessionManager = sessionManager;
        }

        [BindProperty]
        public bool isLoggedin { get; set; }    
        [BindProperty]
        public bool isAdmin { get; set; }
        public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            isAdmin = _sessionManager.IsAdmin;
            isLoggedin = _sessionManager.IsAuthenticated;
            if (isLoggedin == true)
            {
                var user = await _userService.GetUserByIdAsync(id);


                if (user.Id == null)
                {

                    return NotFound();
                }

                User = user;

                return Page();
            }
            return Page();
        }
    }
}

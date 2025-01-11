using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WeddingPlannerApplication.Services.ServicesInterfaces;
using WeddingPlannerDomain;
using System.Threading.Tasks;

namespace WeddingPlanner.RazorPages.Pages.Location
{
    public class ViewLocationModel : PageModel
    {//View a location's details
        private readonly LocationService _locationService; 

        public ViewLocationModel(LocationService locationService)
        {
            _locationService = locationService; 
        }

        public WeddingPlannerDomain.Entities.Location Location { get; set; }

        public async Task <IActionResult> OnGetAsync(int id)
        {
            var location = await _locationService.GetLocationByIdAsnc(id); 

            if (location == null)
            {
                return NotFound();
            }
            Location = location;
            return Page(); 
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace C_Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
   /*     public void OnPost()
        {
            *//*Validation.RequiredField(Request.Form["firstName"], "First Name");
            Validation.RequiredField(Request.Form["lastName"], "Last Name");
            Validation.RequiredField(Request.Form["number"], "Number of People");
            Validation.RequiredField(Request.Form["phone"], "Phone Number");
            Validation.RequiredField(Request.Form["week"], "Weeks");
            
            // Do something
            string.firstName = Request.Form["firstName"];
            string.lastName = Request.Form["lastName"];
            int.numberOf = Request.Form["number"];
            string.phone = Request.Form["phone"];
            string.weeks = Request.Form["week"];*//*
        }*/
    }
}
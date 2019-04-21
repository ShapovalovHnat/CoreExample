using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreExample.Interfaces;
using CoreExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreExample.Pages
{
    public class SigninModel : PageModel
    {
        private readonly IUserService userService;

        public SigninModel(IUserService userService) {
            this.userService = userService;
        }
        
        public User LoginInput { get; set; }

        public void OnGet()
        {
            this.LoginInput = new User();
        }

        public ActionResult OnPost()
        {
            if (!this.ModelState.IsValid || !this.userService.Login(this.LoginInput))
            {
                return this.Page();
            }

            return this.Redirect("/todos");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents 
{
    public class ProjectsViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            var lstProjects = new List<Project>
            {
                new Project(1, "تاکسی", "درخواست آنلاین تاکسی برای سفر های درون شهری", "project-1.jpg", "Atriya"),
                new Project(2, "تاکسی", "درخواست آنلاین تاکسی برای سفر های درون شهری", "project-2.jpg", "Atriya"),
                new Project(3, "تاکسی", "درخواست آنلاین تاکسی برای سفر های درون شهری", "project-3.jpg", "Atriya"),
                new Project(4, "تاکسی", "درخواست آنلاین تاکسی برای سفر های درون شهری", "project-4.jpg", "Atriya"),
            };
            return View("_projects",lstProjects);
        }
    }
}

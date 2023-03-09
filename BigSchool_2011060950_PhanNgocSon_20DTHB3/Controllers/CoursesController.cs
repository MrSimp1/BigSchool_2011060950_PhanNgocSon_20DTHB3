using BigSchool_2011060950_PhanNgocSon_20DTHB3.Models;
using BigSchool_2011060950_PhanNgocSon_20DTHB3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigSchool_2011060950_PhanNgocSon_20DTHB3.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        private readonly ApplicationDbContext _dbConText;
        public CoursesController()
        {
            _dbConText = new ApplicationDbContext();
        }

        // GET: Courses
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbConText.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}
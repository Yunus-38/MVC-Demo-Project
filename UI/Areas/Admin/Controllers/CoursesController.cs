using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CoursesController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly ICourseCategoryService _courseCategoryService;

        public CoursesController(ICourseService courseService, ICourseCategoryService courseCategoryService)
        {
            _courseService = courseService;
            _courseCategoryService = courseCategoryService;
        }

        public IActionResult Index()
        {
            var courses = _courseService.GetAll();
            return View(courses);
        }

        [HttpGet]
        public IActionResult Create()
        {
            List<SelectListItem> categories = (from x in _courseCategoryService.GetAll()
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.Id.ToString()
                                               }
                                               ).ToList();
            ViewBag.c = categories;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Course course)
        {
            // iş kodları
            if (ModelState.IsValid)
            {
                _courseService.Add(course);
                bool result = _courseService.Save() > 0;
                if (result)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(course);
        }
    }
}

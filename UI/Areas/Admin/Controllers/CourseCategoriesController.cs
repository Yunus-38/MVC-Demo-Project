using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseCategoriesController : Controller
    {
        private readonly ICourseCategoryService _courseCategoryService;
        public CourseCategoriesController(ICourseCategoryService courseCategoryService)
        {
            _courseCategoryService = courseCategoryService;
        }
        public IActionResult Index()
        {
            var categories = _courseCategoryService.GetByDefault(x => x.IsDeleted == 0);
            return View(categories);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CourseCategory courseCategoryService)
        {
            //iş kodları
            if (ModelState.IsValid)
            {
                _courseCategoryService.Add(courseCategoryService);
                bool result = _courseCategoryService.Save() > 0;
                if (result)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(courseCategoryService);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                var category = _courseCategoryService.GetById(id.Value);
                if (category == null)
                {
                    return NotFound();
                }
                return View(category);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(CourseCategory courseCategory)
        {
            if (ModelState.IsValid)
            {
                _courseCategoryService.Update(courseCategory);
                bool result = _courseCategoryService.Save() > 0;
                if (result)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(courseCategory);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id.HasValue)
            {
                var category = _courseCategoryService.GetById(id.Value);
                if (category == null)
                {
                    return NotFound();
                }
                return View(category);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                var category = _courseCategoryService.GetById(id.Value);
                if (category == null)
                {
                    return NotFound();
                }

                category.IsDeleted = 1;
                _courseCategoryService.Save();
            }
            return RedirectToAction("Index");
        }

    }
}

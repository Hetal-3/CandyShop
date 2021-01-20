using CandyShop.Models;
using CandyShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Controllers
{
    public class CandyController:Controller
    {
        private readonly ICandyRepository _candyRepository;
        private readonly ICategoryRepository _categoryRepository;
        public CandyController(ICategoryRepository categoryRepository,ICandyRepository candyRepository) {
            _candyRepository = candyRepository;
            _categoryRepository = categoryRepository;
        
        }
        public IActionResult List() {
            ViewBag.CurrentCategory = "Bestsellers";
            ViewBag.Title = "Testing";
            //return View(_candyRepository.GetAllCandies);
            var candyListViewModel = new CandyListViewModel();
            candyListViewModel.Candies = _candyRepository.GetAllCandies;
            candyListViewModel.CurrentCategory = "Best sellers";
            return View(candyListViewModel);
        }

    }
}

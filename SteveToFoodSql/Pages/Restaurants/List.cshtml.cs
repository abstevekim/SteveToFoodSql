using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using SteveToFoodSql.Core;
using SteveToFoodSql.Data;


namespace SteveToFoodSql.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;

        public string Message { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public ListModel MyProperty { get; set; }
        public IRestaurantData RestaurantData { get; }

        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            this.config = config;
            RestaurantData = restaurantData;
        }
        public void OnGet(string searchTerm)
        {

            Message = config["Message"];
            Restaurants = RestaurantData.GetRestaurantsByName(SearchTerm);
        }
    }
}

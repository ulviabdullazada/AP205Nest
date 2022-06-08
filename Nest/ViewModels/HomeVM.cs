using Nest.Models;
using System.Collections.Generic;

namespace Nest.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders{ get; set; }
        public List<Category> PopularCategories { get; set; }
        public List<Category> RandomCategories { get; set; }
        public List<Product> Products { get; set; }
        public List<Product> RecentProducts { get; set; }
        public List<Product> TopRatedProducts { get; set; }
    }
}

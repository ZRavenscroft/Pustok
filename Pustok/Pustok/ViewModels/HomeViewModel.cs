using Pustok.Models;
using System.Collections.Generic;

namespace Pustok.ViewModels
{
    public class HomeViewModel
    {
        public List<Authors> Authors { get; set; }
        public List<Books> Books { get; set; }
        public List<BtmPromotions> BtmPromotions { get; set; }
        public List<Genres> Genres { get; set; }
        public List<Sliders> Sliders { get; set; }
        public List<TopPromotions> TopPromotions { get; set; }
    }
}

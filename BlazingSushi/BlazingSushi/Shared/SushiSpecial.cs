using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingSushi.Shared
{
    public class SushiSpecial
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal BasePrice { get; set; }

        public string Description { get; set; }

        public int Portion { get; set; }

        public string ImageUrl { get; set; }


        public string GetFormattedBasePrice() => BasePrice.ToString("0.00");
    }
}

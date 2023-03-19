using System;

namespace WebApi.Models
{
    public class Goods
    {
        public string NameGoods { get; set; }
        public double PriceGoods { get; set; }
    }

    public class FoodGoods : Goods
    {
        public Guid IdGoods { get; set; }
    }
}

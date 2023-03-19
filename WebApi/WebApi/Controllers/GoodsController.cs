using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodsApi: ControllerBase
    {
        public static List<FoodGoods> goods = new List<FoodGoods>();

        [HttpGet]
        public IActionResult GetAll() 
        {
            return Ok(goods);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(string id)
        {
            try {
                var good = goods.SingleOrDefault(hh => hh.IdGoods == Guid.Parse(id));
                if (good == null)
                {
                    return NotFound();
                }
                return Ok(good);
            } 
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
          
        }

        [HttpPost]
        public IActionResult Create(Goods goodVM) 
        {
            var good = new FoodGoods
            {
                IdGoods = Guid.NewGuid(),
                NameGoods = goodVM.NameGoods,
                PriceGoods = goodVM.PriceGoods,
            };
            goods.Add(good);
            return Ok(new { 
                Success = true,Data = good
            });
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, FoodGoods foodgoodEidt) 
        {
            try
            {
                var good = goods.SingleOrDefault(hh => hh.IdGoods == Guid.Parse(id));
                if (good == null)
                {
                    return NotFound();
                }

                if (id != good.IdGoods.ToString())
                {
                    return BadRequest();
                }
               
                good.NameGoods = foodgoodEidt.NameGoods;
                good.PriceGoods = foodgoodEidt.PriceGoods;

                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}

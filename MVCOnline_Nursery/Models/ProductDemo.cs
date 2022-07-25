using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCOnline_Nursery.Models
{
    public class ProductDemo
    {
        public int Id { get; set; }
        //[UniqueKey, 1]
        public int SKU_NO { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public CategoriesDemo CategoriesDemo { get; set; }
    }
   
}
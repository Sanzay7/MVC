using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Day16.FirstMVCAPP.Models
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        
        public double Price { get; set; }

        public int ProductCategoryId { get; set; }
        [ValidateNever]
        public ProductCategoryModel ProductCategory { get; set; }


    }
}

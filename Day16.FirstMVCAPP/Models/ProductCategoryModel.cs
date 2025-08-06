using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Day16.FirstMVCAPP.Models
{
    public class ProductCategoryModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter the valid category name")]
        public string Name { get; set; }

    }
}

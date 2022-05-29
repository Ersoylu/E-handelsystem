using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using shopapp.entity;

namespace shopapp.webui.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }  
       
       
        public string Name { get; set; }     
       
        [Required(ErrorMessage="URL är ett obligatoriskt fält.")]  
        public string Url { get; set; }     
      
        
        public double? Price { get; set; } 
      
        [Required(ErrorMessage="Description är ett obligatoriskt fält.")]
        [StringLength(100,MinimumLength=5,ErrorMessage="Beskrivningen bör vara i intervallet 5-100 tecken.")]

        public string Description { get; set; }      
       
        [Required(ErrorMessage="ImageUrl är ett obligatoriskt fält.")]  
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public List<Category> SelectedCategories { get; set; }
    }
}
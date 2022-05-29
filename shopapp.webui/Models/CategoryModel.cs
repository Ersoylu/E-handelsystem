using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using shopapp.entity;

namespace shopapp.webui.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
                
        [Required(ErrorMessage="Kategorinamn krävs.")]
        [StringLength(100,MinimumLength=5,ErrorMessage="Ange ett värde mellan 5-100 för kategorin.")]        
        public string Name { get; set; }

        [Required(ErrorMessage="URL krävs.")]
        [StringLength(100,MinimumLength=5,ErrorMessage="Ange ett värde mellan 5-100 för URL.")]        

        public string Url { get; set; }

        public List<Product> Products { get; set; }
    }
}
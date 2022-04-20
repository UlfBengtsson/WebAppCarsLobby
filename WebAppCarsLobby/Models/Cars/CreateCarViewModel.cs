using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCarsLobby.Models.Cars
{
    public class CreateCarViewModel
    {
        [Required]
        [StringLength(255)]
        public string Brand { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Model")]
        public string ModelName { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Price { get; set; }

        public List<string> BrandList { get; set; }
    }
}

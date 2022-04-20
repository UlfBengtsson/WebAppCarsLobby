using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCarsLobby.Models.Cars
{
    public class Car
    {
        public int Id { get; set; }

        public string Brand { get; set; }
        
        [Display(Name = "Model")]
        public string ModelName { get; set; }
        
        public int Price { get; set; }
    }
}

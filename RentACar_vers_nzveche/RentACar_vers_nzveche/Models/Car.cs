using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar_vers_nzveche.Models
{
    
    public class Car
    {
        
        public Car()
        {
            BookedCars = new HashSet<BookedCar>();
        }

        [Key]
        public int CarId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int CarYear { get; set; }
        public string Description { get; set; }
        public decimal PricaPerDay { get; set; }

        public virtual ICollection<BookedCar> BookedCars { get; set; }
    }
}

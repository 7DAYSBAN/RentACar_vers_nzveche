using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar_vers_nzveche.Models
{
    

    public partial class BookedCar
    {
        [Key]
        public int BookCarId { get; set; }
        public int CarId { get; set; }
        public int UserId { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }

        public virtual Car Car { get; set; }
        public virtual User User { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace capstone.Models
{
    public class Well
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int DistrictNumber { get; set; }
        public int  Elevation { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}

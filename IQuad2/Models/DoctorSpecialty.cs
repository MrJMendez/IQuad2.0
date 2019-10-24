using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IQuad2.Models
{
    public class DoctorSpecialty
    {
        public string Id { get; set; }
        
        public int SpecId { get; set; }

    }
}
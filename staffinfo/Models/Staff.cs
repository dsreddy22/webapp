using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace staffinfo.Models
{
    public class Staff
    {
        public int ID { get; set; }

        [Required]
        public int Name { get; set; }

        [Required]
        public int Age { get; set; }

        [DataType(DataType.EmailAddress)]
        public int Email { get; set; }

        [Required]
        public int ContactNo { get; set; }
    }
}
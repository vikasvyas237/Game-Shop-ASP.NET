using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _200394465A1.Models
{
    public class Genre
    {
        [Key]
        public virtual int genreid { get; set; }
        public virtual String Name { get; set; }

        public virtual String Description { get; set; }
    }
}
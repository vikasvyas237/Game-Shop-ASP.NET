using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _200394465A1.Models
{
    public class Game
    {   [Key]
        public virtual int genreid { get; set; }
        public virtual double Price { get; set; }
        public virtual String Name { get; set; }

        public virtual String Description { get; set; }

        public virtual String Minimum_Requirements { get; set; }

        public virtual String Publisher { get; set; }

        public virtual String Developer { get; set; }

        public virtual String Genre { get; set; }

    }
}
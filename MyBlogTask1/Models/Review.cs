using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlogTask1.Models
{
    public class Review
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Rid { get; set; }

        public string Rname { get; set; }

        public DateTime Rdate { get; set; }

        public string Rtext { get; set; }
    }
}
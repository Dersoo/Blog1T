using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlogTask1.Models
{
    public class Article
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Aid { get; set; }

        public string Aname { get; set; }

        public DateTime Adate { get; set; }

        public string Atext { get; set; }

    }
}
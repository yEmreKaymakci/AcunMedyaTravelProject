using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AcunMedyaTravelProject.Entities
{
    public class Slider
    {
        public int SliderID { get; set; }
        public string Title { get; set; }
        [MaxLength(50)]
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string ImageUrl { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaTravelProject.Entities
{
    public class Testimonial
    {
        //prop tab tab
        public int TestimonialID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string ImgUrl { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }

    }
}
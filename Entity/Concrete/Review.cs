﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Review
    {
        public int ReviewID { get; set; }
        public string ReviewTitle { get; set; }
        public string ReviewContent { get; set; }
        public string ReviewThumbnailImage { get; set; }
        public string ReviewImage { get; set; }
        public DateTime ReviewCreatedDate { get; set; }
        public bool ReviewStatus { get; set; }
    }
}

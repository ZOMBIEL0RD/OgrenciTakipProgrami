﻿using Nesne_2_OGRENCI_TAKIP_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne_2_OGRENCI_TAKIP_1.Models
{
    public class Register
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int LessonId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public virtual Student Student { get; set; }
        public virtual Lesson Lesson { get; set; }
    }
}

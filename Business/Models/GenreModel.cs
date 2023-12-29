﻿using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable 

namespace Business.Models
{
    public class GenreModel
    {
        public int Id { get; set; }

        [StringLength(75)]
        public string Name { get; set; }

    }
}

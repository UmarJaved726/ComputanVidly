﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComputanVidely.Models;
using System.ComponentModel.DataAnnotations;

namespace ComputanVidely.DTOs
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }


        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime ReleaseDate { get; set; }

        public byte NumberInStock { get; set; }
    }
}
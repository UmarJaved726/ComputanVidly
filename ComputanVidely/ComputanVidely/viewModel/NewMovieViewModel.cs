using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComputanVidely.Models;

namespace ComputanVidely.viewModel
{
    public class NewMovieViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
    }
}
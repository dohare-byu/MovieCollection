using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCollection.Models.ViewModels
{
    public class MovieViewModel
    {
        public string ID { get; set; }

        public string Category { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public string Director { get; set; }

        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string Lent { get; set; }

        public string Notes { get; set; }
    }
}

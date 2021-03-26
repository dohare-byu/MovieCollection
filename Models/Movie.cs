using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MovieCollection.Models
{
    public class Movie //this is the class for movies 
    {
        [Key]
        [Required]
        public int ID { get; set; } //primary key

        [Required]
        public string Category { get; set; } //attributes of the class here and below

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string Lent { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }
    }
}

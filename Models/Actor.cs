﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
	public class Actor
	{
        [Key]
        public int Id { get; set; }
        [Display(Name ="Profile Picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name ="Full Name")]
        public string FullName { get; set; }
        [Display(Name ="Biography")]
        public string Bio { get; set; }
        public string Biography { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}

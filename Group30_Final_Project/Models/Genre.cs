using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Group30_Final_Project.Models
{
    public class Genre
    {
        public Int32 GenreID { get; set; }

        [Display(Name = "Genre Name")]
        [Required(ErrorMessage = "Genre name is required.")]
        public String GenreName { get; set; }

        //navigational properties
        public virtual List<Song> GenreSongs { get; set; }
        public virtual List<Album> GenreAlbums { get; set; }
        public virtual List<Artist> GenreArtists { get; set; }
    }
}
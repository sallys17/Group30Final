using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Group30_Final_Project.Models
{
    public class Album
    {
        public Int32 AlbumID { get; set; }

        [Display(Name = "Album Title")]
        [Required(ErrorMessage = "Album title is required.")]
        public String AlbumTitle { get; set; }

        [Display(Name = "Album Price")]
        [Required(ErrorMessage = "Album price is required.")]
        //$X*.XX format
        public Decimal AlbumPrice { get; set; }

        //navigational properties
        public virtual List<Genre> AlbumGenres { get; set; }
        public virtual List<Song> AlbumSongs { get; set; }
        public virtual List<Artist> AlbumArtists { get; set; }
        public virtual List<RateReview> AlbumRateReviews { get; set; }
        public virtual Promotion AlbumPromo { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Group30_Final_Project.Models
{
    public class Song
    {
        public Int32 SongID { get; set; }

        [Display(Name = "Song Title")]
        [Required(ErrorMessage = "Song title is required.")]
        public String SongTitle { get; set; }

        [Display(Name = "Song Price")]
        [Required(ErrorMessage = "Song price is required.")]
        //$X*.XX format
        public Decimal SongPrice { get; set; }

        //navigational properties
        public virtual List<Genre> SongGenres { get; set; }
        public virtual List<Album> SongAlbums { get; set; }
        public virtual List<Artist> SongArtists { get; set; }
        public virtual List<RateReview> SongRateReviews { get; set; }
        public virtual Promotion SongPromo { get; set; }
    }
}
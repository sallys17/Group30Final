using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Group30_Final_Project.Models
{
    public class Artist
    {
        public Int32 AlbumID { get; set; }

        [Display(Name = "Artist Title")]
        [Required(ErrorMessage = "Artist title is required.")]
        public String ArtistTitle { get; set; }

        //navigational properties
        public virtual List<Genre> ArtistGenres { get; set; }
        public virtual List<Song> ArtistSongs { get; set; }
        public virtual List<Album> ArtistAlbums { get; set; }
        public virtual List<RateReview> ArtistRateReviews { get; set; }
        public virtual Promotion ArtistPromo { get; set; }
    }
}
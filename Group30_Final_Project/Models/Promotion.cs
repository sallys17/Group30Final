using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Group30_Final_Project.Models
{
    public class Promotion
    {
        public Int32 PromoID { get; set; }

        //True if item is featured
        //False if item is not featured
        public bool boolFeatured { get; set; }

        //manager enters discount amount in Int Percentage (ex: xx% discount applied - add calculation to handle)
        public Int32 DiscountAmount { get; set; }

        //navigational properties
        public virtual List<Song> PromoSongs { get; set; }
        public virtual List<Album> PromoAlbums { get; set; }
        public virtual List<Artist> PromoArtists { get; set; }
    }
}
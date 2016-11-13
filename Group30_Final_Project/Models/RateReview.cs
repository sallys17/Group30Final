using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Group30_Final_Project.Models
{
    public class RateReview
    {
        public Int32 RateReviewID { get; set; }

        //user enters numeric rating of 1 - 5
        public Int32 intRating { get; set; }

        //user enters word review
        public String strReview { get; set; }

        //navigational properties
        public virtual Song SongRateReviews { get; set; }
        public virtual Album AlbumRateReviews { get; set; }
        public virtual Artist ArtistRateReviews { get; set; }
        public virtual User RateReviews { get; set; }
    }

}
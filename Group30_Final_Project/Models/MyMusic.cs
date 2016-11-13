using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Group30_Final_Project.Models
{
    public class MyMusic
    {
        //auto generated PK 
        public Int32 LibraryID { get; set; }

        //Name of libary for each user
        public String LibaryName { get; set; }

/********************************************************************************************************************/
/***********      Navigation properties below                ********************************************************/


        // 1 and only 1 person can own each libary
        public User LibaryUser { get; set; }




    }
}
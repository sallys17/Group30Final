using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Group30_Final_Project.Models
{
    public class User
    {
        //Auto generated PK
        public Int32 UsereID { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [RegularExpression(@"/^[A - Z]$/", ErrorMessage = "Please enter only one letter.")]
        [Display(Name = "MI")]
        public string MI { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public Int32 UserType { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Enter a valid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone Number is required.")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Please enter a valid phone number.")]
        [Display(Name = "Phone Number")]
        [RegularExpression(@"^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$", ErrorMessage = "Please enter a valid Phone number.")]
        [DisplayFormat(DataFormatString = "{0:(###)###-####}",
            ApplyFormatInEditMode = true)]
        public string Phone { get; set; }

        public string Password { get; set; }

        //only required for employees
        [RegularExpression(@"^\d{3}-\d{2}-\d{4}$", ErrorMessage = "Please enter a valid Phone number.")]
        [Display(Name = "SSN")]
        public string SSN { get; set; }

        public string EmployeeType { get; set; }

        //Credit card 1 information
        [DataType(DataType.CreditCard, ErrorMessage ="Please enter a valid credit card number.")]
        public String CreditCardNumber1 { get; set; }


        [EnumDataType(typeof(CreditCard))]
        public CreditCard CreditCardType1 { get; set; }

        // Defining enum for credit card type
        // to be used in controller after getting credit card number from user
        public enum CreditCard
        {
            Visa = 1,
            [Display(Name = "American Express")]
            AmericanExpress = 2,
            Discover = 3,
            MasterCard = 4,
        }
    
        //Credit card 2 information
        [DataType(DataType.CreditCard, ErrorMessage = "Please enter a valid credit card number.")]
        public String CreditCardNumber2 { get; set; }

        [EnumDataType(typeof(CreditCard))]
        public CreditCard CreditCardType2 { get; set; }

        public String StreetAddress1 { get; set; }
        
        public String StreetAddress2 { get; set; }

        [DataType(DataType.PostalCode, ErrorMessage ="Please enter a valid ZIP code.")]
        public String Zip { get; set; }

        //True if user account is enabled
        //managers can disable / enable a user's account
        public bool AccountEnabled { get; set; }


/********************************************************************************************************************/
/***********      Navigation properties below                ********************************************************/
/********************************************************************************************************************/

        //link to unique library for each user
        public MyMusic MyLibary { get; set; }

        //list of reviews made by the user
        public List<RateReview> UserRateReviews { get; set; }

        //orders associated with individual user
        public List<Order> SongOrders { get; set; }




        




    }
}
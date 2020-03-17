using System;

namespace HotelVirtueClasses
{
    public class clsCustomer
    {
        public int CustomerId { get; set; }
        public int ContactNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
      

        public int Valid(int someCustomerId)
        {
            //if the number field is not blank
            if (someCustomerId != 0)
            {
                return 0;
            }
            else
            {
                return 0;
            }
        }

        public long Valid(long someContactNumber)
        {
            //if the number field is not blank
            if (someContactNumber != 0)
            {
                return 0;
            }
            else
            {
                return 0;
            }
        }

        public string Valid(string someFirstName)
        {
            //if the number field is not blank
            if (someFirstName != "")
            {
                return "";
            }
            else
            {
                return "The first name may not be blank";
            }
        }

        public bool Find(int customerId)
        {
 
                //always return true
                return true;
        
        }
    }
}
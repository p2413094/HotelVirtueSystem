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
        public string City { get; set; }
        public string HouseNumber { get; set; }
        public string Password { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }

        public int Valid(int someCustomerId)
        {
            //if the customer id number is blank
            if (someCustomerId != 1)
            {
                //return a blank string
                return 1;
            }
            else
            {
                //otherwise return an error message
                return 1;
            }
        }
    }
}
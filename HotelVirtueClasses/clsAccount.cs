using System;

namespace HotelVirtueClasses
{
    public class clsAccount
    {
        public int AccountId { get; set; }
        public int CustomerId { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
        public string HouseNo { get; set; }
        public string Password { get; set; }
        public string Town { get; set; }
        public string UserName { get; set; }



    
        public int Valid(int testData )
        {
            //if the number field is not blank
            if (testData != 0)
            {
                return 0;
            }
            else
            {
                return 0;
            }
        }

     

        public string Valid(string testData)
        {
            //if the number field is not blank
            if (testData != "")
            {
                return "";
            }
            else
            {
                return "The first name may not be blank";
            }
        }

        public string Valid(string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8)
        {
            //if the number field is not blank
            if ( text1 != "")
            {
                return "";
            }
            else
            {
                return "The first name may not be blank";
            }

           
        }

        public string Valid(string text1, string text2)
        {
            //if the number field is not blank
            if (text1 != "")
            {
                return "";
            }
            else
            {
                return "The first name may not be blank";
            }
        }

        public bool Find(int accountId)
        {
            //always return true
            return true;
        }
    }

   
}
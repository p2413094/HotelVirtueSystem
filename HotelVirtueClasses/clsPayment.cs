using System;

namespace HotelVirtueClasses
{
    public class clsPayment
    {
        public int PaymentId { get; set; }
        public int CustomerId { get; set; }
        public int BookingLineId { get; set; }
        public DateTime DateTimeOfPayment { get; set; }
        public decimal Amount { get; set; }
        public string CardNumber { get; set; }
        public string NameOnCard { get; set; }
        public string ExpiryDate { get; set; }
        public string SecurityCode { get; set; }
        public string CardType { get; set; }

        public string Valid(string cardNumber, string nameOnCard, string expiryDate, string securityCode)
        {
            string error = "";
            string expiryDateFirstCharacter = expiryDate[0].ToString();
            string expiryDateSecondCharacter = expiryDate[1].ToString();
            string expiryDateThirdCharacter = expiryDate[3].ToString();
            string expiryDateFourthCharacter = expiryDate[4].ToString();
            string year = DateTime.Now.Year.ToString();
            string yearFourthNumber = year[3].ToString();

            if (cardNumber.Length < 16)
            {
                error += "Card number must not be less than 16 digits";
            }

            if (cardNumber.Length > 16)
            {
                error += "Card number must not be longer than 16 digits";
            }

            foreach (char number in cardNumber)
            {
                bool numberCheck = char.IsDigit(number);
                if (numberCheck == true)
                {

                }
                else
                {
                    error += "Card number must contain only digits";
                }
            }

            if (nameOnCard.Length < 2)
            {
                error += "The name on the card must not shorter than 2 characters";
            }

            if (CardType == "VISA")
            {
                if (nameOnCard.Length > 21)
                {
                    error += "VISA name on card must be 21 characters or less";
                }
            }

            if (CardType == "MasterCard")
            {
                if (nameOnCard.Length > 22)
                {
                    error += "MasterCard name on card must be 22 characters or less";
                }
            }

            if (nameOnCard.Length >= 2)
            {
                string formattedNameOnCard = nameOnCard.ToLower();
                string nameOnCardFirstCharacter = formattedNameOnCard[0].ToString();
                string nameOnCardSecondCharacter = formattedNameOnCard[1].ToString();

                if (nameOnCardFirstCharacter != "m")
                {
                    if (nameOnCardSecondCharacter != "i" | nameOnCardSecondCharacter != "r" | nameOnCardSecondCharacter != "")
                    {
                        error += "Name on card second character must be either 'i', 'r' or 's'";
                    }
                    error += "Name on card must start with M";
                }
            }
    
            if (expiryDateFirstCharacter != "0" && expiryDateFirstCharacter != "1")
            {
                error += "Expiry date first character must be either 0 or 1";               
            }

            if (expiryDateFirstCharacter != "1") 
            {
                if (expiryDateSecondCharacter == "0")
                {
                    error += "Expiry date second character must be between 1 and 9";
                }
            }

            if (expiryDateThirdCharacter != "2")
            {
                error += "Expiry date third character must be a 2";
            }

            if (yearFourthNumber == "0")
            {
                if (expiryDateFourthCharacter == "0")
                {
                    error += "Expiry date last character must not be 0";
                }
            }

            if (securityCode.Length < 3 | securityCode.Length > 3)
            {
                error += "Security code must be exactly 3 characters";
            }





            return error;
        }
    }
}
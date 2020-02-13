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








            return error;
        }
    }
}
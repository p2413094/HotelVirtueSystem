using System;
using System.Collections.Generic;

namespace HotelVirtueClasses
{
    public class clsPayment
    {
        private Int32 mPaymentId;
        private Int32 mCustomerId;
        private Int32 mBookingLineId;
        private DateTime mDateTimeOfPayment;
        private decimal mAmount;
        private string mCardNumber;
        private string mNameOnCard;
        private string mExpiryDate;
        private string mSecurityCode;
        private string mCardType;
        public int PaymentId
        {
            get { return mPaymentId; }
            set { mPaymentId = value; }
        }

        public int CustomerId
        {
            get { return mCustomerId; }
            set { mCustomerId = value; }
        }

        public int BookingLineId
        {
            get { return mBookingLineId; }
            set { mBookingLineId = value; }
        }

        public DateTime DateTimeOfPayment
        {
            get { return mDateTimeOfPayment; }
            set { mDateTimeOfPayment = value; }
        }

        public decimal Amount
        {
            get { return mAmount; }
            set { mAmount = value; }
        }

        public string CardNumber
        {
            get { return mCardNumber; }
            set { mCardNumber = value; }
        }

        public string NameOnCard
        {
            get { return mNameOnCard; }
            set { mNameOnCard = value; }
        }

        public string ExpiryDate
        {
            get { return mExpiryDate; }
            set { mExpiryDate = value; }
        }

        public string SecurityCode
        {
            get { return mSecurityCode; }
            set { mSecurityCode = value; }
        }

        public string CardType
        {
            get { return mCardType; }
            set { mCardType = value; }
        }

        public List<string> ErrorList = new List<string>();

        public string Valid(string cardNumber, string nameOnCard, string expiryDate, string securityCode)
        {
            string error = "";
            string expiryDateFirstCharacter;
            string expiryDateSecondCharacter;
            string expiryDateThirdCharacter;
            string expiryDateFourthCharacter;
            string year;
            string yearFourthNumber;

            try
            {
                expiryDateFirstCharacter = expiryDate[0].ToString();
                expiryDateSecondCharacter = expiryDate[1].ToString();
                expiryDateThirdCharacter = expiryDate[3].ToString();
                expiryDateFourthCharacter = expiryDate[4].ToString();
                year = DateTime.Now.Year.ToString();
                yearFourthNumber = year[3].ToString();

                if (expiryDateFirstCharacter != "0" && expiryDateFirstCharacter != "1")
                {
                    error = "Expiry date first character must be either 0 or 1";
                    ErrorList.Add(error);
                }

                if (expiryDateFirstCharacter != "1")
                {
                    if (expiryDateSecondCharacter == "0")
                    {
                        error = "Expiry date second character must be between 1 and 9";
                        ErrorList.Add(error);
                    }
                }

                if (expiryDateThirdCharacter != "2")
                {
                    error = "Expiry date third character must be a 2";
                    ErrorList.Add(error);
                }

                if (yearFourthNumber == "0")
                {
                    if (expiryDateFourthCharacter == "0")
                    {
                        error = "Expiry date last character must not be 0";
                        ErrorList.Add(error);
                    }
                }
            }

            catch
            {
                error = "Could not decompose expiry date";
                ErrorList.Add(error);
            }


            if (cardNumber.Length < 16)
            {
                error = "Card number must not be less than 16 digits";
                ErrorList.Add(error);

            }

            if (cardNumber.Length > 16)
            {
                error = "Card number must not be longer than 16 digits";
                ErrorList.Add(error);

            }

            foreach (char number in cardNumber)
            {
                bool numberCheck = char.IsDigit(number);
                if (numberCheck == false)
                {
                    error = "Card number must contain only digits";
                    ErrorList.Add(error);

                }
            }

            if (nameOnCard.Length < 2)
            {
                error = "The name on the card must not shorter than 2 characters";
                ErrorList.Add(error);
            }

            if (CardType == "VISA")
            {
                if (nameOnCard.Length > 21)
                {
                    error = "VISA name on card must be 21 characters or less";
                    ErrorList.Add(error);
                }
            }

            if (CardType == "MasterCard")
            {
                if (nameOnCard.Length > 22)
                {
                    error = "MasterCard name on card must be 22 characters or less";
                    ErrorList.Add(error);
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
                        error = "Name on card second character must be either 'i', 'r' or 's'";
                        ErrorList.Add(error);
                    }
                    error = "Name on card must start with M";
                    ErrorList.Add(error);
                }
            }             

            if (securityCode.Length < 3 | securityCode.Length > 3)
            {
                error = "Security code must be exactly 3 characters";
                ErrorList.Add(error);
            }

            return error;
        }

        public List<string> BillingErrors = new List<string>();
        public void ValidateBillingDetails(string firstName, string lastName, string emailAddress, string contactNumber)
        {
            string error;

            if (firstName.Length == 0)
            {
                error = "First name length must be bigger than 0 characters";
                BillingErrors.Add(error);
            }
            if (firstName.Length > 10)
            {
                error = "First name length must be not be bigger than 10 characters";
                BillingErrors.Add(error);
            }

            if (lastName.Length == 0)
            {
                error = "Last name length must be bigger than 0 characters";
                BillingErrors.Add(error);
            }
            if (lastName.Length > 10)
            {
                error = "Last name length must be not be bigger than 10 characters";
                BillingErrors.Add(error);
            }

            if (emailAddress.Length == 0)
            {
                error = "Email address length must be not be bigger than 50 characters";
                BillingErrors.Add(error);
            }

            if (emailAddress.Length > 50)
            {
                error = "Email address length must be not be bigger than 50 characters";
                BillingErrors.Add(error);
            }

            try
            {
                Int32 convertedContactNumber = Convert.ToInt32(contactNumber);
            }
            catch
            {
                error = "Contact number must be in an integer format";
                BillingErrors.Add(error);
            }
        }

        public bool Find(int paymentId)
        {          
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PaymentId", paymentId);
            DB.Execute("sproc_tblPayment_FilterByPaymentId");
            if (DB.Count == 1)
            {
                mPaymentId = Convert.ToInt32(DB.DataTable.Rows[0]["PaymentId"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mBookingLineId = Convert.ToInt32(DB.DataTable.Rows[0]["BookingLineId"]);
                mDateTimeOfPayment = Convert.ToDateTime(DB.DataTable.Rows[0]["DateTimeOfPayment"]);
                mAmount = Convert.ToDecimal(DB.DataTable.Rows[0]["Amount"]);
                mCardNumber = Convert.ToString(DB.DataTable.Rows[0]["CardNumber"]);
                mNameOnCard = Convert.ToString(DB.DataTable.Rows[0]["NameOnCard"]);
                mExpiryDate = Convert.ToString(DB.DataTable.Rows[0]["ExpiryDate"]);
                mSecurityCode = Convert.ToString(DB.DataTable.Rows[0]["SecurityCode"]);
                mCardType = Convert.ToString(DB.DataTable.Rows[0]["CardType"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
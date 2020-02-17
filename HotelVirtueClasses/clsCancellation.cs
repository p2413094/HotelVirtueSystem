using System;

namespace HotelVirtueClasses
{
    public class clsCancellation
    {

        public int CancellationId { get; set; }
        public int BookingLineId { get; set; }
        public string Reason { get; set; }
        public DateTime DateTimeOfCancellation { get; set; }

        public string Valid(string reason)
        {
            string Error = "";
            if (reason.Length > 50)
            {
                Error = "Cancellation reason must not be longer than 50 characters";
            }
            if (reason.Length == 0)
            {
                Error = "Cancellation reason must not be blank";
            }
            return Error;
        }
    }
}
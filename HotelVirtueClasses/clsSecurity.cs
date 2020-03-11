using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace HotelVirtueClasses
{
    public class clsSecurity
    {
        public string GetHashSecurityCode(string securityCode)
        {
            SHA256Managed HashGeneratorForSecurityCode = new SHA256Managed();
            string hashedSecurityCode;
            byte[] textBytes;
            byte[] hashBytes;
            textBytes = System.Text.Encoding.UTF8.GetBytes(securityCode);
            hashBytes = HashGeneratorForSecurityCode.ComputeHash(textBytes);
            hashedSecurityCode = BitConverter.ToString(hashBytes).Replace("-", "");

            return hashedSecurityCode;
        }
    }   
}

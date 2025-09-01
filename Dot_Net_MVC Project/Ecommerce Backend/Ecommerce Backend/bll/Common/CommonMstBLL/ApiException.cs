// using Microsoft.AspNetCore.Mvc;
// using Org.BouncyCastle.Asn1.Ocsp;
// using RTA.Masters.Models;

namespace Rta.Comman
{
    public class ApiException : Exception
    {
        public bool IsBadRequest { get; }
        public int StatusCode { get; }

        public ApiException(string message, bool isBadRequest = true, int statusCode = 400)
            : base(message)
        {
            IsBadRequest = isBadRequest;
            StatusCode = statusCode;
        }

        public ApiException(string message, Exception innerException, bool isBadRequest = true, int statusCode = 400)
            : base(message, innerException)
        {
            IsBadRequest = isBadRequest;
            StatusCode = statusCode;
        }
    }

}

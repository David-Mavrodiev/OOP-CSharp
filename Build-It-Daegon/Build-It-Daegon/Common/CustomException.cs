using System;

namespace Build_It_Daegon.Common
{
    public class CustomException : ApplicationException
    {
        public CustomException(String message)
        {
            this.Message = message;
        }
        public string Message { get; private set; }
    }
}
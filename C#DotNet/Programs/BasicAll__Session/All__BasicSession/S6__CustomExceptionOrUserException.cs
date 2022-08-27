using System;
using System.Collections.Generic;
using System.Text;

namespace Basic__AllSession
{
    public class S6__CustomExceptionOrUserException : Exception
    {
        public enum UserException 
        {
            INVALID_DATA, INVALID_VALUE
        }
        private readonly UserException Type;
        public S6__CustomExceptionOrUserException(UserException Type, string Message) : base(Message) 
        {
            this.Type = Type;
        }
    }
}

using System;

namespace CSharp_04.Exceptions
{
    class UserExistsException : Exception
    {
        public override string Message => "User is already exist!";
    }
}

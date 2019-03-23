using System;

namespace CSharp_04.Exceptions
{
    class UserIsNotExistsException : Exception
    {
        public override string Message => "User is not exist!";
    }
}

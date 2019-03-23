using System;

namespace CSharp_04.Exceptions
{
    class EmailException : Exception
    {
        public override string Message => "Email adress is not correct!";
    }
}

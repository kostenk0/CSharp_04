using System;

namespace CSharp_04.Exceptions
{
    class BornException : Exception
    {
        public override string Message => "You have not born yet!";
    }
}

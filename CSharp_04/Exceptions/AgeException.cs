using System;

namespace CSharp_04.Exceptions
{
    class AgeException : Exception
    {
        public override string Message => "Wrong age";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepthrow
{
    internal class ownException : Exception
    {
        public ownException() { }
        public ownException(string message) : base(message) { }
    }
}

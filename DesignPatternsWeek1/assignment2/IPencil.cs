using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public interface IPencil
    {
        bool CanWrite { get; } // determines if the pencil can still write
        void Write(string message); // writes characters of the message
        void AfterSharpening(); // the pencil is made ‘new’ (so it can write 'max' again)
    }
}

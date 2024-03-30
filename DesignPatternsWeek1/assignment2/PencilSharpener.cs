using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class PencilSharpener : IPencilSharpener
    {
        public void Sharpen(IPencil pencil)
        {
            pencil.AfterSharpening();
        }
    }
}

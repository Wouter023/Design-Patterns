using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public interface IStack
    {
        void Push(int Value);

        int Pop();

        bool Contains(int value);

        int Count { get; }

        bool isEmpty { get; }
    }
}

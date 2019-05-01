using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap_Sort
{
    interface IHeap
    {
        void Insert(int data);
        void Delete(int data);
    }
}

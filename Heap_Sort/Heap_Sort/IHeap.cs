using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap_Sort
{
    interface IHeap
    {
        bool Insert(int data);
        bool Update(int delData, int addData);
        bool Delete(int data);
    }
}

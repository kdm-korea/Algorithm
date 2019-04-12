using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    interface ITree<T>
    {
        bool Create(T root);
        bool Insert(T parent, T child);
        bool Find(T value);
        bool Delete(T value);
    }
}

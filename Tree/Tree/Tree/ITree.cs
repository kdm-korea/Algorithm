using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface ITree<T, E>
    {
        bool Insert(E node, T data, Direct direct);
        bool Delete(T data);
        Node<T> Retreive(T data);
        Node<T> Root();
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    interface ITree<T, V>
    {
        bool Insert(T parent, T child, bool direction);
        V Find(T value);
        bool Delete(T value);
    }
}

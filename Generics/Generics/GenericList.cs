﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class GenericList<T>
    {
        public void Add(T value)
        {

        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}

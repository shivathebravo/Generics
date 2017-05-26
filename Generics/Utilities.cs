﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    
    //where T:IComparable
    //where T:Product
    //wherer T:Struct value type
    //where T:Class
    //where T:new()
    public class Utilities<T> where T:IComparable,new()
    {
        public int Max (int a, int b)
        {
            return a > b ? a : b;
        }

        public T Max<T>( T a, T b) where T: IComparable
        {
           return a.CompareTo(b) > 0 ? a : b;
        }

        public void Dosomething( T value)
        {
            var obj = new T();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithSpikes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Disposable.FunWithDisposable();

            Foo f = new Foo().WithValue("what");

            Console.WriteLine(f.Value);
        }
    }
}

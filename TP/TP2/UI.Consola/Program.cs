using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    class Program
    {

        static void Main(string[] args)
        {
            new Usuario().Menu();
        }
    }
}

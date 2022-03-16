using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Delegates
{
    class Fruit
    {
        public string Vitamin;
        public Fruit(string vitamin)
        {
            Vitamin = vitamin;
        }
        public override string ToString()
        {
            return $"Fruit vitamins : {Vitamin}";
        }
    }
}

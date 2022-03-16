using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Delegates
{
    class Pineapple:Fruit
    {
        public string Color;
        public Pineapple(string vitamin) : base (vitamin)
        {
            Vitamin = vitamin;
        }
        public override string ToString()
        {
            return $"Pineapple vitamin : {Vitamin}";
        }
    }
}

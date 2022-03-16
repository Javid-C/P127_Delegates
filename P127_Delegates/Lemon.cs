using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Delegates
{
    class Lemon:Fruit
    {
        public string Color;
        public Lemon(string vitamin) : base(vitamin)
        {
            Vitamin = vitamin;
        }
        public override string ToString()
        {
            return $"Lemon vitamin : {Vitamin}";
        }

    }
}

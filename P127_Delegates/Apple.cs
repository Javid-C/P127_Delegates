using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Delegates
{
    class Apple:Fruit
    {
        public string Color;
        public Apple(string vitamin) : base(vitamin)
        {
            Vitamin = vitamin;
        }
        public override string ToString()
        {
            return $"Apple vitamin : {Vitamin}";
        }
    }
}

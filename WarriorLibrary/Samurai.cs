using System;
using System.Collections.Generic;
using System.Text;

namespace DIDemo
{
    public class Samurai : Warrior
    {
        public Samurai(IWeapon weapon) : base(weapon)
        {
            this.Name = "Samuria";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class IAmBroken : ILightState
    {
        public ILightState TurnOff()
    {
        Console.WriteLine("broken");
            return this;
    }

    public ILightState TurnOn()
    {
        Console.WriteLine("broken");
        return this;
    }
        public ILightState Fix()
        {
            Console.WriteLine("you Fix it");
            return new IAmOff();
        }
    }
}

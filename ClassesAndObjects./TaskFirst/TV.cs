using System;

namespace Task2
{
    public class TV : OnOff
    {
        internal string modelName;

        public void On()
        {
            Console.Write($"TV '{modelName}' turned on");
        }

        public void Off()
        {
            Console.Write($"TV '{modelName}' turned on");
        }
    }
}

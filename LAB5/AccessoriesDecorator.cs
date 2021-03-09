using System;
using System.Collections.Generic;
using System.Text;

namespace LAB2_3
{
    public abstract class AccessoriesDecorator : Computer
    {
        protected Computer computer;
        public AccessoriesDecorator(string n, Computer computer) : base()
        {
            this.computer = computer;
            this.accessories += n;
        }
    }

    class ComputerWithWebcam : AccessoriesDecorator
    {
        public ComputerWithWebcam(Computer computer) : base(computer.accessories + " Камера", computer)
        { }
    }

    class ComputerWithFingerprint : AccessoriesDecorator
    {
        public ComputerWithFingerprint(Computer computer) : base(computer.accessories + " Сканер отпечатков пальцев", computer)
        { }
    }

    class ComputerWithSecondDisplay : AccessoriesDecorator
    {
        public ComputerWithSecondDisplay(Computer computer) : base(computer.accessories + " Второй экран", computer)
        { }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LAB2_3
{
    public abstract class PCBuilderBase
    {
        protected Computer pc;

        protected PCBuilderBase()
        {
            pc = new Computer();
        }

        public abstract void BuildProcessor();
        public abstract void BuildVideocard();
        public abstract void BuildRAM();
        public abstract void BuildSSD();
        public abstract void BuildHDD();
        public void DateOfPurchase()
        {
            pc.dateOfPurchase = DateTime.Now;
        }

        public Computer GetComputer()
        {
            return pc;
        }
    }
}

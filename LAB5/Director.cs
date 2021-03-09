using System;
using System.Collections.Generic;
using System.Text;

namespace LAB2_3
{
    public class Director : IObserver
    {
        private PCBuilderBase builderBase;
        public bool approval { get; set; }

        public PCBuilderBase BuilderBase
        {
            set { builderBase = value; }
        }

        public void Update(object obj)
        {
            Computer computer = (Computer)obj;
            if (computer.processor.Model != null)
                approval = true;
            else
                approval = false;
        }

        public void BuildWithoutVideocard()
        {
            this.builderBase.BuildProcessor();
            this.builderBase.BuildRAM();
            this.builderBase.BuildSSD();
            this.builderBase.BuildHDD();
            this.builderBase.DateOfPurchase();
        }

        public void BuildWithVideocard()
        {
            this.builderBase.BuildProcessor();
            this.builderBase.BuildRAM();
            this.builderBase.BuildSSD();
            this.builderBase.BuildHDD();
            this.builderBase.BuildVideocard();
            this.builderBase.DateOfPurchase();
        }
    }
}

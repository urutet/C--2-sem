using System;
using System.Collections.Generic;
using System.Text;

namespace LAB2_3
{
    public class Director
    {
        private PCBuilderBase builderBase;

        public PCBuilderBase BuilderBase
        {
            set { builderBase = value; }
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

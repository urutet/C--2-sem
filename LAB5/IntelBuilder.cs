using System;
using System.Collections.Generic;
using System.Text;

namespace LAB2_3
{
    class IntelBuilder : PCBuilderBase
    {
        List<IObserver> observers;

        public IntelBuilder() : base()
        {
            observers = new List<IObserver>();
        }

        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (var obs in observers)
            {
                obs.Update(pc);
            }
        }

        public override void BuildProcessor()
        {
            this.pc.processor = new Processor();
            this.pc.processor.manufacturer = Processor.Manufacturer.Intel;
            this.pc.processor.baseClock = 2200;
            this.pc.processor.maxClock = 3400;
            this.pc.processor.Model = "Kaby Lake";
            this.pc.processor.Series = "Core i5";
            this.pc.processor.numberOfCores = 6;
            this.pc.processor.l1_3CacheSize = 16;
        }

        public override void BuildVideocard()
        {
            this.pc.videocard = new Videocard();
            this.pc.videocard.manufacturer = Videocard.Manufacturer.Nvidia;
            this.pc.videocard.Model = "GTX 1650 Ti";
            this.pc.videocard.Series = "Pascal";
            this.pc.videocard.VRAMSizeGB = 4;
            this.pc.videocard.baseClock = "1140";
            this.pc.videocard.DirectX11Support = true;
        }

        public override void BuildHDD()
        {
            this.pc.HDDdiskSizeGB = 500;
        }

        public override void BuildSSD()
        {
            this.pc.SSDdiskSizeGB = 250;
        }

        public override void BuildRAM()
        {
            this.pc.RAMType = "DDR4";
            this.pc.RAMSizeGB = 16;
        }
    }
}

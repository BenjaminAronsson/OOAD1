using System;
namespace OOAD_labb1
{
    public class Computer
    {
        public enum ProcessorBrand
        {
            INTEL, AMD
        }

        public ProcessorBrand Brand { get; set; }
        public string Color { get; set; }
        public int ClockSpeed { get; set; }
        public string GPU { get; set; }
        public string CpuCooler { get; set; }
        public int RAMSize { get; set; }
        public int diskStorage  { get; set; }
        public int NumberOfFans { get; set; }

        public override string ToString()
        {
            return "Brand: " + Brand + "\nColor: " + Color + "\nclockspeed: " + ClockSpeed + "\ngpu: " + GPU + "\ncoller: " + CpuCooler +"\n";
        }

        public class Builder
        {
            ProcessorBrand brand;
            private string color;
            private int clockSpeed;
            private string gpu;
            private string cpuCooler;
            private int ramSize;
            private int diskStorage;
            private int numberOfFans;

            public Builder WithBrand(ProcessorBrand brand)
            {
                this.brand = brand;
                return this;
            }
            public Builder WithColor(string color)
            {
                this.color = color;
                return this;
            }
            public Builder WithClockSpeed(int clockSpeed)
            {
                this.clockSpeed = clockSpeed;
                return this;
            }
            public Builder WithGpu(string gpu)
            {
                this.gpu = gpu;
                return this;
            }
            public Builder WithCooler(string cpuCooler)
            {
                this.cpuCooler = cpuCooler;
                return this;
            }
            public Builder WithRam(int ramSize)
            {
                this.ramSize = ramSize;
                return this;
            }
            public Builder WithStorage(int diskStorage)
            {
                this.diskStorage = diskStorage;
                return this;
            }
            public Builder WithNumberOfFans(int numberOfFans)
            {
                this.numberOfFans = numberOfFans;
                return this;
            }

            public Computer Build()
            {
                Computer computer = new Computer();
                computer.Brand = brand;
                computer.ClockSpeed = clockSpeed;
                computer.Color = color;
                computer.CpuCooler = cpuCooler;
                computer.diskStorage = diskStorage;
                computer.GPU = gpu;
                computer.NumberOfFans = numberOfFans;
                computer.RAMSize = ramSize;
                return computer;
            }
        }
    }

    
}

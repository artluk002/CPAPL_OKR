using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKRKPIAP
{
    public class Computer
    {
        private int frequency;
        public int Frequency { get { return frequency; } set { frequency = value > 0 ? value : value / -1; } }
        private int coresCount;
        public int CoresCount { get { return coresCount; } set { coresCount = value > 0 ? value: 2; } }
        private int memoryVolume;
        public int MemoryVolume { get { return memoryVolume; } set { memoryVolume = value; } }
        private int hardDiskVolume;
        public int HardDiskVolume { get { return hardDiskVolume; } set { hardDiskVolume = value; } }
        public virtual double Price()
        {
            return Frequency * CoresCount / 100 + MemoryVolume / 80 + HardDiskVolume / 20;
        }
        public virtual bool Prigodnost()
        {
            if(Frequency >= 2000)
                if(CoresCount >= 2)
                    if(MemoryVolume >= 2048)
                        if(HardDiskVolume >= 320)
                            return true;
            return false;
        }
        public Computer() { }
        public Computer(int frequency, int coresCount, int memoryVolume, int hardDiskVolume)
        {
            Frequency = frequency;
            CoresCount = coresCount;
            MemoryVolume = memoryVolume;
            HardDiskVolume = hardDiskVolume;
        }

        public override string ToString()
        {
            return $"{frequency} {coresCount} {memoryVolume} {hardDiskVolume} {Price()} {Prigodnost()}";
        }

    }
}

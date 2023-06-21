using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKRKPIAP
{
    public class NetBook : Computer
    {
        private int autonomWork;
        public int AutonomWork { get { return autonomWork; } set { autonomWork = value; } }

        public override double Price()
        {
            return base.Price() + autonomWork / 10;
        }
        public override bool Prigodnost()
        {
            if(base.Prigodnost())
                if(autonomWork >= 60)
                    return true;
            return false;
        }
        public NetBook() { }
        public NetBook(int autonomWork) : base()
        {
            AutonomWork = autonomWork;
        }
        public NetBook(int frequency, int coresCount, int memoryVolume, int hardDiskVolume, int autonomWork) : base(frequency, coresCount, memoryVolume, hardDiskVolume)
        {
            AutonomWork = autonomWork;
        }
        public override string ToString()
        {
            return base.ToString() + " " + autonomWork;
        }
    }
}

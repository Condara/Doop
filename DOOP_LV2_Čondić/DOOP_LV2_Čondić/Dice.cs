using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_LV2_Čondić
{
    class Dice
    {
        private int SidesNum;
        private Random randG;
        public Dice(int SidesNum)
        {
            this.SidesNum = SidesNum;
            this.randG = new Random();
        }
        public Dice(int SidesNum, Random rand)
        {
            this.SidesNum = SidesNum;
            this.randG = rand;
        }
        public int Roll()
        {
            return RandomGenerator.GetInstance().NextInt(1, 6);
        }
    }
}
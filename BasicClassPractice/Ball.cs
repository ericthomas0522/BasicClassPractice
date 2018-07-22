using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassPractice
{
    class Ball
    {
        private int size;
        private int timesThrown;
      

        public Ball(int size)
        {
            this.size = size;
            timesThrown = 0;
        }

        public void Pop(Ball ball)
        {
            size = 0;
        }

        public void Throw(Ball ball)
        {
            if (size > 0)
            {
                timesThrown++;
            }
        }

        public int TimesThrown(Ball ball)
        {
            return timesThrown;
        }
    }
}

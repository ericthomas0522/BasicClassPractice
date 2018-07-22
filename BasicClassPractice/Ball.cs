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
        private Color color;

        public Ball(Color color, int size)
        {
            this.size = size;
            this.color = color;
            timesThrown = 0;
        }

        public void Pop()
        {
            size = 0;
        }

        public void Throw()
        {
            if (size > 0)
            {
                timesThrown++;
            }
        }

        public int TimesThrown()
        {
            return timesThrown;
        }
    }
}

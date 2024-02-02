using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial
{
      partial class Calcii
    {
        private int x;
        public Calcii(int num)
        {
            x = num;
        }
        partial void add(int a, int b);

        public void addPublic(int a, int b)
        {
            this.add(a, b);

        }
    }
}

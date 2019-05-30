using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class RandomNumber
    {
        private List<int> num = new List<int>();
        private Random random = new Random();

        public List<int> Create_RandomNumber() {
            for (int idx = 0; idx < 100000; idx++) {
                num.Add(random.Next(0, 100000));
            }
            return num;
        }
    }
}

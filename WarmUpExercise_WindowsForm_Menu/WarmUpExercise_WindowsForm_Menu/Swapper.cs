using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUpExercise_Menu
{
    class Swapper
    {
        private int a;
        private int b;

        public Swapper()
        {
            a = 0;
            b = 0;
        }

        public Swapper(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public string A { get; set; }
        public string B { get; set; }

        public int Swap()
        {
            int temp = a;
            a = b;
            b = temp;

            return a;
        }
    }
}

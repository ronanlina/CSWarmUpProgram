using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUpExercise_Menu
{
    class Reverse
    {
        private int number;

        public Reverse()
        {
            number = 0;
        }

        public Reverse(int number)
        {
            this.number = number;
        }

        public string Number { get; set; }

        public int DoReverse()
        {
            int temp;

            int reversed = 0;
            while (number != 0)
            {
                temp = number % 10;
                reversed = reversed * 10 + temp;
                number = number / 10;
            }

            return reversed;
        }
    }
}

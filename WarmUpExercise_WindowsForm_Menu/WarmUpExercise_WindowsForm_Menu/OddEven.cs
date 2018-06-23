using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUpExercise_Menu
{
    class OddEven
    {
        private int number;

        public OddEven()
        {
            number = 0;
        }

        public OddEven(int number)
        {
            this.number = number;
        }

        public string Number { get; set; }

        public string IsOddEven()
        {
            if (!(number % 2 == 0))
            {
                return "ODD";
            }

            return "EVEN";
        }
    }
}

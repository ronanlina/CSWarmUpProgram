using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUpExercise_Menu
{
    class SumOfDigits
    {

        private int number;

        public SumOfDigits()
        {
            number = 0;
        }

        public SumOfDigits(int number)
        {
            this.number = number;
        }

        public string Number { get; set; }

        public int GetSum()
        {
            int sum = 0;
            string temp = number.ToString();

            for (int i = 0; i < temp.Length; i++)
            {
                sum = sum + Int32.Parse(temp[i].ToString());
            }

            return sum;
        }

    }
}

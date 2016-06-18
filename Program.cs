using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3Bnum {
    class Program {
        static void Main(string[] args) {
            int[] myArray = { 200, 0, 100, -100, 0, 300 };
            int num = 5;
            bool found = false;
            while (!found) {
                if(myArray[num] ==0) {
                    found = true;
                }
                num--;
                Console.Write(num); //= 4
                Console.ReadKey();
            }
        }
    }
}

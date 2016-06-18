using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastPairOfDuplicates {
    class Program {
        static void Main(string[] args) {
            int[] anArray = { 1, 9, 1, 9, 9, 5, 7, 7, 4 };
            int index = LastPairOfDuplicates(anArray);

        }
        public static int LastPairOfDuplicates(int[] anArray) {
            int index;
            for (int i = anArray.Length; i > -1; i = i - 1) {
                if (i == i + 1) {
                    index = i;
                    break;
                    return index;
                } else {
                    return 
                }
               
                
            }
            
        }
    }
}


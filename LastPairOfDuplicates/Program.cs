using System;
// displays index of the first of last pair
namespace LastPairOfDuplicates {
    class Program {
        static void Main(string[] args) {
            int[] anArray = { 1, 9, 1, 9, 9, 5, 7, 7, 4 };
            int index = LastPairOfDuplicates(anArray); // 6
            DisplayResult(index);
  
        }
        public static int LastPairOfDuplicates(int[] anArray) {
            int index = 0;
            for (int i = 1; i < anArray.Length; i++) {
                if (anArray[i] == anArray[i - 1]) {
                    index = i - 1;
                }
            }          
            return index;

        }
        public static void DisplayResult(int index) {
            Console.WriteLine(index);
            Console.ReadKey();
        }
    }
}


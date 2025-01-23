

namespace LarningCSharp.Class_007
{
    public class ArrayHelpers
    {


        public class Helpers
        {

            // Add an element to an array
            public  int[] AddElement(int[] array, int element)
            {
                int[] newArray = new int[array.Length + 1];
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }
                newArray[array.Length] = element;
                return newArray;
            }

            // Delete an element from an array
            public  int[] DeleteElement(int[] array, int element)
            {
                int count = 0;
                foreach (var num in array)
                {
                    if (num == element) count++;
                }

                if (count == 0) return array; // Element not found

                int[] newArray = new int[array.Length - count];
                int index = 0;
                foreach (var num in array)
                {
                    if (num != element)
                    {
                        newArray[index++] = num;
                    }
                }
                return newArray;
            }

            // Traverse the array
            public  void Traverse(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"Index {i}: {array[i]}");
                }
            }

            // Count elements in the array
            public  int CountElements(int[] array)
            {
                return array.Length;
            }

            // Search for an element in the array
            public  bool SearchElement(int[] array, int element)
            {
                foreach (var num in array)
                {
                    if (num == element)
                    {
                        return true;
                    }
                }
                return false;
            }


        }






        public void Main()
        {
            //int number = 0;
            //string name = "Tahim";
            //char c = 'a';
            ////Create an array 
            //int[] numbers = {10, 20, 30,40 ,50};
            //string[] names = { "Tahim", "Mamun", "Roshid", "Hazeat" };
            //char[] chars = { 'a', 'b', 'c', 'e', 'f' };

            //for (int i = 0; i < chars.Length; i++)
            //{
            //    Console.WriteLine(chars[i]);
            //}
            //foreach (var item in chars)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] numbers = new int[5];
            //int[] newNumber = { 10, 20, 30, 40, 50 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = newNumber[i];
            //    Console.WriteLine($"{i} : {newNumber[i]}");
            //}

            //int[] numbers = { 10, 20, 30, 40 };

            //// Remove an element (e.g., 20)
            //int elementToRemove = 20;
            //int[] updatedNumbers = new int[numbers.Length - 1];

            //int index = 0;
            //foreach (var num in numbers)
            //{
            //    if (num != elementToRemove)
            //    {
            //        updatedNumbers[index++] = num;
            //    }
            //}

            //// Print the updated array
            //Console.WriteLine("After Deleting:");
            //foreach (var num in updatedNumbers)
            //{
            //    Console.Write(num + " ");
            //}


            //int[] numbers = { 10, 20, 30, 40 };

            //Console.WriteLine("Traversing Array:");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"Index {i}: {numbers[i]}");
            //}



            //int[] numbers = { 10, 20, 30, 40 };

            //int elementToFind = 3;
            //bool found = false;

            //foreach (var num in numbers)
            //{
            //    if (num == elementToFind)
            //    {
            //        found = true;
            //        break;
            //    }
            //}

            //Console.WriteLine($"Element {elementToFind} Found: {found}");
            //int[] numbers = { 10, 20, 30, 40 };

            //int count=0;

            //foreach (var item in numbers)
            //{
            //    count++;
            //}

            //Console.WriteLine(numbers.Length);

            var method = new Helpers();

            int[] numbers = { 10, 20, 30, 40, 50 };
            

          numbers = method.AddElement(numbers, 60);
            Console.WriteLine(numbers.Length);

        }
    }
}

namespace LarningCSharp.Class_002
{
    public class Operators
    {
        public void Main()
        {

            // 1 : Arithmetical Operators 
            //-------------------------------------
            // + , - ,* ,/ ,%

            //int num1 = 10;
            //int num2 = 20;
            //int ans = num1 % num2;
            /*
             
             */

            /*
            Assignment Operators 
            -------------------------------------
                = Assigns to
                += Add and Assigns to
                -= Subtract and Assigns to
                *= Multiply and Assigns to
                /= Divide and Assigns to
                %= Remainder Assigns to


            // Assign '=' Operator
            int number = 10;
            Console.WriteLine("Assign '=' Operator:");
            Console.WriteLine($"number = {number}"); // Output: 10

            // Add and Assign '+=' Operator
            number += 5; // Same as: number = number + 5
            Console.WriteLine("\nAdd and Assign '+=' Operator:");
            Console.WriteLine($"number += 5; Result: {number}"); // Output: 15
                                                                 // Subtract and Assign '-=' Operator
            number -= 3; // Same as: number = number - 3
            Console.WriteLine("\nSubtract and Assign '-=' Operator:");
            Console.WriteLine($"number -= 3; Result: {number}"); // Output: 12

            // Multiply and Assign '*=' Operator
            number *= 2; // Same as: number = number * 2
            Console.WriteLine("\nMultiply and Assign '*=' Operator:");
            Console.WriteLine($"number *= 2; Result: {number}"); // Output: 24


            // Divide and Assign '/=' Operator
            number /= 2; // Same as: number = number / 2
            Console.WriteLine("\nDivide and Assign '/=' Operator:");
            Console.WriteLine($"number /= 4; Result: {number}"); // Output: 12


            // Remainder and Assign '%=' Operator
            number %= 5; // Same as: number = number % 5
            Console.WriteLine("\nRemainder and Assign '%=' Operator:");
            Console.WriteLine($"number %= 5; Result: {number}"); // Output: 1

             */

            /*
           Increment / Decrement Operators
            -------------------------------------
               n++ Post-Incrementation (First it returns value;
                then increments)
                ++ n Pre-Incrementation (First it increments
                value; then returns)
                n-- Post-Decrementation (First it returns value;
                then decrements)
                --n Pre-Decrementation (First it decrements
                value; then returns)




             int n = 5;

            // Post-Incrementation: n++ (First return, then increment)
            Console.WriteLine("Post-Increment (n++):");
            Console.WriteLine($"Value before increment: {n}"); // 5
            Console.WriteLine($"Returned value: {n++}");      // 5
            Console.WriteLine($"Value after increment: {n}"); // 6

            // Pre-Incrementation: ++n (First increment, then return)
            Console.WriteLine("\nPre-Increment (++n):");
            n = 5; // Reset value
            Console.WriteLine($"Value before increment: {n}"); // 5
            Console.WriteLine($"Returned value: {++n}");      // 6
            Console.WriteLine($"Value after increment: {n}"); // 6

            // Post-Decrementation: n-- (First return, then decrement)
            Console.WriteLine("\nPost-Decrement (n--):");
            n = 5; // Reset value
            Console.WriteLine($"Value before decrement: {n}"); // 5
            Console.WriteLine($"Returned value: {n--}");       // 5
            Console.WriteLine($"Value after decrement: {n}");  // 4

            // Pre-Decrementation: --n (First decrement, then return)
            Console.WriteLine("\nPre-Decrement (--n):");
            n = 5; // Reset value
            Console.WriteLine($"Value before decrement: {n}"); // 5
            Console.WriteLine($"Returned value: {--n}");       // 4
            Console.WriteLine($"Value after decrement: {n}");  // 4

             */
            /*
             
            Comparison Operators
            ----------------------------------

            Used to compare two values and return true/false,
            based on the condition.
            == equal to
            != not equal to
            < less than
            > greater than
            <= less than or equal to
            >= greater than or equal to
             

            int a = 10;
            int b = 20;

            // == Equal To
            Console.WriteLine("== Equal To:");
            Console.WriteLine($"a == b: {a == b}"); // false

            // != Not Equal To
            Console.WriteLine("\n!= Not Equal To:");
            Console.WriteLine($"a != b: {a != b}"); // true

            // < Less Than
            Console.WriteLine("\n< Less Than:");
            Console.WriteLine($"a < b: {a < b}"); // true

            // > Greater Than
            Console.WriteLine("\n> Greater Than:");
            Console.WriteLine($"a > b: {a > b}"); // false

            // <= Less Than or Equal To
            Console.WriteLine("\n<= Less Than or Equal To:");
            Console.WriteLine($"a <= b: {a <= b}"); // true
            Console.WriteLine($"a <= 10: {a <= 10}"); // true

            // >= Greater Than or Equal To
            Console.WriteLine("\n>= Greater Than or Equal To:");
            Console.WriteLine($"a >= b: {a >= b}"); // false
            Console.WriteLine($"a >= 10: {a >= 10}"); // true

             */

            /*
             Logical Operators
               -----------------------

            Checks both operands (Boolean) and returns
            true/false.
            & Logical And (Both operands should be true).
            Evaluates both operands, even if left-hand
            operand returns false.
            && Conditional And (Both operands should be
            true). Doesn't evaluate right-hand operand, if
            left-hand operand returns false.
            | Logical Or (At least any one operand should
            be true). Evaluates both operands, even if lefthand operand returns true.
            || Conditional Or (At least any one operand
            should be true). Doesn't evaluate right-hand
            operand, if left-hand operand returns true.



            bool operand1 = true;
            bool operand2 = false;

            // & Logical And
            Console.WriteLine("& Logical And:");
            Console.WriteLine($"operand1 & operand2: {operand1 & operand2}"); // false
            Console.WriteLine($"operand1 & true: {operand1 & true}"); // true

            // && Conditional And
            Console.WriteLine("\n&& Conditional And:");
            Console.WriteLine($"operand1 && operand2: {operand2 && operand1}"); // false
            Console.WriteLine($"operand1 && true: {operand1 && true}"); // true

            // | Logical Or
            Console.WriteLine("\n| Logical Or:");
            Console.WriteLine($"operand1 | operand2: {operand1 | operand2}"); // true
            Console.WriteLine($"operand2 | false: {operand2 | false}"); // false

            // || Conditional Or
            Console.WriteLine("\n|| Conditional Or:");
            Console.WriteLine($"operand1 || operand2: {operand1 || operand2}"); // true
            Console.WriteLine($"operand2 || true: {operand2 || true}"); // true

         */
        }

    }
}

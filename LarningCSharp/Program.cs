﻿using System.Collections;

class Program
{
    static void Main()
    {
        //Lifo = Last in First Out
        Stack<string> st = new Stack<string>();

        // Push() item add 
        st.Push("First");
        st.Push("Second");
        st.Push("Third");
        Console.WriteLine(st.Count);
        // Pop() item Out 

        //st.Pop();


        // Peek()
        string topItem = st.Peek();
        Console.WriteLine(topItem);

        // Clear()
        st.Clear();

        // Count()
        
        //while (st.Count > 0)
        //{
        //    Console.WriteLine(st.Pop());
        //}

    }
}
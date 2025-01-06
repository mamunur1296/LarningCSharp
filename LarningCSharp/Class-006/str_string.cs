namespace LarningCSharp.Class_006
{
    public class str_string
    {
        public void Main()
        {
            // Clone
            string original = "Hello, World!";
            object cloned = original.Clone();
            Console.WriteLine($"Original: {original}");
            Console.WriteLine($"Clone: {cloned}"); // orginal clone kore

            // CompareTo
            string str1 = "apple";
            string str2 = "ban";
            Console.WriteLine($"CompareTo: {str1.CompareTo(str2)}"); // size compare kore

            // Contains
            Console.WriteLine($"Contains: {original.Contains("World")}"); // kono word ache naki nai check kore

            // CopyTo
            char[] destinationArray = new char[5];
            original.CopyTo(7, destinationArray, 0, 5);
            Console.WriteLine($"CopyTo: {new string(destinationArray)}"); // word copy kore boshay

            // EndsWith
            Console.WriteLine($"EndsWith: {original.EndsWith("!")}"); // end e ki ache check kore

            // Equals
            Console.WriteLine($"Equals: {original.Equals("Hello World!")}"); // 2tai equal kina check kore

            // IndexOf
            Console.WriteLine($"IndexOf: {original.IndexOf('W')}"); // index koto check kore

            // IndexOfAny
            char[] charsToFind = { 'o', 'r' };
            Console.WriteLine($"IndexOfAny: {original.IndexOfAny(charsToFind)}"); // 

            // Insert
            Console.WriteLine($"Insert: {original.Insert(7, "Beautiful ")}"); // new word add kore

            // IsNormalized
            Console.WriteLine($"IsNormalized: {original.IsNormalized()}");

            // LastIndexOf
            Console.WriteLine($"LastIndexOf: {original.LastIndexOf('l')}"); // Output: 10

            // LastIndexOfAny
            Console.WriteLine($"LastIndexOfAny: {original.LastIndexOfAny(charsToFind)}"); // Output: 8

            // Normalize
            string normalized = original.Normalize();
            Console.WriteLine($"Normalize: {normalized}"); //

            // PadLeft
            Console.WriteLine($"PadLeft: {original.PadLeft(25, '-')}"); // space

            // PadRight
            Console.WriteLine($"PadRight: {original.PadRight(20, '-')}"); // space

            // Remove
            Console.WriteLine($"Remove: {original.Remove(7, 6)}"); // remove kore

            // Replace
            Console.WriteLine($"Replace: {original.Replace("World", "C#")}"); // replace kore

            // Split
            string[] words = original.Split(' ');
            Console.WriteLine($"Split: {string.Join(", ", words)}"); // 

            // StartsWith
            Console.WriteLine($"StartsWith: {original.StartsWith("Hello")}"); // ki diye start hoy check kore

            // Substring
            Console.WriteLine($"Substring: {original.Substring(7, 5)}"); // string er index onujauyi word dey

            // ToCharArray
            char[] charArray = original.ToCharArray();
            Console.WriteLine($"ToCharArray: {string.Join(", ", charArray)}"); //

            // ToLower
            Console.WriteLine($"ToLower: {original.ToLower()}"); // small letter kore dey

            // ToUpper
            Console.WriteLine($"ToUpper: {original.ToUpper()}"); // big letter kore dey

            // Trim
            string spaced = "   Hello   ";
            Console.WriteLine($"Trim: {spaced.Trim()}"); // kono space thakle trim kore

            // TrimStart
            Console.WriteLine($"TrimStart: {spaced.TrimStart()}"); // shurur tuku trim kore
            // TrimEnd
            Console.WriteLine($"TrimEnd: {spaced.TrimEnd()}"); // shesher tuku trim kore
            Console.WriteLine("sByte: {0} ");

        }
    }
}

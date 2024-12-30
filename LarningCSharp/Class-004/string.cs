using System.Diagnostics.Metrics;

namespace LarningCSharp.Class_004
{
    public class @string
    {
        public void Main()
        {
            string message1;
            string ? message2 = "Message";
            string message3 = string.Empty;
            string oldPath = @"c:\\Program Files\\Microsoft {message2} \n Visual Studio 8.0";
            string newPath = @"c:\Program Files\Microsoft Visual Studio 9.0";
            string oldPath2 = "Hello Would !";
            var temp = "I'm still a strongly-typed System.String!";
            const string message4 = "Abc Company";
            const int message5 = 5;

            char[] letters = { 'A', 'B', 'C' };
            char letters1 = 'A';



            string s1 = " A string is more";
            string s2 = " than the sum of its chars .  ";

            s1 += s2;


            string str1 = "Hello ";
            string str2 = str1;
            str1 += "World";



            string columns = " Columns 1 \tColumns 2\tColumns 3";
            string rows = " Row 1\r\nRow 2\r\nRow 3";




            string title = "\"The \u00C6olean Harp\", by Samuel Taylor Coleridge";



            var jh = (firstName:"Mamunur",lastName:"Rushid",born:1997,published:2024);




            

            char[] letterss = { 'a', 'b', 'c', 'd', 'e' };

            //for (int i = 0; i < letterss.Length; i++)
            //{
            //    Console.WriteLine("letter :- " + letterss[i] + i);
            //}

            //foreach (char letter in letterss) 
            //{
            //    Console.WriteLine(letter);
            //}

            string s3 = "visuek C sharp Express";
            string s33 = "visuek  sharp Express";
            //Console.WriteLine(s3.ToLower());
            //Console.WriteLine(s3.ToUpper());
            //Console.WriteLine(s3.Substring(3,5));
            //Console.WriteLine(Substr(s3,3,5));
            var s4 = s3.Clone(); // this Clone() methods to mack Copy parants data 
            Console.WriteLine(s3.CompareTo(s3));
            Console.WriteLine(s3.);

            // Clone 

            //string s3 = "visuek C sharp Express";
            //var s4 = s3.Clone();
            // this Clone() methods to mack Copy parants data 

        }
        private string Substr(string input ,int start,int end)
        {
            var sentance = "";
            for (int i = start; i <= end; i++)
            {
                sentance += input[i];
            }
            return sentance;
        }
    }
}

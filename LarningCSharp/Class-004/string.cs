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




            string s3 = "visuek C sharp Express";




            Console.WriteLine(s3.Substring(7));
            Console.WriteLine(s3.Substring(7,5));


        }
    }
}

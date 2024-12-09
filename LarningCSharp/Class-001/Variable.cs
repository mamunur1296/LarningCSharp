namespace LarningCSharp.Class_001
{
    public class Integer
    {
        public sbyte sByte { get; set; } = 100;
        public int iInt { get; set; } = 50;
    }
    public class Variable
    {
        string name;
        int number = 0; 
        bool isActiove = false;
        

        sbyte sByte = 100; // 8 bit : 1 byte  : Range: -128 to 127
        byte sByte2 = 50; // 8 bit ; 1 byte  : Range: 0 to 255
        short sShort = 0;// 16 bit ; 2 byte  : Range: -32,768 to 32,767
        ushort sUShort = 0; // 16 bit ; 2 byte  : Range: 0 to 65,535
        int sInt = 0; // 32 bit ; 4 byte  : Range: -2,147,483,648 to 2,147,483,647
        uint sUInt = 0; // 32 bit ; 4 byte  : Range: 0 to 4,294,967,295
        long sLong = 0; // 68 bit ; 8 byte  : Range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        ulong sULong = 0;
        float fFloat = 0.0f;
        double fDouble = 0.0;
        decimal dedecimal = 0;// 128 bit ; 16 byte  : Range: 0 to 4,294,967,295
        public char a = 'a';

        public void Main()
        {
            Integer integer = new Integer();
            //Console.WriteLine("sByte: " + integer.sByte);
            Console.WriteLine($"sByte: { integer.iInt}");
            Console.WriteLine("sByte: " + sByte);
            Console.WriteLine("sByte: {0} ", sByte2);

        }
    }
}

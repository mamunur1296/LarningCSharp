
using static LarningCSharp.Class_007.ArrayHelpers;

namespace LarningCSharp.Class_007
{
    public class Test
    {
        public void Main()
        {
            var ArrayHelper = new Helpers();
            int[] numbers = { 10, 20, 30, 40 };
            numbers = ArrayHelper.AddElement(numbers,50);
            ArrayHelper.Traverse(numbers);
        }
    }
}

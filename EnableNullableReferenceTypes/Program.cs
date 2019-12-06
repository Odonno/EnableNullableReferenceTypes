using System;

namespace EnableNullableReferenceTypes
{
    public class Result
    {
        public int? Value { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var result = new Result();
            string str = result.Value.ToString();

            Console.WriteLine(str);
        }
    }
}

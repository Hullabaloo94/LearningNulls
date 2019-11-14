using System;

namespace LearningNulls
{
    class Program
    {
        static void Main(string[] args)
        {
            // Null Coalescing is the ability of checking if your variable is null and doing something if that is the case. In the below example, we check if s is null and because it is we set its value to "default".
            String s = null;//"hello";
            String s2 = s ?? "default";
            Console.WriteLine(s2);

            // Usually Null Coalescing doesn't allow value typed variables such as int because it cannot be null. However, you can allow null by doing 'int?' as the datatype. 
            int? n = null;
            int n2 = n ?? 2;
            Console.WriteLine(n2);

            // Null Coalescing is a great way to deal with null if a default value is required.
        }
    }
}

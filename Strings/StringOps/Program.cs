namespace StringOps
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "The quick brown fox jumps over the lazy dog";
            string str2 = "This is a string";
            string str3 = "THIS is a STRING";
            string[] strs = {"one", "two", "three", "four"};
            string outstr;
            
            // strings are also objects, so their properties can be accessed
            // length if a string
            Console.WriteLine(str1.Length);

            // access individual characters
            Console.WriteLine(str1[14]);

            // iterate over string
            foreach (char ch in str1)
            {
                Console.WriteLine(ch);
                if (ch == 'b')
                {
                    Console.WriteLine();
                    break;
                }
            }

            // string concatenation
            outstr = string.Concat(strs);
            Console.WriteLine(outstr);

            // joing strings with join
            outstr = String.Join('.', strs);
            Console.WriteLine(outstr);
            outstr = String.Join('---', strs);
            Console.WriteLine(outstr);

            // string comparison
            // compare will perform an ordinal comparison and return:
            // < 0 : first string comes before second in sort order
            // 0 : first and second strings are same position in sort order
            // > 0 : first string comes after the second in sort order
            int result  = String.Compare(str2, "This is a string"); // used for sorting strings

            // equals returns just a regular boolean
            bool isEqual = str2.Equals(str3);
            Console.WriteLine(isEqual);
        }
    }
}
using System;

namespace GithubTest {
    class Program {
        static void Main(string[] args) {
            int? val = 3;  // int? is shorthand for Nullable<int>
            string output;
            output = val switch
            {
                1 => "A",
                2 => "B",
                3 => (val * val).ToString(),
                null => "X",
                _ => "default case"
            };

            Console.WriteLine($"output from switch: {output}");
            Console.WriteLine($"output from switch: {output}");
        }
    }
}

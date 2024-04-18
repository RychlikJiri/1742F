using System.IO;
using System.Collections;

namespace codeforce
{
    class MyClass
    {
        static void Main(string[] args)
        {
            int repeats = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < repeats; i++)
                problem();
        }

        static void problem()
        {

            int[] s = new int[26];
            int[] t = new int[26];

            s[1]++;
            t[1]++;
            int repeats = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < repeats; i++)
            {
                string[] parameters = Console.ReadLine().Split();
                int[] chchchanges;
                if (Convert.ToInt16(parameters[0]) == 0)
                    chchchanges = s;
                else chchchanges = t;

            }
        }
    }
};

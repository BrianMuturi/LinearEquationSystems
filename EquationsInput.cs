using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearEquationSystems
{
    static class EquationsInput
    {
        static private int[,] matrix;

        static public void Initialize(int n)
        {
            matrix = new int[n, n + 1];
        }

        static public void UserInterface(int n)
        {
            Initialize(n);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter {i + 1} equation: ");
                string input = Console.ReadLine();
                string tmp = input;

                for (int j = 0; j < n + 1; j++)
                {
                    if (input.Contains(" "))
                    {
                        tmp = input.Substring(0, input.IndexOf(" "));
                        int.TryParse(tmp, out matrix[i, j]);

                        input = input.Substring(tmp.Length + 1, input.Length - tmp.Length - 1);

                    }
                    else
                    {
                        int.TryParse(input, out matrix[i, j]);
                        break;
                    }
                }
            }

        }

        public static int[,] ReturnMatrix()
        {
            return matrix;
        }
    }
}

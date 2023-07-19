using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BaliseProgramming
{
    public static class Helper
    {
        
        public static List<List<int>> GetAllBitsOutcomes(int length)
        {
            List<List<int>> outcomes = new List<List<int>>();
            int[] coinArray = new int[length];

            GenerateOutcomes(outcomes, coinArray, 0);
            outcomes.Reverse(); 
            return outcomes;
        }


        private static void GenerateOutcomes(List<List<int>> outcomes, int[] coinArray, int index)
        {
            if (index == coinArray.Length)
            {
                // Add a copy of the current coinArray to outcomes
                outcomes.Add(new List<int>(coinArray));
                return;
            }
            // Set the current index to 0 (Head)
            coinArray[index] = 0;
            GenerateOutcomes(outcomes, coinArray, index + 1);

            // Set the current index to 1 (Tail)
            coinArray[index] = 1;
            GenerateOutcomes(outcomes, coinArray, index + 1);
        }


        public static string SetBit(string wordArray, int b, char reqOut)
        {
            char[] convertedArray = wordArray.ToCharArray();
            convertedArray[b] = reqOut;
            string updatedBinaryString = new string(convertedArray);
            return updatedBinaryString;
        }


        public static string IntListToString(List<int> list)
        {
            StringBuilder builder = new StringBuilder();
            foreach (int lst in list)
            {
                // Append each int to the StringBuilder overload.
                builder.Append(lst).Append("");
            }
            return builder.ToString();
        }



        public static string AddBinaryPolynomials(int[] polynomial1, int[] polynomial2)
        {
            
            if (polynomial1.Length > polynomial2.Length)
            {
                string poly2 = ToString(polynomial2);
                poly2 = poly2.PadLeft(polynomial1.Length, '0');
                polynomial2 = ToList(poly2);
            } else if (polynomial1.Length < polynomial2.Length) {
                string poly1 = ToString(polynomial1);
                poly1 = poly1.PadLeft(polynomial2.Length, '0');
                polynomial1 = ToList(poly1);
            }

            int[] solution = new int[polynomial1.Length]; 
            int rem = 0;
            Array.Reverse(polynomial1);
            Array.Reverse(polynomial2);
            for (int i = 0; i < polynomial1.Length; i++)
            {
                int add = polynomial1[i] + polynomial2[i];
                if ((rem + add) == 2)
                {
                    solution[i] = 0;
                    rem = 1;

                } else if ( rem + add == 1 || rem + add == 0)
                {
                    solution[i] = rem + add;
                    rem = 0;
                } else if (rem + add == 3)
                {
                    solution[i] = 1;
                    rem = 1;

                }
            }
            if (rem == 1) solution[polynomial1.Length -1] = 1;

                        
            Array.Reverse(solution);
            return ToString(solution);

        }



        // Perform polynomial multiplication
        public static int[] MultiplyPolynomials(int[] polyA, int[] polyB)
        {
            int degreeA = polyA.Length - 1;
            int degreeB = polyB.Length - 1;
            int degreeC = degreeA + degreeB;
            int[] result = new int[degreeC + 1];

            for (int i = 0; i <= degreeA; i++)
            {
                for (int j = 0; j <= degreeB; j++)
                {
                    int product = polyA[i] & polyB[j];
                    int currentIndex = i + j;
                    result[currentIndex] ^= product;
                }
            }
            //Array.Reverse(result);
            return result;
        }




        public static int[] ToList(string x)
        {
            int[] l = new int[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                l[i] = int.Parse(x[i].ToString());
            }
            return l;
        }

        public static string ToString(int[] x)
        {
            string str1 = "";
            for (int i = 0; i < x.Length; i++)
            {
                str1 += x[i].ToString();
            }
            return str1;
        }

        // This function calculate the binary polynomial division and returns the remainder 
        public static string DivisionRemainder(string dividend, string divisor)
        {
            int[] a = ToList(dividend);
            int[] b = ToList(divisor);
            string working = "";
            string res = "";

            while (b.Length <= a.Length && a.Length > 0)
            {
                if (a[0] == 1)
                {
                    Array.Copy(a, 1, a, 0, a.Length - 1);
                    Array.Resize(ref a, a.Length - 1);

                    for (int j = 0; j < b.Length - 1; j++)
                    {
                        a[j] ^= b[j + 1];
                    }

                    if (a.Length > 0)
                    {
                        working += ToString(a);
                        res += "1";
                    }
                }
                else
                {
                    Array.Copy(a, 1, a, 0, a.Length - 1);
                    Array.Resize(ref a, a.Length - 1);

                    working += ToString(a);
                    res += "0";
                }
            }

            //Console.WriteLine("Result is\t" + res);
            //Console.WriteLine("Remainder is\t" + ToString(a));
            return ToString(a);
        }




      

        public static string CalculateCheckBits(StringBuilder bit_n_to_85)
        {
            // Check if it's a long or a short telegram. Otherwise, raise error warning 
            bool isLong = false;
            if (bit_n_to_85.Length > 256) isLong = true;
            else if (bit_n_to_85.Length != 256) Console.WriteLine("Warning: Invalid Candidate Telegram Bit Length");
            int[] fx;
            int[] gx;
            if (isLong)
            {
                fx = new int[] { 1, 1, 0, 1, 1, 0, 1, 1, 1, 1, 1 };
                gx = new int[] { 1, 0, 1, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0, 1, 1, 0, 1, 0, 0, 1, 1, 1, 1, 0, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 1 };
            } else
            {
                fx = new int[] { 1, 0, 1, 1, 0, 1, 0, 1, 0, 1, 1 };
                gx = new int[] { 1, 0, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 1, 0, 0, 1, 0, 1, 1 };
            }
            int[] multiplyFxGx = MultiplyPolynomials(fx, gx);
            string remainder = DivisionRemainder(bit_n_to_85.ToString() ,ToString(multiplyFxGx));

            string result = AddBinaryPolynomials(ToList(remainder), gx);
            return result;   

        }

        public static string Permutation(string telegram)
        {
            string firstPart = "";
            string secondPart = "";

            for (int i = 0; i < telegram.Length; i++)
            {
                if (i % 2 == 0) firstPart += telegram.ElementAt(i);
                else secondPart += telegram.ElementAt(i);
            }
            string result = secondPart + firstPart;
            return result;

        }



        public static string ConvertBinaryToHex(string binary)
        {
            // Remove any whitespace characters from the binary string
            binary = binary.Replace(" ", "");

            // Pad the binary string with leading zeros if necessary
            int remainder = binary.Length % 4;
            if (remainder != 0)
            {
                binary = binary.PadRight(binary.Length + (4 - remainder), '0');
            }

            // Convert the binary string to hexadecimal
            string hex = "";
            for (int i = 0; i < binary.Length; i += 4)
            {
                string nibble = binary.Substring(i, 4);
                int decimalValue = Convert.ToInt32(nibble, 2);
                hex += decimalValue.ToString("X");
            }
            return hex;
        }


        public static byte[] ConvertHexToAscii(string hex)
        {
            // Ensure the hex string has an even length
            if (hex.Length % 2 != 0)
            {
                throw new ArgumentException("Invalid hex string length.");
            }

            byte[] asciiBytes = new byte[hex.Length / 2];

            for (int i = 0; i < hex.Length; i += 2)
            {
                string hexByte = hex.Substring(i, 2);
                byte asciiByte = Convert.ToByte(hexByte, 16);
                asciiBytes[i / 2] = asciiByte;
            }
            return asciiBytes;
        }



        public static void ProduceTlg(byte[] asciiBytes, string filePath)
        {
            char[] chars = new char[asciiBytes.Length];
            int c = 0;
            foreach (byte b in asciiBytes)
            {
                char asciiChar = Convert.ToChar(b);
                chars[c] = asciiChar;
                c++;
            }
            Encoding encoding = Encoding.GetEncoding("iso-8859-1");

            // Create a StreamWriter instance to write to the file
            using (StreamWriter writer = new(filePath, false, encoding))
            {
                writer.Write(chars);
            }
        }


    }
}

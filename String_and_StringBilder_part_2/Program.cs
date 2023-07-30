using System.Text;
using System.IO;
using System.Data.SqlTypes;

namespace String_and_StringBilder_part_2
{
    internal class Program
    {

        static void jobNumberOne(string originalString)
        {           
            Console.WriteLine("Введите подстроку");
            string substring = Console.ReadLine();
            string[] massString = originalString.Split(' ', '.' , ',', ',', '\n', '\t', '\0');
            for(int i = 0; i < massString.Length; i++)
            {
                if (massString[i].Contains(substring))
                {
                    Console.Write(massString[i]+", ");
                }
            }
            Console.WriteLine();
        }

        static void jobNumberTwo(string originalString)
        {
            Console.WriteLine("Введите колличество символов");
            int n = int.Parse(Console.ReadLine());
            string[] massString = originalString.Split(' ', '.', ',', '\n','\t', '\0');
            for (int i = 0; i < massString.Length; i++)
            {
                if (massString[i] != "" && massString[i].Length<=n)
                {
                    Console.Write(massString[i] + ", ");
                }
            }
            Console.WriteLine();
        }

        static void jobNumberThree(string originalString)
        {            
            string[] massString = originalString.Split(' ', '.', ',', '\n', '\t', '\0', '\r');
            for (int i = 0; i < massString.Length; i++)
            {
                if (massString[i] != "" && !char.IsLower(massString[i][0]))
                {
                    Console.Write(massString[i] + ", ");
                }
            }
            Console.WriteLine();
        }

        static void jobNumberFour(string originalString)
        {
            string[] massString = originalString.Split(' ', '.', ',', '\n', '\t', '\0', '\r');
            for (int i = 0; i < massString.Length; i++)
            {
                if (massString[i] != "")
                {
                    for(int j=0; j < massString[i].Length; j++)
                    {
                        if (char.IsDigit(massString[i][j]))
                        {
                            Console.Write(massString[i] + ", ");
                            break;
                        }
                    }                    
                }
            }
            Console.WriteLine();
        }

        static void jobNumberFive(string originalString)
        {
            Console.WriteLine("Введите символ");
            char subChar = char.Parse(Console.ReadLine()); 
            string[] massString = originalString.Split(' ', '\n', '\t', '\0', '\r');
            for (int i = 0; i < massString.Length; i++)
            {
                if(massString[i] != "")
                {
                    if (massString[i][massString[i].Length - 1] == '.' || massString[i][massString[i].Length - 1] == ',' || massString[i][massString[i].Length - 1] == ':')
                    {
                        if (massString[i][massString[i].Length - 2] != subChar) Console.Write(massString[i] + " ");
                    }
                    else if (massString[i][massString[i].Length - 1] != subChar) Console.Write(massString[i] + " ");                    
                }
            }
            Console.WriteLine();
        }

        static void jobNumberSix(string originalString)
        {
            Console.WriteLine("Введите символ");
            char subChar = char.Parse(Console.ReadLine());
            string[] massString = originalString.Split(' ', '\n', '\t', '\0', '\r');
            for (int i = 0; i < massString.Length; i++)
            {
                if (massString[i] != "")
                {
                    if (!massString[i].Contains(char.ToLower(subChar)) && !massString[i].Contains(char.ToUpper(subChar)))
                    {
                        Console.Write(massString[i] + " ");
                    }                    
                }
            }
            Console.WriteLine();
        }

        static void jobNumberSeven(string originalString)
        {
            string[] massString = originalString.Split(' ', '\n', '\t', '\0', '\r');
            for (int i = 0; i < massString.Length; i++)
            {
                if (massString[i] != "")
                {
                    if (massString[i].Length !=1)
                    {
                        Console.Write(massString[i] + " ");
                    }
                }
            }
            Console.WriteLine();
        }

        static void jobNumberEight(string originalString)
        {
            string[] massString = originalString.Split(' ', '\n', '\t', '\0', '\r');
            List<string> list = new List<string>();
            for(int i = 0;i < massString.Length; i++) {
                if (!EquelsStringInList(list, massString[i]))
                {
                    list.Add(massString[i]);
                    Console.Write(massString[i] + " ");
                }
            }
        }

        static bool EquelsStringInList(List<string> list, string massString)
        {
            foreach(string item in list)
            {
                if(EquelsString(item,massString)) return true;
            }
            return false;
        }

        static bool EquelsString(string listString, string massString)
        {
            if ( listString.Length== massString.Length )
            {
                for(int i = 0; i<massString.Length; i++)
                {
                    if (char.ToLower(listString[i]) != massString[i] && char.ToUpper(listString[i]) != massString[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }


        static void jobNumberNine(string originalString)
        {
            
        }

        static void jobNumberTen(string originalString)
        {
                   
        }

        static void jobNumberEleven(string originalString)
        {
            
           
        }

        static void jobNumberTwelve(string originalString)
        {
            
        }

        static void jobNumberThirteen(string originalString)
        {
            
        }

        static void jobNumberFourteen(string originalString)
        {
            
        }

        static void jobNumberFifteen(string originalString)
        {
           
        }

        static void jobNumberSixteen(string originalString)
        {
            
        }

        static void jobNumberSeventeen(string originalString)
        {
            
        }

        static void jobNumberEighteen(string originalString)
        {
            
        }
        static void jobNumberNineteen(string originalString)
        {
           
        }
        static void jobNumberTwenty(string originalString)
        {
           

        }

       


        static void Main(string[] args)
        {
            string originalString;
            try
            {
                using (StreamReader streamReader = new StreamReader("text.txt"))
                {
                    originalString = streamReader.ReadToEnd();
                }
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Исходный текст: \n" + originalString);
                    Console.Write("Введите номер задания: ");
                    int jobNumber = int.Parse(Console.ReadLine());
                    switch (jobNumber)
                    {
                        case 1:
                            jobNumberOne(originalString);
                            break;
                        case 2:
                            jobNumberTwo(originalString);
                            break;
                        case 3:
                            jobNumberThree(originalString);
                            break;
                        case 4:
                            jobNumberFour(originalString);
                            break;
                        case 5:
                            jobNumberFive(originalString);
                            break;
                        case 6:
                            jobNumberSix(originalString);
                            break;
                        case 7:
                            jobNumberSeven(originalString);
                            break;
                        case 8:
                            jobNumberEight(originalString);
                            break;
                        case 9:
                            jobNumberNine(originalString);
                            break;
                        case 10:
                            jobNumberTen(originalString);
                            break;
                        case 11:
                            jobNumberEleven(originalString);
                            break;
                        case 12:
                            jobNumberTwelve(originalString);
                            break;
                        case 13:
                            jobNumberThirteen(originalString);
                            break;
                        case 14:
                            jobNumberFourteen(originalString);
                            break;
                        case 15:
                            jobNumberFifteen(originalString);
                            break;
                        case 16:
                            jobNumberSixteen(originalString);
                            break;
                        case 17:
                            jobNumberSeventeen(originalString);
                            break;
                        case 18:
                            jobNumberEighteen(originalString);
                            break;
                        case 19:
                            jobNumberNineteen(originalString);
                            break;
                        case 20:
                            jobNumberTwenty(originalString);
                            break;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
           
            
        }
    }
}
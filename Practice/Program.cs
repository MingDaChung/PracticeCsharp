using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Practice
{
    class Program
    {
        static void Main()
        {
            //From w3resource Basic Excercises

            //Q16
            //Array result = {  };
            //string[] stringarray = new string[] { "apple", "banana", "orange", "x" };

            //Console.WriteLine(swap(stringArray[0]));
            //Console.WriteLine(swap(stringArray[1]));
            //Console.WriteLine(swap(stringArray[2]));
            //Console.WriteLine(swap(stringArray[3]));

            //static string swap (string input)
            //{
            //    return input.Length > 1
            //    ? input.Substring(input.Length - 1) + input.Substring(1, input.Length - 2) + input.Substring(0, 1) : input;
            //}

            //Q17
            //string result;
            //Console.WriteLine("Input a String : ");
            //result = Console.ReadLine();
            //Addword(result);
            //static string Addword(string input)
            //{
            //    if (input.Length > 1)
            //    {
            //        var word = input.Substring(0, 1);
            //        Console.WriteLine(word + input + word);
            //    }
            //    else
            //    {
            //        Console.WriteLine(input);
            //    }
            //    return input;
            //}

            //Q18
            //int num1 = 0, num2 = 0;
            //Console.WriteLine("Input First Number : ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input Second Number : ");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Check if one is negative and one is positive:");
            //Console.WriteLine((num1 < 0 && num2 > 0) || (num1 > 0 && num2 < 0));

            //if ((num1 < 0 && num2>0) || (num1>0 && num2<0)) {
            //    Console.WriteLine("Match");
            //}
            //else
            //{
            //    Console.WriteLine("Not Match");
            //}

            //Q19
            //int num1 = 0, num2 = 0;
            //Console.WriteLine("Input First Number : ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input Second Number : ");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //if (num1 == num2)
            //{
            //    Console.WriteLine("Triple The Ans : {0} ", 3 * num1);
            //}
            //else
            //{
            //    Console.WriteLine("Ans is : {0}", num1 * num2);
            //}

            //Q20
            //int num1 = 0, num2 = 0;
            //Console.WriteLine("Input First Number : ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input Second Number : ");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //if (num1>num2)
            //{
            //    Console.WriteLine("Ans : {0}",(num1 - num2) * 2);
            //}
            //else
            //{
            //    Console.WriteLine("Ans : {0}" , num2-num1);
            //}

            //Q21
            //int num1 = 0, num2 = 0;
            //Console.WriteLine("Input First Number : ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input Second Number : ");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(num1 + num2 == 20 || num1 == 20 || num2 == 20);

            //Q22
            //int num1 = 0, num2 = 0;
            //Console.WriteLine("Input First Number : ");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(Math.Abs(num1 - 100) <= 20 || Math.Abs(num1 - 200) <= 20);

            //Q23
            //string result= "";
            //Console.WriteLine("Input a string : ");
            //result = Console.ReadLine();

            //result = result.ToLower();

            //Console.WriteLine(result);

            //Q24
            //string result = "";
            //Console.WriteLine("Input a String : ");
            //result = Console.ReadLine();
            //string[] words = result.Split(new[] { " " }, StringSplitOptions.None);
            //string word = "";
            //int count = 0;

            //foreach(string s in words)
            //{
            //    if(s.Length > count)
            //    {
            //        word = s;
            //        count = s.Length;
            //    }
            //}
            //Console.WriteLine("The Longest word is : {0}",word);

            //Q25
            //for(int i=1; i < 100; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine("Odd : {0}",i);
            //    }
            //}

            //Q26
            //int counter = 0, sum = 0, num = 2;

            //while(counter < 500)
            //{
            //    if (isPrime(num))
            //    {
            //        sum += num;
            //        counter++;
            //        Console.WriteLine(num);
            //        Console.WriteLine("Counter : {0}", counter);
            //    }
            //    num++;
            //}
            //Console.WriteLine("Sum : {0}",sum);

            //static bool isPrime(int num)
            //{
            //    int x = (int)Math.Floor(Math.Sqrt(num));
            //    if (num == 1) return false;
            //    if (num == 2) return true;

            //    for (int i = 2; i <= x; ++i)
            //    {
            //        if (num % i == 0) return false;
            //    }

            //    return true;
            //}

            //Q27
            //int num = 0, sum=0;
            //Console.WriteLine("Input a Number : ");
            //num = Convert.ToInt32(Console.ReadLine());

            //while(num != 0)
            //{
            //    sum += num % 10;
            //    num /= 10;
            //}

            //Console.WriteLine("Ans : {0}", sum);

            //Q28
            //string input = "Display the pattern like pyramid using the alphabet.";
            //string reverse = "";
            //List<string> wordList = new List<string>();//unnecessary(I think)

            //string[] words = input.Split(new[] {" "}, StringSplitOptions.None);

            //for (int i = words.Length-1; i>=0; i--) {
            //    reverse += words[i] + " ";
            //}

            //Console.WriteLine("Test : {0}", reverse);//string reverse can do reverse

            //wordList.Add(reverse);//I think this part below is unnecessary

            //foreach (String s in wordList)
            //{
            //    Console.WriteLine("Reverse : {0}", s);
            //}

            //Q29
            //Skip Maybe do it later

            //Q30
            //string hexa = "";
            //Console.WriteLine("Input Hexadecimal : ");
            //hexa = Console.ReadLine();
            //int dec = Convert.ToInt32(hexa,16);

            //Console.WriteLine("Hexa : {0}",hexa);
            //Console.WriteLine("decimal : {0}", dec);

            //Q31
            //int[] Array1 = { 1, 2, 3, 4 };
            //int[] Array2 = { 1, 2, 3, 4 };

            //Console.WriteLine("Array1: [{0}]", string.Join(", ", Array1));
            //Console.WriteLine("Array2: [{0}]", string.Join(", ", Array2));

            //for (int i =0;i<Array1.Length ;i++)
            //{
            //    Console.WriteLine(Array1[i]*Array2[i]);
            //}

            //Q32
            //string str = "The quick brown fox jumps over the lazy dog.";
            //if (str.Length > 4)
            //{
            //    Console.WriteLine(str.Length);
            //    Console.WriteLine(str.Length < 4 ? str + str + str : str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4));
            //}

            //Q33
            //int num = 0;
            //Console.WriteLine("input a number : ");
            //num = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(num % 3 == 0 || num % 5 == 0);

            //Q34
            //string input = "Hello how are you.";
            //Console.WriteLine(input[5]);
            //Console.WriteLine((input.Length<6 && input.Equals("Hello"))||(input.StartsWith("Hello") && input[5] == ' '));

            //Q35
            //int num1 = 0, num2 = 0;
            //Console.WriteLine("First : ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Second : ");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(num1<100 && num2>200);

            //Q36
            //int num1 = 0, num2 = 0;
            //Console.WriteLine("First : ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Second : ");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(num1 > -10 && num1 < 10 && num2 > -10 && num2 < 10);

            //Q37
            //string input = "PHP Tutorial";
            //Console.WriteLine(input.Substring(1,2).Equals("HP") ? input.Remove(1,2) : input);

            //Q38
            //string input = "PHPHPHP Tutorial";
            //string output = "";

            //if (input.Length >= 1 && input[0] == 'P')
            //{
            //    output += input[0];
            //}
            //if (input.Length >= 2 && input[1] == 'H')
            //{
            //    output += input[1];
            //}
            //Console.WriteLine(output);

            //Q39
            //int num1 = 0, num2 = 0 , num3 = 0;
            //Console.WriteLine("First : ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Second : ");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Third : ");
            //num3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Largest : " + Math.Max(num1, Math.Max(num2, num3)));
            //Console.WriteLine("Smallest : " + Math.Min(num1, Math.Min(num2, num3)));

            //Q40
            //int num1 = 0, num2 = 0;
            //Console.WriteLine("First : ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Second : ");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //int check = 20;
            //var val1 = Math.Abs(num1 - check);
            //var val2 = Math.Abs(num2 - check);

            //Console.WriteLine("{0} is more near to {1}", num1 == num2 ? 0 : (val1 < val2) ? num1 : num2,check);

            //Q41
            //string input = "";
            //Console.WriteLine("Input a String : ");
            //input = Console.ReadLine();
            //char check = 'w';
            //var counter = input.Count(s => s == check);

            //Console.WriteLine("There are not more than 3 {0} in this string : {1}" ,check,counter <= 3);

            //Q42

            //Console.WriteLine("Input a string less than 4 words : ");
            //string input = Console.ReadLine();
            //if (input.Length <= 4)
            //{
            //    Console.WriteLine(input.ToUpper());
            //}
            //else
            //{
            //    Console.WriteLine("Need less than 4 words ~ ");
            //}

            //Q43
            //Don't know why .... 
            //ww "False" www "False" wwww"True"
            //Console.WriteLine("Input a String : ");
            //string input = Console.ReadLine();

            //Console.WriteLine(check(input));

            //static bool check(string str)
            //{
            //    var counter = 0;
            //    for (int i = 0; i < str.Length - 1; i++)
            //    {
            //        if (str[i].Equals('w')) counter++;
            //        if(str.Substring(i,2).Equals("ww") && counter > 2)
            //        {
            //            return true;
            //        }
            //    }
            //    return false;
            //}

            //Q44
            //Console.WriteLine("Input a String : ");
            //string input = Console.ReadLine();
            //var output = string.Empty;

            //for(int i = 0; i < input.Length; i += 2)
            //{
            //    output += input[i];
            //}
            //Console.WriteLine(output);

            //Q45
            //int[] number = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
            //Console.WriteLine("Input a number : ");
            //int check = Convert.ToInt32(Console.ReadLine());
            //int counter = 0;

            //for (int i = 0; i < number.Length; i++)//Can use Lambda .Count write below
            //{
            //    if (number[i] == check) counter++;
            //}
            //Console.WriteLine("Number of {0} present in the said array : {1}", check, counter);
            //Console.WriteLine("Number of {0} present in the said array : {1}",check,number.Count(x => x==check));

            //Q46
            //int[] number = {1,2,3,4,5,245,532,2,1,3,5,5,2,3,3 };
            //Console.WriteLine("Input a number");
            //int check = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(check == number[0] || check == number[number.Length-1]);

            //Q47
            //int[] number = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            //int sum = 0;

            //for(int i = 0; i < number.Length; i++)
            //{
            //    sum += number[i];
            //}
            //Console.WriteLine("Ans : {0}", sum);

            //Q48
            //int[] number = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            //Console.WriteLine(number[0] == number[number.Length - 1]);

            //Q49
            //int[] number1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            //int[] number2 = { 2, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };

            //Console.WriteLine(number1[0] == number2[0] || number1[number1.Length - 1] == number2[number2.Length - 1]);

            //Q50
            //int[] number = { 1, 2, 8 };
            //Console.WriteLine("Array : [{0}] ", string.Join(", " ,number));

            //int tem = number[0];            
            //for(int i = 0; i < number.Length-1; i++)
            //{
            //    number[i] = number[i + 1];
            //}
            //number[number.Length-1] = tem;

            //Console.WriteLine("Array : [{0}] ", string.Join(", ", number));

            //Q51
            //int[] number = { 1, 2, 5, 7, 8 };
            //int bignum = 0;

            //for(int i = 0; i < number.Length ; i++)
            //{
            //    if (number[i] > bignum) bignum = number[i];
            //}
            //Console.WriteLine("Highest value between first and last values of the said array: {0}", bignum);

            //Q52
            //int[] num1 = { 1, 2, 5 };
            //int[] num2 = { 0, 3, 8 };
            //int[] num3 = { -1, 0, 2 };
            //int[] result = { num1[1], num2[1], num3[1] };

            //Console.WriteLine("Array : [{0}] ", string.Join(", ", result));

            //Q53
            //int[] number = { 2, 4, 7, 8, 6 };

            //Console.WriteLine("Check if an array contains an odd number? : {0}", check(number));

            //static bool check(int[] num)
            //{
            //    for (int i = 0; i < num.Length; i++)
            //    {
            //        if (num[i] % 2 != 0) return true;
            //    }
            //    return false;
            //}

            //Q54
            //Console.WriteLine("Input a year : ");
            //int year = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("It's {0} century", century(year));
            //static int century(int year)
            //{
            //    return year / 100 + ((year % 100 == 0) ? 0 : 1);
            //}

            //Q55
            //int[] number1 = { 6, 1, 12, 3, 1, 4 };
            //int[] number2 = { 2, 4, 2, 6, 9, 3 };
            //int[] number3 = { 0, -1, -1, -2 };
            //Console.WriteLine("Ans : {0}", check(number1));
            //Console.WriteLine("Ans : {0}", check(number2));
            //Console.WriteLine("Ans : {0}", check(number3));

            //static int check(int[] num)
            //{
            //    var ans = 0;
            //    for(int i = 0; i < num.Length-1; i++)
            //    {
            //        if (ans < num[i] * num[i + 1]) ans = num[i] * num[i + 1];
            //    }
            //    return ans;
            //}

            //Q56
            //string input = "aaaa";
            //Console.WriteLine("Given string {0} is a palindrome : {1}" ,input,check(input));

            //static bool check(string str)
            //{
            //    for(int i = 0; i < str.Length-1; i++)
            //    {
            //        if (str.Substring(i, 1) != str.Substring(i + 1, 1)) return false;
            //    }
            //    return true;
            //}

            //Q57
            //I think it's the same question to Q55,the diffrence is Q57 use Math.Max. Skip

            //Q58
            //int[] number = { 1, 3, 4, 7, 9 };
            //Console.WriteLine("{0} is/are not in this Array.", check(number));

            //static int check(int[] num)
            //{   
            //    //Misunderstand the question,I thought I should return string
            //    //string result = "";
            //    //for(int i = 1; i <= 9; i++)
            //    //{
            //    //    for(int j=0;j<num.Length-1; j++)
            //    //    {
            //    //        if (i != num[j]) result += num[j];
            //    //    }
            //    //}
            //    //return result;
            //    Array.Sort(num);
            //    int counter = 0;
            //    for (int i = 0; i < num.Length - 1; i++)
            //    {
            //        counter += num[i + 1] - num[i] - 1;
            //    }
            //    return counter;
            //}

            //Q59
            //int[] number1 = { 1, 3, 5, 6, 9 };
            //int[] number2 = { 0, 10 };
            //int[] number3 = { 1, 3, 1, 3 };

            //Console.WriteLine(check(number1));
            //Console.WriteLine(check(number2));
            //Console.WriteLine(check(number3));

            ////Misunderstand the question.
            ////for(int i =0; i < number.Length - 1; i++)
            ////{
            ////    for(int j = 0; j < number.Length - 1; j++)
            ////    {
            ////        if(number[i]>number[j])
            ////        {
            ////            int temp = number[i];
            ////            number[i] = number[j];
            ////            number[j] = temp;
            ////        }
            ////    }
            ////}
            ////for(int i = 0; i < number.Length - 1; i++)
            ////{
            ////    Console.WriteLine(number[i]);
            ////}

            //static bool check(int[] num)
            //{
            //    int checkpoint = 0;
            //    for (int i = 0; i < num.Length - 1; i++)
            //    {
            //        if (num[i] >= num[i + 1]) checkpoint++;
            //        if (i + 2 < num.Length && num[i] >= num[i + 2]) checkpoint++;
            //    }
            //    return checkpoint <= 2;
            //}

            //Q60
            //This question is DOPE!!!  Need more Practice.
            //int[][] number = {
            //    new int[]{0, 2, 3, 2},
            //    new int[]{0, 6, 0, 1},
            //    new int[]{4, 0, 3, 0}
            //};
            //Console.WriteLine(check(number));

            //static int check(int[][] num) {
            //    int counter = 0;
            //    for(int i =0; i < num[0].Length; i++)
            //    {
            //        for(int j = 0;j<num.Length && num[j][i] > 0; j++)
            //        {
            //            counter += num[j][i];
            //        }
            //    }
            //    return counter;
            //}

            //Q61
            //.OrderBy遞增排列
            //int[] x = check(new int[] { -5, 236, 120, 70, -5, -5, 698, 280 });
            //foreach (var item in x)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //static int[] check(int[] num)
            //{
            //    int[] arr = num.Where(x => x != -5).OrderBy(x => x).ToArray();
            //    //return arr;
            //    int counter = 0;
            //    return num.Select(x => x >= 0 ? arr[counter++] : -5).ToArray();
            //}

            //Q62
            //So Hard....
            //Console.WriteLine(check("p(rq)st"));
            //Console.WriteLine(check("(p(rq)st)"));
            //Console.WriteLine(check("ab(cd(ef)gh)ij"));

            //static string check(string str)
            //{
            //    int lid = str.LastIndexOf('(');
            //    if (lid == -1)
            //    {
            //        return str;
            //    }
            //    else
            //    {
            //        int rid = str.IndexOf(')', lid);
            //        return check(str.Substring(0, lid) 
            //                    + new string(str.Substring(lid + 1, rid - lid - 1).Reverse().ToArray())
            //                    + str.Substring(rid + 1));
            //    }
            //}

            //Q63
            //Solution have .Contains or foreach()
            //int[] number = { 1, 3, 4, 5, 6, 1, 6, 4 };
            //Console.WriteLine("Input a number : ");
            //int input = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("There have {0} in this Array : {1}", input, check(number, input));

            //static bool check(int[] num,int input)
            //{
            //    //return num.Contains(input);
            //    foreach(int item in num)
            //    {
            //        if (item == input) return true;
            //    }
            //    return false;
            //}

            //Q64
            //I cheat because I think it's useless
            //string file_path;
            //file_path = "c:/csharp/ex/test.cpp";
            //Console.WriteLine(test(file_path));
            //file_path = "c:/movies/abc.mp4";
            //Console.WriteLine(test(file_path));
            //file_path = "test.txt";
            //Console.WriteLine(test(file_path));

            //static string test(string file_path)
            //{
            //    return file_path.Split('/').Last();
            //}

            //Q65
            //int[] number =new int[] { 1, 2, 3, 4, 5 };
            //Array.ForEach(check(number), Console.WriteLine);

            //static int[] check(int[] num)
            //{
            //    for (int i = 0; i < num.Length; i++)
            //    {
            //        num[i] = num[i] * num.Length;
            //    }
            //    return num;
            //}

            //Q66
            //string num1 = "20", num2 = "30";
            //Console.WriteLine("Which ine is bigger {0} or {1} : {2}", num1, num2, check(num1, num2));
            //static string check(string num1, string num2)
            //{
            //    return Int32.Parse(num1) > Int32.Parse(num2) ? num1 : num2;
            //}

            //Q67
            //string str1 = "PHP";
            //string str2 = "JAVASCRIPT";
            //Console.WriteLine(check(str));
            //Console.WriteLine(check(str2));

            //static string check(string str)
            //{
            //    return str.Replace("P", "9").Replace("T", "0").Replace("S", "1").Replace("H", "6").Replace("A", "8");
            //}

            //Q68
            //Use .Count or .Split
            ////string str = "#hello";
            ////var count = str.Count(x => x == '#');
            ////Console.WriteLine(count);
            //Console.WriteLine(check("PHP Exercises", 'E', 'e'));

            //static int check(string str , char w1,char w2)
            //{
            //    return str.Split(w1, w2).Length - 1;
            //}

            //Q69
            //.ToLower and .ToUpper are change all char to Lower or Upper 
            //string str1 = "AAAAA";
            //string str2 = "aaaaa";
            //string str3 = "JavaScript";
            //Console.WriteLine(check(str1));
            //Console.WriteLine(check(str2));
            //Console.WriteLine(check(str3));

            //static bool check(string str)
            //{
            //    return str == str.ToLower() | str == str.ToUpper();
            //}

            //Q70
            //string str1 = "PHP";
            //string str2 = "Python";
            //string str3 = "Javascript";

            //Console.WriteLine(check(str1));
            //Console.WriteLine(check(str2));
            //Console.WriteLine(check(str3));

            //static string check(string str)
            //{
            //    return str.Substring(1, str.Length - 2);
            //}

            //Q71
            //string str1 = "PHHHHHHP";
            //string str2 = "PHP";
            //string str3 = "PPPHHHHHHP";

            //Console.WriteLine(check(str1));
            //Console.WriteLine(check(str2));
            //Console.WriteLine(check(str3));

            //static bool check(string str)
            //{
            //    for (int i = 0; i < str.Length - 1; i++)
            //    {
            //        if (str[i] == str[i + 1])
            //        {
            //            return true;
            //            break;
            //        }
            //    }
            //    return false;
            //}

            //Q72
            //int[] num1 = { 1, 2, 3, 5, 4, 2, 3, 4 };
            //int[] num2 = { 2, 4, 2, 6, 4, 8 };


            //Console.WriteLine(check(num1));
            //Console.WriteLine(check(num2));

            //static bool check(int[] num)
            //{
            //    int sum = 0;
            //    for (int i = 0; i < num.Length; i++)
            //    {
            //        //Console.WriteLine("{0} + {1} = " , sum , num[i]);
            //        sum = sum + num[i];
            //        //Console.WriteLine(sum);
            //    }
            //    if (sum % (num.Length) == 0)
            //    {
            //        return true;
            //    }
            //    return false;
            //}

            //Q73
            //string str1 = "PHP";
            //string str2 = "python";
            //string str3 = "javascript";

            //Console.WriteLine(check(str1));
            //Console.WriteLine(check(str2));
            //Console.WriteLine(check(str3));

            //static string check(string str)
            //{
            //    return new string(str.OrderBy(x => x).ToArray());
            //}

            //Q74
            //string str1 = "PHP";
            //string str2 = "python";
            //string str3 = "javascript";

            //Console.WriteLine(check(str1));
            //Console.WriteLine(check(str2));
            //Console.WriteLine(check(str3));

            //static string check(string str)
            //{
            //    string checkpoint = "";
            //    if(str.Length%2 == 0)
            //    {
            //        return checkpoint = "even";
            //    }
            //    return checkpoint = "odd";
            //}

            //Q75
            //Console.WriteLine("Input a positive number : ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(check(num));

            //static int check(int num)
            //{
            //    int ans = 0;
            //    for(int i=0; i <= num; i++) {
            //        ans = (2*i)-1;
            //    }
            //    return ans;
            //}

            //Q76

            //char cha1 = '1';
            //char cha2 = 'A';
            //char cha3 = 'a';
            //char cha4 = '#';

            //Console.WriteLine("ASCII of {0} is : {1}", cha1, check(cha1));
            //Console.WriteLine("ASCII of {0} is : {1}", cha2, check(cha2));
            //Console.WriteLine("ASCII of {0} is : {1}", cha3, check(cha3));
            //Console.WriteLine("ASCII of {0} is : {1}", cha4, check(cha4));

            //static int check(char cha)
            //{
            //    return (int)cha;
            //}

            //Q77
            //Can use .EndWith()
            //string str1 = "Exercise";
            //string str2 = "Exercises";
            //string str3 = "Book";
            //string str4 = "Books";

            //Console.WriteLine("Is {0} is plural : {1}", str1, check(str1));
            //Console.WriteLine("Is {0} is plural : {1}", str2, check(str2));
            //Console.WriteLine("Is {0} is plural : {1}", str3, check(str3));
            //Console.WriteLine("Is {0} is plural : {1}", str4, check(str4));

            //static bool check(string str)
            //{
            //    //if (str.Substring(str.Length - 1) == "s")
            //    //{
            //    //    return true;
            //    //}

            //    //return false;

            //    return str.EndsWith("s");
            //}

            //Q78
            //int[] num1 = { 1, 2, 3 };
            //int[] num2 = { -2, 0, 3, 4 };

            //Console.WriteLine("Ans : {0}", check(num1));
            //Console.WriteLine("Ans : {0}", check(num2));

            //static int check(int[] num)
            //{
            //    return num.Sum(x => x * x);
            //}

            //Q79
            //int test1 = 112;
            //string test1a = inttostr(test1);
            //string test2 = "50";
            //int test2a = strtoint(test2);

            //Console.WriteLine("{0}'s type is {1} => {2}'s type is {3}", test1, test1.GetType(), test1a, test1a.GetType());
            //Console.WriteLine("{0}'s type is {1} => {2}'s type is {3}", test2, test2.GetType(), test2a, test2a.GetType());

            //static int strtoint(string str)
            //{
            //    return int.Parse(str);
            //}

            //static string inttostr(int num)
            //{
            //    return num.ToString();
            //}

            //Q80

            //object[] test = new object[5];
            //test[0] = 25;
            //test[1] = "Anna";
            //test[2] = false;
            //test[3] = DateTime.Now;
            //test[4] = 199.12;

            //for(int i = 0; i < test.Length ; i++)
            //{
            //    Console.WriteLine("Value : {0} , Type : {1}", test[i], test[i].GetType());
            //}

            //Console.WriteLine("\n\n");
            //string[] testtostring = tostring(test);

            //for(int i = 0; i < testtostring.Length; i++)
            //{
            //    Console.WriteLine("Value : {0} , Type : {1}", testtostring[i], testtostring[i].GetType());
            //}

            //static string[] tostring(object[] obj)
            //{
            //    return Array.ConvertAll(obj , x => x.ToString());
            //}

            //Q81
            //Console.WriteLine("Input a number : ");
            //int test = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("十位數大於個位數 : {0}", check(test));

            //static bool check(int num)
            //{
            //    return (num / 10) >= num % 10;
            //}

            //Q82
            string str1 = "Py@th12on";
            string str2 = "Python 3.0";
            string str3 = "2^sdfds*^*^jlljdslfnoswje34u230sdfds984";

            Console.WriteLine("Orginal : {0}\nChanged : {1}", str1, check(str1));
            Console.WriteLine("Orginal : {0}\nChanged : {1}", str2, check(str2));
            Console.WriteLine("Orginal : {0}\nChanged : {1}", str3, check(str3));

            static string check(string str)
            {
                return Regex.Replace(str, @"[^a-zA-Z]", "");
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. Two Sum  (Y)
            //Given an array of integers, return indices of the two numbers such that they add up to a specific target.
            //You may assume that each input would have exactly one solution.
            //Example:
            //Given nums = [2, 7, 11, 15], target = 9,
            //Because nums[0] + nums[1] = 2 + 7 = 9,
            //return [0, 1].
            //int[] nums = new int[] { 3, 2, 5 };
            //int target = 6;
            //for (int i = 0; i < TwoSum(nums, target).Length; i++)
            //{
            //    Console.WriteLine(TwoSum(nums, target)[i]);
            //}
            //Console.ReadKey();

            #endregion

            #region 6. ZigZag Conversion (N)
            //The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

            //P   A   H   N
            //A P L S I I G
            //Y   I   R
            //And then read line by line: "PAHNAPLSIIGYIR"
            //Write the code that will take a string and make this conversion given a number of rows:

            //string convert(string text, int nRows);
            //convert("PAYPALISHIRING", 3) should return "PAHNAPLSIIGYIR".
            //string input = "ABCDE";
            //int nRows = 4;
            //Console.WriteLine(Convert(input, nRows));
            //Console.ReadKey();
            #endregion

            #region 7. Reverse Integer (Y)            //重点要考虑返回值overload
            //Reverse digits of an integer.

            //Example1: x = 123, return 321
            //Example2: x = -123, return -321
            //int x = 0;
            //Console.WriteLine(Reverse(x));
            //Console.ReadKey();


            #endregion

            #region 8. String to Integer (atoi)


            #endregion

            #region 9. Palindrome Number   //？需要更好的解法wiouth extra space!!!
            //Determine whether an integer is a palindrome.Do this without extra space.
            //int num = -2147447412;
            //Console.WriteLine(IsPalindrome(num));
            //Console.ReadKey();
            #endregion

            #region 13. Roman to Integer  ？
            //Given a roman numeral, convert it to an integer.Input is guaranteed to be within the range from 1 to 3999.
            //罗马数字共有七个，即I(1)，V(5)，X(10)，L(50)，C(100)，D(500)，M(1000)。按照下面的规则可以表示任意正整数。 

            //重复数次：一个罗马数字重复几次，就表示这个数的几倍。 
            //右加左减：在一个较大的罗马数字的右边记上一个较小的罗马数字，表示大数字加小数字。在一个较大的数字的左边记上一个较小的罗马数字，表示大数字减小数字。但是，左减不能跨越一个位数。比如，99不可以用IC表示，而是用XCIX表示。此外，左减数字不能超过一位，比如8写成VIII，而非IIX。同理，右加数字不能超过三位，比如十四写成XIV，而非XIIII。 
            //string romanNum = "IV";
            //Console.WriteLine(RomanToInt(romanNum));

            #endregion

            #region 14. Longest Common Prefix (Y)
            //Write a function to find the longest common prefix string amongst an array of strings.
            //string[] strs = {};
            //Console.WriteLine("The longest Common Prefix is {0}.", LongestCommonPrefix1(strs));
            //Console.ReadKey();

            //string sss = "abcd";
            //Console.WriteLine(sss.Length);
            //Console.WriteLine(sss.Substring(0,sss.Length));
            //Console.ReadKey();


            #endregion

            #region 20. Valid Parentheses
            //Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
            //The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.
            string sss = "[((a))][b]";

            Console.WriteLine("The string is {0}.",IsValid(sss));
            Console.ReadKey();

            #endregion


        }

        public static bool IsValid(string sss)
        {
           
            #region 第一种情况
            int[] indexOfLS = new int[sss.Length];
            int[] indexOfRS = new int[sss.Length];
            int[] indexOfLM = new int[sss.Length];
            int[] indexOfRM = new int[sss.Length];
            int[] indexOfLL = new int[sss.Length];
            int[] indexOfRL = new int[sss.Length];
            int nLS = 0;
            int nRS = 0;
            int nLM = 0;
            int nRM = 0;
            int nLL = 0;
            int nRL = 0;
            for (int i = 0; i < sss.Length; i++)
            {
                switch (sss[i])
                {
                    case '(':
                        indexOfLS[nLS] = i;
                        nLS++;
                        break;
                    case ')':
                        indexOfRS[nRS] = i;
                        nRS++;
                        break;
                    case '[':
                        indexOfLM[nLM] = i;
                        nLM++;
                        break;
                    case ']':
                        indexOfRM[nRM] = i;
                        nRM++;
                        break;
                    case '{':
                        indexOfLL[nLL] = i;
                        nLL++;
                        break;
                    case '}':
                        indexOfRL[nRL] = i;
                        nRL++;
                        break;
                    default:
                        break;
                }
            }

            if (nLS != nRS || nLM != nRM || nLL != nRL)                       //左右括号数量不同，false
            {
                return false;
            }
            else
            {
                for (int i = 0; i < indexOfLS.Length && i< indexOfRS.Length; i++)                   //左(括号的index小于右括号的index
                {
                    if ((int)indexOfLS[i]>(int)indexOfRS[i])
                    {
                        return false;
                    }
                }
                for (int i = 0; i < indexOfLM.Length; i++)                   //左[括号的index小于右括号的index
                {
                    if (Convert.ToInt32(indexOfLM[i]) > Convert.ToInt32(indexOfRM[i]))
                    {
                        return false;
                    }
                }
                for (int i = 0; i < indexOfLL.Length; i++)                   //左{括号的index小于右括号的index
                {
                    if (Convert.ToInt32(indexOfLL[i]) > Convert.ToInt32(indexOfRL[i]))
                    {
                        return false;
                    }
                }
            }



            #endregion
            #region 第二种情况
            string[] smallSplit = new string[] { };
            string[] mediumSplit = new string[] { };
            string[] largeSplit = new string[] { };
            smallSplit = sss.Split(new char[] { '(', ')' });
            mediumSplit = sss.Split(new char[] { '[', ']' });
            largeSplit= sss.Split(new char[] { '{', '}' });
            if (smallSplit.Length>1)
            {
                foreach (string s in smallSplit)
                {
                    if (s.Contains('[') || s.Contains(']') || s.Contains('{') || s.Contains('}'))
                    {
                        return IsValid(s);                                                          //递归
                    }
                }
            }
            if (mediumSplit.Length>1)
            {
                foreach (string s in mediumSplit)
                {
                    if (s.Contains('(') || s.Contains(')') || s.Contains('{') || s.Contains('}'))
                    {
                        return IsValid(s);
                    }
                }
            }
            if (largeSplit.Length>1)
            {
                foreach (string s in largeSplit)
                {
                    if (s.Contains('(') || s.Contains(')') || s.Contains('[') || s.Contains(']'))
                    {
                        return IsValid(s);

                    }
                }
            }
            
            #endregion
            return true;
        }

            
        






        
        public static string LongestCommonPrefix1(string[] strs)
        {
            if (strs.Length==0)                                      //Have to consider empty array!!!
            {
                return "";
            }

            string longestPrefix = "";
            string shortestStr = strs[0];
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length<shortestStr.Length)
                {
                    shortestStr = strs[i];
                }
            }

            
            bool flag = false;
            for (int i = shortestStr.Length; i > 0; i--)
            {
                foreach (string str in strs)
                {

                    flag = false;
                    if (str.StartsWith(shortestStr.Substring(0,i)))
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                    
                }
                if (flag==true)
                {
                    longestPrefix = shortestStr.Substring(0, i);
                    break;
                }
                else
                {
                    continue;
                }
            }
            return longestPrefix;
        }

        //public static string LongestCommonPrefix2(string[] strs)                          //Low effiency!!!
        //{
        //    if (strs.Length==1)                                  //need to consider containing only one string
        //    {
        //        return strs[0];
        //    }

        //    int j = 0;                                          //all members are the same
        //    for (; j < strs.Length - 1; j++)
        //    {
        //        if (strs[j] != strs[j + 1])
        //        {
        //            break;
        //        }

        //    }
        //    if (j == strs.Length - 1)
        //    {
        //        return strs[0];
        //    }


        //    string prestr = "";                              //
        //    string longestPreStr = "";
        //    int maxLength = 0;
        //    bool flag = false;
        //    foreach (string str1 in strs)                   //get every string in the array
        //    {
        //        for (int i = 1; i <= str1.Length; i++)            //get every possible prefix for individual string
        //        {
        //            foreach (string str2 in strs)                //to match every string in the array
        //            {
        //                flag = false;
        //                if (str2.StartsWith(str1.Substring(0, i)) || str2 == str1.Substring(0, i))
        //                {
        //                    flag = true;
        //                }
        //                else
        //                {
        //                    break;
        //                }
        //            }
        //            if (flag == false)
        //            {
        //                prestr = str1.Substring(0, i - 1);                  //注意是i-1，不是i
        //                if (prestr.Length >= maxLength)
        //                {
        //                    maxLength = prestr.Length;
        //                    longestPreStr = prestr;
        //                }
        //                break;
        //            }

        //        }
        //    }
        //    return longestPreStr;


        //}

        //static int RomanToInt(string s)
        //{
        //    char[] arr = new char[] { };
        //    arr = s.ToCharArray();
        //    int indexI=Array.IndexOf(arr,'I');
        //    Array.
        //}

        public static bool IsPalindrome(int num)
        {
            if (num < 0)
            {
                return false;
            }
            else if (num < 10 && num >= 0)
            {
                return true;
            }
            else
            {

                string str = num.ToString();
                bool flag = true;
                for (int i = 0; i < str.Length / 2; i++)
                {
                    if (str[i] != str[str.Length - i - 1])
                    {
                        flag = false;
                        break;
                    }
                }
                return flag;
            }


        }

        public static int Reverse(int num)
        {
            char[] temp = new char[] { };
            if (num>=-9 && num<9)
            {
                return num;
            }
            else if (num>9)
            {
                temp=num.ToString().ToCharArray();
                Array.Reverse(temp);
                string str= new string(temp);
                try
                {
                    return Convert.ToInt32(str);
                }
                catch (Exception)
                {

                    return 0;
                }
                
            }
            else
            {
                temp = (-1*num).ToString().ToCharArray();
                Array.Reverse(temp);
                string str = new string(temp);
                try
                {
                    return Convert.ToInt32(str) * -1;
                }
                catch (Exception)
                {

                    return 0;
                }
                
            }
        }

        static public int[] TwoSum(int[] nums, int target)
        {
            int i = 0;
            for (; i < nums.Length - 1; i++)
            {
                int j = i + 1;
                for (; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { 0, 0 };

        }

        static public string ConvertStingToInt(string text, int nRows)
        {
            string result = "";
            int len = text.Length;
            if (nRows == 1)
            {
                result = text;
            }
            else if (nRows == 2)
            {
                for (int i = 0; i < len; i = i + 2)
                {
                    result += text[i];
                }
                for (int i = 1; i < len; i = i + 2)
                {
                    result += text[i];
                }
            }

            else if (nRows >= 3)
            {



                for (int j = 1; j <= nRows; j++)                                          //遍历rows
                {
                    if (j == 1)                                                               //first row
                    {
                        for (int i = 0; i < len; i = i + (2 * nRows - 2))
                        {
                            result += text[i];
                        }
                    }
                    if (j > 1 && j < nRows)                                       //middle rows
                    {
                        for (int i = j - 1; i < len-1; i = i + (2 * nRows - 2))
                        {
                            for (
                                
                                int k = nRows - 2; k >= 1; k--)
                            {
                                result += text[i];
                                if (i+2*nRows-4 < len)
                                {
                                    result += text[i + 2 * nRows - 4];
                                }
                            }
                        }
                    }
                    if (j == nRows)
                    {
                        for (int i = j - 1; i < len; i = i + (2 * nRows - 2))                  //last row
                        {
                            result += text[i];
                        }
                    }
                }
            }



            return result;
        }


    }
}











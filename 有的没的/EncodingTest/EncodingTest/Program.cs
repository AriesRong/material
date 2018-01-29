using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EncodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding ei = Encoding.GetEncoding(936);
            Console.WriteLine(ei.WebName);

            //通过GetBytes()可以把一个字符串或者是字符串数组转换成字节
            string str = "阿萨德喝酒啊是贷款";
            byte[] bytes = Encoding.Unicode.GetBytes(str);
            foreach(byte i in bytes)
            {
                Console.Write(i+" ");
            }

            Console.WriteLine();
            //通过GetChars()可以将字节数组转换成字符
            char[] a = Encoding.Unicode.GetChars(bytes);
            foreach (char i in a)
            {
                Console.Write(i);
            }
            
            Console.WriteLine();
            //通过GetByteCount()可以获得将字符串或者字符串数组转换成字节数组的字节数组的长度
            int count = Encoding.Unicode.GetByteCount(str);
            Console.WriteLine(count);

            //通过GetCharCount()可以获得将字节数组转换成字符串或者字符数组的字符串长度
            int count2 = Encoding.Unicode.GetCharCount(bytes);
            Console.WriteLine(count2);

            Console.WriteLine( GetFileEncoding(@"C:\Users\Y\Desktop\GenericTest\GenericTest.sln"));


            string str2 = "Encoder测试";
            int charCount = str2.Length;
            Encoding ed = Encoding.UTF8;
            char[] chars = str2.ToCharArray();
            int maxByteCount = ed.GetEncoder().GetByteCount(chars, 0, charCount, false);//通过GetEncoder()获得的UFF8编码器获得str转换成byte数组的长度
            byte[] result = new byte[maxByteCount];
            ed.GetEncoder().GetBytes(chars, 0, charCount, result, 0, false);//通过GetEncoder()获得的UTF8编码器对str进行加密,并将加密后的字节数组赋给result
            for (int i = 0; i < result.Length; i++)
            {
                if (i != result.Length - 1)
                    Console.Write("{0:X}-", result[i]);//以16进制输出
                else
                    Console.Write("{0:X}", result[i]);
            }


            Console.WriteLine();
            string str3 = "Encoder测试";
            int charCount3 = str3.Length;
            Encoding ed3 = Encoding.UTF8;
            char[] chars3 = str3.ToCharArray();
            int maxByteCount3 = ed3.GetEncoder().GetByteCount(chars3, 0, charCount3, false);
            byte[] result3 = new byte[maxByteCount3];
            ed3.GetEncoder().GetBytes(chars, 0, charCount3, result3, 0, false);
            char[] resultChars = new char[ed3.GetDecoder().GetCharCount(result3, 0, maxByteCount3)];
            ed3.GetDecoder().GetChars(result3, 0, result3.Length, resultChars, 0, false);
            for (int i = 0; i < resultChars.Length; i++)
            {
                if (i != resultChars.Length - 1)
                    Console.Write("{0}-", resultChars[i]);
                else
                    Console.Write("{0}", resultChars[i]);
            }

            Console.WriteLine();
            string str4 = "Encoding博客系列";
            byte[] bytes4 = Encoding.UTF8.GetBytes(str4);
            char[] result4 = Encoding.UTF8.GetChars(bytes4);
            Console.WriteLine(result4);

            Console.Read();
        }

        public static Encoding GetFileEncoding(string filePath)
        {
            Encoding Result = null;
            FileInfo info = new FileInfo(filePath);
            FileStream fs = default(FileStream);
            try
            {
                fs = info.OpenRead();
                Encoding[] unicodeEncodings =
                {
                    Encoding.BigEndianUnicode,Encoding.Unicode,
                    Encoding.UTF8,Encoding.UTF32,Encoding.UTF7,
                    new UTF32Encoding(true,true)
                };
                for(int i = 0; Result == null && i < unicodeEncodings.Length; i++)
                {
                    fs.Position = 0;
                    byte[] preamble = unicodeEncodings[i].GetPreamble();
                    bool isEqual = true;
                    for(int j = 0; isEqual && j < preamble.Length; j++)
                    {
                        isEqual = preamble[j] == fs.ReadByte();
                    }
                    if (isEqual)
                        Result = unicodeEncodings[i];
                }
            }
            catch(IOException ex)
            {
                throw ex;
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
            if (object.ReferenceEquals(null, Result))
                Result = Encoding.Default;
            return Result;
        }
    }
}

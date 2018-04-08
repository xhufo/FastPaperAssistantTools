using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Security;
using System.Threading;
using System.Net.Sockets;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.IO;

namespace TextProcess
{
    class TestLib
    {
        string text_tmp;
        /* Function 1 */
        public string Delete_blank(string text)
        {
            string s;
            s = text.Replace(" ", "");
            return s;
        }

        /* Function 2 */
        public string Big2Low(string text)
        {
            string s;
            s = text.ToLower();
            return s;
        }

        /* Function 3 */
        /// 转全角的函数(SBC case) /// 
        ///
        /// 全角字符串 ///
        ///全角空格为12288,半角空格为32 
        ///其他字符半角(33-126)与全角(65281-65374)的对应关系是：均相差65248 ///
        public string ToSBC(string input)
        { //半角转全角：
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 32)
                {
                    c[i] = (char)12288; continue;
                }
                if (c[i] < 127)
                    c[i] = (char)(c[i] + 65248);
            }
            return new string(c);
        }

        /// /// 转半角的函数(DBC case) ///
        /// 
        /// 半角字符串 ///
        ///全角空格为12288，半角空格为32
        ///其他字符半角(33-126)与全角(65281-65374)的对应关系是：均相差65248 ///
        public string ToDBC(string input)
        {
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 12288)
                {
                    c[i] = (char)32; continue;
                }
                if (c[i] > 65280 && c[i] < 65375)
                    c[i] = (char)(c[i] - 65248);
            }
            return new string(c);
        }

        /* Function 4 */
        public string Biaodian_CE(string text)
        {
            string s;
            s = text.Replace(",", "，");
            s = s.Replace(";", "；");
            s = s.Replace(".", "。");
            s = s.Replace(":", "：");
            s = s.Replace("?", "？");
            return s;
        }
        
        /* Function 5 */
        public string Delete_huiche(string text)
        {
            string s;
            s = text.Replace("\r", "");
            return s;
        }

        internal static System.Windows.Forms.TextBox Delete_blank(System.Windows.Forms.TextBox TextIn)
        {
            throw new NotImplementedException();
        }

        internal static System.Windows.Forms.TextBox Big2Low(System.Windows.Forms.TextBox TextIn)
        {
            throw new NotImplementedException();
        }
    }
}

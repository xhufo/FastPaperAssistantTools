using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextProcess;

namespace 排版工具新
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextOut.Multiline = true;     //将Multiline属性设置为true，实现显示多行
            TextOut.ScrollBars = RichTextBoxScrollBars.Vertical;　//设置ScrollBars属性实现只显示垂直滚动
            TextIn.Multiline = true;     //将Multiline属性设置为true，实现显示多行
            TextIn.ScrollBars = RichTextBoxScrollBars.Vertical;　//设置ScrollBars属性实现只显示垂直滚动
        }

        TestLib c = new TestLib();
        string text_tmp = null;
        string text_chang_flag = null;
        int flag = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            TestLib c = new TestLib();
            //if (text_chang_flag == null)
            //    text_chang_flag = TextIn.Text;
            //else
            //{
            //    flag = string.Compare(text_chang_flag, TextIn.Text);
            //    if (flag != 0)
            //        text_tmp = TextIn.Text;
            //}

            if (text_tmp == null)
                text_tmp = TextIn.Text;
            else
                text_tmp = c.Delete_blank(text_tmp);
            TextOut.Text = text_tmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestLib c = new TestLib();
            //if (text_chang_flag == null)
            //    text_chang_flag = TextIn.Text;
            //else
            //{
            //    flag = string.Compare(text_chang_flag, TextIn.Text);
            //    if (flag != 0)
            //        text_tmp = TextIn.Text;
            //}

            if (text_tmp == null)
                text_tmp = TextIn.Text;
            else
                text_tmp = c.Big2Low(text_tmp);
            TextOut.Text = text_tmp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TestLib c = new TestLib();
            //if (text_chang_flag == null)
            //    text_chang_flag = TextIn.Text;
            //else
            //{
            //    flag = string.Compare(text_chang_flag, TextIn.Text);
            //    if (flag != 0)
            //        text_tmp = TextIn.Text;
            //}

            if (text_tmp == null)
                text_tmp = TextIn.Text;
            else
                text_tmp = c.ToDBC(text_tmp);
            TextOut.Text = text_tmp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TestLib c = new TestLib();
            //if (text_chang_flag == null)
            //    text_chang_flag = TextIn.Text;
            //else
            //{
            //    flag = string.Compare(text_chang_flag, TextIn.Text);
            //    if (flag != 0)
            //        text_tmp = TextIn.Text;
            //}

            if (text_tmp == null)
                text_tmp = TextIn.Text;
            else
                text_tmp = c.Biaodian_CE(text_tmp);
            TextOut.Text = text_tmp;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TestLib c = new TestLib();
            //if (text_chang_flag == null)
            //    text_chang_flag = TextIn.Text;
            //else
            //{
            //    flag = string.Compare(text_chang_flag, TextIn.Text);
            //    if (flag == 0)
            //        text_tmp = TextIn.Text;
            //}

            if (text_tmp == null)
                text_tmp = TextIn.Text;
            else
                text_tmp = c.Delete_huiche(text_tmp);
            TextOut.Text = text_tmp;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            text_tmp = TextIn.Text;
            TextIn.Font = new Font("宋体", TextIn.Font.Size, TextIn.Font.Style);
            TextIn.Font = new Font(TextIn.Font.FontFamily, 20, TextIn.Font.Style); 
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            TextOut.Font = new Font("宋体", TextOut.Font.Size, TextOut.Font.Style);
            TextOut.Font = new Font(TextOut.Font.FontFamily, 20, TextOut.Font.Style);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

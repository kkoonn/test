using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 英単語
{
    public partial class Form1 : Form
    {
        System.Random rnd = new System.Random();

        int EngWord_num;    //英単語辞書に登録されている単語の数
        int JapWord_num;    //日本語辞書に登録されている単語の数
        int question_num;   //出題される単語の番号

        string file_EngPath = "./英単語辞書.txt";
        string file_JapPath = "./日本語辞書.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void next_button_Click(object sender, EventArgs e)
        {

            if (File.Exists(file_EngPath))
            {
                Encoding encoding = Encoding.GetEncoding("Shift-JIS");
                string[] EngWord = File.ReadAllLines(file_EngPath, encoding);
                EngWord_num = EngWord.Length;
                question_num = rnd.Next(1, EngWord_num);

                English_word.Text = EngWord[question_num];
            }
            else
            {
                English_word.Text = "**英単語辞書が存在しません**";
            }
        }

        private void open_button_Click(object sender, EventArgs e)
        {

            if (File.Exists(file_JapPath))
            {
                Encoding encoding = Encoding.GetEncoding("Shift-JIS");
                string[] JapWord = File.ReadAllLines(file_JapPath, encoding);
                JapWord_num = JapWord.Length;

                Japanese_description.Text = JapWord[question_num].Replace('\t', '\n');
            }
            else
            {
                Japanese_description.Text = "**日本語辞書が存在しません**";
            }
        }
    }
}
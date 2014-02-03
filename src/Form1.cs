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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        bool keyS = false;
        bool keyD = false;
        bool keyF = false;
        bool keyJ = false;
        bool keyK = false;
        bool keyL = false;
        int t = 0;
        Dictionary<int, string> dic;

        public Form1()
        {
            InitializeComponent();

            dic = new Dictionary<int,string>();
            dicAdd(false, false, true, false, false, false, "あ");
            dicAdd(false, true, true, false, false, false, "い");
            dicAdd(false, false, true, true, false, false, "う");
            dicAdd(false, true, true, true, false, false, "え");
            dicAdd(false, true, false, true, false, false, "お");
            dicAdd(false, false, true, false, false, true, "か");
            dicAdd(false, true, true, false, false, true, "き");
            dicAdd(false, false, true, true, false, true, "く");
            dicAdd(false, true, true, true, false, true, "け");
            dicAdd(false, true, false, true, false, true, "こ");
            dicAdd(false, false, true, false, true, true, "さ");
            dicAdd(false, true, true, false, true, true, "し");
            dicAdd(false, false, true, true, true, true, "す");
            dicAdd(false, true, true, true, true, true, "せ");
            dicAdd(false, true, false, true, true, true, "そ");
            dicAdd(true, false, true, false, true, false, "た");
            dicAdd(true, true, true, false, true, false, "ち");
            dicAdd(true, false, true, true, true, false, "つ");
            dicAdd(true, true, true, true, true, false, "て");
            dicAdd(true, true, false, true, true, false, "と");
            dicAdd(true, false, true, false, false, false, "な");
            dicAdd(true, true, true, false, false, false, "に");
            dicAdd(true, false, true, true, false, false, "ぬ");
            dicAdd(true, true, true, true, false, false, "ね");
            dicAdd(true, true, false, true, false, false, "の");
            dicAdd(true, false, true, false, false, true, "は");
            dicAdd(true, true, true, false, false, true, "ひ");
            dicAdd(true, false, true, true, false, true, "ふ");
            dicAdd(true, true, true, true, false, true, "へ");
            dicAdd(true, true, false, true, false, true, "ほ");
            dicAdd(true, false, true, false, true, true, "ま");
            dicAdd(true, true, true, false, true, true, "み");
            dicAdd(true, false, true, true, true, true, "む");
            dicAdd(true, true, true, true, true, true, "め");
            dicAdd(true, true, false, true, true, true, "も");
            dicAdd(true, false, false, true, false, false, "や");
            dicAdd(true, false, false, true, false, true, "ゆ");
            dicAdd(true, false, false, true, true, false, "よ");
            dicAdd(false, false, true, false, true, false, "ら");
            dicAdd(false, true, true, false, true, false, "り");
            dicAdd(false, false, true, true, true, false, "る");
            dicAdd(false, true, true, true, true, false, "れ");
            dicAdd(false, true, false, true, true, false, "ろ");
            dicAdd(true, false, false, false, false, false, "わ");
            dicAdd(true, false, false, false, true, false, "を");
            dicAdd(true, false, false, false, true, true, "ん");

        }

        private void dicAdd(bool s, bool d, bool f, bool j, bool k, bool l,string str)
        {
            int key = 0;
            if (s == true) key += 1;
            if (d == true) key += 2;
            if (f == true) key += 4;
            if (j == true) key += 8;
            if (k == true) key += 16;
            if (l == true) key += 32;

            try
            {
                dic.Add(key, str);
            }
            catch (Exception)
            {
            }
            
        }
        
        private void button1_KeyDown(object sender, KeyEventArgs e)
        {            
            string filePath = @"C:\Users\watanabe-3\Desktop\sdfjkl.txt";
            StreamWriter sw = new StreamWriter(filePath, true, Encoding.UTF8);

            if (e.KeyCode == Keys.S && keyS == false)
            {
                keyS = true;
                //this.button1.Text = DateTime.Now.Millisecond.ToString();
                this.button1.BackColor = Color.FromArgb(0x00, 0x00, 0xFF);
                writeLog(sw);
            }

            if (e.KeyCode == Keys.D && keyD == false)
            {
                keyD = true;
                this.button2.BackColor = Color.FromArgb(0x00, 0x00, 0xFF);
                writeLog(sw);
            }


            if (e.KeyCode == Keys.F && keyF == false)
            {
                keyF = true;
                this.button3.BackColor = Color.FromArgb(0x00, 0x00, 0xFF);
                writeLog(sw);
            }

            if (e.KeyCode == Keys.J && keyJ == false)
            {
                keyJ = true;
                this.button4.BackColor = Color.FromArgb(0x00, 0x00, 0xFF);
                writeLog(sw);
            }

            if (e.KeyCode == Keys.K && keyK == false)
            {
                keyK = true;
                this.button5.BackColor = Color.FromArgb(0x00, 0x00, 0xFF);
                writeLog(sw);
            }

            if (e.KeyCode == Keys.L && keyL == false)
            {
                keyL = true;
                this.button6.BackColor = Color.FromArgb(0x00, 0x00, 0xFF);
                writeLog(sw);
            }

            sw.Close();

        }


        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            string filePath = @"C:\Users\watanabe-3\Desktop\sdfjkl.txt";
            StreamWriter sw = new StreamWriter(filePath, true, Encoding.UTF8);

            if (e.KeyCode == Keys.S && keyS == true)
            {
                keyS = false;
                this.button1.UseVisualStyleBackColor = true;
                writeLog(sw);
            }

            if (e.KeyCode == Keys.D && keyD == true)
            {
                keyD = false;
                this.button2.UseVisualStyleBackColor = true;
                writeLog(sw);
            }

            if (e.KeyCode == Keys.F && keyF == true)
            {
                keyF = false;
                this.button3.UseVisualStyleBackColor = true;
                writeLog(sw);
            }

            if (e.KeyCode == Keys.J && keyJ == true)
            {
                keyJ = false;
                this.button4.UseVisualStyleBackColor = true;
                writeLog(sw);
            }

            if (e.KeyCode == Keys.K && keyK == true)
            {
                keyK = false;
                this.button5.UseVisualStyleBackColor = true;
                writeLog(sw);
            }

            if (e.KeyCode == Keys.L && keyL == true)
            {
                keyL = false;
                this.button6.UseVisualStyleBackColor = true;
                writeLog(sw);
            }
            sw.Close();
        }

        private void writeLog(StreamWriter sw)
        {
            // 対応する文字を取得
            int key = 0;
            if (keyS == true) key += 1;
            if (keyD == true) key += 2;
            if (keyF == true) key += 4;
            if (keyJ == true) key += 8;
            if (keyK == true) key += 16;
            if (keyL == true) key += 32;
            string str = "";

            if (key == 0)
            {
                this.button7.Text = "";
            }
            else if (dic.TryGetValue(key, out str) == false)
            {

            }
            else // 対応文字があるとき
            {
                t++;
                DateTime targetTime = DateTime.Now;
                long unixTime = GetUnixTime(targetTime);
                sw.Write(t.ToString() + "," + unixTime.ToString() + ",");

                if (keyS == true)
                {
                    sw.Write("1,");
                }
                else
                {
                    sw.Write("0,");
                }

                if (keyD == true)
                {
                    sw.Write("1,");
                }
                else
                {
                    sw.Write("0,");
                }

                if (keyF == true)
                {
                    sw.Write("1,");
                }
                else
                {
                    sw.Write("0,");
                }

                if (keyJ == true)
                {
                    sw.Write("1,");
                }
                else
                {
                    sw.Write("0,");
                }

                if (keyK == true)
                {
                    sw.Write("1,");
                }
                else
                {
                    sw.Write("0,");
                }

                if (keyL == true)
                {
                    sw.Write("1,");
                }
                else
                {
                    sw.Write("0,");
                }

                sw.Write(str + ",0\r\n");
                this.button7.Font = new Font("Arial", 40);
                this.button7.Text = str;
            }

        }

        public static long GetUnixTime(DateTime targetTime)
        {
            // UTC時間に変換
            targetTime = targetTime.ToUniversalTime();

            // UNIXエポックからの経過時間を取得
            TimeSpan elapsedTime = targetTime - new DateTime(1970, 1, 1, 0, 0, 0, 0);

           // 経過秒数に変換
            return (long)elapsedTime.TotalMilliseconds;
         }       
    }
}



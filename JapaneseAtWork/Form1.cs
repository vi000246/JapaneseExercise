using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JapaneseAtWork
{
    public partial class Form1 : Form
    {
        //全部片假名、平假名所用的集合佇列
        public Queue<ItemCollection> queue;
        public ItemCollection obj;
        
        public List<ItemCollection> CollectionList = new List<ItemCollection>();
        public Form1()
        {
            InitializeComponent();
            label2.Text = "";
            //將背景設成黃綠 再將黃綠的顏色通通設成透明
            this.BackColor = Color.YellowGreen; this.TransparencyKey = Color.YellowGreen;

            //增加註解
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.label3, "輸入完羅馬拼音後請按空白鍵");

            //取得平假名、片假名清單 並轉成佇列
            var list = Model.HiraganaClean;
            //打亂排序
            list.Shuffle();
            //將list轉成佇列
            queue = new Queue<ItemCollection>(list);
            //取出佇列
            obj = queue.Dequeue();
            label1.Text = obj.Name;


        }


        #region 視窗相關

        //關閉代碼
        private void button1_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        //最小化
        private void pnlFormMin_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //最大化還原切換
        //最大化還原切換
        private bool max = false;
        private void pnlFormMax_MouseClick(object sender, MouseEventArgs e)
        {
            if (max)
            {
                this.WindowState = FormWindowState.Normal;
                max = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                max = true;
            }
        }

        //窗體拖動
        private Point mousePoint = new Point();
        private void pnlCloseBar_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            this.mousePoint.X = e.X;
            this.mousePoint.Y = e.Y;
        }

        private void pnlCloseBar_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Top = Control.MousePosition.Y - mousePoint.Y;
                this.Left = Control.MousePosition.X - mousePoint.X;
            }
        }
        #endregion

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //輸入空白鍵
            if (e.KeyChar == ' ') 
            { 

                //如果答對 取出下一個物件
                if (textBox2.Text.ToLower().Trim() == obj.Spell)
                {
                    //清掉錯誤提示
                    label2.Text = "";

                    if (queue.Count > 0)
                    {
                        obj = queue.Dequeue();
                        label1.Text = obj.Name;
                    }
                    else
                    {
                        label1.Text = "NA";
                    }
                }
                //如果答錯 顯示答案
                else {
                    label2.Text = obj.Spell;
                }
                //清空TextBox
                textBox2.Clear();
            }
        }

    }

    public class Person
    {
        public string Name { set; get; }
    }


}

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
        //錯誤的字都丟到這裡
        public Queue<ItemCollection> ErrorQueue =new Queue<ItemCollection>();
        public ItemCollection obj;
        //總題數
        public float TotalChar;
        //答錯數
        public float ErrorChar;


        public Form1()
        {
            InitializeComponent();
            label2.Text = "";
            //將背景設成黃綠 再將黃綠的顏色通通設成透明
            this.BackColor = Color.YellowGreen; this.TransparencyKey = Color.YellowGreen;
            //初始化測驗
            PracticeInit(true);
        }


        /// <summary>
        /// 初始化測驗
        /// </summary>
        /// <param name="IsReset">是否重設佇列</param>
        public void PracticeInit(bool IsReset){

            //隱藏成績lable
            label4.Visible = false;
            //enable文字輸入框
            textBox2.Enabled = true;
            //文字輸入框focus
            textBox2.Select();
            //如果是重新開始
            if (IsReset)
            {
                //取得平假名、片假名清單 並轉成佇列
                var list = Model.Test;
                //打亂排序
                list.Shuffle();
                //將list轉成佇列
                queue = new Queue<ItemCollection>(list);
                TotalChar = queue.Count;
            }
            //如果是加強練習錯誤清單
            else {
                queue = new Queue<ItemCollection>(ErrorQueue);
                TotalChar = queue.Count;
                ErrorQueue.Clear();
            }

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

        /// <summary>
        /// 輸入文字事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        //所有的佇列都完成
                        QueueComplete();
                    }
                }
                //如果答錯 顯示答案 並將obj排進錯誤字佇列
                else {
                    label2.Text = obj.Spell;
                    if (!ErrorQueue.Contains(obj))
                        ErrorQueue.Enqueue(obj);
                }
                //清空TextBox
                textBox2.Clear();
            }
        }

        /// <summary>
        /// 佇列完成事件
        /// </summary>

        public void QueueComplete() {
            label1.Text = "";
            obj = null;
            textBox2.Enabled = false;
            //成績lable
            label4.Visible = true;
            //答錯數
            ErrorChar=ErrorQueue.Count;
            //顯示成績
            label4.Text = string.Format(@"成績:
總題數 :{0}
答錯數 :{1}
答對率 :{2}%
", TotalChar, ErrorChar, Math.Round(((TotalChar-ErrorChar) / TotalChar) * 100, 2));
            
            //顯示加強練習鈕和重新開始鈕
            if(ErrorChar>0)
                button4.Visible = true;

            button5.Visible = true;
        }

        /// <summary>
        /// 加強練習按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            PracticeInit(false);
        }
        /// <summary>
        /// 重新開始按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            PracticeInit(true);
        }
        //提示按鈕
        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("輸入完羅馬拼音後請按空白鍵");
        }

        #region 鍵盤按鈕監聽 用來給按鈕添加熱鍵
        /// <summary>
        /// 鍵盤按鈕監聽 用來給按鈕添加熱鍵
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //重新開始的按鈕 熱鍵是R
            if (keyData ==Keys.R && button5.Visible==true)
            {
                button4.Visible = false;
                button5.Visible = false;
                PracticeInit(true);
            }
            //加強練習的按鈕 熱鍵是E
            if (keyData ==  Keys.E && button4.Visible == true)
            {
                button4.Visible = false;
                button5.Visible = false;
                PracticeInit(false);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion




    }



}

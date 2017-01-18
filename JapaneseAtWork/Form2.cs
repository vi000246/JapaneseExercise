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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //依照setting的值 將treeview打勾
            //平假名 清音
            this.checkedListBox1.SetItemChecked(0, (bool)Properties.Settings.Default["HiraganaClean"]);
            //平假名 濁音
            this.checkedListBox1.SetItemChecked(1, (bool)Properties.Settings.Default["HiraganaMuddy"]);
            //平假名 拗音
            this.checkedListBox1.SetItemChecked(2, (bool)Properties.Settings.Default["HiraganaBend"]);
            //片假名 清音
            this.checkedListBox2.SetItemChecked(0, (bool)Properties.Settings.Default["KatakanaClean"]);
            //片假名 濁音
            this.checkedListBox2.SetItemChecked(1, (bool)Properties.Settings.Default["KatakanaMuddy"]);
            //片假名 拗音
            this.checkedListBox2.SetItemChecked(2, (bool)Properties.Settings.Default["KatakanaBend"]);

        }



        //存檔事件
        private void button1_Click(object sender, EventArgs e)
        {
            //將Setting存進app裡
            //平假名 清音
            Properties.Settings.Default["HiraganaClean"] = checkedListBox1.GetItemChecked(0);
            //平假名 濁音
            Properties.Settings.Default["HiraganaMuddy"] = checkedListBox1.GetItemChecked(1);
            //平假名 拗音
            Properties.Settings.Default["HiraganaBend"] = checkedListBox1.GetItemChecked(2);
            //片假名 清音
            Properties.Settings.Default["KatakanaClean"] = checkedListBox2.GetItemChecked(0);
            //片假名 濁音
            Properties.Settings.Default["KatakanaMuddy"] = checkedListBox2.GetItemChecked(1);
            //片假名 拗音
            Properties.Settings.Default["KatakanaBend"] = checkedListBox2.GetItemChecked(2);
            Properties.Settings.Default.Save(); // Saves settings in application configuration file
            this.Close();
        }

    }


}


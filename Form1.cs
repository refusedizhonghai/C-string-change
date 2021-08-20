using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 字符转换
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static double liuliangcontrol = -2.5;
        private static int l;
        private void button1_Click(object sender, EventArgs e)
        {
            liu();
        }
        private void liu()
        {
            l = Convert.ToInt16(Math.Round(liuliangcontrol, 1) * 10);                           //需要重新写字符转换

            string liuliang = Convert.ToString(l, 16);                                     //需要重新写字符转换
            
            string liuliangset = "01 05 00 01 " + liuliang.ToString();
            textBox1.Text = liuliangset;
        }
        private void lijinjin()
        {
            if(lovetime<10*/years/*)
            {
                MessageBox.show("we have a baby,Luckys");
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenEyes
{
    public partial class Form1 : Form
    {
        int count_st = 0;
        int soft_st = 50*60;
        int hard_st = 60*60;
        int break_t = 10*60;
        @break @break = new @break();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void second_Tick(object sender, EventArgs e)
        {
            label1.Text = (count_st / 60).ToString()+"/"+(hard_st/60).ToString();
            count_st += 1;
            if(soft_st == count_st)
            {
                user_notify.ShowBalloonTip(1000, "Think about taking a break","It is coming up to the time to take a break to reduce eye strain. Save and start your "+(break_t/60f).ToString()+" minute break. A automatic break will start in "+((hard_st-soft_st)/60f).ToString()+" minutes if you don't start your break yourself.",ToolTipIcon.Info);

            }
            else if (hard_st <= count_st)
            {
                @break.ShowDialog();
                count_st = 0;
            }
        }

        private void break_btn_Click(object sender, EventArgs e)
        {
            @break.ShowDialog();
            count_st = 0;

        }
    }
}

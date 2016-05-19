using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using static Lottery_kahroba.model;
using System.IO;
using Newtonsoft.Json;

namespace Lottery_kahroba
{
    public partial class giftForm : DevComponents.DotNetBar.Metro.MetroForm
    {

        List<userLottery> _data = new List<userLottery>();
        int nextIndex = 0;
        string type_text_name = "";
        string type_text_code = "";
        static int index_Num = 0;

        public giftForm()
        {
            InitializeComponent();
        }

        private void buttonX12_Click(object sender, EventArgs e)
        {
            circularProgress1.IsRunning = !circularProgress1.IsRunning;
            type_text_name = ":-)" + "\n" + "نفر انتخاب شده \n" +
                " شماره دانشجویی " + _data[nextIndex].code + "\n" +
                 "به نام " + _data[nextIndex].name;
            index_Num = 0;
            circularProgress1.IsRunning = true;
            lbl_name.Text = "";
            timer_effect.Enabled = true;
            timer_effect.Interval = 350;
            timer_effect.Start();
            nextIndex++;

            if (nextIndex == _data.Count)
            {
                buttonX12.Visible = false;
            }
        }

        private void timer_effect_Tick(object sender, EventArgs e)
        {
            lbl_name.Text = type_text_name.Substring(0, index_Num);//Substring is a part of Type_Text String that we declared at the start
            index_Num++;//Doing a post fix
            if (index_Num == type_text_name.Length + 1)//An if statment with a condition of course
            {
                index_Num = 0;
                timer_effect.Enabled = false;
                circularProgress1.IsRunning = !circularProgress1.IsRunning;
            }
        }

        private void giftForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader files = File.OpenText(Application.StartupPath + @"\data_acept.lottery"))
                {
                    _data = (List<userLottery>)JsonConvert.DeserializeObject(files.ReadToEnd(), typeof(List<userLottery>));
                }

                if (_data.Count == 0)
                {
                    type_text_name = "برای نمایش نفرات انتخاب شده لطفا اول قرعه کشی انجام دهید";
                    buttonX12.Visible = false;
                }
                else
                {
                    type_text_name = "نمایش نفرات انتخاب شده لطفا شکیبا باشید :-)";

                }
            }
            catch (Exception)
            {
                type_text_name = "برای نمایش نفرات انتخاب شده لطفا اول قرعه کشی انجام دهید";
                buttonX12.Visible = false;
            }

            index_Num = 0;
            circularProgress1.IsRunning = !circularProgress1.IsRunning;
            lbl_name.Text = "";
            timer_effect.Enabled = true;
            timer_effect.Start();
        }
    }
}
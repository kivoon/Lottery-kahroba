using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;
using static Lottery_kahroba.model;
using Newtonsoft.Json;
using System.Threading;

namespace Lottery_kahroba
{
    public partial class Form1 : DevComponents.DotNetBar.Metro.MetroForm
    {
        List<userLottery> _data = new List<userLottery>();
        List<userLottery> _data_Acept = new List<userLottery>();

        public int countGift = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_insert_member_Click(object sender, EventArgs e)
        {
            insert_member iMember = new insert_member();
            iMember.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;

            try
            {
                using (StreamReader files = File.OpenText(Application.StartupPath + @"\data.lottery"))
                {
                    _data = (List<userLottery>)JsonConvert.DeserializeObject(files.ReadToEnd(), typeof(List<userLottery>));
                }
            }
            catch (Exception)
            { }


            txt_count.Text = countGift.ToString();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void radialMenu1_ItemClick(object sender, EventArgs e)
        {

        }

        private void btn_exit_menu_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btn_member_menu_Click(object sender, EventArgs e)
        {
            insert_member iMember = new insert_member();
            iMember.ShowDialog();
        }

        private void btn_refresh_menu_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader files = File.OpenText(Application.StartupPath + @"\data.lottery"))
                {
                    _data = (List<userLottery>)JsonConvert.DeserializeObject(files.ReadToEnd(), typeof(List<userLottery>));
                    MessageBoxEx.Show("اطلاعات شرکت کننده ها با موفقیت بروز شد");
                }
            }
            catch (Exception)
            {

                MessageBoxEx.Show("شرکت کننده ای برای همگام سازی ثبت نشده است");
            }

        }

        private void circularProgress1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_lottery_menu_Click(object sender, EventArgs e)
        {
            circularProgress1.IsRunning = !circularProgress1.IsRunning;
            timer1.Enabled = true;

            ThreadStart ts = null;
            Thread td = null;
            ts = new ThreadStart(lottery);
            td = new Thread(ts);
            td.Start();
        }


        private void lottery()
        {
            if (_data.Count > 0)
            {
                int count = 0;
                int[] selectIndex = new int[countGift];
                for (int i = 0; i < selectIndex.Length; i++)
                {
                    selectIndex[i] = -1;
                }

                Random lot = new Random();
                while (true)
                {
                    if (selectIndex[count] == -1)
                    {

                        for (int i = 0; i < new Random().Next(2, 25); i++)
                        {
                            selectIndex[count] = lot.Next(1, _data.Count) - 1;
                        }
                        bool plus = false;

                        for (int i = 0; i < selectIndex.Length; i++)
                        {
                            if (selectIndex[count] == selectIndex[i] && i != count)
                            {
                                plus = true;
                            }
                        }

                        if (plus == false)
                        {
                            count++;
                        }
                        else
                        {
                            selectIndex[count] = -1;
                        }
                    }

                    if (count == countGift)
                    {
                        break;
                    }
                }


                _data_Acept.Clear();

                string data = "";
                for (int i = 0; i < selectIndex.Length; i++)
                {
                    _data_Acept.Add(new userLottery
                    {
                        name = _data[selectIndex[i]].name,
                        code = _data[selectIndex[i]].code
                    });

                    data += _data[selectIndex[i]].name + " - " + _data[selectIndex[i]].code + "\n";
                }


                if (_data_Acept.Count > 0)
                {
                    string json = JsonConvert.SerializeObject(_data_Acept.ToArray());
                    File.WriteAllText(Application.StartupPath + @"\data_acept.lottery", json);
                }


                while (true)
                {
                    if (timer1.Enabled == false)
                    {
                        giftForm gift = new giftForm();
                        gift.ShowDialog();
                        //MessageBox.Show(data);
                        break;
                    }
                }
            }
            else
            {
                MessageBoxEx.Show("شرکت کننده ای برای قرعه کشی ثبت نشده است");
                timer1.Enabled = false;
                circularProgress1.IsRunning = false;
            }
        }

        private void btn_setting_menu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btn_submit_setting_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            countGift = Convert.ToInt32(txt_count.Text.Trim());
        }

        private void txt_count_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)Keys.Back != e.KeyChar)
            {
                int isNumber = 0;
                e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgress1.IsRunning = !circularProgress1.IsRunning;
            timer1.Enabled = false;
        }

        private void btn_last_gift_Click(object sender, EventArgs e)
        {
            giftForm gift = new giftForm();
            gift.ShowDialog();

        }
    }
}
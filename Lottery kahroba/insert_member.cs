using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using static Lottery_kahroba.model;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using System.IO;

namespace Lottery_kahroba
{
    public partial class insert_member : DevComponents.DotNetBar.Metro.MetroForm
    {

        List<userLottery> _data = new List<userLottery>();

        public insert_member()
        {
            InitializeComponent();
        }

        private void insert_member_Load(object sender, EventArgs e)
        {
            try
            {
            // read JsonSchema directly from a file
            using (StreamReader files = File.OpenText(Application.StartupPath + @"\data.lottery"))
            {
                _data = (List<userLottery>)JsonConvert.DeserializeObject(files.ReadToEnd(), typeof(List<userLottery>));
                dataGridViewX1.DataSource = _data.ToArray();
                dataGridViewX1.Refresh();
            }
            }
            catch (Exception)
            {  }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if (txt_code.Text == "" || txt_name.Text == "")
            {
                MessageBox.Show("لطفا نام و نام خانوادگی و شماره دانشجویی را وارد کنید");

            }
            else if (txt_code.Text.Trim().Length > 8)
            {
                MessageBox.Show("شماره دانشجویی را اشتباه وارد کردید");
            }
            else
            {
                _data.Add(new userLottery()
                {
                    name = txt_name.Text,
                    code = Convert.ToInt32(txt_code.Text.Trim())
                });

                string json = JsonConvert.SerializeObject(_data.ToArray());
                File.WriteAllText(Application.StartupPath + @"\data.lottery", json);

                dataGridViewX1.DataSource = _data.ToArray();
                dataGridViewX1.Refresh();

                txt_code.Text = "";
                txt_name.Text = "";
            }
        }

        private void txt_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)Keys.Back != e.KeyChar)
            {
                int isNumber = 0;
                e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);
            }
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewX1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _data.RemoveAt(e.RowIndex);
            string json = JsonConvert.SerializeObject(_data.ToArray());
            File.WriteAllText(Application.StartupPath + @"\data.lottery", json);

            dataGridViewX1.DataSource = _data.ToArray();
            dataGridViewX1.Refresh();

        }
    }
}
namespace Lottery_kahroba
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btn_exit = new DevComponents.DotNetBar.ButtonX();
            this.btn_insert_member = new DevComponents.DotNetBar.ButtonX();
            this.radialMenu2 = new DevComponents.DotNetBar.RadialMenu();
            this.btn_lottery_menu = new DevComponents.DotNetBar.RadialMenuItem();
            this.btn_exit_menu = new DevComponents.DotNetBar.RadialMenuItem();
            this.btn_member_menu = new DevComponents.DotNetBar.RadialMenuItem();
            this.btn_refresh_menu = new DevComponents.DotNetBar.RadialMenuItem();
            this.btn_setting_menu = new DevComponents.DotNetBar.RadialMenuItem();
            this.btn_last_gift = new DevComponents.DotNetBar.RadialMenuItem();
            this.circularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.circularProgressItem3 = new DevComponents.DotNetBar.CircularProgressItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_submit_setting = new DevComponents.DotNetBar.ButtonX();
            this.txt_count = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // btn_exit
            // 
            this.btn_exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btn_exit.Location = new System.Drawing.Point(12, 510);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(152, 40);
            this.btn_exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "خروج";
            this.btn_exit.TextColor = System.Drawing.Color.White;
            this.btn_exit.Visible = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_insert_member
            // 
            this.btn_insert_member.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_insert_member.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_insert_member.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_insert_member.Location = new System.Drawing.Point(635, 510);
            this.btn_insert_member.Name = "btn_insert_member";
            this.btn_insert_member.Size = new System.Drawing.Size(152, 40);
            this.btn_insert_member.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_insert_member.TabIndex = 4;
            this.btn_insert_member.Text = "ثبت شرکت کننده";
            this.btn_insert_member.Visible = false;
            this.btn_insert_member.Click += new System.EventHandler(this.btn_insert_member_Click);
            // 
            // radialMenu2
            // 
            this.radialMenu2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radialMenu2.BackColor = System.Drawing.Color.Transparent;
            this.radialMenu2.Diameter = 400;
            this.radialMenu2.ForeColor = System.Drawing.Color.Black;
            this.radialMenu2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_lottery_menu,
            this.btn_exit_menu,
            this.btn_member_menu,
            this.btn_refresh_menu,
            this.btn_setting_menu,
            this.btn_last_gift});
            this.radialMenu2.Location = new System.Drawing.Point(375, 300);
            this.radialMenu2.MaxItemPieAngle = 120;
            this.radialMenu2.MaxItemRadialAngle = 100;
            this.radialMenu2.MinimumSize = new System.Drawing.Size(100, 100);
            this.radialMenu2.Name = "radialMenu2";
            this.radialMenu2.ShowToolTips = false;
            this.radialMenu2.Size = new System.Drawing.Size(100, 100);
            this.radialMenu2.SubMenuEdgeItemSpacing = 2;
            this.radialMenu2.SubMenuEdgeWidth = 10;
            this.radialMenu2.Symbol = "";
            this.radialMenu2.SymbolSize = 55F;
            this.radialMenu2.TabIndex = 6;
            this.radialMenu2.Text = "radialMenu2";
            // 
            // btn_lottery_menu
            // 
            this.btn_lottery_menu.CircularBackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_lottery_menu.Name = "btn_lottery_menu";
            this.btn_lottery_menu.Symbol = "";
            this.btn_lottery_menu.Text = "قرعه کشی";
            this.btn_lottery_menu.Click += new System.EventHandler(this.btn_lottery_menu_Click);
            // 
            // btn_exit_menu
            // 
            this.btn_exit_menu.CircularBackColor = System.Drawing.Color.Red;
            this.btn_exit_menu.Name = "btn_exit_menu";
            this.btn_exit_menu.Symbol = "";
            this.btn_exit_menu.Text = "خروج";
            this.btn_exit_menu.Click += new System.EventHandler(this.btn_exit_menu_Click);
            // 
            // btn_member_menu
            // 
            this.btn_member_menu.CircularBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_member_menu.Name = "btn_member_menu";
            this.btn_member_menu.Symbol = "";
            this.btn_member_menu.Text = "ثبت مشخصات";
            this.btn_member_menu.Click += new System.EventHandler(this.btn_member_menu_Click);
            // 
            // btn_refresh_menu
            // 
            this.btn_refresh_menu.CircularBackColor = System.Drawing.Color.DarkOrange;
            this.btn_refresh_menu.Name = "btn_refresh_menu";
            this.btn_refresh_menu.Symbol = "";
            this.btn_refresh_menu.Text = "همگام سازی";
            this.btn_refresh_menu.Click += new System.EventHandler(this.btn_refresh_menu_Click);
            // 
            // btn_setting_menu
            // 
            this.btn_setting_menu.CircularBackColor = System.Drawing.Color.Gold;
            this.btn_setting_menu.Name = "btn_setting_menu";
            this.btn_setting_menu.Symbol = "";
            this.btn_setting_menu.Text = "تنظیمات";
            this.btn_setting_menu.Click += new System.EventHandler(this.btn_setting_menu_Click);
            // 
            // btn_last_gift
            // 
            this.btn_last_gift.CircularBackColor = System.Drawing.Color.DeepPink;
            this.btn_last_gift.Name = "btn_last_gift";
            this.btn_last_gift.Symbol = "";
            this.btn_last_gift.Text = "نتایج";
            this.btn_last_gift.Click += new System.EventHandler(this.btn_last_gift_Click);
            // 
            // circularProgress1
            // 
            this.circularProgress1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularProgress1.AnimationSpeed = 85;
            this.circularProgress1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.circularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress1.FocusCuesEnabled = false;
            this.circularProgress1.Location = new System.Drawing.Point(252, 177);
            this.circularProgress1.Name = "circularProgress1";
            this.circularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut;
            this.circularProgress1.ProgressColor = System.Drawing.Color.DarkOrange;
            this.circularProgress1.ProgressTextFormat = "";
            this.circularProgress1.Size = new System.Drawing.Size(341, 350);
            this.circularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress1.TabIndex = 7;
            this.circularProgress1.ValueChanged += new System.EventHandler(this.circularProgress1_ValueChanged);
            // 
            // circularProgressItem3
            // 
            this.circularProgressItem3.Name = "circularProgressItem3";
            this.circularProgressItem3.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut;
            this.circularProgressItem3.ProgressColor = System.Drawing.Color.SteelBlue;
            this.circularProgressItem3.Text = "Donut";
            this.circularProgressItem3.TextPosition = DevComponents.DotNetBar.eTextPosition.Bottom;
            this.circularProgressItem3.Value = 75;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_submit_setting);
            this.panel1.Controls.Add(this.txt_count);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(170, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 367);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // btn_submit_setting
            // 
            this.btn_submit_setting.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_submit_setting.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit_setting.Location = new System.Drawing.Point(129, 223);
            this.btn_submit_setting.Name = "btn_submit_setting";
            this.btn_submit_setting.Size = new System.Drawing.Size(246, 50);
            this.btn_submit_setting.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_submit_setting.TabIndex = 5;
            this.btn_submit_setting.Text = "ثبت تغییرات";
            this.btn_submit_setting.Click += new System.EventHandler(this.btn_submit_setting_Click);
            // 
            // txt_count
            // 
            this.txt_count.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_count.Border.Class = "TextBoxBorder";
            this.txt_count.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_count.DisabledBackColor = System.Drawing.Color.White;
            this.txt_count.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_count.ForeColor = System.Drawing.Color.Black;
            this.txt_count.Location = new System.Drawing.Point(129, 146);
            this.txt_count.Name = "txt_count";
            this.txt_count.PreventEnterBeep = true;
            this.txt_count.Size = new System.Drawing.Size(246, 71);
            this.txt_count.TabIndex = 4;
            this.txt_count.Text = "1";
            this.txt_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_count_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(165, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "تعداد برنده ها";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ForeColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::Lottery_kahroba.Properties.Resources.head;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radialMenu2);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_insert_member);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.circularProgress1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سیستم قرعه کشی کهربا";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonX btn_exit;
        private DevComponents.DotNetBar.ButtonX btn_insert_member;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.RadialMenu radialMenu2;
        private DevComponents.DotNetBar.RadialMenuItem btn_exit_menu;
        private DevComponents.DotNetBar.RadialMenuItem btn_lottery_menu;
        private DevComponents.DotNetBar.RadialMenuItem btn_member_menu;
        private DevComponents.DotNetBar.RadialMenuItem btn_refresh_menu;
        private DevComponents.DotNetBar.CircularProgressItem circularProgressItem3;
        private DevComponents.DotNetBar.RadialMenuItem btn_setting_menu;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX btn_submit_setting;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.RadialMenuItem btn_last_gift;
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress1;
    }
}
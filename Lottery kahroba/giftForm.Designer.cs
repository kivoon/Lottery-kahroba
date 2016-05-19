namespace Lottery_kahroba
{
    partial class giftForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giftForm));
            this.circularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.lbl_name = new System.Windows.Forms.Label();
            this.buttonX12 = new DevComponents.DotNetBar.ButtonX();
            this.timer_effect = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // circularProgress1
            // 
            this.circularProgress1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.circularProgress1.AnimationSpeed = 85;
            this.circularProgress1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.circularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress1.FocusCuesEnabled = false;
            this.circularProgress1.Location = new System.Drawing.Point(271, 15);
            this.circularProgress1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.circularProgress1.Name = "circularProgress1";
            this.circularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut;
            this.circularProgress1.ProgressColor = System.Drawing.Color.DarkOrange;
            this.circularProgress1.ProgressTextFormat = "";
            this.circularProgress1.Size = new System.Drawing.Size(200, 200);
            this.circularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress1.TabIndex = 8;
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_name.BackColor = System.Drawing.Color.White;
            this.lbl_name.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_name.Location = new System.Drawing.Point(16, 221);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_name.Size = new System.Drawing.Size(684, 234);
            this.lbl_name.TabIndex = 9;
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonX12
            // 
            this.buttonX12.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonX12.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX12.FocusCuesEnabled = false;
            this.buttonX12.Image = ((System.Drawing.Image)(resources.GetObject("buttonX12.Image")));
            this.buttonX12.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX12.Location = new System.Drawing.Point(303, 461);
            this.buttonX12.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonX12.Name = "buttonX12";
            this.buttonX12.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.buttonX12.Size = new System.Drawing.Size(120, 120);
            this.buttonX12.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX12.SubItemsExpandWidth = 0;
            this.buttonX12.Symbol = "";
            this.buttonX12.SymbolColor = System.Drawing.Color.White;
            this.buttonX12.SymbolSize = 35F;
            this.buttonX12.TabIndex = 0;
            this.buttonX12.Click += new System.EventHandler(this.buttonX12_Click);
            // 
            // timer_effect
            // 
            this.timer_effect.Interval = 200;
            this.timer_effect.Tick += new System.EventHandler(this.timer_effect_Tick);
            // 
            // giftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 596);
            this.Controls.Add(this.buttonX12);
            this.Controls.Add(this.circularProgress1);
            this.Controls.Add(this.lbl_name);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "giftForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.giftForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress1;
        private System.Windows.Forms.Label lbl_name;
        private DevComponents.DotNetBar.ButtonX buttonX12;
        private System.Windows.Forms.Timer timer_effect;
    }
}
namespace PRO_BYT_kalendarz.Views
{
    partial class AddEventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEventForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LBName = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBDescription = new System.Windows.Forms.TextBox();
            this.LBDescripton = new System.Windows.Forms.Label();
            this.LBAlarm = new System.Windows.Forms.Label();
            this.CBAlarm = new System.Windows.Forms.CheckBox();
            this.DTPDate = new System.Windows.Forms.DateTimePicker();
            this.DTPHour = new System.Windows.Forms.DateTimePicker();
            this.BTSubmit = new System.Windows.Forms.Button();
            this.BTCacnel = new System.Windows.Forms.Button();
            this.ErrPName = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrPName)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Location = new System.Drawing.Point(3, 497);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 3);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Location = new System.Drawing.Point(397, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 470);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 30);
            this.panel3.TabIndex = 2;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PNMoveWindow_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PNMoveWindow_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PNMoveWindow_MouseUp);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Orange;
            this.panel4.Location = new System.Drawing.Point(0, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 470);
            this.panel4.TabIndex = 3;
            // 
            // LBName
            // 
            this.LBName.AutoSize = true;
            this.LBName.Location = new System.Drawing.Point(50, 74);
            this.LBName.Name = "LBName";
            this.LBName.Size = new System.Drawing.Size(40, 13);
            this.LBName.TabIndex = 4;
            this.LBName.Text = "Nazwa";
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(145, 66);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(100, 20);
            this.TBName.TabIndex = 5;
            // 
            // TBDescription
            // 
            this.TBDescription.Location = new System.Drawing.Point(145, 111);
            this.TBDescription.Name = "TBDescription";
            this.TBDescription.Size = new System.Drawing.Size(100, 20);
            this.TBDescription.TabIndex = 6;
            // 
            // LBDescripton
            // 
            this.LBDescripton.AutoSize = true;
            this.LBDescripton.Location = new System.Drawing.Point(53, 111);
            this.LBDescripton.Name = "LBDescripton";
            this.LBDescripton.Size = new System.Drawing.Size(28, 13);
            this.LBDescripton.TabIndex = 7;
            this.LBDescripton.Text = "Opis";
            // 
            // LBAlarm
            // 
            this.LBAlarm.AutoSize = true;
            this.LBAlarm.Location = new System.Drawing.Point(53, 153);
            this.LBAlarm.Name = "LBAlarm";
            this.LBAlarm.Size = new System.Drawing.Size(33, 13);
            this.LBAlarm.TabIndex = 8;
            this.LBAlarm.Text = "Alarm";
            // 
            // CBAlarm
            // 
            this.CBAlarm.AutoSize = true;
            this.CBAlarm.Location = new System.Drawing.Point(145, 153);
            this.CBAlarm.Name = "CBAlarm";
            this.CBAlarm.Size = new System.Drawing.Size(78, 17);
            this.CBAlarm.TabIndex = 9;
            this.CBAlarm.Text = "bez Alarmu";
            this.CBAlarm.UseVisualStyleBackColor = true;
            this.CBAlarm.CheckedChanged += new System.EventHandler(this.CBAlarm_CheckedChanged);
            // 
            // DTPDate
            // 
            this.DTPDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPDate.Location = new System.Drawing.Point(53, 234);
            this.DTPDate.Name = "DTPDate";
            this.DTPDate.ShowUpDown = true;
            this.DTPDate.Size = new System.Drawing.Size(292, 20);
            this.DTPDate.TabIndex = 10;
            // 
            // DTPHour
            // 
            this.DTPHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTPHour.Location = new System.Drawing.Point(53, 283);
            this.DTPHour.Name = "DTPHour";
            this.DTPHour.ShowUpDown = true;
            this.DTPHour.Size = new System.Drawing.Size(292, 20);
            this.DTPHour.TabIndex = 11;
            // 
            // BTSubmit
            // 
            this.BTSubmit.Location = new System.Drawing.Point(256, 369);
            this.BTSubmit.Name = "BTSubmit";
            this.BTSubmit.Size = new System.Drawing.Size(75, 23);
            this.BTSubmit.TabIndex = 12;
            this.BTSubmit.Text = "Dodaj";
            this.BTSubmit.UseVisualStyleBackColor = true;
            this.BTSubmit.Click += new System.EventHandler(this.BTSubmit_Click);
            // 
            // BTCacnel
            // 
            this.BTCacnel.Location = new System.Drawing.Point(56, 369);
            this.BTCacnel.Name = "BTCacnel";
            this.BTCacnel.Size = new System.Drawing.Size(75, 23);
            this.BTCacnel.TabIndex = 13;
            this.BTCacnel.Text = "Anuluj";
            this.BTCacnel.UseVisualStyleBackColor = true;
            this.BTCacnel.Click += new System.EventHandler(this.BTCacnel_Click);
            // 
            // ErrPName
            // 
            this.ErrPName.ContainerControl = this;
            this.ErrPName.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrPName.Icon")));
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.BTCacnel);
            this.Controls.Add(this.BTSubmit);
            this.Controls.Add(this.DTPHour);
            this.Controls.Add(this.DTPDate);
            this.Controls.Add(this.CBAlarm);
            this.Controls.Add(this.LBAlarm);
            this.Controls.Add(this.LBDescripton);
            this.Controls.Add(this.TBDescription);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.LBName);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEventForm";
            this.Text = "AddEventForm";
            this.Load += new System.EventHandler(this.AddEventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrPName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LBName;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBDescription;
        private System.Windows.Forms.Label LBDescripton;
        private System.Windows.Forms.Label LBAlarm;
        private System.Windows.Forms.CheckBox CBAlarm;
        private System.Windows.Forms.DateTimePicker DTPDate;
        private System.Windows.Forms.DateTimePicker DTPHour;
        private System.Windows.Forms.Button BTSubmit;
        private System.Windows.Forms.Button BTCacnel;
        private System.Windows.Forms.ErrorProvider ErrPName;
    }
}
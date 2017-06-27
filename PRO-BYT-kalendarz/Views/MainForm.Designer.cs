namespace PRO_BYT_kalendarz
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BTClose = new System.Windows.Forms.Button();
            this.LVEvents = new System.Windows.Forms.ListView();
            this.EventId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EventName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EventDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EventAlarm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EventAlarmDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EventAlarmHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CMSEvents = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.usunWydarzenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujWydarzenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTNewEvent = new System.Windows.Forms.Button();
            this.dodajWydarzenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4.SuspendLayout();
            this.CMSEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(897, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 470);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(3, 497);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 3);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 470);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.BTClose);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(900, 30);
            this.panel4.TabIndex = 1;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PNMoveWindow_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PNMoveWindow_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PNMoveWindow_MouseUp);
            // 
            // BTClose
            // 
            this.BTClose.BackColor = System.Drawing.Color.Black;
            this.BTClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTClose.BackgroundImage")));
            this.BTClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTClose.FlatAppearance.BorderSize = 0;
            this.BTClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BTClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BTClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTClose.ForeColor = System.Drawing.Color.Black;
            this.BTClose.Location = new System.Drawing.Point(870, 5);
            this.BTClose.Margin = new System.Windows.Forms.Padding(0);
            this.BTClose.Name = "BTClose";
            this.BTClose.Size = new System.Drawing.Size(20, 20);
            this.BTClose.TabIndex = 2;
            this.BTClose.UseVisualStyleBackColor = false;
            this.BTClose.Click += new System.EventHandler(this.BTClose_Click);
            this.BTClose.MouseEnter += new System.EventHandler(this.BTClose_MouseEnter);
            this.BTClose.MouseLeave += new System.EventHandler(this.BTClose_MouseLeave);
            // 
            // LVEvents
            // 
            this.LVEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EventId,
            this.EventName,
            this.EventDescription,
            this.EventAlarm,
            this.EventAlarmDay,
            this.EventAlarmHour});
            this.LVEvents.ContextMenuStrip = this.CMSEvents;
            this.LVEvents.FullRowSelect = true;
            this.LVEvents.Location = new System.Drawing.Point(50, 80);
            this.LVEvents.Name = "LVEvents";
            this.LVEvents.Size = new System.Drawing.Size(800, 300);
            this.LVEvents.TabIndex = 2;
            this.LVEvents.TileSize = new System.Drawing.Size(168, 30);
            this.LVEvents.UseCompatibleStateImageBehavior = false;
            this.LVEvents.View = System.Windows.Forms.View.Details;
            // 
            // EventId
            // 
            this.EventId.Text = "Id";
            // 
            // EventName
            // 
            this.EventName.Text = "Nazwa";
            // 
            // EventDescription
            // 
            this.EventDescription.Text = "Opis";
            // 
            // EventAlarm
            // 
            this.EventAlarm.Text = "Alarm";
            // 
            // EventAlarmDay
            // 
            this.EventAlarmDay.Text = "Dzien";
            // 
            // EventAlarmHour
            // 
            this.EventAlarmHour.Text = "Godzina";
            // 
            // CMSEvents
            // 
            this.CMSEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usunWydarzenieToolStripMenuItem,
            this.edytujWydarzenieToolStripMenuItem,
            this.dodajWydarzenieToolStripMenuItem});
            this.CMSEvents.Name = "CMSEvents";
            this.CMSEvents.Size = new System.Drawing.Size(172, 92);
            // 
            // usunWydarzenieToolStripMenuItem
            // 
            this.usunWydarzenieToolStripMenuItem.Name = "usunWydarzenieToolStripMenuItem";
            this.usunWydarzenieToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.usunWydarzenieToolStripMenuItem.Text = "Usun Wydarzenie";
            this.usunWydarzenieToolStripMenuItem.Click += new System.EventHandler(this.usunWydarzenieToolStripMenuItem_Click);
            // 
            // edytujWydarzenieToolStripMenuItem
            // 
            this.edytujWydarzenieToolStripMenuItem.Name = "edytujWydarzenieToolStripMenuItem";
            this.edytujWydarzenieToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.edytujWydarzenieToolStripMenuItem.Text = "Edytuj Wydarzenie";
            this.edytujWydarzenieToolStripMenuItem.Click += new System.EventHandler(this.edytujWydarzenieToolStripMenuItem_Click);
            // 
            // BTNewEvent
            // 
            this.BTNewEvent.Location = new System.Drawing.Point(121, 426);
            this.BTNewEvent.Name = "BTNewEvent";
            this.BTNewEvent.Size = new System.Drawing.Size(75, 23);
            this.BTNewEvent.TabIndex = 3;
            this.BTNewEvent.Text = "Dodaj";
            this.BTNewEvent.UseVisualStyleBackColor = true;
            this.BTNewEvent.Click += new System.EventHandler(this.BTNewEvent_Click);
            // 
            // dodajWydarzenieToolStripMenuItem
            // 
            this.dodajWydarzenieToolStripMenuItem.Name = "dodajWydarzenieToolStripMenuItem";
            this.dodajWydarzenieToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.dodajWydarzenieToolStripMenuItem.Text = "Dodaj Wydarzenie";
            this.dodajWydarzenieToolStripMenuItem.Click += new System.EventHandler(this.dodajWydarzenieToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.BTNewEvent);
            this.Controls.Add(this.LVEvents);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel4.ResumeLayout(false);
            this.CMSEvents.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BTClose;
        private System.Windows.Forms.ListView LVEvents;
        private System.Windows.Forms.Button BTNewEvent;
        private System.Windows.Forms.ColumnHeader EventId;
        private System.Windows.Forms.ColumnHeader EventName;
        private System.Windows.Forms.ColumnHeader EventDescription;
        private System.Windows.Forms.ColumnHeader EventAlarm;
        private System.Windows.Forms.ColumnHeader EventAlarmDay;
        private System.Windows.Forms.ColumnHeader EventAlarmHour;
        private System.Windows.Forms.ContextMenuStrip CMSEvents;
        private System.Windows.Forms.ToolStripMenuItem usunWydarzenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujWydarzenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajWydarzenieToolStripMenuItem;
    }
}


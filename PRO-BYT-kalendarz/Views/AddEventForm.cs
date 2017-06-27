using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO_BYT_kalendarz.Views
{
    public partial class AddEventForm : Form
    {
        public Event formEvent;
        private int posX = 0, posY = 0;
        public bool Canceled;
        public AddEventForm(int x, int y)
        {
            InitializeComponent();
            posX = x;
            posY = y;
            Canceled = true;
            formEvent = null;
            this.setDateFormat();
        }
        public AddEventForm(int x, int y, Event ev)
        {
            InitializeComponent();
            posX = x;
            posY = y;
            Canceled = true;
            formEvent = ev;
            this.setDateFormat();
            this.TBName.Text = ev.Name;
            this.TBDescription.Text = ev.Description;
            if(ev.Alarm)
            {
                this.CBAlarm.CheckState = CheckState.Checked;
                this.CBAlarm_CheckedChanged();
                this.DTPDate.Value = ev.AlarmDate;
                this.DTPHour.Value = ev.AlarmDate;
            }
        }

        private void setDateFormat()
        {
            DTPDate.Format = DateTimePickerFormat.Custom;
            DTPDate.CustomFormat = "dd-MM-yyyy";
        }

        int mouseX = 0, mouseY = 0;
        int distanceX = 0, distanceY = 0;
        bool mouseDown;
        private void PNMoveWindow_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            distanceX = MousePosition.X - this.DesktopLocation.X;
            distanceY = MousePosition.Y - this.DesktopLocation.Y;
        }

        private void PNMoveWindow_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void PNMoveWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - distanceX;
                mouseY = MousePosition.Y - distanceY;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void CBAlarm_CheckedChanged(object sender=null, EventArgs e=null)
        {
            if (CBAlarm.CheckState == CheckState.Checked)
            {
                CBAlarm.Text = "z Alarmem";
            }
            else if (CBAlarm.CheckState == CheckState.Unchecked)
            {
                CBAlarm.Text = "bez Alarmu";
            }
        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(posX, posY);
        }

        private void BTCacnel_Click(object sender, EventArgs e)
        {
            Canceled = true;
            Close();
        }

        private void BTSubmit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TBName.Text) && !String.IsNullOrEmpty(TBDescription.Text))
            {
                Canceled = false;
                formEvent.Name = TBName.Text;
                formEvent.Description = TBDescription.Text;
                //formEvent.AlarmDate = DTPDate.Value.Date;
                formEvent.AlarmDate = new DateTime(DTPDate.Value.Year, DTPDate.Value.Month, DTPDate.Value.Day);
                TimeSpan ts = new TimeSpan(DTPHour.Value.Hour, DTPHour.Value.Minute, DTPHour.Value.Second);
                formEvent.AlarmDate += ts;
                if (CBAlarm.CheckState==CheckState.Checked)
                {
                    formEvent.Alarm = true;
                    Close();
                }
                else
                {
                    formEvent.Alarm = false;
                    Close();
                }
            }
            else
            {

            }
        }

        private void TBName_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}

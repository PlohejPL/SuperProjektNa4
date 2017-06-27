using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace PRO_BYT_kalendarz
{
    public partial class MainForm : Form
    {
        public ImageList Icons = new ImageList();
        private PRO_BYT_kalendarz.Controller.ApplicationController controller;
        public MainForm(PRO_BYT_kalendarz.Controller.ApplicationController apCtrl)
        {
            InitializeComponent();
            this.controller = apCtrl;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Icons = new ImageList();
            Assembly _assembly;
            Stream _imageStream;
            //StreamReader _textStreamReader;
            try
            {
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("PRO_BYT_kalendarz.clo00.png");

                Icons.Images.Add("clo00", new Bitmap(_imageStream));

                _imageStream = _assembly.GetManifestResourceStream("PRO_BYT_kalendarz.clo01.png");
                Icons.Images.Add("clo01", new Bitmap(_imageStream));
            }
            catch
            {
                MessageBox.Show("Error accessing resources!");
            }
            RefreshLVEvents();
        }

        private void BTClose_Click(object sender, EventArgs e)
        {
            //FileSerializer.SerializeListToFile(dataBase);
            controller.exitApplication();
            this.Close();
        }

        private void BTClose_MouseEnter(object sender, EventArgs e)
        {
            BTClose.BackgroundImage = Icons.Images["clo01"];
        }

        private void BTClose_MouseLeave(object sender, EventArgs e)
        {
            BTClose.BackgroundImage = Icons.Images["clo00"];
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

        public void RefreshLVEvents()
        {
            LVEvents.Items.Clear();
            List<Event> events = (List<Event>)controller.eventDB.getAllTasks();
            for (int i = 0; i < events.Count; i++)
            {
                ListViewItem item;
                Event tmpEvent;
                tmpEvent = ((Event)events[i]);
                item = new ListViewItem(Convert.ToString(tmpEvent.Id));
                item.SubItems.Add(Convert.ToString(tmpEvent.Name));
                item.SubItems.Add(Convert.ToString(tmpEvent.Description));
                item.SubItems.Add(Convert.ToString(tmpEvent.Alarm));
                if (tmpEvent.Alarm)
                {
                    item.SubItems.Add(Convert.ToString(tmpEvent.AlarmDate.Date.ToString("dd-MM-yyyy")));
                    item.SubItems.Add(Convert.ToString(tmpEvent.AlarmDate.ToString("HH") + ":" + tmpEvent.AlarmDate.ToString("mm") + ":" + tmpEvent.AlarmDate.ToString("ss")));
                }
                else
                {
                    item.SubItems.Add(Convert.ToString("--"));
                    item.SubItems.Add(Convert.ToString("--"));
                }
                //item.BackColor = Color.Coral;
                LVEvents.Items.Add(item);
            }
            LVEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void BTNewEvent_Click(object sender, EventArgs e)
        {
            controller.AddEvent();
        }

        private void usunWydarzenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string asddd = LVEvents.SelectedItems[0].SubItems[0].Text;
            int ads = int.Parse(LVEvents.SelectedItems[0].SubItems[0].Text);
            controller.eventDB.deleteTask(int.Parse(LVEvents.SelectedItems[0].SubItems[0].Text));
            RefreshLVEvents();
        }

        private void edytujWydarzenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.EditEvent(int.Parse(LVEvents.SelectedItems[0].SubItems[0].Text));
        }

        private void dodajWydarzenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.AddEvent();
        }
    }
}

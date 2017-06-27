using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRO_BYT_kalendarz.Views;

namespace PRO_BYT_kalendarz.Controller
{
    public class ApplicationController
    {
        private MainForm mainForm;

        public IDbConnectionMenagement<Event> eventDB;

        public ApplicationController()
        {
            eventDB = new FakeDB();
            mainForm = new MainForm(this);
            mainForm.ShowDialog();
        }

        public void AddEvent()
        {
            AddEventForm newEventForm = new AddEventForm(mainForm.Location.X + 250, mainForm.Location.Y);
            newEventForm.formEvent = new Event();
            newEventForm.ShowDialog();

            if (!newEventForm.Canceled)
                eventDB.saveTask(newEventForm.formEvent);

            mainForm.RefreshLVEvents();
        }

        public void EditEvent(int eventId)
        {
            try
            {
                Event editedEvent = eventDB.getTask(eventId);
                AddEventForm editForm = new AddEventForm(mainForm.Location.X + 250, mainForm.Location.Y, editedEvent);
                editForm.ShowDialog();

                bool tmp = editForm.Canceled;

                if (!editForm.Canceled)
                {
                    eventDB.editTask(editForm.formEvent);
                    mainForm.RefreshLVEvents();
                }
            }
            catch (Exception e)
            {
               // MessageBox.Show("Nie wybrano ksiazki", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                string s = e.ToString();
            }
        }

        public void exitApplication()
        {
            eventDB.Dispose();
        }
    }
}

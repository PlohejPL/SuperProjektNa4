using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PRO_BYT_kalendarz
{
    public class FakeDB : IDbConnectionMenagement<Event>, IDisposable
    {
        private List<Event> events;
        private static String fileName = "events.bin";
        private SequenceMenager seqMenager;


        public Event getTask(int taskId)
        {
            Event eevent = null;
            foreach (Event tmpEvent in events)
            {
                if (tmpEvent.Id == taskId)
                {
                    eevent = tmpEvent;
                }
            }
            return eevent;
        }

        public IEnumerable<Event> getAllTasks()
        {
            return events;
        }

        public Event saveTask(Event task)
        {  
            task.Id =  seqMenager.getNextInt();
            events.Add(task);
            return task;
        }

        public void editTask(Event eevent)
        {
            /*foreach (Event tmpEvent in events)
            {
                if (tmpEvent.Id == eevent.Id)
                {
                    tmpEvent.Name = eevent.Name;
                    tmpEvent.Description = eevent.Description;
                    tmpEvent.Alarm = eevent.Alarm;
                    tmpEvent.AlarmDate = eevent.AlarmDate;
                }
            }*/

            for (int i=0;i<events.Count;i++)
            {
                if (events[i].Id == eevent.Id)
                {
                    events[i] = eevent;
                    break;
                }
            }
        }

        public void deleteTask(Event task)
        {
            events.Remove(task);
        }

        public void deleteTask(int taskId)
        {
            foreach (Event tmpEvent in events)
            {
                if (tmpEvent.Id==taskId)
                {
                    events.Remove(tmpEvent);
                    break;
                }
            }
        }



        public FakeDB()
        {
            seqMenager = new SequenceMenager();
            events = new List<Event>();

            var List = (List<Event>)null;
            try
            {
                using (Stream stream = File.Open(fileName, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    List = (List<Event>)bin.Deserialize(stream);
                }
                events = List.ToList();
            }
            catch (IOException)
            {

            }
        }
        bool disposed = false;
        public void Dispose()
        {
            seqMenager.Dispose();
            if (!disposed)
            {
                try
                {
                    using (Stream stream = File.Open(fileName, FileMode.Create))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        bin.Serialize(stream, events);
                    }
                }
                catch (IOException)
                {

                }
                catch (Exception)
                {

                }
                disposed = true;
            }
        }


    }
}

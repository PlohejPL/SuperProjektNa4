using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PRO_BYT_kalendarz;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class ModelTests
    {
        [TestMethod]
        public void DBTest_AddEvent()
        {
            FakeDB db = new PRO_BYT_kalendarz.FakeDB();
            Event ev = new Event{ Id=1,Name="Unit test1", Description="unitTest1", Alarm=false,AlarmDate=new DateTime(2018,10,10,10,10,10)};
            ev = db.saveTask(ev);
            Assert.AreEqual(ev, db.getTask(ev.Id));
        }

        [TestMethod]
        public void DBTest_EditEvent()
        {
            string newName = "NewName";
            FakeDB db = new PRO_BYT_kalendarz.FakeDB();
            Event ev = new Event { Id = 1, Name = "Unit test1", Description = "unitTest1", Alarm = false, AlarmDate = new DateTime(2018, 10, 10, 10, 10, 10) };
            ev = db.saveTask(ev);
            ev.Name = newName;
            db.editTask(ev);
            Assert.AreEqual(newName, db.getTask(ev.Id).Name);
        }

        [TestMethod]
        public void DBTest_RemoveEvent()
        {
            FakeDB db = new PRO_BYT_kalendarz.FakeDB();
            Event ev = new Event { Id = 1, Name = "Unit test1", Description = "unitTest1", Alarm = false, AlarmDate = new DateTime(2018, 10, 10, 10, 10, 10) };
            ev = db.saveTask(ev);
            db.deleteTask(ev);
            foreach (Event tmpEvent in db.getAllTasks())
            {
                Assert.AreNotEqual(tmpEvent, ev);
            }
        }

        [TestMethod]
        public void DBTest_RemoveEvent2()
        {
            FakeDB db = new PRO_BYT_kalendarz.FakeDB();
            Event ev = new Event { Id = 1, Name = "Unit test1", Description = "unitTest1", Alarm = false, AlarmDate = new DateTime(2018, 10, 10, 10, 10, 10) };
            ev = db.saveTask(ev);
            db.deleteTask(ev.Id);
            foreach (Event tmpEvent in db.getAllTasks())
            {
                Assert.AreNotEqual(tmpEvent, ev);
            }
        }

        [TestMethod]
        public void DBTest_GetTask()
        {
            FakeDB db = new PRO_BYT_kalendarz.FakeDB();
            Event ev = new Event { Id = 1, Name = "Unit test1", Description = "unitTest1", Alarm = false, AlarmDate = new DateTime(2018, 10, 10, 10, 10, 10) };
            ev = db.saveTask(ev);
            Event recivedEvent = db.getTask(ev.Id);

            Assert.AreEqual(ev, recivedEvent);
        }

        [TestMethod]
        public void DBTest_GetAllTasks()
        {
            FakeDB db = new PRO_BYT_kalendarz.FakeDB();
            Event ev1 = new Event { Id = 1, Name = "Unit test1", Description = "unitTest1", Alarm = false, AlarmDate = new DateTime(2011, 10, 10, 10, 10, 10) };
            Event ev2 = new Event { Id = 2, Name = "Unit test2", Description = "unitTest2", Alarm = false, AlarmDate = new DateTime(2012, 10, 20, 20, 20, 20) };
            Event ev3 = new Event { Id = 3, Name = "Unit test3", Description = "unitTest3", Alarm = false, AlarmDate = new DateTime(2013, 10, 30, 20, 30, 30) };
            List<Event> events = new List<PRO_BYT_kalendarz.Event>();
            
            ev1 = db.saveTask(ev1);
            ev2 = db.saveTask(ev2);
            ev3 = db.saveTask(ev3);

            events.Add(ev1);
            events.Add(ev2);
            events.Add(ev3);

            foreach (Event tmpEvent in events)
            {
                Assert.AreEqual(tmpEvent, db.getTask(tmpEvent.Id));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO_BYT_kalendarz
{
    [Serializable()]
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Alarm { get; set; }
        public DateTime AlarmDate { get; set; }
    }
}

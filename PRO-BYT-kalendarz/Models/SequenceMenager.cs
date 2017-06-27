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
    [Serializable()]
    public class SequenceMenager : IDisposable
    {
        private static String fileName = "sequence.bin";
        private int sequence;

        public int getNextInt()
        {
            return ++sequence;
        }
        public SequenceMenager()
        {
            var seq = (int?)null;
            try
            {
                using (Stream stream = File.Open(fileName, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                   seq = ((SequenceMenager)bin.Deserialize(stream)).sequence;
                }
            }
            catch (IOException)
            {
            }
            if (seq != null)
            {
                sequence = (int)seq;
            }
            else
            {
                sequence = 0;
            }
        }
        private bool disposed = false;
        public void Dispose()
        {
            if (!disposed)
            {
                try
                {
                    using (Stream stream = File.Open(fileName, FileMode.Create))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        bin.Serialize(stream, this);
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

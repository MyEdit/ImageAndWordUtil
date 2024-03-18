using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WordUtil
{
    public class Medicines
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Storage { get; set; }
        public int Count { get; set; }
        public Image Photo { get; set; } = null;

        public Medicines(int ID, string Name, string Storage, int Count, Image Photo)
        {
            this.ID = ID;
            this.Name = Name;
            this.Storage = Storage;
            this.Count = Count;
            this.Photo = Photo;
        }

        public Medicines(string[] data)
        {
            ID = Convert.ToInt32(data[0]);
            Name = Convert.ToString(data[1]);
            Storage = Convert.ToString(data[2]);
            Count = Convert.ToInt32(data[3]);

            if (data[4] == null || data[4].Length == 0)
                return;

            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(data[4])))
            {
                Photo = Image.FromStream(ms);
            }
        }
    }
}

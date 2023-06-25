using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quran.Data
{
    public class Ayat
    {
        public int id { get; set; }
        public string name { get; set; }
        public string name_en { get; set; }
        public string name_translation { get; set; }
        public int words { get; set; }
        public int letters { get; set; }
        public string type { get; set; }
        public string type_en { get; set; }
        public string ar { get; set; }
        public string en { get; set; }
        public Array[] array { get; set; }
    }

    public class Array
    {
        public int id { get; set; }
        public string ar { get; set; }
        public string en { get; set; }
        public string filename { get; set; }
        public string path { get; set; }
        public string dir { get; set; }
        public int size { get; set; }
    }
}

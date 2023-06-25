using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quran.Data
{




    public class AzkarRoot
    {
        public string title { get; set; }
        public AzkarContent[] content { get; set; }
    }

    public class AzkarContent
    {
        public string zekr { get; set; }
        public int repeat { get; set; }
        public string bless { get; set; }
    }



}

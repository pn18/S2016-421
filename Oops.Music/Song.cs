using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.Music
{
    public class Song
    {
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
        public byte[] Data { get; set; }
    }
}

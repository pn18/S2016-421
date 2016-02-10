using System;
using System.Collections;

namespace Oops.Music
{
    public class Album
    {
        public Album()
        {
            Songs = new ArrayList();
        }

        public string Name { get; set; }
        public string Artist { get; set; }
        public string Label { get; set; }

        public ArrayList Songs { get; private set; }
    }
}

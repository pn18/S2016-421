using System;
using System.Collections;

namespace Oops.Music
{

    public class Mp3Player
    {
        ArrayList albums;

        public Mp3Player()
        {
            albums = new ArrayList();

            albums.Add(new Album { Name = "" });
            albums.Add("Hello");
        }

        public Album Find(string name)
        {
            for (int i = 0; i < albums.Count; i++)
            {
                var album = albums[i] as Album;
                if (album != null)
                {
                    if (album.Name == name)
                    {
                        return album;
                    }
                }
            }
            return null;
        }

        public void Play(Playlist playlist)
        {
            for (int i = 0; i < playlist.Songs.Count; i++)
            {
                Play(playlist.Songs[i] as Song);
                //Play((Song)playlist.Songs[i]);
            }

        }

        public void Play(Song song)
        {
            //TODO: Actually play the song.
        }
    
        public override string ToString()
        {
            return "My MP3 Player";
        }
    }
}

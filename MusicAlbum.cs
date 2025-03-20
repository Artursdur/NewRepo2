﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class MusicAlbum : Media
    {
        public string Artist { get; set; }
        public int TrackCount { get; set; }

        public MusicAlbum(string title, string author, int yearPublished, string artist, int trackCount)
            : base(title, author, yearPublished)
        {
            Artist = artist;
            TrackCount = trackCount;
        }
    }
}

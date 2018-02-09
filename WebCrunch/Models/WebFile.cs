﻿using System;
using System.Collections.Generic;

namespace Models
{
    /// <summary>
    /// Represents a Web File
    /// </summary>
    public partial class WebFile
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public long Size { get; set; } = 0;
        public DateTime DateUploaded { get; set; } = default(DateTime);
        public string Host { get; set; }
        public string URL { get; set; }

        public WebFile(string type, string name, long size, DateTime dateuploaded, string host, string url)
        {
            Type = type;
            Name = name;
            Size = size;
            DateUploaded = dateuploaded;
            Host = host;
            URL = url;
        }
    }
}

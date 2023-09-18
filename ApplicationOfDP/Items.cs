using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationOfDP
{
    public class Items
    {
        public string extension = "";
        public int _index;
    }
    public class Image : Items
    {
        public Image(string path)
        {
            FileInfo f = new FileInfo(path);
            extension = f.Extension;
            _index = 1;
        }
    }
    public class Word : Items
    {
        public Word(string path)
        {
            FileInfo f = new FileInfo(path);
            extension = f.Extension;
            _index = 2;
        }
    }
    public class Excel : Items
    {
        public Excel(string path)
        {
            FileInfo f = new FileInfo(path);
            extension = f.Extension;
            _index = 3;
        }
    }
    public class PowerPoint : Items
    {
        public PowerPoint(string path)
        {
            FileInfo f = new FileInfo(path);
            extension = f.Extension;
            _index = 4;
        }
    }
    public class Text : Items
    {
        public Text(string path)
        {
            FileInfo f = new FileInfo(path);
            extension = f.Extension;
            _index = 5;
        }
    }
    public class PDF : Items
    {
        public PDF(string path)
        {
            FileInfo f = new FileInfo(path);
            extension = f.Extension;
            _index = 6;
        }
    }
    public class UnKnown : Items
    {
        public UnKnown(string path)
        {
            extension = "unknown";
            _index = 7;
        }
    }
    public class Video : Items
    {
        public Video(string path)
        {
            FileInfo f = new FileInfo(path);
            extension = f.Extension;
            _index = 8;
        }
    }
}

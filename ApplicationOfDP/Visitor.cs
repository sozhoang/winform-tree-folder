using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationOfDP
{
    public class Visitor
    {
        public Items CreateObject(string path)
        {
            FileInfo f = new FileInfo(path);
            string ex = f.Extension;
            switch (ex)
            {
                case ".jpg":
                    {
                        return new Image(path);                     
                    }
                case ".png":
                    {
                        return new Image(path);
                    }
                case ".docx":
                    {
                        return new Word(path);
                    }
                case ".xlsx":
                    {
                        return new Excel(path);
                    }
                case ".pptx":
                    {
                        return new PowerPoint(path);
                    }
                case ".txt":
                    {
                        return new Text(path);
                    }
                case ".pdf":
                    {
                        return new PDF(path);
                    }
                case ".mp4":
                    {
                        return new Video(path);
                    }
                default:
                    return new UnKnown(path);
            }
        }
    }
}

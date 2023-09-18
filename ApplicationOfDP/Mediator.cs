using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationOfDP
{
    public class Mediator
    {
        public Dictionary<string, bool> _manager = new();
        public Mediator()
        {
            _manager[".jpg"] = false;
            _manager[".png"] = false;
            _manager[".mp4"] = false;
            _manager[".docx"] = false;
            _manager[".xlsx"] = false;
            _manager[".pdf"] = false;
            _manager["unknown"] = false;
            _manager[".txt"] = false;
            _manager[".pptx"] = false;
        }
        public void Notify(string sender)
        {
            if (sender == "unknown")
            {
                if (Program._form1._all)
                {
                    _manager["unknown"] = true;
                    _manager[".txt"] = true;
                    _manager[".jpg"] = true;
                    _manager[".png"] = true;
                    _manager[".mp4"] = true;
                    _manager[".docx"] = true;
                    _manager[".xlsx"] = true;
                    _manager[".pdf"] = true;
                    _manager[".pptx"] = true;
                    Program._form1._excel = true;
                    Program._form1._image = true;
                    Program._form1._video = true;
                    Program._form1._word = true;
                    Program._form1._pdf = true;
                }
                else
                {
                    _manager["unknown"] = false;
                    _manager[".txt"] = false;
                    _manager[".pptx"] = false;
                    Program._form1._excel = false;
                    Program._form1._image = false;
                    Program._form1._video = false;
                    Program._form1._word = false;
                    Program._form1._pdf = false;
                }
            }
            if (sender == ".jpg")
            {
                _manager[".jpg"] = Program._form1._image;
            }
            if (sender == ".png")
            {
                _manager[".png"] = Program._form1._image;
            }
            if (sender == ".mp4")
            {
                _manager[".mp4"] = Program._form1._video;
            }    
            if(sender == ".docx")
            {
                _manager[".docx"] = Program._form1._word;
            }    
            if(sender == ".xlsx")
            {
                _manager[".xlsx"] = Program._form1._excel;
            }    
            if(sender == ".pdf")
            {
                _manager[".pdf"] = Program._form1._pdf;
            }    
        }
    }
}


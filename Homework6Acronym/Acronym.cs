using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6Acronym
{
    public class Acronym
    {
        private string text;
        private string theAcronym;
        public string Text
        {
            get { return text; }
        }
        public string TheAcronym
        {
            get {
                string acro = "";
                bool nextAcro = true;
                for (int i = 0; i < text.Length; i++) 
                {
                    if (nextAcro==true && text[i]!=' ')
                    {
                        acro += text[i].ToString().ToUpper();
                        nextAcro = false;
                    }
                    if (text[i] == ' ') nextAcro = true;
                }
                theAcronym = acro;
                return acro;
                }
        }
        public Acronym(string text)
        {
            this.text = text;
        }
    }
}

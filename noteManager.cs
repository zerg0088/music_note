using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tempWindow
{
    class noteManager
    {
        private Form1 pform;
        public noteManager(Form1 p)
        {
            pform = p;

            note testNote = new note();
            testNote.Left = 20;
            testNote.Top = 100;

            pform.Controls.Add(testNote);

            
        }


    }
}

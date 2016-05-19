using GmailStructure.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GmailStructure.TempData;
using GmailStructure.Drivers;

namespace ConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GMailPage st = new GMailPage();

            st.EntryEmailAndGoToPasswordPage("qwe");

            
        }
    }
}

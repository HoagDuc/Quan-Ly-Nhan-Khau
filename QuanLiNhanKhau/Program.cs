using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLiNhanKhau
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
                
        public static Form FindOpenedForm(string name)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                    return f;
            }
            return null;
        }
    }
}

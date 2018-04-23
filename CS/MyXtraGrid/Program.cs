using DevExpress.Skins;
using DevExpress.XtraBars.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyXtraGrid {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SkinManager.EnableFormSkins();
            Application.Run(new Form1());
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;

static class Program
{
    /// <summary>
    /// The main entry point for a single instance application.
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {
        if ((args != null) && (args.Length > 0))
        {
            if (args[0].ToUpper() == "")
            {
                Globals.EDITION = Edition.Standard;
            }
            else if (args[0].ToUpper() == "G")
            {
                Globals.EDITION = Edition.Ultimate;
            }
            else if (args[0].ToUpper() == "R")
            {
                Globals.EDITION = Edition.Ultimate;
            }
            else if (args[0].ToUpper() == "U")
            {
                Globals.EDITION = Edition.Ultimate;
            }
            else
            {
                Globals.EDITION = Edition.Standard;
            }
        }
        else
        {
            if (Control.ModifierKeys == (Keys.Control | Keys.Shift))
            {
                Globals.EDITION = Edition.Ultimate;
            }
            else if (Control.ModifierKeys == Keys.Control)
            {
                Globals.EDITION = Edition.Ultimate;
            }
            else if (Control.ModifierKeys == Keys.Shift)
            {
                Globals.EDITION = Edition.Ultimate;
            }
            else // default
            {
                Globals.EDITION = Edition.Standard;
            }
        }

        switch (Globals.EDITION)
        {
            case Edition.Standard:
                {
                    Numbers.MAX_NUMBER = int.MaxValue / 256;
                }
                break;
            case Edition.Grammar:
                {
                    Numbers.MAX_NUMBER = int.MaxValue / 128;
                }
                break;
            case Edition.Research:
                {
                    Numbers.MAX_NUMBER = int.MaxValue / 64;
                }
                break;
            case Edition.Ultimate:
                {
                    Numbers.MAX_NUMBER = int.MaxValue / 32;
                }
                break;
            default:
                {
                    Numbers.MAX_NUMBER = int.MaxValue / 256;
                }
                break;
        }

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        MainForm form = new MainForm();
        Application.Run(form);
    }

    // single instance
    //static void Main()
    //{
    //    bool is_first_instance = true;
    //    using (Mutex mutex = new Mutex(true, Application.ProductName, out is_first_instance))
    //    {
    //        if (is_first_instance)
    //        {
    //            Application.EnableVisualStyles();
    //            Application.SetCompatibleTextRenderingDefault(false);
    //            Application.Run(new MainForm());
    //        }
    //        else
    //        {
    //            Windows windows = new Windows(true, true);
    //            foreach (Window window in windows)
    //            {
    //                if (window.Title == "Numbers")
    //                {
    //                    window.Visible = true;
    //                    //window.Activate();
    //                    window.BringToFront();
    //                }
    //            }
    //        }
    //    }
    //}
}
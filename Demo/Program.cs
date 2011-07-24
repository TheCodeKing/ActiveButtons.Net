/*=============================================================================
*
*	(C) Copyright 2011, Michael Carlisle (mike.carlisle@thecodeking.co.uk)
*
*   http://www.TheCodeKing.co.uk
*  
*	All rights reserved.
*	The code and information is provided "as-is" without waranty of any kind,
*	either expresed or implied.
*
*-----------------------------------------------------------------------------
*	History:
*		17/09/2007	Michael Carlisle				Version 1.0
*=============================================================================
*/
using System;
using System.Windows.Forms;

namespace TheCodeKing.ActiveDemo
{
    internal static class Program
    {
        /// <summary>
        /// 	The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ActiveDemo());
        }
    }
}
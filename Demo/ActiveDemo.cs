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
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using TheCodeKing.ActiveButtons.Controls;

namespace TheCodeKing.ActiveDemo
{
    /// <summary>
    /// 	Demo Windows Form which demonstrates adding buttons to the title bar using
    /// 	the ActiveButtons .Net code library.
    /// </summary>
    public partial class ActiveDemo : Form
    {
        /// <summary>
        /// 	Used to increment default button labels
        /// </summary>
        private int buttonInt = 1;

        /// <summary>
        /// 	Initializes a new instance of the <see cref = "ActiveDemo" /> class.
        /// </summary>
        public ActiveDemo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 	Raises the <see cref = "E:System.Windows.Forms.Form.Load"></see> event.
        /// </summary>
        /// <param name = "e">An <see cref = "T:System.EventArgs"></see> that contains the event data.</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            buttonText.Text = (buttonInt++).ToString();

            // Add an about button
            AddButton("About", AboutClick);
        }

        /// <summary>
        /// 	Handles click events on the menu buttons.
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void AddButtonClick(object sender, EventArgs e)
        {
            if (buttonText.Text.Length == 0)
            {
                errorLabel.Text = "Enter a button label";
            }
            else
            {
                AddButton(buttonText.Text, ButtonClick);
            }
        }

        /// <summary>
        /// 	Handles click events on the about button.
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void AboutClick(object sender, EventArgs e)
        {
            Process.Start("http://www.thecodeking.co.uk");
        }

        /// <summary>
        /// 	Helper method for adding items to the menu bar.
        /// </summary>
        /// <param name = "text"></param>
        /// <param name = "handler"></param>
        private void AddButton(string text, EventHandler handler)
        {
            // get an instance of IActiveMenu used to attach
            // buttons to the form
            IActiveMenu menu = ActiveMenu.GetInstance(this);

            // define a new button
            ActiveButton button = new ActiveButton();
            button.Text = text;
            menu.ToolTip.SetToolTip(button, "Tooltip " + button.Text);
            button.BackColor = colorSwitch.BackColor;
            button.Click += handler;

            // add the button to the menu
            menu.Items.Add(button);

            errorLabel.Text = "";
            buttonText.Text = (buttonInt++).ToString();
        }

        /// <summary>
        /// 	Handles the Click event of the title bar buttons.
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void ButtonClick(object sender, EventArgs e)
        {
            ActiveButton button = (ActiveButton) sender;
            label1.Text = string.Format("Button {0}", button.Text);
            if (button.BackColor == BackColor)
            {
                label1.ForeColor = Color.Black;
            }
            else
            {
                label1.ForeColor = button.BackColor;
            }
        }

        /// <summary>
        /// 	Handles the Click event of the colorPickerBtn control, to enable
        /// 	selection of a button color.
        /// </summary>
        /// <param name = "sender">The source of the event.</param>
        /// <param name = "e">The <see cref = "System.EventArgs" /> instance containing the event data.</param>
        private void ColorPickerButtonClick(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorSwitch.BackColor = colorDialog1.Color;
            }
        }

        /// <summary>
        /// 	Handles the removal of buttons from the menu bar.
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        private void RemoveButtonClick(object sender, EventArgs e)
        {
            IActiveMenu menu = ActiveMenu.GetInstance(this);
            if (menu.Items.Count > 0)
            {
                menu.Items.RemoveAt(menu.Items.Count - 1);
            }
        }
    }
}
namespace TheCodeKing.ActiveDemo
{
    partial class ActiveDemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.buttonText = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorPickerBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.colorSwitch = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(233, 21);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(63, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // buttonText
            // 
            this.buttonText.Location = new System.Drawing.Point(52, 23);
            this.buttonText.Name = "buttonText";
            this.buttonText.Size = new System.Drawing.Size(175, 20);
            this.buttonText.TabIndex = 2;
            // 
            // colorPickerBtn
            // 
            this.colorPickerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerBtn.Location = new System.Drawing.Point(12, 23);
            this.colorPickerBtn.Name = "colorPickerBtn";
            this.colorPickerBtn.Size = new System.Drawing.Size(34, 20);
            this.colorPickerBtn.TabIndex = 3;
            this.colorPickerBtn.Text = "Color";
            this.colorPickerBtn.UseVisualStyleBackColor = true;
            this.colorPickerBtn.Click += new System.EventHandler(this.ColorPickerButtonClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RemoveButtonClick);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(12, 50);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 5;
            // 
            // colorSwitch
            // 
            this.colorSwitch.Location = new System.Drawing.Point(52, 44);
            this.colorSwitch.Name = "colorSwitch";
            this.colorSwitch.Size = new System.Drawing.Size(175, 5);
            this.colorSwitch.TabIndex = 6;
            // 
            // ActiveDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 150);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.colorPickerBtn);
            this.Controls.Add(this.buttonText);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorSwitch);
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(320, 180);
            this.Name = "ActiveDemo";
            this.Text = "ActiveButtons Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox buttonText;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colorPickerBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Panel colorSwitch;

    }
}
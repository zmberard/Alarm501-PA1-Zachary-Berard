
namespace Alarm501
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.edit_Button = new System.Windows.Forms.Button();
            this.add_Button = new System.Windows.Forms.Button();
            this.snooze_Button = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.alarmGoingOFFTextBox = new System.Windows.Forms.TextBox();
            this.alarmListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // edit_Button
            // 
            this.edit_Button.Enabled = false;
            this.edit_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edit_Button.Location = new System.Drawing.Point(35, 36);
            this.edit_Button.Name = "edit_Button";
            this.edit_Button.Size = new System.Drawing.Size(126, 66);
            this.edit_Button.TabIndex = 0;
            this.edit_Button.Text = "Edit";
            this.edit_Button.UseVisualStyleBackColor = true;
            this.edit_Button.Click += new System.EventHandler(this.edit_Button_Click);
            // 
            // add_Button
            // 
            this.add_Button.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_Button.Location = new System.Drawing.Point(256, 36);
            this.add_Button.Name = "add_Button";
            this.add_Button.Size = new System.Drawing.Size(126, 66);
            this.add_Button.TabIndex = 1;
            this.add_Button.Text = "+";
            this.add_Button.UseVisualStyleBackColor = true;
            this.add_Button.Click += new System.EventHandler(this.add_Button_Click);
            // 
            // snooze_Button
            // 
            this.snooze_Button.Enabled = false;
            this.snooze_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.snooze_Button.Location = new System.Drawing.Point(35, 453);
            this.snooze_Button.Name = "snooze_Button";
            this.snooze_Button.Size = new System.Drawing.Size(126, 66);
            this.snooze_Button.TabIndex = 2;
            this.snooze_Button.Text = "Snooze";
            this.snooze_Button.UseVisualStyleBackColor = true;
            this.snooze_Button.Click += new System.EventHandler(this.snooze_Button_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stopButton.Location = new System.Drawing.Point(256, 453);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(126, 66);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // alarmGoingOFFTextBox
            // 
            this.alarmGoingOFFTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.alarmGoingOFFTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alarmGoingOFFTextBox.Enabled = false;
            this.alarmGoingOFFTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alarmGoingOFFTextBox.Location = new System.Drawing.Point(35, 413);
            this.alarmGoingOFFTextBox.Name = "alarmGoingOFFTextBox";
            this.alarmGoingOFFTextBox.Size = new System.Drawing.Size(347, 27);
            this.alarmGoingOFFTextBox.TabIndex = 4;
            this.alarmGoingOFFTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // alarmListBox
            // 
            this.alarmListBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alarmListBox.FormattingEnabled = true;
            this.alarmListBox.ItemHeight = 37;
            this.alarmListBox.Location = new System.Drawing.Point(35, 136);
            this.alarmListBox.Name = "alarmListBox";
            this.alarmListBox.Size = new System.Drawing.Size(347, 263);
            this.alarmListBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 562);
            this.Controls.Add(this.alarmListBox);
            this.Controls.Add(this.alarmGoingOFFTextBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.snooze_Button);
            this.Controls.Add(this.add_Button);
            this.Controls.Add(this.edit_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button edit_Button;
        private System.Windows.Forms.Button add_Button;
        private System.Windows.Forms.Button snooze_Button;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox alarmGoingOFFTextBox;
        private System.Windows.Forms.ListBox alarmListBox;
    }
}


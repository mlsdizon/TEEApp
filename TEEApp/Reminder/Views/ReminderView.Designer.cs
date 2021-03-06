﻿namespace TEEApp.Reminder.Views
{
    partial class ReminderView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblReminder = new Telerik.WinControls.UI.RadLabel();
            this.txtReminder = new Telerik.WinControls.UI.RadTextBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpReminderMeOn = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btnAddReminder = new Telerik.WinControls.UI.RadButton();
            this.lblRemindMeOn = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblReminder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReminder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReminderMeOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddReminder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRemindMeOn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReminder
            // 
            this.lblReminder.Location = new System.Drawing.Point(55, 24);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(68, 19);
            this.lblReminder.TabIndex = 0;
            this.lblReminder.Text = "Reminder : ";
            this.lblReminder.ThemeName = "Office2013Dark";
            // 
            // txtReminder
            // 
            this.txtReminder.AcceptsReturn = true;
            this.txtReminder.AutoSize = false;
            this.txtReminder.Location = new System.Drawing.Point(55, 49);
            this.txtReminder.Multiline = true;
            this.txtReminder.Name = "txtReminder";
            this.txtReminder.NullText = "Enter Reminder Here";
            this.txtReminder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReminder.Size = new System.Drawing.Size(414, 269);
            this.txtReminder.TabIndex = 2;
            this.txtReminder.ThemeName = "Office2013Dark";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(TEEAppModel.Employee);
            // 
            // dtpReminderMeOn
            // 
            this.dtpReminderMeOn.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpReminderMeOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReminderMeOn.Location = new System.Drawing.Point(157, 324);
            this.dtpReminderMeOn.Name = "dtpReminderMeOn";
            this.dtpReminderMeOn.Size = new System.Drawing.Size(164, 21);
            this.dtpReminderMeOn.TabIndex = 3;
            this.dtpReminderMeOn.TabStop = false;
            this.dtpReminderMeOn.Text = "08/07/2016 12:00 AM";
            this.dtpReminderMeOn.ThemeName = "Office2013Dark";
            this.dtpReminderMeOn.Value = new System.DateTime(2016, 7, 8, 0, 0, 0, 0);
            // 
            // btnAddReminder
            // 
            this.btnAddReminder.Location = new System.Drawing.Point(359, 351);
            this.btnAddReminder.Name = "btnAddReminder";
            this.btnAddReminder.Size = new System.Drawing.Size(110, 24);
            this.btnAddReminder.TabIndex = 4;
            this.btnAddReminder.Text = "Add Reminder";
            this.btnAddReminder.ThemeName = "Office2013Dark";
            this.btnAddReminder.Click += new System.EventHandler(this.btnAddReminder_Click);
            // 
            // lblRemindMeOn
            // 
            this.lblRemindMeOn.Location = new System.Drawing.Point(55, 325);
            this.lblRemindMeOn.Name = "lblRemindMeOn";
            this.lblRemindMeOn.Size = new System.Drawing.Size(96, 19);
            this.lblRemindMeOn.TabIndex = 4;
            this.lblRemindMeOn.Text = "Remind me on : ";
            this.lblRemindMeOn.ThemeName = "Office2013Dark";
            // 
            // ReminderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.lblRemindMeOn);
            this.Controls.Add(this.btnAddReminder);
            this.Controls.Add(this.dtpReminderMeOn);
            this.Controls.Add(this.txtReminder);
            this.Controls.Add(this.lblReminder);
            this.Name = "ReminderView";
            this.Size = new System.Drawing.Size(519, 382);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblReminder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReminder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReminderMeOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddReminder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRemindMeOn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lblReminder;
        private Telerik.WinControls.UI.RadTextBox txtReminder;
        private Telerik.WinControls.UI.RadDateTimePicker dtpReminderMeOn;
        private Telerik.WinControls.UI.RadButton btnAddReminder;
        private Telerik.WinControls.UI.RadLabel lblRemindMeOn;
        private System.Windows.Forms.BindingSource employeeBindingSource;
    }
}

namespace TEEApp.Base.Views
{
    partial class LoginView
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
            this.lblName = new Telerik.WinControls.UI.RadLabel();
            this.ddlEmployees = new Telerik.WinControls.UI.RadDropDownList();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLogin = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(25, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Employee Name: ";
            this.lblName.ThemeName = "Office2013Dark";
            // 
            // ddlEmployees
            // 
            this.ddlEmployees.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlEmployees.DataSource = this.employeeBindingSource;
            this.ddlEmployees.DisplayMember = "FullName";
            this.ddlEmployees.Location = new System.Drawing.Point(133, 45);
            this.ddlEmployees.Name = "ddlEmployees";
            this.ddlEmployees.NullText = "Enter Employee Name";
            this.ddlEmployees.Size = new System.Drawing.Size(157, 21);
            this.ddlEmployees.TabIndex = 1;
            this.ddlEmployees.ThemeName = "Office2013Dark";
            this.ddlEmployees.ValueMember = "Id";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(TEEAppModel.Employee);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(200, 121);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 24);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.ThemeName = "Office2013Dark";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.ddlEmployees);
            this.Controls.Add(this.lblName);
            this.Name = "LoginView";
            this.Size = new System.Drawing.Size(320, 200);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lblName;
        private Telerik.WinControls.UI.RadDropDownList ddlEmployees;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Telerik.WinControls.UI.RadButton btnLogin;
    }
}

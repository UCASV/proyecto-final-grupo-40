using System.ComponentModel;

namespace ProyectoFinal.View
{
    partial class frmEmployeeLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeLogin));
            this.tlpEmployee = new System.Windows.Forms.TableLayoutPanel();
            this.picLogoEmployee = new System.Windows.Forms.PictureBox();
            this.lblTextLogin1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserEmployee = new System.Windows.Forms.TextBox();
            this.txtPasswordEmployee = new System.Windows.Forms.TextBox();
            this.cmbCabin = new System.Windows.Forms.ComboBox();
            this.btnSolicitar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tlpEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picLogoEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpEmployee
            // 
            this.tlpEmployee.ColumnCount = 2;
            this.tlpEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEmployee.Controls.Add(this.picLogoEmployee, 0, 0);
            this.tlpEmployee.Controls.Add(this.lblTextLogin1, 0, 1);
            this.tlpEmployee.Controls.Add(this.label1, 0, 2);
            this.tlpEmployee.Controls.Add(this.label2, 0, 4);
            this.tlpEmployee.Controls.Add(this.label3, 1, 2);
            this.tlpEmployee.Controls.Add(this.txtUserEmployee, 0, 3);
            this.tlpEmployee.Controls.Add(this.txtPasswordEmployee, 0, 5);
            this.tlpEmployee.Controls.Add(this.cmbCabin, 1, 3);
            this.tlpEmployee.Controls.Add(this.btnSolicitar, 1, 5);
            this.tlpEmployee.Controls.Add(this.label4, 0, 6);
            this.tlpEmployee.Location = new System.Drawing.Point(0, 0);
            this.tlpEmployee.Name = "tlpEmployee";
            this.tlpEmployee.RowCount = 7;
            this.tlpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.12478F));
            this.tlpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.32689F));
            this.tlpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.557118F));
            this.tlpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.435852F));
            this.tlpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.151142F));
            this.tlpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.490334F));
            this.tlpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.73814F));
            this.tlpEmployee.Size = new System.Drawing.Size(608, 569);
            this.tlpEmployee.TabIndex = 0;
            // 
            // picLogoEmployee
            // 
            this.picLogoEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpEmployee.SetColumnSpan(this.picLogoEmployee, 2);
            this.picLogoEmployee.Image = ((System.Drawing.Image) (resources.GetObject("picLogoEmployee.Image")));
            this.picLogoEmployee.Location = new System.Drawing.Point(183, 32);
            this.picLogoEmployee.Name = "picLogoEmployee";
            this.picLogoEmployee.Size = new System.Drawing.Size(242, 170);
            this.picLogoEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoEmployee.TabIndex = 0;
            this.picLogoEmployee.TabStop = false;
            // 
            // lblTextLogin1
            // 
            this.lblTextLogin1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tlpEmployee.SetColumnSpan(this.lblTextLogin1, 2);
            this.lblTextLogin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTextLogin1.ForeColor = System.Drawing.Color.White;
            this.lblTextLogin1.Location = new System.Drawing.Point(20, 234);
            this.lblTextLogin1.Name = "lblTextLogin1";
            this.lblTextLogin1.Size = new System.Drawing.Size(568, 27);
            this.lblTextLogin1.TabIndex = 2;
            this.lblTextLogin1.Text = "Encargado de cabina - Inicio de Sesión";
            this.lblTextLogin1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "INGRESE SU USUARIO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "INGRESE SU CONTRASEÑA:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(307, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "SELECCIONE LA CABINA EN LA QUE TRABAJARA:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUserEmployee
            // 
            this.txtUserEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserEmployee.Location = new System.Drawing.Point(37, 327);
            this.txtUserEmployee.Name = "txtUserEmployee";
            this.txtUserEmployee.Size = new System.Drawing.Size(230, 20);
            this.txtUserEmployee.TabIndex = 7;
            // 
            // txtPasswordEmployee
            // 
            this.txtPasswordEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPasswordEmployee.Location = new System.Drawing.Point(37, 413);
            this.txtPasswordEmployee.Name = "txtPasswordEmployee";
            this.txtPasswordEmployee.PasswordChar = '*';
            this.txtPasswordEmployee.Size = new System.Drawing.Size(230, 20);
            this.txtPasswordEmployee.TabIndex = 8;
            this.txtPasswordEmployee.UseSystemPasswordChar = true;
            // 
            // cmbCabin
            // 
            this.cmbCabin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCabin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCabin.FormattingEnabled = true;
            this.cmbCabin.Location = new System.Drawing.Point(353, 326);
            this.cmbCabin.Name = "cmbCabin";
            this.cmbCabin.Size = new System.Drawing.Size(206, 21);
            this.cmbCabin.TabIndex = 9;
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSolicitar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (43)))), ((int) (((byte) (48)))), ((int) (((byte) (150)))));
            this.btnSolicitar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (43)))), ((int) (((byte) (48)))), ((int) (((byte) (150)))));
            this.btnSolicitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSolicitar.ForeColor = System.Drawing.Color.White;
            this.btnSolicitar.Location = new System.Drawing.Point(381, 407);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.Size = new System.Drawing.Size(150, 31);
            this.btnSolicitar.TabIndex = 19;
            this.btnSolicitar.Text = "INGRESAR";
            this.btnSolicitar.UseVisualStyleBackColor = false;
            this.btnSolicitar.Click += new System.EventHandler(this.btnSolicitar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 493);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 76);
            this.label4.TabIndex = 20;
            this.label4.Text = "© Copyright 2020. Presidencia de la República de El Salvador.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // frmEmployeeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (31)))), ((int) (((byte) (65)))), ((int) (((byte) (185)))));
            this.ClientSize = new System.Drawing.Size(609, 570);
            this.Controls.Add(this.tlpEmployee);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmployeeLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado - Inicio de Sesión";
            this.Load += new System.EventHandler(this.frmEmployeeLogin_Load);
            this.tlpEmployee.ResumeLayout(false);
            this.tlpEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picLogoEmployee)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Button btnSolicitar;

        private System.Windows.Forms.ComboBox cmbCabin;

        

        private System.Windows.Forms.TextBox txtPasswordEmployee;

        private System.Windows.Forms.TextBox txtUserEmployee;

        

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label lblTextLogin1;

        private System.Windows.Forms.PictureBox picLogoEmployee;

        

        private System.Windows.Forms.TableLayoutPanel tlpEmployee;

        

        #endregion
    }
}
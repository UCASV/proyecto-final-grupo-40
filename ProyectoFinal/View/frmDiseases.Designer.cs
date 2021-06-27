using System.ComponentModel;

namespace ProyectoFinal.View
{
    partial class frmDiseases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiseases));
            this.picLogoSv = new System.Windows.Forms.PictureBox();
            this.lblTextLogin2 = new System.Windows.Forms.Label();
            this.grpDiseases = new System.Windows.Forms.GroupBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chkDisease = new System.Windows.Forms.CheckBox();
            this.btnSolicitar = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.picLogoSv)).BeginInit();
            this.grpDiseases.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogoSv
            // 
            this.picLogoSv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLogoSv.Image = ((System.Drawing.Image) (resources.GetObject("picLogoSv.Image")));
            this.picLogoSv.Location = new System.Drawing.Point(149, 12);
            this.picLogoSv.Name = "picLogoSv";
            this.picLogoSv.Size = new System.Drawing.Size(128, 150);
            this.picLogoSv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoSv.TabIndex = 1;
            this.picLogoSv.TabStop = false;
            // 
            // lblTextLogin2
            // 
            this.lblTextLogin2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTextLogin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTextLogin2.ForeColor = System.Drawing.Color.White;
            this.lblTextLogin2.Location = new System.Drawing.Point(19, 178);
            this.lblTextLogin2.Name = "lblTextLogin2";
            this.lblTextLogin2.Size = new System.Drawing.Size(409, 63);
            this.lblTextLogin2.TabIndex = 3;
            this.lblTextLogin2.Text = "Si usted padece de alguna enfermedad crónica seleccione alguna/s de las casillas " + "\r\nsiguientes: ";
            this.lblTextLogin2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpDiseases
            // 
            this.grpDiseases.Controls.Add(this.checkBox7);
            this.grpDiseases.Controls.Add(this.checkBox6);
            this.grpDiseases.Controls.Add(this.checkBox5);
            this.grpDiseases.Controls.Add(this.checkBox3);
            this.grpDiseases.Controls.Add(this.checkBox2);
            this.grpDiseases.Controls.Add(this.checkBox4);
            this.grpDiseases.Controls.Add(this.checkBox1);
            this.grpDiseases.Controls.Add(this.chkDisease);
            this.grpDiseases.Location = new System.Drawing.Point(12, 244);
            this.grpDiseases.Name = "grpDiseases";
            this.grpDiseases.Size = new System.Drawing.Size(416, 188);
            this.grpDiseases.TabIndex = 4;
            this.grpDiseases.TabStop = false;
            // 
            // checkBox7
            // 
            this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox7.ForeColor = System.Drawing.Color.White;
            this.checkBox7.Location = new System.Drawing.Point(266, 120);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(124, 49);
            this.checkBox7.TabIndex = 14;
            this.checkBox7.Text = "Enfermedad del corazón";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox6.ForeColor = System.Drawing.Color.White;
            this.checkBox6.Location = new System.Drawing.Point(266, 87);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(124, 28);
            this.checkBox6.TabIndex = 13;
            this.checkBox6.Text = "Epilepsia";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox5.ForeColor = System.Drawing.Color.White;
            this.checkBox5.Location = new System.Drawing.Point(266, 53);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(124, 28);
            this.checkBox5.TabIndex = 12;
            this.checkBox5.Text = "VIH/SIDA";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox3.ForeColor = System.Drawing.Color.White;
            this.checkBox3.Location = new System.Drawing.Point(266, 19);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(124, 28);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "Demencia";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(50, 120);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(124, 28);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Diábetes";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox4.ForeColor = System.Drawing.Color.White;
            this.checkBox4.Location = new System.Drawing.Point(50, 86);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(124, 28);
            this.checkBox4.TabIndex = 9;
            this.checkBox4.Text = "Asma";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(50, 53);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 28);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Artritis";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chkDisease
            // 
            this.chkDisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.chkDisease.ForeColor = System.Drawing.Color.White;
            this.chkDisease.Location = new System.Drawing.Point(50, 19);
            this.chkDisease.Name = "chkDisease";
            this.chkDisease.Size = new System.Drawing.Size(124, 28);
            this.chkDisease.TabIndex = 0;
            this.chkDisease.Text = "Cáncer";
            this.chkDisease.UseVisualStyleBackColor = true;
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSolicitar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (43)))), ((int) (((byte) (48)))), ((int) (((byte) (150)))));
            this.btnSolicitar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (43)))), ((int) (((byte) (48)))), ((int) (((byte) (150)))));
            this.btnSolicitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSolicitar.ForeColor = System.Drawing.Color.White;
            this.btnSolicitar.Location = new System.Drawing.Point(252, 449);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.Size = new System.Drawing.Size(150, 35);
            this.btnSolicitar.TabIndex = 19;
            this.btnSolicitar.Text = "CONSULTAR";
            this.btnSolicitar.UseVisualStyleBackColor = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (43)))), ((int) (((byte) (48)))), ((int) (((byte) (150)))));
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (43)))), ((int) (((byte) (48)))), ((int) (((byte) (150)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(36, 449);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(150, 35);
            this.btnReturn.TabIndex = 20;
            this.btnReturn.Text = "REGRESAR";
            this.btnReturn.UseVisualStyleBackColor = false;
            // 
            // frmDiseases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (31)))), ((int) (((byte) (65)))), ((int) (((byte) (185)))));
            this.ClientSize = new System.Drawing.Size(440, 543);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSolicitar);
            this.Controls.Add(this.grpDiseases);
            this.Controls.Add(this.lblTextLogin2);
            this.Controls.Add(this.picLogoSv);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "frmDiseases";
            this.Text = "Registro - Área de enfermedades";
            ((System.ComponentModel.ISupportInitialize) (this.picLogoSv)).EndInit();
            this.grpDiseases.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnReturn;

        private System.Windows.Forms.Button btnSolicitar;
        

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox6;

        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox7;

        private System.Windows.Forms.CheckBox chkDisease;

        private System.Windows.Forms.GroupBox grpDiseases;

       

        private System.Windows.Forms.Label lblTextLogin2;

        private System.Windows.Forms.PictureBox picLogoSv;

        

        #endregion
    }
}
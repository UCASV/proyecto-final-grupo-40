using System.ComponentModel;

namespace ProyectoFinal.View
{
    partial class frmEmployeeCabin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeCabin));
            this.lblTextLogin1 = new System.Windows.Forms.Label();
            this.lblTextLogin2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSolicitar = new System.Windows.Forms.Button();
            this.btnVaccination = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTextLogin1
            // 
            this.lblTextLogin1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTextLogin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTextLogin1.ForeColor = System.Drawing.Color.White;
            this.lblTextLogin1.Location = new System.Drawing.Point(36, 50);
            this.lblTextLogin1.Name = "lblTextLogin1";
            this.lblTextLogin1.Size = new System.Drawing.Size(442, 33);
            this.lblTextLogin1.TabIndex = 2;
            this.lblTextLogin1.Text = "¡Bienvenido al gestor central!";
            this.lblTextLogin1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextLogin2
            // 
            this.lblTextLogin2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTextLogin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTextLogin2.ForeColor = System.Drawing.Color.White;
            this.lblTextLogin2.Location = new System.Drawing.Point(46, 104);
            this.lblTextLogin2.Name = "lblTextLogin2";
            this.lblTextLogin2.Size = new System.Drawing.Size(401, 19);
            this.lblTextLogin2.TabIndex = 3;
            this.lblTextLogin2.Text = "Seleccione qué operación desea realizar:";
            this.lblTextLogin2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Iniciar proceso de vacunación:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Paso 1.Seguimiento de citas/Prechequeo:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(129, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Paso 2. Fila de espera:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(144, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Paso 3. Vacunación:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(46, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Paso 4. Registro de Segunda dosis:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSolicitar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (43)))), ((int) (((byte) (48)))), ((int) (((byte) (150)))));
            this.btnSolicitar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (43)))), ((int) (((byte) (48)))), ((int) (((byte) (150)))));
            this.btnSolicitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSolicitar.ForeColor = System.Drawing.Color.White;
            this.btnSolicitar.Location = new System.Drawing.Point(336, 349);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.Size = new System.Drawing.Size(130, 28);
            this.btnSolicitar.TabIndex = 20;
            this.btnSolicitar.Text = "PASO 4";
            this.btnSolicitar.UseVisualStyleBackColor = false;
            this.btnSolicitar.Click += new System.EventHandler(this.btnSolicitar_Click);
            // 
            // btnVaccination
            // 
            this.btnVaccination.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVaccination.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (43)))), ((int) (((byte) (48)))), ((int) (((byte) (150)))));
            this.btnVaccination.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (43)))), ((int) (((byte) (48)))), ((int) (((byte) (150)))));
            this.btnVaccination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaccination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnVaccination.ForeColor = System.Drawing.Color.White;
            this.btnVaccination.Location = new System.Drawing.Point(336, 311);
            this.btnVaccination.Name = "btnVaccination";
            this.btnVaccination.Size = new System.Drawing.Size(130, 28);
            this.btnVaccination.TabIndex = 21;
            this.btnVaccination.Text = "PASO 3";
            this.btnVaccination.UseVisualStyleBackColor = false;
            this.btnVaccination.Click += new System.EventHandler(this.btnVaccination_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (43)))), ((int) (((byte) (48)))), ((int) (((byte) (150)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (43)))), ((int) (((byte) (48)))), ((int) (((byte) (150)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(336, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 28);
            this.button2.TabIndex = 22;
            this.button2.Text = "PASO 2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (43)))), ((int) (((byte) (48)))), ((int) (((byte) (150)))));
            this.btnCheck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (43)))), ((int) (((byte) (48)))), ((int) (((byte) (150)))));
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(336, 214);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(130, 28);
            this.btnCheck.TabIndex = 23;
            this.btnCheck.Text = "PASO 1";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (43)))), ((int) (((byte) (48)))), ((int) (((byte) (150)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (43)))), ((int) (((byte) (48)))), ((int) (((byte) (150)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(336, 171);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 28);
            this.button5.TabIndex = 25;
            this.button5.Text = "REALIZAR CITA";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (43)))), ((int) (((byte) (48)))), ((int) (((byte) (150)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (43)))), ((int) (((byte) (48)))), ((int) (((byte) (150)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(36, 412);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 28);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Salir";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmEmployeeCabin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (31)))), ((int) (((byte) (65)))), ((int) (((byte) (185)))));
            this.ClientSize = new System.Drawing.Size(517, 462);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnVaccination);
            this.Controls.Add(this.btnSolicitar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTextLogin2);
            this.Controls.Add(this.lblTextLogin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmployeeCabin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CABINA - Gestor Central";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmployeeCabin_FormClosing);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnVaccination;

        private System.Windows.Forms.Button btnCheck;

        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.Button button5;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button btnSolicitar;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label lblTextLogin2;

        private System.Windows.Forms.Label lblTextLogin1;

        

        #endregion
    }
}
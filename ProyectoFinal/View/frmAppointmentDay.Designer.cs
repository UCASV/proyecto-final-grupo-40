using System.ComponentModel;

namespace ProyectoFinal.View
{
    partial class frmAppointmentDay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppointmentDay));
            this.lblTextLogin1 = new System.Windows.Forms.Label();
            this.picLogoEmployee = new System.Windows.Forms.PictureBox();
            this.lblTextLogin2 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.dtpHour = new System.Windows.Forms.DateTimePicker();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTurnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.picLogoEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTextLogin1
            // 
            this.lblTextLogin1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTextLogin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTextLogin1.ForeColor = System.Drawing.Color.White;
            this.lblTextLogin1.Location = new System.Drawing.Point(26, 171);
            this.lblTextLogin1.Name = "lblTextLogin1";
            this.lblTextLogin1.Size = new System.Drawing.Size(502, 47);
            this.lblTextLogin1.TabIndex = 2;
            this.lblTextLogin1.Text = "¡Usted aplica para la vacuna del covid-19!";
            // 
            // picLogoEmployee
            // 
            this.picLogoEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLogoEmployee.Image = ((System.Drawing.Image) (resources.GetObject("picLogoEmployee.Image")));
            this.picLogoEmployee.Location = new System.Drawing.Point(156, 12);
            this.picLogoEmployee.Name = "picLogoEmployee";
            this.picLogoEmployee.Size = new System.Drawing.Size(220, 146);
            this.picLogoEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoEmployee.TabIndex = 3;
            this.picLogoEmployee.TabStop = false;
            // 
            // lblTextLogin2
            // 
            this.lblTextLogin2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTextLogin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTextLogin2.ForeColor = System.Drawing.Color.White;
            this.lblTextLogin2.Location = new System.Drawing.Point(-6, 208);
            this.lblTextLogin2.Name = "lblTextLogin2";
            this.lblTextLogin2.Size = new System.Drawing.Size(568, 19);
            this.lblTextLogin2.TabIndex = 4;
            this.lblTextLogin2.Text = "Selecciona el lugar, la fecha y la hora:";
            this.lblTextLogin2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "";
            this.dtpDate.Location = new System.Drawing.Point(101, 245);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(207, 20);
            this.dtpDate.TabIndex = 5;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "¿Desea generar un PDF con la información de su cita?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPdf
            // 
            this.btnPdf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPdf.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (43)))), ((int) (((byte) (48)))), ((int) (((byte) (150)))));
            this.btnPdf.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (43)))), ((int) (((byte) (48)))), ((int) (((byte) (150)))));
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnPdf.ForeColor = System.Drawing.Color.White;
            this.btnPdf.Location = new System.Drawing.Point(26, 401);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(150, 31);
            this.btnPdf.TabIndex = 22;
            this.btnPdf.Text = "Generar PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (43)))), ((int) (((byte) (48)))), ((int) (((byte) (150)))));
            this.btnContinue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (43)))), ((int) (((byte) (48)))), ((int) (((byte) (150)))));
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(387, 401);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(150, 31);
            this.btnContinue.TabIndex = 23;
            this.btnContinue.Text = "Guardar cita";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // dtpHour
            // 
            this.dtpHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHour.Location = new System.Drawing.Point(327, 245);
            this.dtpHour.Name = "dtpHour";
            this.dtpHour.Size = new System.Drawing.Size(106, 20);
            this.dtpHour.TabIndex = 24;
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(101, 317);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(341, 20);
            this.txtPlace.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(101, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Introduzca el lugar:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTurnBack
            // 
            this.btnTurnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTurnBack.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (43)))), ((int) (((byte) (48)))), ((int) (((byte) (150)))));
            this.btnTurnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (43)))), ((int) (((byte) (48)))), ((int) (((byte) (150)))));
            this.btnTurnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnTurnBack.ForeColor = System.Drawing.Color.White;
            this.btnTurnBack.Location = new System.Drawing.Point(206, 401);
            this.btnTurnBack.Name = "btnTurnBack";
            this.btnTurnBack.Size = new System.Drawing.Size(150, 31);
            this.btnTurnBack.TabIndex = 27;
            this.btnTurnBack.Text = "Volver al menu";
            this.btnTurnBack.UseVisualStyleBackColor = false;
            this.btnTurnBack.Click += new System.EventHandler(this.btnTurnBack_Click);
            // 
            // frmAppointmentDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (31)))), ((int) (((byte) (65)))), ((int) (((byte) (185)))));
            this.ClientSize = new System.Drawing.Size(549, 463);
            this.Controls.Add(this.btnTurnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.dtpHour);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblTextLogin2);
            this.Controls.Add(this.picLogoEmployee);
            this.Controls.Add(this.lblTextLogin1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAppointmentDay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CITA - Reservación";
            ((System.ComponentModel.ISupportInitialize) (this.picLogoEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnTurnBack;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox txtPlace;

        private System.Windows.Forms.DateTimePicker dtpDate;

        private System.Windows.Forms.Button btnContinue;

        private System.Windows.Forms.Button btnPdf;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.DateTimePicker dtpHour;

        private System.Windows.Forms.Label lblTextLogin2;

        private System.Windows.Forms.PictureBox picLogoEmployee;

        private System.Windows.Forms.Label lblTextLogin1;

        #endregion
    }
}
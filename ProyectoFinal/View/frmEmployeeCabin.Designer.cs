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
            this.tlpCabin = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tlpCabin
            // 
            this.tlpCabin.ColumnCount = 2;
            this.tlpCabin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCabin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCabin.Location = new System.Drawing.Point(2, 2);
            this.tlpCabin.Name = "tlpCabin";
            this.tlpCabin.RowCount = 5;
            this.tlpCabin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.17621F));
            this.tlpCabin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.82379F));
            this.tlpCabin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCabin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCabin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCabin.Size = new System.Drawing.Size(484, 489);
            this.tlpCabin.TabIndex = 0;
            // 
            // frmEmployeeCabin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (31)))), ((int) (((byte) (65)))), ((int) (((byte) (185)))));
            this.ClientSize = new System.Drawing.Size(490, 492);
            this.Controls.Add(this.tlpCabin);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEmployeeCabin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CABINA - Gestor Central";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmployeeCabin_FormClosing);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tlpCabin;


        #endregion
    }
}
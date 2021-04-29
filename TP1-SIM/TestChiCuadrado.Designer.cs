﻿namespace TP1_SIM
{
    partial class TestChiCuadrado
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
            this.mstxtMuestra = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb10 = new System.Windows.Forms.RadioButton();
            this.rb15 = new System.Windows.Forms.RadioButton();
            this.rb20 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(49, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamaño de la Muestra (N)";
            // 
            // mstxtMuestra
            // 
            this.mstxtMuestra.Location = new System.Drawing.Point(253, 67);
            this.mstxtMuestra.Mask = "99999";
            this.mstxtMuestra.Name = "mstxtMuestra";
            this.mstxtMuestra.Size = new System.Drawing.Size(59, 20);
            this.mstxtMuestra.TabIndex = 1;
            this.mstxtMuestra.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(49, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sub Intervalos (k)";
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(227, 117);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(31, 17);
            this.rb5.TabIndex = 3;
            this.rb5.TabStop = true;
            this.rb5.Text = "5";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb10
            // 
            this.rb10.AutoSize = true;
            this.rb10.Location = new System.Drawing.Point(287, 117);
            this.rb10.Name = "rb10";
            this.rb10.Size = new System.Drawing.Size(37, 17);
            this.rb10.TabIndex = 4;
            this.rb10.TabStop = true;
            this.rb10.Text = "10";
            this.rb10.UseVisualStyleBackColor = true;
            // 
            // rb15
            // 
            this.rb15.AutoSize = true;
            this.rb15.Location = new System.Drawing.Point(347, 117);
            this.rb15.Name = "rb15";
            this.rb15.Size = new System.Drawing.Size(37, 17);
            this.rb15.TabIndex = 5;
            this.rb15.TabStop = true;
            this.rb15.Text = "15";
            this.rb15.UseVisualStyleBackColor = true;
            // 
            // rb20
            // 
            this.rb20.AutoSize = true;
            this.rb20.Location = new System.Drawing.Point(407, 117);
            this.rb20.Name = "rb20";
            this.rb20.Size = new System.Drawing.Size(37, 17);
            this.rb20.TabIndex = 6;
            this.rb20.TabStop = true;
            this.rb20.Text = "20";
            this.rb20.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chi Cuadrado";
            // 
            // TestChiCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 574);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rb20);
            this.Controls.Add(this.rb15);
            this.Controls.Add(this.rb10);
            this.Controls.Add(this.rb5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mstxtMuestra);
            this.Controls.Add(this.label1);
            this.Name = "TestChiCuadrado";
            this.Text = "TestChiCuadrado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mstxtMuestra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb10;
        private System.Windows.Forms.RadioButton rb15;
        private System.Windows.Forms.RadioButton rb20;
        private System.Windows.Forms.Label label3;
    }
}
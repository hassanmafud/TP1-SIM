namespace TP1_SIM
{
    partial class Menu
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
            this.btnGenerarAlea = new System.Windows.Forms.Button();
            this.btnTestChi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerarAlea
            // 
            this.btnGenerarAlea.Location = new System.Drawing.Point(40, 218);
            this.btnGenerarAlea.Name = "btnGenerarAlea";
            this.btnGenerarAlea.Size = new System.Drawing.Size(195, 23);
            this.btnGenerarAlea.TabIndex = 0;
            this.btnGenerarAlea.Text = "Generar 20 Nº Aleatorios";
            this.btnGenerarAlea.UseVisualStyleBackColor = true;
            this.btnGenerarAlea.Click += new System.EventHandler(this.btnGenerarAlea_Click);
            // 
            // btnTestChi
            // 
            this.btnTestChi.Location = new System.Drawing.Point(296, 218);
            this.btnTestChi.Name = "btnTestChi";
            this.btnTestChi.Size = new System.Drawing.Size(195, 23);
            this.btnTestChi.TabIndex = 1;
            this.btnTestChi.Text = "Test de Chi Cuadrado";
            this.btnTestChi.UseVisualStyleBackColor = true;
            this.btnTestChi.Click += new System.EventHandler(this.btnTestChi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trabajo Practico 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Simulación";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 297);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTestChi);
            this.Controls.Add(this.btnGenerarAlea);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarAlea;
        private System.Windows.Forms.Button btnTestChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
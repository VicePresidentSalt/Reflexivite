namespace Reflexivite
{
    partial class Form_Parametres
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
            this.flp_Parametres = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Confirmer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flp_Parametres
            // 
            this.flp_Parametres.AutoSize = true;
            this.flp_Parametres.Location = new System.Drawing.Point(16, 9);
            this.flp_Parametres.Margin = new System.Windows.Forms.Padding(0);
            this.flp_Parametres.MaximumSize = new System.Drawing.Size(1048, 103);
            this.flp_Parametres.MinimumSize = new System.Drawing.Size(1048, 103);
            this.flp_Parametres.Name = "flp_Parametres";
            this.flp_Parametres.Size = new System.Drawing.Size(1048, 103);
            this.flp_Parametres.TabIndex = 0;
            // 
            // btn_Confirmer
            // 
            this.btn_Confirmer.AutoSize = true;
            this.btn_Confirmer.Location = new System.Drawing.Point(408, 141);
            this.btn_Confirmer.Name = "btn_Confirmer";
            this.btn_Confirmer.Size = new System.Drawing.Size(291, 23);
            this.btn_Confirmer.TabIndex = 1;
            this.btn_Confirmer.Text = "Confirmer";
            this.btn_Confirmer.UseVisualStyleBackColor = true;
            this.btn_Confirmer.Click += new System.EventHandler(this.btn_Confirmer_Click);
            // 
            // Form_Parametres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1073, 176);
            this.Controls.Add(this.btn_Confirmer);
            this.Controls.Add(this.flp_Parametres);
            this.MaximumSize = new System.Drawing.Size(1089, 214);
            this.MinimumSize = new System.Drawing.Size(1089, 214);
            this.Name = "Form_Parametres";
            this.Text = "Form_Parametres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_Parametres;
        private System.Windows.Forms.Button btn_Confirmer;
    }
}
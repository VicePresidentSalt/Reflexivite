namespace Reflexivite
{
    partial class FormReflex
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_Classes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userControl_Constructeurs = new Reflexivite.UserControl_Constructeurs();
            this.SuspendLayout();
            // 
            // cb_Classes
            // 
            this.cb_Classes.FormattingEnabled = true;
            this.cb_Classes.Location = new System.Drawing.Point(332, 12);
            this.cb_Classes.Name = "cb_Classes";
            this.cb_Classes.Size = new System.Drawing.Size(239, 21);
            this.cb_Classes.TabIndex = 0;
            this.cb_Classes.SelectedIndexChanged += new System.EventHandler(this.cb_Classes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Classes :";
            // 
            // userControl_Constructeurs
            // 
            this.userControl_Constructeurs.Location = new System.Drawing.Point(21, 38);
            this.userControl_Constructeurs.Name = "userControl_Constructeurs";
            this.userControl_Constructeurs.Size = new System.Drawing.Size(834, 433);
            this.userControl_Constructeurs.TabIndex = 2;
            // 
            // FormReflex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 476);
            this.Controls.Add(this.userControl_Constructeurs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Classes);
            this.MaximumSize = new System.Drawing.Size(914, 514);
            this.MinimumSize = new System.Drawing.Size(914, 514);
            this.Name = "FormReflex";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormReflex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Classes;
        private System.Windows.Forms.Label label1;
        private UserControl_Constructeurs userControl_Constructeurs;
    }
}


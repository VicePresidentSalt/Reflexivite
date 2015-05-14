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
            this.SuspendLayout();
            // 
            // cb_Classes
            // 
            this.cb_Classes.FormattingEnabled = true;
            this.cb_Classes.Location = new System.Drawing.Point(152, 12);
            this.cb_Classes.Name = "cb_Classes";
            this.cb_Classes.Size = new System.Drawing.Size(239, 21);
            this.cb_Classes.TabIndex = 0;
            // 
            // FormReflex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 383);
            this.Controls.Add(this.cb_Classes);
            this.Name = "FormReflex";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormReflex_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Classes;
    }
}


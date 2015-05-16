namespace Reflexivite
{
    partial class UserControl_Methodes
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Methodes = new System.Windows.Forms.ListBox();
            this.btn_Appliquer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÉTHODES";
            // 
            // listBox_Methodes
            // 
            this.listBox_Methodes.FormattingEnabled = true;
            this.listBox_Methodes.Location = new System.Drawing.Point(36, 44);
            this.listBox_Methodes.Name = "listBox_Methodes";
            this.listBox_Methodes.Size = new System.Drawing.Size(342, 329);
            this.listBox_Methodes.TabIndex = 2;
            // 
            // btn_Appliquer
            // 
            this.btn_Appliquer.Location = new System.Drawing.Point(98, 390);
            this.btn_Appliquer.Name = "btn_Appliquer";
            this.btn_Appliquer.Size = new System.Drawing.Size(221, 23);
            this.btn_Appliquer.TabIndex = 3;
            this.btn_Appliquer.Text = "Appliquer";
            this.btn_Appliquer.UseVisualStyleBackColor = true;
            // 
            // UserControl_Methodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Appliquer);
            this.Controls.Add(this.listBox_Methodes);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_Methodes";
            this.Size = new System.Drawing.Size(471, 433);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Methodes;
        private System.Windows.Forms.Button btn_Appliquer;
    }
}

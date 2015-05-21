namespace Reflexivite
{
    partial class UserControl_Constructeurs
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
            this.listBox_Constructeurs = new System.Windows.Forms.ListBox();
            this.btn_Construire = new System.Windows.Forms.Button();
            this.userControl_Methodes = new Reflexivite.UserControl_Methodes();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONSTRUCTEURS";
            // 
            // listBox_Constructeurs
            // 
            this.listBox_Constructeurs.FormattingEnabled = true;
            this.listBox_Constructeurs.Location = new System.Drawing.Point(21, 45);
            this.listBox_Constructeurs.Name = "listBox_Constructeurs";
            this.listBox_Constructeurs.Size = new System.Drawing.Size(395, 329);
            this.listBox_Constructeurs.TabIndex = 1;
            // 
            // btn_Construire
            // 
            this.btn_Construire.Location = new System.Drawing.Point(68, 380);
            this.btn_Construire.Name = "btn_Construire";
            this.btn_Construire.Size = new System.Drawing.Size(221, 23);
            this.btn_Construire.TabIndex = 2;
            this.btn_Construire.Text = "Construire";
            this.btn_Construire.UseVisualStyleBackColor = true;
            this.btn_Construire.Click += new System.EventHandler(this.btn_Construire_Click);
            // 
            // userControl_Methodes1
            // 
            this.userControl_Methodes.Location = new System.Drawing.Point(436, 0);
            this.userControl_Methodes.Name = "userControl_Methodes1";
            this.userControl_Methodes.Size = new System.Drawing.Size(471, 433);
            this.userControl_Methodes.TabIndex = 3;
            // 
            // UserControl_Constructeurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userControl_Methodes);
            this.Controls.Add(this.btn_Construire);
            this.Controls.Add(this.listBox_Constructeurs);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_Constructeurs";
            this.Size = new System.Drawing.Size(852, 433);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Constructeurs;
        private System.Windows.Forms.Button btn_Construire;
        private UserControl_Methodes userControl_Methodes;
    }
}

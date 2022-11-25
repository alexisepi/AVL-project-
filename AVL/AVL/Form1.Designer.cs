
namespace AVL
{
    partial class FormMain
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
            this.buttonMAJ = new System.Windows.Forms.Button();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.textBoxDpt = new System.Windows.Forms.TextBox();
            this.textBoxPoids = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMAJ
            // 
            this.buttonMAJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMAJ.Location = new System.Drawing.Point(71, 216);
            this.buttonMAJ.Name = "buttonMAJ";
            this.buttonMAJ.Size = new System.Drawing.Size(100, 60);
            this.buttonMAJ.TabIndex = 0;
            this.buttonMAJ.Text = "Mettre à jour";
            this.buttonMAJ.UseVisualStyleBackColor = true;
            this.buttonMAJ.Click += new System.EventHandler(this.buttonMAJ_Click);
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRechercher.Location = new System.Drawing.Point(210, 56);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(180, 60);
            this.buttonRechercher.TabIndex = 1;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // textBoxDpt
            // 
            this.textBoxDpt.Location = new System.Drawing.Point(71, 56);
            this.textBoxDpt.Name = "textBoxDpt";
            this.textBoxDpt.Size = new System.Drawing.Size(100, 20);
            this.textBoxDpt.TabIndex = 2;
            // 
            // textBoxPoids
            // 
            this.textBoxPoids.Location = new System.Drawing.Point(71, 108);
            this.textBoxPoids.Name = "textBoxPoids";
            this.textBoxPoids.Size = new System.Drawing.Size(100, 20);
            this.textBoxPoids.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Département";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Poids";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 288);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPoids);
            this.Controls.Add(this.textBoxDpt);
            this.Controls.Add(this.buttonRechercher);
            this.Controls.Add(this.buttonMAJ);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "AVL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMAJ;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.TextBox textBoxDpt;
        private System.Windows.Forms.TextBox textBoxPoids;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


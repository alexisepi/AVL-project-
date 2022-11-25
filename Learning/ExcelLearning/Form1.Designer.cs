
namespace ExcelLearning
{
    partial class Form1
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
            this.textBox_Chemin = new System.Windows.Forms.TextBox();
            this.button_rechercher = new System.Windows.Forms.Button();
            this.button_Ouvrir = new System.Windows.Forms.Button();
            this.groupBox_Tools = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_Fill = new System.Windows.Forms.GroupBox();
            this.textBox_FillTo = new System.Windows.Forms.TextBox();
            this.textBox_FillFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Fill = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSelectedContent = new System.Windows.Forms.Label();
            this.labelRepo = new System.Windows.Forms.Label();
            this.groupBox_Tools.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_Fill.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Chemin
            // 
            this.textBox_Chemin.Location = new System.Drawing.Point(12, 12);
            this.textBox_Chemin.Name = "textBox_Chemin";
            this.textBox_Chemin.Size = new System.Drawing.Size(643, 20);
            this.textBox_Chemin.TabIndex = 0;
            this.textBox_Chemin.TextChanged += new System.EventHandler(this.textBox_Chemin_TextChanged);
            // 
            // button_rechercher
            // 
            this.button_rechercher.Location = new System.Drawing.Point(661, 10);
            this.button_rechercher.Name = "button_rechercher";
            this.button_rechercher.Size = new System.Drawing.Size(128, 23);
            this.button_rechercher.TabIndex = 1;
            this.button_rechercher.Text = "Rechercher / Browse";
            this.button_rechercher.UseVisualStyleBackColor = true;
            this.button_rechercher.Click += new System.EventHandler(this.button_rechercher_Click);
            // 
            // button_Ouvrir
            // 
            this.button_Ouvrir.Location = new System.Drawing.Point(13, 39);
            this.button_Ouvrir.Name = "button_Ouvrir";
            this.button_Ouvrir.Size = new System.Drawing.Size(775, 23);
            this.button_Ouvrir.TabIndex = 2;
            this.button_Ouvrir.Text = "Ouvrir...";
            this.button_Ouvrir.UseVisualStyleBackColor = true;
            this.button_Ouvrir.Click += new System.EventHandler(this.button_Ouvrir_Click);
            // 
            // groupBox_Tools
            // 
            this.groupBox_Tools.Controls.Add(this.labelRepo);
            this.groupBox_Tools.Controls.Add(this.groupBox1);
            this.groupBox_Tools.Controls.Add(this.groupBox_Fill);
            this.groupBox_Tools.Location = new System.Drawing.Point(13, 69);
            this.groupBox_Tools.Name = "groupBox_Tools";
            this.groupBox_Tools.Size = new System.Drawing.Size(775, 369);
            this.groupBox_Tools.TabIndex = 3;
            this.groupBox_Tools.TabStop = false;
            this.groupBox_Tools.Text = "Outils";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelSelectedContent);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(186, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infos";
            // 
            // groupBox_Fill
            // 
            this.groupBox_Fill.Controls.Add(this.textBox_FillTo);
            this.groupBox_Fill.Controls.Add(this.textBox_FillFrom);
            this.groupBox_Fill.Controls.Add(this.label2);
            this.groupBox_Fill.Controls.Add(this.label1);
            this.groupBox_Fill.Controls.Add(this.button_Fill);
            this.groupBox_Fill.Location = new System.Drawing.Point(7, 20);
            this.groupBox_Fill.Name = "groupBox_Fill";
            this.groupBox_Fill.Size = new System.Drawing.Size(162, 100);
            this.groupBox_Fill.TabIndex = 0;
            this.groupBox_Fill.TabStop = false;
            this.groupBox_Fill.Text = "Remplir";
            // 
            // textBox_FillTo
            // 
            this.textBox_FillTo.Location = new System.Drawing.Point(52, 45);
            this.textBox_FillTo.Name = "textBox_FillTo";
            this.textBox_FillTo.Size = new System.Drawing.Size(100, 20);
            this.textBox_FillTo.TabIndex = 5;
            // 
            // textBox_FillFrom
            // 
            this.textBox_FillFrom.Location = new System.Drawing.Point(52, 17);
            this.textBox_FillFrom.Name = "textBox_FillFrom";
            this.textBox_FillFrom.Size = new System.Drawing.Size(100, 20);
            this.textBox_FillFrom.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "à :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "De :";
            // 
            // button_Fill
            // 
            this.button_Fill.Location = new System.Drawing.Point(10, 71);
            this.button_Fill.Name = "button_Fill";
            this.button_Fill.Size = new System.Drawing.Size(142, 23);
            this.button_Fill.TabIndex = 1;
            this.button_Fill.Text = "Remplir";
            this.button_Fill.UseVisualStyleBackColor = true;
            this.button_Fill.Click += new System.EventHandler(this.button_Fill_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Contenu de la cellule sélectionnée :";
            // 
            // labelSelectedContent
            // 
            this.labelSelectedContent.AutoSize = true;
            this.labelSelectedContent.Location = new System.Drawing.Point(189, 17);
            this.labelSelectedContent.Name = "labelSelectedContent";
            this.labelSelectedContent.Size = new System.Drawing.Size(0, 13);
            this.labelSelectedContent.TabIndex = 1;
            // 
            // labelRepo
            // 
            this.labelRepo.AutoSize = true;
            this.labelRepo.Location = new System.Drawing.Point(7, 127);
            this.labelRepo.Name = "labelRepo";
            this.labelRepo.Size = new System.Drawing.Size(0, 13);
            this.labelRepo.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_Tools);
            this.Controls.Add(this.button_Ouvrir);
            this.Controls.Add(this.button_rechercher);
            this.Controls.Add(this.textBox_Chemin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Tools.ResumeLayout(false);
            this.groupBox_Tools.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Fill.ResumeLayout(false);
            this.groupBox_Fill.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Chemin;
        private System.Windows.Forms.Button button_rechercher;
        private System.Windows.Forms.Button button_Ouvrir;
        private System.Windows.Forms.GroupBox groupBox_Tools;
        private System.Windows.Forms.GroupBox groupBox_Fill;
        private System.Windows.Forms.TextBox textBox_FillTo;
        private System.Windows.Forms.TextBox textBox_FillFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Fill;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSelectedContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelRepo;
    }
}


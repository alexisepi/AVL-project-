namespace Tarification_AVL
{
    partial class HOME
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxDpt = new System.Windows.Forms.TextBox();
            this.textBoxPoids = new System.Windows.Forms.TextBox();
            this.labelDpt = new System.Windows.Forms.Label();
            this.labelPoids = new System.Windows.Forms.Label();
            this.labelChoix = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(3, 345);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(190, 67);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Rechercher";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxDpt
            // 
            this.textBoxDpt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDpt.Location = new System.Drawing.Point(213, 75);
            this.textBoxDpt.Name = "textBoxDpt";
            this.textBoxDpt.Size = new System.Drawing.Size(204, 20);
            this.textBoxDpt.TabIndex = 1;
            // 
            // textBoxPoids
            // 
            this.textBoxPoids.Location = new System.Drawing.Point(213, 174);
            this.textBoxPoids.Name = "textBoxPoids";
            this.textBoxPoids.Size = new System.Drawing.Size(204, 20);
            this.textBoxPoids.TabIndex = 2;
            // 
            // labelDpt
            // 
            this.labelDpt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDpt.AutoSize = true;
            this.labelDpt.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDpt.Location = new System.Drawing.Point(3, 75);
            this.labelDpt.Name = "labelDpt";
            this.labelDpt.Size = new System.Drawing.Size(106, 21);
            this.labelDpt.TabIndex = 3;
            this.labelDpt.Text = "Département :";
            // 
            // labelPoids
            // 
            this.labelPoids.AutoSize = true;
            this.labelPoids.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoids.Location = new System.Drawing.Point(3, 171);
            this.labelPoids.Name = "labelPoids";
            this.labelPoids.Size = new System.Drawing.Size(55, 21);
            this.labelPoids.TabIndex = 4;
            this.labelPoids.Text = "Poids :";
            // 
            // labelChoix
            // 
            this.labelChoix.AutoSize = true;
            this.labelChoix.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoix.Location = new System.Drawing.Point(3, 0);
            this.labelChoix.Name = "labelChoix";
            this.labelChoix.Size = new System.Drawing.Size(197, 21);
            this.labelChoix.TabIndex = 5;
            this.labelChoix.Text = "Aucune information saisie...";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37F));
            this.tableLayoutPanel1.Controls.Add(this.labelChoix, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(435, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(374, 96);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labelDpt, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxDpt, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonSearch, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxPoids, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelPoids, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.MaximumSize = new System.Drawing.Size(420, 430);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(420, 415);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 463);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HOME";
            this.Text = "Tarification des transporteurs";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxDpt;
        private System.Windows.Forms.TextBox textBoxPoids;
        private System.Windows.Forms.Label labelDpt;
        private System.Windows.Forms.Label labelPoids;
        private System.Windows.Forms.Label labelChoix;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}


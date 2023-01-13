namespace Tarification_AVL
{
    partial class Form2
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonMain = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitre = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonMAJ = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonOpenFiles = new System.Windows.Forms.Button();
            this.labelT1 = new System.Windows.Forms.Label();
            this.labelT2 = new System.Windows.Forms.Label();
            this.labelT3 = new System.Windows.Forms.Label();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpenFile2 = new System.Windows.Forms.Button();
            this.buttonOpenFile3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.buttonMain);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(162, 469);
            this.panelMenu.TabIndex = 9;
            // 
            // buttonMain
            // 
            this.buttonMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMain.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMain.ForeColor = System.Drawing.Color.Transparent;
            this.buttonMain.Location = new System.Drawing.Point(0, 50);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(162, 58);
            this.buttonMain.TabIndex = 1;
            this.buttonMain.Text = "Fermer";
            this.buttonMain.UseVisualStyleBackColor = true;
            this.buttonMain.Click += new System.EventHandler(this.buttonMain_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.labelTitre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 51);
            this.panel1.TabIndex = 0;
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.Transparent;
            this.labelTitre.Location = new System.Drawing.Point(30, 4);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(93, 43);
            this.labelTitre.TabIndex = 0;
            this.labelTitre.Text = "AVL";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonMAJ, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(162, 388);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(717, 81);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // buttonMAJ
            // 
            this.buttonMAJ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMAJ.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.buttonMAJ.Location = new System.Drawing.Point(3, 3);
            this.buttonMAJ.Name = "buttonMAJ";
            this.buttonMAJ.Size = new System.Drawing.Size(711, 60);
            this.buttonMAJ.TabIndex = 0;
            this.buttonMAJ.Text = "Mettre à jour";
            this.buttonMAJ.UseVisualStyleBackColor = true;
            this.buttonMAJ.Click += new System.EventHandler(this.buttonMAJ_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 237F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 239F));
            this.tableLayoutPanel2.Controls.Add(this.buttonOpenFile3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonOpenFile2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonOpenFiles, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(162, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(717, 77);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // buttonOpenFiles
            // 
            this.buttonOpenFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOpenFiles.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.buttonOpenFiles.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenFiles.Name = "buttonOpenFiles";
            this.buttonOpenFiles.Size = new System.Drawing.Size(235, 71);
            this.buttonOpenFiles.TabIndex = 0;
            this.buttonOpenFiles.Text = "Fichier Transporteur 1";
            this.buttonOpenFiles.UseVisualStyleBackColor = true;
            this.buttonOpenFiles.Click += new System.EventHandler(this.buttonOpenFiles_Click);
            // 
            // labelT1
            // 
            this.labelT1.AutoSize = true;
            this.labelT1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.labelT1.ForeColor = System.Drawing.Color.Transparent;
            this.labelT1.Location = new System.Drawing.Point(3, 0);
            this.labelT1.Name = "labelT1";
            this.labelT1.Size = new System.Drawing.Size(323, 24);
            this.labelT1.TabIndex = 12;
            this.labelT1.Text = "Fichier Transporteur 1 : (Aucun)";
            // 
            // labelT2
            // 
            this.labelT2.AutoSize = true;
            this.labelT2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.labelT2.ForeColor = System.Drawing.Color.Transparent;
            this.labelT2.Location = new System.Drawing.Point(3, 114);
            this.labelT2.Name = "labelT2";
            this.labelT2.Size = new System.Drawing.Size(323, 24);
            this.labelT2.TabIndex = 13;
            this.labelT2.Text = "Fichier Transporteur 2 : (Aucun)";
            // 
            // labelT3
            // 
            this.labelT3.AutoSize = true;
            this.labelT3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.labelT3.ForeColor = System.Drawing.Color.Transparent;
            this.labelT3.Location = new System.Drawing.Point(3, 228);
            this.labelT3.Name = "labelT3";
            this.labelT3.Size = new System.Drawing.Size(323, 24);
            this.labelT3.TabIndex = 14;
            this.labelT3.Text = "Fichier Transporteur 3 : (Aucun)";
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            this.OFD.Title = "Ouvrir un fichier";
            // 
            // buttonOpenFile2
            // 
            this.buttonOpenFile2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOpenFile2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.buttonOpenFile2.Location = new System.Drawing.Point(244, 3);
            this.buttonOpenFile2.Name = "buttonOpenFile2";
            this.buttonOpenFile2.Size = new System.Drawing.Size(231, 71);
            this.buttonOpenFile2.TabIndex = 1;
            this.buttonOpenFile2.Text = "Fichier Transporteur 2";
            this.buttonOpenFile2.UseVisualStyleBackColor = true;
            this.buttonOpenFile2.Click += new System.EventHandler(this.buttonOpenFile2_Click);
            // 
            // buttonOpenFile3
            // 
            this.buttonOpenFile3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOpenFile3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.buttonOpenFile3.Location = new System.Drawing.Point(481, 3);
            this.buttonOpenFile3.Name = "buttonOpenFile3";
            this.buttonOpenFile3.Size = new System.Drawing.Size(233, 71);
            this.buttonOpenFile3.TabIndex = 2;
            this.buttonOpenFile3.Text = "Fichier Transporteur 3";
            this.buttonOpenFile3.UseVisualStyleBackColor = true;
            this.buttonOpenFile3.Click += new System.EventHandler(this.buttonOpenFile3_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.labelT1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelT3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelT2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(162, 77);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(717, 311);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(879, 469);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form2";
            this.Text = "Excel";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonMAJ;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonOpenFiles;
        private System.Windows.Forms.Label labelT1;
        private System.Windows.Forms.Label labelT2;
        private System.Windows.Forms.Label labelT3;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.Button buttonOpenFile3;
        private System.Windows.Forms.Button buttonOpenFile2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}
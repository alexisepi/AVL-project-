using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;
using System.Configuration;
using Microsoft.Office.Interop.Excel;

namespace Tarification_AVL
{
    public partial class Form2 : Form
    {

        string filename1;
        string filename2;
        string filename3;

        public Form2()
        {
            InitializeComponent();

            this.MinimumSize = new System.Drawing.Size(690, 260); // Taille minimale de la fenêtre en pixels
            this.MaximumSize = new System.Drawing.Size(1100, 670); // Taille minimale de la fenêtre en pixels
        }

        public void buttonOpenFiles_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.OFD.ShowDialog();
            if(dr == DialogResult.OK)
            {
                filename1 = this.OFD.FileName;
                labelT1.Text = "Fichier Transporteur 1 : " + filename1; ;
            }
        }

        public void buttonOpenFile2_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.OFD.ShowDialog();
            if (dr == DialogResult.OK)
            {
                filename2 = this.OFD.FileName;
                labelT2.Text = "Fichier Transporteur 2 : " + filename2; ;
            }
        }

        public void buttonOpenFile3_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.OFD.ShowDialog();
            if (dr == DialogResult.OK)
            {
                filename3 = this.OFD.FileName;
                labelT3.Text = "Fichier Transporteur 3 : " + filename3;
            }
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMAJ_Click(object sender, EventArgs e)
        {
            if(filename1 == null || filename2 == null || filename3 == null)
            {
                MessageBox.Show("Veuillez choisir tous les fichiers");
            }
            else
            {
                // Récupération de l'instance de l'application Excel
                Excel.Application excelApp = new Excel.Application();

                // Ouverture des fichiers Excel
                Excel.Workbook tarifxls = excelApp.Workbooks.Open("C:\\Users\\Mylan\\Documents\\Tarification AVL\\Tarifs.xlsx");

                Excel.Workbook transporteur1 = excelApp.Workbooks.Open(filename1);
                Excel.Workbook transporteur2 = excelApp.Workbooks.Open(filename2);
                Excel.Workbook transporteur3 = excelApp.Workbooks.Open(filename3);

                // Sélection de la première feuille de calcul
                Excel.Worksheet table1 = tarifxls.Worksheets[1];
                Excel.Worksheet table2 = tarifxls.Worksheets[2];
                Excel.Worksheet table3 = tarifxls.Worksheets[3];

                //Sélection table 1 dans les fichiers Transporteur
                Excel.Worksheet worksheet1 = transporteur1.Worksheets[1];
                Excel.Worksheet worksheet2 = transporteur2.Worksheets[1];
                Excel.Worksheet worksheet3 = transporteur3.Worksheets[1];

                object valeur1 = worksheet1.Cells[3, 3].Value;

                table1.Cells[3, 2].Value = valeur1;

                // Fermeture des fichier Excel
                tarifxls.Close();
                transporteur1.Close();
                transporteur2.Close();
                transporteur3.Close();
            }
        }
    }
}

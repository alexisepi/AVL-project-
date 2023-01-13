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

namespace Tarification_AVL
{
    public partial class HOME : Form
    {
        Thread th;

        public HOME()
        {
            InitializeComponent();

            this.MinimumSize = new System.Drawing.Size(690, 260); // Taille minimale de la fenêtre en pixels
            this.MaximumSize = new System.Drawing.Size(1100, 670); // Taille minimale de la fenêtre en pixels
        }

        public void openForm2(object obj)
        {
            Application.Run(new Form2());
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            th = new Thread(openForm2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            int columnNumber = 0;

            // Récupération de l'instance de l'application Excel
            Excel.Application excelApp = new Excel.Application();

            // Ouverture du fichier Excel
            Excel.Workbook workbook = excelApp.Workbooks.Open("C:\\Users\\Mylan\\Documents\\Tarification AVL\\Tarifs.xlsx");

            // Sélection de la première feuille de calcul
            Excel.Worksheet table1 = workbook.Worksheets[1];
            Excel.Worksheet table2 = workbook.Worksheets[2];
            Excel.Worksheet table3 = workbook.Worksheets[3];

            //excelApp.Visible = true;

            // Liste des départements de France dans l'ordre
            string[] departements = {
                "Ain", "Aisne", "Allier", "Alpes de Haute-Provence", "Hautes-Alpes", "Alpes-Maritimes", "Ardèche", "Ardennes",
                "Ariège", "Aube", "Aude", "Aveyron", "Bouches-du-Rhône", "Calvados", "Cantal", "Charente", "Charente-Maritime",
                "Cher", "Corrèze", "Corse-du-Sud", "Côte-d'Or", "Côtes d'Armor", "Creuse", "Dordogne", "Doubs",
                "Drôme", "Eure", "Eure-et-Loir", "Finistère", "Gard", "Haute-Garonne", "Gers", "Gironde", "Hérault", "Ille-et-Vilaine",
                "Indre", "Indre-et-Loire", "Isère", "Jura", "Landes", "Loir-et-Cher", "Loire", "Haute-Loire", "Loire-Atlantique", "Loiret",
                "Lot", "Lot-et-Garonne", "Lozère", "Maine-et-Loire", "Manche", "Marne", "Haute-Marne", "Mayenne", "Meurthe-et-Moselle", "Meuse",
                "Morbihan", "Moselle", "Nièvre", "Nord", "Oise", "Orne", "Pas-de-Calais", "Puy-de-Dôme", "Pyrénées-Atlantiques", "Hautes-Pyrénées",
                "Pyrénées-Orientales", "Bas-Rhin", "Haut-Rhin", "Rhône", "Haute-Saône", "Saône-et-Loire", "Sarthe", "Savoie", "Haute-Savoie", "Paris",
                "Seine-Maritime", "Seine-et-Marne", "Yvelines", "Deux-Sèvres", "Somme", "Tarn", "Tarn-et-Garonne", "Var", "Vaucluse", "Vendée", "Vienne",
                "Haute-Vienne", "Vosges", "Yonne", "Territoire de Belfort", "Essonne", "Hauts-de-Seine", "Seine-Saint-Denis", "Val-de-Marne", "Val-d'Oise"
            };

            // Déclarez une variable booléenne pour enregistrer si la valeur est un entier ou non
            bool isInteger = false;

            // Récupérez la valeur du textbox
            string value = textBoxDpt.Text;

            // Utilisez la méthode TryParse de la classe Int32 pour essayer de convertir la valeur en entier
            isInteger = Int32.TryParse(value, out int result);

            // Si la conversion a réussi, la variable isInteger sera égale à true, sinon elle sera égale à false
            if (isInteger)
            {
                int index = int.Parse(textBoxDpt.Text) - 1;
                if (index >= 0 && index < departements.Length)
                {
                    // Récupération de la valeur saisie dans le textBox
                    string textBoxValue = textBoxDpt.Text;

                    // Conversion de la valeur saisie en entier
                    int rowNumber = int.Parse(textBoxValue);

                    if (textBoxPoids.Text == "")
                    {
                        labelChoix.Text = $"Veuillez saisir le poids";
                    }
                    else if (textBoxPoids.Text != "")
                    {
                        float poids = Single.Parse(textBoxPoids.Text);

                        if (poids <= 9)
                        {
                            columnNumber = 2;
                        }
                        else if (poids <= 19)
                        {
                            columnNumber = 5;
                        }
                        else if (poids <= 29)
                        {
                            columnNumber = 8;
                        }
                        else if (poids <= 39)
                        {
                            columnNumber = 11;
                        }
                        else if (poids <= 49)
                        {
                            columnNumber = 14;
                        }
                        else if (poids <= 59)
                        {
                            columnNumber = 17;
                        }
                        else if (poids <= 69)
                        {
                            columnNumber = 20;
                        }
                        else if (poids <= 79)
                        {
                            columnNumber = 23;
                        }
                        else if (poids <= 100)
                        {
                            columnNumber = 26;
                        }
                        else if (poids <= 499)
                        {
                            columnNumber = 29;
                        }
                        else if (poids <= 750)
                        {
                            columnNumber = 32;
                        }

                        // Lecture de la valeur de la cellule Bx (x étant la ligne correspondant à la valeur saisie)
                        object value1 = table1.Cells[rowNumber + 2, columnNumber].Value;
                        object value2 = table2.Cells[rowNumber + 2, columnNumber].Value;
                        object value3 = table3.Cells[rowNumber + 2, columnNumber].Value;

                        float VAL1 = Convert.ToSingle(value1);
                        float VAL2 = Convert.ToSingle(value2);
                        float VAL3 = Convert.ToSingle(value3);

                        float min = Math.Min(Math.Min(VAL1, VAL2), VAL3);

                        // Si T1 est la plus petite
                        if (min == VAL1)
                        {
                            labelChoix.Text = $"Le meilleur transporteur pour le département de {departements[index]} sera le transporteur 1 : T1 : " + value1 + "€";
                        }
                        // Si T2 est la plus petite
                        else if (min == VAL2)
                        {
                            labelChoix.Text = $"Le meilleur transporteur pour le département de {departements[index]} sera le transporteur 2 : T2 : " + value2 + "€";
                        }
                        // Si T3 est la plus petite
                        else
                        {
                            labelChoix.Text = $"Le meilleur transporteur pour le département de {departements[index]} sera le transporteur 3 : T3 : " + value3 + "€";
                        }
                    }

                    // Fermeture du fichier Excel
                    workbook.Close();
                }
                else if (index >= 96)
                {
                    labelChoix.Text = $"Information saisie erronée";
                }
            }
            else
            {
                labelChoix.Text = $"Aucune information saisie...";
            }
        }
    }
}

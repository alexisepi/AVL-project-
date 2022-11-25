using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace ExcelLearning
{
    public partial class Form1 : Form
    {

        Excel.Application app;
        Excel.Workbooks wbooks;
        Excel.Workbook wbook;
        Timer cellChecker;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox_Tools.Enabled = false;
            cellChecker = new Timer();
            cellChecker.Tick += CellChecker_Tick;
            string filerepo = System.Configuration.ConfigurationManager.AppSettings["filerepo"];
            labelRepo.Text = filerepo;
        }

        private void CellChecker_Tick(object sender, EventArgs e)
        {
            try
            {
                labelSelectedContent.Text = app.Selection.Value;
            }
            catch(Exception)
            {
                 
            }
        }

        private void button_rechercher_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fichier avec les tableaux là chacal (*.xls;*.xlsx)|*.xls;*.xlsx";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                textBox_Chemin.Text = ofd.FileName;

            }
        }

        private void textBox_Chemin_TextChanged(object sender, EventArgs e)
        {
            button_Ouvrir.Enabled = textBox_Chemin.Text != "";
        }

        private void button_Ouvrir_Click(object sender, EventArgs e)
        {
            app = new Excel.Application();
            wbooks = app.Workbooks;
            wbook = wbooks.Open(textBox_Chemin.Text);
            app.Visible = true;
            groupBox_Tools.Enabled = true;
            cellChecker.Start();
        }

        private void button_Fill_Click(object sender, EventArgs e)
        {
            Excel._Worksheet wsheet = wbook.ActiveSheet;
            string from = textBox_FillFrom.Text;
            string to = textBox_FillTo.Text;

            int fromX = int.Parse(from.Split(',')[0]);
            int fromY = int.Parse(from.Split(',')[1]);

            int toX = int.Parse(to.Split(',')[0]);
            int toY = int.Parse(to.Split(',')[1]);

            for(int x = fromX; x <= toX; x++)
            {
                for(int y = fromY; y <= toY; y++)
                {
                    wsheet.Cells[x, y].Value = $"{x}*{y}={x*y}";
                }
            }
        }
    }
}

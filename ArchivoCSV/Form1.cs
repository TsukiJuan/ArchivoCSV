using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ArchivoCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos CSV|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var dataTable = new DataTable();
                var lines = File.ReadAllLines(openFileDialog.FileName);
                if (lines.Length > 0)
                {
                    // Añadir columnas al DataTable.
                    var columns = lines[0].Split(',');
                    foreach (var column in columns)
                    {
                        dataTable.Columns.Add(column);
                    }

                    // Añadir filas al DataTable.
                    for (int i = 1; i < lines.Length; i++)
                    {
                        var row = lines[i].Split(',');
                        dataTable.Rows.Add(row);
                    }
                }

                dtvUserData.DataSource = dataTable;
            }


        }

        private void btnTxl_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var dataTable = new DataTable();
                var lines = File.ReadAllLines(openFileDialog.FileName);
                if (lines.Length > 0)
                {
                    // Añadir columnas al DataTable.
                    var columns = lines[0].Split(',');
                    foreach (var column in columns)
                    {
                        dataTable.Columns.Add(column);
                    }

                    // Añadir filas al DataTable.
                    for (int i = 1; i < lines.Length; i++)
                    {
                        var row = lines[i].Split(',');
                        dataTable.Rows.Add(row);
                    }
                }

                dtvUserData.DataSource = dataTable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files (*.xml)|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Crea un nuevo DataSet
                DataSet dataSet = new DataSet();

                // Lee el archivo XML en el DataSet
                dataSet.ReadXml(filePath);

                // Asigna el DataSet como origen de datos del DataGridView
                dtvUserData.DataSource = dataSet.Tables[0];
            }
        }
        }
}

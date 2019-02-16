using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_BradKellogg
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();

            // populate search combobox
            List<Material> materials = Enum.GetValues(typeof(Material)).Cast<Material>().ToList();
            SearchComboBox.DataSource = materials;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void SearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // current combobox value
            Material mate = (Material)SearchComboBox.SelectedValue;
            string mat = mate.ToString();

            // MessageBox.Show("" + mate);

            // variable and List for search results
            string line = string.Empty;
            List<string> lines = new List<string>();

            if (File.Exists(@"quotes.txt"))
            {
                // read file quotes.txt, since quotes.json is broken
                // loop through lines in file
                using (StreamReader file = new StreamReader(@"quotes.txt"))
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        // MessageBox.Show(line);
                        // search for lines that match combobox value
                        if (line.Contains(mat))
                        {
                            // MessageBox.Show(line, mat);
                            // add said line to List of strings
                            lines.Add(line);
                            // ResultsBox.Items.Add(line);
                        }
                    }
                }
                ResultsBox.DataSource = lines;
            }
        }
    }
}

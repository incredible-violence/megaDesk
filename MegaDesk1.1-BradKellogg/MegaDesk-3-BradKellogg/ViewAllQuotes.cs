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
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();

            if (new FileInfo("quotes.txt").Length > 0)
            {
                List<string> lines = File
                    .ReadLines("quotes.txt")
                    .Select(line => line.TrimEnd('#'))
                    .ToList();
                quotesListBox.DataSource = lines;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {

        }
    }
}

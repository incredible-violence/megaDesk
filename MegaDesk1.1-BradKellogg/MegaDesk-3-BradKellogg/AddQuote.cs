using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_BradKellogg
{
    public partial class AddQuote : Form
    {
        Material mat;

        public AddQuote()
        {
            InitializeComponent();
            List<Material> materials = Enum.GetValues(typeof(Material)).Cast<Material>().ToList();
            materialComboBox.DataSource = materials;
            
        }

        private void AddQuoteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int spaceIndex = nameInput.Text.IndexOf(' ');
                string customer = nameInput.Text;
                int width = int.Parse(widthInput.Text);
                int depth = int.Parse(depthInput.Text);
                int drawers = int.Parse(drawersInput.Text);
                int rushD = int.Parse(rushComboBox.Text);
                mat = (Material)materialComboBox.SelectedValue;

                DeskQuote quote = new DeskQuote(width, depth, drawers, mat, rushD, customer);

                quote.outputToFile("quotes.txt", quote);
                quote.outputToJson("quotes.json", quote);
            }
            catch (Exception)
            {

            }

            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        public bool ValidWidth(string width, out string errorMessage)
        {
            int temp = 0;

            // Parsing failed
            if (!Int32.TryParse(width, out temp))
            {
                errorMessage = "Width must be a number between 24 - 96.";
                return false;
            }

            // Confirm that the width field is not empty.
            if (width.Length == 0)
            {
                errorMessage = "Width is required.";
                return false;
            }

            if (temp < 24)
            {
                errorMessage = "Width must be 24 - 96 inches.";
                return false;
            } else if (temp > 96)
            {
                errorMessage = "Width must be 24 - 96 inches.";
                return false;
            } else
            {
                errorMessage = "";
                return true;
            }
        }

        public bool ValidDepth(string depth, out string errorMessage)
        {
            int temp = 0;

            // Parsing failed
            if (!Int32.TryParse(depth, out temp))
            {
                errorMessage = "Depth must be a number between 12 - 48.";
                return false;
            }

            // Confirm that the depth field is not empty.
            if (depth.Length == 0)
            {
                errorMessage = "Depth is required.";
                return false;
            }

            if (temp < 12)
            {
                errorMessage = "Depth must be 12 - 48 inches.";
                return false;
            }
            else if (temp > 48)
            {
                errorMessage = "Depth must be 12 - 48 inches.";
                return false;
            }
            else
            {
                errorMessage = "";
                return true;
            }
        }

        public bool ValidDrawers(string drawers, out string errorMessage)
        {
            int temp = 0;

            // Parsing failed
            if (!Int32.TryParse(drawers, out temp))
            {
                errorMessage = "Number of drawers must be a number up to 7.";
                return false;
            }

            // Confirm that the height field is not empty.
            if (drawers.Length == 0)
            {
                errorMessage = "Number of drawers is required.";
                return false;
            }

            if (temp < 0)
            {
                errorMessage = "Number of drawers must be 0 - 7.";
                return false;
            }
            else if (temp > 7)
            {
                errorMessage = "Number of drawers must be 0 - 7.";
                return false;
            }
            else
            {
                errorMessage = "";
                return true;
            }
        }

        private void WidthInput_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidWidth(widthInput.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                widthInput.Select(0, widthInput.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.widthErrorProvider.SetError(widthInput, errorMsg);
            }
        }

        private void DepthInput_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidDepth(depthInput.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                depthInput.Select(0, depthInput.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.depthErrorProvider.SetError(depthInput, errorMsg);
            }
        }

        private void DrawersInput_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidDrawers(drawersInput.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                drawersInput.Select(0, drawersInput.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.drawersErrorProvider.SetError(drawersInput, errorMsg);
            }
        }

        private void WidthInput_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            widthErrorProvider.SetError(widthInput, "");
        }

        private void DepthInput_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            depthErrorProvider.SetError(depthInput, "");
        }

        private void DrawersInput_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            drawersErrorProvider.SetError(drawersInput, "");
        }

        private void HeightInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                heightInput.Text = heightInput.Text.Substring(0, heightInput.Text.Length - 1);
            }
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }
    }
}

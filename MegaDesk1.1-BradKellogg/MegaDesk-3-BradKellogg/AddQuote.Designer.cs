namespace MegaDesk_3_BradKellogg
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.addQuoteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.depthInput = new System.Windows.Forms.TextBox();
            this.widthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightInput = new System.Windows.Forms.TextBox();
            this.depthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.numDrawersLabel = new System.Windows.Forms.Label();
            this.drawersInput = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.rushOrderLabel = new System.Windows.Forms.Label();
            this.pageTitle = new System.Windows.Forms.Label();
            this.drawersErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialLabel = new System.Windows.Forms.Label();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.rushComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.widthErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawersErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // addQuoteButton
            // 
            this.addQuoteButton.AutoSize = true;
            this.addQuoteButton.BackColor = System.Drawing.SystemColors.Control;
            this.addQuoteButton.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.addQuoteButton.FlatAppearance.BorderSize = 2;
            this.addQuoteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addQuoteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addQuoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteButton.Location = new System.Drawing.Point(174, 292);
            this.addQuoteButton.Name = "addQuoteButton";
            this.addQuoteButton.Size = new System.Drawing.Size(121, 39);
            this.addQuoteButton.TabIndex = 8;
            this.addQuoteButton.Text = "Add Quote";
            this.addQuoteButton.UseVisualStyleBackColor = false;
            this.addQuoteButton.Click += new System.EventHandler(this.AddQuoteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.cancelButton.FlatAppearance.BorderSize = 2;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(371, 292);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(120, 39);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // widthInput
            // 
            this.widthInput.AcceptsReturn = true;
            this.widthInput.AcceptsTab = true;
            this.widthInput.AutoCompleteCustomSource.AddRange(new string[] {
            "Min 24 Max 36"});
            this.widthInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.widthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthInput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.widthInput.Location = new System.Drawing.Point(153, 126);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(163, 30);
            this.widthInput.TabIndex = 2;
            this.widthInput.Validating += new System.ComponentModel.CancelEventHandler(this.WidthInput_Validating);
            this.widthInput.Validated += new System.EventHandler(this.WidthInput_Validated);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(72, 129);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(63, 25);
            this.widthLabel.TabIndex = 4;
            this.widthLabel.Text = "Width";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(72, 179);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(64, 25);
            this.depthLabel.TabIndex = 5;
            this.depthLabel.Text = "Depth";
            // 
            // depthInput
            // 
            this.depthInput.AcceptsReturn = true;
            this.depthInput.AcceptsTab = true;
            this.depthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthInput.Location = new System.Drawing.Point(153, 176);
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(163, 30);
            this.depthInput.TabIndex = 3;
            this.depthInput.Validating += new System.ComponentModel.CancelEventHandler(this.DepthInput_Validating);
            this.depthInput.Validated += new System.EventHandler(this.DepthInput_Validated);
            // 
            // widthErrorProvider
            // 
            this.widthErrorProvider.ContainerControl = this;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.Location = new System.Drawing.Point(72, 229);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(68, 25);
            this.heightLabel.TabIndex = 7;
            this.heightLabel.Text = "Height";
            // 
            // heightInput
            // 
            this.heightInput.AcceptsReturn = true;
            this.heightInput.AcceptsTab = true;
            this.heightInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightInput.Location = new System.Drawing.Point(153, 226);
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(163, 30);
            this.heightInput.TabIndex = 4;
            this.heightInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightInput_KeyPress);
            // 
            // depthErrorProvider
            // 
            this.depthErrorProvider.ContainerControl = this;
            // 
            // numDrawersLabel
            // 
            this.numDrawersLabel.AutoSize = true;
            this.numDrawersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDrawersLabel.Location = new System.Drawing.Point(322, 129);
            this.numDrawersLabel.Name = "numDrawersLabel";
            this.numDrawersLabel.Size = new System.Drawing.Size(179, 25);
            this.numDrawersLabel.TabIndex = 10;
            this.numDrawersLabel.Text = "Number of Drawers";
            // 
            // drawersInput
            // 
            this.drawersInput.AcceptsReturn = true;
            this.drawersInput.AcceptsTab = true;
            this.drawersInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawersInput.Location = new System.Drawing.Point(507, 126);
            this.drawersInput.Name = "drawersInput";
            this.drawersInput.Size = new System.Drawing.Size(153, 30);
            this.drawersInput.TabIndex = 5;
            this.drawersInput.Validating += new System.ComponentModel.CancelEventHandler(this.DrawersInput_Validating);
            this.drawersInput.Validated += new System.EventHandler(this.DrawersInput_Validated);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(72, 79);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(64, 25);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "Name";
            // 
            // nameInput
            // 
            this.nameInput.AcceptsReturn = true;
            this.nameInput.AcceptsTab = true;
            this.nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.Location = new System.Drawing.Point(153, 76);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(200, 30);
            this.nameInput.TabIndex = 1;
            // 
            // rushOrderLabel
            // 
            this.rushOrderLabel.AutoSize = true;
            this.rushOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushOrderLabel.Location = new System.Drawing.Point(322, 229);
            this.rushOrderLabel.Name = "rushOrderLabel";
            this.rushOrderLabel.Size = new System.Drawing.Size(107, 25);
            this.rushOrderLabel.TabIndex = 16;
            this.rushOrderLabel.Text = "RushOrder";
            // 
            // pageTitle
            // 
            this.pageTitle.AutoSize = true;
            this.pageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitle.Location = new System.Drawing.Point(287, 21);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(123, 25);
            this.pageTitle.TabIndex = 17;
            this.pageTitle.Text = "Add a Quote";
            // 
            // drawersErrorProvider
            // 
            this.drawersErrorProvider.ContainerControl = this;
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel.Location = new System.Drawing.Point(322, 179);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(154, 25);
            this.materialLabel.TabIndex = 14;
            this.materialLabel.Text = "Surface Material";
            // 
            // materialComboBox
            // 
            this.materialComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.IntegralHeight = false;
            this.materialComboBox.ItemHeight = 24;
            this.materialComboBox.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.materialComboBox.Location = new System.Drawing.Point(507, 176);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(153, 32);
            this.materialComboBox.TabIndex = 6;
            // 
            // rushComboBox
            // 
            this.rushComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushComboBox.FormattingEnabled = true;
            this.rushComboBox.Items.AddRange(new object[] {
            "0",
            "3",
            "5",
            "7"});
            this.rushComboBox.Location = new System.Drawing.Point(507, 229);
            this.rushComboBox.Name = "rushComboBox";
            this.rushComboBox.Size = new System.Drawing.Size(153, 32);
            this.rushComboBox.TabIndex = 7;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.rushComboBox);
            this.Controls.Add(this.materialComboBox);
            this.Controls.Add(this.pageTitle);
            this.Controls.Add(this.rushOrderLabel);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.numDrawersLabel);
            this.Controls.Add(this.drawersInput);
            this.Controls.Add(this.heightInput);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addQuoteButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Quote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.widthErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawersErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addQuoteButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.TextBox depthInput;
        private System.Windows.Forms.ErrorProvider widthErrorProvider;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox heightInput;
        private System.Windows.Forms.ErrorProvider depthErrorProvider;
        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.Label rushOrderLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label numDrawersLabel;
        private System.Windows.Forms.TextBox drawersInput;
        private System.Windows.Forms.ErrorProvider drawersErrorProvider;
        private System.Windows.Forms.ComboBox materialComboBox;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.ComboBox rushComboBox;
    }
}
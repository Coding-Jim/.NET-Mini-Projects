namespace HomeWorkMiniProjectWinForms
{
    partial class AddressInfoUI
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
            numberTextBox = new TextBox();
            streetTextBox = new TextBox();
            numberLabel = new Label();
            streetLabel = new Label();
            postalCodeLabel = new Label();
            cityLabel = new Label();
            postalCodeTextBox = new TextBox();
            cityTextBox = new TextBox();
            saveAddressButton = new Button();
            SuspendLayout();
            // 
            // numberTextBox
            // 
            numberTextBox.Location = new Point(650, 230);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(137, 50);
            numberTextBox.TabIndex = 2;
            // 
            // streetTextBox
            // 
            streetTextBox.Location = new Point(243, 230);
            streetTextBox.Name = "streetTextBox";
            streetTextBox.Size = new Size(401, 50);
            streetTextBox.TabIndex = 1;
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new Point(650, 182);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(137, 45);
            numberLabel.TabIndex = 2;
            numberLabel.Text = "Number";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new Point(243, 182);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new Size(103, 45);
            streetLabel.TabIndex = 3;
            streetLabel.Text = "Street";
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new Point(243, 299);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new Size(189, 45);
            postalCodeLabel.TabIndex = 3;
            postalCodeLabel.Text = "Postal Code";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(438, 299);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(74, 45);
            cityLabel.TabIndex = 2;
            cityLabel.Text = "City";
            // 
            // postalCodeTextBox
            // 
            postalCodeTextBox.Location = new Point(243, 347);
            postalCodeTextBox.Name = "postalCodeTextBox";
            postalCodeTextBox.Size = new Size(189, 50);
            postalCodeTextBox.TabIndex = 3;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(438, 347);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(349, 50);
            cityTextBox.TabIndex = 4;
            // 
            // saveAddressButton
            // 
            saveAddressButton.Location = new Point(243, 446);
            saveAddressButton.Name = "saveAddressButton";
            saveAddressButton.Size = new Size(164, 72);
            saveAddressButton.TabIndex = 5;
            saveAddressButton.Text = "Save";
            saveAddressButton.UseVisualStyleBackColor = true;
            saveAddressButton.Click += SaveAddressButton_Click;
            // 
            // AddressInfoUI
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 682);
            Controls.Add(saveAddressButton);
            Controls.Add(cityTextBox);
            Controls.Add(postalCodeTextBox);
            Controls.Add(numberTextBox);
            Controls.Add(cityLabel);
            Controls.Add(streetTextBox);
            Controls.Add(postalCodeLabel);
            Controls.Add(numberLabel);
            Controls.Add(streetLabel);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "AddressInfoUI";
            Text = "Address Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numberTextBox;
        private TextBox streetTextBox;
        private Label numberLabel;
        private Label streetLabel;
        private Label postalCodeLabel;
        private Label cityLabel;
        private TextBox postalCodeTextBox;
        private TextBox cityTextBox;
        private Button saveAddressButton;
    }
}
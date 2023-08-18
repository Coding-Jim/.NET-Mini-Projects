namespace HomeWorkMiniProjectWinForms
{
    partial class PersonalInfoUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            addressListBox = new ListBox();
            addAddressButton = new Button();
            savePersonButton = new Button();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(92, 141);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(174, 45);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(92, 197);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(170, 45);
            lastNameLabel.TabIndex = 0;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(348, 141);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(296, 50);
            firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(348, 197);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(296, 50);
            lastNameTextBox.TabIndex = 2;
            // 
            // addressListBox
            // 
            addressListBox.FormattingEnabled = true;
            addressListBox.ItemHeight = 45;
            addressListBox.Location = new Point(92, 345);
            addressListBox.Name = "addressListBox";
            addressListBox.Size = new Size(994, 319);
            addressListBox.TabIndex = 4;
            addressListBox.TabStop = false;
            // 
            // addAddressButton
            // 
            addAddressButton.Location = new Point(92, 269);
            addAddressButton.Name = "addAddressButton";
            addAddressButton.Size = new Size(226, 70);
            addAddressButton.TabIndex = 3;
            addAddressButton.Text = "Add Address";
            addAddressButton.UseVisualStyleBackColor = true;
            addAddressButton.Click += AddAddressButton_Click;
            // 
            // savePersonButton
            // 
            savePersonButton.Location = new Point(92, 730);
            savePersonButton.Name = "savePersonButton";
            savePersonButton.Size = new Size(226, 70);
            savePersonButton.TabIndex = 4;
            savePersonButton.Text = "Save";
            savePersonButton.UseVisualStyleBackColor = true;
            savePersonButton.Click += SavePersonButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(337, 730);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(226, 70);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // PersonalInfoUI
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 1020);
            Controls.Add(deleteButton);
            Controls.Add(savePersonButton);
            Controls.Add(addAddressButton);
            Controls.Add(addressListBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "PersonalInfoUI";
            Text = "Personal Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private Button addAddressButton;
        private Button savePersonButton;
        public ListBox addressListBox;
        private Button deleteButton;
    }
}
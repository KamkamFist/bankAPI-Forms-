namespace bankAPI
{
    partial class Form1
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
            AccountNoTextBox = new TextBox();
            label1 = new Label();
            GetAccountButton = new Button();
            AccountDetailGroupBox = new GroupBox();
            label4 = new Label();
            AccountAmountTextBox = new TextBox();
            label3 = new Label();
            AccountNumerTextBox = new TextBox();
            AccountNameTextBox = new TextBox();
            label2 = new Label();
            AccountDetailGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // AccountNoTextBox
            // 
            AccountNoTextBox.Location = new Point(118, 6);
            AccountNoTextBox.Name = "AccountNoTextBox";
            AccountNoTextBox.Size = new Size(100, 23);
            AccountNoTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 1;
            label1.Text = "Numer Rachunku";
            label1.Click += label1_Click;
            // 
            // GetAccountButton
            // 
            GetAccountButton.Location = new Point(224, 6);
            GetAccountButton.Name = "GetAccountButton";
            GetAccountButton.Size = new Size(75, 23);
            GetAccountButton.TabIndex = 2;
            GetAccountButton.Text = "Pobierz dane";
            GetAccountButton.UseVisualStyleBackColor = true;
            GetAccountButton.Click += GetAccountData;
            // 
            // AccountDetailGroupBox
            // 
            AccountDetailGroupBox.Controls.Add(label4);
            AccountDetailGroupBox.Controls.Add(AccountAmountTextBox);
            AccountDetailGroupBox.Controls.Add(label3);
            AccountDetailGroupBox.Controls.Add(AccountNumerTextBox);
            AccountDetailGroupBox.Controls.Add(AccountNameTextBox);
            AccountDetailGroupBox.Controls.Add(label2);
            AccountDetailGroupBox.Location = new Point(18, 35);
            AccountDetailGroupBox.Name = "AccountDetailGroupBox";
            AccountDetailGroupBox.Size = new Size(297, 114);
            AccountDetailGroupBox.TabIndex = 3;
            AccountDetailGroupBox.TabStop = false;
            AccountDetailGroupBox.Text = "Rachunek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 83);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 5;
            label4.Text = "Kwota Rachunku: ";
            // 
            // AccountAmountTextBox
            // 
            AccountAmountTextBox.Location = new Point(113, 80);
            AccountAmountTextBox.Name = "AccountAmountTextBox";
            AccountAmountTextBox.Size = new Size(175, 23);
            AccountAmountTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 25);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 3;
            label3.Text = "Numer rachunku: ";
            // 
            // AccountNumerTextBox
            // 
            AccountNumerTextBox.Location = new Point(113, 22);
            AccountNumerTextBox.Name = "AccountNumerTextBox";
            AccountNumerTextBox.Size = new Size(175, 23);
            AccountNumerTextBox.TabIndex = 2;
            // 
            // AccountNameTextBox
            // 
            AccountNameTextBox.Location = new Point(113, 51);
            AccountNameTextBox.Name = "AccountNameTextBox";
            AccountNameTextBox.Size = new Size(175, 23);
            AccountNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 54);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 0;
            label2.Text = "Nazwa rachunku: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 161);
            Controls.Add(AccountDetailGroupBox);
            Controls.Add(GetAccountButton);
            Controls.Add(label1);
            Controls.Add(AccountNoTextBox);
            Name = "Form1";
            Text = "Form1";
            Load += OnAppLoad;
            AccountDetailGroupBox.ResumeLayout(false);
            AccountDetailGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AccountNoTextBox;
        private Label label1;
        private Button GetAccountButton;
        private GroupBox AccountDetailGroupBox;
        private Label label3;
        private TextBox AccountNumerTextBox;
        private TextBox AccountNameTextBox;
        private Label label2;
        private Label label4;
        private TextBox AccountAmountTextBox;
    }
}

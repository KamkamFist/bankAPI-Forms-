namespace bankAPI
{
    partial class NewTransfer
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TransferSourceTextBox = new TextBox();
            TransferTargetTextBox = new TextBox();
            TransferAmountTextBox = new TextBox();
            TranferButtonn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 96);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 0;
            label1.Text = "Rachunek źródłowy: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 125);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 1;
            label2.Text = "Rachunek docelowy: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(296, 154);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Kwota: ";
            // 
            // TransferSourceTextBox
            // 
            TransferSourceTextBox.Location = new Point(347, 93);
            TransferSourceTextBox.Name = "TransferSourceTextBox";
            TransferSourceTextBox.ReadOnly = true;
            TransferSourceTextBox.Size = new Size(100, 23);
            TransferSourceTextBox.TabIndex = 3;
            // 
            // TransferTargetTextBox
            // 
            TransferTargetTextBox.Location = new Point(347, 122);
            TransferTargetTextBox.Name = "TransferTargetTextBox";
            TransferTargetTextBox.Size = new Size(100, 23);
            TransferTargetTextBox.TabIndex = 4;
            // 
            // TransferAmountTextBox
            // 
            TransferAmountTextBox.Location = new Point(347, 151);
            TransferAmountTextBox.Name = "TransferAmountTextBox";
            TransferAmountTextBox.Size = new Size(100, 23);
            TransferAmountTextBox.TabIndex = 5;
            // 
            // TranferButtonn
            // 
            TranferButtonn.Location = new Point(223, 180);
            TranferButtonn.Name = "TranferButtonn";
            TranferButtonn.Size = new Size(224, 26);
            TranferButtonn.TabIndex = 6;
            TranferButtonn.Text = "Wykonaj przelew";
            TranferButtonn.UseVisualStyleBackColor = true;
            TranferButtonn.Click += TranferButtonn_Click;
            // 
            // NewTransfer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 328);
            Controls.Add(TranferButtonn);
            Controls.Add(TransferAmountTextBox);
            Controls.Add(TransferTargetTextBox);
            Controls.Add(TransferSourceTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NewTransfer";
            Text = "Form2";
            Load += NewTransfer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TransferSourceTextBox;
        private TextBox TransferTargetTextBox;
        private TextBox TransferAmountTextBox;
        private Button TranferButtonn;
    }
}
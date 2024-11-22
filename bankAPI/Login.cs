using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankAPI
{

     
    public partial class Login : Form
    {
        Form1 MainForm;
        public Login(Form1 mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private TableLayoutPanel tableLayoutPanel1;

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ExitButton = new Button();
            LoginButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(LoginTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(PasswordTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(ExitButton, 1, 3);
            tableLayoutPanel1.Controls.Add(LoginButton, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(860, 520);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Anchor = AnchorStyles.None;
            LoginTextBox.Location = new Point(433, 183);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(424, 23);
            LoginTextBox.TabIndex = 0;
            LoginTextBox.Text = "jkowalski@teb.pl";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.None;
            PasswordTextBox.Location = new Point(433, 313);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(424, 23);
            PasswordTextBox.TabIndex = 1;
            PasswordTextBox.Text = "321";
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(3, 130);
            label1.Name = "label1";
            label1.Size = new Size(424, 130);
            label1.TabIndex = 2;
            label1.Text = "E-mail: ";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(3, 260);
            label2.Name = "label2";
            label2.Size = new Size(424, 130);
            label2.TabIndex = 3;
            label2.Text = "Hasło: ";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label3, 2);
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(854, 130);
            label3.TabIndex = 4;
            label3.Text = "Logowanie";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExitButton
            // 
            ExitButton.Dock = DockStyle.Fill;
            ExitButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ExitButton.Location = new Point(433, 393);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(424, 124);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "Wyjdź";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButtonPressed;
            // 
            // LoginButton
            // 
            LoginButton.Dock = DockStyle.Fill;
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            LoginButton.Location = new Point(3, 393);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(424, 124);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Zaloguj";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButtonPressed;
            // 
            // Login
            // 
            ClientSize = new Size(860, 520);
            Controls.Add(tableLayoutPanel1);
            Name = "Login";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button ExitButton;
        private Button LoginButton;

        private void LoginButtonPressed(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;

            HttpClient client = new HttpClient();

            LoginRequest loginRequest = new LoginRequest(login, password);

            string url = "http://localhost/BankAPI/login/";

            var data = new
            {
                login = login,
                password = password
            };


            HttpResponseMessage response = client.PostAsJsonAsync(url, data).Result;

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                return;
                MessageBox.Show("Niepoprawne dane logowania");
            }   

            string json = response.Content.ReadAsStringAsync().Result;

            Token token = JsonConvert.DeserializeObject<Token>(json);

            MainForm.token = token.token;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ExitButtonPressed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

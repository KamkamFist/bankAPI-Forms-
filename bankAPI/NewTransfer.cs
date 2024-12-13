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
    public partial class NewTransfer : Form
    {
        public string token;
        public Form1 parent;
        public string source;
        public NewTransfer()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void NewTransfer_Load(object sender, EventArgs e)
        {
            TransferSourceTextBox.Text = source;
        }
        private void TranferButtonn_Click(object sender, EventArgs e)
        {
            string target = TransferTargetTextBox.Text;
            float userAmount = float.Parse(TransferAmountTextBox.Text);
            if (userAmount <= 0)
            {
                MessageBox.Show("Kwota przelewu musi być większa od 0");
                return;
            }
            int amount = (int)Math.Round(userAmount * 100);
            var data = new
            {
                token = token,
                source = source,
                target = target,
                amount = amount
            };
            TransferSourceTextBox.Text = source;
            string url = "http://localhost/bankAPI/transfer/new/";
            HttpClient client = new HttpClient();
            //odpowiedz od api
            HttpResponseMessage response =
                client.PostAsJsonAsync(url, data).Result;
            //jeśli odpowiedź jest OK to przelew się udał
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Przelew wykonany pomyślnie");
                parent.GetAccountData();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Błąd podczas wykonywania przelewu");
            }
        }
    }

}
       
 

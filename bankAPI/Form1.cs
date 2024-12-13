using BankApp;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace bankAPI
{
    public partial class Form1 : Form
    {
        public string token { get; set; } = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        public void setToken(Token t)
        {
            this.token = t.token;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void GetAccountData()
        {

            HttpClient client = new HttpClient();
            string url = "http://localhost/bankAPI/account/details/";
            var data = new { token = token };
            HttpResponseMessage response = client.PostAsJsonAsync(url, data).Result;
            string json = response.Content.ReadAsStringAsync().Result;
            AccountDetailsResponse accountDetailsResponse =
                JsonConvert.DeserializeObject<AccountDetailsResponse>(json);
            Account account = accountDetailsResponse.account;

            AccountNumerTextBox.Text = account.accountNo;
            AccountNameTextBox.Text = account.name.ToString();
            
            AccountAmountTextBox.Text = int.Parse(account.amount) / 100f + " PLN";
        }

        /// <summary>
        /// Method to get account data from API and fill the form with it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshData(object sender, EventArgs e)
        {
            GetAccountData();
        }
    
    

        private void OnAppLoad(object sender, EventArgs e)
        {
            Login loginForm = new Login(this);
            if (loginForm.ShowDialog(this) == DialogResult.OK)
            {
                //jeœli zalogowano poprawnie to poka¿ formularz
                this.Show();
                GetAccountData();
            }
            else
            {
                //jeœli nie to zamknij aplikacjê
                Application.Exit();
            }
        }

        private void OpenTranferButton_Click(object sender, EventArgs e)
        {
            NewTransfer transferForm = new NewTransfer();

            transferForm.token = token; 
            transferForm.parent = this;
            transferForm.source = AccountNumerTextBox.Text;

            transferForm.ShowDialog();
        }
    }
}
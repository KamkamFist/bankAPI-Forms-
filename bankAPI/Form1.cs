using Newtonsoft.Json;
using System.Net.Http.Json;

namespace bankAPI
{
    public partial class Form1 : Form
    {

        public string token;

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

        private void GetAccountData()
        {
            HttpClient client = new HttpClient();
            string url = "http://localhost/BankAPI/account/details";


            var data = new
            {
                token = token
            };

            HttpResponseMessage response = client.PostAsJsonAsync(url, data).Result;


            //wyciagamy dane z odpowiedzi w jsonie
            string json = response.Content.ReadAsStringAsync().Result;
            Account account = JsonConvert.DeserializeObject<Account>(json);//pamietaj zainstalowac Newtonsoft.Json
            AccountNumerTextBox.Text = account.accountNo;
            AccountNameTextBox.Text = account.name.ToString();
            AccountAmountTextBox.Text = account.amount.ToString();
            //wyœwietlamy dane w textboxach

        }

        private void OnAppLoad(object sender, EventArgs e)
        {
            Login loginForm = new Login(this);
            if (loginForm.ShowDialog(this) == DialogResult.OK)
            {
                //je?li zalogowano poprawnie to poka? formularz
                this.Show();
                GetAccountData();
            }
            else
            {
                //je?li nie to zamknij aplikacj?
                Application.Exit();
            }
        }

        private void OpenTranferButton_Click(object sender, EventArgs e)
        {
            NewTransfer transferForm = new NewTransfer();

            transferForm.token = token;
            transferForm.source = AccountNumerTextBox.Text;

            transferForm.ShowDialog();
        }
    }
}
using Newtonsoft.Json;

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
            this.token = t;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GetAccountData(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string url = "http://localhost/BankAPI/account/";
            url += AccountNoTextBox.Text;//dopisz numer konta fo adresu
            HttpResponseMessage response = client.GetAsync(url).Result;

            //wyciagamy dane z odpowiedzi w jsonie
            string json = response.Content.ReadAsStringAsync().Result;
            Account account = JsonConvert.DeserializeObject<Account>(json);//pamietaj zainstalowac Newtonsoft.Json
            AccountNumerTextBox.Text = account.accountNo;
            AccountNameTextBox.Text = account.name.ToString();
            AccountAmountTextBox.Text = account.amount.ToString();
            //wyświetlamy dane w textboxach

        }

        private void OnAppLoad(object sender, EventArgs e)
        {
            Login loginForm = new Login(this);
            if (loginForm.ShowDialog(this) == DialogResult.OK)
            {
                //je?li zalogowano poprawnie to poka? formularz
                this.Show();
            }
            else
            {
                //je?li nie to zamknij aplikacj?
                Application.Exit();
            }
        }
    }
}
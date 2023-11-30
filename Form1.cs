namespace Kassaapparat_app
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        string username = "Safa";
        string password = "safa23is";

        private void kassaButton2_Click(object sender, EventArgs e)
        {
            if (kassaNameBox.Text == username && kassaPassaBox.Text == password)
            {
                resultlabel3.Text = "Du är loggad!";

                Form2 form2 = new Form2(this);
                form2.Show();

            }
            else
            {
                resultlabel3.Text = "Invalid credentials";

            }
            kassaPassaBox.Text = "";

        }
        public void SetUsernameAndPassword(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        private void kassaregisterbutton_Click(object sender, EventArgs e)
        {
            KassaRegister kassaRegister = new KassaRegister();
            kassaRegister.Form1 = this;
            kassaRegister.Show();

        }
    }



    }

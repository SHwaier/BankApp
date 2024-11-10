namespace BankApp
{
    public partial class Form1 : Form
    {
        Person person;
        Account account;
        Bank bank;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void changeMenu(UserControl control, Panel container)
        {
            container.Controls.Clear();
            control.Dock = DockStyle.Fill;
            container.Controls.Add(control);
        }

        private void overviewBtn_Click(object sender, EventArgs e)
        {
            changeMenu(new OverviewMenu(), mainContainer);
        }

        private void actionsBtn_Click(object sender, EventArgs e)
        {
            changeMenu(new ActionsMenu(), mainContainer);

        }
        private void settingsBtn_Click(object sender, EventArgs e)
        {
            changeMenu(new SettingsMenu(), mainContainer);

        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {

        }


    }
}

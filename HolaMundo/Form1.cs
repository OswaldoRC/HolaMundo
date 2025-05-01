using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HolaMundo
{
    public partial class formValidatePassword : Form
    {
        public formValidatePassword()
        {
            InitializeComponent();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            // 2 second delay to show progress bar
            await Task.Delay(2000);
            bool isValid = Regex.IsMatch(txtPass.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$");
            if (txtPass.Text == txtConfirmPassword.Text && isValid)
            {
                // Open a message for validation ok
                MessageBox.Show("Password is valid");
            }
            else
            {
                MessageBox.Show("Password is not valid");
            }
            progressBar1.Visible = false;
        }
    }
}

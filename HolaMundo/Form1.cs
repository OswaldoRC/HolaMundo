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
            // Show progress bar
            progressBar1.Visible = true;
            // 2 second delay to show progress bar
            await Task.Delay(2000);
            /*
             * Regex password validation
             * - At least one lowercase letter
             * - At least one uppercase letter
             * - At least one digit
             * - At least one special character
             */
            bool isValid = Regex.IsMatch(txtPass.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$");
            // Check if both passwords are the same and if matches the pattern
            if (txtPass.Text == txtConfirmPassword.Text && isValid)
            {
                // Open a message for validation ok
                MessageBox.Show("Password is valid");
            }
            else
            {
                // Open a message for validation not ok
                MessageBox.Show("Password is not valid");
            }
            // Hide progress bar
            progressBar1.Visible = false;
        }
    }
}

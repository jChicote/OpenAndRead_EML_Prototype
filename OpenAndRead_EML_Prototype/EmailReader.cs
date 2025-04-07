using MimeKit;

namespace OpenAndRead_EML_Prototype
{
    public partial class EmailReader : Form
    {

        #region - - - - - - Constructors - - - - - -

        public EmailReader()
        {
            InitializeComponent();

            // Bind events
            this.selectEmailButton.Click += this.selectEmailButton_Click;
        }

        #endregion Constructors

        #region - - - - - - Event Handlers - - - - - -

        private void selectEmailButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog _OpenFileDialog = new OpenFileDialog();
            _OpenFileDialog.Filter = "Email Files (*.eml)|*.eml";

            if (_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                var _Email = this.ExtractEmailDetails(_OpenFileDialog);
                this.SetEmailDisplay(_Email);
            }
        }

        #endregion Event Handlers

        #region - - - - - - Methods - - - - - -

        private EmailModel ExtractEmailDetails(OpenFileDialog openedFile)
        {
            string _FilePath = openedFile.FileName;
            var _Email = new EmailModel();

            try
            {
                var _Message = MimeMessage.Load(_FilePath);

                _Email.From = _Message.From.Any()
                    ? string.Join(",", _Message.From.Select(r => r.ToString()))
                    : "";
                _Email.To = _Message.To.Any()
                    ? string.Join(",", _Message.To.Select(r => r.ToString()))
                    : "";
                _Email.Bcc = _Message.Bcc.Any()
                    ? string.Join(",", _Message.Bcc.Select(r => r.ToString()))
                    : "";
                _Email.Cc = _Message.Cc.Any()
                    ? string.Join(",", _Message.Cc.Select(r => r.ToString()))
                    : "";

                _Email.Subject = _Message.Subject;

                if (_Message.HtmlBody != null)
                    _Email.Body = _Message.HtmlBody;
                else if (_Message.TextBody != null)
                    _Email.Body = _Message.TextBody;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading EML file: " + ex.Message);
            }

            return _Email;
        }

        private void SetEmailDisplay(EmailModel model)
        {
            this.fromTextBox.Text = model.From;
            this.toTextBox.Text = model.To;
            this.bccTextBox.Text = model.Bcc;
            this.ccTextBox.Text = model.Cc;

            this.subjectTextBox.Text = model.Subject;
            this.messageBodyTextBox.Text = model.Body;
        }

        #endregion Methods

    }

}

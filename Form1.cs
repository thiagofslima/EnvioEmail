using System.Net;
using System.Net.Mail;

namespace EnvioEmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                string smtpServer = "smtp.gmail.com";
                int smtpPort = 587;

                if (!ValidarForm())
                    return;

                using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
                {
                    smtpClient.Credentials = new NetworkCredential(txtRemetente.Text, txtSenha.Text);
                    smtpClient.EnableSsl = true;

                    using (MailMessage mailMessage = new MailMessage(txtRemetente.Text, txtDestinatario.Text, txtAssunto.Text, txtMensagem.Text))
                    {
                        smtpClient.Send(mailMessage);
                        MessageBox.Show("E-mail enviado com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao enviar e-mail: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarForm()
        {
            if (string.IsNullOrWhiteSpace(txtRemetente.Text))
            {
                MessageBox.Show("Remetente em branco");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Senha em branco");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDestinatario.Text))
            {
                MessageBox.Show("Destinatário em branco");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAssunto.Text))
            {
                MessageBox.Show("Assunto em branco");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMensagem.Text))
            {
                MessageBox.Show("Mensagem em branco");
                return false;
            }

            return true;
        }
    }
}

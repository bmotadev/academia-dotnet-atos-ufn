namespace WinFormsAppAula15
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonGerarEmail_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Botão gerar email foi clicado");


            string[] vetorNome = textBoxNomeJogador.Text.Split(' ');
            string nomeFormatado = "";

            for (int i = 0; i < vetorNome.Length; i++)
            {
                nomeFormatado += vetorNome[i];
            }

            textBoxEmail.Text = nomeFormatado.ToLower() + "@ufn.edu.br";

            textBoxListaEmails.AppendText(textBoxEmail.Text + Environment.NewLine);
            buttonLimpar.Enabled = true;
            textBoxNomeJogador.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxNomeJogador.Text = string.Empty;
            textBoxListaEmails.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            buttonLimpar.Enabled = false;
        }
    }
}
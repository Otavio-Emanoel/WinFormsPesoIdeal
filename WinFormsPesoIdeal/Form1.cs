namespace WinFormsPesoIdeal
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private double CalcularPesoIdeal(double altura, string genero)
        {
            int pesoIdeal = 0;

            if (genero == "Masculino")
            {
                pesoIdeal = (int)((72.7 * altura) - 58);
            }
            else if (genero == "Feminino")
            {
                pesoIdeal = (int)((62.1 * altura) - 44.7);
            }
            return pesoIdeal;
        }

        private int CalcularIdade(DateTime txtDataNascimento, DateTime dataAtual)
        {
            int idade = dataAtual.Year - txtDataNascimento.Year;
            if (dataAtual.Month < txtDataNascimento.Month || (dataAtual.Month == txtDataNascimento.Month && dataAtual.Day < txtDataNascimento.Day))
            {
                idade--;
            }
            return idade;
        }

        private void SalvarDados(string nome, int idade, double peso, double altura, string genero)
        {
            string dados = $"Nome: {nome}\nIdade: {idade}\nPeso: {peso}\nAltura: {altura}\nGênero: {genero}";
            File.WriteAllText("dados.txt", dados);
            MessageBox.Show("Dados de " + nome + " foram salvos com sucesso!");
        }
        private void ExcluirSalvamento()
        {
            if (File.Exists("dados.txt"))
            {
                File.Delete("dados.txt");
                MessageBox.Show("Dados excluídos com sucesso!");
            }
            else
            {
                MessageBox.Show("Não há dados salvos!");
            }
        }



        private void calcularBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtPeso.Text) || string.IsNullOrEmpty(txtAltura.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            double peso, altura;
            if (!double.TryParse(txtPeso.Text, out peso) || !double.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("Peso e altura devem ser números!");
                return;
            }

            int idade = CalcularIdade(txtDataNascimento.Value, dataAtual.Value);

            double pesoIdeal = CalcularPesoIdeal(altura, masculino.Checked ? "Masculino" : "Feminino");

            lblIdade.Text = $"Idade: {idade}";
            pesoIdealLbl.Text = $"Peso ideal: {pesoIdeal}";
            MessageBox.Show($"Peso ideal: {pesoIdeal}");
        }

        private void salvarBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Preencha o campo nome!"); return;
            }
            SalvarDados(txtNome.Text, int.Parse(lblIdade.Text.Split(' ')[1]), double.Parse(txtPeso.Text), double.Parse(txtAltura.Text), masculino.Checked ? "Masculino" : "Feminino");
        }

        private void excluirBtn_Click(object sender, EventArgs e)
        {
            ExcluirSalvamento();
        }

        private void fecharBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nanoFoto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NANO É O MELHOR DO MUNDO!");
        }
    }
}

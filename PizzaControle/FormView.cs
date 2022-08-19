namespace PizzaControle
{
    public partial class FormView : Form {

        



        public FormView() {
            InitializeComponent();
        }

        private void FormView_Load(object sender, EventArgs e) {
            if (Database.isConnected()) {
                statusLabel.Text = "Banco de dados connectado com sucesso";
            }
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenSingleton("Funcionários");
        }

        private void entregadorToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenSingleton("Entregadores");
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenSingleton("Clientes");
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenSingleton("Produtos");
        }

        private void aberturaDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSingleton("Caixa");
        }
        
        private void despesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSingleton("Despesas");
        }
        
        private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSingleton("Entradas");
        }

        private void OpenSingleton(string form) {
            
            int totalForms = Application.OpenForms.Count;
            int formIndex = 0;

            for (int i = 0; i < totalForms; i++) {

                if (Application.OpenForms[i].Text == form) {
                    formIndex = i;
                    break;
                }
            }

            if (formIndex > 0) {
                Application.OpenForms[formIndex].BringToFront();
            } else {
                switch (form) {
                    case "Clientes" :
                        FormClientes formClientes = new FormClientes();
                        formClientes.Show();
                        break;
                    case "Produtos":
                        FormProdutos formProdutos = new FormProdutos();
                        formProdutos.Show();
                        break;
                    case "Entregadores":
                        FormEntregadores formEntregadores = new FormEntregadores();
                        formEntregadores.Show();
                        break;
                    case "Funcionários":
                        FormFuncionarios formFuncionarios = new FormFuncionarios();
                        formFuncionarios.Show();
                        break;
                    case "Caixa":
                        FormCaixa formCaixa = new FormCaixa();
                        formCaixa.Show();
                        break;
                    case "Despesas":
                        FormDespesas formDespesa = new FormDespesas();
                        formDespesa.Show();
                        break;
                    case "Entradas":
                        FormEntradas formEntrada = new FormEntradas();
                        formEntrada.Show();
                        break;

                }

            }
        }

     
    }
    
}
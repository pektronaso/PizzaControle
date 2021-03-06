namespace PizzaControle
{
    public partial class FormView : Form {

        



        public FormView() {
            InitializeComponent();
        }

        private void FormView_Load(object sender, EventArgs e) {
            if (database.isConnected()) {
                statusLabel.Text = "Banco de dados connectado com sucesso";
            }
        }

        private void funcionįrioToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenSingleton("Funcionįrios");
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
                    case "Funcionįrios":
                        FormFuncionarios formFuncionarios = new FormFuncionarios();
                        formFuncionarios.Show();
                        break;
                }

            }
        }

    }
    
}
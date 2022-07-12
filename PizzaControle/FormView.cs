namespace PizzaControle
{
    public partial class FormView : Form
    {

        



        public FormView()
        {
            InitializeComponent();
        }


        private void FormView_Load(object sender, EventArgs e)
        {
            if (database.isConnected())
            {
                statusLabel.Text = "Banco de dados connectado com sucesso";
            }
        }


        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {           

            int totalForms = Application.OpenForms.Count;
            int formIndex = 0;

            for (int i = 0; i < totalForms; i++) {
                
                if (Application.OpenForms[i].Text == "Funcionários") {                    
                    formIndex = i;
                    break;
                }
            }

            if (formIndex > 0) {
                
                Application.OpenForms[formIndex].BringToFront();

            } else {
                
                FormFuncionarios formFuncionarios = new FormFuncionarios();
                formFuncionarios.Show();
            }

            

        }

        private void entregadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int totalForms = Application.OpenForms.Count;
            int formIndex = 0;

            for (int i = 0; i < totalForms; i++)
            {

                if (Application.OpenForms[i].Text == "Entregadores")
                {
                    formIndex = i;
                    break;
                }
            }

            if (formIndex > 0)
            {

                Application.OpenForms[formIndex].BringToFront();

            }
            else
            {

                FormEntregadores formEntregador = new FormEntregadores();
                formEntregador.Show();
            }
        }



        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int totalForms = Application.OpenForms.Count;
            int formIndex = 0;

            for (int i = 0; i < totalForms; i++)
            {

                if (Application.OpenForms[i].Text == "Clientes")
                {
                    formIndex = i;
                    break;
                }
            }

            if (formIndex > 0)
            {

                Application.OpenForms[formIndex].BringToFront();

            }
            else
            {

                FormClientes FormClientes = new FormClientes();
                FormClientes.Show();
            }
        }
    }
    
}
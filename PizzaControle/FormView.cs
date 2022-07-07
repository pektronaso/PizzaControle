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

     }
    
}
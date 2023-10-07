using Database.Repositorios;
using Negocio.Repository;

namespace WindowsForms.telas.fornecedores
{
    public partial class FornecedorView : Form
    {
        private IFornecedorRepository _fornecedorRepository;
        public FornecedorView()
        {
            InitializeComponent();
            _fornecedorRepository = new FornecedorRepository();
        }
        public FornecedorView(IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }
        private void FornecedorView_Load(object sender, EventArgs e)
        {
            var listaFornedores = _fornecedorRepository.ObterTodos(); ;
            dataGridView1.DataSource = listaFornedores;
        }
    }
}

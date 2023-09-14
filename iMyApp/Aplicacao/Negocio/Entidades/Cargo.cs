using Negocio.Entidades.Comum;

namespace Negocio.Entidades
{
    public class Cargo : EntidadeBase
    {                
        public string Nome { get; set; }
        public bool Status { get; set; }

        public Cargo(string nome, bool status)
        {
            Nome = nome;
            Status = status;
            
            CriadoPor = "Welton";
            CriadoEm = DateTime.Now;

            AlteradoPor = "Welton";
            AlteradoEm = DateTime.Now;
        }
    }
}

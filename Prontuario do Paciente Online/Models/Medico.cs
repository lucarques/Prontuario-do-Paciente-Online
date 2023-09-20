namespace Prontuario_do_Paciente_Online.Models
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Crm { get; set; }

        public Medico()
        {
        }

        public Medico(int id, string nome, string crm)
        {
            Id = id;
            Nome = nome;
            Crm = crm;
        }
    }

}

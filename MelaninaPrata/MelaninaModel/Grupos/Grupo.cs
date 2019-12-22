namespace MelaninaModel.Grupos
{
    public class Grupo
    {
        int id;
        string descricao;
        
        public Grupo()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
    }
}

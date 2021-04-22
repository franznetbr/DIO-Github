namespace DIO.Series
//Classe abstrata para que tenhamos um id em todas as classes que herdarem desta classe.
{
    public abstract class EntidadeBase
    {
        public int Id { get; protected set; }
    }
}
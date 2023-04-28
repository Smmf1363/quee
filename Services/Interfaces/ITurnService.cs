using smmf8quee.Models;

namespace smmf8quee.Services.Interfaces
{
    public interface ITurnService
    {
        public void AddTurn(Turns Turn);
        List<Turns> GetTurns();
        Turns GetTurn(int Id);
        void EditTurn(Turns turn);
        void DeleteTurn(Turns turn);
    }
}

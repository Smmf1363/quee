using Microsoft.EntityFrameworkCore;
using smmf8quee.Contexts;
using smmf8quee.Models;
using smmf8quee.Services.Interfaces;

namespace smmf8quee.Services
{
    public class TurnService : ITurnService
    {
        TurnContext _context;
        public TurnService(TurnContext context) {
            _context = context;
        }

        public void AddTurn(Turns Turn)
        {
            _context.Turns.Add(Turn);
            _context.SaveChanges();
        }

        public void DeleteTurn(Turns turn)
        {
            _context.Remove(turn);
            _context.SaveChanges();
        }

        public void EditTurn(Turns turn)
        {
            _context.Update(turn);
            _context.SaveChanges();
        }

        public Turns GetTurn(int Id)
        {
            return _context.Turns.Find(Id);
        }

        public List<Turns> GetTurns()
        {
            return _context.Turns.ToList();
        }
    }
}

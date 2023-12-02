using FinalProject.Models;

namespace FinalProject.Data
{
    public class SportsService : ISportsService
    {
        SportsContext ctx;
        public SportsService(SportsContext context)
        {
            ctx = context;
        }

        public int? AddSport(Sports p)
        {
            var sport = this.GetSportById(p.SportID);
            if (sport != null)
            {
                return null;
            }
            ctx.Sports.Add(p);
            return ctx.SaveChanges();
        }

        public List<Sports> GetAllSports()
        {
            return ctx.Sports.ToList();
        }

        public Sports GetSportById(int Id)
        {
            return ctx.Sports.FirstOrDefault(x => x.SportID == Id);
        }

        public int? RemoveSportById(int id)
        {
            var sport = this.GetSportById(id);
            if (sport == null)
            {
                return null;
            }
            ctx.Sports.Remove(sport);
            return ctx.SaveChanges();
        }

        public int? UpdateSport(Sports p)
        {
            ctx.Sports.Update(p);
            return ctx.SaveChanges();
        }
    }
}

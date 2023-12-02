using FinalProject.Models;

namespace FinalProject.Data
{
    public interface ISportsService
    {
        int? AddSport(Sports p);
        List<Sports> GetAllSports();
        Sports GetSportById(int Id);
        int? RemoveSportById(int id);
        int? UpdateSport(Sports p);
    }
}

using Microsoft.EntityFrameworkCore;
using Service.Models;
using Service.ViewModels;

namespace Service.Classes
{
    public class AwardService
    {
        FinalContext _context;
        public AwardService()
        {
            _context = new FinalContext();
        }
        public AwardsVM GetAwardsVM(int filmid)
        {
            AwardsVM result= new AwardsVM();
            var film = _context.Films.Include(a => a.Awards).Where(a=>a.Id==filmid).FirstOrDefault();
            if (film == null) 
            { return result; }
            result.Name = film.Name;
            result.Filmid = film.Id;
            List<AwardsItem> awardslist = new List<AwardsItem>();
            foreach(var item in film.Awards.ToList())
            {
                var awarditem = new AwardsItem();
                awarditem.Id = item.Id;
                awarditem.Awardname = item.Awardname;
                awarditem.Year = item.Year;
                awardslist.Add(awarditem);
            }
            result.AwardsListItem = awardslist;
            return result;
        
        }
        public AwardsCE_VM getAwardsCE_VM(int filmid)
        {
            AwardsCE_VM result= new AwardsCE_VM();
            result.Filmid = filmid;
            return result;
        }
        public void AddAdwar(AwardsCE_VM vm) 
        {
            Award model= new Award();
            model.Filmid = vm.Filmid;
            model.Awardname= vm.Awardname;
            model.Year= vm.Year;    
            _context.Awards.Add(model);
            _context.SaveChanges();
        }
       
    }
}

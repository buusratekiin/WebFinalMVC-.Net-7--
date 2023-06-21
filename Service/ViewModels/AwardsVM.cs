using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ViewModels
{
    public class AwardsVM
    {
        public int Filmid { get; set; }
        public string Name { get; set; }
        public List<AwardsItem> AwardsListItem { get; set;}

    }
    public class AwardsItem
    {
        public int Id { get; set; }

        public string Awardname { get; set; } = null!;

        public int Filmid { get; set; }

        public int Year { get; set; }
    }
}

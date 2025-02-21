using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Automation.Objects.Games
{
    public class InsertGames
    {
        public string GamesName { get; set; }
        public int Developer { get; set; }
        public string PublisherName{ get; set; }
        public DateTime ReleasedDate { get; set; }
        public Int16 NumberOfEpisodes { get; set; }
        public Int16 Stocks { get; set; }
    }
}

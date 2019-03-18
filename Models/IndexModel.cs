using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VotingSystem.data;

namespace VotingSystem.Models
{
    public class IndexModel
    {
        public IEnumerable<User_Recording> User_Recording { get; set; }
        public IEnumerable<Topic_Recording> Topic_Recording { get; set; }
        public IndexModel()
        {
            VotingSystemEntities db = new VotingSystemEntities();
            this.User_Recording = db.User_Recording.ToList();
            this.Topic_Recording = db.Topic_Recording.ToList();

        }
    }
}
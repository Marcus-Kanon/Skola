using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_2___F
{
    class user
    {
        public string firstName { get; set; } = "<Name>";
        public string lastName { get; set; } = "<Last name>";
        public string alias { get; set; } = "<Alias>";
        public string email { get; set; } = "<E-mail>";
        public string linkedIn { get; set; } = "<Linked In>";
        public string facebook { get; set; } = "<Facebook>";
        public string instagram { get; set; } = "<Instagram>";
        public string twitter { get; set; } = "<Twitter>";
        public string github { get; set; } = "<Github>";
        public string favoriteFood { get; set; } = "<Favorite Food>";
        public string dislikedFood { get; set; } = "<Disliked Food>";
        public string favoriteAnimal { get; set; } = "<Favorite Animal>";
        public string favoriteMovieGenre { get; set; } = "<Favorite Movie Genre>";
        public bool isBlocked { get; set; } = false;
        public bool isGhosted { get; set; } = false;
        public DateTime birthday { get; set; } = DateTime.Today;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_2___F
{
    class User
    {
        //public string firstName { get => firstName; set => firstName = value; }
        public string firstName { get; set; } = "a";
        public string lastName { get; set; } = "b";
        public string alias { get; set; } = "c";
        public string email { get; set; } = "d";
        public string linkedIn { get; set; } = "e";
        public string facebook { get; set; } = "f";
        public string instagram { get; set; } = "g";
        public string twitter { get; set; } = "h";
        public string github { get; set; } = "i";
        public string favoriteFood { get; set; } = "j";
        public string dislikedFood { get; set; } = "k";
        public string favoriteAnimal { get; set; } = "l";
        public string favoriteFilmGenre { get; set; } = "m";
        public bool isBlocked { get; set; } = false;
        public bool isGhosted { get; set; } = false;
    }
}

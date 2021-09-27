using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_2___F
{
    class User
    {
        string firstName { get; set; } = "";
        string lastName { get; set; } = "";
        string alias { get; set; } = "";
        string email { get; set; } = "";
        string linkedIn { get; set; } = "";
        string facebook { get; set; } = "";
        string instagram { get; set; } = "";
        string twitter { get; set; } = "";
        string github { get; set; } = "";
        string favoriteFood { get; set; } = "";
        string dislikedFood { get; set; } = "";
        string favoriteAnimal { get; set; } = "";
        string favoriteFilmGenre { get; set; } = "";
        bool isBlocked { get; set; } = false;
        bool isGhosted { get; set; } = false;
    }
}

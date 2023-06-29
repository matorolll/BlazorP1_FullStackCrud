using BlazorP1_FullStackCrud.Shared;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorP1_FullStackCrud.Shared
{
    public class SuperHero
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string HeroName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public Comic? Comic { get; set; }
        public int ComicId { get; set; }
    }
}

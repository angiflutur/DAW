using System.ComponentModel.DataAnnotations;

namespace proiect.Models
{
    public class Actor
    {
        [Key]
        public string IdActor { get; set; }
    
        public string NumeActor { get; set; }
    
        public string Imagine { get; set; }

        public string Bio {  get; set; }

        // definire relatii
        public List<Actor_Film> Actori_Filme { get; set; }


    }
}

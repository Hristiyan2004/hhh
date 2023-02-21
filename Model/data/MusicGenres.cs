using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_store.Model.data
{
    public class MusicGenres
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Music>? Musics { get; set; }  
    }
}

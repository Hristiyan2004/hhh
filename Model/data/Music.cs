using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_store.Model.data
{
    public class Music
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int GenresId { get; set; }
        public MusicGenres? Genres { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; } = DateTime.Now;
    }
}

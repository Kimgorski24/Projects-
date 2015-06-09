using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCNick.Data.Models
{
    public class Songs
    {
        [Key]
        public int SongId { get; set; }
        public string Title { get; set; }
        public string ArtistName { get; set; }
    }
}

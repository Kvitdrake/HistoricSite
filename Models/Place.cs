using System.ComponentModel.DataAnnotations;

namespace HistoricSite.Models
{
    public class Place
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }
        public string? Country { get; set; }
    }
}

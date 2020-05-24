using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BIT265_MergeSort.Models
{
    public class WifiHotspotsModel
    {
        public long Id { get; set; }
        public string FSCSKEY { get; set; }
        public string LIBID { get; set; }
        public string LibrarySystem { get; set; }
        public string BranchLibrary { get; set; }
        public string WiFiHours { get; set; }
        public bool Password { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int ZIP { get; set; }
        public string Phone { get; set; }
        public string OutletType
        { get; set; }

        [Column(TypeName = "decimal(9,6)")]
        public decimal Longitude{ get; set; }
        [Column(TypeName = "decimal(9,6)")]
        public decimal Latitude { get; set; }
        public string Website { get; set; }
        public bool eCardAccess
        { get; set; }
        public string LastUpdate { get; set; }
    }
}

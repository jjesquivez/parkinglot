using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace parkinglot.Database.Model
{
    [Table("clients")]
    public class ClientsModel
    {
        [Key]
        [Column("id")]
        public string id { get; set; }
        [Column("brand")]
        public string brand { get; set; }
        [Column("model")]
        public string model { get; set; }
        [Column("plates")]
        public string plates { get; set; }
        [Column("enter")]
        public DateTime enter { get; set; }
        [Column("exit")]
        public DateTime exit { get; set; }

    }
}

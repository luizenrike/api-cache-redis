using APICacheRedis.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICacheRedis.Domain.Models
{
    [Table("Agencias")]
    public class Agencia : IEntity
    {
        [Column("Ispb")]
        public int Ispb { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("Code")]
        public int? Code { get; set; }
        [Column("FullName")]
        public string FullName { get; set; }
    }
}

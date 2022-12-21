using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public abstract class BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Id { get; private set; }
        public static int id_no = 0;

        public BaseEntity()
        {
            id_no++;
            Id = id_no;
        }
    }
}

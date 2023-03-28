using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Book
    {
        int Id { get; set; }
        int authorID { get; set; }
        int categoryID { get; set; }
        string Name { get; set; }   
        string Status { get; set; }
        int Quantity { get; set; }
        float Price { get; set; }
    }
}

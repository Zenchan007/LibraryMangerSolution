using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BorrowBook
    {
        public int bookID { get; set; }
        public int readerID { get; set; }

        public string borrowDate { get; set; }

        public string borrowStatus { get; set; }
        public int Quantity { get; set; }

        public string Note { get; set; }
    }
}

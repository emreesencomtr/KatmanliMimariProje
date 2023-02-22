using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection("Data Source=LAPTOP-83L42UFV\\SQLEXPRESS;Initial Catalog=KatmanliMimari;Integrated Security=True");
    }
}

using APPDoceria.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginAPP.Data
{
    public class SQLiteData
    {
        readonly SQLiteAsyncConnection _conexaoDB;

        public UsuarioData UsuarioDataTable { get; set; }
        public SQLiteData (string path)
        {
            _conexaoDB = new SQLiteAsyncConnection (path);
            _conexaoDB.CreateTableAsync<Usuario>().Wait ();

            UsuarioDataTable = new UsuarioData(_conexaoDB);
        }
    }
}

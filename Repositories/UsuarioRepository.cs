using System.Collections.Generic;
using System.Linq;
using AutenticacaoNET6.Models;

namespace AutenticacaoNET6.Repositories
{
    public static class UsuarioRepository
    {
        public static Usuario Get(string Nome, string password)
        {
            var users = new List<Usuario>();
            users.Add(new Usuario { Id = 1, Nome = "aaa", Password = "aaa", Role = "manager" });
            users.Add(new Usuario { Id = 2, Nome = "bbb", Password = "bbb", Role = "employee" });
            users.Add(new Usuario { Id = 3, Nome = "ccc", Password = "ccc", Role = "manager" });
            users.Add(new Usuario { Id = 4, Nome = "ddd", Password = "ddd", Role = "employee" });
            users.Add(new Usuario { Id = 5, Nome = "fff", Password = "fff", Role = "manager" });
            users.Add(new Usuario { Id = 6, Nome = "ggg", Password = "ggg", Role = "employee" });
            return users.FirstOrDefault(x => x.Nome.ToLower() == Nome.ToLower() && x.Password == x.Password);
        }
    }
}
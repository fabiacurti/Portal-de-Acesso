using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models.Acesso
{
    public class Login
    {
        public Guid Id { get; set; }
        public string Usuario { get; set; }
        public Guid UsuarioCorregedoria { get; set; }
        public string Senha { get; set; }

        public DateTime DataCriacao { get; set; }

        public Guid IdUsuario { get; set; }
        public bool Bloqueado { get; set; }


    }
}

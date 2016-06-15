using FutebolAdmin.DAL;
using FutebolAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FutebolAdmin.BL
{
    public class UsuarioBO : IUsuarioBO
    {
        public bool ValidarUsuarioLogin(Usuario Usuario)
        {
            UsuarioDAO _usuarioDAO = new UsuarioDAO();
            Usuario usuario = _usuarioDAO.ConsultarUsuario(Usuario);
            return usuario == null ? false : usuario.ID > 0;
        }

        public Usuario DetalharUsuarioByLogin(string Login)
        {
            UsuarioDAO _usuarioDAO = new UsuarioDAO();
            return _usuarioDAO.ConsultarUsuarioByLogin(Login);
        }
    }
}
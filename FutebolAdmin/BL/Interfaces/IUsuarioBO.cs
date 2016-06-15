using FutebolAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutebolAdmin.BL
{
    public interface IUsuarioBO
    {
        bool ValidarUsuarioLogin(Usuario Usuario);

        Usuario DetalharUsuarioByLogin(string Login);
    }
}

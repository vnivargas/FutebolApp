using FutebolAdmin.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FutebolAdmin.DAL
{
    public class UsuarioDAO
    {
        //private string StrConnection { get; set; }

        //public UsuarioDAO()
        //{
        //    StrConnection = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        //}

        public Usuario ConsultarUsuario(Usuario Usuario)
        {
            var db = new Contexto();
            return db.Usuario.Where(x => x.Login.Equals(Usuario.Login) && x.Senha.Equals(Usuario.Senha, StringComparison.InvariantCulture)).FirstOrDefault();
        }

        public Usuario ConsultarUsuarioByLogin(string Login)
        {
            var db = new Contexto();
            return db.Usuario.Where(x => x.Login.Equals(Login)).FirstOrDefault();
        }

        //public Usuario ConsultarUsuario(Usuario usuario)
        //{
        //     var db = new Contexto();
        //    using 
        //    string query = " SELECT * FROM FUT_USUARIO WHERE LOGIN = @LOGIN AND SENHA = @SENHA ";
        //    using (SqlConnection connection = new SqlConnection(this.StrConnection))
        //    {
        //        connection.Open();

        //        SqlCommand command = new SqlCommand(query, connection);
        //        command.Parameters.Add(new SqlParameter("@LOGIN", usuario.Login));
        //        command.Parameters.Add(new SqlParameter("@SENHA", usuario.Senha));
        //        SqlDataReader reader = command.ExecuteReader();

        //        Usuario user = new Usuario();

        //        while (reader.Read())
        //        {
        //            user.CodigoUsuario = reader["Id_Usuario"] != DBNull.Value ? (int)reader["Id_Usuario"] : 0;
        //            user.CodigoEquipe = reader["Id_Equipe"] != DBNull.Value ? (int)reader["Id_Equipe"] : 0;
        //            user.Login = reader["Login"] != DBNull.Value ? reader["Login"].ToString() : null;
        //            user.Senha = reader["Senha"] != DBNull.Value ? reader["Senha"].ToString() : null;
        //        }

        //        return user;
        //    }
        //}

        //public Usuario ConsultarUsuario(int codigoUsuario)
        //{
        //    string query = " SELECT * FROM FUT_USUARIO WHERE ID_USUARIO = @ID ";
        //    using (SqlConnection connection = new SqlConnection(this.StrConnection))
        //    {
        //        connection.Open();

        //        SqlCommand command = new SqlCommand(query, connection);
        //        command.Parameters.Add(new SqlParameter("@ID", codigoUsuario));
        //        SqlDataReader reader = command.ExecuteReader();

        //        Usuario user = new Usuario();

        //        while (reader.Read())
        //        {
        //            user.CodigoUsuario = reader["Id_Usuario"] != DBNull.Value ? (int)reader["Id_Usuario"] : 0;
        //            user.CodigoEquipe = reader["Id_Equipe"] != DBNull.Value ? (int)reader["Id_Equipe"] : 0;
        //            user.Login = reader["Login"] != DBNull.Value ? reader["Login"].ToString() : null;
        //            user.Senha = reader["Senha"] != DBNull.Value ? reader["Senha"].ToString() : null;
        //        }

        //        return user;
        //    }
        //}

    }
}
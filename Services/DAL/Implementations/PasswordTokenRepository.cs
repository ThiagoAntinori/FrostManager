using Services.BLL.Extensions;
using Services.DAL.Tools;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Services.Domain.Security;
using System.Data;

namespace Services.DAL.Implementations
{
    public class PasswordTokenRepository
    {

        private readonly static PasswordTokenRepository _instance = new PasswordTokenRepository();

        public static PasswordTokenRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private PasswordTokenRepository()
        {
            // Implement here the initialization of your singleton
        }

        public void Insert(PasswordToken passwordToken)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("INSERT INTO PASSWORD_RESET (Token, IdUsuario, FechaVencimiento) VALUES (@Token, @IdUsuario, @FechaVencimiento)",
                    CommandType.Text,
                    new SqlParameter[]
                    {
                        new SqlParameter("@Token", passwordToken.Token),
                        new SqlParameter("@IdUsuario", passwordToken.Usuario.IdUsuario),
                        new SqlParameter("@FechaVencimiento", passwordToken.FechaVencimiento)
                    });
            }
            catch(Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public List<PasswordToken> GetByIdUsuario(Guid idUsuario)
        {
            try
            {
                List<PasswordToken> tokens = new List<PasswordToken>();
                PasswordToken passwordToken = null;
                using(SqlDataReader reader = SqlHelper.ExecuteReader("SELECT Token, IdUsuario, FechaVencimiento FROM PASSWORD_RESET WHERE IdUsuario = @IdUsuario",
                    CommandType.Text,
                    new SqlParameter[]
                    {
                        new SqlParameter("@IdUsuario", idUsuario)
                    }))
                {
                    object[] values = new object[reader.FieldCount];

                    while (reader.Read())
                    {
                        reader.GetValues(values);
                        passwordToken = new PasswordToken
                        {
                            Token = values[0].ToString(),
                            FechaVencimiento = Convert.ToDateTime(values[2].ToString())
                        };
                        passwordToken.Usuario = UsuarioRepository.Current.GetById(Guid.Parse(values[1].ToString()));
                        tokens.Add(passwordToken);
                    }
                    return tokens;
                }
                return null;
            }
            catch(Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public PasswordToken GetByToken(string token)
        {
            try
            {
                PasswordToken passwordToken = null;
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SELECT Token, IdUsuario, FechaVencimiento FROM PASSWORD_RESET WHERE Token = @Token",
                    CommandType.Text,
                    new SqlParameter[]
                    {
                        new SqlParameter("@Token", token)
                    }))
                {
                    object[] values = new object[reader.FieldCount];

                    if (reader.Read())
                    {
                        reader.GetValues(values);
                        passwordToken = new PasswordToken
                        {
                            Token = values[0].ToString(),
                            FechaVencimiento = Convert.ToDateTime(values[2].ToString())
                        };
                        passwordToken.Usuario = UsuarioRepository.Current.GetById(Guid.Parse(values[1].ToString()));
                        return passwordToken;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

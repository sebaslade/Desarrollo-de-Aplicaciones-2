using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//agregar
using System.IdentityModel.Selectors;
using System.ServiceModel;

namespace WCFSeguro
{
    public class Autenticar: UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
			try
			{
				if (userName.Trim() == String.Empty || password.Trim() == String.Empty)
				{
					throw new Exception("El usuario y contraseñas son obligatorios");
				}
				// Validamos en duro que el usuario sea jleon y el pass 12345
				if (userName == "jleon" && password == "12345")
				{
					return;
				}
				{
					throw new Exception("Usuario y contraseña incorrectos");
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
        }
    }
}

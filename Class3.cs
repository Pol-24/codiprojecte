using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public class Class3
    {

        public static int Afegir(Class2 pRegistre)
        {
            int retorno = 0;
            using (SqlConnection conn=Class1.ObtnerC0nexion())
            {
                SqlCommand comandament = new SqlCommand(string.Format("Insert Into Registre (Nom, Correu, Telèfon) values ('{0}', '{1}', '{2}' )",
                   pRegistre.Nom, pRegistre.Correu, pRegistre.Telèfon), conn);

                retorno = comandament.ExecuteNonQuery();  
            }
            return retorno;
        }
    }
}

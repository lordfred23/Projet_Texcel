using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Texcel
{
    class DBprovider
    {
        static SqlConnection conn;
        public DBprovider() {
            Connection();
        }

        public void Connection()
        {
            conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=bdTexelFredAlex;Trusted_Connection=True;");
            
                


           
        }
        public void Deconnection()
        {
            conn.Close();
        }

        public void AddSystemExploitation(string nom,string version, string edition)
        {

            conn.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand(
                        "INSERT INTO tblSystemExploitation(nom,version,edition) VALUES(@nom, @version, @edition)", conn))
                    {
                        command.Parameters.Add(new SqlParameter("nom", nom));
                        command.Parameters.Add(new SqlParameter("version", version));
                        command.Parameters.Add(new SqlParameter("edition", edition));
                        command.ExecuteNonQuery();
                    }
                }
                catch
                {
                    //Console.WriteLine("Count not insert.");
                }
            conn.Close();

         }


        static void AddPlatform(string nom, string config, string typePlatform,int idSysExp)
        {

            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO tblPlatform VALUES(@nom, @config, @typePlatform,@idSysExp)", conn))
                {
                    command.Parameters.Add(new SqlParameter("nom", nom));
                    command.Parameters.Add(new SqlParameter("config", config));
                    command.Parameters.Add(new SqlParameter("typePlatform", typePlatform));
                    command.Parameters.Add(new SqlParameter("idSysExp", idSysExp));
                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                //Console.WriteLine("Count not insert.");
            }
            conn.Close();

        }

        static void AddPlatformToGame(int idJeu,int idPlatform)
        {

            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO tblPlatformJeu VALUES(@idJeu, @idPlatform)", conn))
                {
                    command.Parameters.Add(new SqlParameter("idJeu", idJeu));
                    command.Parameters.Add(new SqlParameter("idPlatform", idPlatform));
                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                //Console.WriteLine("Count not insert.");
            }
            conn.Close();

        }

        static void AddGame(string developpeur,string description,string minimalConfig,int idClassification,string nom)
        {

            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO tblJeu VALUES(@developpeur,@description,@minimalConfig,@idClassification,@nom)", conn))
                {
                    command.Parameters.Add(new SqlParameter("developpeur", developpeur));
                    command.Parameters.Add(new SqlParameter("description", description));
                    command.Parameters.Add(new SqlParameter("minimalConfig", minimalConfig));
                    command.Parameters.Add(new SqlParameter("idClassification", idClassification));
                    command.Parameters.Add(new SqlParameter("nom", nom));
                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                //Console.WriteLine("Count not insert.");
            }
            conn.Close();

        }

        static void AddTheme(string nom,string description)
        {

            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO tblTheme VALUES(@nom, @description)", conn))
                {
                    command.Parameters.Add(new SqlParameter("nom", nom));
                    command.Parameters.Add(new SqlParameter("description", description));
                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                //Console.WriteLine("Count not insert.");
            }
            conn.Close();

        }

        static void AddGenre(string nom, string description)
        {

            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO tblGenre VALUES(@nom, @description)", conn))
                {
                    command.Parameters.Add(new SqlParameter("nom", nom));
                    command.Parameters.Add(new SqlParameter("description", description));
                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                //Console.WriteLine("Count not insert.");
            }
            conn.Close();

        }

        static void AddClassification(string nom, string description)
        {

            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO tblClassification VALUES(@nom, @description)", conn))
                {
                    command.Parameters.Add(new SqlParameter("nom", nom));
                    command.Parameters.Add(new SqlParameter("description", description));
                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                //Console.WriteLine("Count not insert.");
            }
            conn.Close();

        }

        static void AddThemeToGame(int idJeu, int idTheme)
        {

            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO tblJeuTheme VALUES(@idJeu, @idTheme)", conn))
                {
                    command.Parameters.Add(new SqlParameter("idJeu", idJeu));
                    command.Parameters.Add(new SqlParameter("idTheme", idTheme));
                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                //Console.WriteLine("Count not insert.");
            }
            conn.Close();

        }

        static void AddGenreToGame(int idJeu, int idGenre)
        {

            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO tblGenreJeu VALUES(@idJeu, @idGenre)", conn))
                {
                    command.Parameters.Add(new SqlParameter("idJeu", idJeu));
                    command.Parameters.Add(new SqlParameter("idGenre", idGenre));
                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                //Console.WriteLine("Count not insert.");
            }
            conn.Close();

        }

        static void AddRole(string nom, string description)
        {

            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO tblRole VALUES(@nom, @description)", conn))
                {
                    command.Parameters.Add(new SqlParameter("nom", nom));
                    command.Parameters.Add(new SqlParameter("description", description));
                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                //Console.WriteLine("Count not insert.");
            }
            conn.Close();

        }

        static void AddEmploye(string matricule,string nom,string prenom,string dateNaissance,string adresse,string noTelephone,string posteTelephone,string noTelephoneMaison,int idRole)
        {

            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO tblEmploye VALUES(@matricule,@nom,@prenom,@dateNaissance,@adresse,@noTelephone,@posteTelephone,@noTelephoneMaison,@idRole)", conn))
                {
                    command.Parameters.Add(new SqlParameter("matricule", matricule));
                    command.Parameters.Add(new SqlParameter("nom", nom));
                    command.Parameters.Add(new SqlParameter("prenom", prenom));
                    command.Parameters.Add(new SqlParameter("dateNaissance", dateNaissance));
                    command.Parameters.Add(new SqlParameter("adresse", adresse));
                    command.Parameters.Add(new SqlParameter("noTelephone", noTelephone));
                    command.Parameters.Add(new SqlParameter("posteTelephone", posteTelephone));
                    command.Parameters.Add(new SqlParameter("noTelephoneMaison", noTelephoneMaison));
                    command.Parameters.Add(new SqlParameter("idRole", idRole));
                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                //Console.WriteLine("Count not insert.");
            }
            conn.Close();

        }

        static void AddEmployeToTeam(string matricule, int idEquipe)
        {

            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO tblEmployeEquipe VALUES(@matricule, @idEquipe)", conn))
                {
                    command.Parameters.Add(new SqlParameter("matricule", matricule));
                    command.Parameters.Add(new SqlParameter("idEquipe", idEquipe));
                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                //Console.WriteLine("Count not insert.");
            }
            conn.Close();

        }

        static void AddEquipe(string nom)
        {

            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO tblEquipe VALUES(@nom)", conn))
                {
                    command.Parameters.Add(new SqlParameter("nom", nom));
                    
                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                //Console.WriteLine("Count not insert.");
            }
            conn.Close();

        }

        static void AddCategorieTest(string nom, string description)
        {

            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO tblCategorieTest VALUES(@nom, @description)", conn))
                {
                    command.Parameters.Add(new SqlParameter("nom", nom));
                    command.Parameters.Add(new SqlParameter("description", description));
                   
                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                //Console.WriteLine("Count not insert.");
            }
            conn.Close();

        }

        static void AddTest(int resutlat,string nom, string description,int idCategorieTest)
        {

            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO tblTest VALUES(@resultat,@nom, @description,@idCategorieTest)", conn))
                {
                    command.Parameters.Add(new SqlParameter("nom", nom));
                    command.Parameters.Add(new SqlParameter("description", description));
                    command.Parameters.Add(new SqlParameter("resultat", resutlat));
                    command.Parameters.Add(new SqlParameter("idCategorieTest", idCategorieTest));

                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                //Console.WriteLine("Count not insert.");
            }
            conn.Close();

        }

        static void AddWrok(int idTest, int idEquipe,int idProjet)
        {

            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO tblTravail VALUES(@idTest, @idEquipe,@idProjet)", conn))
                {
                    command.Parameters.Add(new SqlParameter("idTest", idTest));
                    command.Parameters.Add(new SqlParameter("idEquipe", idEquipe));
                    command.Parameters.Add(new SqlParameter("idProjet", idProjet));
                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                //Console.WriteLine("Count not insert.");
            }
            conn.Close();

        }




    }

}


using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet_Texcel.ClasseObjBd; //  heyhey namespace different pour les classes de "BD" alex.

namespace Projet_Texcel
{
    class DBprovider
    {
        static SqlConnection conn;
        static ClasseObjBd.CSysExp SysExp;
        static ClasseObjBd.CPlatform plat;
        static ClasseObjBd.CJeu jeu;
        static ClasseObjBd.CTheme them;
        static ClasseObjBd.CGenre genre;
        static ClasseObjBd.CClassification classif;
        static ClasseObjBd.CRole role;
        static ClasseObjBd.CEmploye employe;
        static ClasseObjBd.CEquipe equipe;
        static ClasseObjBd.CCategorieTest categTest;
        static ClasseObjBd.CProjet projet;
        static ClasseObjBd.CTest test;

        static List<CSysExp> sysList = new List<CSysExp>();
        static List<CPlatform> platList = new List<CPlatform>();
        static List<CJeu> jeuList = new List<CJeu>();
        static List<CTheme> themeList = new List<CTheme>();
        static List<CGenre> genreList = new List<CGenre>();
        static List<CClassification> classifList = new List<CClassification>();
        static List<CRole> roleList = new List<CRole>();
        static List<CEmploye> employeList = new List<CEmploye>();
        static List<CEquipe> equipeList = new List<CEquipe>();
        static List<CCategorieTest> categTestList = new List<CCategorieTest>();
        static List<CProjet> projetList = new List<CProjet>();
        static List<CTest> testList = new List<CTest>();
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

        static void DisplaySysExp()
        {

            bool unDouble;
                conn.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM tblSystemExploitation", conn))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        unDouble = false;
                        foreach (CSysExp cc in sysList)
                        {
                            if (reader.GetInt32(0) == cc.IdSysExp )
                            {
                                unDouble = true;
                            }
                        }
                        if(unDouble==false)
                        {
                        int idSysExp = reader.GetInt32(0);
                        string nom = reader.GetString(1);
                        string version = reader.GetString(2);
                        string edition = reader.GetString(3);
                        string tag = reader.GetString(4);
                        SysExp = new CSysExp(idSysExp, nom, version, edition, tag);
                        sysList.Add(SysExp);
                        }
                        
                    }
                }
            conn.Close();
         }


        static void AddPlatform(string nom, string config, string typePlatform,int idSysExp)
        {

            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO tblPlatform(nom,config,typePlatform,idSysExp) VALUES(@nom, @config, @typePlatform,@idSysExp)", conn))
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

        static void DisplayPlatform()
        {

            bool unDouble;
            conn.Open();

            using (SqlCommand command = new SqlCommand("SELECT * FROM tblPlatform ", conn))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    unDouble = false;
                    foreach (CPlatform cc in platList)
                    {
                        if (reader.GetInt32(0) == cc.IdPlatform)
                        {
                            unDouble = true;
                        }
                    }
                    if (unDouble == false)
                    {
                        int idPlatform = reader.GetInt32(0);
                        string nom = reader.GetString(1);
                        string config = reader.GetString(2);
                        string typePlatform = reader.GetString(3);
                        int idSysExp = reader.GetInt32(4);
                        string tag = reader.GetString(5);
                        plat = new CPlatform(idPlatform,idSysExp,nom, config, typePlatform, tag);
                        platList.Add(plat);
                    }

                }
            }
            conn.Close();
        }

        static void AddPlatformToGame(int idJeu,int idPlatform)
        {

            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO tblPlatformJeu(idJeu,idPlatform) VALUES(@idJeu, @idPlatform)", conn))
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
                    "INSERT INTO tblJeu(developpeur,description,minimalConfig,idClassification,nom) VALUES(@developpeur,@description,@minimalConfig,@idClassification,@nom)", conn))
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

        static void DisplayJeu()
        {

            bool unDouble;
            conn.Open();

            using (SqlCommand command = new SqlCommand("SELECT * FROM tblJeu ", conn))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    unDouble = false;
                    foreach (CJeu cc in jeuList)
                    {
                        if (reader.GetInt32(0) == cc.IdJeu)
                        {
                            unDouble = true;
                        }
                    }
                    if (unDouble == false)
                    {
                        int idJeu = reader.GetInt32(0);
                        string developpeur= reader.GetString(1);
                        string description = reader.GetString(2);
                        string minimalConfig = reader.GetString(3);
                        int idClassification = reader.GetInt32(4);
                        string nom = reader.GetString(5);
                        string tag = reader.GetString(6);
                        jeu = new CJeu(idJeu, idClassification, developpeur,description, minimalConfig, tag);
                        jeuList.Add(jeu);
                    }

                }
            }
            conn.Close();
        }

        static void AddTheme(string nom,string description)
        {

            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO tblTheme(nom,description) VALUES(@nom, @description)", conn))
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

        static void DisplayTheme()
        {

            bool unDouble;
            conn.Open();

            using (SqlCommand command = new SqlCommand("SELECT * FROM tblTheme", conn))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    unDouble = false;
                    foreach (CTheme cc in themeList)
                    {
                        if (reader.GetInt32(0) == cc.IdTheme)
                        {
                            unDouble = true;
                        }
                    }
                    if (unDouble == false)
                    {
                        int idTheme = reader.GetInt32(0);
                        string nom = reader.GetString(1);
                        string description = reader.GetString(2);
                        string tag = reader.GetString(3);
                        
                        them = new CTheme(idTheme, nom, description,tag);
                        themeList.Add(them);
                    }

                }
            }
            conn.Close();
        }

        static void AddGenre(string nom, string description)
        {

            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO tblGenre(nom,description) VALUES(@nom, @description)", conn))
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

        static void DisplayGenre()
        {

            bool unDouble;
            conn.Open();

            using (SqlCommand command = new SqlCommand("SELECT * FROM tblGenre", conn))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    unDouble = false;
                    foreach (CGenre cc in genreList)
                    {
                        if (reader.GetInt32(0) == cc.IdGenre)
                        {
                            unDouble = true;
                        }
                    }
                    if (unDouble == false)
                    {
                        int idGenre = reader.GetInt32(0);
                        string nom = reader.GetString(1);
                        string description = reader.GetString(2);
                        string tag = reader.GetString(3);

                       genre = new CGenre(idGenre, nom, description, tag);
                        genreList.Add(genre);
                    }

                }
            }
            conn.Close();
        }

        static void AddClassification(string nom, string description)
        {

            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO tblClassification(nom,description) VALUES(@nom, @description)", conn))
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
        static void DisplayClassif()
        {

            bool unDouble;
            conn.Open();

            using (SqlCommand command = new SqlCommand("SELECT * FROM tblClassification", conn))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    unDouble = false;
                    foreach (CClassification cc in classifList)
                    {
                        if (reader.GetInt32(0) == cc.IdClassification)
                        {
                            unDouble = true;
                        }
                    }
                    if (unDouble == false)
                    {
                        int idClassif = reader.GetInt32(0);
                        string nom = reader.GetString(1);
                        string description = reader.GetString(2);
                        string tag = reader.GetString(3);

                        classif= new CClassification(idClassif, nom, description, tag);
                        classifList.Add(classif);
                        
                    }

                }
            }
            conn.Close();
        }

        static void AddThemeToGame(int idJeu, int idTheme)
        {

            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO tblJeuTheme(idJeu,idTheme) VALUES(@idJeu, @idTheme)", conn))
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
                    "INSERT INTO tblGenreJeu(idJeu,IdGenre) VALUES(@idJeu, @idGenre)", conn))
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
                    "INSERT INTO tblRole(nom,description) VALUES(@nom, @description)", conn))
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

        static void DisplayRole()
        {

            bool unDouble;
            conn.Open();

            using (SqlCommand command = new SqlCommand("SELECT * FROM tblRole", conn))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    unDouble = false;
                    foreach (CRole cc in roleList)
                    {
                        if (reader.GetInt32(0) == cc.IdRole)
                        {
                            unDouble = true;
                        }
                    }
                    if (unDouble == false)
                    {
                        int idRole = reader.GetInt32(0);
                        string nom = reader.GetString(1);
                        string description = reader.GetString(2);
                        string tag = reader.GetString(3);

                        role = new CRole(idRole, nom, description, tag);
                        roleList.Add(role);

                    }

                }
            }
            conn.Close();
        }

        static void AddEmploye(string matricule,string nom,string prenom,string dateNaissance,string adresse,string noTelephone,string posteTelephone,string noTelephoneMaison,int idRole)
        {

            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO tblEmploye(matricule,nom,prenom,dateNaissance,adresse,noTelephone,posteTelephone,noTelephoneMaison,idRole) VALUES(@matricule,@nom,@prenom,@dateNaissance,@adresse,@noTelephone,@posteTelephone,@noTelephoneMaison,@idRole)", conn))
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

        static void DisplayEmploye()
        {

            bool unDouble;
            conn.Open();

            using (SqlCommand command = new SqlCommand("SELECT * FROM tblEmploye", conn))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    unDouble = false;
                    foreach (CEmploye cc in employeList)
                    {
                        if (reader.GetString(0) == cc.Matricule)
                        {
                            unDouble = true;
                        }
                    }
                    if (unDouble == false)
                    {
                        string matricule = reader.GetString(0);
                        string nom = reader.GetString(1);
                        string prenom = reader.GetString(2);
                        string dateN = reader.GetString(3);
                        string adresse = reader.GetString(4);
                        string noTel = reader.GetString(5);
                        string posteTel = reader.GetString(6);
                        string noTelM = reader.GetString(7);
                        int    idRole = reader.GetInt32(8);
                        string tag = reader.GetString(9);

                        employe = new CEmploye(matricule, nom, prenom,dateN,adresse,noTel,posteTel,noTelM, tag,idRole);
                        employeList.Add(employe);

                    }

                }
            }
            conn.Close();
        }

        static void AddEmployeToTeam(string matricule, int idEquipe)
        {

            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO tblEmployeEquipe(matricule,idEquipe) VALUES(@matricule, @idEquipe)", conn))
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
                    "INSERT INTO tblEquipe(nom) VALUES(@nom)", conn))
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

        static void DisplayEquipe()
        {

            bool unDouble;
            conn.Open();

            using (SqlCommand command = new SqlCommand("SELECT * FROM tblEquipe", conn))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    unDouble = false;
                    foreach (CEquipe cc in equipeList)
                    {
                        if (reader.GetInt32(0) == cc.IdEquipe)
                        {
                            unDouble = true;
                        }
                    }
                    if (unDouble == false)
                    {
                        int idEquipe= reader.GetInt32(0);
                        string nom = reader.GetString(1);
                        string tag = reader.GetString(2);

                       equipe= new CEquipe(idEquipe, nom,tag);
                       equipeList.Add(equipe);

                    }

                }
            }
            conn.Close();
        }

        static void AddCategorieTest(string nom, string description)
        {

            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO tblCategorieTest(nom,description) VALUES(@nom, @description)", conn))
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
        static void DisplayCategTest()
        {

            bool unDouble;
            conn.Open();

            using (SqlCommand command = new SqlCommand("SELECT * FROM tblCategorieTest", conn))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    unDouble = false;
                    foreach (CCategorieTest cc in categTestList)
                    {
                        if (reader.GetInt32(0) == cc.IdCategorieTest)
                        {
                            unDouble = true;
                        }
                    }
                    if (unDouble == false)
                    {
                        int idCategTest = reader.GetInt32(0);
                        string nom = reader.GetString(1);
                        string desc = reader.GetString(2);
                        string tag = reader.GetString(3);

                        categTest = new CCategorieTest (idCategTest, nom, desc,tag);
                        categTestList.Add(categTest);

                    }

                }
            }
            conn.Close();
        }

        static void AddProjet(string nom,string description,int idJeu)
        {

            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO tblProjet(nom,description,idJeu) VALUES(@nom, @description,@idJeu)", conn))
                {
                    command.Parameters.Add(new SqlParameter("nom", nom));
                    command.Parameters.Add(new SqlParameter("description", description));
                     command.Parameters.Add(new SqlParameter("idCategorieTest", idJeu));

                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                //Console.WriteLine("Count not insert.");
            }
            conn.Close();

        }

        static void DisplayProjet()
        {

            bool unDouble;
            conn.Open();

            using (SqlCommand command = new SqlCommand("SELECT * FROM tblProjet", conn))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    unDouble = false;
                    foreach (CProjet cc in projetList)
                    {
                        if (reader.GetInt32(0) == cc.IdProjet)
                        {
                            unDouble = true;
                        }
                    }
                    if (unDouble == false)
                    {
                        int idProjet = reader.GetInt32(0);
                        string nom = reader.GetString(1);
                        string desc = reader.GetString(2);
                        int idJeu = reader.GetInt32(3);
                        string tag = reader.GetString(4);

                        projet = new CProjet(idProjet,idJeu, nom, desc, tag);
                        projetList.Add(projet);

                    }

                }
            }
            conn.Close();
        }
        static void AddTest(int resutlat,string nom, string description,int idCategorieTest)
        {

            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO tblTest(resultat,nom,description,idCategorieTest) VALUES(@resultat,@nom, @description,@idCategorieTest)", conn))
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
        static void DisplayTest()
        {

            bool unDouble;
            conn.Open();

            using (SqlCommand command = new SqlCommand("SELECT * FROM tblTest", conn))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    unDouble = false;
                    foreach (CTest cc in testList)
                    {
                        if (reader.GetInt32(0) == cc.IdTest)
                        {
                            unDouble = true;
                        }
                    }
                    if (unDouble == false)
                    {
                        int idTest = reader.GetInt32(0);
                        int result = reader.GetInt32(1);
                        string desc = reader.GetString(2);
                        int idCateg = reader.GetInt32(3);
                        string tag = reader.GetString(4);

                        test= new CTest(idTest, idCateg, result, desc, tag);
                        testList.Add(test);

                    }

                }
            }
            conn.Close();
        }

        static void AddWrok(int idTest, int idEquipe,int idProjet)
        {

            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO tblTravail(idTest,idEquipe,idProjet) VALUES(@idTest, @idEquipe,@idProjet)", conn))
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


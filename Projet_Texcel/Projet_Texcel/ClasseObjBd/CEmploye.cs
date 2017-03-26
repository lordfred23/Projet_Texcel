using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Texcel.ClasseObjBd
{
    public class CEmploye
    {
        int idRole;
        string matricule, nom, prenom, dateNaissance, adresse, noTelephone, posteTelephone, noTelephoneMaison, tag;

        public CEmploye(string matricule,string nom,string prenom,string dateNaissance,string adresse,string noTelephone,string posteTelephone,string noTelephoneMaison,string tag,int idRole)
        {
            Matricule = matricule;
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            Adresse = adresse;
            NoTelephone = noTelephone;
            PosteTelephone = posteTelephone;
            NoTelephoneMaison = noTelephoneMaison;
            Tag = tag;
            IdRole = idRole;

        }

        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

        public string DateNaissance
        {
            get
            {
                return dateNaissance;
            }

            set
            {
                dateNaissance = value;
            }
        }

        public int IdRole
        {
            get
            {
                return idRole;
            }

            set
            {
                idRole = value;
            }
        }

        public string Matricule
        {
            get
            {
                return matricule;
            }

            set
            {
                matricule = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string NoTelephone
        {
            get
            {
                return noTelephone;
            }

            set
            {
                noTelephone = value;
            }
        }

        public string NoTelephoneMaison
        {
            get
            {
                return noTelephoneMaison;
            }

            set
            {
                noTelephoneMaison = value;
            }
        }

        public string PosteTelephone
        {
            get
            {
                return posteTelephone;
            }

            set
            {
                posteTelephone = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public string Tag
        {
            get
            {
                return tag;
            }

            set
            {
                tag = value;
            }
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AFPABNBADMIN
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AfpaBNBEntities : DbContext
    {
        public AfpaBNBEntities()
            : base("name=AfpaBNBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Adresse> Adresses { get; set; }
        public virtual DbSet<Avi> Avis { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<DispoHeberg> DispoHebergs { get; set; }
        public virtual DbSet<Favori> Favoris { get; set; }
        public virtual DbSet<Hebergement> Hebergements { get; set; }
        public virtual DbSet<Messagerie> Messageries { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Saison> Saisons { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    
        public virtual int sp_AddClient(string nom, string prenom, string email, string telephone, string login, string password, Nullable<bool> type, string nomAdresse, string numero, string voie, string ville, string codePostal)
        {
            var nomParameter = nom != null ?
                new ObjectParameter("Nom", nom) :
                new ObjectParameter("Nom", typeof(string));
    
            var prenomParameter = prenom != null ?
                new ObjectParameter("Prenom", prenom) :
                new ObjectParameter("Prenom", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var telephoneParameter = telephone != null ?
                new ObjectParameter("Telephone", telephone) :
                new ObjectParameter("Telephone", typeof(string));
    
            var loginParameter = login != null ?
                new ObjectParameter("Login", login) :
                new ObjectParameter("Login", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var typeParameter = type.HasValue ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(bool));
    
            var nomAdresseParameter = nomAdresse != null ?
                new ObjectParameter("NomAdresse", nomAdresse) :
                new ObjectParameter("NomAdresse", typeof(string));
    
            var numeroParameter = numero != null ?
                new ObjectParameter("Numero", numero) :
                new ObjectParameter("Numero", typeof(string));
    
            var voieParameter = voie != null ?
                new ObjectParameter("Voie", voie) :
                new ObjectParameter("Voie", typeof(string));
    
            var villeParameter = ville != null ?
                new ObjectParameter("Ville", ville) :
                new ObjectParameter("Ville", typeof(string));
    
            var codePostalParameter = codePostal != null ?
                new ObjectParameter("CodePostal", codePostal) :
                new ObjectParameter("CodePostal", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AddClient", nomParameter, prenomParameter, emailParameter, telephoneParameter, loginParameter, passwordParameter, typeParameter, nomAdresseParameter, numeroParameter, voieParameter, villeParameter, codePostalParameter);
        }
    
        public virtual int sp_AddFavoris(Nullable<int> idClient, Nullable<int> idHebergement)
        {
            var idClientParameter = idClient.HasValue ?
                new ObjectParameter("IdClient", idClient) :
                new ObjectParameter("IdClient", typeof(int));
    
            var idHebergementParameter = idHebergement.HasValue ?
                new ObjectParameter("IdHebergement", idHebergement) :
                new ObjectParameter("IdHebergement", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AddFavoris", idClientParameter, idHebergementParameter);
        }
    
        public virtual int sp_AddHebergement(Nullable<int> idClient, string nomHebergement, string photo, string type, string description, string nomAdresse, string numero, string voie, string ville, string codePostal)
        {
            var idClientParameter = idClient.HasValue ?
                new ObjectParameter("IdClient", idClient) :
                new ObjectParameter("IdClient", typeof(int));
    
            var nomHebergementParameter = nomHebergement != null ?
                new ObjectParameter("NomHebergement", nomHebergement) :
                new ObjectParameter("NomHebergement", typeof(string));
    
            var photoParameter = photo != null ?
                new ObjectParameter("Photo", photo) :
                new ObjectParameter("Photo", typeof(string));
    
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var nomAdresseParameter = nomAdresse != null ?
                new ObjectParameter("NomAdresse", nomAdresse) :
                new ObjectParameter("NomAdresse", typeof(string));
    
            var numeroParameter = numero != null ?
                new ObjectParameter("Numero", numero) :
                new ObjectParameter("Numero", typeof(string));
    
            var voieParameter = voie != null ?
                new ObjectParameter("Voie", voie) :
                new ObjectParameter("Voie", typeof(string));
    
            var villeParameter = ville != null ?
                new ObjectParameter("Ville", ville) :
                new ObjectParameter("Ville", typeof(string));
    
            var codePostalParameter = codePostal != null ?
                new ObjectParameter("CodePostal", codePostal) :
                new ObjectParameter("CodePostal", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AddHebergement", idClientParameter, nomHebergementParameter, photoParameter, typeParameter, descriptionParameter, nomAdresseParameter, numeroParameter, voieParameter, villeParameter, codePostalParameter);
        }
    
        public virtual int sp_AddReservation(Nullable<int> idClient, Nullable<int> idHebergement)
        {
            var idClientParameter = idClient.HasValue ?
                new ObjectParameter("IdClient", idClient) :
                new ObjectParameter("IdClient", typeof(int));
    
            var idHebergementParameter = idHebergement.HasValue ?
                new ObjectParameter("IdHebergement", idHebergement) :
                new ObjectParameter("IdHebergement", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AddReservation", idClientParameter, idHebergementParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_DelFavoris(Nullable<int> idClient, Nullable<int> idHebergement)
        {
            var idClientParameter = idClient.HasValue ?
                new ObjectParameter("IdClient", idClient) :
                new ObjectParameter("IdClient", typeof(int));
    
            var idHebergementParameter = idHebergement.HasValue ?
                new ObjectParameter("IdHebergement", idHebergement) :
                new ObjectParameter("IdHebergement", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DelFavoris", idClientParameter, idHebergementParameter);
        }
    
        public virtual int sp_DelReservation(Nullable<int> idClient, Nullable<int> idHebergement)
        {
            var idClientParameter = idClient.HasValue ?
                new ObjectParameter("IdClient", idClient) :
                new ObjectParameter("IdClient", typeof(int));
    
            var idHebergementParameter = idHebergement.HasValue ?
                new ObjectParameter("IdHebergement", idHebergement) :
                new ObjectParameter("IdHebergement", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DelReservation", idClientParameter, idHebergementParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_getClient_Result> sp_getClient(string login, string password)
        {
            var loginParameter = login != null ?
                new ObjectParameter("login", login) :
                new ObjectParameter("login", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getClient_Result>("sp_getClient", loginParameter, passwordParameter);
        }
    
        public virtual int sp_getFavoris(Nullable<int> idClient)
        {
            var idClientParameter = idClient.HasValue ?
                new ObjectParameter("IdClient", idClient) :
                new ObjectParameter("IdClient", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_getFavoris", idClientParameter);
        }
    
        public virtual ObjectResult<sp_getHebergements_Result> sp_getHebergements()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getHebergements_Result>("sp_getHebergements");
        }
    
        public virtual ObjectResult<sp_getReservation_Result> sp_getReservation(Nullable<int> idClient)
        {
            var idClientParameter = idClient.HasValue ?
                new ObjectParameter("IdClient", idClient) :
                new ObjectParameter("IdClient", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getReservation_Result>("sp_getReservation", idClientParameter);
        }
    
        public virtual int sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}

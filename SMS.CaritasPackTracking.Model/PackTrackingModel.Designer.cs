﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("PackTrackingDatabaseModel", "AssistitoRitiro", "Assistito", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(SMS.CaritasPackTracking.Model.Assistito), "Ritiro", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(SMS.CaritasPackTracking.Model.Ritiro))]

#endregion

namespace SMS.CaritasPackTracking.Model
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class PackTrackingDatabaseEntities1 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new PackTrackingDatabaseEntities1 object using the connection string found in the 'PackTrackingDatabaseEntities1' section of the application configuration file.
        /// </summary>
        public PackTrackingDatabaseEntities1() : base("name=PackTrackingDatabaseEntities1", "PackTrackingDatabaseEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new PackTrackingDatabaseEntities1 object.
        /// </summary>
        public PackTrackingDatabaseEntities1(string connectionString) : base(connectionString, "PackTrackingDatabaseEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new PackTrackingDatabaseEntities1 object.
        /// </summary>
        public PackTrackingDatabaseEntities1(EntityConnection connection) : base(connection, "PackTrackingDatabaseEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Assistito> Assistito
        {
            get
            {
                if ((_Assistito == null))
                {
                    _Assistito = base.CreateObjectSet<Assistito>("Assistito");
                }
                return _Assistito;
            }
        }
        private ObjectSet<Assistito> _Assistito;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Ritiro> Ritiro
        {
            get
            {
                if ((_Ritiro == null))
                {
                    _Ritiro = base.CreateObjectSet<Ritiro>("Ritiro");
                }
                return _Ritiro;
            }
        }
        private ObjectSet<Ritiro> _Ritiro;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Assistito EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAssistito(Assistito assistito)
        {
            base.AddObject("Assistito", assistito);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Ritiro EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToRitiro(Ritiro ritiro)
        {
            base.AddObject("Ritiro", ritiro);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PackTrackingDatabaseModel", Name="Assistito")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Assistito : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Assistito object.
        /// </summary>
        /// <param name="numeroTessera">Initial value of the NumeroTessera property.</param>
        public static Assistito CreateAssistito(global::System.Int32 numeroTessera)
        {
            Assistito assistito = new Assistito();
            assistito.NumeroTessera = numeroTessera;
            return assistito;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 NumeroTessera
        {
            get
            {
                return _NumeroTessera;
            }
            set
            {
                if (_NumeroTessera != value)
                {
                    OnNumeroTesseraChanging(value);
                    ReportPropertyChanging("NumeroTessera");
                    _NumeroTessera = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("NumeroTessera");
                    OnNumeroTesseraChanged();
                }
            }
        }
        private global::System.Int32 _NumeroTessera;
        partial void OnNumeroTesseraChanging(global::System.Int32 value);
        partial void OnNumeroTesseraChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Nome
        {
            get
            {
                return _Nome;
            }
            set
            {
                OnNomeChanging(value);
                ReportPropertyChanging("Nome");
                _Nome = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Nome");
                OnNomeChanged();
            }
        }
        private global::System.String _Nome;
        partial void OnNomeChanging(global::System.String value);
        partial void OnNomeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Cognome
        {
            get
            {
                return _Cognome;
            }
            set
            {
                OnCognomeChanging(value);
                ReportPropertyChanging("Cognome");
                _Cognome = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Cognome");
                OnCognomeChanged();
            }
        }
        private global::System.String _Cognome;
        partial void OnCognomeChanging(global::System.String value);
        partial void OnCognomeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ComuneDiNascita
        {
            get
            {
                return _ComuneDiNascita;
            }
            set
            {
                OnComuneDiNascitaChanging(value);
                ReportPropertyChanging("ComuneDiNascita");
                _ComuneDiNascita = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ComuneDiNascita");
                OnComuneDiNascitaChanged();
            }
        }
        private global::System.String _ComuneDiNascita;
        partial void OnComuneDiNascitaChanging(global::System.String value);
        partial void OnComuneDiNascitaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> DataDiNascita
        {
            get
            {
                return _DataDiNascita;
            }
            set
            {
                OnDataDiNascitaChanging(value);
                ReportPropertyChanging("DataDiNascita");
                _DataDiNascita = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DataDiNascita");
                OnDataDiNascitaChanged();
            }
        }
        private Nullable<global::System.DateTime> _DataDiNascita;
        partial void OnDataDiNascitaChanging(Nullable<global::System.DateTime> value);
        partial void OnDataDiNascitaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Indirizzo
        {
            get
            {
                return _Indirizzo;
            }
            set
            {
                OnIndirizzoChanging(value);
                ReportPropertyChanging("Indirizzo");
                _Indirizzo = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Indirizzo");
                OnIndirizzoChanged();
            }
        }
        private global::System.String _Indirizzo;
        partial void OnIndirizzoChanging(global::System.String value);
        partial void OnIndirizzoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CAP
        {
            get
            {
                return _CAP;
            }
            set
            {
                OnCAPChanging(value);
                ReportPropertyChanging("CAP");
                _CAP = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("CAP");
                OnCAPChanged();
            }
        }
        private global::System.String _CAP;
        partial void OnCAPChanging(global::System.String value);
        partial void OnCAPChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int16> ComponentiNucleoFamiliare
        {
            get
            {
                return _ComponentiNucleoFamiliare;
            }
            set
            {
                OnComponentiNucleoFamiliareChanging(value);
                ReportPropertyChanging("ComponentiNucleoFamiliare");
                _ComponentiNucleoFamiliare = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ComponentiNucleoFamiliare");
                OnComponentiNucleoFamiliareChanged();
            }
        }
        private Nullable<global::System.Int16> _ComponentiNucleoFamiliare;
        partial void OnComponentiNucleoFamiliareChanging(Nullable<global::System.Int16> value);
        partial void OnComponentiNucleoFamiliareChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String TelefonoAbitazione
        {
            get
            {
                return _TelefonoAbitazione;
            }
            set
            {
                OnTelefonoAbitazioneChanging(value);
                ReportPropertyChanging("TelefonoAbitazione");
                _TelefonoAbitazione = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("TelefonoAbitazione");
                OnTelefonoAbitazioneChanged();
            }
        }
        private global::System.String _TelefonoAbitazione;
        partial void OnTelefonoAbitazioneChanging(global::System.String value);
        partial void OnTelefonoAbitazioneChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String TelefonoCellulare
        {
            get
            {
                return _TelefonoCellulare;
            }
            set
            {
                OnTelefonoCellulareChanging(value);
                ReportPropertyChanging("TelefonoCellulare");
                _TelefonoCellulare = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("TelefonoCellulare");
                OnTelefonoCellulareChanged();
            }
        }
        private global::System.String _TelefonoCellulare;
        partial void OnTelefonoCellulareChanging(global::System.String value);
        partial void OnTelefonoCellulareChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String StatoDiProvenienza
        {
            get
            {
                return _StatoDiProvenienza;
            }
            set
            {
                OnStatoDiProvenienzaChanging(value);
                ReportPropertyChanging("StatoDiProvenienza");
                _StatoDiProvenienza = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("StatoDiProvenienza");
                OnStatoDiProvenienzaChanged();
            }
        }
        private global::System.String _StatoDiProvenienza;
        partial void OnStatoDiProvenienzaChanging(global::System.String value);
        partial void OnStatoDiProvenienzaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Note
        {
            get
            {
                return _Note;
            }
            set
            {
                OnNoteChanging(value);
                ReportPropertyChanging("Note");
                _Note = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Note");
                OnNoteChanged();
            }
        }
        private global::System.String _Note;
        partial void OnNoteChanging(global::System.String value);
        partial void OnNoteChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> DataConsegnaOlio
        {
            get
            {
                return _DataConsegnaOlio;
            }
            set
            {
                OnDataConsegnaOlioChanging(value);
                ReportPropertyChanging("DataConsegnaOlio");
                _DataConsegnaOlio = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DataConsegnaOlio");
                OnDataConsegnaOlioChanged();
            }
        }
        private Nullable<global::System.DateTime> _DataConsegnaOlio;
        partial void OnDataConsegnaOlioChanging(Nullable<global::System.DateTime> value);
        partial void OnDataConsegnaOlioChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> DataConsegnaCaffe
        {
            get
            {
                return _DataConsegnaCaffe;
            }
            set
            {
                OnDataConsegnaCaffeChanging(value);
                ReportPropertyChanging("DataConsegnaCaffe");
                _DataConsegnaCaffe = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DataConsegnaCaffe");
                OnDataConsegnaCaffeChanged();
            }
        }
        private Nullable<global::System.DateTime> _DataConsegnaCaffe;
        partial void OnDataConsegnaCaffeChanging(Nullable<global::System.DateTime> value);
        partial void OnDataConsegnaCaffeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> DataScadenzaAssistenza
        {
            get
            {
                return _DataScadenzaAssistenza;
            }
            set
            {
                OnDataScadenzaAssistenzaChanging(value);
                ReportPropertyChanging("DataScadenzaAssistenza");
                _DataScadenzaAssistenza = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DataScadenzaAssistenza");
                OnDataScadenzaAssistenzaChanged();
            }
        }
        private Nullable<global::System.DateTime> _DataScadenzaAssistenza;
        partial void OnDataScadenzaAssistenzaChanging(Nullable<global::System.DateTime> value);
        partial void OnDataScadenzaAssistenzaChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("PackTrackingDatabaseModel", "AssistitoRitiro", "Ritiro")]
        public EntityCollection<Ritiro> Ritiro
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Ritiro>("PackTrackingDatabaseModel.AssistitoRitiro", "Ritiro");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Ritiro>("PackTrackingDatabaseModel.AssistitoRitiro", "Ritiro", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PackTrackingDatabaseModel", Name="Ritiro")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Ritiro : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Ritiro object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="data">Initial value of the Data property.</param>
        public static Ritiro CreateRitiro(global::System.Int32 id, global::System.DateTime data)
        {
            Ritiro ritiro = new Ritiro();
            ritiro.Id = id;
            ritiro.Data = data;
            return ritiro;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime Data
        {
            get
            {
                return _Data;
            }
            set
            {
                OnDataChanging(value);
                ReportPropertyChanging("Data");
                _Data = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Data");
                OnDataChanged();
            }
        }
        private global::System.DateTime _Data;
        partial void OnDataChanging(global::System.DateTime value);
        partial void OnDataChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Note
        {
            get
            {
                return _Note;
            }
            set
            {
                OnNoteChanging(value);
                ReportPropertyChanging("Note");
                _Note = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Note");
                OnNoteChanged();
            }
        }
        private global::System.String _Note;
        partial void OnNoteChanging(global::System.String value);
        partial void OnNoteChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("PackTrackingDatabaseModel", "AssistitoRitiro", "Assistito")]
        public Assistito Assistito
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Assistito>("PackTrackingDatabaseModel.AssistitoRitiro", "Assistito").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Assistito>("PackTrackingDatabaseModel.AssistitoRitiro", "Assistito").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Assistito> AssistitoReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Assistito>("PackTrackingDatabaseModel.AssistitoRitiro", "Assistito");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Assistito>("PackTrackingDatabaseModel.AssistitoRitiro", "Assistito", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}

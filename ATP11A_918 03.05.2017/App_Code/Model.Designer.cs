﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5420
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]
[assembly: global::System.Data.Objects.DataClasses.EdmRelationshipAttribute("ATP11A_918Model", "FK_oteller_sehirler", "sehirler", global::System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(ATP11A_918Model.sehirler), "oteller", global::System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(ATP11A_918Model.oteller))]

// Original file name:
// Generation date: 02.05.2017 09:35:21
namespace ATP11A_918Model
{
    
    /// <summary>
    /// There are no comments for ATP11A_918Entities in the schema.
    /// </summary>
    public partial class ATP11A_918Entities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new ATP11A_918Entities object using the connection string found in the 'ATP11A_918Entities' section of the application configuration file.
        /// </summary>
        public ATP11A_918Entities() : 
                base("name=ATP11A_918Entities", "ATP11A_918Entities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new ATP11A_918Entities object.
        /// </summary>
        public ATP11A_918Entities(string connectionString) : 
                base(connectionString, "ATP11A_918Entities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new ATP11A_918Entities object.
        /// </summary>
        public ATP11A_918Entities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "ATP11A_918Entities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for oteller in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<oteller> oteller
        {
            get
            {
                if ((this._oteller == null))
                {
                    this._oteller = base.CreateQuery<oteller>("[oteller]");
                }
                return this._oteller;
            }
        }
        private global::System.Data.Objects.ObjectQuery<oteller> _oteller;
        /// <summary>
        /// There are no comments for sehirler in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<sehirler> sehirler
        {
            get
            {
                if ((this._sehirler == null))
                {
                    this._sehirler = base.CreateQuery<sehirler>("[sehirler]");
                }
                return this._sehirler;
            }
        }
        private global::System.Data.Objects.ObjectQuery<sehirler> _sehirler;
        /// <summary>
        /// There are no comments for sysdiagrams in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<sysdiagrams> sysdiagrams
        {
            get
            {
                if ((this._sysdiagrams == null))
                {
                    this._sysdiagrams = base.CreateQuery<sysdiagrams>("[sysdiagrams]");
                }
                return this._sysdiagrams;
            }
        }
        private global::System.Data.Objects.ObjectQuery<sysdiagrams> _sysdiagrams;
        /// <summary>
        /// There are no comments for oteller in the schema.
        /// </summary>
        public void AddTooteller(oteller oteller)
        {
            base.AddObject("oteller", oteller);
        }
        /// <summary>
        /// There are no comments for sehirler in the schema.
        /// </summary>
        public void AddTosehirler(sehirler sehirler)
        {
            base.AddObject("sehirler", sehirler);
        }
        /// <summary>
        /// There are no comments for sysdiagrams in the schema.
        /// </summary>
        public void AddTosysdiagrams(sysdiagrams sysdiagrams)
        {
            base.AddObject("sysdiagrams", sysdiagrams);
        }
    }
    /// <summary>
    /// There are no comments for ATP11A_918Model.oteller in the schema.
    /// </summary>
    /// <KeyProperties>
    /// otelId
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="ATP11A_918Model", Name="oteller")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class oteller : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new oteller object.
        /// </summary>
        /// <param name="otelId">Initial value of otelId.</param>
        /// <param name="otelAd">Initial value of otelAd.</param>
        /// <param name="aciklama">Initial value of aciklama.</param>
        public static oteller Createoteller(int otelId, string otelAd, string aciklama)
        {
            oteller oteller = new oteller();
            oteller.otelId = otelId;
            oteller.otelAd = otelAd;
            oteller.aciklama = aciklama;
            return oteller;
        }
        /// <summary>
        /// There are no comments for Property otelId in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int otelId
        {
            get
            {
                return this._otelId;
            }
            set
            {
                this.OnotelIdChanging(value);
                this.ReportPropertyChanging("otelId");
                this._otelId = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("otelId");
                this.OnotelIdChanged();
            }
        }
        private int _otelId;
        partial void OnotelIdChanging(int value);
        partial void OnotelIdChanged();
        /// <summary>
        /// There are no comments for Property otelAd in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string otelAd
        {
            get
            {
                return this._otelAd;
            }
            set
            {
                this.OnotelAdChanging(value);
                this.ReportPropertyChanging("otelAd");
                this._otelAd = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("otelAd");
                this.OnotelAdChanged();
            }
        }
        private string _otelAd;
        partial void OnotelAdChanging(string value);
        partial void OnotelAdChanged();
        /// <summary>
        /// There are no comments for Property otelResim in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string otelResim
        {
            get
            {
                return this._otelResim;
            }
            set
            {
                this.OnotelResimChanging(value);
                this.ReportPropertyChanging("otelResim");
                this._otelResim = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("otelResim");
                this.OnotelResimChanged();
            }
        }
        private string _otelResim;
        partial void OnotelResimChanging(string value);
        partial void OnotelResimChanged();
        /// <summary>
        /// There are no comments for Property aciklama in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string aciklama
        {
            get
            {
                return this._aciklama;
            }
            set
            {
                this.OnaciklamaChanging(value);
                this.ReportPropertyChanging("aciklama");
                this._aciklama = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("aciklama");
                this.OnaciklamaChanged();
            }
        }
        private string _aciklama;
        partial void OnaciklamaChanging(string value);
        partial void OnaciklamaChanged();
        /// <summary>
        /// There are no comments for sehirler in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("ATP11A_918Model", "FK_oteller_sehirler", "sehirler")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public sehirler sehirler
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<sehirler>("ATP11A_918Model.FK_oteller_sehirler", "sehirler").Value;
            }
            set
            {
                ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<sehirler>("ATP11A_918Model.FK_oteller_sehirler", "sehirler").Value = value;
            }
        }
        /// <summary>
        /// There are no comments for sehirler in the schema.
        /// </summary>
        [global::System.ComponentModel.BrowsableAttribute(false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityReference<sehirler> sehirlerReference
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<sehirler>("ATP11A_918Model.FK_oteller_sehirler", "sehirler");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<sehirler>("ATP11A_918Model.FK_oteller_sehirler", "sehirler", value);
                }
            }
        }
    }
    /// <summary>
    /// There are no comments for ATP11A_918Model.sehirler in the schema.
    /// </summary>
    /// <KeyProperties>
    /// sehirId
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="ATP11A_918Model", Name="sehirler")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class sehirler : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new sehirler object.
        /// </summary>
        /// <param name="sehirId">Initial value of sehirId.</param>
        /// <param name="sehirAd">Initial value of sehirAd.</param>
        public static sehirler Createsehirler(int sehirId, string sehirAd)
        {
            sehirler sehirler = new sehirler();
            sehirler.sehirId = sehirId;
            sehirler.sehirAd = sehirAd;
            return sehirler;
        }
        /// <summary>
        /// There are no comments for Property sehirId in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int sehirId
        {
            get
            {
                return this._sehirId;
            }
            set
            {
                this.OnsehirIdChanging(value);
                this.ReportPropertyChanging("sehirId");
                this._sehirId = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("sehirId");
                this.OnsehirIdChanged();
            }
        }
        private int _sehirId;
        partial void OnsehirIdChanging(int value);
        partial void OnsehirIdChanged();
        /// <summary>
        /// There are no comments for Property sehirAd in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string sehirAd
        {
            get
            {
                return this._sehirAd;
            }
            set
            {
                this.OnsehirAdChanging(value);
                this.ReportPropertyChanging("sehirAd");
                this._sehirAd = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("sehirAd");
                this.OnsehirAdChanged();
            }
        }
        private string _sehirAd;
        partial void OnsehirAdChanging(string value);
        partial void OnsehirAdChanged();
        /// <summary>
        /// There are no comments for oteller in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("ATP11A_918Model", "FK_oteller_sehirler", "oteller")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityCollection<oteller> oteller
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<oteller>("ATP11A_918Model.FK_oteller_sehirler", "oteller");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<oteller>("ATP11A_918Model.FK_oteller_sehirler", "oteller", value);
                }
            }
        }
    }
    /// <summary>
    /// There are no comments for ATP11A_918Model.sysdiagrams in the schema.
    /// </summary>
    /// <KeyProperties>
    /// diagram_id
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="ATP11A_918Model", Name="sysdiagrams")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class sysdiagrams : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new sysdiagrams object.
        /// </summary>
        /// <param name="name">Initial value of name.</param>
        /// <param name="principal_id">Initial value of principal_id.</param>
        /// <param name="diagram_id">Initial value of diagram_id.</param>
        public static sysdiagrams Createsysdiagrams(string name, int principal_id, int diagram_id)
        {
            sysdiagrams sysdiagrams = new sysdiagrams();
            sysdiagrams.name = name;
            sysdiagrams.principal_id = principal_id;
            sysdiagrams.diagram_id = diagram_id;
            return sysdiagrams;
        }
        /// <summary>
        /// There are no comments for Property name in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this.OnnameChanging(value);
                this.ReportPropertyChanging("name");
                this._name = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("name");
                this.OnnameChanged();
            }
        }
        private string _name;
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
        /// <summary>
        /// There are no comments for Property principal_id in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int principal_id
        {
            get
            {
                return this._principal_id;
            }
            set
            {
                this.Onprincipal_idChanging(value);
                this.ReportPropertyChanging("principal_id");
                this._principal_id = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("principal_id");
                this.Onprincipal_idChanged();
            }
        }
        private int _principal_id;
        partial void Onprincipal_idChanging(int value);
        partial void Onprincipal_idChanged();
        /// <summary>
        /// There are no comments for Property diagram_id in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int diagram_id
        {
            get
            {
                return this._diagram_id;
            }
            set
            {
                this.Ondiagram_idChanging(value);
                this.ReportPropertyChanging("diagram_id");
                this._diagram_id = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("diagram_id");
                this.Ondiagram_idChanged();
            }
        }
        private int _diagram_id;
        partial void Ondiagram_idChanging(int value);
        partial void Ondiagram_idChanged();
        /// <summary>
        /// There are no comments for Property version in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<int> version
        {
            get
            {
                return this._version;
            }
            set
            {
                this.OnversionChanging(value);
                this.ReportPropertyChanging("version");
                this._version = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("version");
                this.OnversionChanged();
            }
        }
        private global::System.Nullable<int> _version;
        partial void OnversionChanging(global::System.Nullable<int> value);
        partial void OnversionChanged();
        /// <summary>
        /// There are no comments for Property definition in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] definition
        {
            get
            {
                return global::System.Data.Objects.DataClasses.StructuralObject.GetValidValue(this._definition);
            }
            set
            {
                this.OndefinitionChanging(value);
                this.ReportPropertyChanging("definition");
                this._definition = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("definition");
                this.OndefinitionChanged();
            }
        }
        private byte[] _definition;
        partial void OndefinitionChanging(byte[] value);
        partial void OndefinitionChanged();
    }
}

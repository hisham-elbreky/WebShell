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

[assembly: EdmRelationshipAttribute("WebNoteModel", "FK_KeyValue_Keyword", "Keyword", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(WebShell.Providers.Localize.Keyword), "KeyValue", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(WebShell.Providers.Localize.KeyValue), true)]
[assembly: EdmRelationshipAttribute("WebNoteModel", "FK_KeyValue_Language", "Language", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(WebShell.Providers.Localize.Language), "KeyValue", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(WebShell.Providers.Localize.KeyValue), true)]

#endregion

namespace WebShell.Providers.Localize
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class LocalizationEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new LocalizationEntities object using the connection string found in the 'LocalizationEntities' section of the application configuration file.
        /// </summary>
        public LocalizationEntities() : base("name=LocalizationEntities", "LocalizationEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new LocalizationEntities object.
        /// </summary>
        public LocalizationEntities(string connectionString) : base(connectionString, "LocalizationEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new LocalizationEntities object.
        /// </summary>
        public LocalizationEntities(EntityConnection connection) : base(connection, "LocalizationEntities")
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
        public ObjectSet<KeyValue> KeyValues
        {
            get
            {
                if ((_KeyValues == null))
                {
                    _KeyValues = base.CreateObjectSet<KeyValue>("KeyValues");
                }
                return _KeyValues;
            }
        }
        private ObjectSet<KeyValue> _KeyValues;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Keyword> Keywords
        {
            get
            {
                if ((_Keywords == null))
                {
                    _Keywords = base.CreateObjectSet<Keyword>("Keywords");
                }
                return _Keywords;
            }
        }
        private ObjectSet<Keyword> _Keywords;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Language> Languages
        {
            get
            {
                if ((_Languages == null))
                {
                    _Languages = base.CreateObjectSet<Language>("Languages");
                }
                return _Languages;
            }
        }
        private ObjectSet<Language> _Languages;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the KeyValues EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToKeyValues(KeyValue keyValue)
        {
            base.AddObject("KeyValues", keyValue);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Keywords EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToKeywords(Keyword keyword)
        {
            base.AddObject("Keywords", keyword);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Languages EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToLanguages(Language language)
        {
            base.AddObject("Languages", language);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="WebNoteModel", Name="KeyValue")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class KeyValue : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new KeyValue object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="languageId">Initial value of the LanguageId property.</param>
        /// <param name="keywordId">Initial value of the KeywordId property.</param>
        /// <param name="value">Initial value of the Value property.</param>
        public static KeyValue CreateKeyValue(global::System.Int64 id, global::System.Int64 languageId, global::System.Int64 keywordId, global::System.String value)
        {
            KeyValue keyValue = new KeyValue();
            keyValue.Id = id;
            keyValue.LanguageId = languageId;
            keyValue.KeywordId = keywordId;
            keyValue.Value = value;
            return keyValue;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 Id
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
        private global::System.Int64 _Id;
        partial void OnIdChanging(global::System.Int64 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 LanguageId
        {
            get
            {
                return _LanguageId;
            }
            set
            {
                OnLanguageIdChanging(value);
                ReportPropertyChanging("LanguageId");
                _LanguageId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LanguageId");
                OnLanguageIdChanged();
            }
        }
        private global::System.Int64 _LanguageId;
        partial void OnLanguageIdChanging(global::System.Int64 value);
        partial void OnLanguageIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 KeywordId
        {
            get
            {
                return _KeywordId;
            }
            set
            {
                OnKeywordIdChanging(value);
                ReportPropertyChanging("KeywordId");
                _KeywordId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("KeywordId");
                OnKeywordIdChanged();
            }
        }
        private global::System.Int64 _KeywordId;
        partial void OnKeywordIdChanging(global::System.Int64 value);
        partial void OnKeywordIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Value
        {
            get
            {
                return _Value;
            }
            set
            {
                OnValueChanging(value);
                ReportPropertyChanging("Value");
                _Value = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Value");
                OnValueChanged();
            }
        }
        private global::System.String _Value;
        partial void OnValueChanging(global::System.String value);
        partial void OnValueChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("WebNoteModel", "FK_KeyValue_Keyword", "Keyword")]
        public Keyword Keyword
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Keyword>("WebNoteModel.FK_KeyValue_Keyword", "Keyword").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Keyword>("WebNoteModel.FK_KeyValue_Keyword", "Keyword").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Keyword> KeywordReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Keyword>("WebNoteModel.FK_KeyValue_Keyword", "Keyword");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Keyword>("WebNoteModel.FK_KeyValue_Keyword", "Keyword", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("WebNoteModel", "FK_KeyValue_Language", "Language")]
        public Language Language
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Language>("WebNoteModel.FK_KeyValue_Language", "Language").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Language>("WebNoteModel.FK_KeyValue_Language", "Language").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Language> LanguageReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Language>("WebNoteModel.FK_KeyValue_Language", "Language");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Language>("WebNoteModel.FK_KeyValue_Language", "Language", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="WebNoteModel", Name="Keyword")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Keyword : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Keyword object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the name property.</param>
        /// <param name="comment">Initial value of the comment property.</param>
        public static Keyword CreateKeyword(global::System.Int64 id, global::System.String name, global::System.Int64 comment)
        {
            Keyword keyword = new Keyword();
            keyword.Id = id;
            keyword.name = name;
            keyword.comment = comment;
            return keyword;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 Id
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
        private global::System.Int64 _Id;
        partial void OnIdChanging(global::System.Int64 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 comment
        {
            get
            {
                return _comment;
            }
            set
            {
                OncommentChanging(value);
                ReportPropertyChanging("comment");
                _comment = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("comment");
                OncommentChanged();
            }
        }
        private global::System.Int64 _comment;
        partial void OncommentChanging(global::System.Int64 value);
        partial void OncommentChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("WebNoteModel", "FK_KeyValue_Keyword", "KeyValue")]
        public EntityCollection<KeyValue> KeyValues
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<KeyValue>("WebNoteModel.FK_KeyValue_Keyword", "KeyValue");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<KeyValue>("WebNoteModel.FK_KeyValue_Keyword", "KeyValue", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="WebNoteModel", Name="Language")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Language : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Language object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the name property.</param>
        public static Language CreateLanguage(global::System.Int64 id, global::System.String name)
        {
            Language language = new Language();
            language.Id = id;
            language.name = name;
            return language;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 Id
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
        private global::System.Int64 _Id;
        partial void OnIdChanging(global::System.Int64 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String comment
        {
            get
            {
                return _comment;
            }
            set
            {
                OncommentChanging(value);
                ReportPropertyChanging("comment");
                _comment = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("comment");
                OncommentChanged();
            }
        }
        private global::System.String _comment;
        partial void OncommentChanging(global::System.String value);
        partial void OncommentChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("WebNoteModel", "FK_KeyValue_Language", "KeyValue")]
        public EntityCollection<KeyValue> KeyValues
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<KeyValue>("WebNoteModel.FK_KeyValue_Language", "KeyValue");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<KeyValue>("WebNoteModel.FK_KeyValue_Language", "KeyValue", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}

﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Recherche
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BD")]
	public partial class DCDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Définitions de méthodes d'extensibilité
    partial void OnCreated();
    partial void InsertHistorique(Historique instance);
    partial void UpdateHistorique(Historique instance);
    partial void DeleteHistorique(Historique instance);
    partial void InsertLien(Lien instance);
    partial void UpdateLien(Lien instance);
    partial void DeleteLien(Lien instance);
    partial void InsertMot(Mot instance);
    partial void UpdateMot(Mot instance);
    partial void DeleteMot(Mot instance);
    partial void InsertSearch(Search instance);
    partial void UpdateSearch(Search instance);
    partial void DeleteSearch(Search instance);
    #endregion
		
		public DCDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["BDConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DCDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DCDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DCDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DCDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Historique> Historique
		{
			get
			{
				return this.GetTable<Historique>();
			}
		}
		
		public System.Data.Linq.Table<Lien> Lien
		{
			get
			{
				return this.GetTable<Lien>();
			}
		}
		
		public System.Data.Linq.Table<Mot> Mot
		{
			get
			{
				return this.GetTable<Mot>();
			}
		}
		
		public System.Data.Linq.Table<Search> Search
		{
			get
			{
				return this.GetTable<Search>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Historique")]
	public partial class Historique : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdHistorique;
		
		private System.Nullable<int> _IdSearch;
		
		private System.Nullable<System.DateTime> _Date;
		
		private EntityRef<Search> _Search;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdHistoriqueChanging(int value);
    partial void OnIdHistoriqueChanged();
    partial void OnIdSearchChanging(System.Nullable<int> value);
    partial void OnIdSearchChanged();
    partial void OnDateChanging(System.Nullable<System.DateTime> value);
    partial void OnDateChanged();
    #endregion
		
		public Historique()
		{
			this._Search = default(EntityRef<Search>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdHistorique", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdHistorique
		{
			get
			{
				return this._IdHistorique;
			}
			set
			{
				if ((this._IdHistorique != value))
				{
					this.OnIdHistoriqueChanging(value);
					this.SendPropertyChanging();
					this._IdHistorique = value;
					this.SendPropertyChanged("IdHistorique");
					this.OnIdHistoriqueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdSearch", DbType="Int")]
		public System.Nullable<int> IdSearch
		{
			get
			{
				return this._IdSearch;
			}
			set
			{
				if ((this._IdSearch != value))
				{
					if (this._Search.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdSearchChanging(value);
					this.SendPropertyChanging();
					this._IdSearch = value;
					this.SendPropertyChanged("IdSearch");
					this.OnIdSearchChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="Date")]
		public System.Nullable<System.DateTime> Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Search_Historique", Storage="_Search", ThisKey="IdSearch", OtherKey="IdSearch", IsForeignKey=true)]
		public Search Search
		{
			get
			{
				return this._Search.Entity;
			}
			set
			{
				Search previousValue = this._Search.Entity;
				if (((previousValue != value) 
							|| (this._Search.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Search.Entity = null;
						previousValue.Historique.Remove(this);
					}
					this._Search.Entity = value;
					if ((value != null))
					{
						value.Historique.Add(this);
						this._IdSearch = value.IdSearch;
					}
					else
					{
						this._IdSearch = default(Nullable<int>);
					}
					this.SendPropertyChanged("Search");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Lien")]
	public partial class Lien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdLien;
		
		private string _Url;
		
		private string _title;
		
		private EntitySet<Search> _Search;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdLienChanging(int value);
    partial void OnIdLienChanged();
    partial void OnUrlChanging(string value);
    partial void OnUrlChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    #endregion
		
		public Lien()
		{
			this._Search = new EntitySet<Search>(new Action<Search>(this.attach_Search), new Action<Search>(this.detach_Search));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdLien", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdLien
		{
			get
			{
				return this._IdLien;
			}
			set
			{
				if ((this._IdLien != value))
				{
					this.OnIdLienChanging(value);
					this.SendPropertyChanging();
					this._IdLien = value;
					this.SendPropertyChanged("IdLien");
					this.OnIdLienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Url", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Url
		{
			get
			{
				return this._Url;
			}
			set
			{
				if ((this._Url != value))
				{
					this.OnUrlChanging(value);
					this.SendPropertyChanging();
					this._Url = value;
					this.SendPropertyChanged("Url");
					this.OnUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="NVarChar(100)")]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Lien_Search", Storage="_Search", ThisKey="IdLien", OtherKey="IdLien")]
		public EntitySet<Search> Search
		{
			get
			{
				return this._Search;
			}
			set
			{
				this._Search.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Search(Search entity)
		{
			this.SendPropertyChanging();
			entity.Lien = this;
		}
		
		private void detach_Search(Search entity)
		{
			this.SendPropertyChanging();
			entity.Lien = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Mot")]
	public partial class Mot : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdMot;
		
		private string _Text;
		
		private EntitySet<Search> _Search;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdMotChanging(int value);
    partial void OnIdMotChanged();
    partial void OnTextChanging(string value);
    partial void OnTextChanged();
    #endregion
		
		public Mot()
		{
			this._Search = new EntitySet<Search>(new Action<Search>(this.attach_Search), new Action<Search>(this.detach_Search));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdMot", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdMot
		{
			get
			{
				return this._IdMot;
			}
			set
			{
				if ((this._IdMot != value))
				{
					this.OnIdMotChanging(value);
					this.SendPropertyChanging();
					this._IdMot = value;
					this.SendPropertyChanged("IdMot");
					this.OnIdMotChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Text", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				if ((this._Text != value))
				{
					this.OnTextChanging(value);
					this.SendPropertyChanging();
					this._Text = value;
					this.SendPropertyChanged("Text");
					this.OnTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Mot_Search", Storage="_Search", ThisKey="IdMot", OtherKey="IdMot")]
		public EntitySet<Search> Search
		{
			get
			{
				return this._Search;
			}
			set
			{
				this._Search.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Search(Search entity)
		{
			this.SendPropertyChanging();
			entity.Mot = this;
		}
		
		private void detach_Search(Search entity)
		{
			this.SendPropertyChanging();
			entity.Mot = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Search")]
	public partial class Search : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdSearch;
		
		private System.Nullable<int> _IdMot;
		
		private System.Nullable<int> _IdLien;
		
		private EntitySet<Historique> _Historique;
		
		private EntityRef<Lien> _Lien;
		
		private EntityRef<Mot> _Mot;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdSearchChanging(int value);
    partial void OnIdSearchChanged();
    partial void OnIdMotChanging(System.Nullable<int> value);
    partial void OnIdMotChanged();
    partial void OnIdLienChanging(System.Nullable<int> value);
    partial void OnIdLienChanged();
    #endregion
		
		public Search()
		{
			this._Historique = new EntitySet<Historique>(new Action<Historique>(this.attach_Historique), new Action<Historique>(this.detach_Historique));
			this._Lien = default(EntityRef<Lien>);
			this._Mot = default(EntityRef<Mot>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdSearch", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdSearch
		{
			get
			{
				return this._IdSearch;
			}
			set
			{
				if ((this._IdSearch != value))
				{
					this.OnIdSearchChanging(value);
					this.SendPropertyChanging();
					this._IdSearch = value;
					this.SendPropertyChanged("IdSearch");
					this.OnIdSearchChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdMot", DbType="Int")]
		public System.Nullable<int> IdMot
		{
			get
			{
				return this._IdMot;
			}
			set
			{
				if ((this._IdMot != value))
				{
					if (this._Mot.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdMotChanging(value);
					this.SendPropertyChanging();
					this._IdMot = value;
					this.SendPropertyChanged("IdMot");
					this.OnIdMotChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdLien", DbType="Int")]
		public System.Nullable<int> IdLien
		{
			get
			{
				return this._IdLien;
			}
			set
			{
				if ((this._IdLien != value))
				{
					if (this._Lien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdLienChanging(value);
					this.SendPropertyChanging();
					this._IdLien = value;
					this.SendPropertyChanged("IdLien");
					this.OnIdLienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Search_Historique", Storage="_Historique", ThisKey="IdSearch", OtherKey="IdSearch")]
		public EntitySet<Historique> Historique
		{
			get
			{
				return this._Historique;
			}
			set
			{
				this._Historique.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Lien_Search", Storage="_Lien", ThisKey="IdLien", OtherKey="IdLien", IsForeignKey=true)]
		public Lien Lien
		{
			get
			{
				return this._Lien.Entity;
			}
			set
			{
				Lien previousValue = this._Lien.Entity;
				if (((previousValue != value) 
							|| (this._Lien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Lien.Entity = null;
						previousValue.Search.Remove(this);
					}
					this._Lien.Entity = value;
					if ((value != null))
					{
						value.Search.Add(this);
						this._IdLien = value.IdLien;
					}
					else
					{
						this._IdLien = default(Nullable<int>);
					}
					this.SendPropertyChanged("Lien");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Mot_Search", Storage="_Mot", ThisKey="IdMot", OtherKey="IdMot", IsForeignKey=true)]
		public Mot Mot
		{
			get
			{
				return this._Mot.Entity;
			}
			set
			{
				Mot previousValue = this._Mot.Entity;
				if (((previousValue != value) 
							|| (this._Mot.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Mot.Entity = null;
						previousValue.Search.Remove(this);
					}
					this._Mot.Entity = value;
					if ((value != null))
					{
						value.Search.Add(this);
						this._IdMot = value.IdMot;
					}
					else
					{
						this._IdMot = default(Nullable<int>);
					}
					this.SendPropertyChanged("Mot");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Historique(Historique entity)
		{
			this.SendPropertyChanging();
			entity.Search = this;
		}
		
		private void detach_Historique(Historique entity)
		{
			this.SendPropertyChanging();
			entity.Search = null;
		}
	}
}
#pragma warning restore 1591

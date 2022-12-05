﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalOOP2Project
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Movie_FinalDB_Project")]
	public partial class MovieTheatreDataClassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertManager(Manager instance);
    partial void UpdateManager(Manager instance);
    partial void DeleteManager(Manager instance);
    #endregion
		
		public MovieTheatreDataClassDataContext() : 
				base(global::FinalOOP2Project.Properties.Settings.Default.Movie_FinalDB_ProjectConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public MovieTheatreDataClassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MovieTheatreDataClassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MovieTheatreDataClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MovieTheatreDataClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Manager> Managers
		{
			get
			{
				return this.GetTable<Manager>();
			}
		}

        public System.Data.Linq.Table<ScreenRoom> ScreenRoom
        {
            get
            {
                return this.GetTable<ScreenRoom>();
            }
        }
		
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserId;
		
		private string _Username;
		
		private string _Password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(50)")]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Manager")]
	public partial class Manager : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ManagerID;
		
		private string _ManagerUsername;
		
		private string _ManagerPassword;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnManagerIDChanging(int value);
    partial void OnManagerIDChanged();
    partial void OnManagerUsernameChanging(string value);
    partial void OnManagerUsernameChanged();
    partial void OnManagerPasswordChanging(string value);
    partial void OnManagerPasswordChanged();
    #endregion
		
		public Manager()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ManagerID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ManagerID
		{
			get
			{
				return this._ManagerID;
			}
			set
			{
				if ((this._ManagerID != value))
				{
					this.OnManagerIDChanging(value);
					this.SendPropertyChanging();
					this._ManagerID = value;
					this.SendPropertyChanged("ManagerID");
					this.OnManagerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ManagerUsername", DbType="VarChar(50)")]
		public string ManagerUsername
		{
			get
			{
				return this._ManagerUsername;
			}
			set
			{
				if ((this._ManagerUsername != value))
				{
					this.OnManagerUsernameChanging(value);
					this.SendPropertyChanging();
					this._ManagerUsername = value;
					this.SendPropertyChanged("ManagerUsername");
					this.OnManagerUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ManagerPassword", DbType="VarChar(50)")]
		public string ManagerPassword
		{
			get
			{
				return this._ManagerPassword;
			}
			set
			{
				if ((this._ManagerPassword != value))
				{
					this.OnManagerPasswordChanging(value);
					this.SendPropertyChanging();
					this._ManagerPassword = value;
					this.SendPropertyChanged("ManagerPassword");
					this.OnManagerPasswordChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Movies")]
	public partial class Movie : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MovieId;
		
		private string _MovieName;
		
		private string _Genre;
		
		private int _DateOfRelease;
		
		private string _Actors;
		
		private EntitySet<ScreenRoom> _ScreenRooms;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMovieIdChanging(int value);
    partial void OnMovieIdChanged();
    partial void OnMovieNameChanging(string value);
    partial void OnMovieNameChanged();
    partial void OnGenreChanging(string value);
    partial void OnGenreChanged();
    partial void OnDateOfReleaseChanging(int value);
    partial void OnDateOfReleaseChanged();
    partial void OnActorsChanging(string value);
    partial void OnActorsChanged();
    #endregion
		
		public Movie()
		{
			this._ScreenRooms = new EntitySet<ScreenRoom>(new Action<ScreenRoom>(this.attach_ScreenRooms), new Action<ScreenRoom>(this.detach_ScreenRooms));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MovieId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MovieId
		{
			get
			{
				return this._MovieId;
			}
			set
			{
				if ((this._MovieId != value))
				{
					this.OnMovieIdChanging(value);
					this.SendPropertyChanging();
					this._MovieId = value;
					this.SendPropertyChanged("MovieId");
					this.OnMovieIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MovieName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string MovieName
		{
			get
			{
				return this._MovieName;
			}
			set
			{
				if ((this._MovieName != value))
				{
					this.OnMovieNameChanging(value);
					this.SendPropertyChanging();
					this._MovieName = value;
					this.SendPropertyChanged("MovieName");
					this.OnMovieNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Genre
		{
			get
			{
				return this._Genre;
			}
			set
			{
				if ((this._Genre != value))
				{
					this.OnGenreChanging(value);
					this.SendPropertyChanging();
					this._Genre = value;
					this.SendPropertyChanged("Genre");
					this.OnGenreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOfRelease", DbType="Int NOT NULL")]
		public int DateOfRelease
		{
			get
			{
				return this._DateOfRelease;
			}
			set
			{
				if ((this._DateOfRelease != value))
				{
					this.OnDateOfReleaseChanging(value);
					this.SendPropertyChanging();
					this._DateOfRelease = value;
					this.SendPropertyChanged("DateOfRelease");
					this.OnDateOfReleaseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Actors", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Actors
		{
			get
			{
				return this._Actors;
			}
			set
			{
				if ((this._Actors != value))
				{
					this.OnActorsChanging(value);
					this.SendPropertyChanging();
					this._Actors = value;
					this.SendPropertyChanged("Actors");
					this.OnActorsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Movie_ScreenRoom", Storage="_ScreenRooms", ThisKey="MovieId", OtherKey="MovieId")]
		public EntitySet<ScreenRoom> ScreenRooms
		{
			get
			{
				return this._ScreenRooms;
			}
			set
			{
				this._ScreenRooms.Assign(value);
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
		
		private void attach_ScreenRooms(ScreenRoom entity)
		{
			this.SendPropertyChanging();
			entity.Movie = this;
		}
		
		private void detach_ScreenRooms(ScreenRoom entity)
		{
			this.SendPropertyChanging();
			entity.Movie = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ScreenRoom")]
	public partial class ScreenRoom : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ScreenRoomId;
		
		private int _MovieId;
		
		private int _RoomNo;
		
		private int _TotalSeatNo;
		
		private EntityRef<Movie> _Movie;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnScreenRoomIdChanging(int value);
    partial void OnScreenRoomIdChanged();
    partial void OnMovieIdChanging(int value);
    partial void OnMovieIdChanged();
    partial void OnRoomNoChanging(int value);
    partial void OnRoomNoChanged();
    partial void OnTotalSeatNoChanging(int value);
    partial void OnTotalSeatNoChanged();
    #endregion
		
		public ScreenRoom()
		{
			this._Movie = default(EntityRef<Movie>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ScreenRoomId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ScreenRoomId
		{
			get
			{
				return this._ScreenRoomId;
			}
			set
			{
				if ((this._ScreenRoomId != value))
				{
					this.OnScreenRoomIdChanging(value);
					this.SendPropertyChanging();
					this._ScreenRoomId = value;
					this.SendPropertyChanged("ScreenRoomId");
					this.OnScreenRoomIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MovieId", DbType="Int NOT NULL")]
		public int MovieId
		{
			get
			{
				return this._MovieId;
			}
			set
			{
				if ((this._MovieId != value))
				{
					if (this._Movie.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMovieIdChanging(value);
					this.SendPropertyChanging();
					this._MovieId = value;
					this.SendPropertyChanged("MovieId");
					this.OnMovieIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoomNo", DbType="Int NOT NULL")]
		public int RoomNo
		{
			get
			{
				return this._RoomNo;
			}
			set
			{
				if ((this._RoomNo != value))
				{
					this.OnRoomNoChanging(value);
					this.SendPropertyChanging();
					this._RoomNo = value;
					this.SendPropertyChanged("RoomNo");
					this.OnRoomNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalSeatNo", DbType="Int NOT NULL")]
		public int TotalSeatNo
		{
			get
			{
				return this._TotalSeatNo;
			}
			set
			{
				if ((this._TotalSeatNo != value))
				{
					this.OnTotalSeatNoChanging(value);
					this.SendPropertyChanging();
					this._TotalSeatNo = value;
					this.SendPropertyChanged("TotalSeatNo");
					this.OnTotalSeatNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Movie_ScreenRoom", Storage="_Movie", ThisKey="MovieId", OtherKey="MovieId", IsForeignKey=true)]
		public Movie Movie
		{
			get
			{
				return this._Movie.Entity;
			}
			set
			{
				Movie previousValue = this._Movie.Entity;
				if (((previousValue != value) 
							|| (this._Movie.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Movie.Entity = null;
						previousValue.ScreenRooms.Remove(this);
					}
					this._Movie.Entity = value;
					if ((value != null))
					{
						value.ScreenRooms.Add(this);
						this._MovieId = value.MovieId;
					}
					else
					{
						this._MovieId = default(int);
					}
					this.SendPropertyChanged("Movie");
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
}
#pragma warning restore 1591

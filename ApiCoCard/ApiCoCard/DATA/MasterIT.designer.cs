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

namespace ApiCoCard.DATA
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dbMasIT")]
	public partial class MasterITDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMAS_WH(MAS_WH instance);
    partial void UpdateMAS_WH(MAS_WH instance);
    partial void DeleteMAS_WH(MAS_WH instance);
    #endregion
		
		public MasterITDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["dbMasITConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MasterITDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MasterITDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MasterITDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MasterITDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<MAS_WH> MAS_WHs
		{
			get
			{
				return this.GetTable<MAS_WH>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MAS_WH")]
	public partial class MAS_WH : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _WH_ID;
		
		private string _WHCODE;
		
		private string _WHNAME;
		
		private string _BRAND;
		
		private System.Nullable<int> _CFLAG;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnWH_IDChanging(int value);
    partial void OnWH_IDChanged();
    partial void OnWHCODEChanging(string value);
    partial void OnWHCODEChanged();
    partial void OnWHNAMEChanging(string value);
    partial void OnWHNAMEChanged();
    partial void OnBRANDChanging(string value);
    partial void OnBRANDChanged();
    partial void OnCFLAGChanging(System.Nullable<int> value);
    partial void OnCFLAGChanged();
    #endregion
		
		public MAS_WH()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WH_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int WH_ID
		{
			get
			{
				return this._WH_ID;
			}
			set
			{
				if ((this._WH_ID != value))
				{
					this.OnWH_IDChanging(value);
					this.SendPropertyChanging();
					this._WH_ID = value;
					this.SendPropertyChanged("WH_ID");
					this.OnWH_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WHCODE", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string WHCODE
		{
			get
			{
				return this._WHCODE;
			}
			set
			{
				if ((this._WHCODE != value))
				{
					this.OnWHCODEChanging(value);
					this.SendPropertyChanging();
					this._WHCODE = value;
					this.SendPropertyChanged("WHCODE");
					this.OnWHCODEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WHNAME", DbType="VarChar(20)")]
		public string WHNAME
		{
			get
			{
				return this._WHNAME;
			}
			set
			{
				if ((this._WHNAME != value))
				{
					this.OnWHNAMEChanging(value);
					this.SendPropertyChanging();
					this._WHNAME = value;
					this.SendPropertyChanged("WHNAME");
					this.OnWHNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BRAND", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string BRAND
		{
			get
			{
				return this._BRAND;
			}
			set
			{
				if ((this._BRAND != value))
				{
					this.OnBRANDChanging(value);
					this.SendPropertyChanging();
					this._BRAND = value;
					this.SendPropertyChanged("BRAND");
					this.OnBRANDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CFLAG", DbType="Int")]
		public System.Nullable<int> CFLAG
		{
			get
			{
				return this._CFLAG;
			}
			set
			{
				if ((this._CFLAG != value))
				{
					this.OnCFLAGChanging(value);
					this.SendPropertyChanging();
					this._CFLAG = value;
					this.SendPropertyChanged("CFLAG");
					this.OnCFLAGChanged();
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

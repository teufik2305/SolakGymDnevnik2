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

namespace SolakGymDnevnik
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SolakGymDnevnikDb")]
	public partial class SolakGymDnevnikDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMember(Member instance);
    partial void UpdateMember(Member instance);
    partial void DeleteMember(Member instance);
    #endregion
		
		public SolakGymDnevnikDataClassesDataContext() : 
				base(global::SolakGymDnevnik.Properties.Settings.Default.SolakGymDnevnikDbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SolakGymDnevnikDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SolakGymDnevnikDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SolakGymDnevnikDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SolakGymDnevnikDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Member> Members
		{
			get
			{
				return this.GetTable<Member>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Member")]
	public partial class Member : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _MembershipNumber;
		
		private string _Name;
		
		private string _PhoneNumber;
		
		private System.DateTime _MembershipDuration;
		
		private int _ExpirationTime;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnMembershipNumberChanging(int value);
    partial void OnMembershipNumberChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPhoneNumberChanging(string value);
    partial void OnPhoneNumberChanged();
    partial void OnMembershipDurationChanging(System.DateTime value);
    partial void OnMembershipDurationChanged();
    partial void OnExpirationTimeChanging(int value);
    partial void OnExpirationTimeChanged();
    #endregion
		
		public Member()
		{
			OnCreated();
		}

        public Member(string name, int membershipNumber, string phoneNumber, int membershipDuration)
        {
            OnCreated();
            Name = name;
            MembershipNumber = membershipNumber;
            PhoneNumber = phoneNumber;
            ExtendtMembershipByMonth(membershipDuration);
        }

        public void ExtendtMembershipByMonth(int membershipDuration)
        {
            MembershipDuration = DateTime.Today.AddMonths(membershipDuration);
            ExpirationTime = (MembershipDuration - DateTime.Today).Days;

        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MembershipNumber", DbType="Int NOT NULL")]
		public int MembershipNumber
		{
			get
			{
				return this._MembershipNumber;
			}
			set
			{
				if ((this._MembershipNumber != value))
				{
					this.OnMembershipNumberChanging(value);
					this.SendPropertyChanging();
					this._MembershipNumber = value;
					this.SendPropertyChanged("MembershipNumber");
					this.OnMembershipNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this.OnPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumber = value;
					this.SendPropertyChanged("PhoneNumber");
					this.OnPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MembershipDuration", DbType="DateTime NOT NULL")]
		public System.DateTime MembershipDuration
		{
			get
			{
				return this._MembershipDuration;
			}
			set
			{
				if ((this._MembershipDuration != value))
				{
					this.OnMembershipDurationChanging(value);
					this.SendPropertyChanging();
					this._MembershipDuration = value;
					this.SendPropertyChanged("MembershipDuration");
					this.OnMembershipDurationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExpirationTime", DbType="Int NOT NULL")]
		public int ExpirationTime
		{
			get
			{
				return this._ExpirationTime;
			}
			set
			{
				if ((this._ExpirationTime != value))
				{
					this.OnExpirationTimeChanging(value);
					this.SendPropertyChanging();
					this._ExpirationTime = value;
					this.SendPropertyChanged("ExpirationTime");
					this.OnExpirationTimeChanged();
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

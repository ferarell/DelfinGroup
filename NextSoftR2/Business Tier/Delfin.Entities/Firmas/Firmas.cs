using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using Infrastructure.Aspect;
using Infrastructure.Aspect.BusinessEntity;

namespace Delfin.Entities
{
	[Serializable()]
	public partial class Firmas : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_empr_codigo;
		private Int32 m_firm_codigo;
		private String m_cuba_codigo;
		private String m_firm_nombre;
		private String m_firm_cargo;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Firmas.
		/// </summary>
		public Firmas()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: EMPR_Codigo.
		/// </summary>
		[DataMember]
		public Int16 EMPR_Codigo
		{
			get { return m_empr_codigo; }
			set
			{
				if (m_empr_codigo != value)
				{
					m_empr_codigo = value;
					OnPropertyChanged("EMPR_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FIRM_Codigo.
		/// </summary>
		[DataMember]
		public Int32 FIRM_Codigo
		{
			get { return m_firm_codigo; }
			set
			{
				if (m_firm_codigo != value)
				{
					m_firm_codigo = value;
					OnPropertyChanged("FIRM_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CUBA_Codigo.
		/// </summary>
		[DataMember]
		public String CUBA_Codigo
		{
			get { return m_cuba_codigo; }
			set
			{
				if (m_cuba_codigo != value)
				{
					m_cuba_codigo = value;
					OnPropertyChanged("CUBA_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FIRM_Nombre.
		/// </summary>
		[DataMember]
		public String FIRM_Nombre
		{
			get { return m_firm_nombre; }
			set
			{
				if (m_firm_nombre != value)
				{
					m_firm_nombre = value;
					OnPropertyChanged("FIRM_Nombre");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FIRM_Cargo.
		/// </summary>
		[DataMember]
		public String FIRM_Cargo
		{
			get { return m_firm_cargo; }
			set
			{
				if (m_firm_cargo != value)
				{
					m_firm_cargo = value;
					OnPropertyChanged("FIRM_Cargo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AUDI_UsrCrea.
		/// </summary>
		[DataMember]
		public String AUDI_UsrCrea
		{
			get { return m_audi_usrcrea; }
			set
			{
				if (m_audi_usrcrea != value)
				{
					m_audi_usrcrea = value;
					OnPropertyChanged("AUDI_UsrCrea");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AUDI_FecCrea.
		/// </summary>
		[DataMember]
		public DateTime AUDI_FecCrea
		{
			get { return m_audi_feccrea; }
			set
			{
				if (m_audi_feccrea != value)
				{
					m_audi_feccrea = value;
					OnPropertyChanged("AUDI_FecCrea");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AUDI_UsrMod.
		/// </summary>
		[DataMember]
		public String AUDI_UsrMod
		{
			get { return m_audi_usrmod; }
			set
			{
				if (m_audi_usrmod != value)
				{
					m_audi_usrmod = value;
					OnPropertyChanged("AUDI_UsrMod");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AUDI_FecMod.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> AUDI_FecMod
		{
			get { return m_audi_fecmod; }
			set
			{
				if (m_audi_fecmod != value)
				{
					m_audi_fecmod = value;
					OnPropertyChanged("AUDI_FecMod");
				}
			}
		}
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref Firmas Item)
		{
			try
			{
				if (Item == null) { Item = new Firmas(); }
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.FIRM_Codigo = this.FIRM_Codigo;
				Item.CUBA_Codigo = this.CUBA_Codigo;
				Item.FIRM_Nombre = this.FIRM_Nombre;
				Item.FIRM_Cargo = this.FIRM_Cargo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}

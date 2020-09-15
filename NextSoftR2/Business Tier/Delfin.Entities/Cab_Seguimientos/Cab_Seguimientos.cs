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
	public partial class Cab_Seguimientos : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_cseg_codigo;
		private String m_cseg_hbl;
		private DateTime m_cseg_fechaemision;
		private Nullable<Int32> m_cdir_codigo;
		private Nullable<Int32> m_cope_codigo;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Cab_Seguimientos.
		/// </summary>
		public Cab_Seguimientos()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CSEG_Codigo.
		/// </summary>
		[DataMember]
		public Int32 CSEG_Codigo
		{
			get { return m_cseg_codigo; }
			set
			{
				if (m_cseg_codigo != value)
				{
					m_cseg_codigo = value;
					OnPropertyChanged("CSEG_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CSEG_HBL.
		/// </summary>
		[DataMember]
		public String CSEG_HBL
		{
			get { return m_cseg_hbl; }
			set
			{
				if (m_cseg_hbl != value)
				{
					m_cseg_hbl = value;
					OnPropertyChanged("CSEG_HBL");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CSEG_FechaEmision.
		/// </summary>
		[DataMember]
		public DateTime CSEG_FechaEmision
		{
			get { return m_cseg_fechaemision; }
			set
			{
				if (m_cseg_fechaemision != value)
				{
					m_cseg_fechaemision = value;
					OnPropertyChanged("CSEG_FechaEmision");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CDIR_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> CDIR_Codigo
		{
			get { return m_cdir_codigo; }
			set
			{
				if (m_cdir_codigo != value)
				{
					m_cdir_codigo = value;
					OnPropertyChanged("CDIR_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COPE_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> COPE_Codigo
		{
			get { return m_cope_codigo; }
			set
			{
				if (m_cope_codigo != value)
				{
					m_cope_codigo = value;
					OnPropertyChanged("COPE_Codigo");
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
		public void CopyTo(ref Cab_Seguimientos Item)
		{
			try
			{
				if (Item == null) { Item = new Cab_Seguimientos(); }
				Item.CSEG_Codigo = this.CSEG_Codigo;
				Item.CSEG_HBL = this.CSEG_HBL;
				Item.CSEG_FechaEmision = this.CSEG_FechaEmision;
				Item.CDIR_Codigo = this.CDIR_Codigo;
				Item.COPE_Codigo = this.COPE_Codigo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}

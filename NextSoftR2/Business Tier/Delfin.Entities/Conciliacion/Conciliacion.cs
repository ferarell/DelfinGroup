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
	public partial class Conciliacion : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_empr_codigo;
		private Int32 m_movi_codigo;
		private Nullable<Int32> m_conc_codigo;
		private String m_conc_periodo;
		private Nullable<Decimal> m_conc_montobco;
		private Nullable<DateTime> m_conc_fecconciliacion;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Conciliacion.
		/// </summary>
		public Conciliacion()
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
		/// Gets or sets el valor de: MOVI_Codigo.
		/// </summary>
		[DataMember]
		public Int32 MOVI_Codigo
		{
			get { return m_movi_codigo; }
			set
			{
				if (m_movi_codigo != value)
				{
					m_movi_codigo = value;
					OnPropertyChanged("MOVI_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONC_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> CONC_Codigo
		{
			get { return m_conc_codigo; }
			set
			{
				if (m_conc_codigo != value)
				{
					m_conc_codigo = value;
					OnPropertyChanged("CONC_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONC_Periodo.
		/// </summary>
		[DataMember]
		public String CONC_Periodo
		{
			get { return m_conc_periodo; }
			set
			{
				if (m_conc_periodo != value)
				{
					m_conc_periodo = value;
					OnPropertyChanged("CONC_Periodo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONC_MontoBCO.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> CONC_MontoBCO
		{
			get { return m_conc_montobco; }
			set
			{
				if (m_conc_montobco != value)
				{
					m_conc_montobco = value;
					OnPropertyChanged("CONC_MontoBCO");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONC_FecConciliacion.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> CONC_FecConciliacion
		{
			get { return m_conc_fecconciliacion; }
			set
			{
				if (m_conc_fecconciliacion != value)
				{
					m_conc_fecconciliacion = value;
					OnPropertyChanged("CONC_FecConciliacion");
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
		public void CopyTo(ref Conciliacion Item)
		{
			try
			{
				if (Item == null) { Item = new Conciliacion(); }
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.MOVI_Codigo = this.MOVI_Codigo;
				Item.CONC_Codigo = this.CONC_Codigo;
				Item.CONC_Periodo = this.CONC_Periodo;
				Item.CONC_MontoBCO = this.CONC_MontoBCO;
				Item.CONC_FecConciliacion = this.CONC_FecConciliacion;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}

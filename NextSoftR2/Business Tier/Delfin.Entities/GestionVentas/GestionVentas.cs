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
   [KnownType(typeof(MasterBusinessEntity))]
   public partial class GestionVentas : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_gest_codigo;
		private Nullable<Int16> m_sucr_codigo;
		private Nullable<Int16> m_empr_codigo;
		private String m_tipo_tabges;
		private String m_tipo_codges;
		private Nullable<DateTime> m_gest_fecha;
		private String m_gest_observacion;
		private Nullable<DateTime> m_gest_fechaproximagestion;
		private Nullable<TimeSpan> m_gest_tiempoproximagestion;
		private String m_tipo_tabgesproxima;
		private String m_tipo_codgesproxima;
		private Nullable<Int16> m_resg_codigo;
		private Nullable<Int32> m_pros_codigo;
		private Nullable<Int32> m_entc_codcliente;
		private Nullable<Int32> m_entc_codejecutivo;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private Nullable<DateTime> m_audi_fecmod;
		private String m_audi_usrmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase GestionVentas.
		/// </summary>
		public GestionVentas()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: GEST_Codigo.
		/// </summary>
		[DataMember]
		public Int32 GEST_Codigo
		{
			get { return m_gest_codigo; }
			set
			{
				if (m_gest_codigo != value)
				{
					m_gest_codigo = value;
					OnPropertyChanged("GEST_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SUCR_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int16> SUCR_Codigo
		{
			get { return m_sucr_codigo; }
			set
			{
				if (m_sucr_codigo != value)
				{
					m_sucr_codigo = value;
					OnPropertyChanged("SUCR_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EMPR_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int16> EMPR_Codigo
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
		/// Gets or sets el valor de: TIPO_TabGES.
		/// </summary>
		[DataMember]
		public String TIPO_TabGES
		{
			get { return m_tipo_tabges; }
			set
			{
				if (m_tipo_tabges != value)
				{
					m_tipo_tabges = value;
					OnPropertyChanged("TIPO_TabGES");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodGES.
		/// </summary>
		[DataMember]
		public String TIPO_CodGES
		{
			get { return m_tipo_codges; }
			set
			{
				if (m_tipo_codges != value)
				{
					m_tipo_codges = value;
					OnPropertyChanged("TIPO_CodGES");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: GEST_Fecha.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> GEST_Fecha
		{
			get { return m_gest_fecha; }
			set
			{
				if (m_gest_fecha != value)
				{
					m_gest_fecha = value;
					OnPropertyChanged("GEST_Fecha");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: GEST_Observacion.
		/// </summary>
		[DataMember]
		public String GEST_Observacion
		{
			get { return m_gest_observacion; }
			set
			{
				if (m_gest_observacion != value)
				{
					m_gest_observacion = value;
					OnPropertyChanged("GEST_Observacion");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: GEST_FechaProximaGestion.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> GEST_FechaProximaGestion
		{
			get { return m_gest_fechaproximagestion; }
			set
			{
				if (m_gest_fechaproximagestion != value)
				{
					m_gest_fechaproximagestion = value;
					OnPropertyChanged("GEST_FechaProximaGestion");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: GEST_TiempoProximaGestion.
		/// </summary>
		[DataMember]
		public Nullable<TimeSpan> GEST_TiempoProximaGestion
		{
			get { return m_gest_tiempoproximagestion; }
			set
			{
				if (m_gest_tiempoproximagestion != value)
				{
					m_gest_tiempoproximagestion = value;
					OnPropertyChanged("GEST_TiempoProximaGestion");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabGESProxima.
		/// </summary>
		[DataMember]
		public String TIPO_TabGESProxima
		{
			get { return m_tipo_tabgesproxima; }
			set
			{
				if (m_tipo_tabgesproxima != value)
				{
					m_tipo_tabgesproxima = value;
					OnPropertyChanged("TIPO_TabGESProxima");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodGESProxima.
		/// </summary>
		[DataMember]
		public String TIPO_CodGESProxima
		{
			get { return m_tipo_codgesproxima; }
			set
			{
				if (m_tipo_codgesproxima != value)
				{
					m_tipo_codgesproxima = value;
					OnPropertyChanged("TIPO_CodGESProxima");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: RESG_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int16> RESG_Codigo
		{
			get { return m_resg_codigo; }
			set
			{
				if (m_resg_codigo != value)
				{
					m_resg_codigo = value;
					OnPropertyChanged("RESG_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PROS_codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> PROS_codigo
		{
			get { return m_pros_codigo; }
			set
			{
				if (m_pros_codigo != value)
				{
					m_pros_codigo = value;
					OnPropertyChanged("PROS_codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodCliente.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodCliente
		{
			get { return m_entc_codcliente; }
			set
			{
				if (m_entc_codcliente != value)
				{
					m_entc_codcliente = value;
					OnPropertyChanged("ENTC_CodCliente");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodEjecutivo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodEjecutivo
		{
			get { return m_entc_codejecutivo; }
			set
			{
				if (m_entc_codejecutivo != value)
				{
					m_entc_codejecutivo = value;
					OnPropertyChanged("ENTC_CodEjecutivo");
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
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref GestionVentas Item)
		{
			try
			{
				if (Item == null) { Item = new GestionVentas(); }
				Item.GEST_Codigo = this.GEST_Codigo;
				Item.SUCR_Codigo = this.SUCR_Codigo;
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.TIPO_TabGES = this.TIPO_TabGES;
				Item.TIPO_CodGES = this.TIPO_CodGES;
				Item.GEST_Fecha = this.GEST_Fecha;
				Item.GEST_Observacion = this.GEST_Observacion;
				Item.GEST_FechaProximaGestion = this.GEST_FechaProximaGestion;
				Item.GEST_TiempoProximaGestion = this.GEST_TiempoProximaGestion;
				Item.TIPO_TabGESProxima = this.TIPO_TabGESProxima;
				Item.TIPO_CodGESProxima = this.TIPO_CodGESProxima;
				Item.RESG_Codigo = this.RESG_Codigo;
				Item.PROS_codigo = this.PROS_codigo;
				Item.ENTC_CodCliente = this.ENTC_CodCliente;
				Item.ENTC_CodEjecutivo = this.ENTC_CodEjecutivo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}

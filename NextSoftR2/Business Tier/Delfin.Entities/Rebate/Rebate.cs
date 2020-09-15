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
	public partial class Rebate : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_reba_codigo;
		private Nullable<Int32> m_cont_codigo;
		private Nullable<DateTime> m_reba_fecini;
		private Nullable<DateTime> m_reba_fecfin;
		private Nullable<Int32> m_entc_codtransportista;
		private String m_tipo_tabmnd;
		private String m_tipo_codmnd;
		private Nullable<Int16> m_empr_codigo;
		private Nullable<Int32> m_puer_coddestino;
		private Nullable<Int32> m_puer_codorigen;
		private String m_conc_tabreb;
		private String m_conc_codreb;
		private DateTime m_audi_feccrea;
		private String m_audi_usrcrea;
		private Nullable<DateTime> m_audi_fecmod;
		private String m_audi_usrmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Rebate.
		/// </summary>
		public Rebate()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: REBA_Codigo.
		/// </summary>
		[DataMember]
		public Int32 REBA_Codigo
		{
			get { return m_reba_codigo; }
			set
			{
				if (m_reba_codigo != value)
				{
					m_reba_codigo = value;
					OnPropertyChanged("REBA_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONT_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> CONT_Codigo
		{
			get { return m_cont_codigo; }
			set
			{
				if (m_cont_codigo != value)
				{
					m_cont_codigo = value;
					OnPropertyChanged("CONT_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: REBA_FecIni.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> REBA_FecIni
		{
			get { return m_reba_fecini; }
			set
			{
				if (m_reba_fecini != value)
				{
					m_reba_fecini = value;
					OnPropertyChanged("REBA_FecIni");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: REBA_FecFin.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> REBA_FecFin
		{
			get { return m_reba_fecfin; }
			set
			{
				if (m_reba_fecfin != value)
				{
					m_reba_fecfin = value;
					OnPropertyChanged("REBA_FecFin");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodTransportista.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodTransportista
		{
			get { return m_entc_codtransportista; }
			set
			{
				if (m_entc_codtransportista != value)
				{
					m_entc_codtransportista = value;
					OnPropertyChanged("ENTC_CodTransportista");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabMnd.
		/// </summary>
		[DataMember]
		public String TIPO_TabMnd
		{
			get { return m_tipo_tabmnd; }
			set
			{
				if (m_tipo_tabmnd != value)
				{
					m_tipo_tabmnd = value;
					OnPropertyChanged("TIPO_TabMnd");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodMnd.
		/// </summary>
		[DataMember]
		public String TIPO_CodMnd
		{
			get { return m_tipo_codmnd; }
			set
			{
				if (m_tipo_codmnd != value)
				{
					m_tipo_codmnd = value;
					OnPropertyChanged("TIPO_CodMnd");
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
		/// Gets or sets el valor de: PUER_CodDestino.
		/// </summary>
		[DataMember]
		public Nullable<Int32> PUER_CodDestino
		{
			get { return m_puer_coddestino; }
			set
			{
				if (m_puer_coddestino != value)
				{
					m_puer_coddestino = value;
					OnPropertyChanged("PUER_CodDestino");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PUER_CodOrigen.
		/// </summary>
		[DataMember]
		public Nullable<Int32> PUER_CodOrigen
		{
			get { return m_puer_codorigen; }
			set
			{
				if (m_puer_codorigen != value)
				{
					m_puer_codorigen = value;
					OnPropertyChanged("PUER_CodOrigen");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONC_TabReb.
		/// </summary>
		[DataMember]
		public String CONC_TabReb
		{
			get { return m_conc_tabreb; }
			set
			{
				if (m_conc_tabreb != value)
				{
					m_conc_tabreb = value;
					OnPropertyChanged("CONC_TabReb");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONC_CodReb.
		/// </summary>
		[DataMember]
		public String CONC_CodReb
		{
			get { return m_conc_codreb; }
			set
			{
				if (m_conc_codreb != value)
				{
					m_conc_codreb = value;
					OnPropertyChanged("CONC_CodReb");
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
		public void CopyTo(ref Rebate Item)
		{
			try
			{
				if (Item == null) { Item = new Rebate(); }
				Item.REBA_Codigo = this.REBA_Codigo;
				Item.CONT_Codigo = this.CONT_Codigo;
				Item.REBA_FecIni = this.REBA_FecIni;
				Item.REBA_FecFin = this.REBA_FecFin;
				Item.ENTC_CodTransportista = this.ENTC_CodTransportista;
				Item.TIPO_TabMnd = this.TIPO_TabMnd;
				Item.TIPO_CodMnd = this.TIPO_CodMnd;
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.PUER_CodDestino = this.PUER_CodDestino;
				Item.PUER_CodOrigen = this.PUER_CodOrigen;
				Item.CONC_TabReb = this.CONC_TabReb;
				Item.CONC_CodReb = this.CONC_CodReb;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}

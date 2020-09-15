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
	public partial class SobreEstadia : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_soes_diassobrestadialinea;
		private Int16 m_soes_diassobrestadiacliente;
		private DateTime m_soes_fecinicio;
		private String m_tipo_tabtrf;
		private String m_tipo_codtrf;
		private Nullable<DateTime> m_soes_fecfin;
		private Int16 m_soes_item;
		private String m_tipo_tabcnt;
		private String m_tipo_codcnt;
		private String m_soes_obsfecinicio;
		private String m_soes_observaciones;
		private Nullable<Int32> m_puer_coddestino;
		private Nullable<Boolean> m_soes_oferta;
		private Int32 m_cont_codigo;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase SobreEstadia.
		/// </summary>
		public SobreEstadia()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: SOES_DiasSobrestadiaLinea.
		/// </summary>
		[DataMember]
		public Int16 SOES_DiasSobrestadiaLinea
		{
			get { return m_soes_diassobrestadialinea; }
			set
			{
				if (m_soes_diassobrestadialinea != value)
				{
					m_soes_diassobrestadialinea = value;
					OnPropertyChanged("SOES_DiasSobrestadiaLinea");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SOES_DiasSobrestadiaCliente.
		/// </summary>
		[DataMember]
		public Int16 SOES_DiasSobrestadiaCliente
		{
			get { return m_soes_diassobrestadiacliente; }
			set
			{
				if (m_soes_diassobrestadiacliente != value)
				{
					m_soes_diassobrestadiacliente = value;
					OnPropertyChanged("SOES_DiasSobrestadiaCliente");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SOES_FecInicio.
		/// </summary>
		[DataMember]
		public DateTime SOES_FecInicio
		{
			get { return m_soes_fecinicio; }
			set
			{
				if (m_soes_fecinicio != value)
				{
					m_soes_fecinicio = value;
					OnPropertyChanged("SOES_FecInicio");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabTRF.
		/// </summary>
		[DataMember]
		public String TIPO_TabTRF
		{
			get { return m_tipo_tabtrf; }
			set
			{
				if (m_tipo_tabtrf != value)
				{
					m_tipo_tabtrf = value;
					OnPropertyChanged("TIPO_TabTRF");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodTRF.
		/// </summary>
		[DataMember]
		public String TIPO_CodTRF
		{
			get { return m_tipo_codtrf; }
			set
			{
				if (m_tipo_codtrf != value)
				{
					m_tipo_codtrf = value;
					OnPropertyChanged("TIPO_CodTRF");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SOES_FecFin.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> SOES_FecFin
		{
			get { return m_soes_fecfin; }
			set
			{
				if (m_soes_fecfin != value)
				{
					m_soes_fecfin = value;
					OnPropertyChanged("SOES_FecFin");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SOES_Item.
		/// </summary>
		[DataMember]
		public Int16 SOES_Item
		{
			get { return m_soes_item; }
			set
			{
				if (m_soes_item != value)
				{
					m_soes_item = value;
					OnPropertyChanged("SOES_Item");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabCNT.
		/// </summary>
		[DataMember]
		public String TIPO_TabCNT
		{
			get { return m_tipo_tabcnt; }
			set
			{
				if (m_tipo_tabcnt != value)
				{
					m_tipo_tabcnt = value;
					OnPropertyChanged("TIPO_TabCNT");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodCNT.
		/// </summary>
		[DataMember]
		public String TIPO_CodCNT
		{
			get { return m_tipo_codcnt; }
			set
			{
				if (m_tipo_codcnt != value)
				{
					m_tipo_codcnt = value;
					OnPropertyChanged("TIPO_CodCNT");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SOES_ObsFecInicio.
		/// </summary>
		[DataMember]
		public String SOES_ObsFecInicio
		{
			get { return m_soes_obsfecinicio; }
			set
			{
				if (m_soes_obsfecinicio != value)
				{
					m_soes_obsfecinicio = value;
					OnPropertyChanged("SOES_ObsFecInicio");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SOES_Observaciones.
		/// </summary>
		[DataMember]
		public String SOES_Observaciones
		{
			get { return m_soes_observaciones; }
			set
			{
				if (m_soes_observaciones != value)
				{
					m_soes_observaciones = value;
					OnPropertyChanged("SOES_Observaciones");
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
		/// Gets or sets el valor de: SOES_Oferta.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> SOES_Oferta
		{
			get { return m_soes_oferta; }
			set
			{
				if (m_soes_oferta != value)
				{
					m_soes_oferta = value;
					OnPropertyChanged("SOES_Oferta");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONT_Codigo.
		/// </summary>
		[DataMember]
		public Int32 CONT_Codigo
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
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref SobreEstadia Item)
		{
			try
			{
				if (Item == null) { Item = new SobreEstadia(); }
				Item.SOES_DiasSobrestadiaLinea = this.SOES_DiasSobrestadiaLinea;
				Item.SOES_DiasSobrestadiaCliente = this.SOES_DiasSobrestadiaCliente;
				Item.SOES_FecInicio = this.SOES_FecInicio;
				Item.TIPO_TabTRF = this.TIPO_TabTRF;
				Item.TIPO_CodTRF = this.TIPO_CodTRF;
				Item.SOES_FecFin = this.SOES_FecFin;
				Item.SOES_Item = this.SOES_Item;
				Item.TIPO_TabCNT = this.TIPO_TabCNT;
				Item.TIPO_CodCNT = this.TIPO_CodCNT;
				Item.SOES_ObsFecInicio = this.SOES_ObsFecInicio;
				Item.SOES_Observaciones = this.SOES_Observaciones;
				Item.PUER_CodDestino = this.PUER_CodDestino;
				Item.SOES_Oferta = this.SOES_Oferta;
				Item.CONT_Codigo = this.CONT_Codigo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}

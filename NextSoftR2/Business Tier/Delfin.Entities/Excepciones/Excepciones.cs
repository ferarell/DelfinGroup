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
	public partial class Excepciones : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_exce_interno;
		private Int16 m_empr_codigo;
		private String m_exce_usrsolicita;
		private Int32 m_entc_codigo;
		private Nullable<Int32> m_docv_codigo;
		private Nullable<Int32> m_ccct_codigo;
		private Nullable<DateTime> m_exce_fecha;
		private String m_exce_usr;
		private String m_exce_usraprueba;
		private Decimal m_exce_montorequerido;
		private Decimal m_exce_montoexcedido;
		private DateTime m_exce_fecaprueba;
		private String m_exce_motivoaprueba;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Excepciones.
		/// </summary>
		public Excepciones()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: EXCE_Interno.
		/// </summary>
		[DataMember]
		public Int32 EXCE_Interno
		{
			get { return m_exce_interno; }
			set
			{
				if (m_exce_interno != value)
				{
					m_exce_interno = value;
					OnPropertyChanged("EXCE_Interno");
				}
			}
		}
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
		/// Gets or sets el valor de: EXCE_UsrSolicita.
		/// </summary>
		[DataMember]
		public String EXCE_UsrSolicita
		{
			get { return m_exce_usrsolicita; }
			set
			{
				if (m_exce_usrsolicita != value)
				{
					m_exce_usrsolicita = value;
					OnPropertyChanged("EXCE_UsrSolicita");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_Codigo.
		/// </summary>
		[DataMember]
		public Int32 ENTC_Codigo
		{
			get { return m_entc_codigo; }
			set
			{
				if (m_entc_codigo != value)
				{
					m_entc_codigo = value;
					OnPropertyChanged("ENTC_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> DOCV_Codigo
		{
			get { return m_docv_codigo; }
			set
			{
				if (m_docv_codigo != value)
				{
					m_docv_codigo = value;
					OnPropertyChanged("DOCV_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCCT_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> CCCT_Codigo
		{
			get { return m_ccct_codigo; }
			set
			{
				if (m_ccct_codigo != value)
				{
					m_ccct_codigo = value;
					OnPropertyChanged("CCCT_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EXCE_Fecha.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> EXCE_Fecha
		{
			get { return m_exce_fecha; }
			set
			{
				if (m_exce_fecha != value)
				{
					m_exce_fecha = value;
					OnPropertyChanged("EXCE_Fecha");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EXCE_Usr.
		/// </summary>
		[DataMember]
		public String EXCE_Usr
		{
			get { return m_exce_usr; }
			set
			{
				if (m_exce_usr != value)
				{
					m_exce_usr = value;
					OnPropertyChanged("EXCE_Usr");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EXCE_UsrAprueba.
		/// </summary>
		[DataMember]
		public String EXCE_UsrAprueba
		{
			get { return m_exce_usraprueba; }
			set
			{
				if (m_exce_usraprueba != value)
				{
					m_exce_usraprueba = value;
					OnPropertyChanged("EXCE_UsrAprueba");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EXCE_MontoRequerido.
		/// </summary>
		[DataMember]
		public Decimal EXCE_MontoRequerido
		{
			get { return m_exce_montorequerido; }
			set
			{
				if (m_exce_montorequerido != value)
				{
					m_exce_montorequerido = value;
					OnPropertyChanged("EXCE_MontoRequerido");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EXCE_MontoExcedido.
		/// </summary>
		[DataMember]
		public Decimal EXCE_MontoExcedido
		{
			get { return m_exce_montoexcedido; }
			set
			{
				if (m_exce_montoexcedido != value)
				{
					m_exce_montoexcedido = value;
					OnPropertyChanged("EXCE_MontoExcedido");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EXCE_FecAprueba.
		/// </summary>
		[DataMember]
		public DateTime EXCE_FecAprueba
		{
			get { return m_exce_fecaprueba; }
			set
			{
				if (m_exce_fecaprueba != value)
				{
					m_exce_fecaprueba = value;
					OnPropertyChanged("EXCE_FecAprueba");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EXCE_MotivoAprueba.
		/// </summary>
		[DataMember]
		public String EXCE_MotivoAprueba
		{
			get { return m_exce_motivoaprueba; }
			set
			{
				if (m_exce_motivoaprueba != value)
				{
					m_exce_motivoaprueba = value;
					OnPropertyChanged("EXCE_MotivoAprueba");
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
		public void CopyTo(ref Excepciones Item)
		{
			try
			{
				if (Item == null) { Item = new Excepciones(); }
				Item.EXCE_Interno = this.EXCE_Interno;
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.EXCE_UsrSolicita = this.EXCE_UsrSolicita;
				Item.ENTC_Codigo = this.ENTC_Codigo;
				Item.DOCV_Codigo = this.DOCV_Codigo;
				Item.CCCT_Codigo = this.CCCT_Codigo;
				Item.EXCE_Fecha = this.EXCE_Fecha;
				Item.EXCE_Usr = this.EXCE_Usr;
				Item.EXCE_UsrAprueba = this.EXCE_UsrAprueba;
				Item.EXCE_MontoRequerido = this.EXCE_MontoRequerido;
				Item.EXCE_MontoExcedido = this.EXCE_MontoExcedido;
				Item.EXCE_FecAprueba = this.EXCE_FecAprueba;
				Item.EXCE_MotivoAprueba = this.EXCE_MotivoAprueba;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}

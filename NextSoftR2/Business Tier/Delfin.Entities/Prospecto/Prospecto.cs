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
using Infrastructure.Aspect.Attributes;

namespace Delfin.Entities
{
	[Serializable()]
   [KnownType(typeof(MasterBusinessEntity))]
   public partial class Prospecto : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_pros_codigo;
		private Int16 m_empr_codigo;
		private Int16 m_sucr_codigo;
		private Int32 m_entc_codcliente;
		private Int32 m_entc_codejecutivo;
		private Nullable<Int32> m_entc_codcustomer;
		private Nullable<Int32> m_entc_codagentecarga;
		private DateTime m_pros_fecasignacion;
		private String m_tipo_tabcdt;
		private String m_tipo_codcdt;
		private Boolean m_pros_activo;
		private String m_cons_tabrgm;
		private String m_cons_codrgm;
		private Int32 m_pros_teus;
		private Decimal m_pros_porcentaje;
		private Int32 m_pros_cntr20;
		private Int32 m_pros_cntr40;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Prospecto.
		/// </summary>
		public Prospecto()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: PROS_codigo.
		/// </summary>
		[DataMember]
      [TableValueParameter(Export = true, Orden = 1)]
      public Int32 PROS_codigo
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
		/// Gets or sets el valor de: SUCR_Codigo.
		/// </summary>
		[DataMember]
		public Int16 SUCR_Codigo
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
		/// Gets or sets el valor de: ENTC_CodCliente.
		/// </summary>
		[DataMember]
      [TableValueParameter(Export = true, Orden = 2)]
      public Int32 ENTC_CodCliente
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
      [TableValueParameter(Export = true, Orden = 6)]
		public Int32 ENTC_CodEjecutivo
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
		/// Gets or sets el valor de: ENTC_CodCustomer.
		/// </summary>
		[DataMember]
      [TableValueParameter(Export = true, Orden = 8)]
		public Nullable<Int32> ENTC_CodCustomer
		{
			get { return m_entc_codcustomer; }
			set
			{
				if (m_entc_codcustomer != value)
				{
					m_entc_codcustomer = value;
					OnPropertyChanged("ENTC_CodCustomer");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodAgenteCarga.
		/// </summary>
		[DataMember]
      [TableValueParameter(Export = true, Orden = 4)]
      public Nullable<Int32> ENTC_CodAgenteCarga
		{
			get { return m_entc_codagentecarga; }
			set
			{
				if (m_entc_codagentecarga != value)
				{
					m_entc_codagentecarga = value;
					OnPropertyChanged("ENTC_CodAgenteCarga");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PROS_FecAsignacion.
		/// </summary>
		[DataMember]
		public DateTime PROS_FecAsignacion
		{
			get { return m_pros_fecasignacion; }
			set
			{
				if (m_pros_fecasignacion != value)
				{
					m_pros_fecasignacion = value;
					OnPropertyChanged("PROS_FecAsignacion");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabCDT.
		/// </summary>
		[DataMember]
      [TableValueParameter(Export = true, Orden = 14)]
		public String TIPO_TabCDT
		{
			get { return m_tipo_tabcdt; }
			set
			{
				if (m_tipo_tabcdt != value)
				{
					m_tipo_tabcdt = value;
					OnPropertyChanged("TIPO_TabCDT");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodCDT.
		/// </summary>
		[DataMember]
      [TableValueParameter(Export = true, Orden = 15)]
		public String TIPO_CodCDT
		{
			get { return m_tipo_codcdt; }
			set
			{
				if (m_tipo_codcdt != value)
				{
					m_tipo_codcdt = value;
					OnPropertyChanged("TIPO_CodCDT");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PROS_Activo.
		/// </summary>
		[DataMember]
		public Boolean PROS_Activo
		{
			get { return m_pros_activo; }
			set
			{
				if (m_pros_activo != value)
				{
					m_pros_activo = value;
					OnPropertyChanged("PROS_Activo");
				}
			}
		}
		/// <summary>
      /// Gets or sets el valor de: CONS_TabRGM.
		/// </summary>
		[DataMember]
      [TableValueParameter(Export = true, Orden = 17)]
		public String CONS_TabRGM
		{
			get { return m_cons_tabrgm; }
			set
			{
				if (m_cons_tabrgm != value)
				{
					m_cons_tabrgm = value;
               OnPropertyChanged("CONS_TabRGM");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodRGM.
		/// </summary>
		[DataMember]
      [TableValueParameter(Export = true, Orden = 18)]
		public String CONS_CodRGM
		{
			get { return m_cons_codrgm; }
			set
			{
				if (m_cons_codrgm != value)
				{
					m_cons_codrgm = value;
					OnPropertyChanged("CONS_CodRGM");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PROS_TEUS.
		/// </summary>
		[DataMember]
      [TableValueParameter(Export = true, Orden = 10)]
      public Int32 PROS_TEUS
		{
			get { return m_pros_teus; }
			set
			{
				if (m_pros_teus != value)
				{
					m_pros_teus = value;
					OnPropertyChanged("PROS_TEUS");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PROS_Porcentaje.
		/// </summary>
		[DataMember]
      [TableValueParameter(Export = true, Orden = 11)]
      public Decimal PROS_Porcentaje
		{
			get { return m_pros_porcentaje; }
			set
			{
				if (m_pros_porcentaje != value)
				{
					m_pros_porcentaje = value;
					OnPropertyChanged("PROS_Porcentaje");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PROS_CNTR20.
		/// </summary>
		[DataMember]
      [TableValueParameter(Export = true, Orden = 12)]
      public Int32 PROS_CNTR20
		{
			get { return m_pros_cntr20; }
			set
			{
				if (m_pros_cntr20 != value)
				{
					m_pros_cntr20 = value;
					OnPropertyChanged("PROS_CNTR20");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PROS_CNTR40.
		/// </summary>
		[DataMember]
      [TableValueParameter(Export = true, Orden = 13)]
      public Int32 PROS_CNTR40
		{
			get { return m_pros_cntr40; }
			set
			{
				if (m_pros_cntr40 != value)
				{
					m_pros_cntr40 = value;
					OnPropertyChanged("PROS_CNTR40");
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
		public void CopyTo(ref Prospecto Item)
		{
			try
			{
				if (Item == null) { Item = new Prospecto(); }
				Item.PROS_codigo = this.PROS_codigo;
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.SUCR_Codigo = this.SUCR_Codigo;
				Item.ENTC_CodCliente = this.ENTC_CodCliente;
				Item.ENTC_CodEjecutivo = this.ENTC_CodEjecutivo;
				Item.ENTC_CodCustomer = this.ENTC_CodCustomer;
				Item.ENTC_CodAgenteCarga = this.ENTC_CodAgenteCarga;
				Item.PROS_FecAsignacion = this.PROS_FecAsignacion;
				Item.TIPO_TabCDT = this.TIPO_TabCDT;
				Item.TIPO_CodCDT = this.TIPO_CodCDT;
				Item.PROS_Activo = this.PROS_Activo;
				Item.CONS_TabRGM = this.CONS_TabRGM;
				Item.CONS_CodRGM = this.CONS_CodRGM;
				Item.PROS_TEUS = this.PROS_TEUS;
				Item.PROS_Porcentaje = this.PROS_Porcentaje;
				Item.PROS_CNTR20 = this.PROS_CNTR20;
				Item.PROS_CNTR40 = this.PROS_CNTR40;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}

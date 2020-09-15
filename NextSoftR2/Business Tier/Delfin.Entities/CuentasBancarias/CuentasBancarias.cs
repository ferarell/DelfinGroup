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
	public partial class CuentasBancarias : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_empr_codigo;
		private String m_cuba_codigo;
		private Nullable<Int16> m_sucr_codigo;
		private String m_tipo_tabbco;
		private String m_tipo_codbco;
		private String m_tipo_tabmnd;
		private String m_tipo_codmnd;
		private String m_cuba_nrocuenta;
		private String m_cuba_tipocuenta;
		private String m_cuba_cuenpuente;
		private String m_cuba_cuencontable;
		private String m_cuba_ctaporcobrar;
		private String m_cuba_ctaporpagar;
		private Nullable<DateTime> m_cuba_fechacierre;
		private Nullable<Boolean> m_cuba_bloqueo;
		private Nullable<Boolean> m_cuba_permchequeblanco;
		private Nullable<Boolean> m_cuba_permimprautomatica;
		private String m_cuba_codagencia;
		private Boolean m_cuba_mediovirtual;
		private Nullable<Boolean> m_cuba_inscritosol;
		private String m_cuba_descripcion;
		private Boolean m_cuba_ctaemprvinculada;
		private String m_cuba_subctaingreso;
		private String m_cuba_subctaegreso;
      private String m_cuba_subctaingresoev;
      private String m_cuba_subctaegresoev;
      private String m_cuba_librodestino;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase CuentasBancarias.
		/// </summary>
		public CuentasBancarias()
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
		/// Gets or sets el valor de: TIPO_TabBCO.
		/// </summary>
		[DataMember]
		public String TIPO_TabBCO
		{
			get { return m_tipo_tabbco; }
			set
			{
				if (m_tipo_tabbco != value)
				{
					m_tipo_tabbco = value;
					OnPropertyChanged("TIPO_TabBCO");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodBCO.
		/// </summary>
		[DataMember]
		public String TIPO_CodBCO
		{
			get { return m_tipo_codbco; }
			set
			{
				if (m_tipo_codbco != value)
				{
					m_tipo_codbco = value;
					OnPropertyChanged("TIPO_CodBCO");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabMND.
		/// </summary>
		[DataMember]
		public String TIPO_TabMND
		{
			get { return m_tipo_tabmnd; }
			set
			{
				if (m_tipo_tabmnd != value)
				{
					m_tipo_tabmnd = value;
					OnPropertyChanged("TIPO_TabMND");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodMND.
		/// </summary>
		[DataMember]
		public String TIPO_CodMND
		{
			get { return m_tipo_codmnd; }
			set
			{
				if (m_tipo_codmnd != value)
				{
					m_tipo_codmnd = value;
					OnPropertyChanged("TIPO_CodMND");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CUBA_NroCuenta.
		/// </summary>
		[DataMember]
		public String CUBA_NroCuenta
		{
			get { return m_cuba_nrocuenta; }
			set
			{
				if (m_cuba_nrocuenta != value)
				{
					m_cuba_nrocuenta = value;
					OnPropertyChanged("CUBA_NroCuenta");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CUBA_TipoCuenta.
		/// </summary>
		[DataMember]
		public String CUBA_TipoCuenta
		{
			get { return m_cuba_tipocuenta; }
			set
			{
				if (m_cuba_tipocuenta != value)
				{
					m_cuba_tipocuenta = value;
					OnPropertyChanged("CUBA_TipoCuenta");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CUBA_CuenPuente.
		/// </summary>
		[DataMember]
		public String CUBA_CuenPuente
		{
			get { return m_cuba_cuenpuente; }
			set
			{
				if (m_cuba_cuenpuente != value)
				{
					m_cuba_cuenpuente = value;
					OnPropertyChanged("CUBA_CuenPuente");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CUBA_CuenContable.
		/// </summary>
		[DataMember]
		public String CUBA_CuenContable
		{
			get { return m_cuba_cuencontable; }
			set
			{
				if (m_cuba_cuencontable != value)
				{
					m_cuba_cuencontable = value;
					OnPropertyChanged("CUBA_CuenContable");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CUBA_CtaPorCobrar.
		/// </summary>
		[DataMember]
		public String CUBA_CtaPorCobrar
		{
			get { return m_cuba_ctaporcobrar; }
			set
			{
				if (m_cuba_ctaporcobrar != value)
				{
					m_cuba_ctaporcobrar = value;
					OnPropertyChanged("CUBA_CtaPorCobrar");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CUBA_CtaPorPagar.
		/// </summary>
		[DataMember]
		public String CUBA_CtaPorPagar
		{
			get { return m_cuba_ctaporpagar; }
			set
			{
				if (m_cuba_ctaporpagar != value)
				{
					m_cuba_ctaporpagar = value;
					OnPropertyChanged("CUBA_CtaPorPagar");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CUBA_FechaCierre.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> CUBA_FechaCierre
		{
			get { return m_cuba_fechacierre; }
			set
			{
				if (m_cuba_fechacierre != value)
				{
					m_cuba_fechacierre = value;
					OnPropertyChanged("CUBA_FechaCierre");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CUBA_Bloqueo.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> CUBA_Bloqueo
		{
			get { return m_cuba_bloqueo; }
			set
			{
				if (m_cuba_bloqueo != value)
				{
					m_cuba_bloqueo = value;
					OnPropertyChanged("CUBA_Bloqueo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CUBA_PermChequeBlanco.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> CUBA_PermChequeBlanco
		{
			get { return m_cuba_permchequeblanco; }
			set
			{
				if (m_cuba_permchequeblanco != value)
				{
					m_cuba_permchequeblanco = value;
					OnPropertyChanged("CUBA_PermChequeBlanco");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CUBA_PermImprAutomatica.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> CUBA_PermImprAutomatica
		{
			get { return m_cuba_permimprautomatica; }
			set
			{
				if (m_cuba_permimprautomatica != value)
				{
					m_cuba_permimprautomatica = value;
					OnPropertyChanged("CUBA_PermImprAutomatica");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CUBA_CodAgencia.
		/// </summary>
		[DataMember]
		public String CUBA_CodAgencia
		{
			get { return m_cuba_codagencia; }
			set
			{
				if (m_cuba_codagencia != value)
				{
					m_cuba_codagencia = value;
					OnPropertyChanged("CUBA_CodAgencia");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CUBA_MedioVirtual.
		/// </summary>
		[DataMember]
		public Boolean CUBA_MedioVirtual
		{
			get { return m_cuba_mediovirtual; }
			set
			{
				if (m_cuba_mediovirtual != value)
				{
					m_cuba_mediovirtual = value;
					OnPropertyChanged("CUBA_MedioVirtual");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CUBA_InscritoSOL.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> CUBA_InscritoSOL
		{
			get { return m_cuba_inscritosol; }
			set
			{
				if (m_cuba_inscritosol != value)
				{
					m_cuba_inscritosol = value;
					OnPropertyChanged("CUBA_InscritoSOL");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CUBA_Descripcion.
		/// </summary>
		[DataMember]
		public String CUBA_Descripcion
		{
			get { return m_cuba_descripcion; }
			set
			{
				if (m_cuba_descripcion != value)
				{
					m_cuba_descripcion = value;
					OnPropertyChanged("CUBA_Descripcion");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CUBA_CtaEmprVinculada.
		/// </summary>
		[DataMember]
		public Boolean CUBA_CtaEmprVinculada
		{
			get { return m_cuba_ctaemprvinculada; }
			set
			{
				if (m_cuba_ctaemprvinculada != value)
				{
					m_cuba_ctaemprvinculada = value;
					OnPropertyChanged("CUBA_CtaEmprVinculada");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CUBA_SubCtaIngreso.
		/// </summary>
		[DataMember]
		public String CUBA_SubCtaIngreso
		{
			get { return m_cuba_subctaingreso; }
			set
			{
				if (m_cuba_subctaingreso != value)
				{
					m_cuba_subctaingreso = value;
					OnPropertyChanged("CUBA_SubCtaIngreso");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CUBA_SubCtaEgreso.
		/// </summary>
		[DataMember]
		public String CUBA_SubCtaEgreso
		{
			get { return m_cuba_subctaegreso; }
			set
			{
				if (m_cuba_subctaegreso != value)
				{
					m_cuba_subctaegreso = value;
					OnPropertyChanged("CUBA_SubCtaEgreso");
				}
			}
		}
      /// <summary>
      /// Gets or sets el valor de: CUBA_SubCtaIngresoEV.
      /// </summary>
      [DataMember]
      public String CUBA_SubCtaIngresoEV
      {
         get { return m_cuba_subctaingresoev; }
         set
         {
            if (m_cuba_subctaingresoev != value)
            {
               m_cuba_subctaingresoev = value;
               OnPropertyChanged("CUBA_SubCtaIngresoEV");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CUBA_SubCtaEgresoEV.
      /// </summary>
      [DataMember]
      public String CUBA_SubCtaEgresoEV
      {
         get { return m_cuba_subctaegresoev; }
         set
         {
            if (m_cuba_subctaegresoev != value)
            {
               m_cuba_subctaegresoev = value;
               OnPropertyChanged("CUBA_SubCtaEgresoEV");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CUBA_LibroDestino.
      /// </summary>
      [DataMember]
      public String CUBA_LibroDestino
      {
         get { return m_cuba_librodestino; }
         set
         {
            if (m_cuba_librodestino != value)
            {
               m_cuba_librodestino = value;
               OnPropertyChanged("CUBA_LibroDestino");
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
		public void CopyTo(ref CuentasBancarias Item)
		{
			try
			{
				if (Item == null) { Item = new CuentasBancarias(); }
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.CUBA_Codigo = this.CUBA_Codigo;
				Item.SUCR_Codigo = this.SUCR_Codigo;
				Item.TIPO_TabBCO = this.TIPO_TabBCO;
				Item.TIPO_CodBCO = this.TIPO_CodBCO;
				Item.TIPO_TabMND = this.TIPO_TabMND;
				Item.TIPO_CodMND = this.TIPO_CodMND;
				Item.CUBA_NroCuenta = this.CUBA_NroCuenta;
				Item.CUBA_TipoCuenta = this.CUBA_TipoCuenta;
				Item.CUBA_CuenPuente = this.CUBA_CuenPuente;
				Item.CUBA_CuenContable = this.CUBA_CuenContable;
				Item.CUBA_CtaPorCobrar = this.CUBA_CtaPorCobrar;
				Item.CUBA_CtaPorPagar = this.CUBA_CtaPorPagar;
				Item.CUBA_FechaCierre = this.CUBA_FechaCierre;
				Item.CUBA_Bloqueo = this.CUBA_Bloqueo;
				Item.CUBA_PermChequeBlanco = this.CUBA_PermChequeBlanco;
				Item.CUBA_PermImprAutomatica = this.CUBA_PermImprAutomatica;
				Item.CUBA_CodAgencia = this.CUBA_CodAgencia;
				Item.CUBA_MedioVirtual = this.CUBA_MedioVirtual;
				Item.CUBA_InscritoSOL = this.CUBA_InscritoSOL;
				Item.CUBA_Descripcion = this.CUBA_Descripcion;
				Item.CUBA_CtaEmprVinculada = this.CUBA_CtaEmprVinculada;
				Item.CUBA_SubCtaIngreso = this.CUBA_SubCtaIngreso;
				Item.CUBA_SubCtaEgreso = this.CUBA_SubCtaEgreso;
            Item.CUBA_SubCtaIngresoEV = this.CUBA_SubCtaIngresoEV;
            Item.CUBA_SubCtaEgresoEV = this.CUBA_SubCtaEgresoEV;
            Item.CUBA_LibroDestino = this.CUBA_LibroDestino;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}

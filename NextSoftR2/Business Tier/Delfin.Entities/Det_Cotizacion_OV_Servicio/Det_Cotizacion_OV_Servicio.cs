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
	public partial class Det_Cotizacion_OV_Servicio : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_ccot_tipo;
		private Int32 m_ccot_numero;
		private Int32 m_scot_item;
		private String m_ccot_ingresogasto;
		private Int32 m_serv_codigo;
		private String m_scot_origen;
		private Nullable<Decimal> m_scot_cantidad;
		private Decimal m_scot_preciouni;
		private Decimal m_scot_importe_ingreso;
		private Decimal m_scot_importe_egreso;
		private String m_tipo_tabmnd;
		private String m_tipo_codmnd;
		private Decimal m_scot_presugerido;
		private Nullable<Int16> m_tipe_codigo;
		private Nullable<Int32> m_entc_codigo;
		private Nullable<Int32> m_tari_codigo;
		private String m_cons_tabbas;
		private String m_cons_codbas;
      private Boolean m_scot_exonerado;
      private Nullable<Boolean> m_scot_chagecontrol;
      private String m_pfac_numero;
      private String m_tipo_tabtdo;
      private String m_tipo_codtdo;
      private String m_scot_numerotdo;
      private String m_scot_serietdo;
      private Nullable<DateTime> m_scot_fechaoperacion;
      private Nullable<DateTime> m_scot_fechaemision;
      private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		private Nullable<int> m_ccct_codigo;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Det_Cotizacion_OV_Servicio.
		/// </summary>
		public Det_Cotizacion_OV_Servicio()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CCOT_Tipo.
		/// </summary>
		[DataMember]
		public Int16 CCOT_Tipo
		{
			get { return m_ccot_tipo; }
			set
			{
				if (m_ccot_tipo != value)
				{
					m_ccot_tipo = value;
					OnPropertyChanged("CCOT_Tipo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_Numero.
		/// </summary>
		[DataMember]
		public Int32 CCOT_Numero
		{
			get { return m_ccot_numero; }
			set
			{
				if (m_ccot_numero != value)
				{
					m_ccot_numero = value;
					OnPropertyChanged("CCOT_Numero");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SCOT_Item.
		/// </summary>
		[DataMember]
		public Int32 SCOT_Item
		{
			get { return m_scot_item; }
			set
			{
				if (m_scot_item != value)
				{
					m_scot_item = value;
					OnPropertyChanged("SCOT_Item");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_IngresoGasto.
		/// </summary>
		[DataMember]
      public String CCOT_IngresoGasto
		{
			get { return m_ccot_ingresogasto; }
			set
			{
				if (m_ccot_ingresogasto != value)
				{
					m_ccot_ingresogasto = value;
					OnPropertyChanged("CCOT_IngresoGasto");
               CalcularTotales();
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SERV_Codigo.
		/// </summary>
		[DataMember]
		public Int32 SERV_Codigo
		{
			get { return m_serv_codigo; }
			set
			{
				if (m_serv_codigo != value)
				{
					m_serv_codigo = value;
					OnPropertyChanged("SERV_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SCOT_Origen.
		/// </summary>
		[DataMember]
		public String SCOT_Origen
		{
			get { return m_scot_origen; }
			set
			{
				if (m_scot_origen != value)
				{
					m_scot_origen = value;
					OnPropertyChanged("SCOT_Origen");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SCOT_Cantidad.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> SCOT_Cantidad
		{
			get { return m_scot_cantidad; }
			set
			{
				if (m_scot_cantidad != value)
				{
					m_scot_cantidad = value;
					OnPropertyChanged("SCOT_Cantidad");
               CalcularTotales();
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SCOT_PrecioUni.
		/// </summary>
		[DataMember]
		public Decimal SCOT_PrecioUni
		{
			get { return m_scot_preciouni; }
			set
			{
				if (m_scot_preciouni != value)
				{
					m_scot_preciouni = value;
					OnPropertyChanged("SCOT_PrecioUni");
               CalcularTotales();
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SCOT_Importe_Ingreso.
		/// </summary>
		[DataMember]
		public Decimal SCOT_Importe_Ingreso
		{
			get { return m_scot_importe_ingreso; }
			set
			{
				if (m_scot_importe_ingreso != value)
				{
					m_scot_importe_ingreso = value;
					OnPropertyChanged("SCOT_Importe_Ingreso");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SCOT_Importe_Egreso.
		/// </summary>
		[DataMember]
		public Decimal SCOT_Importe_Egreso
		{
			get { return m_scot_importe_egreso; }
			set
			{
				if (m_scot_importe_egreso != value)
				{
					m_scot_importe_egreso = value;
					OnPropertyChanged("SCOT_Importe_Egreso");
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
               if (!String.IsNullOrEmpty(m_tipo_codmnd))
               { TIPO_TabMnd = "MND"; }
					OnPropertyChanged("TIPO_CodMnd");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SCOT_PreSugerido.
		/// </summary>
		[DataMember]
		public Decimal SCOT_PreSugerido
		{
			get { return m_scot_presugerido; }
			set
			{
				if (m_scot_presugerido != value)
				{
					m_scot_presugerido = value;
					OnPropertyChanged("SCOT_PreSugerido");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPE_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int16> TIPE_Codigo
		{
			get { return m_tipe_codigo; }
			set
			{
				if (m_tipe_codigo != value)
				{
					m_tipe_codigo = value;
					OnPropertyChanged("TIPE_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_Codigo
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
		/// Gets or sets el valor de: TARI_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> TARI_Codigo
		{
			get { return m_tari_codigo; }
			set
			{
				if (m_tari_codigo != value)
				{
					m_tari_codigo = value;
					OnPropertyChanged("TARI_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_TabBas.
		/// </summary>
		[DataMember]
		public String CONS_TabBas
		{
			get { return m_cons_tabbas; }
			set
			{
				if (m_cons_tabbas != value)
				{
					m_cons_tabbas = value;
					OnPropertyChanged("CONS_TabBas");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodBas.
		/// </summary>
		[DataMember]
		public String CONS_CodBas
		{
			get { return m_cons_codbas; }
			set
			{
				if (m_cons_codbas != value)
				{
					m_cons_codbas = value;
               if (!String.IsNullOrEmpty(m_cons_codbas))
               { CONS_TabBas = "BAS"; }
					OnPropertyChanged("CONS_CodBas");
				}
			}
		}
      /// <summary>
      /// Gets or sets el valor de: SCOT_Exonerado.
		/// </summary>
		[DataMember]
      public Boolean SCOT_Exonerado
		{
         get { return m_scot_exonerado; }
			set
			{
            if (m_scot_exonerado != value)
				{
               m_scot_exonerado = value;
               OnPropertyChanged("SCOT_Exonerado");
				}
			}
		}
      /// <summary>
      /// Gets or sets el valor de: SCOT_ChageControl.
      /// </summary>
      [DataMember]
      public Nullable<Boolean> SCOT_ChageControl
      {
         get { return m_scot_chagecontrol; }
         set
         {
            if (m_scot_chagecontrol != value)
            {
               m_scot_chagecontrol = value;
               OnPropertyChanged("SCOT_ChageControl");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: PFAC_Numero.
      /// </summary>
      [DataMember]
      public String PFAC_Numero
      {
         get { return m_pfac_numero; }
         set
         {
            if (m_pfac_numero != value)
            {
               m_pfac_numero = value;
               OnPropertyChanged("PFAC_Numero");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_TabTDO.
      /// </summary>
      [DataMember]
      public String TIPO_TabTDO
      {
         get { return m_tipo_tabtdo; }
         set
         {
            if (m_tipo_tabtdo != value)
            {
               m_tipo_tabtdo = value;
               OnPropertyChanged("TIPO_TabTDO");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_CodTDO.
      /// </summary>
      [DataMember]
      public String TIPO_CodTDO
      {
         get { return m_tipo_codtdo; }
         set
         {
            if (m_tipo_codtdo != value)
            {
               m_tipo_codtdo = value;
               OnPropertyChanged("TIPO_CodTDO");
            }
            if (!String.IsNullOrEmpty(m_tipo_codtdo))
            { TIPO_TabTDO = "TDO"; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: SCOT_NumeroTDO.
      /// </summary>
      [DataMember]
      public String SCOT_NumeroTDO
      {
         get { return m_scot_numerotdo; }
         set
         {
            if (m_scot_numerotdo != value)
            {
               m_scot_numerotdo = value;
               OnPropertyChanged("SCOT_NumeroTDO");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: SCOT_SerieTDO.
      /// </summary>
      [DataMember]
      public String SCOT_SerieTDO
      {
         get { return m_scot_serietdo; }
         set
         {
            if (m_scot_serietdo != value)
            {
               m_scot_serietdo = value;
               OnPropertyChanged("SCOT_SerieTDO");
            }
         }
      }
      		/// <summary>
      /// Gets or sets el valor de: SCOT_FechaOperacion.
		/// </summary>
		[DataMember]
      public Nullable<DateTime> SCOT_FechaOperacion
		{
         get { return m_scot_fechaoperacion; }
			set
			{
            if (m_scot_fechaoperacion != value)
				{
               m_scot_fechaoperacion = value;
               OnPropertyChanged("SCOT_FechaOperacion");
				}
			}
		}
      /// <summary>
      /// Gets or sets el valor de: SCOT_FechaEmision.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> SCOT_FechaEmision
      {
         get { return m_scot_fechaemision; }
         set
         {
            if (m_scot_fechaemision != value)
            {
               m_scot_fechaemision = value;
               OnPropertyChanged("SCOT_FechaEmision");
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
		/// <summary>
		/// Gets or sets el valor de: SCOT_Cantidad.
		/// </summary>
		[DataMember]
		public Nullable<int> CCCT_Codigo
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
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref Det_Cotizacion_OV_Servicio Item)
		{
         try
         {
            if (Item == null) { Item = new Det_Cotizacion_OV_Servicio(); }
            Item.CCOT_Tipo = this.CCOT_Tipo;
            Item.CCOT_Numero = this.CCOT_Numero;
            Item.SCOT_Item = this.SCOT_Item;
            Item.CCOT_IngresoGasto = this.CCOT_IngresoGasto;
            Item.SERV_Codigo = this.SERV_Codigo;
            Item.SCOT_Origen = this.SCOT_Origen;
            Item.SCOT_Cantidad = this.SCOT_Cantidad;
            Item.SCOT_PrecioUni = this.SCOT_PrecioUni;
            Item.SCOT_Importe_Ingreso = this.SCOT_Importe_Ingreso;
            Item.SCOT_Importe_Egreso = this.SCOT_Importe_Egreso;
            Item.TIPO_TabMnd = this.TIPO_TabMnd;
            Item.TIPO_CodMnd = this.TIPO_CodMnd;
            Item.SCOT_PreSugerido = this.SCOT_PreSugerido;
            Item.TIPE_Codigo = this.TIPE_Codigo;
            Item.ENTC_Codigo = this.ENTC_Codigo;
            Item.TARI_Codigo = this.TARI_Codigo;
            Item.CONS_TabBas = this.CONS_TabBas;
            Item.CONS_CodBas = this.CONS_CodBas;
            Item.SCOT_ChageControl = this.SCOT_ChageControl;
            Item.PFAC_Numero = this.PFAC_Numero;
            Item.TIPO_TabTDO = this.TIPO_TabTDO;
            Item.TIPO_CodTDO = this.TIPO_CodTDO;
            Item.SCOT_NumeroTDO = this.SCOT_NumeroTDO;
            Item.SCOT_SerieTDO = this.SCOT_SerieTDO;
            Item.SCOT_FechaOperacion = this.SCOT_FechaOperacion;
            Item.SCOT_FechaEmision = this.SCOT_FechaEmision;
            Item.SCOT_Exonerado = this.SCOT_Exonerado;
            Item.ENTC_NomCom = this.ENTC_NomCom;
            Item.SERV_AfeIgv = this.SERV_AfeIgv;
            Item.SERV_AfeDet = this.SERV_AfeDet;
            Item.SERV_Nombre = this.SERV_Nombre;
            Item.TIPO_DescMnd = this.TIPO_DescMnd;
            Item.TIPO_DescCMnd = this.TIPO_DescCMnd;
            Item.TIPO_DescTDO = this.TIPO_DescTDO;
            //Item.TIPO_DescCTDO = this.TIPO_DescCTDO;
            Item.SCOT_Editable = this.SCOT_Editable;
            Item.SCOT_Eliminable = this.SCOT_Eliminable;
            Item.CHAN_Cerrado = this.CHAN_Cerrado;

            Item.AUDI_UsrCrea = this.AUDI_UsrCrea;
            Item.AUDI_FecCrea = this.AUDI_FecCrea;
            Item.AUDI_UsrMod = this.AUDI_UsrMod;
            Item.AUDI_FecMod = this.AUDI_FecMod;
			Item.CCCT_Codigo = this.CCCT_Codigo;

         }
         catch (Exception ex)
         { throw ex; }
		}
		#endregion
	}
}

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
	public partial class Det_Cotizacion_OV_Servicio
	{
		#region [ Variables Validación ]
		private Boolean m_ccot_tipoOK;
		private String m_ccot_tipoMSGERROR;
		private Boolean m_ccot_numeroOK;
		private String m_ccot_numeroMSGERROR;
		private Boolean m_scot_itemOK;
		private String m_scot_itemMSGERROR;
		private Boolean m_ccot_ingresogastoOK;
		private String m_ccot_ingresogastoMSGERROR;
		private Boolean m_serv_codigoOK;
		private String m_serv_codigoMSGERROR;
		private Boolean m_scot_origenOK;
		private String m_scot_origenMSGERROR;
		private Boolean m_scot_cantidadOK;
		private String m_scot_cantidadMSGERROR;
		private Boolean m_scot_preciouniOK;
		private String m_scot_preciouniMSGERROR;
		private Boolean m_scot_importe_ingresoOK;
		private String m_scot_importe_ingresoMSGERROR;
		private Boolean m_scot_importe_egresoOK;
		private String m_scot_importe_egresoMSGERROR;
		private Boolean m_tipo_tabmndOK;
		private String m_tipo_tabmndMSGERROR;
		private Boolean m_tipo_codmndOK;
		private String m_tipo_codmndMSGERROR;
		private Boolean m_scot_presugeridoOK;
		private String m_scot_presugeridoMSGERROR;
		private Boolean m_tipe_codigoOK;
		private String m_tipe_codigoMSGERROR;
		private Boolean m_entc_codigoOK;
		private String m_entc_codigoMSGERROR;
		private Boolean m_tari_codigoOK;
		private String m_tari_codigoMSGERROR;
		private Boolean m_cons_tabbasOK;
		private String m_cons_tabbasMSGERROR;
		private Boolean m_cons_codbasOK;
		private String m_cons_codbasMSGERROR;
      private Boolean m_scot_exoneradoOK;
      private String m_scot_exoneradoMSGERROR;
      private Boolean m_scot_chagecontrolOK;
      private String m_scot_chagecontrolMSGERROR;
      private Boolean m_pfac_numeroOK;
      private String m_pfac_numeroMSGERROR;
      private Boolean m_tipo_tabtdoOK;
      private String m_tipo_tabtdoMSGERROR;
      private Boolean m_tipo_codtdoOK;
      private String m_tipo_codtdoMSGERROR;
      private Boolean m_scot_numerotdoOK;
      private String m_scot_numerotdoMSGERROR;
      private Boolean m_scot_serietdoOK;
      private String m_scot_serietdoMSGERROR;
      private Boolean m_audi_usrcreaOK;
		private String m_audi_usrcreaMSGERROR;
		private Boolean m_audi_feccreaOK;
		private String m_audi_feccreaMSGERROR;
		private Boolean m_audi_usrmodOK;
		private String m_audi_usrmodMSGERROR;
		private Boolean m_audi_fecmodOK;
		private String m_audi_fecmodMSGERROR;

      private Boolean m_scot_fechaoperacionOK;
      private String m_scot_fechaoperacionMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: CCOT_Tipo.
		/// </summary>
		[DataMember]
		public Boolean CCOT_TipoOK
		{
			get { return m_ccot_tipoOK; }
			set
			{
				if (m_ccot_tipoOK != value)
				{
					m_ccot_tipoOK = value;
					//OnPropertyChanged("CCOT_TipoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCOT_Tipo.
		/// </summary>
		[DataMember]
		public String CCOT_TipoMSGERROR
		{
			get { return m_ccot_tipoMSGERROR; }
			set
			{
				if (m_ccot_tipoMSGERROR != value)
				{
					m_ccot_tipoMSGERROR = value;
					//OnPropertyChanged("CCOT_TipoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CCOT_Numero.
		/// </summary>
		[DataMember]
		public Boolean CCOT_NumeroOK
		{
			get { return m_ccot_numeroOK; }
			set
			{
				if (m_ccot_numeroOK != value)
				{
					m_ccot_numeroOK = value;
					//OnPropertyChanged("CCOT_NumeroOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCOT_Numero.
		/// </summary>
		[DataMember]
		public String CCOT_NumeroMSGERROR
		{
			get { return m_ccot_numeroMSGERROR; }
			set
			{
				if (m_ccot_numeroMSGERROR != value)
				{
					m_ccot_numeroMSGERROR = value;
					//OnPropertyChanged("CCOT_NumeroMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SCOT_Item.
		/// </summary>
		[DataMember]
		public Boolean SCOT_ItemOK
		{
			get { return m_scot_itemOK; }
			set
			{
				if (m_scot_itemOK != value)
				{
					m_scot_itemOK = value;
					//OnPropertyChanged("SCOT_ItemOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SCOT_Item.
		/// </summary>
		[DataMember]
		public String SCOT_ItemMSGERROR
		{
			get { return m_scot_itemMSGERROR; }
			set
			{
				if (m_scot_itemMSGERROR != value)
				{
					m_scot_itemMSGERROR = value;
					//OnPropertyChanged("SCOT_ItemMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CCOT_IngresoGasto.
		/// </summary>
		[DataMember]
		public Boolean CCOT_IngresoGastoOK
		{
			get { return m_ccot_ingresogastoOK; }
			set
			{
				if (m_ccot_ingresogastoOK != value)
				{
					m_ccot_ingresogastoOK = value;
					//OnPropertyChanged("CCOT_IngresoGastoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCOT_IngresoGasto.
		/// </summary>
		[DataMember]
		public String CCOT_IngresoGastoMSGERROR
		{
			get { return m_ccot_ingresogastoMSGERROR; }
			set
			{
				if (m_ccot_ingresogastoMSGERROR != value)
				{
					m_ccot_ingresogastoMSGERROR = value;
					//OnPropertyChanged("CCOT_IngresoGastoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SERV_Codigo.
		/// </summary>
		[DataMember]
		public Boolean SERV_CodigoOK
		{
			get { return m_serv_codigoOK; }
			set
			{
				if (m_serv_codigoOK != value)
				{
					m_serv_codigoOK = value;
					//OnPropertyChanged("SERV_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SERV_Codigo.
		/// </summary>
		[DataMember]
		public String SERV_CodigoMSGERROR
		{
			get { return m_serv_codigoMSGERROR; }
			set
			{
				if (m_serv_codigoMSGERROR != value)
				{
					m_serv_codigoMSGERROR = value;
					//OnPropertyChanged("SERV_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SCOT_Origen.
		/// </summary>
		[DataMember]
		public Boolean SCOT_OrigenOK
		{
			get { return m_scot_origenOK; }
			set
			{
				if (m_scot_origenOK != value)
				{
					m_scot_origenOK = value;
					//OnPropertyChanged("SCOT_OrigenOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SCOT_Origen.
		/// </summary>
		[DataMember]
		public String SCOT_OrigenMSGERROR
		{
			get { return m_scot_origenMSGERROR; }
			set
			{
				if (m_scot_origenMSGERROR != value)
				{
					m_scot_origenMSGERROR = value;
					//OnPropertyChanged("SCOT_OrigenMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SCOT_Cantidad.
		/// </summary>
		[DataMember]
		public Boolean SCOT_CantidadOK
		{
			get { return m_scot_cantidadOK; }
			set
			{
				if (m_scot_cantidadOK != value)
				{
					m_scot_cantidadOK = value;
					//OnPropertyChanged("SCOT_CantidadOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SCOT_Cantidad.
		/// </summary>
		[DataMember]
		public String SCOT_CantidadMSGERROR
		{
			get { return m_scot_cantidadMSGERROR; }
			set
			{
				if (m_scot_cantidadMSGERROR != value)
				{
					m_scot_cantidadMSGERROR = value;
					//OnPropertyChanged("SCOT_CantidadMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SCOT_PrecioUni.
		/// </summary>
		[DataMember]
		public Boolean SCOT_PrecioUniOK
		{
			get { return m_scot_preciouniOK; }
			set
			{
				if (m_scot_preciouniOK != value)
				{
					m_scot_preciouniOK = value;
					//OnPropertyChanged("SCOT_PrecioUniOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SCOT_PrecioUni.
		/// </summary>
		[DataMember]
		public String SCOT_PrecioUniMSGERROR
		{
			get { return m_scot_preciouniMSGERROR; }
			set
			{
				if (m_scot_preciouniMSGERROR != value)
				{
					m_scot_preciouniMSGERROR = value;
					//OnPropertyChanged("SCOT_PrecioUniMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SCOT_Importe_Ingreso.
		/// </summary>
		[DataMember]
		public Boolean SCOT_Importe_IngresoOK
		{
			get { return m_scot_importe_ingresoOK; }
			set
			{
				if (m_scot_importe_ingresoOK != value)
				{
					m_scot_importe_ingresoOK = value;
					//OnPropertyChanged("SCOT_Importe_IngresoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SCOT_Importe_Ingreso.
		/// </summary>
		[DataMember]
		public String SCOT_Importe_IngresoMSGERROR
		{
			get { return m_scot_importe_ingresoMSGERROR; }
			set
			{
				if (m_scot_importe_ingresoMSGERROR != value)
				{
					m_scot_importe_ingresoMSGERROR = value;
					//OnPropertyChanged("SCOT_Importe_IngresoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SCOT_Importe_Egreso.
		/// </summary>
		[DataMember]
		public Boolean SCOT_Importe_EgresoOK
		{
			get { return m_scot_importe_egresoOK; }
			set
			{
				if (m_scot_importe_egresoOK != value)
				{
					m_scot_importe_egresoOK = value;
					//OnPropertyChanged("SCOT_Importe_EgresoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SCOT_Importe_Egreso.
		/// </summary>
		[DataMember]
		public String SCOT_Importe_EgresoMSGERROR
		{
			get { return m_scot_importe_egresoMSGERROR; }
			set
			{
				if (m_scot_importe_egresoMSGERROR != value)
				{
					m_scot_importe_egresoMSGERROR = value;
					//OnPropertyChanged("SCOT_Importe_EgresoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabMnd.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabMndOK
		{
			get { return m_tipo_tabmndOK; }
			set
			{
				if (m_tipo_tabmndOK != value)
				{
					m_tipo_tabmndOK = value;
					//OnPropertyChanged("TIPO_TabMndOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabMnd.
		/// </summary>
		[DataMember]
		public String TIPO_TabMndMSGERROR
		{
			get { return m_tipo_tabmndMSGERROR; }
			set
			{
				if (m_tipo_tabmndMSGERROR != value)
				{
					m_tipo_tabmndMSGERROR = value;
					//OnPropertyChanged("TIPO_TabMndMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodMnd.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodMndOK
		{
			get { return m_tipo_codmndOK; }
			set
			{
				if (m_tipo_codmndOK != value)
				{
					m_tipo_codmndOK = value;
					//OnPropertyChanged("TIPO_CodMndOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodMnd.
		/// </summary>
		[DataMember]
		public String TIPO_CodMndMSGERROR
		{
			get { return m_tipo_codmndMSGERROR; }
			set
			{
				if (m_tipo_codmndMSGERROR != value)
				{
					m_tipo_codmndMSGERROR = value;
					//OnPropertyChanged("TIPO_CodMndMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SCOT_PreSugerido.
		/// </summary>
		[DataMember]
		public Boolean SCOT_PreSugeridoOK
		{
			get { return m_scot_presugeridoOK; }
			set
			{
				if (m_scot_presugeridoOK != value)
				{
					m_scot_presugeridoOK = value;
					//OnPropertyChanged("SCOT_PreSugeridoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SCOT_PreSugerido.
		/// </summary>
		[DataMember]
		public String SCOT_PreSugeridoMSGERROR
		{
			get { return m_scot_presugeridoMSGERROR; }
			set
			{
				if (m_scot_presugeridoMSGERROR != value)
				{
					m_scot_presugeridoMSGERROR = value;
					//OnPropertyChanged("SCOT_PreSugeridoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPE_Codigo.
		/// </summary>
		[DataMember]
		public Boolean TIPE_CodigoOK
		{
			get { return m_tipe_codigoOK; }
			set
			{
				if (m_tipe_codigoOK != value)
				{
					m_tipe_codigoOK = value;
					//OnPropertyChanged("TIPE_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPE_Codigo.
		/// </summary>
		[DataMember]
		public String TIPE_CodigoMSGERROR
		{
			get { return m_tipe_codigoMSGERROR; }
			set
			{
				if (m_tipe_codigoMSGERROR != value)
				{
					m_tipe_codigoMSGERROR = value;
					//OnPropertyChanged("TIPE_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_Codigo.
		/// </summary>
		[DataMember]
		public Boolean ENTC_CodigoOK
		{
			get { return m_entc_codigoOK; }
			set
			{
				if (m_entc_codigoOK != value)
				{
					m_entc_codigoOK = value;
					//OnPropertyChanged("ENTC_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_Codigo.
		/// </summary>
		[DataMember]
		public String ENTC_CodigoMSGERROR
		{
			get { return m_entc_codigoMSGERROR; }
			set
			{
				if (m_entc_codigoMSGERROR != value)
				{
					m_entc_codigoMSGERROR = value;
					//OnPropertyChanged("ENTC_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TARI_Codigo.
		/// </summary>
		[DataMember]
		public Boolean TARI_CodigoOK
		{
			get { return m_tari_codigoOK; }
			set
			{
				if (m_tari_codigoOK != value)
				{
					m_tari_codigoOK = value;
					//OnPropertyChanged("TARI_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TARI_Codigo.
		/// </summary>
		[DataMember]
		public String TARI_CodigoMSGERROR
		{
			get { return m_tari_codigoMSGERROR; }
			set
			{
				if (m_tari_codigoMSGERROR != value)
				{
					m_tari_codigoMSGERROR = value;
					//OnPropertyChanged("TARI_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_TabBas.
		/// </summary>
		[DataMember]
		public Boolean CONS_TabBasOK
		{
			get { return m_cons_tabbasOK; }
			set
			{
				if (m_cons_tabbasOK != value)
				{
					m_cons_tabbasOK = value;
					//OnPropertyChanged("CONS_TabBasOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_TabBas.
		/// </summary>
		[DataMember]
		public String CONS_TabBasMSGERROR
		{
			get { return m_cons_tabbasMSGERROR; }
			set
			{
				if (m_cons_tabbasMSGERROR != value)
				{
					m_cons_tabbasMSGERROR = value;
					//OnPropertyChanged("CONS_TabBasMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_CodBas.
		/// </summary>
		[DataMember]
		public Boolean CONS_CodBasOK
		{
			get { return m_cons_codbasOK; }
			set
			{
				if (m_cons_codbasOK != value)
				{
					m_cons_codbasOK = value;
					//OnPropertyChanged("CONS_CodBasOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_CodBas.
		/// </summary>
		[DataMember]
		public String CONS_CodBasMSGERROR
		{
			get { return m_cons_codbasMSGERROR; }
			set
			{
				if (m_cons_codbasMSGERROR != value)
				{
					m_cons_codbasMSGERROR = value;
					//OnPropertyChanged("CONS_CodBasMSGERROR");
				}
			}
		}
      /// <summary>
      /// Gets or sets el valor de validación de: SCOT_Exonerado.
      /// </summary>
      [IgnoreDataMember]
      public Boolean SCOT_ExoneradoOK
      {
         get { return m_scot_exoneradoOK; }
         set
         {
            if (m_scot_exoneradoOK != value)
            { m_scot_exoneradoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: SCOT_Exonerado.
      /// </summary>
      [IgnoreDataMember]
      public String SCOT_ExoneradoMSGERROR
      {
         get { return m_scot_exoneradoMSGERROR; }
         set
         {
            if (m_scot_exoneradoMSGERROR != value)
            { m_scot_exoneradoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: SCOT_ChageControl.
      /// </summary>
      [IgnoreDataMember]
      public Boolean SCOT_ChageControlOK
      {
         get { return m_scot_chagecontrolOK; }
         set
         {
            if (m_scot_chagecontrolOK != value)
            { m_scot_chagecontrolOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: SCOT_ChageControl.
      /// </summary>
      [IgnoreDataMember]
      public String SCOT_ChageControlMSGERROR
      {
         get { return m_scot_chagecontrolMSGERROR; }
         set
         {
            if (m_scot_chagecontrolMSGERROR != value)
            { m_scot_chagecontrolMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: PFAC_Numero.
      /// </summary>
      [IgnoreDataMember]
      public Boolean PFAC_NumeroOK
      {
         get { return m_pfac_numeroOK; }
         set
         {
            if (m_pfac_numeroOK != value)
            { m_pfac_numeroOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: PFAC_Numero.
      /// </summary>
      [IgnoreDataMember]
      public String PFAC_NumeroMSGERROR
      {
         get { return m_pfac_numeroMSGERROR; }
         set
         {
            if (m_pfac_numeroMSGERROR != value)
            { m_pfac_numeroMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: TIPO_TabTDO.
      /// </summary>
      [IgnoreDataMember]
      public Boolean TIPO_TabTDOOK
      {
         get { return m_tipo_tabtdoOK; }
         set
         {
            if (m_tipo_tabtdoOK != value)
            { m_tipo_tabtdoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TIPO_TabTDO.
      /// </summary>
      [IgnoreDataMember]
      public String TIPO_TabTDOMSGERROR
      {
         get { return m_tipo_tabtdoMSGERROR; }
         set
         {
            if (m_tipo_tabtdoMSGERROR != value)
            { m_tipo_tabtdoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: TIPO_CodTDO.
      /// </summary>
      [IgnoreDataMember]
      public Boolean TIPO_CodTDOOK
      {
         get { return m_tipo_codtdoOK; }
         set
         {
            if (m_tipo_codtdoOK != value)
            { m_tipo_codtdoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TIPO_CodTDO.
      /// </summary>
      [IgnoreDataMember]
      public String TIPO_CodTDOMSGERROR
      {
         get { return m_tipo_codtdoMSGERROR; }
         set
         {
            if (m_tipo_codtdoMSGERROR != value)
            { m_tipo_codtdoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: SCOT_NumeroTDO.
      /// </summary>
      [IgnoreDataMember]
      public Boolean SCOT_NumeroTDOOK
      {
         get { return m_scot_numerotdoOK; }
         set
         {
            if (m_scot_numerotdoOK != value)
            { m_scot_numerotdoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: SCOT_NumeroTDO.
      /// </summary>
      [IgnoreDataMember]
      public String SCOT_NumeroTDOMSGERROR
      {
         get { return m_scot_numerotdoMSGERROR; }
         set
         {
            if (m_scot_numerotdoMSGERROR != value)
            { m_scot_numerotdoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: SCOT_SerieTDO.
      /// </summary>
      [IgnoreDataMember]
      public Boolean SCOT_SerieTDOOK
      {
         get { return m_scot_serietdoOK; }
         set
         {
            if (m_scot_serietdoOK != value)
            { m_scot_serietdoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: SCOT_SerieTDO.
      /// </summary>
      [IgnoreDataMember]
      public String SCOT_SerieTDOMSGERROR
      {
         get { return m_scot_serietdoMSGERROR; }
         set
         {
            if (m_scot_serietdoMSGERROR != value)
            { m_scot_serietdoMSGERROR = value; }
         }
      }
		
      /// <summary>
      /// Gets or sets el valor de validación de: SCOT_SerieSCOT_FechaOperacionTDO.
      /// </summary>
      [IgnoreDataMember]
      public Boolean SCOT_FechaOperacionOK
      {
         get { return m_scot_fechaoperacionOK; }
         set
         {
            if (m_scot_fechaoperacionOK != value)
            { m_scot_fechaoperacionOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: SCOT_FechaOperacion.
      /// </summary>
      [IgnoreDataMember]
      public String SCOT_FechaOperacionMSGERROR
      {
         get { return m_scot_fechaoperacionMSGERROR; }
         set
         {
            if (m_scot_fechaoperacionMSGERROR != value)
            { m_scot_fechaoperacionMSGERROR = value; }
         }
      }

      #endregion

		#region [ Validacion ]
		private String m_mensajeError;
		
		[DataMember]
		public String MensajeError
		{
			get { return m_mensajeError; }
		}
		public Boolean Validar()
		{
         try
         {
            Boolean _isCorrect = true;
            m_mensajeError = "";
            CCOT_TipoOK = true;
            CCOT_TipoMSGERROR = "";
            //if( CCOT_Tipo == null)
            //{
            //   _isCorrect = false;
            //   CCOT_TipoOK  = false;
            //   CCOT_TipoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCOT_Tipo", "Det_Cotizacion_OV_Servicio");
            //   m_mensajeError += "* Debe ingresar el campo CCOT_Tipo" + Environment.NewLine;
            //}
            CCOT_NumeroOK = true;
            CCOT_NumeroMSGERROR = "";
            //if( CCOT_Numero == null)
            //{
            //   _isCorrect = false;
            //   CCOT_NumeroOK  = false;
            //   CCOT_NumeroMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCOT_Numero", "Det_Cotizacion_OV_Servicio");
            //   m_mensajeError += "* Debe ingresar el campo CCOT_Numero" + Environment.NewLine;
            //}
            SCOT_ItemOK = true;
            SCOT_ItemMSGERROR = "";
            if (SCOT_Item == null)
            {
               _isCorrect = false;
               SCOT_ItemOK = false;
               SCOT_ItemMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Item", (SCOT_ChageControl.HasValue && SCOT_ChageControl.Value ? "Servicio Change Control" : "Servicio Adicional"));
               m_mensajeError += "* Debe ingresar el campo Item" + Environment.NewLine;
            }
            SERV_CodigoOK = true;
            SERV_CodigoMSGERROR = "";
            if (SERV_Codigo == null)
            {
               _isCorrect = false;
               SERV_CodigoOK = false;
               SERV_CodigoMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Servicio", (SCOT_ChageControl.HasValue && SCOT_ChageControl.Value ? "Servicio Change Control" : "Servicio Adicional"));
               m_mensajeError += "* Debe ingresar el campo Servicio" + Environment.NewLine;
            }
            CCOT_IngresoGastoOK = true;
            CCOT_IngresoGastoMSGERROR = "";
            if (String.IsNullOrEmpty(CCOT_IngresoGasto))
            {
               _isCorrect = false;
               CCOT_IngresoGastoOK = false;
               CCOT_IngresoGastoMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Ingreso/Egreso", (SCOT_ChageControl.HasValue && SCOT_ChageControl.Value ? "Servicio Change Control" : "Servicio Adicional"));
               m_mensajeError += "* Debe ingresar el campo Ingreso/Egreso" + Environment.NewLine;
            }
            
            SCOT_CantidadOK = true;
            SCOT_CantidadMSGERROR = "";
            if (!SCOT_Cantidad.HasValue || SCOT_Cantidad.Value <= 0)
            {
               _isCorrect = false;
               SCOT_CantidadOK = false;
               SCOT_CantidadMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Cantidad", (SCOT_ChageControl.HasValue && SCOT_ChageControl.Value ? "Servicio Change Control" : "Servicio Adicional"));
               m_mensajeError += "* Debe ingresar el campo Cantidad" + Environment.NewLine;
            }
            SCOT_OrigenOK = true;
            SCOT_OrigenMSGERROR = "";
            if (SCOT_Origen == null)
            {
               _isCorrect = false;
               SCOT_OrigenOK = false;
               SCOT_OrigenMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Origen", (SCOT_ChageControl.HasValue && SCOT_ChageControl.Value ? "Servicio Change Control" : "Servicio Adicional"));
               m_mensajeError += "* Debe ingresar el campo Origen" + Environment.NewLine;
            }

            SCOT_PrecioUniOK = true;
            SCOT_PrecioUniMSGERROR = "";
            if (SCOT_PrecioUni == null || SCOT_PrecioUni <= 0)
            {
               _isCorrect = false;
               SCOT_PrecioUniOK = false;
               SCOT_PrecioUniMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Precio Unitario", (SCOT_ChageControl.HasValue && SCOT_ChageControl.Value ? "Servicio Change Control" : "Servicio Adicional"));
               m_mensajeError += "* Debe ingresar el campo Precio Unitario" + Environment.NewLine;
            }
            SCOT_Importe_IngresoOK = true;
            SCOT_Importe_IngresoMSGERROR = "";
            if (SCOT_Origen == "I" && (SCOT_Importe_Ingreso == null || SCOT_Importe_Ingreso <= 0))
            {
               _isCorrect = false;
               SCOT_Importe_IngresoOK = false;
               SCOT_Importe_IngresoMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Importe Ingreso", (SCOT_ChageControl.HasValue && SCOT_ChageControl.Value ? "Servicio Change Control" : "Servicio Adicional"));
               m_mensajeError += "* Debe ingresar el campo Importe Ingreso" + Environment.NewLine;
            }
            SCOT_Importe_EgresoOK = true;
            SCOT_Importe_EgresoMSGERROR = "";
            if (SCOT_Origen == "E" && (SCOT_Importe_Egreso == null || SCOT_Importe_Egreso <= 0))
            {
               _isCorrect = false;
               SCOT_Importe_EgresoOK = false;
               SCOT_Importe_EgresoMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Importe Egreso", (SCOT_ChageControl.HasValue && SCOT_ChageControl.Value ? "Servicio Change Control" : "Servicio Adicional"));
               m_mensajeError += "* Debe ingresar el campo Importe Egreso" + Environment.NewLine;
            }
            SCOT_PreSugeridoOK = true;
            SCOT_PreSugeridoMSGERROR = "";
            //if( SCOT_PreSugerido == null)
            //{
            //   _isCorrect = false;
            //   SCOT_PreSugeridoOK  = false;
            //   SCOT_PreSugeridoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "SCOT_PreSugerido", "Det_Cotizacion_OV_Servicio");
            //   m_mensajeError += "* Debe ingresar el campo SCOT_PreSugerido" + Environment.NewLine;
            //}
            //OnPropertyChanged("MensajeError");

            SCOT_FechaOperacionOK = true;
            SCOT_FechaOperacionMSGERROR = "";
            if (SCOT_ChageControl.HasValue && SCOT_ChageControl.Value && !SCOT_FechaOperacion.HasValue)
            {
               _isCorrect = false;
               SCOT_FechaOperacionOK = false;
               SCOT_FechaOperacionMSGERROR = String.Format("Debe ingresar la {0} de la {1}.", "Fecha de Operación", (SCOT_ChageControl.HasValue && SCOT_ChageControl.Value ? "Servicio Change Control" : "Servicio Adicional"));
               m_mensajeError += "* Debe ingresar la Fecha de Operación" + Environment.NewLine;
            }

            return _isCorrect;
         }
         catch (Exception ex)
         { throw ex; }
		}
      public Boolean ValidarTipoDocumento()
      {
         try
         {
            Boolean _isCorrect = true;
            m_mensajeError = "";

            TIPO_TabTDOOK = true;
            TIPO_CodTDOOK = true;
            TIPO_TabTDOMSGERROR = "";
            TIPO_CodTDOMSGERROR = "";
            if (String.IsNullOrEmpty(TIPO_TabTDO) || String.IsNullOrEmpty(TIPO_CodTDO))
            {
               _isCorrect = false;
               TIPO_TabTDOOK = false;
               TIPO_TabTDOMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Tipo Documento", "Servicio");
               TIPO_CodTDOOK = false;
               TIPO_CodTDOMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Tipo Documento", "Servicio");
               m_mensajeError += "* Debe ingresar el campo Tipo Documento" + Environment.NewLine;
            }

            SCOT_SerieTDOOK = true;
            SCOT_SerieTDOMSGERROR = "";
            if (String.IsNullOrEmpty(SCOT_SerieTDO))
            {
               _isCorrect = false;
               SCOT_SerieTDOOK = false;
               SCOT_SerieTDOMSGERROR = String.Format("Debe ingresar la {0} del {1}.", "Serie Documento", "Servicio");
               m_mensajeError += "* Debe ingresar el campo Serie Documento" + Environment.NewLine;
            }

            SCOT_NumeroTDOOK = true;
            SCOT_NumeroTDOMSGERROR = "";
            if (String.IsNullOrEmpty(SCOT_SerieTDO))
            {
               _isCorrect = false;
               SCOT_SerieTDOOK = false;
               SCOT_SerieTDOMSGERROR = String.Format("Debe ingresar la {0} del {1}.", "Número Documento", "Servicio");
               m_mensajeError += "* Debe ingresar el campo Número Documento" + Environment.NewLine;
            }

            //OnPropertyChanged("MensajeError");
            return _isCorrect;
         }
         catch (Exception ex)
         { throw ex; }
      }
		#endregion
	}
}

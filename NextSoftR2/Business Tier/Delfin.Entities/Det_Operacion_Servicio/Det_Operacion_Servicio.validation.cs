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
    public partial class Det_Operacion_Servicio
	{
		#region [ Variables Validación ]
		private Boolean m_sope_itemOK;
		private String m_sope_itemMSGERROR;
		private Boolean m_cope_codigoOK;
		private String m_cope_codigoMSGERROR;
		private Boolean m_cons_codbasOK;
		private String m_cons_codbasMSGERROR;
		private Boolean m_cons_tabbasOK;
		private String m_cons_tabbasMSGERROR;
		private Boolean m_tipo_tabmndOK;
		private String m_tipo_tabmndMSGERROR;
		private Boolean m_tipo_codmndOK;
		private String m_tipo_codmndMSGERROR;
		private Boolean m_serv_codigoOK;
		private String m_serv_codigoMSGERROR;
		private Boolean m_entc_codigoOK;
		private String m_entc_codigoMSGERROR;
		private Boolean m_tipe_codigoOK;
		private String m_tipe_codigoMSGERROR;
		private Boolean m_sope_ingresogastoOK;
		private String m_sope_ingresogastoMSGERROR;
		private Boolean m_sope_cantidadOK;
		private String m_sope_cantidadMSGERROR;
		private Boolean m_sope_preciouniOK;
		private String m_sope_preciouniMSGERROR;
		private Boolean m_sope_importeingresoOK;
		private String m_sope_importeingresoMSGERROR;
		private Boolean m_sope_importeegresoOK;
		private String m_sope_importeegresoMSGERROR;
		private Boolean m_audi_usrcreaOK;
		private String m_audi_usrcreaMSGERROR;
		private Boolean m_audi_feccreaOK;
		private String m_audi_feccreaMSGERROR;
		private Boolean m_audi_usrmodOK;
		private String m_audi_usrmodMSGERROR;
		private Boolean m_audi_fecmodOK;
		private String m_audi_fecmodMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: SOPE_Item.
		/// </summary>
		[DataMember]
		public Boolean SOPE_ItemOK
		{
			get { return m_sope_itemOK; }
			set
			{
				if (m_sope_itemOK != value)
				{
					m_sope_itemOK = value;
					OnPropertyChanged("SOPE_ItemOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SOPE_Item.
		/// </summary>
		[DataMember]
		public String SOPE_ItemMSGERROR
		{
			get { return m_sope_itemMSGERROR; }
			set
			{
				if (m_sope_itemMSGERROR != value)
				{
					m_sope_itemMSGERROR = value;
					OnPropertyChanged("SOPE_ItemMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: COPE_Codigo.
		/// </summary>
		[DataMember]
		public Boolean COPE_CodigoOK
		{
			get { return m_cope_codigoOK; }
			set
			{
				if (m_cope_codigoOK != value)
				{
					m_cope_codigoOK = value;
					OnPropertyChanged("COPE_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: COPE_Codigo.
		/// </summary>
		[DataMember]
		public String COPE_CodigoMSGERROR
		{
			get { return m_cope_codigoMSGERROR; }
			set
			{
				if (m_cope_codigoMSGERROR != value)
				{
					m_cope_codigoMSGERROR = value;
					OnPropertyChanged("COPE_CodigoMSGERROR");
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
					OnPropertyChanged("CONS_CodBasOK");
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
					OnPropertyChanged("CONS_CodBasMSGERROR");
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
					OnPropertyChanged("CONS_TabBasOK");
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
					OnPropertyChanged("CONS_TabBasMSGERROR");
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
					OnPropertyChanged("TIPO_TabMndOK");
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
					OnPropertyChanged("TIPO_TabMndMSGERROR");
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
					OnPropertyChanged("TIPO_CodMndOK");
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
					OnPropertyChanged("TIPO_CodMndMSGERROR");
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
					OnPropertyChanged("SERV_CodigoOK");
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
					OnPropertyChanged("SERV_CodigoMSGERROR");
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
					OnPropertyChanged("ENTC_CodigoOK");
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
					OnPropertyChanged("ENTC_CodigoMSGERROR");
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
					OnPropertyChanged("TIPE_CodigoOK");
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
					OnPropertyChanged("TIPE_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SOPE_IngresoGasto.
		/// </summary>
		[DataMember]
		public Boolean SOPE_IngresoGastoOK
		{
			get { return m_sope_ingresogastoOK; }
			set
			{
				if (m_sope_ingresogastoOK != value)
				{
					m_sope_ingresogastoOK = value;
					OnPropertyChanged("SOPE_IngresoGastoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SOPE_IngresoGasto.
		/// </summary>
		[DataMember]
		public String SOPE_IngresoGastoMSGERROR
		{
			get { return m_sope_ingresogastoMSGERROR; }
			set
			{
				if (m_sope_ingresogastoMSGERROR != value)
				{
					m_sope_ingresogastoMSGERROR = value;
					OnPropertyChanged("SOPE_IngresoGastoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SOPE_Cantidad.
		/// </summary>
		[DataMember]
		public Boolean SOPE_CantidadOK
		{
			get { return m_sope_cantidadOK; }
			set
			{
				if (m_sope_cantidadOK != value)
				{
					m_sope_cantidadOK = value;
					OnPropertyChanged("SOPE_CantidadOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SOPE_Cantidad.
		/// </summary>
		[DataMember]
		public String SOPE_CantidadMSGERROR
		{
			get { return m_sope_cantidadMSGERROR; }
			set
			{
				if (m_sope_cantidadMSGERROR != value)
				{
					m_sope_cantidadMSGERROR = value;
					OnPropertyChanged("SOPE_CantidadMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SOPE_PrecioUni.
		/// </summary>
		[DataMember]
		public Boolean SOPE_PrecioUniOK
		{
			get { return m_sope_preciouniOK; }
			set
			{
				if (m_sope_preciouniOK != value)
				{
					m_sope_preciouniOK = value;
					OnPropertyChanged("SOPE_PrecioUniOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SOPE_PrecioUni.
		/// </summary>
		[DataMember]
		public String SOPE_PrecioUniMSGERROR
		{
			get { return m_sope_preciouniMSGERROR; }
			set
			{
				if (m_sope_preciouniMSGERROR != value)
				{
					m_sope_preciouniMSGERROR = value;
					OnPropertyChanged("SOPE_PrecioUniMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SOPE_ImporteIngreso.
		/// </summary>
		[DataMember]
		public Boolean SOPE_ImporteIngresoOK
		{
			get { return m_sope_importeingresoOK; }
			set
			{
				if (m_sope_importeingresoOK != value)
				{
					m_sope_importeingresoOK = value;
					OnPropertyChanged("SOPE_ImporteIngresoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SOPE_ImporteIngreso.
		/// </summary>
		[DataMember]
		public String SOPE_ImporteIngresoMSGERROR
		{
			get { return m_sope_importeingresoMSGERROR; }
			set
			{
				if (m_sope_importeingresoMSGERROR != value)
				{
					m_sope_importeingresoMSGERROR = value;
					OnPropertyChanged("SOPE_ImporteIngresoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SOPE_ImporteEgreso.
		/// </summary>
		[DataMember]
		public Boolean SOPE_ImporteEgresoOK
		{
			get { return m_sope_importeegresoOK; }
			set
			{
				if (m_sope_importeegresoOK != value)
				{
					m_sope_importeegresoOK = value;
					OnPropertyChanged("SOPE_ImporteEgresoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SOPE_ImporteEgreso.
		/// </summary>
		[DataMember]
		public String SOPE_ImporteEgresoMSGERROR
		{
			get { return m_sope_importeegresoMSGERROR; }
			set
			{
				if (m_sope_importeegresoMSGERROR != value)
				{
					m_sope_importeegresoMSGERROR = value;
					OnPropertyChanged("SOPE_ImporteEgresoMSGERROR");
				}
			}
		}
        [DataMember]
        public String CONS_CodTMCMSGERROR { set; get; }

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
				SOPE_ItemOK  = true;
				SOPE_ItemMSGERROR  = "";
			    ENTC_CodigoMSGERROR = "";
                if (ENTC_Codigo == null)
                {
                    _isCorrect = false;
                    ENTC_CodigoMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Proveedor", "Detalle Servicio");
                    m_mensajeError += "* Debe ingresar el campo Proveedor" + Environment.NewLine;
                }

                SERV_CodigoMSGERROR = "";
                if (SERV_Codigo == null)
                {
                    _isCorrect = false;
                    SERV_CodigoMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Servicio", "Detalle Servicio");
                    m_mensajeError += "* Debe seleccionar el campo Servicio" + Environment.NewLine;
                }
                SOPE_PrecioUniMSGERROR = "";
                if (SOPE_PrecioUni == 0)
                {
                    _isCorrect = false;
                    SOPE_PrecioUniMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Precio Unitario", "Detalle Servicio");
                    m_mensajeError += "* Debe ingresar el campo Precio Unitario" + Environment.NewLine;
                }
                SOPE_CantidadMSGERROR = "";
                if (SOPE_Cantidad == 0)
                {
                    _isCorrect = false;
                    SOPE_CantidadMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Cantidad", "Detalle Servicio");
                    m_mensajeError += "* Debe ingresar el campo Precio Cantidad" + Environment.NewLine;
                }
                CONS_CodBasMSGERROR = "";
                if (String.IsNullOrEmpty(CONS_CodBas))
                {
                    _isCorrect = false;
                    CONS_CodBasMSGERROR = String.Format("Debe seleccionar la {0} del {1}.", "Base", "Detalle Servicio");
                    m_mensajeError += "* Debe seleccionar el campo Base" + Environment.NewLine;
                }
                TIPO_CodMndMSGERROR = "";
                if (String.IsNullOrEmpty(TIPO_CodMnd))
                {
                    _isCorrect = false;
                    TIPO_CodMndMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Tipo Moneda", "Detalle Servicio");
                    m_mensajeError += "* Debe seleccionar el campo Tipo Moneda" + Environment.NewLine;
                }
                CONS_CodTMCMSGERROR = "";
                if (String.IsNullOrEmpty(CONS_CodTMC))
                {
                    _isCorrect = false;
                    CONS_CodTMCMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Tipo Gasto", "Detalle Servicio");
                    m_mensajeError += "* Debe seleccionar el campo Tipo Gasto" + Environment.NewLine;
                }
                //SOPE_IngresoGastoMSGERROR  = "";
                //if( String.IsNullOrEmpty(SOPE_IngresoGasto) )
                //{
                //    _isCorrect = false;
                //    SOPE_IngresoGastoOK  = false;
                //    SOPE_IngresoGastoMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "SOPE_IngresoGasto", "Detalle Servicio");
                //    m_mensajeError += "* Debe ingresar el campo SOPE_IngresoGasto" + Environment.NewLine;
                //}
                //SOPE_ImporteIngresoOK  = true;
                //SOPE_ImporteIngresoMSGERROR  = "";
                //if( SOPE_ImporteIngreso == 0)
                //{
                //    _isCorrect = false;
                //    SOPE_ImporteIngresoOK  = false;
                //    SOPE_ImporteIngresoMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "SOPE_ImporteIngreso", "Detalle Servicio");
                //    m_mensajeError += "* Debe ingresar el campo SOPE_ImporteIngreso" + Environment.NewLine;
                //}
                //SOPE_ImporteEgresoOK  = true;
                //SOPE_ImporteEgresoMSGERROR  = "";
                //if( SOPE_ImporteEgreso == 0)
                //{
                //    _isCorrect = false;
                //    SOPE_ImporteEgresoOK  = false;
                //    SOPE_ImporteEgresoMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "SOPE_ImporteEgreso", "Detalle Servicio");
                //    m_mensajeError += "* Debe ingresar el campo SOPE_ImporteEgreso" + Environment.NewLine;
                //}
				OnPropertyChanged("MensajeError");
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}

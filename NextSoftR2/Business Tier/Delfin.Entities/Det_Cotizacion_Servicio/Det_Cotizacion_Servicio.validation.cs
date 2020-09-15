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
	public partial class Det_Cotizacion_Servicio
	{
		#region [ Variables Validación ]
		private Boolean m_ccot_codigoOK;
		private String m_ccot_codigoMSGERROR;
		private Boolean m_scot_itemOK;
		private String m_scot_itemMSGERROR;
		private Boolean m_serv_codigoOK;
		private String m_serv_codigoMSGERROR;
		private Boolean m_scot_cantidadOK;
		private String m_scot_cantidadMSGERROR;
		private Boolean m_scot_preciouniOK;
		private String m_scot_preciouniMSGERROR;
		private Boolean m_scot_ingresogastoOK;
		private String m_scot_ingresogastoMSGERROR;
		private Boolean m_scot_importeingresoOK;
		private String m_scot_importeingresoMSGERROR;
		private Boolean m_scot_importeegresoOK;
		private String m_scot_importeegresoMSGERROR;
		private Boolean m_cons_codbasOK;
		private String m_cons_codbasMSGERROR;
		private Boolean m_cons_tabbasOK;
		private String m_cons_tabbasMSGERROR;
		private Boolean m_tipo_tabmndOK;
		private String m_tipo_tabmndMSGERROR;
		private Boolean m_tipo_codmndOK;
		private String m_tipo_codmndMSGERROR;
		private Boolean m_entc_codigoOK;
		private String m_entc_codigoMSGERROR;
		private Boolean m_tipe_codigoOK;
		private String m_tipe_codigoMSGERROR;
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
		/// Gets or sets el valor de validación de: CCOT_Codigo.
		/// </summary>
		[DataMember]
		public Boolean CCOT_CodigoOK
		{
			get { return m_ccot_codigoOK; }
			set
			{
				if (m_ccot_codigoOK != value)
				{
					m_ccot_codigoOK = value;
					OnPropertyChanged("CCOT_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCOT_Codigo.
		/// </summary>
		[DataMember]
		public String CCOT_CodigoMSGERROR
		{
			get { return m_ccot_codigoMSGERROR; }
			set
			{
				if (m_ccot_codigoMSGERROR != value)
				{
					m_ccot_codigoMSGERROR = value;
					OnPropertyChanged("CCOT_CodigoMSGERROR");
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
					OnPropertyChanged("SCOT_ItemOK");
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
					OnPropertyChanged("SCOT_ItemMSGERROR");
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
					OnPropertyChanged("SCOT_CantidadOK");
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
					OnPropertyChanged("SCOT_CantidadMSGERROR");
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
					OnPropertyChanged("SCOT_PrecioUniOK");
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
					OnPropertyChanged("SCOT_PrecioUniMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SCOT_IngresoGasto.
		/// </summary>
		[DataMember]
		public Boolean SCOT_IngresoGastoOK
		{
			get { return m_scot_ingresogastoOK; }
			set
			{
				if (m_scot_ingresogastoOK != value)
				{
					m_scot_ingresogastoOK = value;
					OnPropertyChanged("SCOT_IngresoGastoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SCOT_IngresoGasto.
		/// </summary>
		[DataMember]
		public String SCOT_IngresoGastoMSGERROR
		{
			get { return m_scot_ingresogastoMSGERROR; }
			set
			{
				if (m_scot_ingresogastoMSGERROR != value)
				{
					m_scot_ingresogastoMSGERROR = value;
					OnPropertyChanged("SCOT_IngresoGastoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SCOT_ImporteIngreso.
		/// </summary>
		[DataMember]
		public Boolean SCOT_ImporteIngresoOK
		{
			get { return m_scot_importeingresoOK; }
			set
			{
				if (m_scot_importeingresoOK != value)
				{
					m_scot_importeingresoOK = value;
					OnPropertyChanged("SCOT_ImporteIngresoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SCOT_ImporteIngreso.
		/// </summary>
		[DataMember]
		public String SCOT_ImporteIngresoMSGERROR
		{
			get { return m_scot_importeingresoMSGERROR; }
			set
			{
				if (m_scot_importeingresoMSGERROR != value)
				{
					m_scot_importeingresoMSGERROR = value;
					OnPropertyChanged("SCOT_ImporteIngresoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SCOT_ImporteEgreso.
		/// </summary>
		[DataMember]
		public Boolean SCOT_ImporteEgresoOK
		{
			get { return m_scot_importeegresoOK; }
			set
			{
				if (m_scot_importeegresoOK != value)
				{
					m_scot_importeegresoOK = value;
					OnPropertyChanged("SCOT_ImporteEgresoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SCOT_ImporteEgreso.
		/// </summary>
		[DataMember]
		public String SCOT_ImporteEgresoMSGERROR
		{
			get { return m_scot_importeegresoMSGERROR; }
			set
			{
				if (m_scot_importeegresoMSGERROR != value)
				{
					m_scot_importeegresoMSGERROR = value;
					OnPropertyChanged("SCOT_ImporteEgresoMSGERROR");
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
				CCOT_CodigoOK  = true;
				CCOT_CodigoMSGERROR  = "";
                //if( CCOT_Codigo == null)
                //{
                //    _isCorrect = false;
                //    CCOT_CodigoOK  = false;
                //    CCOT_CodigoMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "CCOT_Codigo", "Det_Cotizacion_Servicio");
                //    m_mensajeError += "* Debe ingresar el campo CCOT_Codigo" + Environment.NewLine;
                //}
				SCOT_ItemOK  = true;
				SCOT_ItemMSGERROR  = "";
                //if( SCOT_Item == null)
                //{
                //    _isCorrect = false;
                //    SCOT_ItemOK  = false;
                //    SCOT_ItemMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "SCOT_Item", "Det_Cotizacion_Servicio");
                //    m_mensajeError += "* Debe ingresar el campo SCOT_Item" + Environment.NewLine;
                //}
				SCOT_CantidadOK  = true;
				SCOT_CantidadMSGERROR  = "";
				if( SCOT_Cantidad == 0)
				{
					_isCorrect = false;
					SCOT_CantidadMSGERROR  = String.Format("Debe ingresar la {0} del {1}.", "Cantidad", "Servicio");
					m_mensajeError += "* Debe ingresar el campo Cantidad" + Environment.NewLine;
				}
				SCOT_PrecioUniOK  = true;
				SCOT_PrecioUniMSGERROR  = "";
				if( SCOT_PrecioUni == 0)
				{
					_isCorrect = false;
					SCOT_PrecioUniOK  = false;
					SCOT_PrecioUniMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "Precio Unitario", "Servicio");
					m_mensajeError += "* Debe ingresar el campo Precio Unitario" + Environment.NewLine;
				}
                TIPO_CodMndMSGERROR = "";
                if (String.IsNullOrEmpty(TIPO_CodMnd))
                {
                    _isCorrect = false;
                    TIPO_CodMndMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Tipo Moneda", "Servicio");
                    m_mensajeError += "* Debe seleccionar el campo Tipo Moneda" + Environment.NewLine;

                }
                CONS_CodBasMSGERROR = "";
                if (String.IsNullOrEmpty(CONS_CodBas))
                {
                    _isCorrect = false;
                    CONS_CodBasMSGERROR = String.Format("Debe seleccionar la {0} del {1}.", "Base", "Servicio");
                    m_mensajeError += "* Debe seleccionar el campo Base" + Environment.NewLine;

                }
                CONS_CodTMCMSGERROR = "";
                SCOT_ImporteIngresoMSGERROR = "";
                SCOT_ImporteEgresoMSGERROR = "";
                if (String.IsNullOrEmpty(CONS_CodTMC))
				{
					_isCorrect = false;
                    SCOT_IngresoGastoMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Tipo Gasto", "Servicio");
                    m_mensajeError += "* Debe seleccionar el campo Tipo Gasto" + Environment.NewLine;

                }
                else
                {
                    if (CONS_CodTMC.Equals("001")) // ingreso
                    {
                        if (SCOT_ImporteIngreso == 0)
                        {
                            _isCorrect = false;
                            SCOT_ImporteIngresoMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Ingreso", "Servicio");
                            m_mensajeError += "* Debe ingresar el campo Ingreso" + Environment.NewLine;
                        }
                    }
                    else //egreso
                    {
                        if (SCOT_ImporteEgreso == 0)
                        {
                            _isCorrect = false;
                            SCOT_ImporteEgresoMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Egreso", "Servicio");
                            m_mensajeError += "* Debe ingresar el campo Egreso" + Environment.NewLine;
                        }
                    }
                }
				OnPropertyChanged("MensajeError");
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}

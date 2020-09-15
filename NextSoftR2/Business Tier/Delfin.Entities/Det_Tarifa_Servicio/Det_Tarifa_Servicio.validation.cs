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
	public partial class Det_Tarifa_Servicio
	{
		#region [ Variables Validación ]
		private Boolean m_ctar_codigoOK;
		private String m_ctar_codigoMSGERROR;
		private Boolean m_ctar_tipoOK;
		private String m_ctar_tipoMSGERROR;
		private Boolean m_dtas_itemOK;
		private String m_dtas_itemMSGERROR;
		private Boolean m_serv_codigoOK;
		private String m_serv_codigoMSGERROR;
		private Boolean m_tipo_tabmndOK;
		private String m_tipo_tabmndMSGERROR;
		private Boolean m_tipo_codmndOK;
		private String m_tipo_codmndMSGERROR;
		private Boolean m_dtas_costoOK;
		private String m_dtas_costoMSGERROR;
		private Boolean m_dtas_ventaOK;
		private String m_dtas_ventaMSGERROR;
		private Boolean m_dtas_profitOK;
		private String m_dtas_profitMSGERROR;
		private Boolean m_audi_usrcreaOK;
		private String m_audi_usrcreaMSGERROR;
		private Boolean m_audi_feccreaOK;
		private String m_audi_feccreaMSGERROR;
		private Boolean m_audi_usrmodOK;
		private String m_audi_usrmodMSGERROR;
		private Boolean m_audi_fecmodOK;
		private String m_audi_fecmodMSGERROR;
		private Boolean m_dtas_igvOK;
		private String m_dtas_igvMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: CTAR_Codigo.
		/// </summary>
		[DataMember]
		public Boolean CTAR_CodigoOK
		{
			get { return m_ctar_codigoOK; }
			set
			{
				if (m_ctar_codigoOK != value)
				{
					m_ctar_codigoOK = value;
					OnPropertyChanged("CTAR_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CTAR_Codigo.
		/// </summary>
		[DataMember]
		public String CTAR_CodigoMSGERROR
		{
			get { return m_ctar_codigoMSGERROR; }
			set
			{
				if (m_ctar_codigoMSGERROR != value)
				{
					m_ctar_codigoMSGERROR = value;
					OnPropertyChanged("CTAR_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CTAR_Tipo.
		/// </summary>
		[DataMember]
		public Boolean CTAR_TipoOK
		{
			get { return m_ctar_tipoOK; }
			set
			{
				if (m_ctar_tipoOK != value)
				{
					m_ctar_tipoOK = value;
					OnPropertyChanged("CTAR_TipoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CTAR_Tipo.
		/// </summary>
		[DataMember]
		public String CTAR_TipoMSGERROR
		{
			get { return m_ctar_tipoMSGERROR; }
			set
			{
				if (m_ctar_tipoMSGERROR != value)
				{
					m_ctar_tipoMSGERROR = value;
					OnPropertyChanged("CTAR_TipoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DTAS_Item.
		/// </summary>
		[DataMember]
		public Boolean DTAS_ItemOK
		{
			get { return m_dtas_itemOK; }
			set
			{
				if (m_dtas_itemOK != value)
				{
					m_dtas_itemOK = value;
					OnPropertyChanged("DTAS_ItemOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DTAS_Item.
		/// </summary>
		[DataMember]
		public String DTAS_ItemMSGERROR
		{
			get { return m_dtas_itemMSGERROR; }
			set
			{
				if (m_dtas_itemMSGERROR != value)
				{
					m_dtas_itemMSGERROR = value;
					OnPropertyChanged("DTAS_ItemMSGERROR");
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
		/// Gets or sets el valor de validación de: DTAS_Costo.
		/// </summary>
		[DataMember]
		public Boolean DTAS_CostoOK
		{
			get { return m_dtas_costoOK; }
			set
			{
				if (m_dtas_costoOK != value)
				{
					m_dtas_costoOK = value;
					OnPropertyChanged("DTAS_CostoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DTAS_Costo.
		/// </summary>
		[DataMember]
		public String DTAS_CostoMSGERROR
		{
			get { return m_dtas_costoMSGERROR; }
			set
			{
				if (m_dtas_costoMSGERROR != value)
				{
					m_dtas_costoMSGERROR = value;
					OnPropertyChanged("DTAS_CostoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DTAS_Venta.
		/// </summary>
		[DataMember]
		public Boolean DTAS_VentaOK
		{
			get { return m_dtas_ventaOK; }
			set
			{
				if (m_dtas_ventaOK != value)
				{
					m_dtas_ventaOK = value;
					OnPropertyChanged("DTAS_VentaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DTAS_Venta.
		/// </summary>
		[DataMember]
		public String DTAS_VentaMSGERROR
		{
			get { return m_dtas_ventaMSGERROR; }
			set
			{
				if (m_dtas_ventaMSGERROR != value)
				{
					m_dtas_ventaMSGERROR = value;
					OnPropertyChanged("DTAS_VentaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DTAS_Profit.
		/// </summary>
		[DataMember]
		public Boolean DTAS_ProfitOK
		{
			get { return m_dtas_profitOK; }
			set
			{
				if (m_dtas_profitOK != value)
				{
					m_dtas_profitOK = value;
					OnPropertyChanged("DTAS_ProfitOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DTAS_Profit.
		/// </summary>
		[DataMember]
		public String DTAS_ProfitMSGERROR
		{
			get { return m_dtas_profitMSGERROR; }
			set
			{
				if (m_dtas_profitMSGERROR != value)
				{
					m_dtas_profitMSGERROR = value;
					OnPropertyChanged("DTAS_ProfitMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DTAS_IGV.
		/// </summary>
		[DataMember]
		public Boolean DTAS_IGVOK
		{
			get { return m_dtas_igvOK; }
			set
			{
				if (m_dtas_igvOK != value)
				{
					m_dtas_igvOK = value;
					OnPropertyChanged("DTAS_IGVOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DTAS_IGV.
		/// </summary>
		[DataMember]
		public String DTAS_IGVMSGERROR
		{
			get { return m_dtas_igvMSGERROR; }
			set
			{
				if (m_dtas_igvMSGERROR != value)
				{
					m_dtas_igvMSGERROR = value;
					OnPropertyChanged("DTAS_IGVMSGERROR");
				}
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
				CTAR_CodigoOK  = true;
				CTAR_CodigoMSGERROR  = "";
                //if( CTAR_Codigo == null)
                //{
                //    _isCorrect = false;
                //    CTAR_CodigoOK  = false;
                //    CTAR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CTAR_Codigo", "Det_Tarifa_Servicio");
                //    m_mensajeError += "* Debe ingresar el campo CTAR_Codigo" + Environment.NewLine;
                //}
				CTAR_TipoOK  = true;
				CTAR_TipoMSGERROR  = "";
                TIPO_CodMndMSGERROR = "";
                DTAS_CostoMSGERROR = "";
				if( String.IsNullOrEmpty(CTAR_Tipo) )
				{
					_isCorrect = false;
					CTAR_TipoOK  = false;
					CTAR_TipoMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "Tipo", "Detalle Tarifa Servicio");
                    m_mensajeError += "* Debe ingresar el campo Tipo" + Environment.NewLine;
                }
                else
                {
                    if (CTAR_Tipo.Equals("A")) // Aduanero
                    {
                        if (TIPO_CodMnd == null)
                        {
                            _isCorrect = false;
                            TIPO_CodMndMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Tipo Moneda", "Detalle Tarifa Servicio");
                            m_mensajeError += "* Debe seleccionar el campo Tipo Moneda" + Environment.NewLine;
                        }

                        if (DTAS_Costo== 0)
                        {
                            _isCorrect = false;
                            DTAS_CostoMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Valor", "Detalle Tarifa Servicio");
                            m_mensajeError += "* Debe ingresar el campo Valor" + Environment.NewLine;  
                        }
                    }
                }
				
				SERV_CodigoMSGERROR = "";
                if (SERV_Codigo == null)
				{
					_isCorrect = false;
                    SERV_CodigoMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Servicio", "Detalle Tarifa Servicio");
                    m_mensajeError += "* Debe seleccionar  el campo Servicio" + Environment.NewLine;
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

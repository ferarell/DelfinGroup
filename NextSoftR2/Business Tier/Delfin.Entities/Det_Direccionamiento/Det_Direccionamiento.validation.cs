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
	public partial class Det_Direccionamiento
	{
		#region [ Variables Validación ]
		private Boolean m_ddir_itemOK;
		private String m_ddir_itemMSGERROR;
		private Boolean m_ddir_cantidadOK;
		private String m_ddir_cantidadMSGERROR;
		private Boolean m_ddir_tarjaOK;
		private String m_ddir_tarjaMSGERROR;
		private Boolean m_ddir_rebateOK;
		private String m_ddir_rebateMSGERROR;
		private Boolean m_ddir_contenedorOK;
		private String m_ddir_contenedorMSGERROR;
		private Boolean m_ddir_estadoOK;
		private String m_ddir_estadoMSGERROR;
		private Boolean m_cdir_codigoOK;
		private String m_cdir_codigoMSGERROR;
		private Boolean m_pack_codigoOK;
		private String m_pack_codigoMSGERROR;
		private Boolean m_ddir_montotarjaOK;
		private String m_ddir_montotarjaMSGERROR;
		private Boolean m_ddir_montorebateOK;
		private String m_ddir_montorebateMSGERROR;
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
		/// Gets or sets el valor de validación de: DDIR_Item.
		/// </summary>
		[DataMember]
		public Boolean DDIR_ItemOK
		{
			get { return m_ddir_itemOK; }
			set
			{
				if (m_ddir_itemOK != value)
				{
					m_ddir_itemOK = value;
					OnPropertyChanged("DDIR_ItemOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DDIR_Item.
		/// </summary>
		[DataMember]
		public String DDIR_ItemMSGERROR
		{
			get { return m_ddir_itemMSGERROR; }
			set
			{
				if (m_ddir_itemMSGERROR != value)
				{
					m_ddir_itemMSGERROR = value;
					OnPropertyChanged("DDIR_ItemMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DDIR_Cantidad.
		/// </summary>
		[DataMember]
		public Boolean DDIR_CantidadOK
		{
			get { return m_ddir_cantidadOK; }
			set
			{
				if (m_ddir_cantidadOK != value)
				{
					m_ddir_cantidadOK = value;
					OnPropertyChanged("DDIR_CantidadOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DDIR_Cantidad.
		/// </summary>
		[DataMember]
		public String DDIR_CantidadMSGERROR
		{
			get { return m_ddir_cantidadMSGERROR; }
			set
			{
				if (m_ddir_cantidadMSGERROR != value)
				{
					m_ddir_cantidadMSGERROR = value;
					OnPropertyChanged("DDIR_CantidadMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DDIR_Tarja.
		/// </summary>
		[DataMember]
		public Boolean DDIR_TarjaOK
		{
			get { return m_ddir_tarjaOK; }
			set
			{
				if (m_ddir_tarjaOK != value)
				{
					m_ddir_tarjaOK = value;
					OnPropertyChanged("DDIR_TarjaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DDIR_Tarja.
		/// </summary>
		[DataMember]
		public String DDIR_TarjaMSGERROR
		{
			get { return m_ddir_tarjaMSGERROR; }
			set
			{
				if (m_ddir_tarjaMSGERROR != value)
				{
					m_ddir_tarjaMSGERROR = value;
					OnPropertyChanged("DDIR_TarjaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DDIR_Rebate.
		/// </summary>
		[DataMember]
		public Boolean DDIR_RebateOK
		{
			get { return m_ddir_rebateOK; }
			set
			{
				if (m_ddir_rebateOK != value)
				{
					m_ddir_rebateOK = value;
					OnPropertyChanged("DDIR_RebateOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DDIR_Rebate.
		/// </summary>
		[DataMember]
		public String DDIR_RebateMSGERROR
		{
			get { return m_ddir_rebateMSGERROR; }
			set
			{
				if (m_ddir_rebateMSGERROR != value)
				{
					m_ddir_rebateMSGERROR = value;
					OnPropertyChanged("DDIR_RebateMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DDIR_Contenedor.
		/// </summary>
		[DataMember]
		public Boolean DDIR_ContenedorOK
		{
			get { return m_ddir_contenedorOK; }
			set
			{
				if (m_ddir_contenedorOK != value)
				{
					m_ddir_contenedorOK = value;
					OnPropertyChanged("DDIR_ContenedorOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DDIR_Contenedor.
		/// </summary>
		[DataMember]
		public String DDIR_ContenedorMSGERROR
		{
			get { return m_ddir_contenedorMSGERROR; }
			set
			{
				if (m_ddir_contenedorMSGERROR != value)
				{
					m_ddir_contenedorMSGERROR = value;
					OnPropertyChanged("DDIR_ContenedorMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DDIR_Estado.
		/// </summary>
		[DataMember]
		public Boolean DDIR_EstadoOK
		{
			get { return m_ddir_estadoOK; }
			set
			{
				if (m_ddir_estadoOK != value)
				{
					m_ddir_estadoOK = value;
					OnPropertyChanged("DDIR_EstadoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DDIR_Estado.
		/// </summary>
		[DataMember]
		public String DDIR_EstadoMSGERROR
		{
			get { return m_ddir_estadoMSGERROR; }
			set
			{
				if (m_ddir_estadoMSGERROR != value)
				{
					m_ddir_estadoMSGERROR = value;
					OnPropertyChanged("DDIR_EstadoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CDIR_Codigo.
		/// </summary>
		[DataMember]
		public Boolean CDIR_CodigoOK
		{
			get { return m_cdir_codigoOK; }
			set
			{
				if (m_cdir_codigoOK != value)
				{
					m_cdir_codigoOK = value;
					OnPropertyChanged("CDIR_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CDIR_Codigo.
		/// </summary>
		[DataMember]
		public String CDIR_CodigoMSGERROR
		{
			get { return m_cdir_codigoMSGERROR; }
			set
			{
				if (m_cdir_codigoMSGERROR != value)
				{
					m_cdir_codigoMSGERROR = value;
					OnPropertyChanged("CDIR_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PACK_Codigo.
		/// </summary>
		[DataMember]
		public Boolean PACK_CodigoOK
		{
			get { return m_pack_codigoOK; }
			set
			{
				if (m_pack_codigoOK != value)
				{
					m_pack_codigoOK = value;
					OnPropertyChanged("PACK_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PACK_Codigo.
		/// </summary>
		[DataMember]
		public String PACK_CodigoMSGERROR
		{
			get { return m_pack_codigoMSGERROR; }
			set
			{
				if (m_pack_codigoMSGERROR != value)
				{
					m_pack_codigoMSGERROR = value;
					OnPropertyChanged("PACK_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DDIR_MontoTarja.
		/// </summary>
		[DataMember]
		public Boolean DDIR_MontoTarjaOK
		{
			get { return m_ddir_montotarjaOK; }
			set
			{
				if (m_ddir_montotarjaOK != value)
				{
					m_ddir_montotarjaOK = value;
					OnPropertyChanged("DDIR_MontoTarjaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DDIR_MontoTarja.
		/// </summary>
		[DataMember]
		public String DDIR_MontoTarjaMSGERROR
		{
			get { return m_ddir_montotarjaMSGERROR; }
			set
			{
				if (m_ddir_montotarjaMSGERROR != value)
				{
					m_ddir_montotarjaMSGERROR = value;
					OnPropertyChanged("DDIR_MontoTarjaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DDIR_MontoRebate.
		/// </summary>
		[DataMember]
		public Boolean DDIR_MontoRebateOK
		{
			get { return m_ddir_montorebateOK; }
			set
			{
				if (m_ddir_montorebateOK != value)
				{
					m_ddir_montorebateOK = value;
					OnPropertyChanged("DDIR_MontoRebateOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DDIR_MontoRebate.
		/// </summary>
		[DataMember]
		public String DDIR_MontoRebateMSGERROR
		{
			get { return m_ddir_montorebateMSGERROR; }
			set
			{
				if (m_ddir_montorebateMSGERROR != value)
				{
					m_ddir_montorebateMSGERROR = value;
					OnPropertyChanged("DDIR_MontoRebateMSGERROR");
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
				DDIR_ItemOK  = true;
				DDIR_ItemMSGERROR  = "";
				if( DDIR_Item == null)
				{
					_isCorrect = false;
					DDIR_ItemOK  = false;
					DDIR_ItemMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DDIR_Item", "Det_Direccionamiento");
					m_mensajeError += "* Debe ingresar el campo DDIR_Item" + Environment.NewLine;
				}
				DDIR_CantidadOK  = true;
				DDIR_CantidadMSGERROR  = "";
				if( DDIR_Cantidad == null)
				{
					_isCorrect = false;
					DDIR_CantidadOK  = false;
					DDIR_CantidadMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DDIR_Cantidad", "Det_Direccionamiento");
					m_mensajeError += "* Debe ingresar el campo DDIR_Cantidad" + Environment.NewLine;
				}
				DDIR_ContenedorOK  = true;
				DDIR_ContenedorMSGERROR  = "";
				if( String.IsNullOrEmpty(DDIR_Contenedor) )
				{
					_isCorrect = false;
					DDIR_ContenedorOK  = false;
					DDIR_ContenedorMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DDIR_Contenedor", "Det_Direccionamiento");
					m_mensajeError += "* Debe ingresar el campo DDIR_Contenedor" + Environment.NewLine;
				}
				DDIR_EstadoOK  = true;
				DDIR_EstadoMSGERROR  = "";
				if( String.IsNullOrEmpty(DDIR_Estado) )
				{
					_isCorrect = false;
					DDIR_EstadoOK  = false;
					DDIR_EstadoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DDIR_Estado", "Det_Direccionamiento");
					m_mensajeError += "* Debe ingresar el campo DDIR_Estado" + Environment.NewLine;
				}
				CDIR_CodigoOK  = true;
				CDIR_CodigoMSGERROR  = "";
				if( CDIR_Codigo == null)
				{
					_isCorrect = false;
					CDIR_CodigoOK  = false;
					CDIR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CDIR_Codigo", "Det_Direccionamiento");
					m_mensajeError += "* Debe ingresar el campo CDIR_Codigo" + Environment.NewLine;
				}
				DDIR_MontoTarjaOK  = true;
				DDIR_MontoTarjaMSGERROR  = "";
				if( DDIR_MontoTarja == null)
				{
					_isCorrect = false;
					DDIR_MontoTarjaOK  = false;
					DDIR_MontoTarjaMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DDIR_MontoTarja", "Det_Direccionamiento");
					m_mensajeError += "* Debe ingresar el campo DDIR_MontoTarja" + Environment.NewLine;
				}
				DDIR_MontoRebateOK  = true;
				DDIR_MontoRebateMSGERROR  = "";
				if( DDIR_MontoRebate == null)
				{
					_isCorrect = false;
					DDIR_MontoRebateOK  = false;
					DDIR_MontoRebateMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DDIR_MontoRebate", "Det_Direccionamiento");
					m_mensajeError += "* Debe ingresar el campo DDIR_MontoRebate" + Environment.NewLine;
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

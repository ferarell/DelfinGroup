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
	public partial class DetCtaCte
	{
		#region [ Variables Validación ]
		private Boolean m_dcct_itemOK;
		private String m_dcct_itemMSGERROR;
		private Boolean m_dcct_fechatransOK;
		private String m_dcct_fechatransMSGERROR;
		private Boolean m_dcct_tipocambioOK;
		private String m_dcct_tipocambioMSGERROR;
		private Boolean m_dcct_montodebeOK;
		private String m_dcct_montodebeMSGERROR;
		private Boolean m_dcct_montohaberOK;
		private String m_dcct_montohaberMSGERROR;
		private Boolean m_dcct_montodebedOK;
		private String m_dcct_montodebedMSGERROR;
		private Boolean m_dcct_montohaberdOK;
		private String m_dcct_montohaberdMSGERROR;
		private Boolean m_ccct_codigoOK;
		private String m_ccct_codigoMSGERROR;
		private Boolean m_tipo_tabmndOK;
		private String m_tipo_tabmndMSGERROR;
		private Boolean m_tipo_codmndOK;
		private String m_tipo_codmndMSGERROR;
		private Boolean m_tipo_tabbcoOK;
		private String m_tipo_tabbcoMSGERROR;
		private Boolean m_tipo_codbcoOK;
		private String m_tipo_codbcoMSGERROR;
		private Boolean m_dcct_tipopagoOK;
		private String m_dcct_tipopagoMSGERROR;
		private Boolean m_dcct_nrochequeOK;
		private String m_dcct_nrochequeMSGERROR;
		private Boolean m_dcct_nrocuentaOK;
		private String m_dcct_nrocuentaMSGERROR;
		private Boolean m_caja_codigoOK;
		private String m_caja_codigoMSGERROR;
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
		/// Gets or sets el valor de validación de: DCCT_Item.
		/// </summary>
		[DataMember]
		public Boolean DCCT_ItemOK
		{
			get { return m_dcct_itemOK; }
			set
			{
				if (m_dcct_itemOK != value)
				{
					m_dcct_itemOK = value;
					OnPropertyChanged("DCCT_ItemOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCCT_Item.
		/// </summary>
		[DataMember]
		public String DCCT_ItemMSGERROR
		{
			get { return m_dcct_itemMSGERROR; }
			set
			{
				if (m_dcct_itemMSGERROR != value)
				{
					m_dcct_itemMSGERROR = value;
					OnPropertyChanged("DCCT_ItemMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCCT_FechaTrans.
		/// </summary>
		[DataMember]
		public Boolean DCCT_FechaTransOK
		{
			get { return m_dcct_fechatransOK; }
			set
			{
				if (m_dcct_fechatransOK != value)
				{
					m_dcct_fechatransOK = value;
					OnPropertyChanged("DCCT_FechaTransOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCCT_FechaTrans.
		/// </summary>
		[DataMember]
		public String DCCT_FechaTransMSGERROR
		{
			get { return m_dcct_fechatransMSGERROR; }
			set
			{
				if (m_dcct_fechatransMSGERROR != value)
				{
					m_dcct_fechatransMSGERROR = value;
					OnPropertyChanged("DCCT_FechaTransMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCCT_TipoCambio.
		/// </summary>
		[DataMember]
		public Boolean DCCT_TipoCambioOK
		{
			get { return m_dcct_tipocambioOK; }
			set
			{
				if (m_dcct_tipocambioOK != value)
				{
					m_dcct_tipocambioOK = value;
					OnPropertyChanged("DCCT_TipoCambioOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCCT_TipoCambio.
		/// </summary>
		[DataMember]
		public String DCCT_TipoCambioMSGERROR
		{
			get { return m_dcct_tipocambioMSGERROR; }
			set
			{
				if (m_dcct_tipocambioMSGERROR != value)
				{
					m_dcct_tipocambioMSGERROR = value;
					OnPropertyChanged("DCCT_TipoCambioMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCCT_MontoDebe.
		/// </summary>
		[DataMember]
		public Boolean DCCT_MontoDebeOK
		{
			get { return m_dcct_montodebeOK; }
			set
			{
				if (m_dcct_montodebeOK != value)
				{
					m_dcct_montodebeOK = value;
					OnPropertyChanged("DCCT_MontoDebeOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCCT_MontoDebe.
		/// </summary>
		[DataMember]
		public String DCCT_MontoDebeMSGERROR
		{
			get { return m_dcct_montodebeMSGERROR; }
			set
			{
				if (m_dcct_montodebeMSGERROR != value)
				{
					m_dcct_montodebeMSGERROR = value;
					OnPropertyChanged("DCCT_MontoDebeMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCCT_MontoHaber.
		/// </summary>
		[DataMember]
		public Boolean DCCT_MontoHaberOK
		{
			get { return m_dcct_montohaberOK; }
			set
			{
				if (m_dcct_montohaberOK != value)
				{
					m_dcct_montohaberOK = value;
					OnPropertyChanged("DCCT_MontoHaberOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCCT_MontoHaber.
		/// </summary>
		[DataMember]
		public String DCCT_MontoHaberMSGERROR
		{
			get { return m_dcct_montohaberMSGERROR; }
			set
			{
				if (m_dcct_montohaberMSGERROR != value)
				{
					m_dcct_montohaberMSGERROR = value;
					OnPropertyChanged("DCCT_MontoHaberMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCCT_MontoDebeD.
		/// </summary>
		[DataMember]
		public Boolean DCCT_MontoDebeDOK
		{
			get { return m_dcct_montodebedOK; }
			set
			{
				if (m_dcct_montodebedOK != value)
				{
					m_dcct_montodebedOK = value;
					OnPropertyChanged("DCCT_MontoDebeDOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCCT_MontoDebeD.
		/// </summary>
		[DataMember]
		public String DCCT_MontoDebeDMSGERROR
		{
			get { return m_dcct_montodebedMSGERROR; }
			set
			{
				if (m_dcct_montodebedMSGERROR != value)
				{
					m_dcct_montodebedMSGERROR = value;
					OnPropertyChanged("DCCT_MontoDebeDMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCCT_MontoHaberD.
		/// </summary>
		[DataMember]
		public Boolean DCCT_MontoHaberDOK
		{
			get { return m_dcct_montohaberdOK; }
			set
			{
				if (m_dcct_montohaberdOK != value)
				{
					m_dcct_montohaberdOK = value;
					OnPropertyChanged("DCCT_MontoHaberDOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCCT_MontoHaberD.
		/// </summary>
		[DataMember]
		public String DCCT_MontoHaberDMSGERROR
		{
			get { return m_dcct_montohaberdMSGERROR; }
			set
			{
				if (m_dcct_montohaberdMSGERROR != value)
				{
					m_dcct_montohaberdMSGERROR = value;
					OnPropertyChanged("DCCT_MontoHaberDMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CCCT_Codigo.
		/// </summary>
		[DataMember]
		public Boolean CCCT_CodigoOK
		{
			get { return m_ccct_codigoOK; }
			set
			{
				if (m_ccct_codigoOK != value)
				{
					m_ccct_codigoOK = value;
					OnPropertyChanged("CCCT_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCCT_Codigo.
		/// </summary>
		[DataMember]
		public String CCCT_CodigoMSGERROR
		{
			get { return m_ccct_codigoMSGERROR; }
			set
			{
				if (m_ccct_codigoMSGERROR != value)
				{
					m_ccct_codigoMSGERROR = value;
					OnPropertyChanged("CCCT_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabMND.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabMNDOK
		{
			get { return m_tipo_tabmndOK; }
			set
			{
				if (m_tipo_tabmndOK != value)
				{
					m_tipo_tabmndOK = value;
					OnPropertyChanged("TIPO_TabMNDOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabMND.
		/// </summary>
		[DataMember]
		public String TIPO_TabMNDMSGERROR
		{
			get { return m_tipo_tabmndMSGERROR; }
			set
			{
				if (m_tipo_tabmndMSGERROR != value)
				{
					m_tipo_tabmndMSGERROR = value;
					OnPropertyChanged("TIPO_TabMNDMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodMND.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodMNDOK
		{
			get { return m_tipo_codmndOK; }
			set
			{
				if (m_tipo_codmndOK != value)
				{
					m_tipo_codmndOK = value;
					OnPropertyChanged("TIPO_CodMNDOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodMND.
		/// </summary>
		[DataMember]
		public String TIPO_CodMNDMSGERROR
		{
			get { return m_tipo_codmndMSGERROR; }
			set
			{
				if (m_tipo_codmndMSGERROR != value)
				{
					m_tipo_codmndMSGERROR = value;
					OnPropertyChanged("TIPO_CodMNDMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabBCO.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabBCOOK
		{
			get { return m_tipo_tabbcoOK; }
			set
			{
				if (m_tipo_tabbcoOK != value)
				{
					m_tipo_tabbcoOK = value;
					OnPropertyChanged("TIPO_TabBCOOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabBCO.
		/// </summary>
		[DataMember]
		public String TIPO_TabBCOMSGERROR
		{
			get { return m_tipo_tabbcoMSGERROR; }
			set
			{
				if (m_tipo_tabbcoMSGERROR != value)
				{
					m_tipo_tabbcoMSGERROR = value;
					OnPropertyChanged("TIPO_TabBCOMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodBCO.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodBCOOK
		{
			get { return m_tipo_codbcoOK; }
			set
			{
				if (m_tipo_codbcoOK != value)
				{
					m_tipo_codbcoOK = value;
					OnPropertyChanged("TIPO_CodBCOOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodBCO.
		/// </summary>
		[DataMember]
		public String TIPO_CodBCOMSGERROR
		{
			get { return m_tipo_codbcoMSGERROR; }
			set
			{
				if (m_tipo_codbcoMSGERROR != value)
				{
					m_tipo_codbcoMSGERROR = value;
					OnPropertyChanged("TIPO_CodBCOMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCCT_TipoPago.
		/// </summary>
		[DataMember]
		public Boolean DCCT_TipoPagoOK
		{
			get { return m_dcct_tipopagoOK; }
			set
			{
				if (m_dcct_tipopagoOK != value)
				{
					m_dcct_tipopagoOK = value;
					OnPropertyChanged("DCCT_TipoPagoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCCT_TipoPago.
		/// </summary>
		[DataMember]
		public String DCCT_TipoPagoMSGERROR
		{
			get { return m_dcct_tipopagoMSGERROR; }
			set
			{
				if (m_dcct_tipopagoMSGERROR != value)
				{
					m_dcct_tipopagoMSGERROR = value;
					OnPropertyChanged("DCCT_TipoPagoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCCT_NroCheque.
		/// </summary>
		[DataMember]
		public Boolean DCCT_NroChequeOK
		{
			get { return m_dcct_nrochequeOK; }
			set
			{
				if (m_dcct_nrochequeOK != value)
				{
					m_dcct_nrochequeOK = value;
					OnPropertyChanged("DCCT_NroChequeOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCCT_NroCheque.
		/// </summary>
		[DataMember]
		public String DCCT_NroChequeMSGERROR
		{
			get { return m_dcct_nrochequeMSGERROR; }
			set
			{
				if (m_dcct_nrochequeMSGERROR != value)
				{
					m_dcct_nrochequeMSGERROR = value;
					OnPropertyChanged("DCCT_NroChequeMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCCT_NroCuenta.
		/// </summary>
		[DataMember]
		public Boolean DCCT_NroCuentaOK
		{
			get { return m_dcct_nrocuentaOK; }
			set
			{
				if (m_dcct_nrocuentaOK != value)
				{
					m_dcct_nrocuentaOK = value;
					OnPropertyChanged("DCCT_NroCuentaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCCT_NroCuenta.
		/// </summary>
		[DataMember]
		public String DCCT_NroCuentaMSGERROR
		{
			get { return m_dcct_nrocuentaMSGERROR; }
			set
			{
				if (m_dcct_nrocuentaMSGERROR != value)
				{
					m_dcct_nrocuentaMSGERROR = value;
					OnPropertyChanged("DCCT_NroCuentaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CAJA_Codigo.
		/// </summary>
		[DataMember]
		public Boolean CAJA_CodigoOK
		{
			get { return m_caja_codigoOK; }
			set
			{
				if (m_caja_codigoOK != value)
				{
					m_caja_codigoOK = value;
					OnPropertyChanged("CAJA_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CAJA_Codigo.
		/// </summary>
		[DataMember]
		public String CAJA_CodigoMSGERROR
		{
			get { return m_caja_codigoMSGERROR; }
			set
			{
				if (m_caja_codigoMSGERROR != value)
				{
					m_caja_codigoMSGERROR = value;
					OnPropertyChanged("CAJA_CodigoMSGERROR");
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
				DCCT_ItemOK  = true;
				DCCT_ItemMSGERROR  = "";
				if( DCCT_Item == null)
				{
					_isCorrect = false;
					DCCT_ItemOK  = false;
					DCCT_ItemMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DCCT_Item", "DetCtaCte");
					m_mensajeError += "* Debe ingresar el campo DCCT_Item" + Environment.NewLine;
				}
				DCCT_FechaTransOK  = true;
				DCCT_FechaTransMSGERROR  = "";
				if( DCCT_FechaTrans == null)
				{
					_isCorrect = false;
					DCCT_FechaTransOK  = false;
					DCCT_FechaTransMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DCCT_FechaTrans", "DetCtaCte");
					m_mensajeError += "* Debe ingresar el campo DCCT_FechaTrans" + Environment.NewLine;
				}
				DCCT_TipoCambioOK  = true;
				DCCT_TipoCambioMSGERROR  = "";
				if( DCCT_TipoCambio == null)
				{
					_isCorrect = false;
					DCCT_TipoCambioOK  = false;
					DCCT_TipoCambioMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DCCT_TipoCambio", "DetCtaCte");
					m_mensajeError += "* Debe ingresar el campo DCCT_TipoCambio" + Environment.NewLine;
				}
				DCCT_MontoDebeOK  = true;
				DCCT_MontoDebeMSGERROR  = "";
				if( DCCT_MontoDebe == null)
				{
					_isCorrect = false;
					DCCT_MontoDebeOK  = false;
					DCCT_MontoDebeMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DCCT_MontoDebe", "DetCtaCte");
					m_mensajeError += "* Debe ingresar el campo DCCT_MontoDebe" + Environment.NewLine;
				}
				DCCT_MontoHaberOK  = true;
				DCCT_MontoHaberMSGERROR  = "";
				if( DCCT_MontoHaber == null)
				{
					_isCorrect = false;
					DCCT_MontoHaberOK  = false;
					DCCT_MontoHaberMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DCCT_MontoHaber", "DetCtaCte");
					m_mensajeError += "* Debe ingresar el campo DCCT_MontoHaber" + Environment.NewLine;
				}
				DCCT_MontoDebeDOK  = true;
				DCCT_MontoDebeDMSGERROR  = "";
            if (DCCT_MontoDebeD == null)
				{
					_isCorrect = false;
					DCCT_MontoDebeDOK  = false;
					DCCT_MontoDebeDMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DCCT_MontoDebeD", "DetCtaCte");
					m_mensajeError += "* Debe ingresar el campo DCCT_MontoDebeD" + Environment.NewLine;
				}
				DCCT_MontoHaberDOK  = true;
				DCCT_MontoHaberDMSGERROR  = "";
				if( DCCT_MontoHaberD == null)
				{
					_isCorrect = false;
					DCCT_MontoHaberDOK  = false;
					DCCT_MontoHaberDMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DCCT_MontoHaberD", "DetCtaCte");
					m_mensajeError += "* Debe ingresar el campo DCCT_MontoHaberD" + Environment.NewLine;
				}
				CCCT_CodigoOK  = true;
				CCCT_CodigoMSGERROR  = "";
				if( CCCT_Codigo == null)
				{
					_isCorrect = false;
					CCCT_CodigoOK  = false;
					CCCT_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCCT_Codigo", "DetCtaCte");
					m_mensajeError += "* Debe ingresar el campo CCCT_Codigo" + Environment.NewLine;
				}
				TIPO_TabMNDOK  = true;
				TIPO_TabMNDMSGERROR  = "";
				if( String.IsNullOrEmpty(TIPO_TabMND) )
				{
					_isCorrect = false;
					TIPO_TabMNDOK  = false;
					TIPO_TabMNDMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPO_TabMND", "DetCtaCte");
					m_mensajeError += "* Debe ingresar el campo TIPO_TabMND" + Environment.NewLine;
				}
				TIPO_CodMNDOK  = true;
				TIPO_CodMNDMSGERROR  = "";
				if( String.IsNullOrEmpty(TIPO_CodMND) )
				{
					_isCorrect = false;
					TIPO_CodMNDOK  = false;
					TIPO_CodMNDMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPO_CodMND", "DetCtaCte");
					m_mensajeError += "* Debe ingresar el campo TIPO_CodMND" + Environment.NewLine;
				}
				DCCT_TipoPagoOK  = true;
				DCCT_TipoPagoMSGERROR  = "";
				if( String.IsNullOrEmpty(DCCT_TipoPago) )
				{
					_isCorrect = false;
					DCCT_TipoPagoOK  = false;
					DCCT_TipoPagoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DCCT_TipoPago", "DetCtaCte");
					m_mensajeError += "* Debe ingresar el campo DCCT_TipoPago" + Environment.NewLine;
				}
            //DCCT_NroChequeOK  = true;
            //DCCT_NroChequeMSGERROR  = "";
            //if( String.IsNullOrEmpty(DCCT_NroCheque) )
            //{
            //   _isCorrect = false;
            //   DCCT_NroChequeOK  = false;
            //   DCCT_NroChequeMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DCCT_NroCheque", "DetCtaCte");
            //   m_mensajeError += "* Debe ingresar el campo DCCT_NroCheque" + Environment.NewLine;
            //}
            //DCCT_NroCuentaOK  = true;
            //DCCT_NroCuentaMSGERROR  = "";
            //if( String.IsNullOrEmpty(DCCT_NroCuenta) )
            //{
            //   _isCorrect = false;
            //   DCCT_NroCuentaOK  = false;
            //   DCCT_NroCuentaMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DCCT_NroCuenta", "DetCtaCte");
            //   m_mensajeError += "* Debe ingresar el campo DCCT_NroCuenta" + Environment.NewLine;
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

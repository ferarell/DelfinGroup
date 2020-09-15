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
	public partial class DetMovimiento
	{
		#region [ Variables Validación ]
		private Boolean m_empr_codigoOK;
		private String m_empr_codigoMSGERROR;
		private Boolean m_movi_codigoOK;
		private String m_movi_codigoMSGERROR;
		private Boolean m_dmov_itemOK;
		private String m_dmov_itemMSGERROR;
		private Boolean m_tipo_tabtgbOK;
		private String m_tipo_tabtgbMSGERROR;
		private Boolean m_tipo_codtgbOK;
		private String m_tipo_codtgbMSGERROR;
		private Boolean m_dmov_montodebeOK;
		private String m_dmov_montodebeMSGERROR;
		private Boolean m_dmov_montohaberOK;
		private String m_dmov_montohaberMSGERROR;
		private Boolean m_dmov_nrooperacionOK;
		private String m_dmov_nrooperacionMSGERROR;
		private Boolean m_dmov_flujoOK;
		private String m_dmov_flujoMSGERROR;
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
		/// Gets or sets el valor de validación de: EMPR_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean EMPR_CodigoOK
		{
			get { return m_empr_codigoOK; }
			set
			{
				if (m_empr_codigoOK != value)
				{ m_empr_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: EMPR_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String EMPR_CodigoMSGERROR
		{
			get { return m_empr_codigoMSGERROR; }
			set
			{
				if (m_empr_codigoMSGERROR != value)
				{m_empr_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: MOVI_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean MOVI_CodigoOK
		{
			get { return m_movi_codigoOK; }
			set
			{
				if (m_movi_codigoOK != value)
				{ m_movi_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: MOVI_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String MOVI_CodigoMSGERROR
		{
			get { return m_movi_codigoMSGERROR; }
			set
			{
				if (m_movi_codigoMSGERROR != value)
				{m_movi_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DMOV_Item.
		/// </summary>
		[IgnoreDataMember]
		public Boolean DMOV_ItemOK
		{
			get { return m_dmov_itemOK; }
			set
			{
				if (m_dmov_itemOK != value)
				{ m_dmov_itemOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DMOV_Item.
		/// </summary>
		[IgnoreDataMember]
		public String DMOV_ItemMSGERROR
		{
			get { return m_dmov_itemMSGERROR; }
			set
			{
				if (m_dmov_itemMSGERROR != value)
				{m_dmov_itemMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabTGB.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPO_TabTGBOK
		{
			get { return m_tipo_tabtgbOK; }
			set
			{
				if (m_tipo_tabtgbOK != value)
				{ m_tipo_tabtgbOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabTGB.
		/// </summary>
		[IgnoreDataMember]
		public String TIPO_TabTGBMSGERROR
		{
			get { return m_tipo_tabtgbMSGERROR; }
			set
			{
				if (m_tipo_tabtgbMSGERROR != value)
				{m_tipo_tabtgbMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodTGB.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPO_CodTGBOK
		{
			get { return m_tipo_codtgbOK; }
			set
			{
				if (m_tipo_codtgbOK != value)
				{ m_tipo_codtgbOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodTGB.
		/// </summary>
		[IgnoreDataMember]
		public String TIPO_CodTGBMSGERROR
		{
			get { return m_tipo_codtgbMSGERROR; }
			set
			{
				if (m_tipo_codtgbMSGERROR != value)
				{m_tipo_codtgbMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DMOV_MontoDebe.
		/// </summary>
		[IgnoreDataMember]
		public Boolean DMOV_MontoDebeOK
		{
			get { return m_dmov_montodebeOK; }
			set
			{
				if (m_dmov_montodebeOK != value)
				{ m_dmov_montodebeOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DMOV_MontoDebe.
		/// </summary>
		[IgnoreDataMember]
		public String DMOV_MontoDebeMSGERROR
		{
			get { return m_dmov_montodebeMSGERROR; }
			set
			{
				if (m_dmov_montodebeMSGERROR != value)
				{m_dmov_montodebeMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DMOV_MontoHaber.
		/// </summary>
		[IgnoreDataMember]
		public Boolean DMOV_MontoHaberOK
		{
			get { return m_dmov_montohaberOK; }
			set
			{
				if (m_dmov_montohaberOK != value)
				{ m_dmov_montohaberOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DMOV_MontoHaber.
		/// </summary>
		[IgnoreDataMember]
		public String DMOV_MontoHaberMSGERROR
		{
			get { return m_dmov_montohaberMSGERROR; }
			set
			{
				if (m_dmov_montohaberMSGERROR != value)
				{m_dmov_montohaberMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DMOV_NroOperacion.
		/// </summary>
		[IgnoreDataMember]
		public Boolean DMOV_NroOperacionOK
		{
			get { return m_dmov_nrooperacionOK; }
			set
			{
				if (m_dmov_nrooperacionOK != value)
				{ m_dmov_nrooperacionOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DMOV_NroOperacion.
		/// </summary>
		[IgnoreDataMember]
		public String DMOV_NroOperacionMSGERROR
		{
			get { return m_dmov_nrooperacionMSGERROR; }
			set
			{
				if (m_dmov_nrooperacionMSGERROR != value)
				{m_dmov_nrooperacionMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DMOV_Flujo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean DMOV_FlujoOK
		{
			get { return m_dmov_flujoOK; }
			set
			{
				if (m_dmov_flujoOK != value)
				{ m_dmov_flujoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DMOV_Flujo.
		/// </summary>
		[IgnoreDataMember]
		public String DMOV_FlujoMSGERROR
		{
			get { return m_dmov_flujoMSGERROR; }
			set
			{
				if (m_dmov_flujoMSGERROR != value)
				{m_dmov_flujoMSGERROR = value; }
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
				EMPR_CodigoOK  = true;
				EMPR_CodigoMSGERROR  = "";
				if( EMPR_Codigo == null)
				{
					_isCorrect = false;
					EMPR_CodigoOK  = false;
					EMPR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EMPR_Codigo", "DetMovimiento");
					m_mensajeError += "* Debe ingresar el campo EMPR_Codigo" + Environment.NewLine;
				}
				MOVI_CodigoOK  = true;
				MOVI_CodigoMSGERROR  = "";
				if( MOVI_Codigo == 0)
				{
					_isCorrect = false;
					MOVI_CodigoOK  = false;
					MOVI_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "MOVI_Codigo", "DetMovimiento");
					m_mensajeError += "* Debe ingresar el campo MOVI_Codigo" + Environment.NewLine;
				}
				DMOV_ItemOK  = true;
				DMOV_ItemMSGERROR  = "";
				if( DMOV_Item == null)
				{
					_isCorrect = false;
					DMOV_ItemOK  = false;
					DMOV_ItemMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DMOV_Item", "DetMovimiento");
					m_mensajeError += "* Debe ingresar el campo DMOV_Item" + Environment.NewLine;
				}
				DMOV_MontoDebeOK  = true;
				DMOV_MontoDebeMSGERROR  = "";
				if( DMOV_MontoDebe == 0)
				{
					_isCorrect = false;
					DMOV_MontoDebeOK  = false;
					DMOV_MontoDebeMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DMOV_MontoDebe", "DetMovimiento");
					m_mensajeError += "* Debe ingresar el campo DMOV_MontoDebe" + Environment.NewLine;
				}
				DMOV_MontoHaberOK  = true;
				DMOV_MontoHaberMSGERROR  = "";
				if( DMOV_MontoHaber == 0)
				{
					_isCorrect = false;
					DMOV_MontoHaberOK  = false;
					DMOV_MontoHaberMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DMOV_MontoHaber", "DetMovimiento");
					m_mensajeError += "* Debe ingresar el campo DMOV_MontoHaber" + Environment.NewLine;
				}
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}

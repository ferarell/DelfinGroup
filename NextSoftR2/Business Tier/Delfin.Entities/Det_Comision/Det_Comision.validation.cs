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
	public partial class Det_Comision
	{
		#region [ Variables Validación ]
		private Boolean m_comi_codigoOK;
		private String m_comi_codigoMSGERROR;
		private Boolean m_dcom_itemOK;
		private String m_dcom_itemMSGERROR;
		private Boolean m_pack_codigoOK;
		private String m_pack_codigoMSGERROR;
		private Boolean m_dcom_minprofitOK;
		private String m_dcom_minprofitMSGERROR;
		private Boolean m_dcom_valorOK;
		private String m_dcom_valorMSGERROR;
		private Boolean m_audi_feccreaOK;
		private String m_audi_feccreaMSGERROR;
		private Boolean m_audi_usrcreaOK;
		private String m_audi_usrcreaMSGERROR;
		private Boolean m_audi_fecmodOK;
		private String m_audi_fecmodMSGERROR;
		private Boolean m_audi_usrmodOK;
		private String m_audi_usrmodMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: COMI_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean COMI_CodigoOK
		{
			get { return m_comi_codigoOK; }
			set
			{
				if (m_comi_codigoOK != value)
				{ m_comi_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: COMI_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String COMI_CodigoMSGERROR
		{
			get { return m_comi_codigoMSGERROR; }
			set
			{
				if (m_comi_codigoMSGERROR != value)
				{m_comi_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCOM_Item.
		/// </summary>
		[IgnoreDataMember]
		public Boolean DCOM_ItemOK
		{
			get { return m_dcom_itemOK; }
			set
			{
				if (m_dcom_itemOK != value)
				{ m_dcom_itemOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCOM_Item.
		/// </summary>
		[IgnoreDataMember]
		public String DCOM_ItemMSGERROR
		{
			get { return m_dcom_itemMSGERROR; }
			set
			{
				if (m_dcom_itemMSGERROR != value)
				{m_dcom_itemMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PACK_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean PACK_CodigoOK
		{
			get { return m_pack_codigoOK; }
			set
			{
				if (m_pack_codigoOK != value)
				{ m_pack_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PACK_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String PACK_CodigoMSGERROR
		{
			get { return m_pack_codigoMSGERROR; }
			set
			{
				if (m_pack_codigoMSGERROR != value)
				{m_pack_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCOM_MinProfit.
		/// </summary>
		[IgnoreDataMember]
		public Boolean DCOM_MinProfitOK
		{
			get { return m_dcom_minprofitOK; }
			set
			{
				if (m_dcom_minprofitOK != value)
				{ m_dcom_minprofitOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCOM_MinProfit.
		/// </summary>
		[IgnoreDataMember]
		public String DCOM_MinProfitMSGERROR
		{
			get { return m_dcom_minprofitMSGERROR; }
			set
			{
				if (m_dcom_minprofitMSGERROR != value)
				{m_dcom_minprofitMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCOM_Valor.
		/// </summary>
		[IgnoreDataMember]
		public Boolean DCOM_ValorOK
		{
			get { return m_dcom_valorOK; }
			set
			{
				if (m_dcom_valorOK != value)
				{ m_dcom_valorOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCOM_Valor.
		/// </summary>
		[IgnoreDataMember]
		public String DCOM_ValorMSGERROR
		{
			get { return m_dcom_valorMSGERROR; }
			set
			{
				if (m_dcom_valorMSGERROR != value)
				{m_dcom_valorMSGERROR = value; }
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
				COMI_CodigoOK  = true;
				COMI_CodigoMSGERROR  = "";
				if( COMI_Codigo == 0)
				{
					_isCorrect = false;
					COMI_CodigoOK  = false;
					COMI_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "COMI_Codigo", "Det_Comision");
					m_mensajeError += "* Debe ingresar el campo COMI_Codigo" + Environment.NewLine;
				}
				DCOM_ItemOK  = true;
				DCOM_ItemMSGERROR  = "";
				if( DCOM_Item == 0)
				{
					_isCorrect = false;
					DCOM_ItemOK  = false;
					DCOM_ItemMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DCOM_Item", "Det_Comision");
					m_mensajeError += "* Debe ingresar el campo DCOM_Item" + Environment.NewLine;
				}
				PACK_CodigoOK  = true;
				PACK_CodigoMSGERROR  = "";
				if( PACK_Codigo == 0)
				{
					_isCorrect = false;
					PACK_CodigoOK  = false;
					PACK_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "PACK_Codigo", "Det_Comision");
					m_mensajeError += "* Debe ingresar el campo PACK_Codigo" + Environment.NewLine;
				}
				DCOM_MinProfitOK  = true;
				DCOM_MinProfitMSGERROR  = "";
				if( DCOM_MinProfit == 0)
				{
					_isCorrect = false;
					DCOM_MinProfitOK  = false;
					DCOM_MinProfitMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DCOM_MinProfit", "Det_Comision");
					m_mensajeError += "* Debe ingresar el campo DCOM_MinProfit" + Environment.NewLine;
				}
				DCOM_ValorOK  = true;
				DCOM_ValorMSGERROR  = "";
				if( DCOM_Valor == 0)
				{
					_isCorrect = false;
					DCOM_ValorOK  = false;
					DCOM_ValorMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DCOM_Valor", "Det_Comision");
					m_mensajeError += "* Debe ingresar el campo DCOM_Valor" + Environment.NewLine;
				}
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}

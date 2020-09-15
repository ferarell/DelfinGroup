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
	public partial class LiqCtaCte
	{
		#region [ Variables Validación ]
		private Boolean m_empr_codigoOK;
		private String m_empr_codigoMSGERROR;
		private Boolean m_liqu_codigoOK;
		private String m_liqu_codigoMSGERROR;
		private Boolean m_ccct_codigoOK;
		private String m_ccct_codigoMSGERROR;
		private Boolean m_lccc_itemOK;
		private String m_lccc_itemMSGERROR;
		private Boolean m_audi_usrcreaOK;
		private String m_audi_usrcreaMSGERROR;
		private Boolean m_auid_feccreaOK;
		private String m_auid_feccreaMSGERROR;
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
		/// Gets or sets el valor de validación de: LIQU_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LIQU_CodigoOK
		{
			get { return m_liqu_codigoOK; }
			set
			{
				if (m_liqu_codigoOK != value)
				{ m_liqu_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LIQU_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String LIQU_CodigoMSGERROR
		{
			get { return m_liqu_codigoMSGERROR; }
			set
			{
				if (m_liqu_codigoMSGERROR != value)
				{m_liqu_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CCCT_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CCCT_CodigoOK
		{
			get { return m_ccct_codigoOK; }
			set
			{
				if (m_ccct_codigoOK != value)
				{ m_ccct_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCCT_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String CCCT_CodigoMSGERROR
		{
			get { return m_ccct_codigoMSGERROR; }
			set
			{
				if (m_ccct_codigoMSGERROR != value)
				{m_ccct_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LCCC_Item.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LCCC_ItemOK
		{
			get { return m_lccc_itemOK; }
			set
			{
				if (m_lccc_itemOK != value)
				{ m_lccc_itemOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LCCC_Item.
		/// </summary>
		[IgnoreDataMember]
		public String LCCC_ItemMSGERROR
		{
			get { return m_lccc_itemMSGERROR; }
			set
			{
				if (m_lccc_itemMSGERROR != value)
				{m_lccc_itemMSGERROR = value; }
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
					EMPR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EMPR_Codigo", "LiqCtaCte");
					m_mensajeError += "* Debe ingresar el campo EMPR_Codigo" + Environment.NewLine;
				}
				LIQU_CodigoOK  = true;
				LIQU_CodigoMSGERROR  = "";
				if( String.IsNullOrEmpty(LIQU_Codigo) )
				{
					_isCorrect = false;
					LIQU_CodigoOK  = false;
					LIQU_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "LIQU_Codigo", "LiqCtaCte");
					m_mensajeError += "* Debe ingresar el campo LIQU_Codigo" + Environment.NewLine;
				}
				CCCT_CodigoOK  = true;
				CCCT_CodigoMSGERROR  = "";
				if( CCCT_Codigo == 0)
				{
					_isCorrect = false;
					CCCT_CodigoOK  = false;
					CCCT_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCCT_Codigo", "LiqCtaCte");
					m_mensajeError += "* Debe ingresar el campo CCCT_Codigo" + Environment.NewLine;
				}
				LCCC_ItemOK  = true;
				LCCC_ItemMSGERROR  = "";
				if( LCCC_Item == null)
				{
					_isCorrect = false;
					LCCC_ItemOK  = false;
					LCCC_ItemMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "LCCC_Item", "LiqCtaCte");
					m_mensajeError += "* Debe ingresar el campo LCCC_Item" + Environment.NewLine;
				}
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}

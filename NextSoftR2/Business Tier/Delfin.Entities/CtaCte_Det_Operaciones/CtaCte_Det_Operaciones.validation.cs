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
	public partial class CtaCte_Det_Operaciones
	{
		#region [ Variables Validación ]
		private Boolean m_dcto_codigoOK;
		private String m_dcto_codigoMSGERROR;
		private Boolean m_dope_itemOK;
		private String m_dope_itemMSGERROR;
		private Boolean m_cope_codigoOK;
		private String m_cope_codigoMSGERROR;
		private Boolean m_sope_itemOK;
		private String m_sope_itemMSGERROR;
		private Boolean m_ccct_codigoOK;
		private String m_ccct_codigoMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: DCTO_Codigo.
		/// </summary>
		[DataMember]
		public Boolean DCTO_CodigoOK
		{
			get { return m_dcto_codigoOK; }
			set
			{
				if (m_dcto_codigoOK != value)
				{
					m_dcto_codigoOK = value;
					OnPropertyChanged("DCTO_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCTO_Codigo.
		/// </summary>
		[DataMember]
		public String DCTO_CodigoMSGERROR
		{
			get { return m_dcto_codigoMSGERROR; }
			set
			{
				if (m_dcto_codigoMSGERROR != value)
				{
					m_dcto_codigoMSGERROR = value;
					OnPropertyChanged("DCTO_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOPE_Item.
		/// </summary>
		[DataMember]
		public Boolean DOPE_ItemOK
		{
			get { return m_dope_itemOK; }
			set
			{
				if (m_dope_itemOK != value)
				{
					m_dope_itemOK = value;
					OnPropertyChanged("DOPE_ItemOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOPE_Item.
		/// </summary>
		[DataMember]
		public String DOPE_ItemMSGERROR
		{
			get { return m_dope_itemMSGERROR; }
			set
			{
				if (m_dope_itemMSGERROR != value)
				{
					m_dope_itemMSGERROR = value;
					OnPropertyChanged("DOPE_ItemMSGERROR");
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
				DCTO_CodigoOK  = true;
				DCTO_CodigoMSGERROR  = "";
				if( DCTO_Codigo == null)
				{
					_isCorrect = false;
					DCTO_CodigoOK  = false;
					DCTO_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DCTO_Codigo", "CtaCte_Det_Operaciones");
					m_mensajeError += "* Debe ingresar el campo DCTO_Codigo" + Environment.NewLine;
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

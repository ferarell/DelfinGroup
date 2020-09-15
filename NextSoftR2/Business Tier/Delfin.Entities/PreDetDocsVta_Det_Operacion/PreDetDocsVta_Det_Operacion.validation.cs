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
	public partial class PreDetDocsVta_Det_Operacion
	{
		#region [ Variables Validación ]
		private Boolean m_pddo_codigoOK;
		private String m_pddo_codigoMSGERROR;
		private Boolean m_sope_itemOK;
		private String m_sope_itemMSGERROR;
		private Boolean m_cope_codigoOK;
		private String m_cope_codigoMSGERROR;
		private Boolean m_dope_itemOK;
		private String m_dope_itemMSGERROR;
		private Boolean m_pddo_itemOK;
		private String m_pddo_itemMSGERROR;
		private Boolean m_docv_codigoOK;
		private String m_docv_codigoMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: PDDO_Codigo.
		/// </summary>
		[DataMember]
		public Boolean PDDO_CodigoOK
		{
			get { return m_pddo_codigoOK; }
			set
			{
				if (m_pddo_codigoOK != value)
				{
					m_pddo_codigoOK = value;
					OnPropertyChanged("PDDO_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PDDO_Codigo.
		/// </summary>
		[DataMember]
		public String PDDO_CodigoMSGERROR
		{
			get { return m_pddo_codigoMSGERROR; }
			set
			{
				if (m_pddo_codigoMSGERROR != value)
				{
					m_pddo_codigoMSGERROR = value;
					OnPropertyChanged("PDDO_CodigoMSGERROR");
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
		/// Gets or sets el valor de validación de: PDDO_Item.
		/// </summary>
		[DataMember]
		public Boolean PDDO_ItemOK
		{
			get { return m_pddo_itemOK; }
			set
			{
				if (m_pddo_itemOK != value)
				{
					m_pddo_itemOK = value;
					OnPropertyChanged("PDDO_ItemOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PDDO_Item.
		/// </summary>
		[DataMember]
		public String PDDO_ItemMSGERROR
		{
			get { return m_pddo_itemMSGERROR; }
			set
			{
				if (m_pddo_itemMSGERROR != value)
				{
					m_pddo_itemMSGERROR = value;
					OnPropertyChanged("PDDO_ItemMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_Codigo.
		/// </summary>
		[DataMember]
		public Boolean DOCV_CodigoOK
		{
			get { return m_docv_codigoOK; }
			set
			{
				if (m_docv_codigoOK != value)
				{
					m_docv_codigoOK = value;
					OnPropertyChanged("DOCV_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_Codigo.
		/// </summary>
		[DataMember]
		public String DOCV_CodigoMSGERROR
		{
			get { return m_docv_codigoMSGERROR; }
			set
			{
				if (m_docv_codigoMSGERROR != value)
				{
					m_docv_codigoMSGERROR = value;
					OnPropertyChanged("DOCV_CodigoMSGERROR");
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
				PDDO_CodigoOK  = true;
				PDDO_CodigoMSGERROR  = "";
				if( PDVO_Codigo == null)
				{
					_isCorrect = false;
					PDDO_CodigoOK  = false;
					PDDO_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "PDDO_Codigo", "PreDetDocsVta_Det_Operacion");
					m_mensajeError += "* Debe ingresar el campo PDDO_Codigo" + Environment.NewLine;
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

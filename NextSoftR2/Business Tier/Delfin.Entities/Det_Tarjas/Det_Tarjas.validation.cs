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
	public partial class Det_Tarjas
	{
		#region [ Variables Validación ]
		private Boolean m_dtaj_itemOK;
		private String m_dtaj_itemMSGERROR;
		private Boolean m_dtaj_nrocontenedorOK;
		private String m_dtaj_nrocontenedorMSGERROR;
		private Boolean m_audi_usrcreaOK;
		private String m_audi_usrcreaMSGERROR;
		private Boolean m_audi_feccreaOK;
		private String m_audi_feccreaMSGERROR;
		private Boolean m_audi_usrmodOK;
		private String m_audi_usrmodMSGERROR;
		private Boolean m_audi_fecmodOK;
		private String m_audi_fecmodMSGERROR;
		private Boolean m_tarj_codigoOK;
		private String m_tarj_codigoMSGERROR;
		private Boolean m_pack_codigoOK;
		private String m_pack_codigoMSGERROR;
		private Boolean m_cons_tabetjOK;
		private String m_cons_tabetjMSGERROR;
		private Boolean m_cons_codetjOK;
		private String m_cons_codetjMSGERROR;
		private Boolean m_dtaj_tarjaOK;
		private String m_dtaj_tarjaMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: DTAJ_Item.
		/// </summary>
		[DataMember]
		public Boolean DTAJ_ItemOK
		{
			get { return m_dtaj_itemOK; }
			set
			{
				if (m_dtaj_itemOK != value)
				{
					m_dtaj_itemOK = value;
					OnPropertyChanged("DTAJ_ItemOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DTAJ_Item.
		/// </summary>
		[DataMember]
		public String DTAJ_ItemMSGERROR
		{
			get { return m_dtaj_itemMSGERROR; }
			set
			{
				if (m_dtaj_itemMSGERROR != value)
				{
					m_dtaj_itemMSGERROR = value;
					OnPropertyChanged("DTAJ_ItemMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DTAJ_NroContenedor.
		/// </summary>
		[DataMember]
		public Boolean DTAJ_NroContenedorOK
		{
			get { return m_dtaj_nrocontenedorOK; }
			set
			{
				if (m_dtaj_nrocontenedorOK != value)
				{
					m_dtaj_nrocontenedorOK = value;
					OnPropertyChanged("DTAJ_NroContenedorOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DTAJ_NroContenedor.
		/// </summary>
		[DataMember]
		public String DTAJ_NroContenedorMSGERROR
		{
			get { return m_dtaj_nrocontenedorMSGERROR; }
			set
			{
				if (m_dtaj_nrocontenedorMSGERROR != value)
				{
					m_dtaj_nrocontenedorMSGERROR = value;
					OnPropertyChanged("DTAJ_NroContenedorMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TARJ_Codigo.
		/// </summary>
		[DataMember]
		public Boolean TARJ_CodigoOK
		{
			get { return m_tarj_codigoOK; }
			set
			{
				if (m_tarj_codigoOK != value)
				{
					m_tarj_codigoOK = value;
					OnPropertyChanged("TARJ_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TARJ_Codigo.
		/// </summary>
		[DataMember]
		public String TARJ_CodigoMSGERROR
		{
			get { return m_tarj_codigoMSGERROR; }
			set
			{
				if (m_tarj_codigoMSGERROR != value)
				{
					m_tarj_codigoMSGERROR = value;
					OnPropertyChanged("TARJ_CodigoMSGERROR");
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
		/// Gets or sets el valor de validación de: CONS_TabETJ.
		/// </summary>
		[DataMember]
		public Boolean CONS_TabETJOK
		{
			get { return m_cons_tabetjOK; }
			set
			{
				if (m_cons_tabetjOK != value)
				{
					m_cons_tabetjOK = value;
					OnPropertyChanged("CONS_TabETJOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_TabETJ.
		/// </summary>
		[DataMember]
		public String CONS_TabETJMSGERROR
		{
			get { return m_cons_tabetjMSGERROR; }
			set
			{
				if (m_cons_tabetjMSGERROR != value)
				{
					m_cons_tabetjMSGERROR = value;
					OnPropertyChanged("CONS_TabETJMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_CodETJ.
		/// </summary>
		[DataMember]
		public Boolean CONS_CodETJOK
		{
			get { return m_cons_codetjOK; }
			set
			{
				if (m_cons_codetjOK != value)
				{
					m_cons_codetjOK = value;
					OnPropertyChanged("CONS_CodETJOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_CodETJ.
		/// </summary>
		[DataMember]
		public String CONS_CodETJMSGERROR
		{
			get { return m_cons_codetjMSGERROR; }
			set
			{
				if (m_cons_codetjMSGERROR != value)
				{
					m_cons_codetjMSGERROR = value;
					OnPropertyChanged("CONS_CodETJMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DTAJ_Tarja.
		/// </summary>
		[DataMember]
		public Boolean DTAJ_TarjaOK
		{
			get { return m_dtaj_tarjaOK; }
			set
			{
				if (m_dtaj_tarjaOK != value)
				{
					m_dtaj_tarjaOK = value;
					OnPropertyChanged("DTAJ_TarjaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DTAJ_Tarja.
		/// </summary>
		[DataMember]
		public String DTAJ_TarjaMSGERROR
		{
			get { return m_dtaj_tarjaMSGERROR; }
			set
			{
				if (m_dtaj_tarjaMSGERROR != value)
				{
					m_dtaj_tarjaMSGERROR = value;
					OnPropertyChanged("DTAJ_TarjaMSGERROR");
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
				DTAJ_ItemOK  = true;
				DTAJ_ItemMSGERROR  = "";
				if( DTAJ_Item == null)
				{
					_isCorrect = false;
					DTAJ_ItemOK  = false;
					DTAJ_ItemMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DTAJ_Item", "Det_Tarjas");
					m_mensajeError += "* Debe ingresar el campo DTAJ_Item" + Environment.NewLine;
				}
				DTAJ_NroContenedorOK  = true;
				DTAJ_NroContenedorMSGERROR  = "";
				if( String.IsNullOrEmpty(DTAJ_NroContenedor) )
				{
					_isCorrect = false;
					DTAJ_NroContenedorOK  = false;
					DTAJ_NroContenedorMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DTAJ_NroContenedor", "Det_Tarjas");
					m_mensajeError += "* Debe ingresar el campo DTAJ_NroContenedor" + Environment.NewLine;
				}
				TARJ_CodigoOK  = true;
				TARJ_CodigoMSGERROR  = "";
				if( TARJ_Codigo == null)
				{
					_isCorrect = false;
					TARJ_CodigoOK  = false;
					TARJ_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TARJ_Codigo", "Det_Tarjas");
					m_mensajeError += "* Debe ingresar el campo TARJ_Codigo" + Environment.NewLine;
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

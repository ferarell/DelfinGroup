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
    public partial class PreDetDocsVta
	{
		#region [ Variables Validación ]
		private Boolean m_pddo_itemOK;
		private String m_pddo_itemMSGERROR;
		private Boolean m_ddov_cantidadOK;
		private String m_ddov_cantidadMSGERROR;
		private Boolean m_ddov_preciounitarioOK;
		private String m_ddov_preciounitarioMSGERROR;
		private Boolean m_ddov_preciounitariodOK;
		private String m_ddov_preciounitariodMSGERROR;
		private Boolean m_ddov_valorventaOK;
		private String m_ddov_valorventaMSGERROR;
		private Boolean m_ddov_valorventadOK;
		private String m_ddov_valorventadMSGERROR;
		private Boolean m_ddov_impuesto1OK;
		private String m_ddov_impuesto1MSGERROR;
		private Boolean m_ddov_impuesto1dOK;
		private String m_ddov_impuesto1dMSGERROR;
		private Boolean m_ddov_impuesto2OK;
		private String m_ddov_impuesto2MSGERROR;
		private Boolean m_ddov_impuesto2dOK;
		private String m_ddov_impuesto2dMSGERROR;
		private Boolean m_ddov_impuesto3OK;
		private String m_ddov_impuesto3MSGERROR;
		private Boolean m_ddov_impuesto3dOK;
		private String m_ddov_impuesto3dMSGERROR;
		private Boolean m_ddov_impuesto4OK;
		private String m_ddov_impuesto4MSGERROR;
		private Boolean m_ddov_impuesto4dOK;
		private String m_ddov_impuesto4dMSGERROR;
		private Boolean m_ddov_notasOK;
		private String m_ddov_notasMSGERROR;
		private Boolean m_docv_codigoOK;
		private String m_docv_codigoMSGERROR;
		private Boolean m_serv_codigoOK;
		private String m_serv_codigoMSGERROR;
		private Boolean m_ddov_descripcionOK;
		private String m_ddov_descripcionMSGERROR;
		private Boolean m_dope_itemOK;
		private String m_dope_itemMSGERROR;
		private Boolean m_cope_codigoOK;
		private String m_cope_codigoMSGERROR;
		private Boolean m_sope_itemOK;
		private String m_sope_itemMSGERROR;
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
		/// Gets or sets el valor de validación de: DDOV_Cantidad.
		/// </summary>
		[DataMember]
		public Boolean DDOV_CantidadOK
		{
			get { return m_ddov_cantidadOK; }
			set
			{
				if (m_ddov_cantidadOK != value)
				{
					m_ddov_cantidadOK = value;
					OnPropertyChanged("DDOV_CantidadOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DDOV_Cantidad.
		/// </summary>
		[DataMember]
		public String DDOV_CantidadMSGERROR
		{
			get { return m_ddov_cantidadMSGERROR; }
			set
			{
				if (m_ddov_cantidadMSGERROR != value)
				{
					m_ddov_cantidadMSGERROR = value;
					OnPropertyChanged("DDOV_CantidadMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DDOV_PrecioUnitario.
		/// </summary>
		[DataMember]
		public Boolean DDOV_PrecioUnitarioOK
		{
			get { return m_ddov_preciounitarioOK; }
			set
			{
				if (m_ddov_preciounitarioOK != value)
				{
					m_ddov_preciounitarioOK = value;
					OnPropertyChanged("DDOV_PrecioUnitarioOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DDOV_PrecioUnitario.
		/// </summary>
		[DataMember]
		public String DDOV_PrecioUnitarioMSGERROR
		{
			get { return m_ddov_preciounitarioMSGERROR; }
			set
			{
				if (m_ddov_preciounitarioMSGERROR != value)
				{
					m_ddov_preciounitarioMSGERROR = value;
					OnPropertyChanged("DDOV_PrecioUnitarioMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DDOV_PrecioUnitarioD.
		/// </summary>
		[DataMember]
		public Boolean DDOV_PrecioUnitarioDOK
		{
			get { return m_ddov_preciounitariodOK; }
			set
			{
				if (m_ddov_preciounitariodOK != value)
				{
					m_ddov_preciounitariodOK = value;
					OnPropertyChanged("DDOV_PrecioUnitarioDOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DDOV_PrecioUnitarioD.
		/// </summary>
		[DataMember]
		public String DDOV_PrecioUnitarioDMSGERROR
		{
			get { return m_ddov_preciounitariodMSGERROR; }
			set
			{
				if (m_ddov_preciounitariodMSGERROR != value)
				{
					m_ddov_preciounitariodMSGERROR = value;
					OnPropertyChanged("DDOV_PrecioUnitarioDMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DDOV_ValorVenta.
		/// </summary>
		[DataMember]
		public Boolean DDOV_ValorVentaOK
		{
			get { return m_ddov_valorventaOK; }
			set
			{
				if (m_ddov_valorventaOK != value)
				{
					m_ddov_valorventaOK = value;
					OnPropertyChanged("DDOV_ValorVentaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DDOV_ValorVenta.
		/// </summary>
		[DataMember]
		public String DDOV_ValorVentaMSGERROR
		{
			get { return m_ddov_valorventaMSGERROR; }
			set
			{
				if (m_ddov_valorventaMSGERROR != value)
				{
					m_ddov_valorventaMSGERROR = value;
					OnPropertyChanged("DDOV_ValorVentaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DDOV_ValorVentaD.
		/// </summary>
		[DataMember]
		public Boolean DDOV_ValorVentaDOK
		{
			get { return m_ddov_valorventadOK; }
			set
			{
				if (m_ddov_valorventadOK != value)
				{
					m_ddov_valorventadOK = value;
					OnPropertyChanged("DDOV_ValorVentaDOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DDOV_ValorVentaD.
		/// </summary>
		[DataMember]
		public String DDOV_ValorVentaDMSGERROR
		{
			get { return m_ddov_valorventadMSGERROR; }
			set
			{
				if (m_ddov_valorventadMSGERROR != value)
				{
					m_ddov_valorventadMSGERROR = value;
					OnPropertyChanged("DDOV_ValorVentaDMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DDOV_Impuesto1.
		/// </summary>
		[DataMember]
		public Boolean DDOV_Impuesto1OK
		{
			get { return m_ddov_impuesto1OK; }
			set
			{
				if (m_ddov_impuesto1OK != value)
				{
					m_ddov_impuesto1OK = value;
					OnPropertyChanged("DDOV_Impuesto1OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DDOV_Impuesto1.
		/// </summary>
		[DataMember]
		public String DDOV_Impuesto1MSGERROR
		{
			get { return m_ddov_impuesto1MSGERROR; }
			set
			{
				if (m_ddov_impuesto1MSGERROR != value)
				{
					m_ddov_impuesto1MSGERROR = value;
					OnPropertyChanged("DDOV_Impuesto1MSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DDOV_Impuesto1D.
		/// </summary>
		[DataMember]
		public Boolean DDOV_Impuesto1DOK
		{
			get { return m_ddov_impuesto1dOK; }
			set
			{
				if (m_ddov_impuesto1dOK != value)
				{
					m_ddov_impuesto1dOK = value;
					OnPropertyChanged("DDOV_Impuesto1DOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DDOV_Impuesto1D.
		/// </summary>
		[DataMember]
		public String DDOV_Impuesto1DMSGERROR
		{
			get { return m_ddov_impuesto1dMSGERROR; }
			set
			{
				if (m_ddov_impuesto1dMSGERROR != value)
				{
					m_ddov_impuesto1dMSGERROR = value;
					OnPropertyChanged("DDOV_Impuesto1DMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DDOV_Impuesto2.
		/// </summary>
		[DataMember]
		public Boolean DDOV_Impuesto2OK
		{
			get { return m_ddov_impuesto2OK; }
			set
			{
				if (m_ddov_impuesto2OK != value)
				{
					m_ddov_impuesto2OK = value;
					OnPropertyChanged("DDOV_Impuesto2OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DDOV_Impuesto2.
		/// </summary>
		[DataMember]
		public String DDOV_Impuesto2MSGERROR
		{
			get { return m_ddov_impuesto2MSGERROR; }
			set
			{
				if (m_ddov_impuesto2MSGERROR != value)
				{
					m_ddov_impuesto2MSGERROR = value;
					OnPropertyChanged("DDOV_Impuesto2MSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DDOV_Impuesto2D.
		/// </summary>
		[DataMember]
		public Boolean DDOV_Impuesto2DOK
		{
			get { return m_ddov_impuesto2dOK; }
			set
			{
				if (m_ddov_impuesto2dOK != value)
				{
					m_ddov_impuesto2dOK = value;
					OnPropertyChanged("DDOV_Impuesto2DOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DDOV_Impuesto2D.
		/// </summary>
		[DataMember]
		public String DDOV_Impuesto2DMSGERROR
		{
			get { return m_ddov_impuesto2dMSGERROR; }
			set
			{
				if (m_ddov_impuesto2dMSGERROR != value)
				{
					m_ddov_impuesto2dMSGERROR = value;
					OnPropertyChanged("DDOV_Impuesto2DMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DDOV_Impuesto3.
		/// </summary>
		[DataMember]
		public Boolean DDOV_Impuesto3OK
		{
			get { return m_ddov_impuesto3OK; }
			set
			{
				if (m_ddov_impuesto3OK != value)
				{
					m_ddov_impuesto3OK = value;
					OnPropertyChanged("DDOV_Impuesto3OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DDOV_Impuesto3.
		/// </summary>
		[DataMember]
		public String DDOV_Impuesto3MSGERROR
		{
			get { return m_ddov_impuesto3MSGERROR; }
			set
			{
				if (m_ddov_impuesto3MSGERROR != value)
				{
					m_ddov_impuesto3MSGERROR = value;
					OnPropertyChanged("DDOV_Impuesto3MSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DDOV_Impuesto3D.
		/// </summary>
		[DataMember]
		public Boolean DDOV_Impuesto3DOK
		{
			get { return m_ddov_impuesto3dOK; }
			set
			{
				if (m_ddov_impuesto3dOK != value)
				{
					m_ddov_impuesto3dOK = value;
					OnPropertyChanged("DDOV_Impuesto3DOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DDOV_Impuesto3D.
		/// </summary>
		[DataMember]
		public String DDOV_Impuesto3DMSGERROR
		{
			get { return m_ddov_impuesto3dMSGERROR; }
			set
			{
				if (m_ddov_impuesto3dMSGERROR != value)
				{
					m_ddov_impuesto3dMSGERROR = value;
					OnPropertyChanged("DDOV_Impuesto3DMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DDOV_Impuesto4.
		/// </summary>
		[DataMember]
		public Boolean DDOV_Impuesto4OK
		{
			get { return m_ddov_impuesto4OK; }
			set
			{
				if (m_ddov_impuesto4OK != value)
				{
					m_ddov_impuesto4OK = value;
					OnPropertyChanged("DDOV_Impuesto4OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DDOV_Impuesto4.
		/// </summary>
		[DataMember]
		public String DDOV_Impuesto4MSGERROR
		{
			get { return m_ddov_impuesto4MSGERROR; }
			set
			{
				if (m_ddov_impuesto4MSGERROR != value)
				{
					m_ddov_impuesto4MSGERROR = value;
					OnPropertyChanged("DDOV_Impuesto4MSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DDOV_Impuesto4D.
		/// </summary>
		[DataMember]
		public Boolean DDOV_Impuesto4DOK
		{
			get { return m_ddov_impuesto4dOK; }
			set
			{
				if (m_ddov_impuesto4dOK != value)
				{
					m_ddov_impuesto4dOK = value;
					OnPropertyChanged("DDOV_Impuesto4DOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DDOV_Impuesto4D.
		/// </summary>
		[DataMember]
		public String DDOV_Impuesto4DMSGERROR
		{
			get { return m_ddov_impuesto4dMSGERROR; }
			set
			{
				if (m_ddov_impuesto4dMSGERROR != value)
				{
					m_ddov_impuesto4dMSGERROR = value;
					OnPropertyChanged("DDOV_Impuesto4DMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DDOV_Notas.
		/// </summary>
		[DataMember]
		public Boolean DDOV_NotasOK
		{
			get { return m_ddov_notasOK; }
			set
			{
				if (m_ddov_notasOK != value)
				{
					m_ddov_notasOK = value;
					OnPropertyChanged("DDOV_NotasOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DDOV_Notas.
		/// </summary>
		[DataMember]
		public String DDOV_NotasMSGERROR
		{
			get { return m_ddov_notasMSGERROR; }
			set
			{
				if (m_ddov_notasMSGERROR != value)
				{
					m_ddov_notasMSGERROR = value;
					OnPropertyChanged("DDOV_NotasMSGERROR");
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
		/// Gets or sets el valor de validación de: DDOV_Descripcion.
		/// </summary>
		[DataMember]
		public Boolean DDOV_DescripcionOK
		{
			get { return m_ddov_descripcionOK; }
			set
			{
				if (m_ddov_descripcionOK != value)
				{
					m_ddov_descripcionOK = value;
					OnPropertyChanged("DDOV_DescripcionOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DDOV_Descripcion.
		/// </summary>
		[DataMember]
		public String DDOV_DescripcionMSGERROR
		{
			get { return m_ddov_descripcionMSGERROR; }
			set
			{
				if (m_ddov_descripcionMSGERROR != value)
				{
					m_ddov_descripcionMSGERROR = value;
					OnPropertyChanged("DDOV_DescripcionMSGERROR");
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
                //PDDO_ItemOK  = true;
                //PDDO_ItemMSGERROR  = "";
                //if( PDDO_Item == null)
                //{
                //    _isCorrect = false;
                //    PDDO_ItemOK  = false;
                //    PDDO_ItemMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "PDDO_Item", "Detalle Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo PDDO_Item" + Environment.NewLine;
                //}
				DDOV_CantidadOK  = true;
				DDOV_CantidadMSGERROR  = "";
				if( DDOV_Cantidad == 0)
				{
					_isCorrect = false;
					DDOV_CantidadOK  = false;
					DDOV_CantidadMSGERROR  = String.Format("Debe ingresar la {0} del {1}.", "Cantidad", "Detalle Documento de Venta");
					m_mensajeError += "* Debe ingresar el campo Cantidad" + Environment.NewLine;
				}
				DDOV_PrecioUnitarioOK  = true;
				DDOV_PrecioUnitarioMSGERROR  = "";
				if( DDOV_PrecioUnitario == 0)
				{
					_isCorrect = false;
					DDOV_PrecioUnitarioOK  = false;
					DDOV_PrecioUnitarioMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "Precio Unitario", "Detalle Documento de Venta");
					m_mensajeError += "* Debe ingresar el campo Precio Unitario" + Environment.NewLine;
				}
                //DDOV_PrecioUnitarioDOK  = true;
                //DDOV_PrecioUnitarioDMSGERROR  = "";
                //if( DDOV_PrecioUnitarioD == null)
                //{
                //    _isCorrect = false;
                //    DDOV_PrecioUnitarioDOK  = false;
                //    DDOV_PrecioUnitarioDMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "DDOV_PrecioUnitarioD", "Detalle Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo DDOV_PrecioUnitarioD" + Environment.NewLine;
                //}
				DDOV_ValorVentaOK  = true;
				DDOV_ValorVentaMSGERROR  = "";
				if( DDOV_ValorVenta == 0)
				{
					_isCorrect = false;
					DDOV_ValorVentaOK  = false;
					DDOV_ValorVentaMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "Valor Venta", "Detalle Documento de Venta");
					m_mensajeError += "* Debe ingresar el campo Valor Venta" + Environment.NewLine;
				}
                //DDOV_ValorVentaDOK  = true;
                //DDOV_ValorVentaDMSGERROR  = "";
                //if( DDOV_ValorVentaD == 0)
                //{
                //    _isCorrect = false;
                //    DDOV_ValorVentaDOK  = false;
                //    DDOV_ValorVentaDMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "DDOV_ValorVentaD", "Detalle Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo DDOV_ValorVentaD" + Environment.NewLine;
                //}
				DDOV_Impuesto1OK  = true;
				DDOV_Impuesto1MSGERROR  = "";
				if( DDOV_Impuesto1 == 0)
				{
					_isCorrect = false;
					DDOV_Impuesto1OK  = false;
					DDOV_Impuesto1MSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "Impuesto", "Detalle Documento de Venta");
					m_mensajeError += "* Debe ingresar el campo Impuesto" + Environment.NewLine;
				}
                //DDOV_Impuesto1DOK  = true;
                //DDOV_Impuesto1DMSGERROR  = "";
                //if( DDOV_Impuesto1D == null)
                //{
                //    _isCorrect = false;
                //    DDOV_Impuesto1DOK  = false;
                //    DDOV_Impuesto1DMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "DDOV_Impuesto1D", "Detalle Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo DDOV_Impuesto1D" + Environment.NewLine;
                //}
                //DDOV_Impuesto2OK  = true;
                //DDOV_Impuesto2MSGERROR  = "";
                //if( DDOV_Impuesto2 == null)
                //{
                //    _isCorrect = false;
                //    DDOV_Impuesto2OK  = false;
                //    DDOV_Impuesto2MSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "DDOV_Impuesto2", "Detalle Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo DDOV_Impuesto2" + Environment.NewLine;
                //}
                //DDOV_Impuesto2DOK  = true;
                //DDOV_Impuesto2DMSGERROR  = "";
                //if( DDOV_Impuesto2D == null)
                //{
                //    _isCorrect = false;
                //    DDOV_Impuesto2DOK  = false;
                //    DDOV_Impuesto2DMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "DDOV_Impuesto2D", "Detalle Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo DDOV_Impuesto2D" + Environment.NewLine;
                //}
                //DDOV_Impuesto3OK  = true;
                //DDOV_Impuesto3MSGERROR  = "";
                //if( DDOV_Impuesto3 == null)
                //{
                //    _isCorrect = false;
                //    DDOV_Impuesto3OK  = false;
                //    DDOV_Impuesto3MSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "DDOV_Impuesto3", "Detalle Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo DDOV_Impuesto3" + Environment.NewLine;
                //}
                //DDOV_Impuesto3DOK  = true;
                //DDOV_Impuesto3DMSGERROR  = "";
                //if( DDOV_Impuesto3D == null)
                //{
                //    _isCorrect = false;
                //    DDOV_Impuesto3DOK  = false;
                //    DDOV_Impuesto3DMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "DDOV_Impuesto3D", "Detalle Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo DDOV_Impuesto3D" + Environment.NewLine;
                //}
                //DDOV_Impuesto4OK  = true;
                //DDOV_Impuesto4MSGERROR  = "";
                //if( DDOV_Impuesto4 == null)
                //{
                //    _isCorrect = false;
                //    DDOV_Impuesto4OK  = false;
                //    DDOV_Impuesto4MSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "DDOV_Impuesto4", "Detalle Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo DDOV_Impuesto4" + Environment.NewLine;
                //}
                //DDOV_Impuesto4DOK  = true;
                //DDOV_Impuesto4DMSGERROR  = "";
                //if( DDOV_Impuesto4D == null)
                //{
                //    _isCorrect = false;
                //    DDOV_Impuesto4DOK  = false;
                //    DDOV_Impuesto4DMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "DDOV_Impuesto4D", "Detalle Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo DDOV_Impuesto4D" + Environment.NewLine;
                //}
                //DOCV_CodigoOK  = true;
                //DOCV_CodigoMSGERROR  = "";
                //if( DOCV_Codigo == null)
                //{
                //    _isCorrect = false;
                //    DOCV_CodigoOK  = false;
                //    DOCV_CodigoMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "DOCV_Codigo", "Detalle Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo DOCV_Codigo" + Environment.NewLine;
                //}
				SERV_CodigoOK  = true;
				SERV_CodigoMSGERROR  = "";
				if( SERV_Codigo == 0)
				{
					_isCorrect = false;
					SERV_CodigoOK  = false;
					SERV_CodigoMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "Servicio", "Detalle Documento de Venta");
                    m_mensajeError += "* Debe ingresar el campo Servicio" + Environment.NewLine;
				}
                //DDOV_DescripcionOK  = true;
                //DDOV_DescripcionMSGERROR  = "";
                //if( String.IsNullOrEmpty(DDOV_Descripcion) )
                //{
                //    _isCorrect = false;
                //    DDOV_DescripcionOK  = false;
                //    DDOV_DescripcionMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "DDOV_Descripcion", "Detalle Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo DDOV_Descripcion" + Environment.NewLine;
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

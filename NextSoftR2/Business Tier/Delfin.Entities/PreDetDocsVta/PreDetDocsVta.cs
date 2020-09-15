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
	[Serializable()]
	public partial class PreDetDocsVta : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_pddo_item;
		private Decimal m_ddov_cantidad;
		private Decimal m_ddov_preciounitario;
		private Decimal m_ddov_preciounitariod;
		private Decimal m_ddov_valorventa;
		private Decimal m_ddov_valorventad;
		private Decimal m_ddov_impuesto1;
		private Decimal m_ddov_impuesto1d;
		private Decimal m_ddov_impuesto2;
		private Decimal m_ddov_impuesto2d;
		private Decimal m_ddov_impuesto3;
		private Decimal m_ddov_impuesto3d;
		private Decimal m_ddov_impuesto4;
		private Decimal m_ddov_impuesto4d;
		private String m_ddov_notas;
		private Int32 m_docv_codigo;
		private Int32 m_serv_codigo;
		private String m_ddov_descripcion;
		private Nullable<Int32> m_dope_item;
		private Nullable<Int32> m_cope_codigo;
		private Nullable<Int32> m_sope_item;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase PreDetDocsVta.
		/// </summary>
		public PreDetDocsVta()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: PDDO_Item.
		/// </summary>
		[DataMember]
		public Int16 PDDO_Item
		{
			get { return m_pddo_item; }
			set
			{
				if (m_pddo_item != value)
				{
					m_pddo_item = value;
					OnPropertyChanged("PDDO_Item");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DDOV_Cantidad.
		/// </summary>
		[DataMember]
		public Decimal DDOV_Cantidad
		{
			get { return m_ddov_cantidad; }
			set
			{
				if (m_ddov_cantidad != value)
				{
					m_ddov_cantidad = value;
					OnPropertyChanged("DDOV_Cantidad");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DDOV_PrecioUnitario.
		/// </summary>
		[DataMember]
		public Decimal DDOV_PrecioUnitario
		{
			get { return m_ddov_preciounitario; }
			set
			{
				if (m_ddov_preciounitario != value)
				{
					m_ddov_preciounitario = value;
					OnPropertyChanged("DDOV_PrecioUnitario");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DDOV_PrecioUnitarioD.
		/// </summary>
		[DataMember]
		public Decimal DDOV_PrecioUnitarioD
		{
			get { return m_ddov_preciounitariod; }
			set
			{
				if (m_ddov_preciounitariod != value)
				{
					m_ddov_preciounitariod = value;
					OnPropertyChanged("DDOV_PrecioUnitarioD");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DDOV_ValorVenta.
		/// </summary>
		[DataMember]
		public Decimal DDOV_ValorVenta
		{
			get { return m_ddov_valorventa; }
			set
			{
				if (m_ddov_valorventa != value)
				{
					m_ddov_valorventa = value;
					OnPropertyChanged("DDOV_ValorVenta");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DDOV_ValorVentaD.
		/// </summary>
		[DataMember]
		public Decimal DDOV_ValorVentaD
		{
			get { return m_ddov_valorventad; }
			set
			{
				if (m_ddov_valorventad != value)
				{
					m_ddov_valorventad = value;
					OnPropertyChanged("DDOV_ValorVentaD");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DDOV_Impuesto1.
		/// </summary>
		[DataMember]
		public Decimal DDOV_Impuesto1
		{
			get { return m_ddov_impuesto1; }
			set
			{
				if (m_ddov_impuesto1 != value)
				{
					m_ddov_impuesto1 = value;
					OnPropertyChanged("DDOV_Impuesto1");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DDOV_Impuesto1D.
		/// </summary>
		[DataMember]
		public Decimal DDOV_Impuesto1D
		{
			get { return m_ddov_impuesto1d; }
			set
			{
				if (m_ddov_impuesto1d != value)
				{
					m_ddov_impuesto1d = value;
					OnPropertyChanged("DDOV_Impuesto1D");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DDOV_Impuesto2.
		/// </summary>
		[DataMember]
		public Decimal DDOV_Impuesto2
		{
			get { return m_ddov_impuesto2; }
			set
			{
				if (m_ddov_impuesto2 != value)
				{
					m_ddov_impuesto2 = value;
					OnPropertyChanged("DDOV_Impuesto2");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DDOV_Impuesto2D.
		/// </summary>
		[DataMember]
		public Decimal DDOV_Impuesto2D
		{
			get { return m_ddov_impuesto2d; }
			set
			{
				if (m_ddov_impuesto2d != value)
				{
					m_ddov_impuesto2d = value;
					OnPropertyChanged("DDOV_Impuesto2D");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DDOV_Impuesto3.
		/// </summary>
		[DataMember]
		public Decimal DDOV_Impuesto3
		{
			get { return m_ddov_impuesto3; }
			set
			{
				if (m_ddov_impuesto3 != value)
				{
					m_ddov_impuesto3 = value;
					OnPropertyChanged("DDOV_Impuesto3");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DDOV_Impuesto3D.
		/// </summary>
		[DataMember]
		public Decimal DDOV_Impuesto3D
		{
			get { return m_ddov_impuesto3d; }
			set
			{
				if (m_ddov_impuesto3d != value)
				{
					m_ddov_impuesto3d = value;
					OnPropertyChanged("DDOV_Impuesto3D");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DDOV_Impuesto4.
		/// </summary>
		[DataMember]
		public Decimal DDOV_Impuesto4
		{
			get { return m_ddov_impuesto4; }
			set
			{
				if (m_ddov_impuesto4 != value)
				{
					m_ddov_impuesto4 = value;
					OnPropertyChanged("DDOV_Impuesto4");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DDOV_Impuesto4D.
		/// </summary>
		[DataMember]
		public Decimal DDOV_Impuesto4D
		{
			get { return m_ddov_impuesto4d; }
			set
			{
				if (m_ddov_impuesto4d != value)
				{
					m_ddov_impuesto4d = value;
					OnPropertyChanged("DDOV_Impuesto4D");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DDOV_Notas.
		/// </summary>
		[DataMember]
		public String DDOV_Notas
		{
			get { return m_ddov_notas; }
			set
			{
				if (m_ddov_notas != value)
				{
					m_ddov_notas = value;
					OnPropertyChanged("DDOV_Notas");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_Codigo.
		/// </summary>
		[DataMember]
		public Int32 DOCV_Codigo
		{
			get { return m_docv_codigo; }
			set
			{
				if (m_docv_codigo != value)
				{
					m_docv_codigo = value;
					OnPropertyChanged("DOCV_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SERV_Codigo.
		/// </summary>
		[DataMember]
		public Int32 SERV_Codigo
		{
			get { return m_serv_codigo; }
			set
			{
				if (m_serv_codigo != value)
				{
					m_serv_codigo = value;
					OnPropertyChanged("SERV_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DDOV_Descripcion.
		/// </summary>
		[DataMember]
		public String DDOV_Descripcion
		{
			get { return m_ddov_descripcion; }
			set
			{
				if (m_ddov_descripcion != value)
				{
					m_ddov_descripcion = value;
					OnPropertyChanged("DDOV_Descripcion");
				}
			}
		}
		
		
		
		/// <summary>
		/// Gets or sets el valor de: AUDI_UsrCrea.
		/// </summary>
		[DataMember]
		public String AUDI_UsrCrea
		{
			get { return m_audi_usrcrea; }
			set
			{
				if (m_audi_usrcrea != value)
				{
					m_audi_usrcrea = value;
					OnPropertyChanged("AUDI_UsrCrea");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AUDI_FecCrea.
		/// </summary>
		[DataMember]
		public DateTime AUDI_FecCrea
		{
			get { return m_audi_feccrea; }
			set
			{
				if (m_audi_feccrea != value)
				{
					m_audi_feccrea = value;
					OnPropertyChanged("AUDI_FecCrea");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AUDI_UsrMod.
		/// </summary>
		[DataMember]
		public String AUDI_UsrMod
		{
			get { return m_audi_usrmod; }
			set
			{
				if (m_audi_usrmod != value)
				{
					m_audi_usrmod = value;
					OnPropertyChanged("AUDI_UsrMod");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AUDI_FecMod.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> AUDI_FecMod
		{
			get { return m_audi_fecmod; }
			set
			{
				if (m_audi_fecmod != value)
				{
					m_audi_fecmod = value;
					OnPropertyChanged("AUDI_FecMod");
				}
			}
		}
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref PreDetDocsVta Item)
		{
			try
			{
				if (Item == null) { Item = new PreDetDocsVta(); }
				Item.PDDO_Item = this.PDDO_Item;
				Item.DDOV_Cantidad = this.DDOV_Cantidad;
				Item.DDOV_PrecioUnitario = this.DDOV_PrecioUnitario;
				Item.DDOV_PrecioUnitarioD = this.DDOV_PrecioUnitarioD;
				Item.DDOV_ValorVenta = this.DDOV_ValorVenta;
				Item.DDOV_ValorVentaD = this.DDOV_ValorVentaD;
				Item.DDOV_Impuesto1 = this.DDOV_Impuesto1;
				Item.DDOV_Impuesto1D = this.DDOV_Impuesto1D;
				Item.DDOV_Impuesto2 = this.DDOV_Impuesto2;
				Item.DDOV_Impuesto2D = this.DDOV_Impuesto2D;
				Item.DDOV_Impuesto3 = this.DDOV_Impuesto3;
				Item.DDOV_Impuesto3D = this.DDOV_Impuesto3D;
				Item.DDOV_Impuesto4 = this.DDOV_Impuesto4;
				Item.DDOV_Impuesto4D = this.DDOV_Impuesto4D;
				Item.DDOV_Notas = this.DDOV_Notas;
				Item.DOCV_Codigo = this.DOCV_Codigo;
				Item.SERV_Codigo = this.SERV_Codigo;
				Item.DDOV_Descripcion = this.DDOV_Descripcion;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}

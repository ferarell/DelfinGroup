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
	public partial class Det_Direccionamiento : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_ddir_item;
		private Int16 m_ddir_cantidad;
		private Nullable<Boolean> m_ddir_tarja;
		private Nullable<Boolean> m_ddir_rebate;
		private String m_ddir_contenedor;
		private String m_ddir_estado;
		private Int32 m_cdir_codigo;
		private Nullable<Int32> m_pack_codigo;
		private Decimal m_ddir_montotarja;
		private Decimal m_ddir_montorebate;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Det_Direccionamiento.
		/// </summary>
		public Det_Direccionamiento()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: DDIR_Item.
		/// </summary>
		[DataMember]
		public Int32 DDIR_Item
		{
			get { return m_ddir_item; }
			set
			{
				if (m_ddir_item != value)
				{
					m_ddir_item = value;
					OnPropertyChanged("DDIR_Item");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DDIR_Cantidad.
		/// </summary>
		[DataMember]
		public Int16 DDIR_Cantidad
		{
			get { return m_ddir_cantidad; }
			set
			{
				if (m_ddir_cantidad != value)
				{
					m_ddir_cantidad = value;
					OnPropertyChanged("DDIR_Cantidad");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DDIR_Tarja.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> DDIR_Tarja
		{
			get { return m_ddir_tarja; }
			set
			{
				if (m_ddir_tarja != value)
				{
					m_ddir_tarja = value;
					OnPropertyChanged("DDIR_Tarja");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DDIR_Rebate.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> DDIR_Rebate
		{
			get { return m_ddir_rebate; }
			set
			{
				if (m_ddir_rebate != value)
				{
					m_ddir_rebate = value;
					OnPropertyChanged("DDIR_Rebate");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DDIR_Contenedor.
		/// </summary>
		[DataMember]
		public String DDIR_Contenedor
		{
			get { return m_ddir_contenedor; }
			set
			{
				if (m_ddir_contenedor != value)
				{
					m_ddir_contenedor = value;
					OnPropertyChanged("DDIR_Contenedor");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DDIR_Estado.
		/// </summary>
		[DataMember]
		public String DDIR_Estado
		{
			get { return m_ddir_estado; }
			set
			{
				if (m_ddir_estado != value)
				{
					m_ddir_estado = value;
					OnPropertyChanged("DDIR_Estado");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CDIR_Codigo.
		/// </summary>
		[DataMember]
		public Int32 CDIR_Codigo
		{
			get { return m_cdir_codigo; }
			set
			{
				if (m_cdir_codigo != value)
				{
					m_cdir_codigo = value;
					OnPropertyChanged("CDIR_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PACK_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> PACK_Codigo
		{
			get { return m_pack_codigo; }
			set
			{
				if (m_pack_codigo != value)
				{
					m_pack_codigo = value;
					OnPropertyChanged("PACK_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DDIR_MontoTarja.
		/// </summary>
		[DataMember]
		public Decimal DDIR_MontoTarja
		{
			get { return m_ddir_montotarja; }
			set
			{
				if (m_ddir_montotarja != value)
				{
					m_ddir_montotarja = value;
					OnPropertyChanged("DDIR_MontoTarja");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DDIR_MontoRebate.
		/// </summary>
		[DataMember]
		public Decimal DDIR_MontoRebate
		{
			get { return m_ddir_montorebate; }
			set
			{
				if (m_ddir_montorebate != value)
				{
					m_ddir_montorebate = value;
					OnPropertyChanged("DDIR_MontoRebate");
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
		public void CopyTo(ref Det_Direccionamiento Item)
		{
			try
			{
				if (Item == null) { Item = new Det_Direccionamiento(); }
				Item.DDIR_Item = this.DDIR_Item;
				Item.DDIR_Cantidad = this.DDIR_Cantidad;
				Item.DDIR_Tarja = this.DDIR_Tarja;
				Item.DDIR_Rebate = this.DDIR_Rebate;
				Item.DDIR_Contenedor = this.DDIR_Contenedor;
				Item.DDIR_Estado = this.DDIR_Estado;
				Item.CDIR_Codigo = this.CDIR_Codigo;
				Item.PACK_Codigo = this.PACK_Codigo;
				Item.DDIR_MontoTarja = this.DDIR_MontoTarja;
				Item.DDIR_MontoRebate = this.DDIR_MontoRebate;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}

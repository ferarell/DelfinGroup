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
	public partial class Det_Tarjas : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_dtaj_item;
		private String m_dtaj_nrocontenedor;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		private Int32 m_tarj_codigo;
		private Nullable<Int32> m_pack_codigo;
		private String m_cons_tabetj;
		private String m_cons_codetj;
		private Nullable<Boolean> m_dtaj_tarja;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Det_Tarjas.
		/// </summary>
		public Det_Tarjas()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: DTAJ_Item.
		/// </summary>
		[DataMember]
		public Int32 DTAJ_Item
		{
			get { return m_dtaj_item; }
			set
			{
				if (m_dtaj_item != value)
				{
					m_dtaj_item = value;
					OnPropertyChanged("DTAJ_Item");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DTAJ_NroContenedor.
		/// </summary>
		[DataMember]
		public String DTAJ_NroContenedor
		{
			get { return m_dtaj_nrocontenedor; }
			set
			{
				if (m_dtaj_nrocontenedor != value)
				{
					m_dtaj_nrocontenedor = value;
					OnPropertyChanged("DTAJ_NroContenedor");
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
		/// <summary>
		/// Gets or sets el valor de: TARJ_Codigo.
		/// </summary>
		[DataMember]
		public Int32 TARJ_Codigo
		{
			get { return m_tarj_codigo; }
			set
			{
				if (m_tarj_codigo != value)
				{
					m_tarj_codigo = value;
					OnPropertyChanged("TARJ_Codigo");
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
		/// Gets or sets el valor de: CONS_TabETJ.
		/// </summary>
		[DataMember]
		public String CONS_TabETJ
		{
			get { return m_cons_tabetj; }
			set
			{
				if (m_cons_tabetj != value)
				{
					m_cons_tabetj = value;
					OnPropertyChanged("CONS_TabETJ");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodETJ.
		/// </summary>
		[DataMember]
		public String CONS_CodETJ
		{
			get { return m_cons_codetj; }
			set
			{
				if (m_cons_codetj != value)
				{
					m_cons_codetj = value;
					OnPropertyChanged("CONS_CodETJ");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DTAJ_Tarja.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> DTAJ_Tarja
		{
			get { return m_dtaj_tarja; }
			set
			{
				if (m_dtaj_tarja != value)
				{
					m_dtaj_tarja = value;
					OnPropertyChanged("DTAJ_Tarja");
				}
			}
		}
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref Det_Tarjas Item)
		{
			try
			{
				if (Item == null) { Item = new Det_Tarjas(); }
				Item.DTAJ_Item = this.DTAJ_Item;
				Item.DTAJ_NroContenedor = this.DTAJ_NroContenedor;
				Item.TARJ_Codigo = this.TARJ_Codigo;
				Item.PACK_Codigo = this.PACK_Codigo;
				Item.CONS_TabETJ = this.CONS_TabETJ;
				Item.CONS_CodETJ = this.CONS_CodETJ;
				Item.DTAJ_Tarja = this.DTAJ_Tarja;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}

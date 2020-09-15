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
   [KnownType(typeof(MasterBusinessEntity))]
	public partial class Tipos : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private String m_tipo_codtabla;
		private String m_tipo_codtipo;
		private String m_tipo_desc1;
		private String m_tipo_desc2;
		private String m_tipo_descc;
		private Nullable<Decimal> m_tipo_num1;
		private Nullable<Decimal> m_tipo_num2;
		private Nullable<Int16> m_tipo_num3;
		private Nullable<Int16> m_tipo_num4;
		private Nullable<Boolean> m_tipo_activo;
		private String m_tipo_mascara;
		private String m_tipo_codtablahijo;
		private String m_tipo_codtipohijo;
		private String m_tipo_desc3;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Tipos.
		/// </summary>
		public Tipos()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodTabla.
		/// </summary>
		[DataMember]
		public String TIPO_CodTabla
		{
			get { return m_tipo_codtabla; }
			set
			{
				if (m_tipo_codtabla != value)
				{
					m_tipo_codtabla = value;
					OnPropertyChanged("TIPO_CodTabla");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodTipo.
		/// </summary>
		[DataMember]
		public String TIPO_CodTipo
		{
			get { return m_tipo_codtipo; }
			set
			{
				if (m_tipo_codtipo != value)
				{
					m_tipo_codtipo = value;
					OnPropertyChanged("TIPO_CodTipo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_Desc1.
		/// </summary>
		[DataMember]
		public String TIPO_Desc1
		{
			get { return m_tipo_desc1; }
			set
			{
				if (m_tipo_desc1 != value)
				{
					m_tipo_desc1 = value;
					OnPropertyChanged("TIPO_Desc1");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_Desc2.
		/// </summary>
		[DataMember]
		public String TIPO_Desc2
		{
			get { return m_tipo_desc2; }
			set
			{
				if (m_tipo_desc2 != value)
				{
					m_tipo_desc2 = value;
					OnPropertyChanged("TIPO_Desc2");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_DescC.
		/// </summary>
		[DataMember]
		public String TIPO_DescC
		{
			get { return m_tipo_descc; }
			set
			{
				if (m_tipo_descc != value)
				{
					m_tipo_descc = value;
					OnPropertyChanged("TIPO_DescC");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_Num1.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> TIPO_Num1
		{
			get { return m_tipo_num1; }
			set
			{
				if (m_tipo_num1 != value)
				{
					m_tipo_num1 = value;
					OnPropertyChanged("TIPO_Num1");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_Num2.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> TIPO_Num2
		{
			get { return m_tipo_num2; }
			set
			{
				if (m_tipo_num2 != value)
				{
					m_tipo_num2 = value;
					OnPropertyChanged("TIPO_Num2");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_Num3.
		/// </summary>
		[DataMember]
		public Nullable<Int16> TIPO_Num3
		{
			get { return m_tipo_num3; }
			set
			{
				if (m_tipo_num3 != value)
				{
					m_tipo_num3 = value;
					OnPropertyChanged("TIPO_Num3");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_Num4.
		/// </summary>
		[DataMember]
		public Nullable<Int16> TIPO_Num4
		{
			get { return m_tipo_num4; }
			set
			{
				if (m_tipo_num4 != value)
				{
					m_tipo_num4 = value;
					OnPropertyChanged("TIPO_Num4");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_Activo.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> TIPO_Activo
		{
			get { return m_tipo_activo; }
			set
			{
				if (m_tipo_activo != value)
				{
					m_tipo_activo = value;
					OnPropertyChanged("TIPO_Activo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_Mascara.
		/// </summary>
		[DataMember]
		public String TIPO_Mascara
		{
			get { return m_tipo_mascara; }
			set
			{
				if (m_tipo_mascara != value)
				{
					m_tipo_mascara = value;
					OnPropertyChanged("TIPO_Mascara");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodTablaHijo.
		/// </summary>
		[DataMember]
		public String TIPO_CodTablaHijo
		{
			get { return m_tipo_codtablahijo; }
			set
			{
				if (m_tipo_codtablahijo != value)
				{
					m_tipo_codtablahijo = value;
					OnPropertyChanged("TIPO_CodTablaHijo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodTipoHijo.
		/// </summary>
		[DataMember]
		public String TIPO_CodTipoHijo
		{
			get { return m_tipo_codtipohijo; }
			set
			{
				if (m_tipo_codtipohijo != value)
				{
					m_tipo_codtipohijo = value;
					OnPropertyChanged("TIPO_CodTipoHijo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_Desc3.
		/// </summary>
		[DataMember]
		public String TIPO_Desc3
		{
			get { return m_tipo_desc3; }
			set
			{
				if (m_tipo_desc3 != value)
				{
					m_tipo_desc3 = value;
					OnPropertyChanged("TIPO_Desc3");
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
		public void CopyTo(ref Tipos Item)
		{
			try
			{
				if (Item == null) { Item = new Tipos(); }
				Item.TIPO_CodTabla = this.TIPO_CodTabla;
				Item.TIPO_CodTipo = this.TIPO_CodTipo;
				Item.TIPO_Desc1 = this.TIPO_Desc1;
				Item.TIPO_Desc2 = this.TIPO_Desc2;
				Item.TIPO_DescC = this.TIPO_DescC;
				Item.TIPO_Num1 = this.TIPO_Num1;
				Item.TIPO_Num2 = this.TIPO_Num2;
				Item.TIPO_Num3 = this.TIPO_Num3;
				Item.TIPO_Num4 = this.TIPO_Num4;
				Item.TIPO_Activo = this.TIPO_Activo;
				Item.TIPO_Mascara = this.TIPO_Mascara;
				Item.TIPO_CodTablaHijo = this.TIPO_CodTablaHijo;
				Item.TIPO_CodTipoHijo = this.TIPO_CodTipoHijo;
				Item.TIPO_Desc3 = this.TIPO_Desc3;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}

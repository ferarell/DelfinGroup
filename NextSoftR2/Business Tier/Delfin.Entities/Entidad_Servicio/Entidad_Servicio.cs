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
   public partial class Entidad_Servicio : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_eser_codigo;
		private Nullable<Int32> m_serv_codigo;
		private Decimal m_eser_valor;
		private Boolean m_eser_exonerado;
		private Nullable<Int32> m_entc_codigo;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
        private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Entidad_Servicio.
		/// </summary>
		public Entidad_Servicio()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: ESER_Codigo.
		/// </summary>
		[DataMember]
		public Int32 ESER_Codigo
		{
			get { return m_eser_codigo; }
			set
			{
				if (m_eser_codigo != value)
				{
					m_eser_codigo = value;
					OnPropertyChanged("ESER_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SERV_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> SERV_Codigo
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
		/// Gets or sets el valor de: ESER_Valor.
		/// </summary>
		[DataMember]
		public Decimal ESER_Valor
		{
			get { return m_eser_valor; }
			set
			{
				if (m_eser_valor != value)
				{
					m_eser_valor = value;
					OnPropertyChanged("ESER_Valor");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ESER_Exonerado.
		/// </summary>
		[DataMember]
		public Boolean ESER_Exonerado
		{
			get { return m_eser_exonerado; }
			set
			{
				if (m_eser_exonerado != value)
				{
					m_eser_exonerado = value;
					OnPropertyChanged("ESER_Exonerado");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodCliente.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_Codigo
		{
			get { return m_entc_codigo; }
			set
			{
            if (m_entc_codigo != value)
				{
               m_entc_codigo = value;
					OnPropertyChanged("ENTC_CodCliente");
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
		public void CopyTo(ref Entidad_Servicio Item)
		{
			try
			{
				if (Item == null) { Item = new Entidad_Servicio(); }
				Item.ESER_Codigo = this.ESER_Codigo;
				Item.SERV_Codigo = this.SERV_Codigo;
				Item.ESER_Valor = this.ESER_Valor;
				Item.ESER_Exonerado = this.ESER_Exonerado;
				Item.ENTC_Codigo = this.ENTC_Codigo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}

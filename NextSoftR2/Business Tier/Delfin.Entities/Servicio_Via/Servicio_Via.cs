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
	public partial class Servicio_Via : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private String m_cons_tabvia;
		private String m_cons_codvia;
		private Int32 m_serv_codigo;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Servicio_Via.
		/// </summary>
		public Servicio_Via()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CONS_TabVIA.
		/// </summary>
		[DataMember]
		public String CONS_TabVIA
		{
			get { return m_cons_tabvia; }
			set
			{
				if (m_cons_tabvia != value)
				{
					m_cons_tabvia = value;
					OnPropertyChanged("CONS_TabVIA");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodVIA.
		/// </summary>
		[DataMember]
		public String CONS_CodVIA
		{
			get { return m_cons_codvia; }
			set
			{
				if (m_cons_codvia != value)
				{
					m_cons_codvia = value;
					OnPropertyChanged("CONS_CodVIA");
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
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref Servicio_Via Item)
		{
			try
			{
				if (Item == null) { Item = new Servicio_Via(); }
				Item.CONS_TabVIA = this.CONS_TabVIA;
				Item.CONS_CodVIA = this.CONS_CodVIA;
				Item.SERV_Codigo = this.SERV_Codigo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}

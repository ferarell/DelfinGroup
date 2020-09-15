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
	public partial class GRR_Paquetes : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private String m_reba_tipo;
		private Int32 m_reba_codigo;
		private Int32 m_pack_codigo;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase GRR_Paquetes.
		/// </summary>
		public GRR_Paquetes()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: REBA_Tipo.
		/// </summary>
		[DataMember]
		public String REBA_Tipo
		{
			get { return m_reba_tipo; }
			set
			{
				if (m_reba_tipo != value)
				{
					m_reba_tipo = value;
					OnPropertyChanged("REBA_Tipo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: REBA_Codigo.
		/// </summary>
		[DataMember]
		public Int32 REBA_Codigo
		{
			get { return m_reba_codigo; }
			set
			{
				if (m_reba_codigo != value)
				{
					m_reba_codigo = value;
					OnPropertyChanged("REBA_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PACK_Codigo.
		/// </summary>
		[DataMember]
		public Int32 PACK_Codigo
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
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref GRR_Paquetes Item)
		{
			try
			{
				if (Item == null) { Item = new GRR_Paquetes(); }
				Item.REBA_Tipo = this.REBA_Tipo;
				Item.REBA_Codigo = this.REBA_Codigo;
				Item.PACK_Codigo = this.PACK_Codigo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}

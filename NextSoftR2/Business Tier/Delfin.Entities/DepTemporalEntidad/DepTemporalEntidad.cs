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
	public partial class DepTemporalEntidad : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_dete_codigo;
		private Nullable<Int32> m_entc_codlnaviera;
		private Nullable<Int32> m_entc_coddeptemporal;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase DepTemporalEntidad.
		/// </summary>
		public DepTemporalEntidad()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: DETE_Codigo.
		/// </summary>
		[DataMember]
		public Int32 DETE_Codigo
		{
			get { return m_dete_codigo; }
			set
			{
				if (m_dete_codigo != value)
				{
					m_dete_codigo = value;
					OnPropertyChanged("DETE_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodLNaviera.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodLNaviera
		{
			get { return m_entc_codlnaviera; }
			set
			{
				if (m_entc_codlnaviera != value)
				{
					m_entc_codlnaviera = value;
					OnPropertyChanged("ENTC_CodLNaviera");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodDepTemporal.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodDepTemporal
		{
			get { return m_entc_coddeptemporal; }
			set
			{
				if (m_entc_coddeptemporal != value)
				{
					m_entc_coddeptemporal = value;
					OnPropertyChanged("ENTC_CodDepTemporal");
				}
			}
		}
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref DepTemporalEntidad Item)
		{
			try
			{
				if (Item == null) { Item = new DepTemporalEntidad(); }
				Item.DETE_Codigo = this.DETE_Codigo;
				Item.ENTC_CodLNaviera = this.ENTC_CodLNaviera;
				Item.ENTC_CodDepTemporal = this.ENTC_CodDepTemporal;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}

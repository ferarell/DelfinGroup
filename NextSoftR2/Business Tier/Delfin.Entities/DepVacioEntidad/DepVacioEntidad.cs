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
	public partial class DepVacioEntidad : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_deva_codigo;
		private Nullable<Int32> m_entc_codpadre;
		private Nullable<Int32> m_entc_codhijo;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase DepVacioEntidad.
		/// </summary>
		public DepVacioEntidad()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: DEVA_Codigo.
		/// </summary>
		[DataMember]
		public Int32 DEVA_Codigo
		{
			get { return m_deva_codigo; }
			set
			{
				if (m_deva_codigo != value)
				{
					m_deva_codigo = value;
					OnPropertyChanged("DEVA_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodPadre.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodPadre
		{
			get { return m_entc_codpadre; }
			set
			{
				if (m_entc_codpadre != value)
				{
					m_entc_codpadre = value;
					OnPropertyChanged("ENTC_CodPadre");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodHijo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodHijo
		{
			get { return m_entc_codhijo; }
			set
			{
				if (m_entc_codhijo != value)
				{
					m_entc_codhijo = value;
					OnPropertyChanged("ENTC_CodHijo");
				}
			}
		}
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref DepVacioEntidad Item)
		{
			try
			{
				if (Item == null) { Item = new DepVacioEntidad(); }
				Item.DEVA_Codigo = this.DEVA_Codigo;
				Item.ENTC_CodPadre = this.ENTC_CodPadre;
				Item.ENTC_CodHijo = this.ENTC_CodHijo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}

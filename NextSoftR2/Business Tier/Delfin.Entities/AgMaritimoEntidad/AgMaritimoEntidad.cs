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
	public partial class AgMaritimoEntidad : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_agma_codigo;
		private Nullable<Int32> m_entc_codpadre;
		private Nullable<Int32> m_entc_codhijo;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase AgMaritimoEntidad.
		/// </summary>
		public AgMaritimoEntidad()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: AGMA_Codigo.
		/// </summary>
		[DataMember]
		public Int32 AGMA_Codigo
		{
			get { return m_agma_codigo; }
			set
			{
				if (m_agma_codigo != value)
				{
					m_agma_codigo = value;
					OnPropertyChanged("AGMA_Codigo");
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
		public void CopyTo(ref AgMaritimoEntidad Item)
		{
			try
			{
				if (Item == null) { Item = new AgMaritimoEntidad(); }
				Item.AGMA_Codigo = this.AGMA_Codigo;
				Item.ENTC_CodPadre = this.ENTC_CodPadre;
				Item.ENTC_CodHijo = this.ENTC_CodHijo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}

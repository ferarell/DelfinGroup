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
	public partial class FuncionEntidad
	{
		#region [ Variables ]
		Entidad m_itemEntidad;
		ObservableCollection<Entidad> m_listEntidad;
		TiposEntidad m_itemTiposEntidad;
		ObservableCollection<TiposEntidad> m_listTiposEntidad;
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: Entidad.
		/// </summary>
		[DataMember]
		public Entidad ItemEntidad
		{
			get { return  m_itemEntidad; }
			set {  m_itemEntidad = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Entidad.
		/// </summary>
		[DataMember]
		public ObservableCollection<Entidad> ListEntidad
		{
			get { return  m_listEntidad; }
			set {  m_listEntidad = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: TiposEntidad.
		/// </summary>
		[DataMember]
		public TiposEntidad ItemTiposEntidad
		{
			get { return  m_itemTiposEntidad; }
			set {  m_itemTiposEntidad = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: TiposEntidad.
		/// </summary>
		[DataMember]
		public ObservableCollection<TiposEntidad> ListTiposEntidad
		{
			get { return  m_listTiposEntidad; }
			set {  m_listTiposEntidad = value; }
		}
		#endregion
	}
}

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
	public partial class EntidadLimiteCredito
	{
		#region [ Variables ]
		FuncionEntidad m_itemFuncionEntidad;
		ObservableCollection<FuncionEntidad> m_listFuncionEntidad;
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: FuncionEntidad.
		/// </summary>
		[DataMember]
		public FuncionEntidad ItemFuncionEntidad
		{
			get { return  m_itemFuncionEntidad; }
			set {  m_itemFuncionEntidad = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: FuncionEntidad.
		/// </summary>
		[DataMember]
		public ObservableCollection<FuncionEntidad> ListFuncionEntidad
		{
			get { return  m_listFuncionEntidad; }
			set {  m_listFuncionEntidad = value; }
		}
		#endregion
	}
}

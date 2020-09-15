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
	public partial class Contrato
	{
		#region [ Variables ]
		Empresa m_itemEmpresa;
		ObservableCollection<Empresa> m_listEmpresa;
      
      ObservableCollection<Tarifa> m_listTarifa;
      #endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: Empresa.
		/// </summary>
		[DataMember]
		public Empresa ItemEmpresa
		{
			get { return  m_itemEmpresa; }
			set {  m_itemEmpresa = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Empresa.
		/// </summary>
		[DataMember]
		public ObservableCollection<Empresa> ListEmpresa
		{
			get { return  m_listEmpresa; }
			set {  m_listEmpresa = value; }
		}

      /// <summary>
      /// Gets or sets el valor de: ListTarifa.
      /// </summary>
      [DataMember]
      public ObservableCollection<Tarifa> ListTarifa
      {
         get
         {
            if (m_listTarifa == null) { m_listTarifa = new ObservableCollection<Tarifa>(); }
            return m_listTarifa;
         }
         set { m_listTarifa = value; }
      }
      #endregion
	}
}

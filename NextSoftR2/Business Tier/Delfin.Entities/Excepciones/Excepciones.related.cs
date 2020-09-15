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
	public partial class Excepciones
	{
		#region [ Variables ]
		CtaCte m_itemCtaCte;
		ObservableCollection<CtaCte> m_listCtaCte;
		Empresa m_itemEmpresa;
		ObservableCollection<Empresa> m_listEmpresa;
		Entidad m_itemEntidad;
		ObservableCollection<Entidad> m_listEntidad;
		DocsVta m_itemDocsVta;
		ObservableCollection<DocsVta> m_listDocsVta;
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CtaCte.
		/// </summary>
		[DataMember]
		public CtaCte ItemCtaCte
		{
			get { return  m_itemCtaCte; }
			set {  m_itemCtaCte = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: CtaCte.
		/// </summary>
		[DataMember]
		public ObservableCollection<CtaCte> ListCtaCte
		{
			get { return  m_listCtaCte; }
			set {  m_listCtaCte = value; }
		}
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
		/// Gets or sets el valor de: DocsVta.
		/// </summary>
		[DataMember]
		public DocsVta ItemDocsVta
		{
			get { return  m_itemDocsVta; }
			set {  m_itemDocsVta = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: DocsVta.
		/// </summary>
		[DataMember]
		public ObservableCollection<DocsVta> ListDocsVta
		{
			get { return  m_listDocsVta; }
			set {  m_listDocsVta = value; }
		}
		#endregion
	}
}

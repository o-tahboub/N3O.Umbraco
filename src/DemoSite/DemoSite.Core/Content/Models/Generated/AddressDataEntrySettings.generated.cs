//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v12.3.0+c42eb28
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace DemoSite.Content
{
	/// <summary>Address Data Entry Settings</summary>
	[PublishedModel("addressDataEntrySettings")]
	public partial class AddressDataEntrySettings : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.0+c42eb28")]
		public new const string ModelTypeAlias = "addressDataEntrySettings";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.0+c42eb28")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.0+c42eb28")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.0+c42eb28")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<AddressDataEntrySettings, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public AddressDataEntrySettings(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Administrative Area
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.0+c42eb28")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("administrativeArea")]
		public virtual global::DemoSite.Content.AddressField AdministrativeArea => this.Value<global::DemoSite.Content.AddressField>(_publishedValueFallback, "administrativeArea");

		///<summary>
		/// Country
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.0+c42eb28")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("country")]
		public virtual global::DemoSite.Content.AddressField Country => this.Value<global::DemoSite.Content.AddressField>(_publishedValueFallback, "country");

		///<summary>
		/// Default
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.0+c42eb28")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("defaultCountry")]
		public virtual global::DemoSite.Content.Country DefaultCountry => this.Value<global::DemoSite.Content.Country>(_publishedValueFallback, "defaultCountry");

		///<summary>
		/// Line 1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.0+c42eb28")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("line1")]
		public virtual global::DemoSite.Content.AddressField Line1 => this.Value<global::DemoSite.Content.AddressField>(_publishedValueFallback, "line1");

		///<summary>
		/// Line 2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.0+c42eb28")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("line2")]
		public virtual global::DemoSite.Content.AddressField Line2 => this.Value<global::DemoSite.Content.AddressField>(_publishedValueFallback, "line2");

		///<summary>
		/// Line 3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.0+c42eb28")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("line3")]
		public virtual global::DemoSite.Content.AddressField Line3 => this.Value<global::DemoSite.Content.AddressField>(_publishedValueFallback, "line3");

		///<summary>
		/// Locality
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.0+c42eb28")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("locality")]
		public virtual global::DemoSite.Content.AddressField Locality => this.Value<global::DemoSite.Content.AddressField>(_publishedValueFallback, "locality");

		///<summary>
		/// Postal Code
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.0+c42eb28")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("postalCode")]
		public virtual global::DemoSite.Content.AddressField PostalCode => this.Value<global::DemoSite.Content.AddressField>(_publishedValueFallback, "postalCode");
	}
}

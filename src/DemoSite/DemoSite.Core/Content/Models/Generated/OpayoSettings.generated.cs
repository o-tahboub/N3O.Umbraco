//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v12.1.2+9230b25
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
	/// <summary>Opayo Settings</summary>
	[PublishedModel("opayoSettings")]
	public partial class OpayoSettings : PublishedContentModel, IPaymentMethodSettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		public new const string ModelTypeAlias = "opayoSettings";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<OpayoSettings, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public OpayoSettings(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Integration Key
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("productionIntegrationKey")]
		public virtual string ProductionIntegrationKey => this.Value<string>(_publishedValueFallback, "productionIntegrationKey");

		///<summary>
		/// Integration Password
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("productionIntegrationPassword")]
		public virtual string ProductionIntegrationPassword => this.Value<string>(_publishedValueFallback, "productionIntegrationPassword");

		///<summary>
		/// Vendor Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("productionVendorName")]
		public virtual string ProductionVendorName => this.Value<string>(_publishedValueFallback, "productionVendorName");

		///<summary>
		/// Integration Key
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("stagingIntegrationKey")]
		public virtual string StagingIntegrationKey => this.Value<string>(_publishedValueFallback, "stagingIntegrationKey");

		///<summary>
		/// Integration Password
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("stagingIntegrationPassword")]
		public virtual string StagingIntegrationPassword => this.Value<string>(_publishedValueFallback, "stagingIntegrationPassword");

		///<summary>
		/// Vendor Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("stagingVendorName")]
		public virtual string StagingVendorName => this.Value<string>(_publishedValueFallback, "stagingVendorName");

		///<summary>
		/// Restrict Collection Days To
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("restrictCollectionDaysTo")]
		public virtual global::System.Collections.Generic.List<global::N3O.Umbraco.Lookups.DayOfMonth> RestrictCollectionDaysTo => global::DemoSite.Content.PaymentMethodSettings.GetRestrictCollectionDaysTo(this, _publishedValueFallback);

		///<summary>
		/// Transaction Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("transactionDescription")]
		public virtual string TransactionDescription => global::DemoSite.Content.PaymentMethodSettings.GetTransactionDescription(this, _publishedValueFallback);

		///<summary>
		/// Transaction ID
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.1.2+9230b25")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("transactionId")]
		public virtual string TransactionId => global::DemoSite.Content.PaymentMethodSettings.GetTransactionId(this, _publishedValueFallback);
	}
}

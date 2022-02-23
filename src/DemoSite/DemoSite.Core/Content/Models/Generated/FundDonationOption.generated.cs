//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f
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

namespace DemoSite.Core.Content
{
	/// <summary>Fund</summary>
	[PublishedModel("fundDonationOption")]
	public partial class FundDonationOption : PublishedContentModel, IDonationOption
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		public new const string ModelTypeAlias = "fundDonationOption";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<FundDonationOption, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public FundDonationOption(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Donation Item
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("donationItem")]
		public virtual global::DemoSite.Core.Content.DonationItem DonationItem => this.Value<global::DemoSite.Core.Content.DonationItem>(_publishedValueFallback, "donationItem");

		///<summary>
		/// Price Handles
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("donationPriceHandles")]
		public virtual global::System.Collections.Generic.IEnumerable<global::DemoSite.Core.Content.PriceHandle> DonationPriceHandles => this.Value<global::System.Collections.Generic.IEnumerable<global::DemoSite.Core.Content.PriceHandle>>(_publishedValueFallback, "donationPriceHandles");

		///<summary>
		/// Price Handles
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("regularGivingPriceHandles")]
		public virtual global::System.Collections.Generic.IEnumerable<global::DemoSite.Core.Content.PriceHandle> RegularGivingPriceHandles => this.Value<global::System.Collections.Generic.IEnumerable<global::DemoSite.Core.Content.PriceHandle>>(_publishedValueFallback, "regularGivingPriceHandles");

		///<summary>
		/// Location
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dimension1")]
		public virtual global::DemoSite.Core.Content.FundDimension1Value Dimension1 => global::DemoSite.Core.Content.DonationOption.GetDimension1(this, _publishedValueFallback);

		///<summary>
		/// Theme
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dimension2")]
		public virtual global::DemoSite.Core.Content.FundDimension2Value Dimension2 => global::DemoSite.Core.Content.DonationOption.GetDimension2(this, _publishedValueFallback);

		///<summary>
		/// Stipulation
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dimension3")]
		public virtual global::DemoSite.Core.Content.FundDimension3Value Dimension3 => global::DemoSite.Core.Content.DonationOption.GetDimension3(this, _publishedValueFallback);

		///<summary>
		/// Hide
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[ImplementPropertyType("hideDonation")]
		public virtual bool HideDonation => global::DemoSite.Core.Content.DonationOption.GetHideDonation(this, _publishedValueFallback);

		///<summary>
		/// Hide Quantity
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[ImplementPropertyType("hideQuantity")]
		public virtual bool HideQuantity => global::DemoSite.Core.Content.DonationOption.GetHideQuantity(this, _publishedValueFallback);

		///<summary>
		/// Hide
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[ImplementPropertyType("hideRegularGiving")]
		public virtual bool HideRegularGiving => global::DemoSite.Core.Content.DonationOption.GetHideRegularGiving(this, _publishedValueFallback);
	}
}

//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v11.4.0+e52e987
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
	/// <summary>Feedback</summary>
	[PublishedModel("feedbackDonationOption")]
	public partial class FeedbackDonationOption : PublishedContentModel, IDonationOption
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.4.0+e52e987")]
		public new const string ModelTypeAlias = "feedbackDonationOption";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.4.0+e52e987")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.4.0+e52e987")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.4.0+e52e987")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<FeedbackDonationOption, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public FeedbackDonationOption(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Scheme
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.4.0+e52e987")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("scheme")]
		public virtual global::DemoSite.Content.FeedbackScheme Scheme => this.Value<global::DemoSite.Content.FeedbackScheme>(_publishedValueFallback, "scheme");

		///<summary>
		/// Default Giving Type
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.4.0+e52e987")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("defaultGivingType")]
		public virtual global::N3O.Umbraco.Giving.Lookups.GivingType DefaultGivingType => global::DemoSite.Content.DonationOption.GetDefaultGivingType(this, _publishedValueFallback);

		///<summary>
		/// Location
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.4.0+e52e987")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dimension1")]
		public virtual global::DemoSite.Content.FundDimension1Value Dimension1 => global::DemoSite.Content.DonationOption.GetDimension1(this, _publishedValueFallback);

		///<summary>
		/// Theme
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.4.0+e52e987")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dimension2")]
		public virtual global::DemoSite.Content.FundDimension2Value Dimension2 => global::DemoSite.Content.DonationOption.GetDimension2(this, _publishedValueFallback);

		///<summary>
		/// Stipulation
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.4.0+e52e987")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dimension3")]
		public virtual global::DemoSite.Content.FundDimension3Value Dimension3 => global::DemoSite.Content.DonationOption.GetDimension3(this, _publishedValueFallback);

		///<summary>
		/// Hide
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.4.0+e52e987")]
		[ImplementPropertyType("hideDonation")]
		public virtual bool HideDonation => global::DemoSite.Content.DonationOption.GetHideDonation(this, _publishedValueFallback);

		///<summary>
		/// Hide Quantity
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.4.0+e52e987")]
		[ImplementPropertyType("hideQuantity")]
		public virtual bool HideQuantity => global::DemoSite.Content.DonationOption.GetHideQuantity(this, _publishedValueFallback);

		///<summary>
		/// Hide
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.4.0+e52e987")]
		[ImplementPropertyType("hideRegularGiving")]
		public virtual bool HideRegularGiving => global::DemoSite.Content.DonationOption.GetHideRegularGiving(this, _publishedValueFallback);
	}
}
//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v11.4.1+29f8f0b
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
	/// <summary>Get Involved</summary>
	[PublishedModel("getInvolvedPage")]
	public partial class GetInvolvedPage : PublishedContentModel, IPage
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.4.1+29f8f0b")]
		public new const string ModelTypeAlias = "getInvolvedPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.4.1+29f8f0b")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.4.1+29f8f0b")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.4.1+29f8f0b")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<GetInvolvedPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public GetInvolvedPage(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Assets
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.4.1+29f8f0b")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("assets")]
		public virtual global::System.Collections.Generic.IEnumerable<global::DemoSite.Content.PageAssetItem> Assets => global::DemoSite.Content.Page.GetAssets(this, _publishedValueFallback);

		///<summary>
		/// Blocks
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.4.1+29f8f0b")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("blocks")]
		public virtual global::Perplex.ContentBlocks.Rendering.IContentBlocks Blocks => global::DemoSite.Content.Page.GetBlocks(this, _publishedValueFallback);

		///<summary>
		/// Body HTML
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.4.1+29f8f0b")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("bodyHtml")]
		public virtual string BodyHtml => global::DemoSite.Content.Page.GetBodyHtml(this, _publishedValueFallback);

		///<summary>
		/// Inline Styles
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.4.1+29f8f0b")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("css")]
		public virtual string Css => global::DemoSite.Content.Page.GetCss(this, _publishedValueFallback);

		///<summary>
		/// Head HTML
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.4.1+29f8f0b")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headHtml")]
		public virtual string HeadHtml => global::DemoSite.Content.Page.GetHeadHtml(this, _publishedValueFallback);

		///<summary>
		/// Hide From Search Engines
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.4.1+29f8f0b")]
		[ImplementPropertyType("hidePage")]
		public virtual bool HidePage => global::DemoSite.Content.Page.GetHidePage(this, _publishedValueFallback);

		///<summary>
		/// Inline Script
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.4.1+29f8f0b")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("javaScript")]
		public virtual string JavaScript => global::DemoSite.Content.Page.GetJavaScript(this, _publishedValueFallback);

		///<summary>
		/// Title & Meta
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.4.1+29f8f0b")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("titleMeta")]
		public virtual global::N3O.Umbraco.SerpEditor.Models.SerpEntry TitleMeta => global::DemoSite.Content.Page.GetTitleMeta(this, _publishedValueFallback);
	}
}

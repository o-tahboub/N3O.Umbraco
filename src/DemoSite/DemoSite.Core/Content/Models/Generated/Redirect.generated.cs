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
	/// <summary>Redirect</summary>
	[PublishedModel("redirect")]
	public partial class Redirect : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		public new const string ModelTypeAlias = "redirect";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<Redirect, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public Redirect(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Hit Count
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[ImplementPropertyType("hitCount")]
		public virtual int HitCount => this.Value<int>(_publishedValueFallback, "hitCount");

		///<summary>
		/// Last Hit Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[ImplementPropertyType("lastHitDate")]
		public virtual global::System.DateTime LastHitDate => this.Value<global::System.DateTime>(_publishedValueFallback, "lastHitDate");

		///<summary>
		/// Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("linkContent")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent LinkContent => this.Value<global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent>(_publishedValueFallback, "linkContent");

		///<summary>
		/// External URL
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("linkExternalUrl")]
		public virtual string LinkExternalUrl => this.Value<string>(_publishedValueFallback, "linkExternalUrl");

		///<summary>
		/// Temporary
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[ImplementPropertyType("temporary")]
		public virtual bool Temporary => this.Value<bool>(_publishedValueFallback, "temporary");
	}
}

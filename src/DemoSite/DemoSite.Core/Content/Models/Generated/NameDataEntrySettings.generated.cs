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
	/// <summary>Name Data Entry Settings</summary>
	[PublishedModel("nameDataEntrySettings")]
	public partial class NameDataEntrySettings : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		public new const string ModelTypeAlias = "nameDataEntrySettings";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<NameDataEntrySettings, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public NameDataEntrySettings(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Capitalisation
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("firstNameCapitalisation")]
		public virtual global::N3O.Umbraco.Lookups.Capitalisation FirstNameCapitalisation => this.Value<global::N3O.Umbraco.Lookups.Capitalisation>(_publishedValueFallback, "firstNameCapitalisation");

		///<summary>
		/// Help Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("firstNameHelpText")]
		public virtual string FirstNameHelpText => this.Value<string>(_publishedValueFallback, "firstNameHelpText");

		///<summary>
		/// Label
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("firstNameLabel")]
		public virtual string FirstNameLabel => this.Value<string>(_publishedValueFallback, "firstNameLabel");

		///<summary>
		/// Order
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[ImplementPropertyType("firstNameOrder")]
		public virtual int FirstNameOrder => this.Value<int>(_publishedValueFallback, "firstNameOrder");

		///<summary>
		/// Required
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[ImplementPropertyType("firstNameRequired")]
		public virtual bool FirstNameRequired => this.Value<bool>(_publishedValueFallback, "firstNameRequired");

		///<summary>
		/// Capitalisation
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("lastNameCapitalisation")]
		public virtual global::N3O.Umbraco.Lookups.Capitalisation LastNameCapitalisation => this.Value<global::N3O.Umbraco.Lookups.Capitalisation>(_publishedValueFallback, "lastNameCapitalisation");

		///<summary>
		/// Help Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("lastNameHelpText")]
		public virtual string LastNameHelpText => this.Value<string>(_publishedValueFallback, "lastNameHelpText");

		///<summary>
		/// Label
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("lastNameLabel")]
		public virtual string LastNameLabel => this.Value<string>(_publishedValueFallback, "lastNameLabel");

		///<summary>
		/// Order
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[ImplementPropertyType("lastNameOrder")]
		public virtual int LastNameOrder => this.Value<int>(_publishedValueFallback, "lastNameOrder");

		///<summary>
		/// Required
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[ImplementPropertyType("lastNameRequired")]
		public virtual bool LastNameRequired => this.Value<bool>(_publishedValueFallback, "lastNameRequired");

		///<summary>
		/// Help Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("titleHelpText")]
		public virtual string TitleHelpText => this.Value<string>(_publishedValueFallback, "titleHelpText");

		///<summary>
		/// Label
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("titleLabel")]
		public virtual string TitleLabel => this.Value<string>(_publishedValueFallback, "titleLabel");

		///<summary>
		/// Options
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("titleOptions")]
		public virtual global::System.Collections.Generic.IEnumerable<string> TitleOptions => this.Value<global::System.Collections.Generic.IEnumerable<string>>(_publishedValueFallback, "titleOptions");

		///<summary>
		/// Order
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[ImplementPropertyType("titleOrder")]
		public virtual int TitleOrder => this.Value<int>(_publishedValueFallback, "titleOrder");

		///<summary>
		/// Required
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.3.1+3a269ed3293c8e22bd9a546f424402c0a491964f")]
		[ImplementPropertyType("titleRequired")]
		public virtual bool TitleRequired => this.Value<bool>(_publishedValueFallback, "titleRequired");
	}
}

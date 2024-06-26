using N3O.Umbraco.Templates;
using System.Collections.Generic;

namespace DemoSite.Styles;

public class HorizontalAlignment : TemplateStyle {
    public HorizontalAlignment(string id, string name, string cssClass)
        : base(id, name, null, new KeyValuePair<string, object>(nameof(cssClass), cssClass)) { }
    
    public override string Category => "Horizontal Alignment";
    public override string Icon => "icon-tab-key";
}

public class HorizontalAlignments : ITemplateStylesCollection {
    public static readonly HorizontalAlignment Centre = new("centre", "Centre", "text-center");
    public static readonly HorizontalAlignment Left = new("left", "Left", "text-left");
    public static readonly HorizontalAlignment Right = new("right", "Right", "text-right");
}

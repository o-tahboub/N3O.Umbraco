﻿using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;

namespace N3O.Umbraco.Data.DataTypes {
    [DataEditor(DataConstants.PropertyEditorAliases.ImportErrorsViewer,
                "N3O Import Errors Viewer",
                "~/App_Plugins/N3O.Umbraco.Data.ImportErrorsViewer/N3O.Umbraco.Data.ImportErrorsViewer.html",
                HideLabel = false,
                ValueType = "JSON")]
    public class ImportErrorsViewerDataEditor : DataEditor {
        private readonly IIOHelper _ioHelper;
    
        public ImportErrorsViewerDataEditor(IDataValueEditorFactory dataValueEditorFactory, IIOHelper ioHelper)
            : base(dataValueEditorFactory) {
            _ioHelper = ioHelper;
        }

        protected override IConfigurationEditor CreateConfigurationEditor() {
            return new ImportErrorsViewerConfigurationEditor(_ioHelper);
        }
    }
}
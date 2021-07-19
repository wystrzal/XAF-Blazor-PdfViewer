using DevExpress.ExpressApp.Blazor.Editors;
using DevExpress.ExpressApp.Blazor.Editors.Adapters;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using System;

namespace Blazor_PdfViewer.Module.Blazor.Editors.FileDataEditor
{
    [PropertyEditor(typeof(IFileData), false)]
    public class CustomFileDataPropertyEditor : BlazorPropertyEditorBase
    {
        public CustomFileDataPropertyEditor(Type objectType, IModelMemberViewItem model) : base(objectType, model) { }
        protected override IComponentAdapter CreateComponentAdapter() => new FileDataAdapter(new FileDataModel());
    }
}

using System;
using DevExpress.ExpressApp.Blazor.Components.Models;
using DevExpress.Persistent.BaseImpl;

namespace Blazor_PdfViewer.Module.Blazor.Editors.FileDataEditor
{
    public class FileDataModel : ComponentModelBase
    {
        public FileData Value
        {
            get => GetPropertyValue<FileData>();
            set => SetPropertyValue(value);
        }

        public bool ReadOnly
        {
            get => GetPropertyValue<bool>();
            set => SetPropertyValue(value);
        }

        public void SetValueFromUI(FileData value)
        {
            SetPropertyValue(value, notify: false, nameof(Value));
            ValueChanged?.Invoke(this, EventArgs.Empty);
        }
        public event EventHandler ValueChanged;
    }
}
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_PdfViewer.Module.BusinessObjects
{
    [DefaultClassOptions]
    [NavigationItem("Default")]
    [DefaultProperty(nameof(Title))]
    public class PdfViewer : FileAttachmentBase
    {
        public PdfViewer(Session session) : base(session) { }


        string title;

        public string Title
        {
            get => title;
            set => SetPropertyValue(nameof(Title), ref title, value);
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            File = new FileData(Session);
        }
    }
}

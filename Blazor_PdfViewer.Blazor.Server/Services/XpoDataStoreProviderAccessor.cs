using System;
using DevExpress.ExpressApp.Xpo;

namespace Blazor_PdfViewer.Blazor.Server.Services {
    public class XpoDataStoreProviderAccessor {
        public IXpoDataStoreProvider DataStoreProvider { get; set; }
    }
}

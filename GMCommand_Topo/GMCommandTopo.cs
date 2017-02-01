using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Windows.Forms;

using Application = Intergraph.GeoMedia.GeoMedia.Application;

namespace FH.Kaernten.GIS.GeoMedia.Topo.Command
{
    [ComVisible(true)]
    [ProgId("GeoMedia.GMCommandTopo")]
    [Guid("AA20446E-716D-4124-BC1F-2930789F06EA")]

    public class GMCommandTopo
    {
        private Application _gmApp = null;

        public void Initialize(Application gmApp, object gmViewListeners)
        {
            _gmApp = gmApp;
        }

        public void Terminate()
        {
            if (_gmApp != null)
                Marshal.ReleaseComObject(_gmApp);
        }

        public void Activate()
        {
            FormTopo form = new FormTopo(_gmApp);
            form.ShowDialog();
        }

    }
}

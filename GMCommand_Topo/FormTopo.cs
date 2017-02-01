using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FH.Kaernten.GIS.GeoMedia.Utils;
using Application = Intergraph.GeoMedia.GeoMedia.Application;

namespace FH.Kaernten.GIS.GeoMedia.Topo.Command
{
    public partial class FormTopo : Form
    {

        private Application _gmApp = null;
        private bool _nodesChecked = false;
        private bool _edgesChecked = false;
        private bool _facesChecked = false;
        private string _selectedTable = null;

        public FormTopo(Application gmApp)
        {
            InitializeComponent();

            _gmApp = gmApp;

            // user cannot check target features before connection and table are chosen
            cbxEdges.Enabled = false;
            cbxFaces.Enabled = false;
            cbxNodex.Enabled = false;

            // get connections and fill in a combo
            GMConnectionUtils connUtils = new GMConnectionUtils(_gmApp);
            connUtils.FillConnectionComboBox(cboConnection);

            // enable combo with tables, if there are connections
            cboTable.Enabled = cboConnection.Items.Count > 0;

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboConnection_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConvert.Enabled = false;

            this.UncheckAll();

            GMMetadataUtils metaUtils = new GMMetadataUtils(_gmApp);
            //MetadataTableConstants: gmmtPoint 1 Point, gmmtLinear 2 Linear, gmmtAreal 4 Area, gmmtAnySpatial 8 Any Spatial
            metaUtils.FillTableComboBox(cboConnection, cboTable, 4);
            // if there are polygon tables, select the first of them
            if (cboTable.Items.Count > 0)
            {
                cboTable.SelectedIndex = 0;
                cbxEdges.Enabled = true;
                cbxFaces.Enabled = true;
                cbxNodex.Enabled = true;
            }
        }


        private void cboTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UncheckAll();
            _selectedTable = cboTable.SelectedItem as string;
        }

        private void cbxNodex_CheckedChanged(object sender, EventArgs e)
        {
            if (_nodesChecked)
            {
                _nodesChecked = false;
                if (!_edgesChecked && !_facesChecked)
                {
                    btnConvert.Enabled = false;
                }
            }
            else
            {
                _nodesChecked = true;
                btnConvert.Enabled = true;
            }
        }

        private void cbxEdges_CheckedChanged(object sender, EventArgs e)
        {
            if (_edgesChecked)
            {
                _edgesChecked = false;
                if (!_facesChecked && !_nodesChecked)
                {
                    btnConvert.Enabled = false;
                }
            }
            else
            {
                _edgesChecked = true;
                btnConvert.Enabled = true;
            }
        }

        private void cbxFaces_CheckedChanged(object sender, EventArgs e)
        {
            if (_facesChecked)
            {
                _facesChecked = false;
                if (!_edgesChecked && !_nodesChecked)
                {
                    btnConvert.Enabled = false;
                }
            }
            else
            {
                _facesChecked = true;
                btnConvert.Enabled = true;
            }
        }

        private void UncheckAll()
        {
            cbxEdges.Checked = false;
            cbxFaces.Checked = false;
            cbxNodex.Checked = false;
        }

    }
}

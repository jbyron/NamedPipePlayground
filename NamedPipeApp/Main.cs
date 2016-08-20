using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SixthImpulse.NameGenerator;
using static SixthImpulse.NameGenerator.SillyNameGenerator;
using static SixthImpulse.NamedPipeLib.PipeServer;

namespace SixthImpulse.NamedPipeApp {

public partial class Main : Form {

    #region Data Members


    #endregion 

    #region Constructor 
        public Main() {
            InitializeComponent();

            _initControls();
        }

    #endregion

    #region Event Procs

    private void Main_Load(object sender, EventArgs e) {
        return;
    }

    private void btnRandomName_Click(object sender, EventArgs e) {
        _populateRandomPipeNames(cboPipeName);
    }

    private void cboServerName_Leave(object sender, EventArgs e) {
        txtPipeAddr.Text = _buildPipeNameUri();
    }

    private void cboPipeName_Leave(object sender, EventArgs e) {
        txtPipeAddr.Text = _buildPipeNameUri();
    }

    private void cboPipeName_TextUpdate(object sender, EventArgs e) {
        txtPipeAddr.Text = _buildPipeNameUri();
    }

    private void cboPipeName_SelectedIndexChanged(object sender, EventArgs e) {
        txtPipeAddr.Text = _buildPipeNameUri();
    }

    private void cboServerName_SelectedIndexChanged(object sender, EventArgs e) {
        txtPipeAddr.Text = _buildPipeNameUri();
    }

    private void cboServerName_TextUpdate(object sender, EventArgs e) {
        txtPipeAddr.Text = _buildPipeNameUri();
    }

    #endregion

    #region Private Procs

    private string _buildPipeNameUri() {
        return string.Format(@"\\{0}\pipe\{1}", cboServerName.Text, cboPipeName.Text);
    }

    private void _initControls() {
        _populateServerCbo(cboServerName);
        _populateRandomPipeNames(cboPipeName);
        _populatePipeServerStatuses(cboPipeServerStatus);

        _buildPipeNameUri();

        txtCurStatus.Text = "Not Started";

        return;
    }

    private void _populateServerCbo(ComboBox cbo) {
        
        cbo.Items.Clear();
        cbo.Items.Add(new ServerAddress("local", "."));
        cbo.SelectedIndex = 0;

        return;
    }

    private void _populateRandomPipeNames(ComboBox cbo) {
        
        cbo.Items.Clear();
        cbo.Items.AddRange(SillyNameGenerator.getNamesStatic(10)); 
        cbo.SelectedIndex = 0;

        return;
    }

    private void _populatePipeServerStatuses(ComboBox cbo) {
        
        cbo.Items.Clear();
        cbo.Items.Add(new ComboBoxItem<PipeServerStatuses>("NotSet",        PipeServerStatuses.NotSet));
        cbo.Items.Add(new ComboBoxItem<PipeServerStatuses>("Active",        PipeServerStatuses.Active));
        cbo.Items.Add(new ComboBoxItem<PipeServerStatuses>("Not Started",   PipeServerStatuses.NotStarted));

        cbo.Text = "NotSet";

        return;
    }

    #endregion



internal class ComboBoxItem<T> {
    
    internal ComboBoxItem(string displayName, T dataValue) {
        this.displayName = displayName;
        this.dataValue = dataValue;
    }

    internal string displayName { get; set; }

    internal T dataValue { get; set; }

    public override string ToString() {
        return this.displayName;
    }

}

internal class ServerAddress {
    internal ServerAddress(string name, string address) {
        this.name = name;
        this.address = address;
    }

    string name { get; set; }

    string address { get; set; }

    public override string ToString() {
        return this.name;
    }

} // class ServerAddress

} // class Main
}
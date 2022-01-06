using System;
using System.Windows.Forms;
using MainWindow.Model;

namespace MainWindow.View
{
    public partial class MainForm : Form
    {
        private readonly BindingSource _bs, _Diarybs;
        public MainForm()
        {
            InitializeComponent();
            _bs = new BindingSource();
            lbPatientList.DataSource = _bs;
            _bs.DataSource = Storage.Patients;
            _Diarybs = new BindingSource();
            dgwDiary.DataSource = _Diarybs;
            btPatientAdd.Click += onPatientAdd;
            btPatientRemove.Click += onPatientRemove;
            lbPatientList.DoubleClick += OnEditPatientInformation;
            lbPatientList.SelectedIndexChanged += OnIndexChanged;
        }

        private void OnIndexChanged(object sender, EventArgs e)
        {
            _Diarybs.DataSource = Storage.Patients[lbPatientList.SelectedIndex].PatientDiary;
        }

        private void OnEditPatientInformation(object sender, EventArgs e)
        {
            var Patient_Form_025_o = new Form_025_o(lbPatientList.SelectedIndex);
            Patient_Form_025_o.ShowDialog();
            _bs.ResetBindings(true);
        }

        private void onPatientAdd(object sender, EventArgs e)
        {
            var Patient_Form_025_o = new Form_025_o(-1);
            Patient_Form_025_o.ShowDialog();
            _bs.ResetBindings(true);
        }
        private void onPatientRemove(object sender, EventArgs e)
        {
            Storage.Patients.RemoveAt(lbPatientList.SelectedIndex);
            JSONManagement.JSONSerialize(Storage.Patients);
            _bs.ResetBindings(true);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            JSONManagement.JSONDeserialize(Storage.Patients);
            _bs.ResetBindings(true);
        }

    }
}

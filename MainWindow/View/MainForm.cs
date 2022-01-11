using System;
using System.Windows.Forms;
using System.Linq;
using MainWindow.Model;
using System.Collections.Generic;

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
            btPatientAdd.Click += OnPatientAdd;
            btPatientRemove.Click += OnPatientRemove;
            btSave.Click += OnSave;
            lbPatientList.DoubleClick += OnEditPatientInformation;
            lbPatientList.SelectedIndexChanged += OnIndexChanged;
            this.FormClosing += OnApplicationClossing;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            JSONManagement.JSONDeserialize(Storage.Patients);
            _bs.ResetBindings(true);
            _Diarybs.ResetBindings(true);
            if (Storage.Patients.Count > 0)
            {
                lbPatientList.SelectedIndex = 1;
                lbPatientList.SelectedIndex = 0;
            }
        }
        private void OnPatientAdd(object sender, EventArgs e)
        {
            var Patient_Form_025_o = new Form_025_o(-1);
            Patient_Form_025_o.ShowDialog();
            _bs.ResetBindings(true);
        }
        private void OnPatientRemove(object sender, EventArgs e)
        {
            Storage.Patients.RemoveAt(lbPatientList.SelectedIndex);
            JSONManagement.JSONSerialize(Storage.Patients);
            _bs.ResetBindings(true);
        }
        private void OnEditPatientInformation(object sender, EventArgs e)
        {
            var Patient_Form_025_o = new Form_025_o(lbPatientList.SelectedIndex);
            Patient_Form_025_o.ShowDialog();
            _bs.ResetBindings(true);
        }
        private void OnIndexChanged(object sender, EventArgs e)
        {
            AutoClear();
            _Diarybs.DataSource = Storage.Patients[lbPatientList.SelectedIndex].PatientDiary;
            SetDgwSettings();
            JSONManagement.JSONSerialize(Storage.Patients);
        }
        private void OnApplicationClossing(object sender, FormClosingEventArgs e)
        {
            JSONManagement.JSONSerialize(Storage.Patients);
        }
        private void OnSave(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Documents (*.docx)|*.docx";
            sfd.FileName = "PatientDiary.docx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SaveToWord.SaveDataToWord(dgwDiary, sfd.FileName);
            }
        }
        private void AutoClear()
        {
            var Count = Storage.Patients[lbPatientList.SelectedIndex].PatientDiary.Count;
            for (int i = Count - 1; i > 0; i--)
            {
                if (Storage.Patients[lbPatientList.SelectedIndex].PatientDiary[i].ApplicationDate == null &&
                    Storage.Patients[lbPatientList.SelectedIndex].PatientDiary[i].Appointment == null &&
                    Storage.Patients[lbPatientList.SelectedIndex].PatientDiary[i].MainInformation == null &&
                    Storage.Patients[lbPatientList.SelectedIndex].PatientDiary[i].PlaceOfTreatment == null)
                    Storage.Patients[lbPatientList.SelectedIndex].PatientDiary.RemoveAt(i);
            }
        }
        private void SetDgwSettings()
        {
            this.dgwDiary.Columns[0].Width = 80;
            this.dgwDiary.Columns[1].Width = 140;
            this.dgwDiary.Columns[2].Width = 521;
            this.dgwDiary.Columns[3].Width = 100;
            this.dgwDiary.Columns[0].HeaderText = "Дата звернення";
            this.dgwDiary.Columns[1].HeaderText = "Місце проведення лікування:\nполіклініка – 1,\nвдома – 2,\nденний стаціонар – 3,\nстаціонар вдома – 4";
            this.dgwDiary.Columns[2].HeaderText = "Скарги хворого, об’єктивні дані, діагноз, перебіг хвороби";
            this.dgwDiary.Columns[3].HeaderText = "Призначення, підпис лікаря або консультанта";
        }
    }
}

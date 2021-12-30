using System;
using MainWindow.Model;
using System.Windows.Forms;

namespace MainWindow.View
{
    public partial class Form_025_o : Form
    {
        private int Index { get; set; }
        public Form_025_o(int patientNumber)
        {
            InitializeComponent();
            Index = patientNumber;
            if (Index !=-1)
                PatientRead(patientNumber);
            #region event subscriptions 
            this.Load += OnForm_025_oLoad;

            tbEdrpouCode.KeyPress += OnEditingNumericFields;
            tbCardNumber.KeyPress += OnEditingNumericFields;
            tbPatientCode.KeyPress += OnEditingNumericFields;
            tbGender.KeyPress += OnEditingNumericFields;
            tbHomeNumber.KeyPress += OnEditingNumericFields;
            tbWorkNumber.KeyPress += OnEditingNumericFields;
            tbDispensaryGroup.KeyPress += OnEditingNumericFields;
            tbContingent.KeyPress += OnEditingNumericFields;
            tbCertificateNumber.KeyPress += OnEditingNumericFields;

            tbMinistryName.KeyPress += OnEditingLetterFields;
            tbName.KeyPress += OnEditingLetterFields;

            tbCardCreatingDate.KeyPress += OnEditingDateFields;
            tbBirthday.KeyPress += OnEditingDateFields;
            tbRegistered1.KeyPress += OnEditingDateFields;
            tbRegistered2.KeyPress += OnEditingDateFields;
            tbDeregistered1.KeyPress += OnEditingDateFields;
            tbDeregistered2.KeyPress += OnEditingDateFields;

            tbCardCreatingDate.Enter += OnDateInputPrompt;
            tbBirthday.Enter += OnDateInputPrompt;
            tbRegistered1.Enter += OnDateInputPrompt;
            tbRegistered2.Enter += OnDateInputPrompt;
            tbDeregistered1.Enter += OnDateInputPrompt;
            tbDeregistered2.Enter += OnDateInputPrompt;
            btOk.Click += OnOk;
            #endregion
        }

        private void OnForm_025_oLoad(object sender, EventArgs e)
        {
            if (Index == -1)
            {
                tbCardCreatingDate.Text = "дд.мм.гггг";
                tbBirthday.Text = "дд.мм.гггг";
                tbRegistered1.Text = "дд.мм.гггг";
                tbRegistered2.Text = "дд.мм.гггг";
                tbDeregistered1.Text = "дд.мм.гггг";
                tbDeregistered2.Text = "дд.мм.гггг";
                tbCardCreatingDate.ForeColor = System.Drawing.Color.Gray;
                tbBirthday.ForeColor = System.Drawing.Color.Gray;
                tbRegistered1.ForeColor = System.Drawing.Color.Gray;
                tbRegistered2.ForeColor = System.Drawing.Color.Gray;
                tbDeregistered1.ForeColor = System.Drawing.Color.Gray;
                tbDeregistered2.ForeColor = System.Drawing.Color.Gray;
            }
        }
        private void OnDateInputPrompt(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            if (textbox.Text == "дд.мм.гггг")
                textbox.Text = null;
            textbox.ForeColor = System.Drawing.Color.Black;
        }
        private void OnEditingNumericFields(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }
        private void OnEditingLetterFields(object sender, KeyPressEventArgs e)
        {
            var letter = e.KeyChar;
            if (!Char.IsLetter(letter) && letter != 8 && letter != 45 && letter != (char)Keys.Space)
                e.Handled = true;
        }
        private void OnEditingDateFields(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 47)
                e.Handled = true;
        }
        private void OnOk(object sender, EventArgs e)
        {
            if (Index == -1)
                PatientAdd();
            else
                PatientEdit(Index);
            JSONManagement.JSONSerialize(Storage.Patients);
            Close();
        }
        private void PatientAdd ()
        {
            var patientdata = new Form_025()
                .SetMinistryName(tbMinistryName.Text)
                .SetMedicalInstitutionAdress(tbMedicalInstitutionAdress.Text)
                .SetEdrpouCode(tbEdrpouCode.Text)
                .SetDecree(tbDecree.Text)
                .SetCardNumber(tbCardNumber.Text)
                .SetPatientCode(tbPatientCode.Text)
                .SetCardCreatingDate(tbCardCreatingDate.Text)
                .SetName(tbName.Text)
                .SetGender(tbGender.Text)
                .SetBirthday(tbBirthday.Text)
                .SetHomeNumber(tbHomeNumber.Text)
                .SetWorkNumber(tbWorkNumber.Text)
                .SetAdress(tbAdress.Text)
                .SetWorkPlace(tbWorkplace.Text)
                .SetDispensaryGroup(tbDispensaryGroup.Text)
                .SetContingent(tbContingent.Text)
                .SetCertificateNumber(tbCertificateNumber.Text)
                .SetRegistered1(tbRegistered1.Text)
                .SetRegisteredReason1(tbRegisteredReason1.Text)
                .SetDeregistered1(tbDeregistered1.Text)
                .SetDeregisteredReason1(tbDeregisteredReason1.Text)
                .SetRegistered2(tbRegistered2.Text)
                .SetRegisteredReason2(tbRegisteredReason2.Text)
                .SetDeregistered2(tbDeregistered2.Text)
                .SetDeregisteredReason2(tbDeregisteredReason2.Text)
                .SetAddition(tbAddition.Text);
            var patient = new Patient()
                .SetData(patientdata);
            Storage.Patients.Add(patient);
        }
        private void PatientRead(int patientNumber)
        {
            tbMinistryName.Text = Storage.Patients[patientNumber].Data.MinistryName;
            tbMedicalInstitutionAdress.Text = Storage.Patients[patientNumber].Data.MedicalInstitutionAdress;
            tbEdrpouCode.Text = Storage.Patients[patientNumber].Data.EdrpouCode;
            tbDecree.Text = Storage.Patients[patientNumber].Data.Decree;
            tbCardNumber.Text = Storage.Patients[patientNumber].Data.CardNumber.ToString();
            tbPatientCode.Text = Storage.Patients[patientNumber].Data.PatientCode.ToString();
            tbCardCreatingDate.Text = Storage.Patients[patientNumber].Data.CardCreatingDate.ToString("dd/MM/yyyy");
            tbName.Text = Storage.Patients[patientNumber].Data.Name;
            tbGender.Text = Storage.Patients[patientNumber].Data.Gender.ToString();
            tbBirthday.Text = Storage.Patients[patientNumber].Data.Birthday.ToString("dd/MM/yyyy");
            tbHomeNumber.Text = Storage.Patients[patientNumber].Data.HomeNumber;
            tbWorkNumber.Text = Storage.Patients[patientNumber].Data.WorkNumber;
            tbAdress.Text = Storage.Patients[patientNumber].Data.Adress;
            tbWorkplace.Text = Storage.Patients[patientNumber].Data.WorkPlace;
            tbDispensaryGroup.Text = Storage.Patients[patientNumber].Data.DispensaryGroup.ToString();
            tbContingent.Text = Storage.Patients[patientNumber].Data.Contingent.ToString();
            tbCertificateNumber.Text = Storage.Patients[patientNumber].Data.CertificateNumber.ToString();
            tbRegistered1.Text = Storage.Patients[patientNumber].Data.Registered1.ToString("dd/MM/yyyy");
            tbRegisteredReason1.Text = Storage.Patients[patientNumber].Data.RegisteredReason1;
            tbDeregistered1.Text = Storage.Patients[patientNumber].Data.Deregistered1.ToString("dd/MM/yyyy");
            tbDeregisteredReason1.Text = Storage.Patients[patientNumber].Data.DeregisteredReason1;
            tbRegistered2.Text = Storage.Patients[patientNumber].Data.Registered2.ToString("dd/MM/yyyy");
            tbRegisteredReason2.Text = Storage.Patients[patientNumber].Data.RegisteredReason2;
            tbDeregistered2.Text = Storage.Patients[patientNumber].Data.Deregistered2.ToString("dd/MM/yyyy");
            tbDeregisteredReason2.Text = Storage.Patients[patientNumber].Data.DeregisteredReason2;
            tbAddition.Text = Storage.Patients[patientNumber].Data.Addition;
        }
        private void PatientEdit(int patientNumber)
        {
            Storage.Patients[patientNumber].Data.MinistryName = tbMinistryName.Text;
            Storage.Patients[patientNumber].Data.MedicalInstitutionAdress = tbMedicalInstitutionAdress.Text;
            if (!string.IsNullOrWhiteSpace(tbEdrpouCode.Text))
                Storage.Patients[patientNumber].Data.EdrpouCode = tbEdrpouCode.Text;
            Storage.Patients[patientNumber].Data.Decree = tbDecree.Text;
            if (!string.IsNullOrWhiteSpace(tbCardNumber.Text))
                Storage.Patients[patientNumber].Data.CardNumber = int.Parse(tbCardNumber.Text);
            if (!string.IsNullOrWhiteSpace(tbPatientCode.Text))
                Storage.Patients[patientNumber].Data.PatientCode = int.Parse(tbPatientCode.Text);
            if (!string.IsNullOrWhiteSpace(tbCardCreatingDate.Text))
                Storage.Patients[patientNumber].Data.CardCreatingDate = Convert.ToDateTime(tbCardCreatingDate.Text);
            Storage.Patients[patientNumber].Data.Name = tbName.Text;
            if (!string.IsNullOrWhiteSpace(tbGender.Text))
                Storage.Patients[patientNumber].Data.Gender = int.Parse(tbGender.Text);
            if (!string.IsNullOrWhiteSpace(tbBirthday.Text))
                Storage.Patients[patientNumber].Data.Birthday = Convert.ToDateTime(tbBirthday.Text);
            if (!string.IsNullOrWhiteSpace(tbHomeNumber.Text))
                Storage.Patients[patientNumber].Data.HomeNumber = tbHomeNumber.Text;
            if (!string.IsNullOrWhiteSpace(tbWorkNumber.Text))
                Storage.Patients[patientNumber].Data.WorkNumber = tbWorkNumber.Text;
            Storage.Patients[patientNumber].Data.Adress = tbAdress.Text;
            Storage.Patients[patientNumber].Data.WorkPlace = tbWorkplace.Text;
            if (!string.IsNullOrWhiteSpace(tbDispensaryGroup.Text))
                Storage.Patients[patientNumber].Data.DispensaryGroup = int.Parse(tbDispensaryGroup.Text);
            if (!string.IsNullOrWhiteSpace(tbContingent.Text))
                Storage.Patients[patientNumber].Data.Contingent = int.Parse(tbContingent.Text);
            if (string.IsNullOrWhiteSpace(tbCertificateNumber.Text))
                Storage.Patients[patientNumber].Data.CertificateNumber = int.Parse(tbCertificateNumber.Text);
            if (!string.IsNullOrWhiteSpace(tbRegistered1.Text))
                Storage.Patients[patientNumber].Data.Registered1 = Convert.ToDateTime(tbRegistered1.Text);
            Storage.Patients[patientNumber].Data.RegisteredReason1 = tbRegisteredReason1.Text;
            if (!string.IsNullOrWhiteSpace(tbDeregistered1.Text))
                Storage.Patients[patientNumber].Data.Deregistered1 = Convert.ToDateTime(tbDeregistered1.Text);
            Storage.Patients[patientNumber].Data.DeregisteredReason1 = tbDeregisteredReason1.Text;
            if (!string.IsNullOrWhiteSpace(tbRegistered2.Text))
                Storage.Patients[patientNumber].Data.Registered2 = Convert.ToDateTime(tbRegistered2.Text);
            Storage.Patients[patientNumber].Data.RegisteredReason2 = tbRegisteredReason2.Text;
            if (!string.IsNullOrWhiteSpace(tbDeregistered2.Text))
                Storage.Patients[patientNumber].Data.Deregistered2 = Convert.ToDateTime(tbDeregistered2.Text);
            Storage.Patients[patientNumber].Data.DeregisteredReason2 = tbDeregisteredReason2.Text;
            Storage.Patients[patientNumber].Data.Addition = tbAddition.Text;
        }

    }
}

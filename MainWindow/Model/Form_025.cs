using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainWindow.Model
{
    public class Form_025
    {
        public string MinistryName { get; set; }
        public string MedicalInstitutionAdress { get; set; }
        public string EdrpouCode { get; set; }
        public string Decree { get; set; }
        public int CardNumber { get; set; }
        public long PatientCode { get; set; }
        public DateTime CardCreatingDate { get; set; }
        public string Name { get; set; }
        public int Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string HomeNumber { get; set; }
        public string WorkNumber { get; set; }
        public string Adress { get; set; }
        public string WorkPlace { get; set; }
        public int DispensaryGroup { get; set; }
        public int Contingent { get; set; }
        public long CertificateNumber { get; set; }
        public DateTime Registered1 { get; set; }
        public string RegisteredReason1 { get; set; }
        public DateTime Deregistered1 { get; set; }
        public string DeregisteredReason1 { get; set; }
        public DateTime Registered2 { get; set; }
        public string RegisteredReason2 { get; set; }
        public DateTime Deregistered2 { get; set; }
        public string DeregisteredReason2 { get; set; }
        public string Addition { get; set; }
        public Form_025 SetMinistryName(string ministryname)
        {
            MinistryName = ministryname;
            return this;
        }
        public Form_025 SetMedicalInstitutionAdress(string medicalinstitutionadress)
        {
            MedicalInstitutionAdress = medicalinstitutionadress;
            return this;
        }
        public Form_025 SetEdrpouCode(string edrpoucode)
        {
            EdrpouCode = edrpoucode;
            return this;
        }
        public Form_025 SetDecree(string decree)
        {
            Decree = decree;
            return this;
        }
        public Form_025 SetCardNumber(string cardnumber)
        {
            if (string.IsNullOrWhiteSpace(cardnumber))
                return this;
            CardNumber = int.Parse(cardnumber);
            return this;
        }
        public Form_025 SetPatientCode(string patientcode)
        {
            if (string.IsNullOrWhiteSpace(patientcode))
                return this;
            PatientCode = int.Parse(patientcode);
            return this;
        }
        public Form_025 SetCardCreatingDate(string cardcreatingdate)
        {
            if (string.IsNullOrWhiteSpace(cardcreatingdate))
                return this;
            if (cardcreatingdate == "дд.мм.гггг")
                return this;
            CardCreatingDate = Convert.ToDateTime(cardcreatingdate);
            return this;
        }
        public Form_025 SetName(string name)
        {
            Name = name;
            return this;
        }
        public Form_025 SetGender(string gender)
        {
            if (string.IsNullOrWhiteSpace(gender))
                return this;
            Gender = int.Parse(gender);
            return this;
        }
        public Form_025 SetBirthday(string birthday)
        {
            if (string.IsNullOrWhiteSpace(birthday))
                return this;
            if (birthday == "дд.мм.гггг")
                return this;
            Birthday = Convert.ToDateTime(birthday);
            return this;
        }
        public Form_025 SetHomeNumber(string homenumber)
        {
            HomeNumber = homenumber;
            return this;
        }
        public Form_025 SetWorkNumber(string worknumber)
        {
            WorkNumber = worknumber;
            return this;
        }
        public Form_025 SetAdress(string adress)
        {
            Adress = adress;
            return this;
        }
        public Form_025 SetWorkPlace(string workplace)
        {
            WorkPlace = workplace;
            return this;
        }
        public Form_025 SetDispensaryGroup(string dispensarygroup)
        {
            if (string.IsNullOrWhiteSpace(dispensarygroup))
                return this;
            DispensaryGroup = int.Parse(dispensarygroup);
            return this;
        }
        public Form_025 SetContingent(string contingent)
        {
            if (string.IsNullOrWhiteSpace(contingent))
                return this;
            Contingent = int.Parse(contingent);
            return this;
        }
        public Form_025 SetCertificateNumber(string certificatenumber)
        {
            if (string.IsNullOrWhiteSpace(certificatenumber))
                return this;
            CertificateNumber = int.Parse(certificatenumber);
            return this;
        }
        public Form_025 SetRegistered1(string registered1)
        {
            if (string.IsNullOrWhiteSpace(registered1))
                return this;
            if (registered1 == "дд.мм.гггг")
                return this;
            Registered1 = Convert.ToDateTime(registered1);
            return this;
        }
        public Form_025 SetRegisteredReason1(string registeredreason1)
        {
            RegisteredReason1 = registeredreason1;
            return this;
        }
        public Form_025 SetDeregistered1(string deregistered1)
        {
            if (string.IsNullOrWhiteSpace(deregistered1))
                return this;
            if (deregistered1 == "дд.мм.гггг")
                return this;
            Deregistered1 = Convert.ToDateTime(deregistered1);
            return this;
        }
        public Form_025 SetDeregisteredReason1(string deregisteredreason1)
        {
            DeregisteredReason1 = deregisteredreason1;
            return this;
        }
        public Form_025 SetRegistered2(string registered2)
        {
            if (string.IsNullOrWhiteSpace(registered2))
                return this;
            if (registered2 == "дд.мм.гггг")
                return this;
            Registered2 = Convert.ToDateTime(registered2);
            return this;
        }
        public Form_025 SetRegisteredReason2(string registeredreason2)
        {
            RegisteredReason2 = registeredreason2;
            return this;
        }
        public Form_025 SetDeregistered2(string deregistered2)
        {
            if (string.IsNullOrWhiteSpace(deregistered2))
                return this;
            if (deregistered2 == "дд.мм.гггг")
                return this;
            Deregistered2 = Convert.ToDateTime(deregistered2);
            return this;
        }
        public Form_025 SetDeregisteredReason2(string deregisteredreason2)
        {
            DeregisteredReason2 = deregisteredreason2;
            return this;
        }
        public Form_025 SetAddition(string addition)
        {
            Addition = addition;
            return this;
        }
    }

}

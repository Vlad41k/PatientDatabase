using System;
using System.Collections.Generic;

namespace MainWindow.Model
{
    public static class Storage
    {
        public static readonly List<Patient> Patients;
        static Storage()
        {
            Patients = new List<Patient>();
        }

    }
}
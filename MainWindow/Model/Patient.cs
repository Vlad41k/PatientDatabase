using System;
using System.Collections.Generic;

namespace MainWindow.Model
{
    public class Patient
    {
        public Form_025 Data { get; set; }
        public List<Diary> PatientDiary { get; set; }
        public Patient SetData (Form_025 data)
        {
            Data = data;
            return this;
        }
        public override string ToString() => $"{Data.Name}";
    }
}
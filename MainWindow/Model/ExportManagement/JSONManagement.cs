using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace MainWindow.Model
{
    class JSONManagement
    {
        public static void JSONSerialize(List<Patient> storage)
        {
            using (var file = new FileStream("patients.json", FileMode.OpenOrCreate))
            {
                file.Close();
                string json = JsonSerializer.Serialize(storage,
                    new JsonSerializerOptions()
                    {
                        WriteIndented = true,
                        IncludeFields = true,
                    });
                File.WriteAllText("patients.json", json);
            }
        }
        public static void JSONDeserialize(List<Patient> storage)
        {
            using (var file = new FileStream("patients.json", FileMode.Open))
            {
                file.Close();
                string json = File.ReadAllText("patients.json");
                Storage.Patients.AddRange (JsonSerializer.Deserialize<List<Patient>>(json,
                    new JsonSerializerOptions()
                    {
                        WriteIndented = true,
                        IncludeFields = true
                    }));
            }
        }
    }
}

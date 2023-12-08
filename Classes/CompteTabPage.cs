using System;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;
using System.Linq;

namespace DevNatifM2.Classes
{
    internal class CompteTabPage
    {
        private TextBox tbPrenom;
        private TextBox tbNom;
        private Button btnEnregistrer;
        private string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "persistance", "compte.json");

        public CompteTabPage(TabPage tabPage)
        {
            tbPrenom = tabPage.Controls.Find("tbPrenom", true).FirstOrDefault() as TextBox;
            tbNom = tabPage.Controls.Find("tbNom", true).FirstOrDefault() as TextBox;

            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                var savedData = JsonSerializer.Deserialize<CompteData>(jsonData);
                tbPrenom.Text = savedData.Prenom;
                tbNom.Text = savedData.Nom;
            }

            btnEnregistrer = tabPage.Controls.Find("btnEnregistrer", true).FirstOrDefault() as Button;
            btnEnregistrer.Click += btnEnregistrer_Click;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            var dataToSave = new CompteData
            {
                Prenom = tbPrenom.Text,
                Nom = tbNom.Text
            };

            string jsonDirectory = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(jsonDirectory))
            {
                Directory.CreateDirectory(jsonDirectory); 
            }

            string jsonData = JsonSerializer.Serialize(dataToSave);
            File.WriteAllText(filePath, jsonData);

            MessageBox.Show("Les données ont été enregistrées avec succès.", "Enregistrement réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

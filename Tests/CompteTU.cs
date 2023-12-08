using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DevNatifM2.Tests
{
    internal class CompteTU
    {
        private TabControl tabControl;
        private TabPage tabCompte;
        private Classes.CompteTabPage compteTabPage;

        [SetUp]
        public void Setup()
        {
            tabControl = new TabControl();
            tabCompte = new TabPage();

            TextBox tbPrenom = new TextBox();
            tbPrenom.Name = "tbPrenom";
            TextBox tbNom = new TextBox();
            tbNom.Name = "tbNom";
            Button btnEnregistrer = new Button();
            btnEnregistrer.Name = "btnEnregistrer";

            tabCompte.Controls.Add(tbPrenom);
            tabCompte.Controls.Add(tbNom);
            tabCompte.Controls.Add(btnEnregistrer);

            tabControl.TabPages.Add(tabCompte);

            compteTabPage = new Classes.CompteTabPage(tabCompte);
        }

        [Test]
        public void Enregistrer_DonneesDansFichier_EnregistrementReussi()
        {
            string testFilePath = Path.Combine(Path.GetTempPath(), "test_compte.json");
            string prenomAttendu = "John";
            string nomAttendu = "Doe";

            tabCompte.Controls["tbPrenom"].Text = prenomAttendu;
            tabCompte.Controls["tbNom"].Text = nomAttendu;

            (tabCompte.Controls["btnEnregistrer"] as Button).PerformClick();

            Assert.That(File.Exists(testFilePath), Is.True, "Le fichier JSON n'a pas été créé.");
            string jsonData = File.ReadAllText(testFilePath);
            var savedData = System.Text.Json.JsonSerializer.Deserialize<Classes.CompteData>(jsonData);

            Assert.That(savedData, Is.Not.Null, "Les données n'ont pas été correctement enregistrées.");

            Assert.That(prenomAttendu, Is.EqualTo(savedData.Prenom), "Le prénom enregistré ne correspond pas.");
            Assert.That(nomAttendu, Is.EqualTo(savedData.Nom), "Le nom enregistré ne correspond pas.");

            if (File.Exists(testFilePath))
            {
                File.Delete(testFilePath);
            }
        }
    }
}

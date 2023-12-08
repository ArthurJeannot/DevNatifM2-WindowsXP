namespace DevNatifM2
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.TabControl();
            this.tabCamera = new System.Windows.Forms.TabPage();
            this.btnPicture = new System.Windows.Forms.Button();
            this.cbCameraList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCamera = new System.Windows.Forms.Button();
            this.picCamera = new System.Windows.Forms.PictureBox();
            this.tabLocalisation = new System.Windows.Forms.TabPage();
            this.btnGeo = new System.Windows.Forms.Button();
            this.wbMap = new System.Windows.Forms.WebBrowser();
            this.lbLocalisation = new System.Windows.Forms.Label();
            this.tabMicro = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cbListMicro = new System.Windows.Forms.ComboBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.tabCompte = new System.Windows.Forms.TabPage();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.tabCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).BeginInit();
            this.tabLocalisation.SuspendLayout();
            this.tabMicro.SuspendLayout();
            this.tabCompte.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Controls.Add(this.tabCamera);
            this.menu.Controls.Add(this.tabLocalisation);
            this.menu.Controls.Add(this.tabMicro);
            this.menu.Controls.Add(this.tabCompte);
            this.menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.SelectedIndex = 0;
            this.menu.Size = new System.Drawing.Size(595, 408);
            this.menu.TabIndex = 0;
            this.menu.SelectedIndexChanged += new System.EventHandler(this.menu_SelectedIndexChanged);
            // 
            // tabCamera
            // 
            this.tabCamera.Controls.Add(this.btnPicture);
            this.tabCamera.Controls.Add(this.cbCameraList);
            this.tabCamera.Controls.Add(this.label1);
            this.tabCamera.Controls.Add(this.btnCamera);
            this.tabCamera.Controls.Add(this.picCamera);
            this.tabCamera.Location = new System.Drawing.Point(4, 22);
            this.tabCamera.Name = "tabCamera";
            this.tabCamera.Padding = new System.Windows.Forms.Padding(3);
            this.tabCamera.Size = new System.Drawing.Size(587, 382);
            this.tabCamera.TabIndex = 0;
            this.tabCamera.Text = "Caméra";
            this.tabCamera.UseVisualStyleBackColor = true;
            // 
            // btnPicture
            // 
            this.btnPicture.Enabled = false;
            this.btnPicture.Location = new System.Drawing.Point(470, 322);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(109, 23);
            this.btnPicture.TabIndex = 4;
            this.btnPicture.Text = "Prendre une photo";
            this.btnPicture.UseVisualStyleBackColor = true;
            // 
            // cbCameraList
            // 
            this.cbCameraList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCameraList.FormattingEnabled = true;
            this.cbCameraList.Location = new System.Drawing.Point(78, 324);
            this.cbCameraList.Name = "cbCameraList";
            this.cbCameraList.Size = new System.Drawing.Size(221, 21);
            this.cbCameraList.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Caméra :";
            // 
            // btnCamera
            // 
            this.btnCamera.Location = new System.Drawing.Point(320, 322);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(75, 23);
            this.btnCamera.TabIndex = 1;
            this.btnCamera.Text = "Allumer";
            this.btnCamera.UseVisualStyleBackColor = true;
            // 
            // picCamera
            // 
            this.picCamera.Location = new System.Drawing.Point(8, 6);
            this.picCamera.Name = "picCamera";
            this.picCamera.Size = new System.Drawing.Size(571, 288);
            this.picCamera.TabIndex = 0;
            this.picCamera.TabStop = false;
            // 
            // tabLocalisation
            // 
            this.tabLocalisation.Controls.Add(this.btnGeo);
            this.tabLocalisation.Controls.Add(this.wbMap);
            this.tabLocalisation.Controls.Add(this.lbLocalisation);
            this.tabLocalisation.Location = new System.Drawing.Point(4, 22);
            this.tabLocalisation.Name = "tabLocalisation";
            this.tabLocalisation.Padding = new System.Windows.Forms.Padding(3);
            this.tabLocalisation.Size = new System.Drawing.Size(587, 382);
            this.tabLocalisation.TabIndex = 1;
            this.tabLocalisation.Text = "Géolocalisation";
            this.tabLocalisation.UseVisualStyleBackColor = true;
            // 
            // btnGeo
            // 
            this.btnGeo.Location = new System.Drawing.Point(403, 8);
            this.btnGeo.Name = "btnGeo";
            this.btnGeo.Size = new System.Drawing.Size(142, 27);
            this.btnGeo.TabIndex = 2;
            this.btnGeo.Text = "Chercher (C\'est pété !)";
            this.btnGeo.UseVisualStyleBackColor = true;
            // 
            // wbMap
            // 
            this.wbMap.Location = new System.Drawing.Point(0, 45);
            this.wbMap.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMap.Name = "wbMap";
            this.wbMap.Size = new System.Drawing.Size(587, 341);
            this.wbMap.TabIndex = 1;
            // 
            // lbLocalisation
            // 
            this.lbLocalisation.AutoSize = true;
            this.lbLocalisation.Location = new System.Drawing.Point(8, 15);
            this.lbLocalisation.Name = "lbLocalisation";
            this.lbLocalisation.Size = new System.Drawing.Size(344, 13);
            this.lbLocalisation.TabIndex = 0;
            this.lbLocalisation.Text = "Veuillez activer la géolocalisation dans les paramètres de votre appareil.";
            // 
            // tabMicro
            // 
            this.tabMicro.Controls.Add(this.label2);
            this.tabMicro.Controls.Add(this.cbListMicro);
            this.tabMicro.Controls.Add(this.btnRecord);
            this.tabMicro.Location = new System.Drawing.Point(4, 22);
            this.tabMicro.Name = "tabMicro";
            this.tabMicro.Padding = new System.Windows.Forms.Padding(3);
            this.tabMicro.Size = new System.Drawing.Size(587, 382);
            this.tabMicro.TabIndex = 2;
            this.tabMicro.Text = "Micro";
            this.tabMicro.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Micro";
            // 
            // cbListMicro
            // 
            this.cbListMicro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListMicro.FormattingEnabled = true;
            this.cbListMicro.Location = new System.Drawing.Point(100, 185);
            this.cbListMicro.Name = "cbListMicro";
            this.cbListMicro.Size = new System.Drawing.Size(169, 21);
            this.cbListMicro.TabIndex = 4;
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(344, 168);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(110, 38);
            this.btnRecord.TabIndex = 1;
            this.btnRecord.Text = "Activer la répétition";
            this.btnRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecord.UseVisualStyleBackColor = true;
            // 
            // tabCompte
            // 
            this.tabCompte.Controls.Add(this.btnEnregistrer);
            this.tabCompte.Controls.Add(this.tbNom);
            this.tabCompte.Controls.Add(this.tbPrenom);
            this.tabCompte.Controls.Add(this.label4);
            this.tabCompte.Controls.Add(this.label3);
            this.tabCompte.Location = new System.Drawing.Point(4, 22);
            this.tabCompte.Name = "tabCompte";
            this.tabCompte.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompte.Size = new System.Drawing.Size(587, 382);
            this.tabCompte.TabIndex = 3;
            this.tabCompte.Text = "Compte";
            this.tabCompte.UseVisualStyleBackColor = true;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(208, 186);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(227, 20);
            this.tbNom.TabIndex = 3;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(208, 134);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(227, 20);
            this.tbPrenom.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nom";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(255, 263);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 4;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 408);
            this.Controls.Add(this.menu);
            this.Name = "MainForm";
            this.Text = "Retour vers le Windows XP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menu.ResumeLayout(false);
            this.tabCamera.ResumeLayout(false);
            this.tabCamera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).EndInit();
            this.tabLocalisation.ResumeLayout(false);
            this.tabLocalisation.PerformLayout();
            this.tabMicro.ResumeLayout(false);
            this.tabMicro.PerformLayout();
            this.tabCompte.ResumeLayout(false);
            this.tabCompte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menu;
        private System.Windows.Forms.TabPage tabCamera;
        private System.Windows.Forms.TabPage tabLocalisation;
        private System.Windows.Forms.TabPage tabMicro;
        private System.Windows.Forms.TabPage tabCompte;
        private System.Windows.Forms.PictureBox picCamera;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.ComboBox cbCameraList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLocalisation;
        private System.Windows.Forms.WebBrowser wbMap;
        private System.Windows.Forms.Button btnGeo;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbListMicro;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Button btnEnregistrer;
    }
}


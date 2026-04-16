namespace Banka_Balon
{
    partial class Form_Hlavni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_upravitKlienta = new System.Windows.Forms.Button();
            this.btn_odstranKlienta = new System.Windows.Forms.Button();
            this.btn_pridejKlienta = new System.Windows.Forms.Button();
            this.listbox_klient = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_upravitKlienta);
            this.groupBox1.Controls.Add(this.btn_odstranKlienta);
            this.groupBox1.Controls.Add(this.btn_pridejKlienta);
            this.groupBox1.Controls.Add(this.listbox_klient);
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 596);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klient";
            // 
            // btn_upravitKlienta
            // 
            this.btn_upravitKlienta.Location = new System.Drawing.Point(6, 531);
            this.btn_upravitKlienta.Name = "btn_upravitKlienta";
            this.btn_upravitKlienta.Size = new System.Drawing.Size(181, 24);
            this.btn_upravitKlienta.TabIndex = 3;
            this.btn_upravitKlienta.Text = "Upravit klienta";
            this.btn_upravitKlienta.UseVisualStyleBackColor = true;
            this.btn_upravitKlienta.Click += new System.EventHandler(this.btn_upravitKlienta_Click_1);
            // 
            // btn_odstranKlienta
            // 
            this.btn_odstranKlienta.Location = new System.Drawing.Point(6, 501);
            this.btn_odstranKlienta.Name = "btn_odstranKlienta";
            this.btn_odstranKlienta.Size = new System.Drawing.Size(181, 24);
            this.btn_odstranKlienta.TabIndex = 2;
            this.btn_odstranKlienta.Text = "Odstranit klienta";
            this.btn_odstranKlienta.UseVisualStyleBackColor = true;
            this.btn_odstranKlienta.Click += new System.EventHandler(this.btn_odstranKlienta_Click_1);
            // 
            // btn_pridejKlienta
            // 
            this.btn_pridejKlienta.Location = new System.Drawing.Point(5, 471);
            this.btn_pridejKlienta.Name = "btn_pridejKlienta";
            this.btn_pridejKlienta.Size = new System.Drawing.Size(181, 24);
            this.btn_pridejKlienta.TabIndex = 1;
            this.btn_pridejKlienta.Text = "Přidat klienta";
            this.btn_pridejKlienta.UseVisualStyleBackColor = true;
            this.btn_pridejKlienta.Click += new System.EventHandler(this.btn_pridejKlienta_Click_1);
            // 
            // listbox_klient
            // 
            this.listbox_klient.FormattingEnabled = true;
            this.listbox_klient.Location = new System.Drawing.Point(6, 15);
            this.listbox_klient.Name = "listbox_klient";
            this.listbox_klient.Size = new System.Drawing.Size(154, 433);
            this.listbox_klient.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Účet klienta";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form_Hlavni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Hlavni";
            this.Text = "Form_Hlavni";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_upravitKlienta;
        private System.Windows.Forms.Button btn_odstranKlienta;
        private System.Windows.Forms.Button btn_pridejKlienta;
        private System.Windows.Forms.ListBox listbox_klient;
        private System.Windows.Forms.Button button1;
    }
}


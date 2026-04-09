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
            this.button_custom = new System.Windows.Forms.Button();
            this.button_Del = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.listbox_klient = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_custom);
            this.groupBox1.Controls.Add(this.button_Del);
            this.groupBox1.Controls.Add(this.button_Add);
            this.groupBox1.Controls.Add(this.listbox_klient);
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 564);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klient";
            // 
            // button_custom
            // 
            this.button_custom.Location = new System.Drawing.Point(6, 531);
            this.button_custom.Name = "button_custom";
            this.button_custom.Size = new System.Drawing.Size(181, 24);
            this.button_custom.TabIndex = 3;
            this.button_custom.Text = "Upravit klienta";
            this.button_custom.UseVisualStyleBackColor = true;
            this.button_custom.Click += new System.EventHandler(this.button_custom_Click);
            // 
            // button_Del
            // 
            this.button_Del.Location = new System.Drawing.Point(6, 501);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(181, 24);
            this.button_Del.TabIndex = 2;
            this.button_Del.Text = "Odstranit klienta";
            this.button_Del.UseVisualStyleBackColor = true;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(5, 471);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(181, 24);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "Přidat klienta";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // listbox_klient
            // 
            this.listbox_klient.FormattingEnabled = true;
            this.listbox_klient.Location = new System.Drawing.Point(6, 15);
            this.listbox_klient.Name = "listbox_klient";
            this.listbox_klient.Size = new System.Drawing.Size(154, 433);
            this.listbox_klient.TabIndex = 0;
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
        private System.Windows.Forms.Button button_custom;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.ListBox listbox_klient;
    }
}


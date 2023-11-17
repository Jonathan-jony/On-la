namespace Onela
{
    partial class Form1
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
            this.label_contacts = new System.Windows.Forms.Label();
            this.TextBox_search = new System.Windows.Forms.RichTextBox();
            this.button_addContacts = new System.Windows.Forms.Button();
            this.pictureBox_user = new System.Windows.Forms.PictureBox();
            this.label_user = new System.Windows.Forms.Label();
            this.button_userIMG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).BeginInit();
            this.SuspendLayout();
            // 
            // label_contacts
            // 
            this.label_contacts.AutoSize = true;
            this.label_contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contacts.Location = new System.Drawing.Point(12, 9);
            this.label_contacts.Name = "label_contacts";
            this.label_contacts.Size = new System.Drawing.Size(82, 24);
            this.label_contacts.TabIndex = 1;
            this.label_contacts.Text = "Contacts";
            // 
            // TextBox_search
            // 
            this.TextBox_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_search.Location = new System.Drawing.Point(16, 36);
            this.TextBox_search.Name = "TextBox_search";
            this.TextBox_search.Size = new System.Drawing.Size(271, 28);
            this.TextBox_search.TabIndex = 2;
            this.TextBox_search.Text = "🔍 Recherche";
            // 
            // button_addContacts
            // 
            this.button_addContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addContacts.Location = new System.Drawing.Point(264, 6);
            this.button_addContacts.Name = "button_addContacts";
            this.button_addContacts.Size = new System.Drawing.Size(23, 24);
            this.button_addContacts.TabIndex = 3;
            this.button_addContacts.Tag = "";
            this.button_addContacts.Text = "➕";
            this.button_addContacts.UseVisualStyleBackColor = true;
            this.button_addContacts.Click += new System.EventHandler(this.button_addContacts_Click);
            // 
            // pictureBox_user
            // 
            this.pictureBox_user.Location = new System.Drawing.Point(16, 89);
            this.pictureBox_user.Name = "pictureBox_user";
            this.pictureBox_user.Size = new System.Drawing.Size(49, 39);
            this.pictureBox_user.TabIndex = 4;
            this.pictureBox_user.TabStop = false;
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.Location = new System.Drawing.Point(71, 89);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(28, 15);
            this.label_user.TabIndex = 5;
            this.label_user.Text = "Moi";
            // 
            // button_userIMG
            // 
            this.button_userIMG.Location = new System.Drawing.Point(71, 106);
            this.button_userIMG.Name = "button_userIMG";
            this.button_userIMG.Size = new System.Drawing.Size(53, 22);
            this.button_userIMG.TabIndex = 6;
            this.button_userIMG.Text = "Modifier";
            this.button_userIMG.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 560);
            this.Controls.Add(this.button_userIMG);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.pictureBox_user);
            this.Controls.Add(this.button_addContacts);
            this.Controls.Add(this.TextBox_search);
            this.Controls.Add(this.label_contacts);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_contacts;
        private System.Windows.Forms.RichTextBox TextBox_search;
        private System.Windows.Forms.Button button_addContacts;
        private System.Windows.Forms.PictureBox pictureBox_user;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Button button_userIMG;
    }
}


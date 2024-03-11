namespace Dolgozat0311
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox_Tagok = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1_Id = new System.Windows.Forms.TextBox();
            this.numericUpDown1_Ratings = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1_Entry = new System.Windows.Forms.DateTimePicker();
            this.textBox_fullname = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Értékelés = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Read = new System.Windows.Forms.Button();
            this.button_Create = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_Ratings)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(436, 222);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(8, 4);
            this.listBox1.TabIndex = 0;
            // 
            // listBox_Tagok
            // 
            this.listBox_Tagok.FormattingEnabled = true;
            this.listBox_Tagok.ItemHeight = 16;
            this.listBox_Tagok.Location = new System.Drawing.Point(0, 1);
            this.listBox_Tagok.Name = "listBox_Tagok";
            this.listBox_Tagok.Size = new System.Drawing.Size(157, 452);
            this.listBox_Tagok.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Értékelés);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Id);
            this.groupBox1.Controls.Add(this.textBox_fullname);
            this.groupBox1.Controls.Add(this.dateTimePicker1_Entry);
            this.groupBox1.Controls.Add(this.numericUpDown1_Ratings);
            this.groupBox1.Controls.Add(this.textBox1_Id);
            this.groupBox1.Location = new System.Drawing.Point(190, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 274);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBox1_Id
            // 
            this.textBox1_Id.Enabled = false;
            this.textBox1_Id.Location = new System.Drawing.Point(43, 53);
            this.textBox1_Id.Name = "textBox1_Id";
            this.textBox1_Id.ReadOnly = true;
            this.textBox1_Id.Size = new System.Drawing.Size(100, 22);
            this.textBox1_Id.TabIndex = 0;
            // 
            // numericUpDown1_Ratings
            // 
            this.numericUpDown1_Ratings.Location = new System.Drawing.Point(43, 132);
            this.numericUpDown1_Ratings.Name = "numericUpDown1_Ratings";
            this.numericUpDown1_Ratings.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1_Ratings.TabIndex = 1;
            // 
            // dateTimePicker1_Entry
            // 
            this.dateTimePicker1_Entry.Location = new System.Drawing.Point(246, 132);
            this.dateTimePicker1_Entry.Name = "dateTimePicker1_Entry";
            this.dateTimePicker1_Entry.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1_Entry.TabIndex = 2;
            // 
            // textBox_fullname
            // 
            this.textBox_fullname.Location = new System.Drawing.Point(246, 53);
            this.textBox_fullname.Name = "textBox_fullname";
            this.textBox_fullname.Size = new System.Drawing.Size(100, 22);
            this.textBox_fullname.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(40, 34);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(20, 16);
            this.Id.TabIndex = 4;
            this.Id.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Teljes név";
            // 
            // Értékelés
            // 
            this.Értékelés.AutoSize = true;
            this.Értékelés.Location = new System.Drawing.Point(40, 100);
            this.Értékelés.Name = "Értékelés";
            this.Értékelés.Size = new System.Drawing.Size(44, 16);
            this.Értékelés.TabIndex = 4;
            this.Értékelés.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Csatlakozás";
            // 
            // button_Read
            // 
            this.button_Read.Location = new System.Drawing.Point(199, 334);
            this.button_Read.Name = "button_Read";
            this.button_Read.Size = new System.Drawing.Size(114, 52);
            this.button_Read.TabIndex = 3;
            this.button_Read.Text = "Beolvasás";
            this.button_Read.UseVisualStyleBackColor = true;
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(319, 332);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(106, 54);
            this.button_Create.TabIndex = 4;
            this.button_Create.Text = "Felvétel";
            this.button_Create.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(447, 332);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(133, 54);
            this.button_Delete.TabIndex = 5;
            this.button_Delete.Text = "Törlés";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(606, 334);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(88, 52);
            this.button_Update.TabIndex = 6;
            this.button_Update.Text = "Módosítás";
            this.button_Update.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.button_Read);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_Tagok);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_Ratings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox_Tagok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1_Id;
        private System.Windows.Forms.NumericUpDown numericUpDown1_Ratings;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_Entry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Értékelés;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox textBox_fullname;
        private System.Windows.Forms.Button button_Read;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
    }
}


namespace ExcuseManager
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
            this.textBox_Excuse = new System.Windows.Forms.TextBox();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.dateTimePicker_LastUsed = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label_FileDate = new System.Windows.Forms.Label();
            this.button_Folder = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Open = new System.Windows.Forms.Button();
            this.button_Random = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBox_Excuse
            // 
            this.textBox_Excuse.Location = new System.Drawing.Point(107, 26);
            this.textBox_Excuse.Name = "textBox_Excuse";
            this.textBox_Excuse.Size = new System.Drawing.Size(331, 20);
            this.textBox_Excuse.TabIndex = 0;
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(107, 52);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(331, 20);
            this.textBox_Result.TabIndex = 1;
            // 
            // dateTimePicker_LastUsed
            // 
            this.dateTimePicker_LastUsed.Location = new System.Drawing.Point(107, 90);
            this.dateTimePicker_LastUsed.Name = "dateTimePicker_LastUsed";
            this.dateTimePicker_LastUsed.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_LastUsed.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // label_FileDate
            // 
            this.label_FileDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_FileDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FileDate.Location = new System.Drawing.Point(107, 117);
            this.label_FileDate.Name = "label_FileDate";
            this.label_FileDate.Size = new System.Drawing.Size(200, 30);
            this.label_FileDate.TabIndex = 4;
            this.label_FileDate.Text = "label2";
            // 
            // button_Folder
            // 
            this.button_Folder.Location = new System.Drawing.Point(12, 159);
            this.button_Folder.Name = "button_Folder";
            this.button_Folder.Size = new System.Drawing.Size(75, 23);
            this.button_Folder.TabIndex = 5;
            this.button_Folder.Text = "Folder";
            this.button_Folder.UseVisualStyleBackColor = true;
            this.button_Folder.Click += new System.EventHandler(this.button_Folder_Click);
            // 
            // button_Save
            // 
            this.button_Save.Enabled = false;
            this.button_Save.Location = new System.Drawing.Point(93, 159);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 6;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Open
            // 
            this.button_Open.Enabled = false;
            this.button_Open.Location = new System.Drawing.Point(174, 159);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(75, 23);
            this.button_Open.TabIndex = 7;
            this.button_Open.Text = "Open";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // button_Random
            // 
            this.button_Random.Enabled = false;
            this.button_Random.Location = new System.Drawing.Point(255, 159);
            this.button_Random.Name = "button_Random";
            this.button_Random.Size = new System.Drawing.Size(149, 23);
            this.button_Random.TabIndex = 9;
            this.button_Random.Text = "Random";
            this.button_Random.UseVisualStyleBackColor = true;
            this.button_Random.Click += new System.EventHandler(this.button_Random_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Excuse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Results";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Last Used";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "File date";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 214);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Random);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Folder);
            this.Controls.Add(this.label_FileDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_LastUsed);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.textBox_Excuse);
            this.Name = "Form1";
            this.Text = "Excuse Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Excuse;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.DateTimePicker dateTimePicker_LastUsed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_FileDate;
        private System.Windows.Forms.Button button_Folder;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Button button_Random;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


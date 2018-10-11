namespace DBConverter
{
    partial class frmDBConverter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileSource = new System.Windows.Forms.TextBox();
            this.btnSourceFile = new System.Windows.Forms.Button();
            this.ofdSourceFile = new System.Windows.Forms.OpenFileDialog();
            this.rdbMSSql_MySql = new System.Windows.Forms.RadioButton();
            this.rdbMySql_MSSql = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.btnTarget = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fbdTarget = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DB Converter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Source DB Dump";
            // 
            // txtFileSource
            // 
            this.txtFileSource.Location = new System.Drawing.Point(306, 77);
            this.txtFileSource.Name = "txtFileSource";
            this.txtFileSource.Size = new System.Drawing.Size(100, 20);
            this.txtFileSource.TabIndex = 2;
            // 
            // btnSourceFile
            // 
            this.btnSourceFile.Location = new System.Drawing.Point(427, 77);
            this.btnSourceFile.Name = "btnSourceFile";
            this.btnSourceFile.Size = new System.Drawing.Size(31, 23);
            this.btnSourceFile.TabIndex = 3;
            this.btnSourceFile.Text = "...";
            this.btnSourceFile.UseVisualStyleBackColor = true;
            this.btnSourceFile.Click += new System.EventHandler(this.btnSourceFile_Click);
            // 
            // ofdSourceFile
            // 
            this.ofdSourceFile.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdSourceFile_FileOk);
            // 
            // rdbMSSql_MySql
            // 
            this.rdbMSSql_MySql.AutoSize = true;
            this.rdbMSSql_MySql.Location = new System.Drawing.Point(13, 22);
            this.rdbMSSql_MySql.Name = "rdbMSSql_MySql";
            this.rdbMSSql_MySql.Size = new System.Drawing.Size(118, 17);
            this.rdbMSSql_MySql.TabIndex = 4;
            this.rdbMSSql_MySql.TabStop = true;
            this.rdbMSSql_MySql.Text = "MS SQL --> MySQL";
            this.rdbMSSql_MySql.UseVisualStyleBackColor = true;
            // 
            // rdbMySql_MSSql
            // 
            this.rdbMySql_MSSql.AutoSize = true;
            this.rdbMySql_MSSql.Location = new System.Drawing.Point(177, 22);
            this.rdbMySql_MSSql.Name = "rdbMySql_MSSql";
            this.rdbMySql_MSSql.Size = new System.Drawing.Size(118, 17);
            this.rdbMySql_MSSql.TabIndex = 5;
            this.rdbMySql_MSSql.TabStop = true;
            this.rdbMySql_MSSql.Text = "MySQL --> MS SQL";
            this.rdbMySql_MSSql.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(315, 218);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(306, 120);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(100, 20);
            this.txtTarget.TabIndex = 7;
            // 
            // btnTarget
            // 
            this.btnTarget.Location = new System.Drawing.Point(427, 120);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(31, 23);
            this.btnTarget.TabIndex = 8;
            this.btnTarget.Text = "...";
            this.btnTarget.UseVisualStyleBackColor = true;
            this.btnTarget.Click += new System.EventHandler(this.btnTarget_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Target Path";
            // 
            // fbdTarget
            // 
            this.fbdTarget.HelpRequest += new System.EventHandler(this.fbdTarget_HelpRequest);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbMySql_MSSql);
            this.groupBox1.Controls.Add(this.rdbMSSql_MySql);
            this.groupBox1.Location = new System.Drawing.Point(161, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 51);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convesion";
            // 
            // frmDBConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTarget);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnSourceFile);
            this.Controls.Add(this.txtFileSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDBConverter";
            this.Text = "DB Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFileSource;
        private System.Windows.Forms.Button btnSourceFile;
        private System.Windows.Forms.OpenFileDialog ofdSourceFile;
        private System.Windows.Forms.RadioButton rdbMSSql_MySql;
        private System.Windows.Forms.RadioButton rdbMySql_MSSql;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Button btnTarget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog fbdTarget;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


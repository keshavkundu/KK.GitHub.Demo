
namespace KK.GitHub.Demo
{
    partial class GithubDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GithubDemo));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtGitUrl = new System.Windows.Forms.TextBox();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.btnValidateInput = new System.Windows.Forms.Button();
            this.lblErrorUserName = new System.Windows.Forms.Label();
            this.lblErrorGitUrl = new System.Windows.Forms.Label();
            this.lblErrorToken = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLeftHeading = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.CommentWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Occurence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.lblCommentHeader = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(25, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wecome To Github BI Tool";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(24, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Please enter Username: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Please enter Git enterprise repository Url:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Please enter Private Access Token:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(26, 152);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(518, 26);
            this.txtUserName.TabIndex = 1;
            // 
            // txtGitUrl
            // 
            this.txtGitUrl.Location = new System.Drawing.Point(26, 395);
            this.txtGitUrl.Name = "txtGitUrl";
            this.txtGitUrl.Size = new System.Drawing.Size(522, 26);
            this.txtGitUrl.TabIndex = 3;
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(28, 267);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(520, 26);
            this.txtToken.TabIndex = 2;
            // 
            // btnValidateInput
            // 
            this.btnValidateInput.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnValidateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidateInput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnValidateInput.Location = new System.Drawing.Point(418, 482);
            this.btnValidateInput.Name = "btnValidateInput";
            this.btnValidateInput.Size = new System.Drawing.Size(130, 44);
            this.btnValidateInput.TabIndex = 4;
            this.btnValidateInput.Text = "Validate";
            this.btnValidateInput.UseVisualStyleBackColor = false;
            this.btnValidateInput.Click += new System.EventHandler(this.btnValidateInput_Click);
            // 
            // lblErrorUserName
            // 
            this.lblErrorUserName.AutoSize = true;
            this.lblErrorUserName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorUserName.Location = new System.Drawing.Point(24, 183);
            this.lblErrorUserName.Name = "lblErrorUserName";
            this.lblErrorUserName.Size = new System.Drawing.Size(152, 20);
            this.lblErrorUserName.TabIndex = 9;
            this.lblErrorUserName.Text = "This field is required.";
            this.lblErrorUserName.Visible = false;
            // 
            // lblErrorGitUrl
            // 
            this.lblErrorGitUrl.AutoSize = true;
            this.lblErrorGitUrl.ForeColor = System.Drawing.Color.Red;
            this.lblErrorGitUrl.Location = new System.Drawing.Point(20, 428);
            this.lblErrorGitUrl.Name = "lblErrorGitUrl";
            this.lblErrorGitUrl.Size = new System.Drawing.Size(152, 20);
            this.lblErrorGitUrl.TabIndex = 10;
            this.lblErrorGitUrl.Text = "This field is required.";
            this.lblErrorGitUrl.Visible = false;
            // 
            // lblErrorToken
            // 
            this.lblErrorToken.AutoSize = true;
            this.lblErrorToken.ForeColor = System.Drawing.Color.Red;
            this.lblErrorToken.Location = new System.Drawing.Point(26, 301);
            this.lblErrorToken.Name = "lblErrorToken";
            this.lblErrorToken.Size = new System.Drawing.Size(152, 20);
            this.lblErrorToken.TabIndex = 11;
            this.lblErrorToken.Text = "This field is required.";
            this.lblErrorToken.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(228, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(372, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(326, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "*";
            // 
            // lblLeftHeading
            // 
            this.lblLeftHeading.AutoSize = true;
            this.lblLeftHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftHeading.ForeColor = System.Drawing.Color.Blue;
            this.lblLeftHeading.Location = new System.Drawing.Point(23, 76);
            this.lblLeftHeading.Name = "lblLeftHeading";
            this.lblLeftHeading.Size = new System.Drawing.Size(412, 25);
            this.lblLeftHeading.TabIndex = 15;
            this.lblLeftHeading.Text = "Please note all the below fields are mandatory.";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Location = new System.Drawing.Point(-4, -2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1265, 68);
            this.pnlHeader.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 543);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 53);
            this.panel1.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkBlue;
            this.label11.Location = new System.Drawing.Point(1127, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Release 2021";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(534, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Version 1.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "©KeshavKundu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label10.Location = new System.Drawing.Point(567, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 440);
            this.label10.TabIndex = 18;
            this.label10.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // lblInformation
            // 
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.ForeColor = System.Drawing.Color.Navy;
            this.lblInformation.Location = new System.Drawing.Point(587, 80);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(656, 399);
            this.lblInformation.TabIndex = 0;
            this.lblInformation.Text = resources.GetString("lblInformation.Text");
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CommentWord,
            this.Occurence});
            this.dataGridView.Location = new System.Drawing.Point(587, 133);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(656, 324);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.Visible = false;
            // 
            // CommentWord
            // 
            this.CommentWord.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CommentWord.DataPropertyName = "Commented Words";
            this.CommentWord.FillWeight = 190.9091F;
            this.CommentWord.HeaderText = "Commented Words";
            this.CommentWord.MinimumWidth = 8;
            this.CommentWord.Name = "CommentWord";
            this.CommentWord.ReadOnly = true;
            this.CommentWord.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Occurence
            // 
            this.Occurence.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Occurence.DataPropertyName = "Occurence";
            this.Occurence.FillWeight = 9.090912F;
            this.Occurence.HeaderText = "Occurence";
            this.Occurence.MinimumWidth = 8;
            this.Occurence.Name = "Occurence";
            this.Occurence.ReadOnly = true;
            this.Occurence.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Occurence.Width = 122;
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExportCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportCSV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExportCSV.Location = new System.Drawing.Point(1085, 482);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(155, 44);
            this.btnExportCSV.TabIndex = 19;
            this.btnExportCSV.Text = "Export to CSV";
            this.btnExportCSV.UseVisualStyleBackColor = false;
            this.btnExportCSV.Visible = false;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // lblCommentHeader
            // 
            this.lblCommentHeader.AutoSize = true;
            this.lblCommentHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentHeader.ForeColor = System.Drawing.Color.Blue;
            this.lblCommentHeader.Location = new System.Drawing.Point(581, 76);
            this.lblCommentHeader.Name = "lblCommentHeader";
            this.lblCommentHeader.Size = new System.Drawing.Size(621, 50);
            this.lblCommentHeader.TabIndex = 20;
            this.lblCommentHeader.Text = "The most common words used by the user in comments section during\r\nthe check in p" +
    "rocess sorted in ASCII values ascending.";
            this.lblCommentHeader.Visible = false;
            // 
            // GithubDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1255, 592);
            this.Controls.Add(this.lblCommentHeader);
            this.Controls.Add(this.btnExportCSV);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.lblLeftHeading);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblErrorToken);
            this.Controls.Add(this.lblErrorGitUrl);
            this.Controls.Add(this.lblErrorUserName);
            this.Controls.Add(this.btnValidateInput);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.txtGitUrl);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GithubDemo";
            this.Text = "Github BI Demo";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtGitUrl;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Button btnValidateInput;
        private System.Windows.Forms.Label lblErrorUserName;
        private System.Windows.Forms.Label lblErrorGitUrl;
        private System.Windows.Forms.Label lblErrorToken;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblLeftHeading;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.Label lblCommentHeader;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Occurence;
    }
}



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
            this.label1 = new System.Windows.Forms.Label();
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
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(731, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Here you have to enter the below mentioned details to connect with Github reposit" +
    "ory.\r\n\r\nAfter successful login you will be able to analyse the most common words" +
    " used during checkin process.\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(35, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wecome to the Github BI intelligence demo tool. ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(39, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Please enter Username: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Please enter Git enterprise repository Url:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(377, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Please enter Private Access Token:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(39, 220);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(299, 26);
            this.txtUserName.TabIndex = 5;
            // 
            // txtGitUrl
            // 
            this.txtGitUrl.Location = new System.Drawing.Point(41, 311);
            this.txtGitUrl.Name = "txtGitUrl";
            this.txtGitUrl.Size = new System.Drawing.Size(725, 26);
            this.txtGitUrl.TabIndex = 6;
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(379, 220);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(387, 26);
            this.txtToken.TabIndex = 7;
            // 
            // btnValidateInput
            // 
            this.btnValidateInput.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnValidateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidateInput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnValidateInput.Location = new System.Drawing.Point(636, 417);
            this.btnValidateInput.Name = "btnValidateInput";
            this.btnValidateInput.Size = new System.Drawing.Size(130, 44);
            this.btnValidateInput.TabIndex = 8;
            this.btnValidateInput.Text = "Validate";
            this.btnValidateInput.UseVisualStyleBackColor = false;
            this.btnValidateInput.Click += new System.EventHandler(this.btnValidateInput_Click);
            // 
            // lblErrorUserName
            // 
            this.lblErrorUserName.AutoSize = true;
            this.lblErrorUserName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorUserName.Location = new System.Drawing.Point(37, 254);
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
            this.lblErrorGitUrl.Location = new System.Drawing.Point(35, 344);
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
            this.lblErrorToken.Location = new System.Drawing.Point(377, 254);
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
            this.label6.Location = new System.Drawing.Point(237, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "*";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(377, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "*";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(665, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "*";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(39, 417);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(337, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Please note all the above fields are mandatory.";
            // 
            // GithubDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.label9);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GithubDemo";
            this.Text = "Github BI Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label label9;
    }
}


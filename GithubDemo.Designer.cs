
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 106);
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
            this.label3.Location = new System.Drawing.Point(56, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Git URL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Token:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(197, 235);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(546, 26);
            this.txtUserName.TabIndex = 5;
            // 
            // txtGitUrl
            // 
            this.txtGitUrl.Location = new System.Drawing.Point(197, 287);
            this.txtGitUrl.Name = "txtGitUrl";
            this.txtGitUrl.Size = new System.Drawing.Size(546, 26);
            this.txtGitUrl.TabIndex = 6;
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(197, 337);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(546, 26);
            this.txtToken.TabIndex = 7;
            // 
            // btnValidateInput
            // 
            this.btnValidateInput.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnValidateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidateInput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnValidateInput.Location = new System.Drawing.Point(613, 424);
            this.btnValidateInput.Name = "btnValidateInput";
            this.btnValidateInput.Size = new System.Drawing.Size(130, 44);
            this.btnValidateInput.TabIndex = 8;
            this.btnValidateInput.Text = "Validate";
            this.btnValidateInput.UseVisualStyleBackColor = false;
            this.btnValidateInput.Click += new System.EventHandler(this.btnValidateInput_Click);
            // 
            // GithubDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 527);
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
    }
}


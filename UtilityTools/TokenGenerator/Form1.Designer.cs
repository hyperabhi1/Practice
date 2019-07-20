namespace TokenGenerator
{
    partial class FormTokenGenerator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonRProduction = new System.Windows.Forms.RadioButton();
            this.radioButtonRSandBox = new System.Windows.Forms.RadioButton();
            this.radioButtonRQA = new System.Windows.Forms.RadioButton();
            this.textBoxRAppCD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRClientSecret = new System.Windows.Forms.TextBox();
            this.textBoxRBody = new System.Windows.Forms.TextBox();
            this.textBoxRauthServiceUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRToken = new System.Windows.Forms.TextBox();
            this.buttonRCopyToken = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRGo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resume\'s token generator";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonRProduction);
            this.panel1.Controls.Add(this.radioButtonRSandBox);
            this.panel1.Controls.Add(this.radioButtonRQA);
            this.panel1.Location = new System.Drawing.Point(19, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 21);
            this.panel1.TabIndex = 3;
            // 
            // radioButtonRProduction
            // 
            this.radioButtonRProduction.AutoSize = true;
            this.radioButtonRProduction.Location = new System.Drawing.Point(145, 2);
            this.radioButtonRProduction.Name = "radioButtonRProduction";
            this.radioButtonRProduction.Size = new System.Drawing.Size(76, 17);
            this.radioButtonRProduction.TabIndex = 2;
            this.radioButtonRProduction.Text = "Production";
            this.radioButtonRProduction.UseVisualStyleBackColor = true;
            this.radioButtonRProduction.CheckedChanged += new System.EventHandler(this.ResumesEventHandler);
            // 
            // radioButtonRSandBox
            // 
            this.radioButtonRSandBox.AutoSize = true;
            this.radioButtonRSandBox.Location = new System.Drawing.Point(65, 2);
            this.radioButtonRSandBox.Name = "radioButtonRSandBox";
            this.radioButtonRSandBox.Size = new System.Drawing.Size(68, 17);
            this.radioButtonRSandBox.TabIndex = 1;
            this.radioButtonRSandBox.Text = "SandBox";
            this.radioButtonRSandBox.UseVisualStyleBackColor = true;
            this.radioButtonRSandBox.CheckedChanged += new System.EventHandler(this.ResumesEventHandler);
            // 
            // radioButtonRQA
            // 
            this.radioButtonRQA.AutoSize = true;
            this.radioButtonRQA.Location = new System.Drawing.Point(4, 2);
            this.radioButtonRQA.Name = "radioButtonRQA";
            this.radioButtonRQA.Size = new System.Drawing.Size(40, 17);
            this.radioButtonRQA.TabIndex = 0;
            this.radioButtonRQA.Text = "QA";
            this.radioButtonRQA.UseVisualStyleBackColor = true;
            this.radioButtonRQA.CheckedChanged += new System.EventHandler(this.ResumesEventHandler);
            // 
            // textBoxRAppCD
            // 
            this.textBoxRAppCD.Location = new System.Drawing.Point(94, 63);
            this.textBoxRAppCD.Name = "textBoxRAppCD";
            this.textBoxRAppCD.ReadOnly = true;
            this.textBoxRAppCD.Size = new System.Drawing.Size(158, 20);
            this.textBoxRAppCD.TabIndex = 4;
            this.textBoxRAppCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "AppCD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ClientSecret";
            // 
            // textBoxRClientSecret
            // 
            this.textBoxRClientSecret.Location = new System.Drawing.Point(94, 89);
            this.textBoxRClientSecret.Name = "textBoxRClientSecret";
            this.textBoxRClientSecret.ReadOnly = true;
            this.textBoxRClientSecret.Size = new System.Drawing.Size(158, 20);
            this.textBoxRClientSecret.TabIndex = 6;
            this.textBoxRClientSecret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRBody
            // 
            this.textBoxRBody.Location = new System.Drawing.Point(58, 141);
            this.textBoxRBody.Multiline = true;
            this.textBoxRBody.Name = "textBoxRBody";
            this.textBoxRBody.ReadOnly = true;
            this.textBoxRBody.Size = new System.Drawing.Size(194, 73);
            this.textBoxRBody.TabIndex = 8;
            // 
            // textBoxRauthServiceUrl
            // 
            this.textBoxRauthServiceUrl.Location = new System.Drawing.Point(94, 115);
            this.textBoxRauthServiceUrl.Name = "textBoxRauthServiceUrl";
            this.textBoxRauthServiceUrl.ReadOnly = true;
            this.textBoxRauthServiceUrl.Size = new System.Drawing.Size(158, 20);
            this.textBoxRauthServiceUrl.TabIndex = 9;
            this.textBoxRauthServiceUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "authServiceUrl";
            // 
            // textBoxRToken
            // 
            this.textBoxRToken.BackColor = System.Drawing.Color.White;
            this.textBoxRToken.Location = new System.Drawing.Point(19, 220);
            this.textBoxRToken.Multiline = true;
            this.textBoxRToken.Name = "textBoxRToken";
            this.textBoxRToken.ReadOnly = true;
            this.textBoxRToken.Size = new System.Drawing.Size(233, 293);
            this.textBoxRToken.TabIndex = 11;
            // 
            // buttonRCopyToken
            // 
            this.buttonRCopyToken.Enabled = false;
            this.buttonRCopyToken.Location = new System.Drawing.Point(177, 519);
            this.buttonRCopyToken.Name = "buttonRCopyToken";
            this.buttonRCopyToken.Size = new System.Drawing.Size(75, 23);
            this.buttonRCopyToken.TabIndex = 12;
            this.buttonRCopyToken.Text = "Copy token";
            this.buttonRCopyToken.UseVisualStyleBackColor = true;
            this.buttonRCopyToken.Click += new System.EventHandler(this.buttonRCopyToken_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Body";
            // 
            // buttonRGo
            // 
            this.buttonRGo.Enabled = false;
            this.buttonRGo.Location = new System.Drawing.Point(19, 191);
            this.buttonRGo.Name = "buttonRGo";
            this.buttonRGo.Size = new System.Drawing.Size(33, 23);
            this.buttonRGo.TabIndex = 14;
            this.buttonRGo.Text = "Go";
            this.buttonRGo.UseVisualStyleBackColor = true;
            this.buttonRGo.Click += new System.EventHandler(this.buttonRGo_Click);
            // 
            // FormTokenGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 554);
            this.Controls.Add(this.buttonRGo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonRCopyToken);
            this.Controls.Add(this.textBoxRToken);
            this.Controls.Add(this.textBoxRauthServiceUrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRBody);
            this.Controls.Add(this.textBoxRClientSecret);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRAppCD);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.MaximumSize = new System.Drawing.Size(286, 593);
            this.MinimumSize = new System.Drawing.Size(286, 593);
            this.Name = "FormTokenGenerator";
            this.Text = "Token Generator";
            this.Load += new System.EventHandler(this.FormTokenGenerator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonRProduction;
        private System.Windows.Forms.RadioButton radioButtonRSandBox;
        private System.Windows.Forms.RadioButton radioButtonRQA;
        private System.Windows.Forms.TextBox textBoxRAppCD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRClientSecret;
        private System.Windows.Forms.TextBox textBoxRBody;
        private System.Windows.Forms.TextBox textBoxRauthServiceUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRToken;
        private System.Windows.Forms.Button buttonRCopyToken;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRGo;
    }
}


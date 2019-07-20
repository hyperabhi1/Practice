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
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButtonJQA = new System.Windows.Forms.RadioButton();
            this.radioButtonJSandBox = new System.Windows.Forms.RadioButton();
            this.radioButtonJProduction = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxJAppCD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxJClientSecret = new System.Windows.Forms.TextBox();
            this.textBoxJBody = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxJauthServiceUrl = new System.Windows.Forms.TextBox();
            this.textBoxJToken = new System.Windows.Forms.TextBox();
            this.buttonJCopyToken = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonJGo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.textBoxRToken.Location = new System.Drawing.Point(19, 220);
            this.textBoxRToken.Multiline = true;
            this.textBoxRToken.Name = "textBoxRToken";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(254, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 533);
            this.label6.TabIndex = 15;
            this.label6.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n" +
    "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(278, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "ClientSecret";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(278, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Jobs\'s token generator";
            // 
            // radioButtonJQA
            // 
            this.radioButtonJQA.AutoSize = true;
            this.radioButtonJQA.Location = new System.Drawing.Point(4, 2);
            this.radioButtonJQA.Name = "radioButtonJQA";
            this.radioButtonJQA.Size = new System.Drawing.Size(40, 17);
            this.radioButtonJQA.TabIndex = 0;
            this.radioButtonJQA.Text = "QA";
            this.radioButtonJQA.UseVisualStyleBackColor = true;
            // 
            // radioButtonJSandBox
            // 
            this.radioButtonJSandBox.AutoSize = true;
            this.radioButtonJSandBox.Location = new System.Drawing.Point(65, 2);
            this.radioButtonJSandBox.Name = "radioButtonJSandBox";
            this.radioButtonJSandBox.Size = new System.Drawing.Size(68, 17);
            this.radioButtonJSandBox.TabIndex = 1;
            this.radioButtonJSandBox.Text = "SandBox";
            this.radioButtonJSandBox.UseVisualStyleBackColor = true;
            // 
            // radioButtonJProduction
            // 
            this.radioButtonJProduction.AutoSize = true;
            this.radioButtonJProduction.Location = new System.Drawing.Point(145, 2);
            this.radioButtonJProduction.Name = "radioButtonJProduction";
            this.radioButtonJProduction.Size = new System.Drawing.Size(76, 17);
            this.radioButtonJProduction.TabIndex = 2;
            this.radioButtonJProduction.Text = "Production";
            this.radioButtonJProduction.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonJProduction);
            this.panel2.Controls.Add(this.radioButtonJSandBox);
            this.panel2.Controls.Add(this.radioButtonJQA);
            this.panel2.Location = new System.Drawing.Point(281, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 21);
            this.panel2.TabIndex = 17;
            // 
            // textBoxJAppCD
            // 
            this.textBoxJAppCD.Location = new System.Drawing.Point(356, 62);
            this.textBoxJAppCD.Name = "textBoxJAppCD";
            this.textBoxJAppCD.ReadOnly = true;
            this.textBoxJAppCD.Size = new System.Drawing.Size(158, 20);
            this.textBoxJAppCD.TabIndex = 18;
            this.textBoxJAppCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(278, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "AppCD";
            // 
            // textBoxJClientSecret
            // 
            this.textBoxJClientSecret.Location = new System.Drawing.Point(356, 88);
            this.textBoxJClientSecret.Name = "textBoxJClientSecret";
            this.textBoxJClientSecret.ReadOnly = true;
            this.textBoxJClientSecret.Size = new System.Drawing.Size(158, 20);
            this.textBoxJClientSecret.TabIndex = 20;
            this.textBoxJClientSecret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxJBody
            // 
            this.textBoxJBody.Location = new System.Drawing.Point(320, 140);
            this.textBoxJBody.Multiline = true;
            this.textBoxJBody.Name = "textBoxJBody";
            this.textBoxJBody.ReadOnly = true;
            this.textBoxJBody.Size = new System.Drawing.Size(194, 73);
            this.textBoxJBody.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(278, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "authServiceUrl";
            // 
            // textBoxJauthServiceUrl
            // 
            this.textBoxJauthServiceUrl.Location = new System.Drawing.Point(356, 114);
            this.textBoxJauthServiceUrl.Name = "textBoxJauthServiceUrl";
            this.textBoxJauthServiceUrl.ReadOnly = true;
            this.textBoxJauthServiceUrl.Size = new System.Drawing.Size(158, 20);
            this.textBoxJauthServiceUrl.TabIndex = 23;
            this.textBoxJauthServiceUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxJToken
            // 
            this.textBoxJToken.Location = new System.Drawing.Point(281, 219);
            this.textBoxJToken.Multiline = true;
            this.textBoxJToken.Name = "textBoxJToken";
            this.textBoxJToken.Size = new System.Drawing.Size(233, 293);
            this.textBoxJToken.TabIndex = 25;
            // 
            // buttonJCopyToken
            // 
            this.buttonJCopyToken.Enabled = false;
            this.buttonJCopyToken.Location = new System.Drawing.Point(439, 518);
            this.buttonJCopyToken.Name = "buttonJCopyToken";
            this.buttonJCopyToken.Size = new System.Drawing.Size(75, 23);
            this.buttonJCopyToken.TabIndex = 26;
            this.buttonJCopyToken.Text = "Copy token";
            this.buttonJCopyToken.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(278, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Body";
            // 
            // buttonJGo
            // 
            this.buttonJGo.Enabled = false;
            this.buttonJGo.Location = new System.Drawing.Point(281, 190);
            this.buttonJGo.Name = "buttonJGo";
            this.buttonJGo.Size = new System.Drawing.Size(33, 23);
            this.buttonJGo.TabIndex = 28;
            this.buttonJGo.Text = "Go";
            this.buttonJGo.UseVisualStyleBackColor = true;
            // 
            // FormTokenGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 554);
            this.Controls.Add(this.buttonJGo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonJCopyToken);
            this.Controls.Add(this.textBoxJToken);
            this.Controls.Add(this.textBoxJauthServiceUrl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxJBody);
            this.Controls.Add(this.textBoxJClientSecret);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxJAppCD);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
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
            this.Controls.Add(this.label6);
            this.Name = "FormTokenGenerator";
            this.Text = "Token Generator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButtonJQA;
        private System.Windows.Forms.RadioButton radioButtonJSandBox;
        private System.Windows.Forms.RadioButton radioButtonJProduction;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxJAppCD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxJClientSecret;
        private System.Windows.Forms.TextBox textBoxJBody;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxJauthServiceUrl;
        private System.Windows.Forms.TextBox textBoxJToken;
        private System.Windows.Forms.Button buttonJCopyToken;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonJGo;
    }
}


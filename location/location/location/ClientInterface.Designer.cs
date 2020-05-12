namespace location
{
    partial class ClientInterface
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
            this.components = new System.ComponentModel.Container();
            this.usernameTxtbox = new System.Windows.Forms.TextBox();
            this.locationTxtbox = new System.Windows.Forms.TextBox();
            this.serverTxtbox = new System.Windows.Forms.TextBox();
            this.portTxtbox = new System.Windows.Forms.TextBox();
            this.timeoutTxtbox = new System.Windows.Forms.TextBox();
            this.protocolrdbtn09 = new System.Windows.Forms.RadioButton();
            this.protocolrdbtn10 = new System.Windows.Forms.RadioButton();
            this.protocolrdbtn11 = new System.Windows.Forms.RadioButton();
            this.submitbtn = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchrdbtn = new System.Windows.Forms.RadioButton();
            this.changelocrdbtn = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameTxtbox
            // 
            this.usernameTxtbox.BackColor = System.Drawing.SystemColors.Window;
            this.usernameTxtbox.Location = new System.Drawing.Point(348, 179);
            this.usernameTxtbox.Name = "usernameTxtbox";
            this.usernameTxtbox.Size = new System.Drawing.Size(200, 20);
            this.usernameTxtbox.TabIndex = 1;
            this.usernameTxtbox.Visible = false;
            this.usernameTxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.usernameTxtbox.Validating += new System.ComponentModel.CancelEventHandler(this.usernameTxtbox_Validating);
            // 
            // locationTxtbox
            // 
            this.locationTxtbox.Location = new System.Drawing.Point(348, 232);
            this.locationTxtbox.Name = "locationTxtbox";
            this.locationTxtbox.Size = new System.Drawing.Size(200, 20);
            this.locationTxtbox.TabIndex = 2;
            this.locationTxtbox.Visible = false;
            this.locationTxtbox.TextChanged += new System.EventHandler(this.locationTxtbox_TextChanged);
            this.locationTxtbox.Validating += new System.ComponentModel.CancelEventHandler(this.locationTxtbox_Validating);
            // 
            // serverTxtbox
            // 
            this.serverTxtbox.Location = new System.Drawing.Point(348, 285);
            this.serverTxtbox.Name = "serverTxtbox";
            this.serverTxtbox.Size = new System.Drawing.Size(200, 20);
            this.serverTxtbox.TabIndex = 3;
            this.serverTxtbox.Visible = false;
            this.serverTxtbox.TextChanged += new System.EventHandler(this.serverTxtbox_TextChanged);
            this.serverTxtbox.Validating += new System.ComponentModel.CancelEventHandler(this.serverTxtbox_Validating);
            // 
            // portTxtbox
            // 
            this.portTxtbox.Location = new System.Drawing.Point(348, 387);
            this.portTxtbox.Name = "portTxtbox";
            this.portTxtbox.Size = new System.Drawing.Size(200, 20);
            this.portTxtbox.TabIndex = 5;
            this.portTxtbox.Visible = false;
            this.portTxtbox.TextChanged += new System.EventHandler(this.portTxtbox_TextChanged);
            this.portTxtbox.Validating += new System.ComponentModel.CancelEventHandler(this.portTxtbox_Validating);
            // 
            // timeoutTxtbox
            // 
            this.timeoutTxtbox.Location = new System.Drawing.Point(348, 336);
            this.timeoutTxtbox.Name = "timeoutTxtbox";
            this.timeoutTxtbox.Size = new System.Drawing.Size(200, 20);
            this.timeoutTxtbox.TabIndex = 4;
            this.timeoutTxtbox.Visible = false;
            this.timeoutTxtbox.Validating += new System.ComponentModel.CancelEventHandler(this.timeoutTxtbox_Validating);
            // 
            // protocolrdbtn09
            // 
            this.protocolrdbtn09.AutoSize = true;
            this.protocolrdbtn09.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.protocolrdbtn09.ForeColor = System.Drawing.Color.White;
            this.protocolrdbtn09.Location = new System.Drawing.Point(45, 82);
            this.protocolrdbtn09.Name = "protocolrdbtn09";
            this.protocolrdbtn09.Size = new System.Drawing.Size(114, 24);
            this.protocolrdbtn09.TabIndex = 6;
            this.protocolrdbtn09.TabStop = true;
            this.protocolrdbtn09.Text = "- HTTP 0.9";
            this.protocolrdbtn09.UseVisualStyleBackColor = true;
            this.protocolrdbtn09.CheckedChanged += new System.EventHandler(this.protocolrdbtn09_CheckedChanged);
            // 
            // protocolrdbtn10
            // 
            this.protocolrdbtn10.AutoSize = true;
            this.protocolrdbtn10.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.protocolrdbtn10.ForeColor = System.Drawing.Color.White;
            this.protocolrdbtn10.Location = new System.Drawing.Point(45, 51);
            this.protocolrdbtn10.Name = "protocolrdbtn10";
            this.protocolrdbtn10.Size = new System.Drawing.Size(114, 24);
            this.protocolrdbtn10.TabIndex = 7;
            this.protocolrdbtn10.TabStop = true;
            this.protocolrdbtn10.Text = "- HTTP 1.0";
            this.protocolrdbtn10.UseVisualStyleBackColor = true;
            this.protocolrdbtn10.CheckedChanged += new System.EventHandler(this.protocolrdbtn10_CheckedChanged);
            // 
            // protocolrdbtn11
            // 
            this.protocolrdbtn11.AutoSize = true;
            this.protocolrdbtn11.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.protocolrdbtn11.ForeColor = System.Drawing.Color.White;
            this.protocolrdbtn11.Location = new System.Drawing.Point(45, 20);
            this.protocolrdbtn11.Name = "protocolrdbtn11";
            this.protocolrdbtn11.Size = new System.Drawing.Size(114, 24);
            this.protocolrdbtn11.TabIndex = 8;
            this.protocolrdbtn11.TabStop = true;
            this.protocolrdbtn11.Text = "- HTTP 1.1";
            this.protocolrdbtn11.UseVisualStyleBackColor = true;
            this.protocolrdbtn11.CheckedChanged += new System.EventHandler(this.protocolrdbtn11_CheckedChanged);
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.Color.White;
            this.submitbtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.ForeColor = System.Drawing.Color.Black;
            this.submitbtn.Location = new System.Drawing.Point(379, 413);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(135, 71);
            this.submitbtn.TabIndex = 6;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = false;
            this.submitbtn.Visible = false;
            this.submitbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(45, 114);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(100, 24);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "- Default";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(422, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "SERVER";
            this.label1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(428, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "PORT";
            this.label3.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(419, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "TIMEOUT";
            this.label2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(414, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "USERNAME";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // searchrdbtn
            // 
            this.searchrdbtn.AutoSize = true;
            this.searchrdbtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchrdbtn.ForeColor = System.Drawing.Color.White;
            this.searchrdbtn.Location = new System.Drawing.Point(45, 22);
            this.searchrdbtn.Name = "searchrdbtn";
            this.searchrdbtn.Size = new System.Drawing.Size(81, 24);
            this.searchrdbtn.TabIndex = 12;
            this.searchrdbtn.TabStop = true;
            this.searchrdbtn.Text = "Search";
            this.searchrdbtn.UseVisualStyleBackColor = true;
            this.searchrdbtn.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // changelocrdbtn
            // 
            this.changelocrdbtn.AutoSize = true;
            this.changelocrdbtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changelocrdbtn.ForeColor = System.Drawing.Color.White;
            this.changelocrdbtn.Location = new System.Drawing.Point(45, 71);
            this.changelocrdbtn.Name = "changelocrdbtn";
            this.changelocrdbtn.Size = new System.Drawing.Size(163, 24);
            this.changelocrdbtn.TabIndex = 13;
            this.changelocrdbtn.TabStop = true;
            this.changelocrdbtn.Text = "Change Location";
            this.changelocrdbtn.UseVisualStyleBackColor = true;
            this.changelocrdbtn.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(31, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 50);
            this.label6.TabIndex = 8;
            this.label6.Text = "Track Fast.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-5, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 34);
            this.panel1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(34, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 26);
            this.label7.TabIndex = 24;
            this.label7.Text = "Select a service";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.changelocrdbtn);
            this.panel2.Controls.Add(this.searchrdbtn);
            this.panel2.Location = new System.Drawing.Point(-5, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 111);
            this.panel2.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(245)))));
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(331, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 34);
            this.panel3.TabIndex = 25;
            this.panel3.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(39, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 26);
            this.label8.TabIndex = 24;
            this.label8.Text = "Enter Details";
            this.label8.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(414, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "LOCATION";
            this.label5.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(34, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 26);
            this.label9.TabIndex = 25;
            this.label9.Text = "Select a protocol";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(245)))));
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(-5, 285);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(273, 34);
            this.panel4.TabIndex = 26;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.radioButton1);
            this.panel5.Controls.Add(this.protocolrdbtn11);
            this.panel5.Controls.Add(this.protocolrdbtn09);
            this.panel5.Controls.Add(this.protocolrdbtn10);
            this.panel5.Location = new System.Drawing.Point(-5, 319);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(232, 157);
            this.panel5.TabIndex = 27;
            // 
            // ClientInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(577, 488);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.timeoutTxtbox);
            this.Controls.Add(this.portTxtbox);
            this.Controls.Add(this.serverTxtbox);
            this.Controls.Add(this.locationTxtbox);
            this.Controls.Add(this.usernameTxtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientInterface";
            this.Text = "ClientInterface";
            this.Load += new System.EventHandler(this.ClientInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTxtbox;
        private System.Windows.Forms.TextBox locationTxtbox;
        private System.Windows.Forms.TextBox serverTxtbox;
        private System.Windows.Forms.TextBox portTxtbox;
        private System.Windows.Forms.TextBox timeoutTxtbox;
        private System.Windows.Forms.RadioButton protocolrdbtn09;
        private System.Windows.Forms.RadioButton protocolrdbtn10;
        private System.Windows.Forms.RadioButton protocolrdbtn11;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton changelocrdbtn;
        private System.Windows.Forms.RadioButton searchrdbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
    }
}
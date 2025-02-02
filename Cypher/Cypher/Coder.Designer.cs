namespace Cypher
{
    partial class Coder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Coder));
            this.Exit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.csr_texBox = new System.Windows.Forms.TextBox();
            this.csr_trackBar = new System.Windows.Forms.TrackBar();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.vzn_textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.input_rtb = new System.Windows.Forms.RichTextBox();
            this.output_rtb = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Save_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rus_radioButton = new System.Windows.Forms.RadioButton();
            this.eng_radioButton = new System.Windows.Forms.RadioButton();
            this.enc_button = new System.Windows.Forms.Button();
            this.copy_code = new System.Windows.Forms.Button();
            this.quick_code = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.csr_trackBar)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Exit.Location = new System.Drawing.Point(496, 502);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(116, 27);
            this.Exit.TabIndex = 99;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_button);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(358, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(266, 496);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(258, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Atbash cipher";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(8, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 177);
            this.label5.TabIndex = 7;
            this.label5.Text = "The cipher usar\r\n an alphabet to function. Essentially, the letters in a message " +
    "are \'mirrored\' in the alphabet, so that \'a\' becomes \'z\', and \'b\' becomes \'y\', an" +
    "d so forth.";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.csr_texBox);
            this.tabPage2.Controls.Add(this.csr_trackBar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(258, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Caesar shift";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(8, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 311);
            this.label4.TabIndex = 6;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Shift value:";
            // 
            // csr_texBox
            // 
            this.csr_texBox.Location = new System.Drawing.Point(85, 6);
            this.csr_texBox.MaxLength = 6;
            this.csr_texBox.Name = "csr_texBox";
            this.csr_texBox.Size = new System.Drawing.Size(100, 20);
            this.csr_texBox.TabIndex = 4;
            this.csr_texBox.Text = "0";
            this.csr_texBox.TextChanged += new System.EventHandler(this.csr_texBox_TextChanged);
            // 
            // csr_trackBar
            // 
            this.csr_trackBar.Location = new System.Drawing.Point(6, 32);
            this.csr_trackBar.Maximum = 33;
            this.csr_trackBar.Minimum = -33;
            this.csr_trackBar.Name = "csr_trackBar";
            this.csr_trackBar.Size = new System.Drawing.Size(244, 45);
            this.csr_trackBar.TabIndex = 3;
            this.csr_trackBar.Scroll += new System.EventHandler(this.csr_trackBar_Scroll);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.vzn_textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(258, 470);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Vigenère cipher";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(6, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Copy key";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(6, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 257);
            this.label7.TabIndex = 7;
            this.label7.Text = resources.GetString("label7.Text");
            this.label7.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Encryption key:";
            // 
            // vzn_textBox1
            // 
            this.vzn_textBox1.Location = new System.Drawing.Point(6, 22);
            this.vzn_textBox1.Name = "vzn_textBox1";
            this.vzn_textBox1.Size = new System.Drawing.Size(244, 20);
            this.vzn_textBox1.TabIndex = 0;
            this.vzn_textBox1.TextChanged += new System.EventHandler(this.vzn_textBox1_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.input_rtb, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.output_rtb, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(352, 496);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // input_rtb
            // 
            this.input_rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.input_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.input_rtb.Location = new System.Drawing.Point(3, 28);
            this.input_rtb.Name = "input_rtb";
            this.input_rtb.Size = new System.Drawing.Size(346, 205);
            this.input_rtb.TabIndex = 0;
            this.input_rtb.Text = "";
            // 
            // output_rtb
            // 
            this.output_rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.output_rtb.Location = new System.Drawing.Point(3, 279);
            this.output_rtb.Name = "output_rtb";
            this.output_rtb.ReadOnly = true;
            this.output_rtb.Size = new System.Drawing.Size(346, 214);
            this.output_rtb.TabIndex = 1;
            this.output_rtb.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input text:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel2.Controls.Add(this.Save_button, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 239);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(346, 34);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // Save_button
            // 
            this.Save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Save_button.Location = new System.Drawing.Point(194, 3);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(149, 28);
            this.Save_button.TabIndex = 8;
            this.Save_button.Text = "Save output";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output text:";
            // 
            // rus_radioButton
            // 
            this.rus_radioButton.AutoSize = true;
            this.rus_radioButton.Location = new System.Drawing.Point(431, 512);
            this.rus_radioButton.Name = "rus_radioButton";
            this.rus_radioButton.Size = new System.Drawing.Size(63, 17);
            this.rus_radioButton.TabIndex = 3;
            this.rus_radioButton.Text = "Russian";
            this.rus_radioButton.UseVisualStyleBackColor = true;
            // 
            // eng_radioButton
            // 
            this.eng_radioButton.AutoSize = true;
            this.eng_radioButton.Checked = true;
            this.eng_radioButton.Location = new System.Drawing.Point(362, 512);
            this.eng_radioButton.Name = "eng_radioButton";
            this.eng_radioButton.Size = new System.Drawing.Size(59, 17);
            this.eng_radioButton.TabIndex = 4;
            this.eng_radioButton.TabStop = true;
            this.eng_radioButton.Text = "English";
            this.eng_radioButton.UseVisualStyleBackColor = true;
            // 
            // enc_button
            // 
            this.enc_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.enc_button.Location = new System.Drawing.Point(3, 502);
            this.enc_button.Name = "enc_button";
            this.enc_button.Size = new System.Drawing.Size(110, 33);
            this.enc_button.TabIndex = 1;
            this.enc_button.Text = "Encode";
            this.enc_button.UseVisualStyleBackColor = true;
            this.enc_button.Click += new System.EventHandler(this.enc_button_Click);
            // 
            // copy_code
            // 
            this.copy_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.copy_code.Location = new System.Drawing.Point(119, 502);
            this.copy_code.Name = "copy_code";
            this.copy_code.Size = new System.Drawing.Size(110, 33);
            this.copy_code.TabIndex = 2;
            this.copy_code.Text = "Copy output";
            this.copy_code.UseVisualStyleBackColor = true;
            this.copy_code.Click += new System.EventHandler(this.copy_code_Click);
            // 
            // quick_code
            // 
            this.quick_code.AutoSize = true;
            this.quick_code.Enabled = false;
            this.quick_code.Location = new System.Drawing.Point(235, 512);
            this.quick_code.Name = "quick_code";
            this.quick_code.Size = new System.Drawing.Size(101, 17);
            this.quick_code.TabIndex = 3;
            this.quick_code.Text = "Quick encoding";
            this.quick_code.UseVisualStyleBackColor = true;
            this.quick_code.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckFileExists = true;
            this.saveFileDialog1.FileName = "output.txt";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Coder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 541);
            this.Controls.Add(this.quick_code);
            this.Controls.Add(this.copy_code);
            this.Controls.Add(this.enc_button);
            this.Controls.Add(this.eng_radioButton);
            this.Controls.Add(this.rus_radioButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Exit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(640, 580);
            this.MinimumSize = new System.Drawing.Size(640, 580);
            this.Name = "Coder";
            this.Text = "PocketCypher : Coder";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Coder_FormClosed);
            this.Load += new System.EventHandler(this.Coder_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.csr_trackBar)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox input_rtb;
        private System.Windows.Forms.RichTextBox output_rtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton rus_radioButton;
        private System.Windows.Forms.RadioButton eng_radioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox csr_texBox;
        private System.Windows.Forms.TrackBar csr_trackBar;
        private System.Windows.Forms.Button enc_button;
        private System.Windows.Forms.Button copy_code;
        private System.Windows.Forms.CheckBox quick_code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vzn_textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
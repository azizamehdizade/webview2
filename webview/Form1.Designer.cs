namespace webview2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            tabPage2 = new TabPage();
            webView22 = new Microsoft.Web.WebView2.WinForms.WebView2();
            tabPage3 = new TabPage();
            panel2 = new Panel();
            button5 = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            button6 = new Button();
            listBox2 = new ListBox();
            label2 = new Label();
            listBox1 = new ListBox();
            label1 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView22).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 6, 5, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1268, 1120);
            panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 9F);
            tabControl1.ItemSize = new Size(75, 26);
            tabControl1.Location = new Point(0, 96);
            tabControl1.Margin = new Padding(5, 6, 5, 6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1266, 1022);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(webView21);
            tabPage1.Location = new Point(8, 34);
            tabPage1.Margin = new Padding(5, 6, 5, 6);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1250, 980);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tab 1";
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Fill;
            webView21.Location = new Point(3, 4);
            webView21.Margin = new Padding(5, 6, 5, 6);
            webView21.Name = "webView21";
            webView21.Size = new Size(1244, 972);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            webView21.NavigationCompleted += webView21_NavigationCompleted;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(webView22);
            tabPage2.Location = new Point(8, 34);
            tabPage2.Margin = new Padding(5, 6, 5, 6);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1248, 978);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tab 2";
            // 
            // webView22
            // 
            webView22.AllowExternalDrop = true;
            webView22.CreationProperties = null;
            webView22.DefaultBackgroundColor = Color.White;
            webView22.Dock = DockStyle.Fill;
            webView22.Location = new Point(3, 4);
            webView22.Margin = new Padding(5, 6, 5, 6);
            webView22.Name = "webView22";
            webView22.Size = new Size(1242, 970);
            webView22.TabIndex = 0;
            webView22.ZoomFactor = 1D;
            webView22.NavigationCompleted += webView21_NavigationCompleted;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.White;
            tabPage3.Location = new Point(8, 34);
            tabPage3.Margin = new Padding(5, 6, 5, 6);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(1248, 978);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "+";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(226, 230, 234);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(5, 6, 5, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1266, 96);
            panel2.TabIndex = 0;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(212, 237, 218);
            button5.FlatAppearance.BorderColor = Color.FromArgb(163, 194, 170);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button5.Location = new Point(1130, 18);
            button5.Margin = new Padding(5, 6, 5, 6);
            button5.Name = "button5";
            button5.Size = new Size(120, 60);
            button5.TabIndex = 5;
            button5.Text = "Get";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 9.5F);
            textBox1.Location = new Point(273, 20);
            textBox1.Margin = new Padding(5, 6, 5, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(842, 41);
            textBox1.TabIndex = 4;
            textBox1.Text = "https://www.google.com";
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderColor = Color.Silver;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10F);
            button4.Location = new Point(205, 18);
            button4.Margin = new Padding(5, 6, 5, 6);
            button4.Name = "button4";
            button4.Size = new Size(55, 60);
            button4.TabIndex = 3;
            button4.Text = "⌂";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderColor = Color.Silver;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F);
            button3.Location = new Point(141, 18);
            button3.Margin = new Padding(5, 6, 5, 6);
            button3.Name = "button3";
            button3.Size = new Size(55, 60);
            button3.TabIndex = 2;
            button3.Text = "⟳";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F);
            button2.Location = new Point(78, 18);
            button2.Margin = new Padding(5, 6, 5, 6);
            button2.Name = "button2";
            button2.Size = new Size(55, 60);
            button2.TabIndex = 1;
            button2.Text = "→";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(15, 18);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(55, 60);
            button1.TabIndex = 0;
            button1.Text = "←";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(248, 249, 250);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(button6);
            panel3.Controls.Add(listBox2);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(listBox1);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1268, 0);
            panel3.Margin = new Padding(5, 6, 5, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(438, 1120);
            panel3.TabIndex = 1;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(255, 243, 176);
            button6.FlatAppearance.BorderColor = Color.FromArgb(214, 198, 122);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            button6.Location = new Point(26, 930);
            button6.Margin = new Padding(5, 6, 5, 6);
            button6.Name = "button6";
            button6.Size = new Size(384, 72);
            button6.TabIndex = 4;
            button6.Text = "Seçilmişlərə əlavə et";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.White;
            listBox2.BorderStyle = BorderStyle.FixedSingle;
            listBox2.Font = new Font("Segoe UI", 9F);
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(26, 536);
            listBox2.Margin = new Padding(5, 6, 5, 6);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(382, 354);
            listBox2.TabIndex = 3;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(26, 480);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(228, 37);
            label2.TabIndex = 2;
            label2.Text = "Tarixçə (ListBox)";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Font = new Font("Segoe UI", 9F);
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "google.com", "wikipedia.org", "youtube.com", "azertag.az" });
            listBox1.Location = new Point(26, 92);
            listBox1.Margin = new Padding(5, 6, 5, 6);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(382, 354);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(26, 36);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(275, 37);
            label1.TabIndex = 0;
            label1.Text = "Seçilmişlər (ListBox)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1706, 1120);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Mini Brauzer ";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView22).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView22;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button6;
    }
}
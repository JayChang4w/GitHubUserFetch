namespace GitHubUserFetch
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnQuery = new ReaLTaiizor.Controls.MetroDefaultButton();
            this.numPerSize = new ReaLTaiizor.Controls.MetroNumeric();
            this.btnPrev = new ReaLTaiizor.Controls.MetroButton();
            this.btnNext = new ReaLTaiizor.Controls.MetroButton();
            this.lblPerPage = new ReaLTaiizor.Controls.MetroLabel();
            this.lblPageNumber = new ReaLTaiizor.Controls.MetroLabel();
            this.txtPageNumber = new ReaLTaiizor.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnQuery
            // 
            this.btnQuery.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnQuery.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnQuery.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btnQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuery.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnQuery.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnQuery.HoverTextColor = System.Drawing.Color.White;
            this.btnQuery.IsDerivedStyle = true;
            this.btnQuery.Location = new System.Drawing.Point(715, 10);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnQuery.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnQuery.NormalTextColor = System.Drawing.Color.Black;
            this.btnQuery.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnQuery.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnQuery.PressTextColor = System.Drawing.Color.White;
            this.btnQuery.Size = new System.Drawing.Size(81, 41);
            this.btnQuery.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.btnQuery.StyleManager = null;
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "Query";
            this.btnQuery.ThemeAuthor = "Taiizor";
            this.btnQuery.ThemeName = "MetroLight";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // numPerSize
            // 
            this.numPerSize.BackColor = System.Drawing.Color.Transparent;
            this.numPerSize.BackgroundColor = System.Drawing.Color.Empty;
            this.numPerSize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.numPerSize.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.numPerSize.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.numPerSize.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.numPerSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numPerSize.IsDerivedStyle = true;
            this.numPerSize.Location = new System.Drawing.Point(113, 22);
            this.numPerSize.Maximum = 100;
            this.numPerSize.Minimum = 10;
            this.numPerSize.Name = "numPerSize";
            this.numPerSize.Size = new System.Drawing.Size(87, 26);
            this.numPerSize.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.numPerSize.StyleManager = null;
            this.numPerSize.SymbolsColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.numPerSize.TabIndex = 1;
            this.numPerSize.Text = "metroNumeric1";
            this.numPerSize.ThemeAuthor = "Taiizor";
            this.numPerSize.ThemeName = "MetroLight";
            this.numPerSize.Value = 10;
            // 
            // btnPrev
            // 
            this.btnPrev.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnPrev.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnPrev.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrev.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnPrev.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnPrev.HoverTextColor = System.Drawing.Color.White;
            this.btnPrev.IsDerivedStyle = true;
            this.btnPrev.Location = new System.Drawing.Point(461, 22);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnPrev.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnPrev.NormalTextColor = System.Drawing.Color.White;
            this.btnPrev.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnPrev.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnPrev.PressTextColor = System.Drawing.Color.White;
            this.btnPrev.Size = new System.Drawing.Size(94, 29);
            this.btnPrev.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.btnPrev.StyleManager = null;
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "Prev";
            this.btnPrev.ThemeAuthor = "Taiizor";
            this.btnPrev.ThemeName = "MetroLight";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnNext.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnNext.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnNext.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnNext.HoverTextColor = System.Drawing.Color.White;
            this.btnNext.IsDerivedStyle = true;
            this.btnNext.Location = new System.Drawing.Point(585, 22);
            this.btnNext.Name = "btnNext";
            this.btnNext.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnNext.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnNext.NormalTextColor = System.Drawing.Color.White;
            this.btnNext.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnNext.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnNext.PressTextColor = System.Drawing.Color.White;
            this.btnNext.Size = new System.Drawing.Size(94, 29);
            this.btnNext.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.btnNext.StyleManager = null;
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.ThemeAuthor = "Taiizor";
            this.btnNext.ThemeName = "MetroLight";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPerPage
            // 
            this.lblPerPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPerPage.IsDerivedStyle = true;
            this.lblPerPage.Location = new System.Drawing.Point(33, 22);
            this.lblPerPage.Name = "lblPerPage";
            this.lblPerPage.Size = new System.Drawing.Size(74, 29);
            this.lblPerPage.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblPerPage.StyleManager = null;
            this.lblPerPage.TabIndex = 4;
            this.lblPerPage.Text = "PerPage";
            this.lblPerPage.ThemeAuthor = "Taiizor";
            this.lblPerPage.ThemeName = "MetroLight";
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPageNumber.IsDerivedStyle = true;
            this.lblPageNumber.Location = new System.Drawing.Point(232, 22);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(110, 29);
            this.lblPageNumber.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblPageNumber.StyleManager = null;
            this.lblPageNumber.TabIndex = 5;
            this.lblPageNumber.Text = "PageNumber";
            this.lblPageNumber.ThemeAuthor = "Taiizor";
            this.lblPageNumber.ThemeName = "MetroLight";
            // 
            // txtPageNumber
            // 
            this.txtPageNumber.AutoCompleteCustomSource = null;
            this.txtPageNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPageNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPageNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtPageNumber.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPageNumber.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtPageNumber.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtPageNumber.Enabled = false;
            this.txtPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPageNumber.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtPageNumber.Image = null;
            this.txtPageNumber.IsDerivedStyle = true;
            this.txtPageNumber.Lines = null;
            this.txtPageNumber.Location = new System.Drawing.Point(348, 22);
            this.txtPageNumber.MaxLength = 32767;
            this.txtPageNumber.Multiline = false;
            this.txtPageNumber.Name = "txtPageNumber";
            this.txtPageNumber.ReadOnly = false;
            this.txtPageNumber.Size = new System.Drawing.Size(87, 29);
            this.txtPageNumber.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.txtPageNumber.StyleManager = null;
            this.txtPageNumber.TabIndex = 6;
            this.txtPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPageNumber.ThemeAuthor = "Taiizor";
            this.txtPageNumber.ThemeName = "MetroLight";
            this.txtPageNumber.UseSystemPasswordChar = false;
            this.txtPageNumber.WatermarkText = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 877);
            this.Controls.Add(this.txtPageNumber);
            this.Controls.Add(this.lblPageNumber);
            this.Controls.Add(this.lblPerPage);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.numPerSize);
            this.Controls.Add(this.btnQuery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(12, 90, 12, 12);
            this.ShowLeftRect = false;
            this.Text = "GitHub Users";
            this.TextColor = System.Drawing.Color.White;
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MetroDefaultButton btnQuery;
        private ReaLTaiizor.Controls.MetroNumeric numPerSize;
        private ReaLTaiizor.Controls.MetroButton btnPrev;
        private ReaLTaiizor.Controls.MetroButton btnNext;
        private ReaLTaiizor.Controls.MetroLabel lblPerPage;
        private ReaLTaiizor.Controls.MetroLabel lblPageNumber;
        private ReaLTaiizor.Controls.MetroTextBox txtPageNumber;
    }
}
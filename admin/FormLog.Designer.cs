using System;
using System.Drawing;
using System.Windows.Forms;

namespace DuplicateLKS.admin
{
    partial class FormLog
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtHour = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dateFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dateUntil = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnFilter = new Guna.UI2.WinForms.Guna2Button();
            tableLog = new Guna.UI2.WinForms.Guna2DataGridView();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)tableLog).BeginInit();
            SuspendLayout();
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Microsoft Tai Le", 20F);
            guna2HtmlLabel3.ForeColor = Color.DarkGray;
            guna2HtmlLabel3.Location = new Point(12, 12);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(228, 36);
            guna2HtmlLabel3.TabIndex = 2;
            guna2HtmlLabel3.Text = "Pages / Dashboard";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Microsoft Tai Le", 50F, FontStyle.Bold);
            guna2HtmlLabel2.ForeColor = Color.Black;
            guna2HtmlLabel2.Location = new Point(10, 37);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(378, 87);
            guna2HtmlLabel2.TabIndex = 3;
            guna2HtmlLabel2.Text = "Log Activity";
            // 
            // txtDate
            // 
            txtDate.BackColor = Color.Transparent;
            txtDate.Font = new Font("Microsoft Tai Le", 20F);
            txtDate.ForeColor = Color.Black;
            txtDate.Location = new Point(1230, 12);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(161, 36);
            txtDate.TabIndex = 2;
            txtDate.Text = "Hari, Tanggal";
            // 
            // txtHour
            // 
            txtHour.BackColor = Color.Transparent;
            txtHour.Font = new Font("Microsoft Tai Le", 20F);
            txtHour.ForeColor = Color.Black;
            txtHour.Location = new Point(1353, 54);
            txtHour.Name = "txtHour";
            txtHour.Size = new Size(50, 36);
            txtHour.TabIndex = 2;
            txtHour.Text = "Jam";
            // 
            // dateFrom
            // 
            dateFrom.BorderRadius = 16;
            dateFrom.Checked = true;
            dateFrom.CustomizableEdges = customizableEdges1;
            dateFrom.FillColor = Color.White;
            dateFrom.Font = new Font("Microsoft Sans Serif", 12F);
            dateFrom.ForeColor = Color.Black;
            dateFrom.Format = DateTimePickerFormat.Long;
            dateFrom.Location = new Point(12, 184);
            dateFrom.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dateFrom.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dateFrom.Name = "dateFrom";
            dateFrom.ShadowDecoration.CustomizableEdges = customizableEdges2;
            dateFrom.Size = new Size(350, 59);
            dateFrom.TabIndex = 4;
            dateFrom.Value = new DateTime(2025, 6, 11, 8, 33, 13, 658);
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Font = new Font("Microsoft Tai Le", 18F);
            guna2HtmlLabel5.ForeColor = Color.Black;
            guna2HtmlLabel5.Location = new Point(12, 146);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(138, 32);
            guna2HtmlLabel5.TabIndex = 5;
            guna2HtmlLabel5.Text = "Dari Tanggal";
            // 
            // dateUntil
            // 
            dateUntil.BorderRadius = 16;
            dateUntil.Checked = true;
            dateUntil.CustomizableEdges = customizableEdges3;
            dateUntil.FillColor = Color.White;
            dateUntil.Font = new Font("Microsoft Sans Serif", 12F);
            dateUntil.ForeColor = Color.Black;
            dateUntil.Format = DateTimePickerFormat.Long;
            dateUntil.Location = new Point(383, 184);
            dateUntil.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dateUntil.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dateUntil.Name = "dateUntil";
            dateUntil.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dateUntil.Size = new Size(350, 59);
            dateUntil.TabIndex = 4;
            dateUntil.Value = new DateTime(2025, 6, 11, 8, 33, 13, 658);
            // 
            // guna2HtmlLabel6
            // 
            guna2HtmlLabel6.BackColor = Color.Transparent;
            guna2HtmlLabel6.Font = new Font("Microsoft Tai Le", 18F);
            guna2HtmlLabel6.ForeColor = Color.Black;
            guna2HtmlLabel6.Location = new Point(383, 146);
            guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            guna2HtmlLabel6.Size = new Size(173, 32);
            guna2HtmlLabel6.TabIndex = 5;
            guna2HtmlLabel6.Text = "Sampai Tanggal";
            // 
            // btnFilter
            // 
            btnFilter.BorderRadius = 16;
            btnFilter.CustomizableEdges = customizableEdges5;
            btnFilter.DisabledState.BorderColor = Color.DarkGray;
            btnFilter.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFilter.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFilter.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFilter.Font = new Font("Microsoft Sans Serif", 16F);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(748, 184);
            btnFilter.Name = "btnFilter";
            btnFilter.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnFilter.Size = new Size(233, 59);
            btnFilter.TabIndex = 6;
            btnFilter.Text = "Filter";
            btnFilter.Click += btnFilter_Click;
            // 
            // tableLog
            // 
            tableLog.AllowUserToAddRows = false;
            tableLog.AllowUserToDeleteRows = false;
            tableLog.AllowUserToResizeColumns = false;
            tableLog.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            tableLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tableLog.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(232, 234, 237);
            dataGridViewCellStyle2.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tableLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tableLog.ColumnHeadersHeight = 35;
            tableLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(239, 241, 243);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            tableLog.DefaultCellStyle = dataGridViewCellStyle3;
            tableLog.GridColor = Color.FromArgb(239, 241, 243);
            tableLog.Location = new Point(12, 267);
            tableLog.MultiSelect = false;
            tableLog.Name = "tableLog";
            tableLog.ReadOnly = true;
            tableLog.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Microsoft Tai Le", 12F);
            tableLog.RowsDefaultCellStyle = dataGridViewCellStyle4;
            tableLog.Size = new Size(1447, 765);
            tableLog.TabIndex = 7;
            tableLog.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            tableLog.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            tableLog.ThemeStyle.AlternatingRowsStyle.Font = null;
            tableLog.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            tableLog.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            tableLog.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            tableLog.ThemeStyle.BackColor = Color.WhiteSmoke;
            tableLog.ThemeStyle.GridColor = Color.FromArgb(239, 241, 243);
            tableLog.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(232, 234, 237);
            tableLog.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            tableLog.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            tableLog.ThemeStyle.HeaderStyle.ForeColor = Color.Black;
            tableLog.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tableLog.ThemeStyle.HeaderStyle.Height = 35;
            tableLog.ThemeStyle.ReadOnly = true;
            tableLog.ThemeStyle.RowsStyle.BackColor = Color.White;
            tableLog.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tableLog.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            tableLog.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            tableLog.ThemeStyle.RowsStyle.Height = 25;
            tableLog.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(239, 241, 243);
            tableLog.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FormLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1471, 1080);
            Controls.Add(tableLog);
            Controls.Add(btnFilter);
            Controls.Add(guna2HtmlLabel6);
            Controls.Add(guna2HtmlLabel5);
            Controls.Add(dateUntil);
            Controls.Add(dateFrom);
            Controls.Add(txtHour);
            Controls.Add(txtDate);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(guna2HtmlLabel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLog";
            Text = "FormLog";
            Load += FormLog_Load;
            ((System.ComponentModel.ISupportInitialize)tableLog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtHour;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateFrom;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateUntil;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private Guna.UI2.WinForms.Guna2DataGridView tableLog;
        private System.Windows.Forms.Timer timer1;
    }
}
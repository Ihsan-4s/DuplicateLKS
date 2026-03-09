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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtHour = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dateFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dateUntil = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.tableLog = new Guna.UI2.WinForms.Guna2DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tableLog)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Tai Le", 20F);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(10, 10);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(228, 36);
            this.guna2HtmlLabel3.TabIndex = 2;
            this.guna2HtmlLabel3.Text = "Pages / Dashboard";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Tai Le", 50F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(9, 32);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(378, 87);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Log Activity";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.Transparent;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Tai Le", 20F);
            this.txtDate.ForeColor = System.Drawing.Color.Black;
            this.txtDate.Location = new System.Drawing.Point(1054, 10);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(161, 36);
            this.txtDate.TabIndex = 2;
            this.txtDate.Text = "Hari, Tanggal";
            // 
            // txtHour
            // 
            this.txtHour.BackColor = System.Drawing.Color.Transparent;
            this.txtHour.Font = new System.Drawing.Font("Microsoft Tai Le", 20F);
            this.txtHour.ForeColor = System.Drawing.Color.Black;
            this.txtHour.Location = new System.Drawing.Point(1160, 47);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(50, 36);
            this.txtHour.TabIndex = 2;
            this.txtHour.Text = "Jam";
            // 
            // dateFrom
            // 
            this.dateFrom.BorderRadius = 16;
            this.dateFrom.Checked = true;
            this.dateFrom.FillColor = System.Drawing.Color.White;
            this.dateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateFrom.ForeColor = System.Drawing.Color.Black;
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateFrom.Location = new System.Drawing.Point(10, 159);
            this.dateFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(300, 51);
            this.dateFrom.TabIndex = 4;
            this.dateFrom.Value = new System.DateTime(2025, 6, 11, 8, 33, 13, 658);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Tai Le", 18F);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(10, 127);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(138, 32);
            this.guna2HtmlLabel5.TabIndex = 5;
            this.guna2HtmlLabel5.Text = "Dari Tanggal";
            // 
            // dateUntil
            // 
            this.dateUntil.BorderRadius = 16;
            this.dateUntil.Checked = true;
            this.dateUntil.FillColor = System.Drawing.Color.White;
            this.dateUntil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateUntil.ForeColor = System.Drawing.Color.Black;
            this.dateUntil.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateUntil.Location = new System.Drawing.Point(328, 159);
            this.dateUntil.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateUntil.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateUntil.Name = "dateUntil";
            this.dateUntil.Size = new System.Drawing.Size(300, 51);
            this.dateUntil.TabIndex = 4;
            this.dateUntil.Value = new System.DateTime(2025, 6, 11, 8, 33, 13, 658);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Tai Le", 18F);
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(328, 127);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(173, 32);
            this.guna2HtmlLabel6.TabIndex = 5;
            this.guna2HtmlLabel6.Text = "Sampai Tanggal";
            // 
            // btnFilter
            // 
            this.btnFilter.BorderRadius = 16;
            this.btnFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(641, 159);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(200, 51);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "Filter";
            // 
            // tableLog
            // 
            this.tableLog.AllowUserToAddRows = false;
            this.tableLog.AllowUserToDeleteRows = false;
            this.tableLog.AllowUserToResizeColumns = false;
            this.tableLog.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.tableLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tableLog.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tableLog.ColumnHeadersHeight = 35;
            this.tableLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableLog.DefaultCellStyle = dataGridViewCellStyle7;
            this.tableLog.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.tableLog.Location = new System.Drawing.Point(10, 231);
            this.tableLog.MultiSelect = false;
            this.tableLog.Name = "tableLog";
            this.tableLog.ReadOnly = true;
            this.tableLog.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.tableLog.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.tableLog.RowTemplate.Height = 25;
            this.tableLog.Size = new System.Drawing.Size(1240, 663);
            this.tableLog.TabIndex = 7;
            this.tableLog.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.tableLog.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tableLog.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tableLog.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tableLog.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tableLog.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tableLog.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLog.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.tableLog.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.tableLog.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableLog.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tableLog.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.tableLog.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tableLog.ThemeStyle.HeaderStyle.Height = 35;
            this.tableLog.ThemeStyle.ReadOnly = true;
            this.tableLog.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableLog.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableLog.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tableLog.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tableLog.ThemeStyle.RowsStyle.Height = 25;
            this.tableLog.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.tableLog.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // FormLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1218, 936);
            this.Controls.Add(this.tableLog);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.dateUntil);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLog";
            this.Text = "FormLog";
            ((System.ComponentModel.ISupportInitialize)(this.tableLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
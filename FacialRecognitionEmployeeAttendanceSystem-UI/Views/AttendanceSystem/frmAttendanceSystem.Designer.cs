﻿namespace FacialRecognitionEmployeeAttendanceSystem_UI.Views
{
    partial class frmAttendanceSystem
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
            this.btnFacialRecognitionMode = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbCamera = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPinMode = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCheckAttendanceHistory = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFacialRecognitionMode
            // 
            this.btnFacialRecognitionMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFacialRecognitionMode.Location = new System.Drawing.Point(3, 3);
            this.btnFacialRecognitionMode.Name = "btnFacialRecognitionMode";
            this.btnFacialRecognitionMode.Size = new System.Drawing.Size(263, 44);
            this.btnFacialRecognitionMode.TabIndex = 0;
            this.btnFacialRecognitionMode.Text = "Facial Recognition Mode";
            this.btnFacialRecognitionMode.UseVisualStyleBackColor = true;
            this.btnFacialRecognitionMode.Click += new System.EventHandler(this.btnFacialRecognitionMode_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.pbCamera, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(921, 488);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pbCamera
            // 
            this.pbCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCamera.Location = new System.Drawing.Point(5, 5);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(634, 478);
            this.pbCamera.TabIndex = 2;
            this.pbCamera.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnPinMode, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnFacialRecognitionMode, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnConfirm, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(647, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(269, 478);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnPinMode
            // 
            this.btnPinMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPinMode.Location = new System.Drawing.Point(3, 53);
            this.btnPinMode.Name = "btnPinMode";
            this.btnPinMode.Size = new System.Drawing.Size(263, 45);
            this.btnPinMode.TabIndex = 1;
            this.btnPinMode.Text = "PIN Mode";
            this.btnPinMode.UseVisualStyleBackColor = true;
            this.btnPinMode.Click += new System.EventHandler(this.btnPinMode_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 43);
            this.panel1.TabIndex = 2;
            // 
            // txtPin
            // 
            this.txtPin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPin.Location = new System.Drawing.Point(0, 0);
            this.txtPin.Multiline = true;
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(263, 43);
            this.txtPin.TabIndex = 0;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfirm.Location = new System.Drawing.Point(3, 153);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(263, 44);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCheckAttendanceHistory);
            this.panel2.Controls.Add(this.btnMainMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 272);
            this.panel2.TabIndex = 4;
            // 
            // btnCheckAttendanceHistory
            // 
            this.btnCheckAttendanceHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheckAttendanceHistory.Location = new System.Drawing.Point(0, 0);
            this.btnCheckAttendanceHistory.Name = "btnCheckAttendanceHistory";
            this.btnCheckAttendanceHistory.Size = new System.Drawing.Size(263, 44);
            this.btnCheckAttendanceHistory.TabIndex = 1;
            this.btnCheckAttendanceHistory.Text = "Check Attendance History";
            this.btnCheckAttendanceHistory.UseVisualStyleBackColor = true;
            this.btnCheckAttendanceHistory.Click += new System.EventHandler(this.btnCheckAttendanceHistory_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMainMenu.Location = new System.Drawing.Point(0, 228);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(263, 44);
            this.btnMainMenu.TabIndex = 0;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // frmAttendanceSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 488);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmAttendanceSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance System";
            this.Load += new System.EventHandler(this.frmAttendanceSystem_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFacialRecognitionMode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnPinMode;
        private System.Windows.Forms.PictureBox pbCamera;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnCheckAttendanceHistory;
    }
}
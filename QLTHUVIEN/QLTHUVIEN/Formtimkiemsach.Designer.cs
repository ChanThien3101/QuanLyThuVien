﻿/*
@author HuuDuc_20NS_VKU
*/
namespace WindowsFormsApplication1
{
    partial class Formtimkiemsach
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ramasach = new System.Windows.Forms.RadioButton();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.ratensach = new System.Windows.Forms.RadioButton();
            this.luoi = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(288, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "TÌM KIẾM SÁCH ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.ramasach);
            this.groupBox1.Controls.Add(this.txttimkiem);
            this.groupBox1.Controls.Add(this.ratensach);
            this.groupBox1.Location = new System.Drawing.Point(52, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 92);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 39;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(466, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 38;
            this.button2.Text = "Tìm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ramasach
            // 
            this.ramasach.AutoSize = true;
            this.ramasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ramasach.Location = new System.Drawing.Point(41, 29);
            this.ramasach.Name = "ramasach";
            this.ramasach.Size = new System.Drawing.Size(99, 28);
            this.ramasach.TabIndex = 36;
            this.ramasach.TabStop = true;
            this.ramasach.Text = "Mã sách";
            this.ramasach.UseVisualStyleBackColor = true;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(155, 36);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(293, 20);
            this.txttimkiem.TabIndex = 37;
            // 
            // ratensach
            // 
            this.ratensach.AutoSize = true;
            this.ratensach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ratensach.Location = new System.Drawing.Point(41, 63);
            this.ratensach.Name = "ratensach";
            this.ratensach.Size = new System.Drawing.Size(107, 28);
            this.ratensach.TabIndex = 35;
            this.ratensach.TabStop = true;
            this.ratensach.Text = "Tên sách";
            this.ratensach.UseVisualStyleBackColor = true;
            // 
            // luoi
            // 
            this.luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoi.Location = new System.Drawing.Point(52, 179);
            this.luoi.Name = "luoi";
            this.luoi.Size = new System.Drawing.Size(605, 265);
            this.luoi.TabIndex = 35;
            // 
            // Formtimkiemsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 456);
            this.Controls.Add(this.luoi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Formtimkiemsach";
            this.Text = "Formtimkiemsach";
            this.Load += new System.EventHandler(this.Formtimkiemsach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton ramasach;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.RadioButton ratensach;
        private System.Windows.Forms.DataGridView luoi;
        private System.Windows.Forms.Button button1;
    }
}
﻿
namespace AlarmSystem
{
    partial class CustomRepetitionPage
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
            this.updownRepetition = new System.Windows.Forms.NumericUpDown();
            this.lbltitle = new System.Windows.Forms.Label();
            this.RepeatList = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updownRepetition)).BeginInit();
            this.SuspendLayout();
            // 
            // updownRepetition
            // 
            this.updownRepetition.Location = new System.Drawing.Point(84, 227);
            this.updownRepetition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updownRepetition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updownRepetition.Name = "updownRepetition";
            this.updownRepetition.Size = new System.Drawing.Size(160, 22);
            this.updownRepetition.TabIndex = 0;
            this.updownRepetition.UseWaitCursor = true;
            this.updownRepetition.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(128, 66);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(71, 16);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "Repetition:";
            this.lbltitle.UseWaitCursor = true;
            // 
            // RepeatList
            // 
            this.RepeatList.AutoSize = true;
            this.RepeatList.Location = new System.Drawing.Point(132, 109);
            this.RepeatList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RepeatList.Name = "RepeatList";
            this.RepeatList.Size = new System.Drawing.Size(21, 16);
            this.RepeatList.TabIndex = 2;
            this.RepeatList.Text = "<>";
            this.RepeatList.UseWaitCursor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(105, 358);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.UseWaitCursor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 420);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomRepetitionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.RepeatList);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.updownRepetition);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustomRepetitionPage";
            this.Text = "Custom Repetition";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.CustomRepetition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updownRepetition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown updownRepetition;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label RepeatList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
    }
}
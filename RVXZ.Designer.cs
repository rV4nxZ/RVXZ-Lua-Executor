﻿using System.ComponentModel;

namespace RVXZ
{
    partial class RVXZ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RVXZ));
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.scriptInput = new System.Windows.Forms.RichTextBox();
            this.txtIsAttached = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(12, 392);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(163, 46);
            this.btnAttach.TabIndex = 1;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.BtnAttach_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(181, 392);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(163, 46);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // scriptInput
            // 
            this.scriptInput.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scriptInput.Location = new System.Drawing.Point(12, 12);
            this.scriptInput.Name = "scriptInput";
            this.scriptInput.Size = new System.Drawing.Size(765, 374);
            this.scriptInput.TabIndex = 3;
            this.scriptInput.Text = "--Paste any script here--\nprint(\"Hello, Roblox!\")";
            // 
            // txtIsAttached
            // 
            this.txtIsAttached.AutoSize = true;
            this.txtIsAttached.Location = new System.Drawing.Point(504, 408);
            this.txtIsAttached.Name = "txtIsAttached";
            this.txtIsAttached.Size = new System.Drawing.Size(77, 15);
            this.txtIsAttached.TabIndex = 5;
            this.txtIsAttached.Text = "txtIsAttached";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RVXZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIsAttached);
            this.Controls.Add(this.scriptInput);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnAttach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RVXZ";
            this.Text = "RVXZ";
            this.Load += new System.EventHandler(this.RVXZ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.RichTextBox scriptInput;
        private Label txtIsAttached;
        private System.Windows.Forms.Timer timer1;
    }
}
﻿namespace SettlersCardTracker
{
    partial class BuySettlementForm
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
            this.txtNewValue = new System.Windows.Forms.TextBox();
            this.txtNewType = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnBuySettlementSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNewValue
            // 
            this.txtNewValue.Location = new System.Drawing.Point(32, 113);
            this.txtNewValue.MaxLength = 8;
            this.txtNewValue.Name = "txtNewValue";
            this.txtNewValue.Size = new System.Drawing.Size(100, 20);
            this.txtNewValue.TabIndex = 0;
            this.txtNewValue.TextChanged += new System.EventHandler(this.txtNewValue_TextChanged);
            // 
            // txtNewType
            // 
            this.txtNewType.Location = new System.Drawing.Point(151, 113);
            this.txtNewType.MaxLength = 5;
            this.txtNewType.Name = "txtNewType";
            this.txtNewType.Size = new System.Drawing.Size(100, 20);
            this.txtNewType.TabIndex = 1;
            this.txtNewType.TextChanged += new System.EventHandler(this.txtNewType_TextChanged);
            // 
            // lblInfo
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(29, 52);
            this.lblInstructions.Name = "lblInfo";
            this.lblInstructions.Size = new System.Drawing.Size(235, 26);
            this.lblInstructions.TabIndex = 3;
            this.lblInstructions.Text = "Enter resource values and corresponding types: \r\n(ex. 8,5,4 / W,T,S) (T = wheat)";
            // 
            // btnBuySettlementSubmit
            // 
            this.btnBuySettlementSubmit.Location = new System.Drawing.Point(105, 200);
            this.btnBuySettlementSubmit.Name = "btnBuySettlementSubmit";
            this.btnBuySettlementSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnBuySettlementSubmit.TabIndex = 2;
            this.btnBuySettlementSubmit.Text = "Submit";
            this.btnBuySettlementSubmit.UseVisualStyleBackColor = true;
            this.btnBuySettlementSubmit.Click += new System.EventHandler(this.btnBuySettlementSubmit_Click);
            // 
            // BuySettlementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.btnBuySettlementSubmit);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.txtNewType);
            this.Controls.Add(this.txtNewValue);
            this.Name = "BuySettlementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BuySettlement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewValue;
        private System.Windows.Forms.TextBox txtNewType;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnBuySettlementSubmit;
    }
}
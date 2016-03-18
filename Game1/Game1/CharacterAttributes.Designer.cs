﻿namespace Game1
{
    partial class CharacterAttributes
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.healthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.strengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dexterityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.submitButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.healthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strengthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexterityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assign Your Character\'s Attributes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Points to Allocate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Health:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Strength:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Dexterity:";
            // 
            // healthNumericUpDown
            // 
            this.healthNumericUpDown.Location = new System.Drawing.Point(97, 73);
            this.healthNumericUpDown.Name = "healthNumericUpDown";
            this.healthNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.healthNumericUpDown.TabIndex = 7;
            this.healthNumericUpDown.ValueChanged += new System.EventHandler(this.healthNumericUpDown_ValueChanged);
            // 
            // strengthNumericUpDown
            // 
            this.strengthNumericUpDown.Location = new System.Drawing.Point(97, 108);
            this.strengthNumericUpDown.Name = "strengthNumericUpDown";
            this.strengthNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.strengthNumericUpDown.TabIndex = 8;
            this.strengthNumericUpDown.ValueChanged += new System.EventHandler(this.strengthNumericUpDown_ValueChanged);
            // 
            // dexterityNumericUpDown
            // 
            this.dexterityNumericUpDown.Location = new System.Drawing.Point(97, 143);
            this.dexterityNumericUpDown.Name = "dexterityNumericUpDown";
            this.dexterityNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.dexterityNumericUpDown.TabIndex = 9;
            this.dexterityNumericUpDown.ValueChanged += new System.EventHandler(this.dexterityNumericUpDown_ValueChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(97, 201);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CharacterAttributes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.dexterityNumericUpDown);
            this.Controls.Add(this.strengthNumericUpDown);
            this.Controls.Add(this.healthNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CharacterAttributes";
            this.Text = "CharacterAttributes";
            this.Load += new System.EventHandler(this.CharacterAttributes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.healthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strengthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexterityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown healthNumericUpDown;
        private System.Windows.Forms.NumericUpDown strengthNumericUpDown;
        private System.Windows.Forms.NumericUpDown dexterityNumericUpDown;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}
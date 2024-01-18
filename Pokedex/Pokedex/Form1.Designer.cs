namespace Pokedex
{
    partial class Form1
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
            this.AttackCombo = new System.Windows.Forms.ComboBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.LevelUp = new System.Windows.Forms.NumericUpDown();
            this.LegendaryCheck = new System.Windows.Forms.CheckBox();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.HpUp = new System.Windows.Forms.NumericUpDown();
            this.EXPUp = new System.Windows.Forms.NumericUpDown();
            this.GenerationUp = new System.Windows.Forms.NumericUpDown();
            this.ShinyCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DebugBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LevelUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HpUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EXPUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerationUp)).BeginInit();
            this.SuspendLayout();
            // 
            // AttackCombo
            // 
            this.AttackCombo.FormattingEnabled = true;
            this.AttackCombo.Items.AddRange(new object[] {
            "Attack",
            "SP_Attack",
            "Defense",
            "SP_Defense"});
            this.AttackCombo.Location = new System.Drawing.Point(64, 230);
            this.AttackCombo.Name = "AttackCombo";
            this.AttackCombo.Size = new System.Drawing.Size(121, 24);
            this.AttackCombo.TabIndex = 0;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(64, 84);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 22);
            this.NameBox.TabIndex = 1;
            // 
            // LevelUp
            // 
            this.LevelUp.Location = new System.Drawing.Point(64, 158);
            this.LevelUp.Name = "LevelUp";
            this.LevelUp.Size = new System.Drawing.Size(120, 22);
            this.LevelUp.TabIndex = 2;
            // 
            // LegendaryCheck
            // 
            this.LegendaryCheck.AutoSize = true;
            this.LegendaryCheck.Location = new System.Drawing.Point(66, 292);
            this.LegendaryCheck.Name = "LegendaryCheck";
            this.LegendaryCheck.Size = new System.Drawing.Size(94, 20);
            this.LegendaryCheck.TabIndex = 3;
            this.LegendaryCheck.Text = "Legendary";
            this.LegendaryCheck.UseVisualStyleBackColor = true;
            // 
            // TypeBox
            // 
            this.TypeBox.Location = new System.Drawing.Point(216, 84);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(100, 22);
            this.TypeBox.TabIndex = 4;
            // 
            // HpUp
            // 
            this.HpUp.Location = new System.Drawing.Point(210, 158);
            this.HpUp.Name = "HpUp";
            this.HpUp.Size = new System.Drawing.Size(120, 22);
            this.HpUp.TabIndex = 5;
            // 
            // EXPUp
            // 
            this.EXPUp.Location = new System.Drawing.Point(354, 158);
            this.EXPUp.Name = "EXPUp";
            this.EXPUp.Size = new System.Drawing.Size(120, 22);
            this.EXPUp.TabIndex = 6;
            // 
            // GenerationUp
            // 
            this.GenerationUp.Location = new System.Drawing.Point(494, 158);
            this.GenerationUp.Name = "GenerationUp";
            this.GenerationUp.Size = new System.Drawing.Size(120, 22);
            this.GenerationUp.TabIndex = 7;
            // 
            // ShinyCheck
            // 
            this.ShinyCheck.AutoSize = true;
            this.ShinyCheck.Location = new System.Drawing.Point(194, 292);
            this.ShinyCheck.Name = "ShinyCheck";
            this.ShinyCheck.Size = new System.Drawing.Size(62, 20);
            this.ShinyCheck.TabIndex = 8;
            this.ShinyCheck.Text = "Shiny";
            this.ShinyCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "HP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "EXP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(526, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Gen.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "AttackType";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(315, 292);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(87, 28);
            this.SaveButton.TabIndex = 18;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DebugBox
            // 
            this.DebugBox.Location = new System.Drawing.Point(315, 326);
            this.DebugBox.Multiline = true;
            this.DebugBox.Name = "DebugBox";
            this.DebugBox.Size = new System.Drawing.Size(246, 87);
            this.DebugBox.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DebugBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShinyCheck);
            this.Controls.Add(this.GenerationUp);
            this.Controls.Add(this.EXPUp);
            this.Controls.Add(this.HpUp);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.LegendaryCheck);
            this.Controls.Add(this.LevelUp);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.AttackCombo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LevelUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HpUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EXPUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerationUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AttackCombo;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.NumericUpDown LevelUp;
        private System.Windows.Forms.CheckBox LegendaryCheck;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.NumericUpDown HpUp;
        private System.Windows.Forms.NumericUpDown EXPUp;
        private System.Windows.Forms.NumericUpDown GenerationUp;
        private System.Windows.Forms.CheckBox ShinyCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox DebugBox;
    }
}


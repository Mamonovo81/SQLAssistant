namespace SQLAssistant
{
    partial class FrmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CboDbServers = new System.Windows.Forms.ComboBox();
            this.BtnTest = new System.Windows.Forms.Button();
            this.BtnEceSql = new System.Windows.Forms.Button();
            this.BtnService = new System.Windows.Forms.Button();
            this.BtnExeFil = new System.Windows.Forms.Button();
            this.TxtSql = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblResult = new System.Windows.Forms.Label();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection";
            // 
            // CboDbServers
            // 
            this.CboDbServers.FormattingEnabled = true;
            this.CboDbServers.Location = new System.Drawing.Point(200, 12);
            this.CboDbServers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CboDbServers.Name = "CboDbServers";
            this.CboDbServers.Size = new System.Drawing.Size(429, 24);
            this.CboDbServers.TabIndex = 1;
            // 
            // BtnTest
            // 
            this.BtnTest.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnTest.Location = new System.Drawing.Point(655, 9);
            this.BtnTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(193, 71);
            this.BtnTest.TabIndex = 2;
            this.BtnTest.Text = "Test Connection";
            this.BtnTest.UseVisualStyleBackColor = false;
            // 
            // BtnEceSql
            // 
            this.BtnEceSql.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnEceSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEceSql.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnEceSql.Location = new System.Drawing.Point(654, 87);
            this.BtnEceSql.Name = "BtnEceSql";
            this.BtnEceSql.Size = new System.Drawing.Size(190, 46);
            this.BtnEceSql.TabIndex = 3;
            this.BtnEceSql.Text = "Execute SQL";
            this.BtnEceSql.UseVisualStyleBackColor = false;
            // 
            // BtnService
            // 
            this.BtnService.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnService.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnService.Location = new System.Drawing.Point(654, 139);
            this.BtnService.Name = "BtnService";
            this.BtnService.Size = new System.Drawing.Size(189, 46);
            this.BtnService.TabIndex = 4;
            this.BtnService.Text = "Service";
            this.BtnService.UseVisualStyleBackColor = false;
            // 
            // BtnExeFil
            // 
            this.BtnExeFil.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnExeFil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExeFil.Location = new System.Drawing.Point(654, 195);
            this.BtnExeFil.Name = "BtnExeFil";
            this.BtnExeFil.Size = new System.Drawing.Size(188, 36);
            this.BtnExeFil.TabIndex = 5;
            this.BtnExeFil.Text = "Execute File";
            this.BtnExeFil.UseVisualStyleBackColor = false;
            // 
            // TxtSql
            // 
            this.TxtSql.Location = new System.Drawing.Point(49, 43);
            this.TxtSql.Multiline = true;
            this.TxtSql.Name = "TxtSql";
            this.TxtSql.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtSql.Size = new System.Drawing.Size(599, 188);
            this.TxtSql.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(50, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "SQL";
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblResult.Location = new System.Drawing.Point(52, 243);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(73, 20);
            this.LblResult.TabIndex = 8;
            this.LblResult.Text = "Results";
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(52, 266);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtResult.Size = new System.Drawing.Size(790, 188);
            this.TxtResult.TabIndex = 9;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(869, 544);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSql);
            this.Controls.Add(this.BtnExeFil);
            this.Controls.Add(this.BtnService);
            this.Controls.Add(this.BtnEceSql);
            this.Controls.Add(this.BtnTest);
            this.Controls.Add(this.CboDbServers);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboDbServers;
        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.Button BtnEceSql;
        private System.Windows.Forms.Button BtnService;
        private System.Windows.Forms.Button BtnExeFil;
        private System.Windows.Forms.TextBox TxtSql;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.TextBox TxtResult;
    }
}


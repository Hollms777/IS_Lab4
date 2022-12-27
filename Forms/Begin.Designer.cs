namespace IS_Lab4
{
    partial class Begin
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
            this.button_Flegmatic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Holeric = new System.Windows.Forms.Button();
            this.button_Melanholik = new System.Windows.Forms.Button();
            this.button_Sangvinic = new System.Windows.Forms.Button();
            this.button_delete_results = new System.Windows.Forms.Button();
            this.button_results = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Flegmatic
            // 
            this.button_Flegmatic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Flegmatic.Location = new System.Drawing.Point(283, 79);
            this.button_Flegmatic.Name = "button_Flegmatic";
            this.button_Flegmatic.Size = new System.Drawing.Size(225, 43);
            this.button_Flegmatic.TabIndex = 0;
            this.button_Flegmatic.Text = "Тест на Флегматика";
            this.button_Flegmatic.UseVisualStyleBackColor = true;
            this.button_Flegmatic.Click += new System.EventHandler(this.button_Flegmatic_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 450);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тест на тип темпераменту";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_Holeric
            // 
            this.button_Holeric.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Holeric.Location = new System.Drawing.Point(283, 128);
            this.button_Holeric.Name = "button_Holeric";
            this.button_Holeric.Size = new System.Drawing.Size(225, 43);
            this.button_Holeric.TabIndex = 2;
            this.button_Holeric.Text = "Тест на Холерика";
            this.button_Holeric.UseVisualStyleBackColor = true;
            this.button_Holeric.Click += new System.EventHandler(this.button_Holeric_Click);
            // 
            // button_Melanholik
            // 
            this.button_Melanholik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Melanholik.Location = new System.Drawing.Point(283, 177);
            this.button_Melanholik.Name = "button_Melanholik";
            this.button_Melanholik.Size = new System.Drawing.Size(225, 43);
            this.button_Melanholik.TabIndex = 3;
            this.button_Melanholik.Text = "Тест на Меланхоліка";
            this.button_Melanholik.UseVisualStyleBackColor = true;
            this.button_Melanholik.Click += new System.EventHandler(this.button_Melanholik_Click);
            // 
            // button_Sangvinic
            // 
            this.button_Sangvinic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Sangvinic.Location = new System.Drawing.Point(283, 226);
            this.button_Sangvinic.Name = "button_Sangvinic";
            this.button_Sangvinic.Size = new System.Drawing.Size(225, 43);
            this.button_Sangvinic.TabIndex = 4;
            this.button_Sangvinic.Text = "Тест на Сангвініка";
            this.button_Sangvinic.UseVisualStyleBackColor = true;
            this.button_Sangvinic.Click += new System.EventHandler(this.button_Sangvinic_Click);
            // 
            // button_delete_results
            // 
            this.button_delete_results.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_delete_results.Location = new System.Drawing.Point(283, 275);
            this.button_delete_results.Name = "button_delete_results";
            this.button_delete_results.Size = new System.Drawing.Size(225, 43);
            this.button_delete_results.TabIndex = 5;
            this.button_delete_results.Text = "Скинути результати";
            this.button_delete_results.UseVisualStyleBackColor = true;
            this.button_delete_results.Click += new System.EventHandler(this.button_delete_results_Click);
            // 
            // button_results
            // 
            this.button_results.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_results.Location = new System.Drawing.Point(283, 324);
            this.button_results.Name = "button_results";
            this.button_results.Size = new System.Drawing.Size(225, 43);
            this.button_results.TabIndex = 6;
            this.button_results.Text = "Результати";
            this.button_results.UseVisualStyleBackColor = true;
            this.button_results.Click += new System.EventHandler(this.button_results_Click);
            // 
            // button_exit
            // 
            this.button_exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_exit.Location = new System.Drawing.Point(283, 373);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(225, 43);
            this.button_exit.TabIndex = 7;
            this.button_exit.Text = "Вихід";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Begin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_results);
            this.Controls.Add(this.button_delete_results);
            this.Controls.Add(this.button_Sangvinic);
            this.Controls.Add(this.button_Melanholik);
            this.Controls.Add(this.button_Holeric);
            this.Controls.Add(this.button_Flegmatic);
            this.Controls.Add(this.label1);
            this.Name = "Begin";
            this.Text = "Begin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Begin_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Flegmatic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Holeric;
        private System.Windows.Forms.Button button_Melanholik;
        private System.Windows.Forms.Button button_Sangvinic;
        private System.Windows.Forms.Button button_delete_results;
        private System.Windows.Forms.Button button_results;
        private System.Windows.Forms.Button button_exit;
    }
}


namespace VitaFarm
{
    partial class FormLogin
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
            this.LayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.LayoutLogin = new System.Windows.Forms.TableLayoutPanel();
            this.TextLogin = new System.Windows.Forms.TextBox();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LayoutAccess = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.LabelRegistration = new System.Windows.Forms.Label();
            this.LabelGuest = new System.Windows.Forms.Label();
            this.LayoutMain.SuspendLayout();
            this.LayoutLogin.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.LayoutAccess.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutMain
            // 
            this.LayoutMain.ColumnCount = 1;
            this.LayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutMain.Controls.Add(this.LayoutLogin, 0, 1);
            this.LayoutMain.Controls.Add(this.LabelLogin, 0, 0);
            this.LayoutMain.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.LayoutMain.Controls.Add(this.LabelPassword, 0, 2);
            this.LayoutMain.Controls.Add(this.LayoutAccess, 0, 4);
            this.LayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutMain.Location = new System.Drawing.Point(0, 0);
            this.LayoutMain.Name = "LayoutMain";
            this.LayoutMain.RowCount = 5;
            this.LayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.19388F));
            this.LayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.0625F));
            this.LayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.421875F));
            this.LayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.02347F));
            this.LayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.723F));
            this.LayoutMain.Size = new System.Drawing.Size(486, 213);
            this.LayoutMain.TabIndex = 0;
            // 
            // LayoutLogin
            // 
            this.LayoutLogin.ColumnCount = 3;
            this.LayoutLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.28572F));
            this.LayoutLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.42857F));
            this.LayoutLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.28572F));
            this.LayoutLogin.Controls.Add(this.TextLogin, 1, 0);
            this.LayoutLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutLogin.Location = new System.Drawing.Point(3, 49);
            this.LayoutLogin.Name = "LayoutLogin";
            this.LayoutLogin.RowCount = 1;
            this.LayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutLogin.Size = new System.Drawing.Size(480, 23);
            this.LayoutLogin.TabIndex = 0;
            // 
            // TextLogin
            // 
            this.TextLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextLogin.Location = new System.Drawing.Point(90, 3);
            this.TextLogin.Name = "TextLogin";
            this.TextLogin.Size = new System.Drawing.Size(298, 20);
            this.TextLogin.TabIndex = 0;
            // 
            // LabelLogin
            // 
            this.LabelLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(224, 33);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(38, 13);
            this.LabelLogin.TabIndex = 1;
            this.LabelLogin.Text = "Логин";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.42857F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.28572F));
            this.tableLayoutPanel1.Controls.Add(this.TextPassword, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 93);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 25);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // TextPassword
            // 
            this.TextPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextPassword.Location = new System.Drawing.Point(90, 3);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(298, 20);
            this.TextPassword.TabIndex = 0;
            // 
            // LabelPassword
            // 
            this.LabelPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(220, 77);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(45, 13);
            this.LabelPassword.TabIndex = 3;
            this.LabelPassword.Text = "Пароль";
            // 
            // LayoutAccess
            // 
            this.LayoutAccess.ColumnCount = 1;
            this.LayoutAccess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutAccess.Controls.Add(this.ButtonOk, 0, 0);
            this.LayoutAccess.Controls.Add(this.LabelRegistration, 0, 1);
            this.LayoutAccess.Controls.Add(this.LabelGuest, 0, 2);
            this.LayoutAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutAccess.Location = new System.Drawing.Point(3, 124);
            this.LayoutAccess.Name = "LayoutAccess";
            this.LayoutAccess.RowCount = 3;
            this.LayoutAccess.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.08046F));
            this.LayoutAccess.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.83908F));
            this.LayoutAccess.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.93103F));
            this.LayoutAccess.Size = new System.Drawing.Size(480, 86);
            this.LayoutAccess.TabIndex = 4;
            // 
            // ButtonOk
            // 
            this.ButtonOk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonOk.Location = new System.Drawing.Point(202, 3);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(75, 23);
            this.ButtonOk.TabIndex = 0;
            this.ButtonOk.Text = "Войти";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // LabelRegistration
            // 
            this.LabelRegistration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelRegistration.AutoSize = true;
            this.LabelRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelRegistration.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabelRegistration.Location = new System.Drawing.Point(145, 34);
            this.LabelRegistration.Name = "LabelRegistration";
            this.LabelRegistration.Size = new System.Drawing.Size(190, 13);
            this.LabelRegistration.TabIndex = 1;
            this.LabelRegistration.Text = "Нет аккаунта? Зарегистрироваться";
            this.LabelRegistration.Click += new System.EventHandler(this.LabelRegistration_Click);
            // 
            // LabelGuest
            // 
            this.LabelGuest.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelGuest.AutoSize = true;
            this.LabelGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelGuest.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabelGuest.Location = new System.Drawing.Point(195, 53);
            this.LabelGuest.Name = "LabelGuest";
            this.LabelGuest.Size = new System.Drawing.Size(89, 13);
            this.LabelGuest.TabIndex = 2;
            this.LabelGuest.Text = "Войти как гость";
            this.LabelGuest.Click += new System.EventHandler(this.LabelGuest_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 213);
            this.Controls.Add(this.LayoutMain);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.LayoutMain.ResumeLayout(false);
            this.LayoutMain.PerformLayout();
            this.LayoutLogin.ResumeLayout(false);
            this.LayoutLogin.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.LayoutAccess.ResumeLayout(false);
            this.LayoutAccess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LayoutMain;
        private System.Windows.Forms.TableLayoutPanel LayoutLogin;
        private System.Windows.Forms.TextBox TextLogin;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TableLayoutPanel LayoutAccess;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Label LabelRegistration;
        private System.Windows.Forms.Label LabelGuest;
    }
}


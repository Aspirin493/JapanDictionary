
namespace JapanDictionary
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.Tabs = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.word_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.ProjectName = new Guna.UI.WinForms.GunaLabel();
            this.WordTextbox = new Guna.UI.WinForms.GunaTextBox();
            this.TipLabel = new Guna.UI.WinForms.GunaLabel();
            this.loading_status = new Guna.UI.WinForms.GunaLabel();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.ItemSize = new System.Drawing.Size(135, 40);
            this.Tabs.Location = new System.Drawing.Point(1, 55);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(827, 533);
            this.Tabs.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.Tabs.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.Tabs.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.Tabs.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.Tabs.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.Tabs.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.Tabs.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.Tabs.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.Tabs.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.Tabs.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.Tabs.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.Tabs.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Tabs.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.Tabs.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.Tabs.TabButtonSelectedState.InnerColor = System.Drawing.Color.Gray;
            this.Tabs.TabButtonSize = new System.Drawing.Size(135, 40);
            this.Tabs.TabIndex = 0;
            this.Tabs.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tabPage1.Controls.Add(this.word_panel);
            this.tabPage1.Location = new System.Drawing.Point(139, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(684, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Слова";
            // 
            // word_panel
            // 
            this.word_panel.Location = new System.Drawing.Point(6, 6);
            this.word_panel.Name = "word_panel";
            this.word_panel.Size = new System.Drawing.Size(671, 513);
            this.word_panel.TabIndex = 0;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gunaPanel1.Controls.Add(this.ProjectName);
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(135, 57);
            this.gunaPanel1.TabIndex = 1;
            // 
            // ProjectName
            // 
            this.ProjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectName.Font = new System.Drawing.Font("Inter SemiBold", 10.75F, System.Drawing.FontStyle.Bold);
            this.ProjectName.ForeColor = System.Drawing.Color.White;
            this.ProjectName.Location = new System.Drawing.Point(0, 0);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(135, 57);
            this.ProjectName.TabIndex = 2;
            this.ProjectName.Text = "JapanDictionary";
            this.ProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WordTextbox
            // 
            this.WordTextbox.BackColor = System.Drawing.Color.Transparent;
            this.WordTextbox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.WordTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.WordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WordTextbox.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.WordTextbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.WordTextbox.FocusedForeColor = System.Drawing.Color.White;
            this.WordTextbox.Font = new System.Drawing.Font("Inter", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordTextbox.ForeColor = System.Drawing.Color.White;
            this.WordTextbox.Location = new System.Drawing.Point(353, 5);
            this.WordTextbox.Name = "WordTextbox";
            this.WordTextbox.PasswordChar = '\0';
            this.WordTextbox.Radius = 4;
            this.WordTextbox.SelectedText = "";
            this.WordTextbox.Size = new System.Drawing.Size(203, 26);
            this.WordTextbox.TabIndex = 2;
            this.WordTextbox.Text = "Введите слово";
            this.WordTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WordTextbox.Click += new System.EventHandler(this.WordTextbox_Click);
            this.WordTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WordTextbox_KeyDown);
            // 
            // TipLabel
            // 
            this.TipLabel.AutoSize = true;
            this.TipLabel.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipLabel.ForeColor = System.Drawing.Color.Gray;
            this.TipLabel.Location = new System.Drawing.Point(373, 38);
            this.TipLabel.Name = "TipLabel";
            this.TipLabel.Size = new System.Drawing.Size(159, 14);
            this.TipLabel.TabIndex = 3;
            this.TipLabel.Text = "Нажмите ENTER для поиска";
            // 
            // loading_status
            // 
            this.loading_status.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading_status.ForeColor = System.Drawing.Color.White;
            this.loading_status.Location = new System.Drawing.Point(247, 281);
            this.loading_status.Name = "loading_status";
            this.loading_status.Size = new System.Drawing.Size(335, 29);
            this.loading_status.TabIndex = 4;
            this.loading_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(829, 590);
            this.Controls.Add(this.loading_status);
            this.Controls.Add(this.TipLabel);
            this.Controls.Add(this.WordTextbox);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTabControl Tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel word_panel;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel ProjectName;
        private Guna.UI.WinForms.GunaTextBox WordTextbox;
        private Guna.UI.WinForms.GunaLabel TipLabel;
        private Guna.UI.WinForms.GunaLabel loading_status;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
    }
}


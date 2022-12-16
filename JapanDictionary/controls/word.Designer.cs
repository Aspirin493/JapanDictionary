
namespace JapanDictionary
{
    partial class word
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.japan = new Guna.UI.WinForms.GunaLabel();
            this.alternative = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.content = new Guna.UI.WinForms.GunaLabel();
            this.front_other = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // japan
            // 
            this.japan.AutoEllipsis = true;
            this.japan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.japan.ForeColor = System.Drawing.Color.White;
            this.japan.Location = new System.Drawing.Point(0, 6);
            this.japan.Name = "japan";
            this.japan.Size = new System.Drawing.Size(292, 16);
            this.japan.TabIndex = 0;
            this.japan.Text = "null";
            this.japan.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit;
            this.japan.DoubleClick += new System.EventHandler(this.japan_DoubleClick);
            // 
            // alternative
            // 
            this.alternative.AutoEllipsis = true;
            this.alternative.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alternative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.alternative.Location = new System.Drawing.Point(0, 26);
            this.alternative.Name = "alternative";
            this.alternative.Size = new System.Drawing.Size(292, 16);
            this.alternative.TabIndex = 2;
            this.alternative.Text = "null";
            this.alternative.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit;
            this.alternative.DoubleClick += new System.EventHandler(this.alternative_DoubleClick);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gunaPanel1.Controls.Add(this.front_other);
            this.gunaPanel1.Controls.Add(this.content);
            this.gunaPanel1.Controls.Add(this.alternative);
            this.gunaPanel1.Controls.Add(this.japan);
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(298, 132);
            this.gunaPanel1.TabIndex = 3;
            // 
            // content
            // 
            this.content.AutoEllipsis = true;
            this.content.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.content.ForeColor = System.Drawing.Color.White;
            this.content.Location = new System.Drawing.Point(0, 64);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(292, 66);
            this.content.TabIndex = 3;
            this.content.Text = "null";
            this.content.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit;
            this.content.DoubleClick += new System.EventHandler(this.content_DoubleClick);
            // 
            // front_other
            // 
            this.front_other.AutoEllipsis = true;
            this.front_other.AutoSize = true;
            this.front_other.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.front_other.ForeColor = System.Drawing.Color.White;
            this.front_other.Location = new System.Drawing.Point(107, 44);
            this.front_other.Name = "front_other";
            this.front_other.Size = new System.Drawing.Size(64, 15);
            this.front_other.TabIndex = 4;
            this.front_other.Text = "Значение";
            this.front_other.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit;
            // 
            // word
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.gunaPanel1);
            this.Name = "word";
            this.Size = new System.Drawing.Size(298, 150);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel japan;
        private Guna.UI.WinForms.GunaLabel alternative;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel content;
        private Guna.UI.WinForms.GunaLabel front_other;
    }
}

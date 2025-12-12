namespace Tyuiu.MkhitaryanSG.Sprint6.Task7.V18
{
    partial class FormAbout
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
            textBox1 = new TextBox();
            buttonOK = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.FromArgb(255, 255, 192);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(250, 178);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(276, 28);
            textBox1.TabIndex = 0;
            textBox1.Text = "Разработчик Мхитарян С. Г. РППб25-1";
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(331, 235);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 29);
            buttonOK.TabIndex = 1;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOK);
            Controls.Add(textBox1);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button buttonOK;
    }
}
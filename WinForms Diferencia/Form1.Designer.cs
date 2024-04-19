namespace WinFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.button = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
       
            this.SuspendLayout();
            
            this.button.Location = new System.Drawing.Point(100, 100);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.Text = "Botón";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click); 

            this.textBox.Location = new System.Drawing.Point(100, 50);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(150, 20);
            this.textBox.Text = "Texto de ejemplo";

           
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox);
           
            this.Text = "Ventana Principal";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox textBox;
        
        private void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has presionado el botón.");
        }

    }
}



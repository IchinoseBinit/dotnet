namespace WindowsFormsApp1
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
            this.labelHelloWorld = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHelloWorld
            // 
            this.labelHelloWorld.AutoSize = true;
            this.labelHelloWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHelloWorld.Location = new System.Drawing.Point(270, 98);
            this.labelHelloWorld.Name = "labelHelloWorld";
            this.labelHelloWorld.Size = new System.Drawing.Size(172, 32);
            this.labelHelloWorld.TabIndex = 0;
            this.labelHelloWorld.Text = "Hello World";
            this.labelHelloWorld.Click += new System.EventHandler(this.labelHelloWorld_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(276, 183);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(210, 22);
            this.txtBoxName.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSubmit.Location = new System.Drawing.Point(276, 244);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(210, 31);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(273, 319);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 16);
            this.lblName.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.labelHelloWorld);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHelloWorld;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblName;
    }
}


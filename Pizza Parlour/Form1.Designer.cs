
namespace Pizza_Parlour
{
    partial class pizzaParlour
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
            this.topBar = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.toppingText = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Button = new System.Windows.Forms.Button();
            this.outputBorder = new System.Windows.Forms.Label();
            this.outputText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.DarkRed;
            this.topBar.Location = new System.Drawing.Point(0, -1);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(385, 93);
            this.topBar.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.DarkRed;
            this.Title.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(92, 32);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(187, 33);
            this.Title.TabIndex = 1;
            this.Title.Text = "Pizza Parlour";
            // 
            // toppingText
            // 
            this.toppingText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toppingText.ForeColor = System.Drawing.Color.White;
            this.toppingText.Location = new System.Drawing.Point(37, 117);
            this.toppingText.Name = "toppingText";
            this.toppingText.Size = new System.Drawing.Size(199, 23);
            this.toppingText.TabIndex = 2;
            this.toppingText.Text = "Number of Toppings:";
            this.toppingText.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Button
            // 
            this.Button.BackColor = System.Drawing.Color.Black;
            this.Button.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button.ForeColor = System.Drawing.Color.White;
            this.Button.Location = new System.Drawing.Point(128, 187);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(119, 48);
            this.Button.TabIndex = 4;
            this.Button.Text = "Calculate";
            this.Button.UseVisualStyleBackColor = false;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // outputBorder
            // 
            this.outputBorder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputBorder.Location = new System.Drawing.Point(38, 255);
            this.outputBorder.Name = "outputBorder";
            this.outputBorder.Size = new System.Drawing.Size(304, 56);
            this.outputBorder.TabIndex = 5;
            // 
            // outputText
            // 
            this.outputText.BackColor = System.Drawing.Color.White;
            this.outputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputText.Location = new System.Drawing.Point(45, 272);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(284, 23);
            this.outputText.TabIndex = 6;
            // 
            // pizzaParlour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(385, 339);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.outputBorder);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toppingText);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.topBar);
            this.Name = "pizzaParlour";
            this.Text = "Pizza Parlour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topBar;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label toppingText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Label outputBorder;
        private System.Windows.Forms.Label outputText;
    }
}


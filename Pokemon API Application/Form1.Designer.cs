
namespace Pokemon_API_Application
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
            System.Windows.Forms.Label lblchoice;
            this.inputbox = new System.Windows.Forms.TextBox();
            this.btnNewPokemon = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelHappy = new System.Windows.Forms.Label();
            this.labelCapture = new System.Windows.Forms.Label();
            this.labelHabitat = new System.Windows.Forms.Label();
            this.labelGrowth = new System.Windows.Forms.Label();
            this.labelEgg = new System.Windows.Forms.Label();
            this.labelFlavor = new System.Windows.Forms.Label();
            lblchoice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblchoice
            // 
            lblchoice.AutoSize = true;
            lblchoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblchoice.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            lblchoice.Location = new System.Drawing.Point(22, 174);
            lblchoice.Name = "lblchoice";
            lblchoice.Size = new System.Drawing.Size(290, 50);
            lblchoice.TabIndex = 0;
            lblchoice.Text = "Insert a Pokedex number below \r\nto generate a new Pokemon ";
            // 
            // inputbox
            // 
            this.inputbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputbox.Location = new System.Drawing.Point(89, 242);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(133, 23);
            this.inputbox.TabIndex = 1;
            // 
            // btnNewPokemon
            // 
            this.btnNewPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPokemon.Location = new System.Drawing.Point(89, 289);
            this.btnNewPokemon.Name = "btnNewPokemon";
            this.btnNewPokemon.Size = new System.Drawing.Size(133, 29);
            this.btnNewPokemon.TabIndex = 2;
            this.btnNewPokemon.Text = "Generate";
            this.btnNewPokemon.UseVisualStyleBackColor = true;
            this.btnNewPokemon.Click += new System.EventHandler(this.btnNewPokemon_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(506, 23);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 25);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name:";
            // 
            // labelHappy
            // 
            this.labelHappy.AutoSize = true;
            this.labelHappy.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHappy.Location = new System.Drawing.Point(506, 78);
            this.labelHappy.Name = "labelHappy";
            this.labelHappy.Size = new System.Drawing.Size(150, 25);
            this.labelHappy.TabIndex = 4;
            this.labelHappy.Text = "Base Happiness:";
            // 
            // labelCapture
            // 
            this.labelCapture.AutoSize = true;
            this.labelCapture.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapture.Location = new System.Drawing.Point(506, 134);
            this.labelCapture.Name = "labelCapture";
            this.labelCapture.Size = new System.Drawing.Size(129, 25);
            this.labelCapture.TabIndex = 5;
            this.labelCapture.Text = "Capture Rate:";
            // 
            // labelHabitat
            // 
            this.labelHabitat.AutoSize = true;
            this.labelHabitat.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHabitat.Location = new System.Drawing.Point(506, 199);
            this.labelHabitat.Name = "labelHabitat";
            this.labelHabitat.Size = new System.Drawing.Size(81, 25);
            this.labelHabitat.TabIndex = 6;
            this.labelHabitat.Text = "Habitat:";
            // 
            // labelGrowth
            // 
            this.labelGrowth.AutoSize = true;
            this.labelGrowth.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrowth.Location = new System.Drawing.Point(506, 250);
            this.labelGrowth.Name = "labelGrowth";
            this.labelGrowth.Size = new System.Drawing.Size(125, 25);
            this.labelGrowth.TabIndex = 7;
            this.labelGrowth.Text = "Growth Rate:";
            // 
            // labelEgg
            // 
            this.labelEgg.AutoSize = true;
            this.labelEgg.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEgg.Location = new System.Drawing.Point(506, 300);
            this.labelEgg.Name = "labelEgg";
            this.labelEgg.Size = new System.Drawing.Size(111, 25);
            this.labelEgg.TabIndex = 8;
            this.labelEgg.Text = "Egg Group:";
            // 
            // labelFlavor
            // 
            this.labelFlavor.AutoSize = true;
            this.labelFlavor.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFlavor.Location = new System.Drawing.Point(506, 356);
            this.labelFlavor.Name = "labelFlavor";
            this.labelFlavor.Size = new System.Drawing.Size(88, 21);
            this.labelFlavor.TabIndex = 9;
            this.labelFlavor.Text = "Flavor Text:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 505);
            this.Controls.Add(this.labelFlavor);
            this.Controls.Add(this.labelEgg);
            this.Controls.Add(this.labelGrowth);
            this.Controls.Add(this.labelHabitat);
            this.Controls.Add(this.labelCapture);
            this.Controls.Add(this.labelHappy);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnNewPokemon);
            this.Controls.Add(this.inputbox);
            this.Controls.Add(lblchoice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputbox;
        private System.Windows.Forms.Button btnNewPokemon;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelHappy;
        private System.Windows.Forms.Label labelCapture;
        private System.Windows.Forms.Label labelHabitat;
        private System.Windows.Forms.Label labelGrowth;
        private System.Windows.Forms.Label labelEgg;
        private System.Windows.Forms.Label labelFlavor;
    }
}


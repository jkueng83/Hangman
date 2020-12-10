
namespace Hangman
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
            this.btTest = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tBoxAddNewWord = new System.Windows.Forms.TextBox();
            this.btAddNewWord = new System.Windows.Forms.Button();
            this.btPlayNewGame = new System.Windows.Forms.Button();
            this.lbWord = new System.Windows.Forms.Label();
            this.tBoxCharacter = new System.Windows.Forms.TextBox();
            this.lbSelectedCharacters = new System.Windows.Forms.Label();
            this.lbGameStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btTest
            // 
            this.btTest.Location = new System.Drawing.Point(747, 156);
            this.btTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btTest.Name = "btTest";
            this.btTest.Size = new System.Drawing.Size(100, 28);
            this.btTest.TabIndex = 0;
            this.btTest.Text = "Test";
            this.btTest.UseVisualStyleBackColor = true;
            this.btTest.Click += new System.EventHandler(this.btTest_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(52, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 431);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tBoxAddNewWord
            // 
            this.tBoxAddNewWord.Location = new System.Drawing.Point(396, 444);
            this.tBoxAddNewWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxAddNewWord.Name = "tBoxAddNewWord";
            this.tBoxAddNewWord.Size = new System.Drawing.Size(303, 22);
            this.tBoxAddNewWord.TabIndex = 2;
            this.tBoxAddNewWord.Text = "Add New Word";
            this.tBoxAddNewWord.Click += new System.EventHandler(this.tBoxAddNewWord_Click);
            // 
            // btAddNewWord
            // 
            this.btAddNewWord.Location = new System.Drawing.Point(747, 441);
            this.btAddNewWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAddNewWord.Name = "btAddNewWord";
            this.btAddNewWord.Size = new System.Drawing.Size(127, 28);
            this.btAddNewWord.TabIndex = 3;
            this.btAddNewWord.Text = "Add new Word";
            this.btAddNewWord.UseVisualStyleBackColor = true;
            this.btAddNewWord.Click += new System.EventHandler(this.btAddNewWord_Click);
            // 
            // btPlayNewGame
            // 
            this.btPlayNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlayNewGame.ForeColor = System.Drawing.Color.Green;
            this.btPlayNewGame.Location = new System.Drawing.Point(396, 38);
            this.btPlayNewGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPlayNewGame.Name = "btPlayNewGame";
            this.btPlayNewGame.Size = new System.Drawing.Size(244, 46);
            this.btPlayNewGame.TabIndex = 4;
            this.btPlayNewGame.Text = "Play new Game";
            this.btPlayNewGame.UseVisualStyleBackColor = true;
            this.btPlayNewGame.Click += new System.EventHandler(this.btPlayNewGame_Click);
            // 
            // lbWord
            // 
            this.lbWord.AutoSize = true;
            this.lbWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWord.ForeColor = System.Drawing.Color.Green;
            this.lbWord.Location = new System.Drawing.Point(396, 117);
            this.lbWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWord.Name = "lbWord";
            this.lbWord.Size = new System.Drawing.Size(75, 29);
            this.lbWord.TabIndex = 5;
            this.lbWord.Text = "Word";
            // 
            // tBoxCharacter
            // 
            this.tBoxCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxCharacter.Location = new System.Drawing.Point(396, 219);
            this.tBoxCharacter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxCharacter.Name = "tBoxCharacter";
            this.tBoxCharacter.Size = new System.Drawing.Size(263, 30);
            this.tBoxCharacter.TabIndex = 6;
            this.tBoxCharacter.Text = "Enter Your Character";
            this.tBoxCharacter.Click += new System.EventHandler(this.tBoxCharacter_Click);
            this.tBoxCharacter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxCharacter_KeyDown);
            // 
            // lbSelectedCharacters
            // 
            this.lbSelectedCharacters.AutoSize = true;
            this.lbSelectedCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectedCharacters.ForeColor = System.Drawing.Color.Green;
            this.lbSelectedCharacters.Location = new System.Drawing.Point(396, 306);
            this.lbSelectedCharacters.Name = "lbSelectedCharacters";
            this.lbSelectedCharacters.Size = new System.Drawing.Size(181, 25);
            this.lbSelectedCharacters.TabIndex = 7;
            this.lbSelectedCharacters.Text = "selected characters";
            // 
            // lbGameStatus
            // 
            this.lbGameStatus.AutoSize = true;
            this.lbGameStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameStatus.Location = new System.Drawing.Point(744, 38);
            this.lbGameStatus.Name = "lbGameStatus";
            this.lbGameStatus.Size = new System.Drawing.Size(150, 29);
            this.lbGameStatus.TabIndex = 8;
            this.lbGameStatus.Text = "Game Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lbGameStatus);
            this.Controls.Add(this.lbSelectedCharacters);
            this.Controls.Add(this.tBoxCharacter);
            this.Controls.Add(this.lbWord);
            this.Controls.Add(this.btPlayNewGame);
            this.Controls.Add(this.btAddNewWord);
            this.Controls.Add(this.tBoxAddNewWord);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btTest);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Hangman";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tBoxAddNewWord;
        private System.Windows.Forms.Button btAddNewWord;
        private System.Windows.Forms.Button btPlayNewGame;
        private System.Windows.Forms.Label lbWord;
        private System.Windows.Forms.TextBox tBoxCharacter;
        private System.Windows.Forms.Label lbSelectedCharacters;
        private System.Windows.Forms.Label lbGameStatus;
    }
}


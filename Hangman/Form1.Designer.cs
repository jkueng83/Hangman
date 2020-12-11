
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
            this.btRemoveHangman = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btTest
            // 
            this.btTest.Location = new System.Drawing.Point(39, 397);
            this.btTest.Name = "btTest";
            this.btTest.Size = new System.Drawing.Size(75, 23);
            this.btTest.TabIndex = 0;
            this.btTest.Text = "Test";
            this.btTest.UseVisualStyleBackColor = true;
            this.btTest.Click += new System.EventHandler(this.btTest_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(39, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 350);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tBoxAddNewWord
            // 
            this.tBoxAddNewWord.Location = new System.Drawing.Point(297, 361);
            this.tBoxAddNewWord.Name = "tBoxAddNewWord";
            this.tBoxAddNewWord.Size = new System.Drawing.Size(228, 20);
            this.tBoxAddNewWord.TabIndex = 2;
            this.tBoxAddNewWord.Text = "Add New Word";
            this.tBoxAddNewWord.Click += new System.EventHandler(this.tBoxAddNewWord_Click);
            // 
            // btAddNewWord
            // 
            this.btAddNewWord.Location = new System.Drawing.Point(560, 358);
            this.btAddNewWord.Name = "btAddNewWord";
            this.btAddNewWord.Size = new System.Drawing.Size(95, 23);
            this.btAddNewWord.TabIndex = 3;
            this.btAddNewWord.Text = "Add new Word";
            this.btAddNewWord.UseVisualStyleBackColor = true;
            this.btAddNewWord.Click += new System.EventHandler(this.btAddNewWord_Click);
            // 
            // btPlayNewGame
            // 
            this.btPlayNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlayNewGame.ForeColor = System.Drawing.Color.Green;
            this.btPlayNewGame.Location = new System.Drawing.Point(297, 31);
            this.btPlayNewGame.Name = "btPlayNewGame";
            this.btPlayNewGame.Size = new System.Drawing.Size(183, 37);
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
            this.lbWord.Location = new System.Drawing.Point(297, 95);
            this.lbWord.Name = "lbWord";
            this.lbWord.Size = new System.Drawing.Size(60, 24);
            this.lbWord.TabIndex = 5;
            this.lbWord.Text = "Word";
            // 
            // tBoxCharacter
            // 
            this.tBoxCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxCharacter.Location = new System.Drawing.Point(297, 178);
            this.tBoxCharacter.Name = "tBoxCharacter";
            this.tBoxCharacter.Size = new System.Drawing.Size(198, 26);
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
            this.lbSelectedCharacters.Location = new System.Drawing.Point(297, 249);
            this.lbSelectedCharacters.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSelectedCharacters.Name = "lbSelectedCharacters";
            this.lbSelectedCharacters.Size = new System.Drawing.Size(148, 20);
            this.lbSelectedCharacters.TabIndex = 7;
            this.lbSelectedCharacters.Text = "selected characters";
            // 
            // lbGameStatus
            // 
            this.lbGameStatus.AutoSize = true;
            this.lbGameStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameStatus.Location = new System.Drawing.Point(558, 31);
            this.lbGameStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGameStatus.Name = "lbGameStatus";
            this.lbGameStatus.Size = new System.Drawing.Size(116, 24);
            this.lbGameStatus.TabIndex = 8;
            this.lbGameStatus.Text = "Game Status";
            // 
            // btRemoveHangman
            // 
            this.btRemoveHangman.Location = new System.Drawing.Point(125, 397);
            this.btRemoveHangman.Name = "btRemoveHangman";
            this.btRemoveHangman.Size = new System.Drawing.Size(114, 23);
            this.btRemoveHangman.TabIndex = 9;
            this.btRemoveHangman.Text = "Remove Hangman";
            this.btRemoveHangman.UseVisualStyleBackColor = true;
            this.btRemoveHangman.Click += new System.EventHandler(this.btRemoveHangman_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRemoveHangman);
            this.Controls.Add(this.lbGameStatus);
            this.Controls.Add(this.lbSelectedCharacters);
            this.Controls.Add(this.tBoxCharacter);
            this.Controls.Add(this.lbWord);
            this.Controls.Add(this.btPlayNewGame);
            this.Controls.Add(this.btAddNewWord);
            this.Controls.Add(this.tBoxAddNewWord);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btTest);
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
        private System.Windows.Forms.Button btRemoveHangman;
    }
}


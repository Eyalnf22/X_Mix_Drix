namespace FormX
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
            this.pnl = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.myTurn = new System.Windows.Forms.Label();
            this.afterPnl = new System.Windows.Forms.Panel();
            this.newGame = new System.Windows.Forms.Button();
            this.pnl.SuspendLayout();
            this.afterPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.afterPnl);
            this.pnl.Location = new System.Drawing.Point(41, 84);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(378, 354);
            this.pnl.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(125, 21);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(164, 37);
            this.title.TabIndex = 1;
            this.title.Text = "X Mix Drix";
            // 
            // myTurn
            // 
            this.myTurn.AutoSize = true;
            this.myTurn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myTurn.ForeColor = System.Drawing.Color.Firebrick;
            this.myTurn.Location = new System.Drawing.Point(12, 54);
            this.myTurn.Name = "myTurn";
            this.myTurn.Size = new System.Drawing.Size(80, 27);
            this.myTurn.TabIndex = 2;
            this.myTurn.Text = "turn: X";
            // 
            // afterPnl
            // 
            this.afterPnl.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.afterPnl.Controls.Add(this.newGame);
            this.afterPnl.Location = new System.Drawing.Point(74, 112);
            this.afterPnl.Name = "afterPnl";
            this.afterPnl.Size = new System.Drawing.Size(200, 100);
            this.afterPnl.TabIndex = 3;
            this.afterPnl.Visible = false;
            // 
            // newGame
            // 
            this.newGame.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGame.Location = new System.Drawing.Point(30, 30);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(144, 42);
            this.newGame.TabIndex = 0;
            this.newGame.Text = "New Game";
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.myTurn);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pnl);
            this.Name = "Form1";
            this.Text = "X Mix Drix";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl.ResumeLayout(false);
            this.afterPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label myTurn;
        private System.Windows.Forms.Panel afterPnl;
        private System.Windows.Forms.Button newGame;
    }
}


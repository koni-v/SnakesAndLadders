﻿using System;

namespace Snakes_Ladders
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
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnRoll2 = new System.Windows.Forms.Button();
            this.lbxText = new System.Windows.Forms.Label();
            this.lbyText = new System.Windows.Forms.Label();
            this.lbx = new System.Windows.Forms.Label();
            this.lby = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.lbp = new System.Windows.Forms.Label();
            this.lbp2 = new System.Windows.Forms.Label();
            this.lbMessage2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbdice = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lby2 = new System.Windows.Forms.Label();
            this.lbx2 = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.pbdice = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbPurpleStart = new System.Windows.Forms.PictureBox();
            this.pbYellowStart = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.pbPurpleToken = new System.Windows.Forms.PictureBox();
            this.pbYellowToken = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbdice)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPurpleStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYellowStart)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPurpleToken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYellowToken)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.BackColor = System.Drawing.Color.Yellow;
            this.btnRoll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRoll.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRoll.ForeColor = System.Drawing.Color.Black;
            this.btnRoll.Location = new System.Drawing.Point(731, 362);
            this.btnRoll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(111, 43);
            this.btnRoll.TabIndex = 3;
            this.btnRoll.Text = "ROLL";
            this.btnRoll.UseVisualStyleBackColor = false;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnRoll2
            // 
            this.btnRoll2.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnRoll2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoll2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRoll2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRoll2.ForeColor = System.Drawing.Color.Black;
            this.btnRoll2.Location = new System.Drawing.Point(892, 362);
            this.btnRoll2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRoll2.Name = "btnRoll2";
            this.btnRoll2.Size = new System.Drawing.Size(111, 43);
            this.btnRoll2.TabIndex = 4;
            this.btnRoll2.Text = "ROLL";
            this.btnRoll2.UseVisualStyleBackColor = false;
            this.btnRoll2.Click += new System.EventHandler(this.btnRoll2_Click);
            // 
            // lbxText
            // 
            this.lbxText.AutoSize = true;
            this.lbxText.Location = new System.Drawing.Point(729, 148);
            this.lbxText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbxText.Name = "lbxText";
            this.lbxText.Size = new System.Drawing.Size(18, 16);
            this.lbxText.TabIndex = 5;
            this.lbxText.Text = "X:";
            // 
            // lbyText
            // 
            this.lbyText.AutoSize = true;
            this.lbyText.Location = new System.Drawing.Point(729, 164);
            this.lbyText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbyText.Name = "lbyText";
            this.lbyText.Size = new System.Drawing.Size(19, 16);
            this.lbyText.TabIndex = 6;
            this.lbyText.Text = "Y:";
            // 
            // lbx
            // 
            this.lbx.AutoSize = true;
            this.lbx.Location = new System.Drawing.Point(769, 148);
            this.lbx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(24, 16);
            this.lbx.TabIndex = 7;
            this.lbx.Text = "lbx";
            // 
            // lby
            // 
            this.lby.AutoSize = true;
            this.lby.Location = new System.Drawing.Point(769, 164);
            this.lby.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lby.Name = "lby";
            this.lby.Size = new System.Drawing.Size(25, 16);
            this.lby.TabIndex = 8;
            this.lby.Text = "lby";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(735, 465);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Position - player1:";
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMessage.ForeColor = System.Drawing.Color.Red;
            this.lbMessage.Location = new System.Drawing.Point(735, 529);
            this.lbMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(75, 18);
            this.lbMessage.TabIndex = 10;
            this.lbMessage.Text = "Message";
            // 
            // lbp
            // 
            this.lbp.AutoSize = true;
            this.lbp.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.lbp.Location = new System.Drawing.Point(892, 465);
            this.lbp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbp.Name = "lbp";
            this.lbp.Size = new System.Drawing.Size(29, 18);
            this.lbp.TabIndex = 11;
            this.lbp.Text = "lbp";
            // 
            // lbp2
            // 
            this.lbp2.AutoSize = true;
            this.lbp2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.lbp2.Location = new System.Drawing.Point(892, 484);
            this.lbp2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbp2.Name = "lbp2";
            this.lbp2.Size = new System.Drawing.Size(38, 18);
            this.lbp2.TabIndex = 14;
            this.lbp2.Text = "lbp2";
            // 
            // lbMessage2
            // 
            this.lbMessage2.AutoSize = true;
            this.lbMessage2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMessage2.ForeColor = System.Drawing.Color.Red;
            this.lbMessage2.Location = new System.Drawing.Point(735, 529);
            this.lbMessage2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMessage2.Name = "lbMessage2";
            this.lbMessage2.Size = new System.Drawing.Size(75, 18);
            this.lbMessage2.TabIndex = 13;
            this.lbMessage2.Text = "Message";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(735, 484);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "Position - player2:";
            // 
            // lbdice
            // 
            this.lbdice.AutoSize = true;
            this.lbdice.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.lbdice.Location = new System.Drawing.Point(881, 188);
            this.lbdice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdice.Name = "lbdice";
            this.lbdice.Size = new System.Drawing.Size(31, 35);
            this.lbdice.TabIndex = 16;
            this.lbdice.Text = "N";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(823, 188);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 35);
            this.label12.TabIndex = 15;
            this.label12.Text = "Dice:";
            // 
            // lby2
            // 
            this.lby2.AutoSize = true;
            this.lby2.Location = new System.Drawing.Point(823, 164);
            this.lby2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lby2.Name = "lby2";
            this.lby2.Size = new System.Drawing.Size(32, 16);
            this.lby2.TabIndex = 18;
            this.lby2.Text = "lby2";
            // 
            // lbx2
            // 
            this.lbx2.AutoSize = true;
            this.lbx2.Location = new System.Drawing.Point(823, 148);
            this.lbx2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbx2.Name = "lbx2";
            this.lbx2.Size = new System.Drawing.Size(31, 16);
            this.lbx2.TabIndex = 17;
            this.lbx2.Text = "lbx2";
            // 
            // lblTurn
            // 
            this.lblTurn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.lblTurn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTurn.Location = new System.Drawing.Point(732, 417);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(271, 37);
            this.lblTurn.TabIndex = 19;
            this.lblTurn.Text = "lblTurn";
            this.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(731, 609);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(272, 37);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbdice
            // 
            this.pbdice.Location = new System.Drawing.Point(804, 224);
            this.pbdice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbdice.Name = "pbdice";
            this.pbdice.Size = new System.Drawing.Size(133, 119);
            this.pbdice.TabIndex = 2;
            this.pbdice.TabStop = false;
         
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Snakes_Ladders.Properties.Resources.stage1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.pbPurpleStart);
            this.panel1.Controls.Add(this.pbYellowStart);
            this.panel1.Location = new System.Drawing.Point(733, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 123);
            this.panel1.TabIndex = 1;
            // 
            // pbPurpleStart
            // 
            this.pbPurpleStart.BackColor = System.Drawing.Color.Transparent;
            this.pbPurpleStart.BackgroundImage = global::Snakes_Ladders.Properties.Resources.token2;
            this.pbPurpleStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPurpleStart.Location = new System.Drawing.Point(163, 16);
            this.pbPurpleStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbPurpleStart.Name = "pbPurpleStart";
            this.pbPurpleStart.Size = new System.Drawing.Size(44, 73);
            this.pbPurpleStart.TabIndex = 3;
            this.pbPurpleStart.TabStop = false;
            // 
            // pbYellowStart
            // 
            this.pbYellowStart.BackColor = System.Drawing.Color.Transparent;
            this.pbYellowStart.BackgroundImage = global::Snakes_Ladders.Properties.Resources.token1;
            this.pbYellowStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbYellowStart.Location = new System.Drawing.Point(60, 15);
            this.pbYellowStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbYellowStart.Name = "pbYellowStart";
            this.pbYellowStart.Size = new System.Drawing.Size(44, 73);
            this.pbYellowStart.TabIndex = 2;
            this.pbYellowStart.TabStop = false;
            // 
            // panel
            // 
            this.panel.BackgroundImage = global::Snakes_Ladders.Properties.Resources.snakesAndLadders;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel.Controls.Add(this.pbPurpleToken);
            this.panel.Controls.Add(this.pbYellowToken);
            this.panel.Location = new System.Drawing.Point(4, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(705, 646);
            this.panel.TabIndex = 0;
            // 
            // pbPurpleToken
            // 
            this.pbPurpleToken.BackColor = System.Drawing.Color.Transparent;
            this.pbPurpleToken.BackgroundImage = global::Snakes_Ladders.Properties.Resources.token2;
            this.pbPurpleToken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPurpleToken.Location = new System.Drawing.Point(92, 585);
            this.pbPurpleToken.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbPurpleToken.Name = "pbPurpleToken";
            this.pbPurpleToken.Size = new System.Drawing.Size(31, 54);
            this.pbPurpleToken.TabIndex = 5;
            this.pbPurpleToken.TabStop = false;
            // 
            // pbYellowToken
            // 
            this.pbYellowToken.BackColor = System.Drawing.Color.Transparent;
            this.pbYellowToken.BackgroundImage = global::Snakes_Ladders.Properties.Resources.token1;
            this.pbYellowToken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbYellowToken.Location = new System.Drawing.Point(32, 393);
            this.pbYellowToken.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbYellowToken.Name = "pbYellowToken";
            this.pbYellowToken.Size = new System.Drawing.Size(33, 54);
            this.pbYellowToken.TabIndex = 4;
            this.pbYellowToken.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1029, 650);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.lby2);
            this.Controls.Add(this.lbx2);
            this.Controls.Add(this.lbdice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbp2);
            this.Controls.Add(this.lbMessage2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbp);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lby);
            this.Controls.Add(this.lbx);
            this.Controls.Add(this.lbyText);
            this.Controls.Add(this.lbxText);
            this.Controls.Add(this.btnRoll2);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.pbdice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbdice)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPurpleStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYellowStart)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPurpleToken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYellowToken)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbYellowStart;
        private System.Windows.Forms.PictureBox pbPurpleStart;
        private System.Windows.Forms.PictureBox pbdice;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnRoll2;
        private System.Windows.Forms.PictureBox pbPurpleToken;
        private System.Windows.Forms.PictureBox pbYellowToken;
        private System.Windows.Forms.Label lbxText;
        private System.Windows.Forms.Label lbyText;
        private System.Windows.Forms.Label lbx;
        private System.Windows.Forms.Label lby;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Label lbp;
        private System.Windows.Forms.Label lbp2;
        private System.Windows.Forms.Label lbMessage2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbdice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lby2;
        private System.Windows.Forms.Label lbx2;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnExit;
    }
}


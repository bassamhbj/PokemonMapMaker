
namespace PokemonMapMaker
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
            if (disposing && (components != null)) {
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
            this.pictureBoxTileset = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonFileBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxSelectedTile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTileset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedTile)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTileset
            // 
            this.pictureBoxTileset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTileset.Location = new System.Drawing.Point(36, 64);
            this.pictureBoxTileset.Name = "pictureBoxTileset";
            this.pictureBoxTileset.Size = new System.Drawing.Size(256, 448);
            this.pictureBoxTileset.TabIndex = 0;
            this.pictureBoxTileset.TabStop = false;
            this.pictureBoxTileset.Click += new System.EventHandler(this.pictureBoxTileset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(335, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Enabled = false;
            this.textBoxFileName.Location = new System.Drawing.Point(36, 31);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(175, 20);
            this.textBoxFileName.TabIndex = 4;
            // 
            // buttonFileBrowse
            // 
            this.buttonFileBrowse.Location = new System.Drawing.Point(217, 31);
            this.buttonFileBrowse.Name = "buttonFileBrowse";
            this.buttonFileBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonFileBrowse.TabIndex = 5;
            this.buttonFileBrowse.Text = "Browse...";
            this.buttonFileBrowse.UseVisualStyleBackColor = true;
            this.buttonFileBrowse.Click += new System.EventHandler(this.buttonFileBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 541);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Selected Tile:";
            // 
            // pictureBoxSelectedTile
            // 
            this.pictureBoxSelectedTile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSelectedTile.Location = new System.Drawing.Point(143, 536);
            this.pictureBoxSelectedTile.Name = "pictureBoxSelectedTile";
            this.pictureBoxSelectedTile.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxSelectedTile.TabIndex = 7;
            this.pictureBoxSelectedTile.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.pictureBoxSelectedTile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonFileBrowse);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxTileset);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTileset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedTile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTileset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonFileBrowse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxSelectedTile;
    }
}


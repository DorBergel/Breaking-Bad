
namespace BrakingBad
{
    partial class surface
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
            this.gamePlate = new System.Windows.Forms.PictureBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.gameBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.saveBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gamePlate)).BeginInit();
            this.SuspendLayout();
            // 
            // gamePlate
            // 
            this.gamePlate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gamePlate.Location = new System.Drawing.Point(69, 15);
            this.gamePlate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gamePlate.Name = "gamePlate";
            this.gamePlate.Size = new System.Drawing.Size(1518, 812);
            this.gamePlate.TabIndex = 0;
            this.gamePlate.TabStop = false;
            this.gamePlate.Paint += new System.Windows.Forms.PaintEventHandler(this.gamePlate_Paint);
            this.gamePlate.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gamePlate_MouseDoubleClick);
            this.gamePlate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gamePlate_MouseDown);
            this.gamePlate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gamePlate_MouseMove);
            this.gamePlate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gamePlate_MouseUp);
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(1459, 846);
            this.editBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(129, 48);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Edit Mode";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // gameBtn
            // 
            this.gameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameBtn.Location = new System.Drawing.Point(1291, 846);
            this.gameBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gameBtn.Name = "gameBtn";
            this.gameBtn.Size = new System.Drawing.Size(129, 48);
            this.gameBtn.TabIndex = 2;
            this.gameBtn.Text = "Game Mode";
            this.gameBtn.UseVisualStyleBackColor = true;
            this.gameBtn.Click += new System.EventHandler(this.gameBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(764, 846);
            this.startBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(129, 48);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Launch";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(87, 846);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(153, 69);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save Level";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBtn.Location = new System.Drawing.Point(314, 846);
            this.loadBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(153, 69);
            this.loadBtn.TabIndex = 6;
            this.loadBtn.Text = "Load Level";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(764, 899);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // surface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 941);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.gameBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.gamePlate);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "surface";
            this.Text = "Breaking Bad";
            this.Load += new System.EventHandler(this.surface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gamePlate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gamePlate;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button gameBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button button1;
    }
}


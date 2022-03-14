
namespace gamePDD
{
    partial class Form_usergame
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
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButton5
            // 
            this.metroButton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.metroButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroButton5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.metroButton5.Location = new System.Drawing.Point(620, 78);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(139, 35);
            this.metroButton5.TabIndex = 12;
            this.metroButton5.Text = "Выход";
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.metroButton2.Location = new System.Drawing.Point(74, 140);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(156, 60);
            this.metroButton2.TabIndex = 9;
            this.metroButton2.Text = "Загрузить игру";
            // 
            // metroButton1
            // 
            this.metroButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.metroButton1.Location = new System.Drawing.Point(74, 36);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(156, 60);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Начать игру";
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.metroProgressBar1.Location = new System.Drawing.Point(53, 534);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(978, 23);
            this.metroProgressBar1.TabIndex = 7;
            this.metroProgressBar1.Value = 56;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // metroButton6
            // 
            this.metroButton6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.metroButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroButton6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.metroButton6.Location = new System.Drawing.Point(620, 12);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.metroButton6.Size = new System.Drawing.Size(139, 38);
            this.metroButton6.TabIndex = 13;
            this.metroButton6.Text = "Сменить пользователя";
            this.metroButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // Form_usergame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 288);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.metroButton6);
            this.Name = "Form_usergame";
            this.Text = "Form5";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.Windows.Forms.ImageList imageList1;
        private MetroFramework.Controls.MetroButton metroButton6;
    }
}
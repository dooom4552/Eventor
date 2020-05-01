namespace Eventor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
       

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_1 = new System.Windows.Forms.Button();
            this.ComboBox_Message = new System.Windows.Forms.ComboBox();
            this.Button_Add = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showEventorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Label_SelectFile = new System.Windows.Forms.Label();
            this.Label_FileName = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.checkBox_alwaysontop = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(2, 9);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(185, 27);
            this.button_1.TabIndex = 2;
            this.button_1.Text = "Select Log Book";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Visible = false;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // ComboBox_Message
            // 
            this.ComboBox_Message.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Message.FormattingEnabled = true;
            this.ComboBox_Message.Location = new System.Drawing.Point(195, 46);
            this.ComboBox_Message.Name = "ComboBox_Message";
            this.ComboBox_Message.Size = new System.Drawing.Size(185, 23);
            this.ComboBox_Message.TabIndex = 4;
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(2, 43);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(185, 27);
            this.Button_Add.TabIndex = 5;
            this.Button_Add.Text = "Log the Event";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "No active Log Book";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.showEventorToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 48);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.выходToolStripMenuItem.Text = "Exit Eventor";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // showEventorToolStripMenuItem
            // 
            this.showEventorToolStripMenuItem.Name = "showEventorToolStripMenuItem";
            this.showEventorToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.showEventorToolStripMenuItem.Text = "Show Eventor";
            this.showEventorToolStripMenuItem.Click += new System.EventHandler(this.showEventorToolStripMenuItem_Click);
            // 
            // Label_SelectFile
            // 
            this.Label_SelectFile.AutoSize = true;
            this.Label_SelectFile.Location = new System.Drawing.Point(264, 50);
            this.Label_SelectFile.Name = "Label_SelectFile";
            this.Label_SelectFile.Size = new System.Drawing.Size(0, 15);
            this.Label_SelectFile.TabIndex = 6;
            // 
            // Label_FileName
            // 
            this.Label_FileName.AutoSize = true;
            this.Label_FileName.Location = new System.Drawing.Point(203, 15);
            this.Label_FileName.Name = "Label_FileName";
            this.Label_FileName.Size = new System.Drawing.Size(171, 15);
            this.Label_FileName.TabIndex = 7;
            this.Label_FileName.Text = "Select a Log Book for Logging";
            // 
            // button_Exit
            // 
            this.button_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Exit.BackgroundImage")));
            this.button_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Exit.Location = new System.Drawing.Point(395, -2);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(48, 48);
            this.button_Exit.TabIndex = 8;
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // checkBox_alwaysontop
            // 
            this.checkBox_alwaysontop.AutoSize = true;
            this.checkBox_alwaysontop.Checked = true;
            this.checkBox_alwaysontop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_alwaysontop.Location = new System.Drawing.Point(130, 77);
            this.checkBox_alwaysontop.Name = "checkBox_alwaysontop";
            this.checkBox_alwaysontop.Size = new System.Drawing.Size(100, 19);
            this.checkBox_alwaysontop.TabIndex = 9;
            this.checkBox_alwaysontop.Text = "always on top";
            this.checkBox_alwaysontop.UseVisualStyleBackColor = true;
            this.checkBox_alwaysontop.CheckedChanged += new System.EventHandler(this.checkBox_alwaysontop_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 103);
            this.Controls.Add(this.checkBox_alwaysontop);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.Label_FileName);
            this.Controls.Add(this.Label_SelectFile);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.ComboBox_Message);
            this.Controls.Add(this.button_1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventor";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.ComboBox ComboBox_Message;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label Label_SelectFile;
        private System.Windows.Forms.Label Label_FileName;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showEventorToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_alwaysontop;
    }
}


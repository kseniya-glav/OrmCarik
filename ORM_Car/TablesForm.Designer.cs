namespace ORM_Car
{
    partial class TablesForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ListTable = new System.Windows.Forms.ListBox();
            this.gb = new System.Windows.Forms.GroupBox();
            this.LView = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListTable
            // 
            this.ListTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListTable.FormattingEnabled = true;
            this.ListTable.Location = new System.Drawing.Point(0, 0);
            this.ListTable.Name = "ListTable";
            this.ListTable.Size = new System.Drawing.Size(99, 375);
            this.ListTable.TabIndex = 1;
            this.ListTable.SelectedIndexChanged += new System.EventHandler(this.ListTable_SelectedIndexChanged);
            // 
            // gb
            // 
            this.gb.Controls.Add(this.LView);
            this.gb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb.Location = new System.Drawing.Point(99, 0);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(521, 375);
            this.gb.TabIndex = 1;
            this.gb.TabStop = false;
            this.gb.Text = "Таблица";
            // 
            // LView
            // 
            this.LView.ContextMenuStrip = this.contextMenuStrip1;
            this.LView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LView.FullRowSelect = true;
            this.LView.HideSelection = false;
            this.LView.Location = new System.Drawing.Point(3, 16);
            this.LView.Name = "LView";
            this.LView.Size = new System.Drawing.Size(515, 356);
            this.LView.TabIndex = 1;
            this.LView.UseCompatibleStateImageBehavior = false;
            this.LView.View = System.Windows.Forms.View.Details;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.изменитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 70);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // TablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 375);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.ListTable);
            this.Name = "TablesForm";
            this.Text = "Таблицы";
            this.gb.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListTable;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.ListView LView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
    }
}


namespace ORM_Car
{
    partial class CarInsert
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
            this.label5 = new System.Windows.Forms.Label();
            this.cbCarRental = new System.Windows.Forms.ComboBox();
            this.автопрокатыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carRental2DataSet = new ORM_Car.CarRental2DataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMarka = new System.Windows.Forms.ComboBox();
            this.маркиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.маркиМоделиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btColor = new System.Windows.Forms.Button();
            this.cbСondition = new System.Windows.Forms.ComboBox();
            this.cbDealer = new System.Windows.Forms.ComboBox();
            this.дилерыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carRental2DataSet1 = new ORM_Car.CarRental2DataSet1();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.epMain = new System.Windows.Forms.ErrorProvider(this.components);
            this.CD = new System.Windows.Forms.ColorDialog();
            this.автопрокатыTableAdapter = new ORM_Car.CarRental2DataSetTableAdapters.АвтопрокатыTableAdapter();
            this.маркиTableAdapter = new ORM_Car.CarRental2DataSetTableAdapters.МаркиTableAdapter();
            this.моделиTableAdapter = new ORM_Car.CarRental2DataSetTableAdapters.МоделиTableAdapter();
            this.дилерыTableAdapter = new ORM_Car.CarRental2DataSet1TableAdapters.ДилерыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.автопрокатыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRental2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.маркиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.маркиМоделиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дилерыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRental2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMain)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Автопрокат:";
            // 
            // cbCarRental
            // 
            this.cbCarRental.DataSource = this.автопрокатыBindingSource;
            this.cbCarRental.DisplayMember = "Название_автопроката";
            this.cbCarRental.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarRental.FormattingEnabled = true;
            this.cbCarRental.Location = new System.Drawing.Point(87, 6);
            this.cbCarRental.Name = "cbCarRental";
            this.cbCarRental.Size = new System.Drawing.Size(136, 21);
            this.cbCarRental.TabIndex = 5;
            this.cbCarRental.ValueMember = "Код_автопроката";
            // 
            // автопрокатыBindingSource
            // 
            this.автопрокатыBindingSource.DataMember = "Автопрокаты";
            this.автопрокатыBindingSource.DataSource = this.carRental2DataSet;
            // 
            // carRental2DataSet
            // 
            this.carRental2DataSet.DataSetName = "CarRental2DataSet";
            this.carRental2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Марка:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Модель:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Цвет:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Состояние:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дилер:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Цена за сутки:";
            // 
            // cbMarka
            // 
            this.cbMarka.DataSource = this.маркиBindingSource;
            this.cbMarka.DisplayMember = "Название_марки";
            this.cbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarka.FormattingEnabled = true;
            this.cbMarka.Location = new System.Drawing.Point(87, 37);
            this.cbMarka.Name = "cbMarka";
            this.cbMarka.Size = new System.Drawing.Size(136, 21);
            this.cbMarka.TabIndex = 12;
            this.cbMarka.ValueMember = "Код_марки";
            // 
            // маркиBindingSource
            // 
            this.маркиBindingSource.DataMember = "Марки";
            this.маркиBindingSource.DataSource = this.carRental2DataSet;
            // 
            // cbModel
            // 
            this.cbModel.DataSource = this.маркиМоделиBindingSource;
            this.cbModel.DisplayMember = "Название_модели";
            this.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(87, 64);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(136, 21);
            this.cbModel.TabIndex = 13;
            this.cbModel.ValueMember = "Код_модели";
            // 
            // маркиМоделиBindingSource
            // 
            this.маркиМоделиBindingSource.DataMember = "Марки_Модели";
            this.маркиМоделиBindingSource.DataSource = this.маркиBindingSource;
            // 
            // btColor
            // 
            this.btColor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btColor.Location = new System.Drawing.Point(87, 92);
            this.btColor.Name = "btColor";
            this.btColor.Size = new System.Drawing.Size(136, 21);
            this.btColor.TabIndex = 14;
            this.btColor.UseVisualStyleBackColor = true;
            this.btColor.Click += new System.EventHandler(this.btColor_Click);
            // 
            // cbСondition
            // 
            this.cbСondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbСondition.FormattingEnabled = true;
            this.cbСondition.Location = new System.Drawing.Point(87, 120);
            this.cbСondition.Name = "cbСondition";
            this.cbСondition.Size = new System.Drawing.Size(136, 21);
            this.cbСondition.TabIndex = 15;
            this.cbСondition.ValueMember = "Код_диллера";
            // 
            // cbDealer
            // 
            this.cbDealer.DataSource = this.дилерыBindingSource;
            this.cbDealer.DisplayMember = "Название_фирмы";
            this.cbDealer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDealer.FormattingEnabled = true;
            this.cbDealer.Location = new System.Drawing.Point(87, 153);
            this.cbDealer.Name = "cbDealer";
            this.cbDealer.Size = new System.Drawing.Size(136, 21);
            this.cbDealer.TabIndex = 16;
            this.cbDealer.ValueMember = "Код_диллера";
            // 
            // дилерыBindingSource
            // 
            this.дилерыBindingSource.DataMember = "Дилеры";
            this.дилерыBindingSource.DataSource = this.carRental2DataSet1;
            // 
            // carRental2DataSet1
            // 
            this.carRental2DataSet1.DataSetName = "CarRental2DataSet1";
            this.carRental2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(101, 180);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(122, 20);
            this.tbPrice.TabIndex = 17;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(15, 206);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 23);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "Изменить/Добавить";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(123, 206);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // epMain
            // 
            this.epMain.ContainerControl = this;
            // 
            // автопрокатыTableAdapter
            // 
            this.автопрокатыTableAdapter.ClearBeforeFill = true;
            // 
            // маркиTableAdapter
            // 
            this.маркиTableAdapter.ClearBeforeFill = true;
            // 
            // моделиTableAdapter
            // 
            this.моделиTableAdapter.ClearBeforeFill = true;
            // 
            // дилерыTableAdapter
            // 
            this.дилерыTableAdapter.ClearBeforeFill = true;
            // 
            // CarInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 238);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.cbDealer);
            this.Controls.Add(this.cbСondition);
            this.Controls.Add(this.btColor);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.cbMarka);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbCarRental);
            this.Controls.Add(this.label5);
            this.Name = "CarInsert";
            this.Text = "Добавить";
            this.Load += new System.EventHandler(this.CarRentalInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.автопрокатыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRental2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.маркиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.маркиМоделиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дилерыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRental2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCarRental;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMarka;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.Button btColor;
        private System.Windows.Forms.ComboBox cbСondition;
        private System.Windows.Forms.ComboBox cbDealer;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider epMain;
        private System.Windows.Forms.ColorDialog CD;
        private CarRental2DataSet carRental2DataSet;
        private CarRental2DataSet1 carRental2DataSet1;
        private System.Windows.Forms.BindingSource автопрокатыBindingSource;
        private CarRental2DataSetTableAdapters.АвтопрокатыTableAdapter автопрокатыTableAdapter;
        private System.Windows.Forms.BindingSource маркиBindingSource;
        private CarRental2DataSetTableAdapters.МаркиTableAdapter маркиTableAdapter;
        private System.Windows.Forms.BindingSource маркиМоделиBindingSource;
        private CarRental2DataSetTableAdapters.МоделиTableAdapter моделиTableAdapter;
        private System.Windows.Forms.BindingSource дилерыBindingSource;
        private CarRental2DataSet1TableAdapters.ДилерыTableAdapter дилерыTableAdapter;
    }
}
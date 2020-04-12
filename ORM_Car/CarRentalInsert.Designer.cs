namespace ORM_Car
{
    partial class CarRentalInsert
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOwner = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAccount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBank = new System.Windows.Forms.ComboBox();
            this.банкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carRental2DataSet = new ORM_Car.CarRental2DataSet();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.epMain = new System.Windows.Forms.ErrorProvider(this.components);
            this.банкиTableAdapter = new ORM_Car.CarRental2DataSetTableAdapters.БанкиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.банкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRental2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMain)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(97, 6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(136, 20);
            this.tbName.TabIndex = 4;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Собственик:";
            // 
            // tbOwner
            // 
            this.tbOwner.Location = new System.Drawing.Point(97, 36);
            this.tbOwner.Name = "tbOwner";
            this.tbOwner.Size = new System.Drawing.Size(136, 20);
            this.tbOwner.TabIndex = 6;
            this.tbOwner.TextChanged += new System.EventHandler(this.tbOwner_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Адрес:";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(97, 68);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(136, 20);
            this.tbAddress.TabIndex = 8;
            this.tbAddress.TextChanged += new System.EventHandler(this.tbAddress_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Рас. счет:";
            // 
            // tbAccount
            // 
            this.tbAccount.Location = new System.Drawing.Point(97, 100);
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Size = new System.Drawing.Size(136, 20);
            this.tbAccount.TabIndex = 10;
            this.tbAccount.TextChanged += new System.EventHandler(this.tbAccount_TextChanged);
            this.tbAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAccount_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Банк:";
            // 
            // cbBank
            // 
            this.cbBank.DataSource = this.банкиBindingSource;
            this.cbBank.DisplayMember = "Название_банка";
            this.cbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBank.FormattingEnabled = true;
            this.cbBank.Location = new System.Drawing.Point(97, 130);
            this.cbBank.Name = "cbBank";
            this.cbBank.Size = new System.Drawing.Size(136, 21);
            this.cbBank.TabIndex = 5;
            this.cbBank.ValueMember = "Код_банка";
            // 
            // банкиBindingSource
            // 
            this.банкиBindingSource.DataMember = "Банки";
            this.банкиBindingSource.DataSource = this.carRental2DataSet;
            // 
            // carRental2DataSet
            // 
            this.carRental2DataSet.DataSetName = "CarRental2DataSet";
            this.carRental2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(18, 157);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 23);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "Изменить/Добавить";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(133, 157);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // epMain
            // 
            this.epMain.ContainerControl = this;
            // 
            // банкиTableAdapter
            // 
            this.банкиTableAdapter.ClearBeforeFill = true;
            // 
            // CarRentalInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 190);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbBank);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAccount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbOwner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Name = "CarRentalInsert";
            this.Text = "Добавить";
            this.Load += new System.EventHandler(this.CarRentalInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.банкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRental2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOwner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBank;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider epMain;
        private CarRental2DataSet carRental2DataSet;
        private System.Windows.Forms.BindingSource банкиBindingSource;
        private CarRental2DataSetTableAdapters.БанкиTableAdapter банкиTableAdapter;
    }
}
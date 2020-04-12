using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORM_Car
{
    public partial class CarRentalInsert : Form
    {
        public string LastName = "";
        public int index = 0;
        public FormType FT;
        public enum FormType
        {
            Insert,
            Update
        }
        public string CName
        {
            get { return tbName.Text; }
            set { tbName.Text = value; }
        }
        public string COwner
        {
            get { return tbOwner.Text; }
            set { tbOwner.Text = value; }
        }
        public string CAddress
        {
            get { return tbAddress.Text; }
            set { tbAddress.Text = value; }
        }
        public string CAccount
        {
            get { return tbAccount.Text; }
            set { tbAccount.Text = value; }
        }
        public int CBank
        {
            get { return Convert.ToInt32(cbBank.SelectedValue); }
            set { cbBank.SelectedValue = Convert.ToInt32(value); }
        }
        public CarRentalInsert(FormType frmType)
        {
            InitializeComponent();
            FT = frmType;
            switch (frmType)
            {
                case FormType.Insert:
                    btnOK.Text = @"Добавить";
                    break;
                case FormType.Update:
                    btnOK.Text = @"Изменить";
                    btnOK.Enabled = true;
                    break;
            }
        }

        private void CarRentalInsert_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carRental2DataSet.Банки". При необходимости она может быть перемещена или удалена.
            this.банкиTableAdapter.Fill(this.carRental2DataSet.Банки);
            // TODO: This line of code loads data into the 'carRental2DataSet.Банки' table. You can move, or remove it, as needed.
            this.банкиTableAdapter.Fill(this.carRental2DataSet.Банки);
            switch (FT)
            {
                case FormType.Insert:
                    cbBank.SelectedValue = index + 1;
                    break;
                case FormType.Update:
                    cbBank.SelectedValue = index;
                    break;
            }
        }

        private void tbAccount_TextChanged(object sender, EventArgs e)
        {
            if (tbAccount.Text.Length != 20)
            {
                epMain.SetError(tbAccount, "Расчётный счёт состоит из 20 цифр.");
                btnOK.Enabled = false;
                return;
            }
            else
            {
                epMain.SetError(tbAccount, "");
                btnOK.Enabled = true;
            }
            if (tbName.Text == "" || tbOwner.Text == "" || tbAddress.Text == "")
            {
                btnOK.Enabled = false;
                return;
            }
            btnOK.Enabled = true;
        }

        private void tbAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            using (ModelCarRental MRC = new ModelCarRental())
            {
                Автопрокаты g = new Автопрокаты();
                g.Название_автопроката = tbName.Text;
                foreach (Автопрокаты count in MRC.Автопрокаты)
                {
                    if (tbName.Text.Length > 20 || tbName.Text.Length < 4)
                    {
                        epMain.SetError(tbName, "Название должно быть от 4 до 20 символов.");
                        btnOK.Enabled = false;
                        return;
                    }
                    else
                    {
                        epMain.SetError(tbName, "");
                        btnOK.Enabled = true;
                    }
                    if ((LastName != g.Название_автопроката && count.Название_автопроката == g.Название_автопроката))
                    {
                        epMain.SetError(tbName, "Такое название уже есть.\nНазвание должно быть уникальным.");
                        btnOK.Enabled = false;
                        return;
                    }
                    else
                    {
                        epMain.SetError(tbName, "");
                        btnOK.Enabled = true;
                    }
                }
                if (tbAccount.Text == "" || tbOwner.Text == "" || tbAddress.Text == "")
                {
                    btnOK.Enabled = false;
                    return;
                }
                btnOK.Enabled = true;
            }
        }

        private void tbOwner_TextChanged(object sender, EventArgs e)
        {
            if (tbOwner.Text.Length > 20 || tbOwner.Text.Length < 7)
            {
                epMain.SetError(tbOwner, "ФИО собственника должно состоять не менее чем\nиз 7 символов, и не более чем из 20 символов.");
                btnOK.Enabled = false;
                return;
            }
            else
            {
                epMain.SetError(tbOwner, "");
                btnOK.Enabled = true;
            }
            if (tbAccount.Text == "" || tbName.Text == "" || tbAddress.Text == "")
            {
                btnOK.Enabled = false;
                return;
            }
            btnOK.Enabled = true;
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            if (tbAddress.Text.Length > 50 || tbAddress.Text.Length < 3)
            {
                epMain.SetError(tbAddress, "Адрес должен состоять не менее чем\nиз 3 символов, и не более чем из 50 символов.");
                btnOK.Enabled = false;
                return;
            }
            else
            {
                epMain.SetError(tbAddress, "");
                btnOK.Enabled = true;
            }
            if (tbAccount.Text == "" || tbName.Text == "" || tbOwner.Text == "")
            {
                btnOK.Enabled = false;
                return;
            }
            btnOK.Enabled = true;
        }
    }
}

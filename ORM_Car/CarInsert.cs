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
    public partial class CarInsert : Form
    {
        public string LastCondition = "";
        public int indexCarRental = 0, indexColor = 0, indexModel = 0, indexDealer = 0, indexMarka = 0;
        public FormType FT;
        public enum FormType
        {
            Insert,
            Update
        }
        public int CCarRental
        {
            get { return Convert.ToInt32(cbCarRental.SelectedValue); }
            set { cbCarRental.SelectedValue = Convert.ToInt32(value); }
        }
        public int CMarka
        {
            get { return Convert.ToInt32(cbMarka.SelectedValue); }
            set { cbMarka.SelectedValue = Convert.ToInt32(value); }
        }
        public int CColor
        {
            get { return btColor.BackColor.ToArgb(); }
        }
        public string Color
        {
            set { btColor.Tag = Convert.ToString(value); }
        }
        public string CСondition
        {
            get { return cbСondition.Text; }
            set { cbСondition.Text = value; }
        }

       

        public string CPrice
        {
            get { return tbPrice.Text; }
            set { tbPrice.Text = value; }
        }

       
        public int CDealer
        {
            get { return Convert.ToInt32(cbDealer.SelectedValue); }
            set { cbDealer.SelectedValue = Convert.ToInt32(value); }
        }
        public int Model
        {
            get { return Convert.ToInt32(cbModel.SelectedValue); }
            set { cbModel.SelectedValue = Convert.ToInt32(value); }
        }

       
        public CarInsert(FormType frmType)
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
            string[] mas = { "не удовлетворительно", "удовлетворительно", "хорошо", "отлично" };
            cbСondition.DataSource = mas;
        }
        private void CarRentalInsert_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carRental2DataSet1.Дилеры". При необходимости она может быть перемещена или удалена.
            this.дилерыTableAdapter.Fill(this.carRental2DataSet1.Дилеры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carRental2DataSet.Модели". При необходимости она может быть перемещена или удалена.
            this.моделиTableAdapter.Fill(this.carRental2DataSet.Модели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carRental2DataSet.Марки". При необходимости она может быть перемещена или удалена.
            this.маркиTableAdapter.Fill(this.carRental2DataSet.Марки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carRental2DataSet.Автопрокаты". При необходимости она может быть перемещена или удалена.
            this.автопрокатыTableAdapter.Fill(this.carRental2DataSet.Автопрокаты);
            // TODO: This line of code loads data into the 'carRental2DataSet1.Дилеры' table. You can move, or remove it, as needed.
            this.дилерыTableAdapter.Fill(this.carRental2DataSet1.Дилеры);
            // TODO: This line of code loads data into the 'carRental2DataSet.Модели' table. You can move, or remove it, as needed.
            this.моделиTableAdapter.Fill(this.carRental2DataSet.Модели);
            // TODO: This line of code loads data into the 'carRental2DataSet.Марки' table. You can move, or remove it, as needed.
            this.маркиTableAdapter.Fill(this.carRental2DataSet.Марки);
            // TODO: This line of code loads data into the 'carRental2DataSet.Автопрокаты' table. You can move, or remove it, as needed.
            this.автопрокатыTableAdapter.Fill(this.carRental2DataSet.Автопрокаты);
            btColor.BackColor = System.Drawing.Color.FromArgb(indexColor);
            cbСondition.SelectedIndex = cbСondition.FindString(LastCondition);
            switch (FT)
            {
                case FormType.Insert:
                    cbDealer.SelectedValue = indexDealer + 1;
                    cbMarka.SelectedValue = indexMarka + 1;
                    cbModel.SelectedValue = indexModel + 1;
                    cbCarRental.SelectedValue = indexCarRental + 1;

                    break;
                case FormType.Update:
                    cbDealer.SelectedValue = indexDealer;
                    cbMarka.SelectedValue = indexMarka;
                    cbModel.SelectedValue = indexModel;
                    cbCarRental.SelectedValue = indexCarRental;
                    btnOK.Enabled = true;
                    break;
            }
        }

        private void btColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                btColor.BackColor = cd.Color;
            }
        }
        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            {
                if (tbPrice.Text == "")
                {
                    epMain.SetError(tbPrice, "Поле не может быть пустым.");
                    btnOK.Enabled = false;
                    return;
                }
                else
                {
                    epMain.SetError(tbPrice, "");
                    btnOK.Enabled = true;
                }
                if (Convert.ToInt32(tbPrice.Text) > 25000)
                {
                    epMain.SetError(tbPrice, "Стоимость аренды должна быть не более 25000.");
                    btnOK.Enabled = false;
                    return;
                }
                else
                {
                    epMain.SetError(tbPrice, "");
                    btnOK.Enabled = true;
                }
                btnOK.Enabled = true;
            }
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }

    }
}

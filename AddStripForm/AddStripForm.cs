using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace AddStripForm
{
    public partial class AddStripForm : Form
    {
        Calculation calculation;
        CalcLine calcLine;
        bool ifFileChanged;

        public AddStripForm()
        {
            InitializeComponent();
            calculation = new Calculation(lstbx);
            ifFileChanged = false;


        }

        /// <summary> method: menuNew_Click
        /// check if current file is saved,
		/// then start a new text document by clearing the textbox and listbox.
		/// </summary>
        private void menuNew_Click(object sender, EventArgs e)
        {
            saveFileChange();
            txtbxEnter.Text = "";
            calculation.Clear();
            openFileDialog1.FileName = "";
            saveFileDialog1.FileName = "";
            ifFileChanged = false;
        }

        /// <summary> method: menuOpen_Click
        /// show the standard Open dialog box and if the user chooses a file name
        /// and clicks OK, then use that name to display the text of the file in
        /// the listbox.
        /// </summary>
        private void menuOpen_Click(object sender, EventArgs e)
        {
            saveFileChange();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                calculation.LoadFormFile(openFileDialog1.FileName);
                saveFileDialog1.FileName = openFileDialog1.FileName;
                ifFileChanged = false;
            }
        }

        /// <summary> method: saveChange
        /// detect if the file has been changed, 
        /// if it is changed, save it.
        /// It is used in other functions such as New, Open, and Exit.
        /// </summary>
        private void saveFileChange()
        {
            //detect if file is changed
            if (ifFileChanged)
            {
                DialogResult dialogResult = MessageBox.Show("There are changes on you file, do you want to save it before proceed?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (saveFileDialog1.FileName == "")
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            calculation.SaveToFile(saveFileDialog1.FileName);
                            openFileDialog1.FileName = saveFileDialog1.FileName;
                            MessageBox.Show("File has been saved.");
                        }
                    }
                    else
                    {
                        calculation.SaveToFile(saveFileDialog1.FileName);
                        openFileDialog1.FileName = saveFileDialog1.FileName;
                    }
                    ifFileChanged = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
                }
            }
        }


        /// <summary> method: menuSave_Click
        /// show the standard Save dialog box and if the user chooses a file name
        /// and clicks OK, then use that name to save the text of the listbox to a file.
        /// </summary>
        private void menuSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.FileName == "")
            {
                saveFileDialog1.FileName = "Calculation1.cal";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    calculation.SaveToFile(saveFileDialog1.FileName);
                    openFileDialog1.FileName = saveFileDialog1.FileName;
                }
            }
            else
            {
                calculation.SaveToFile(saveFileDialog1.FileName);
                openFileDialog1.FileName = saveFileDialog1.FileName;
            }
            MessageBox.Show("File has been saved.");
            ifFileChanged = false;
        }

        /// <summary> method: menuExit_Click
        /// before close, check if file is changed, if changed then prompt window ask for save,
        /// if not changed then exit program.
        /// </summary>
        private void menuExit_Click(object sender, EventArgs e)
        {
            saveFileChange();
            Close();
        }

        /// <summary> method: txtbxEnter_KeyPress
        /// first detect keypress, then validate the input, 
        /// if input is valide, then send input to calcLine and display operation in the listbox.
        /// </summary>
        private void txtbxEnter_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Input key validation
            //For existing string inputString in txtbxEnter:
            string inputString = txtbxEnter.Text;
            //if existString.length==0:
            //   if calcline !=""&&!(keyCode==+ - enter): message(the first char can only be + - enter);
            //   if calcline ==""&&!(keyCode==+ - ):message(the first char can only be + -);
            if (inputString.Length == 0)
            {
                if (lstbx.Items.Count == 0)
                {
                    if (!(e.KeyChar == (char)43 || e.KeyChar == (char)45))
                    {
                        MessageBox.Show("When you input operation for the first time, the first charactor (operator) can only be '+' or '-'.");
                        e.Handled = true;
                    }
                }
                else
                {
                    if (!(e.KeyChar == (char)43 || e.KeyChar == (char)45 || e.KeyChar == (char)Keys.Enter))
                    {
                        MessageBox.Show("When you input operation not for the first time, the first character (operator) can only be '+', '-', or enter.");
                        e.Handled = true;
                    }
                }
            }
            //else if existString.length==1:
            //   if !(key.code==number):message(the second char can only be number)
            else if (inputString.Length == 1)
            {
                if (!(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)8))
                {
                    MessageBox.Show("The second character can only be numbers.");
                    e.Handled = true;
                }
            }
            //else if existString.length==2:
            //   if !(key.code==number + - * / # = enter): message(char only number or + - * / # = or enter)
            else if (inputString.Length > 1)
            {
                bool IsContainsDot = txtbxEnter.Text.Contains(".");

                if (!(Char.IsDigit(e.KeyChar) || (!IsContainsDot && e.KeyChar == (char)46) || e.KeyChar == (char)8 || e.KeyChar == (char)43 || e.KeyChar == (char)45 || e.KeyChar == (char)42 || e.KeyChar == (char)47 || e.KeyChar == (char)35 || e.KeyChar == (char)61 || e.KeyChar == (char)Keys.Enter))
                {
                    MessageBox.Show("Only numbers or '+','-','*','/','#','=' or enter allowed.");
                    e.Handled = true;
                }
                else
                {
                    if (e.KeyChar == (char)43 || e.KeyChar == (char)45 || e.KeyChar == (char)42 || e.KeyChar == (char)47 || e.KeyChar == (char)35 || e.KeyChar == (char)61 || e.KeyChar == (char)Keys.Enter)
                    {
                        char Op = e.KeyChar;
                        calcLine = new CalcLine(inputString);
                        calculation.Add(calcLine);
                        if (e.KeyChar == (char)35 || e.KeyChar == (char)61 || e.KeyChar == (char)Keys.Enter)
                        {
                            //If end operator == '#', '=' or enter, add new calcLine for operation, then set textbox empty.
                            if (e.KeyChar == (char)Keys.Enter)
                            {
                                Op = '=';
                            }
                            calcLine = new CalcLine(Op.ToString());
                            calculation.Add(calcLine);
                            e.Handled = true;
                        }
                        txtbxEnter.Text = "";
                    }
                }
            }
            ifFileChanged = true;
        }

        /// <summary> method: lstbx_SelectedIndexChanged
        /// get selected index, then use calculation to find nth calcLine, then convert calcLine to string, 
        /// then show the string in the update textbox.
        /// </summary>
        private void lstbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbx.SelectedIndex > -1)
            {
                txtbxUpdate.Text = calculation.Find(lstbx.SelectedIndex).ToString();
            }
        }

        /// <summary> method: btnUpdate_Click
        /// validate calcLine format, then use calculation.replace function, 
        /// then show the string in the update textbox.
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstbx.SelectedIndex > -1)
            {
                string text = txtbxUpdate.Text;
                //To check the first operation, it can only be add or minus.
                if (lstbx.SelectedIndex == 0 && !(text[0] == '+' || text[0] == '-'))
                {
                    MessageBox.Show("For the first operation, only add and minus are allowed.");
                }
                //then check input validation using ifStringValidate() function.
                else
                {
                    if (ifStringValidate(txtbxUpdate.Text))
                    {
                        calcLine = new CalcLine(txtbxUpdate.Text);
                        calculation.Replace(calcLine, lstbx.SelectedIndex);
                        txtbxUpdate.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("A single character operation can only be '=' or '#'. Other valid operations should be 'operator+number', for example: '+43' or '*562'.");
                    }

                }
            }
            ifFileChanged = true;
        }

        /// <summary> method: ifStringValidate
        /// validate calcLine format.
        /// case 1: input string length==1, text can be only = or #;
        /// case 2: input string length>1,then input string(1, length-1) can be only numbers.
        /// </summary>
        private bool ifStringValidate(string stringForValidation)
        {
            if (stringForValidation.Length == 1 && (stringForValidation[0] == '=' || stringForValidation[0] == '#'))
            {
                return true;
            }
            else if (stringForValidation.Length > 1 && !(stringForValidation[0] == '=' || stringForValidation[0] == '#'))
            {
                string subEditText = stringForValidation.Substring(1, (stringForValidation.Length - 1));
                double theNewNumber;
                if (double.TryParse(subEditText, out theNewNumber))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary> method: btnDelete_Click
        /// delete selected calcLine object in calculation.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstbx.SelectedIndex > -1)
            {
                calculation.Delete(lstbx.SelectedIndex);
                txtbxUpdate.Text = "";
            }
            ifFileChanged = true;
        }

        /// <summary> method: btnInsert_Click
        /// check input validation first,
        /// then insert new calcLine object at selected position.
        /// </summary>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (lstbx.SelectedIndex > -1)
            {
                if (ifStringValidate(txtbxUpdate.Text))
                {
                    calcLine = new CalcLine(txtbxUpdate.Text);
                    calculation.Insert(calcLine, lstbx.SelectedIndex);
                    txtbxUpdate.Text = "";
                }
                else
                {
                    MessageBox.Show("A single character operation can only be '=' or '#'. Other valid operations should be 'operator+number', for example: '+43' or '*562'.");
                }
            }
            ifFileChanged = true;
        }

        /// <summary> method: menuSaveAs_Click
        /// open saveFileDialog to save file.
        /// </summary>
        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = openFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                calculation.SaveToFile(saveFileDialog1.FileName);
                openFileDialog1.FileName = saveFileDialog1.FileName;
                MessageBox.Show("File has been saved.");
                ifFileChanged = false;
            }
        }

        /// <summary> method: menuPrint_Click
        /// show preintPreviewDialog to allow print all operations.
        /// </summary>
        private void menuPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        /// <summary> method: printDocument1_PrintPage
        /// set print content and formant.
        /// </summary>
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //define print format
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font textFontCenter = new Font("Arial", 10, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 10, FontStyle.Bold);
            Font headingFont = new Font("Arial", 10, FontStyle.Bold);
            Brush brush = new SolidBrush(Color.Black);

            //margins
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;

            for (int i = 0; i < lstbx.Items.Count; i++)
            {
                string printString = lstbx.Items[i].ToString();
                g.DrawString(printString, headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
            }
        }
    }
}

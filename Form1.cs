using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_2
{
    public partial class Form1 : Form
    {
        double sum = 0;
        double userInputValue = 0;
        bool isFirstValue = true;
        bool isFirstOperator = true;
        bool equalToClicked = false;
        bool isOperatorClicked = false;
        bool isSeparatoClicked = false;
        string currentOperator = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ValueClick(object sender, EventArgs e)
        {
            Button selectedButton = (Button)sender;
            //edtUserEntry.Text += selectedButton.Text;
            if (isFirstValue == true)
            {
                if (isSeparatoClicked == true)
                {
                    edtUserEntry.Text += selectedButton.Text;

                }
                else
                {
                    edtUserEntry.Text += selectedButton.Text;
                    userInputValue = double.Parse(edtUserEntry.Text);
                }

            }
            else
            {
                edtUserEntry.Text += selectedButton.Text;
            }
        }

        private void OperatorClick(object sender, EventArgs e)
        {
            Button selectedOperator = (Button)sender;

            isFirstValue = false;
            isSeparatoClicked = false;



            if (isFirstOperator == true)
            {
                switch (selectedOperator.Text)
                {
                    case "+":
                        edtCalculations.Text = userInputValue.ToString() + " " + selectedOperator.Text;
                        sum = userInputValue;
                        currentOperator = selectedOperator.Text;
                        isFirstOperator = false;
                        edtUserEntry.Text = "";
                        break;
                    case "-":
                        edtCalculations.Text = userInputValue.ToString() + " " + selectedOperator.Text;
                        sum = userInputValue;
                        currentOperator = selectedOperator.Text;
                        isFirstOperator = false;
                        edtUserEntry.Text = "";
                        break;
                    case "x":
                        edtCalculations.Text = userInputValue.ToString() + " " + selectedOperator.Text;
                        sum = userInputValue;
                        currentOperator = selectedOperator.Text;
                        isFirstOperator = false;
                        edtUserEntry.Text = "";
                        break;
                    case "/":
                        edtCalculations.Text = userInputValue.ToString() + " " + selectedOperator.Text;
                        sum = userInputValue;
                        currentOperator = selectedOperator.Text;
                        isFirstOperator = false;
                        edtUserEntry.Text = "";
                        break;


                }

            }
            else
            {
                switch (currentOperator)
                {
                    case "+":
                        sum += double.Parse(edtUserEntry.Text);
                        edtCalculations.Text = sum.ToString() + " " + selectedOperator.Text;
                        currentOperator = selectedOperator.Text;
                        edtUserEntry.Text = "";
                        break;
                    case "-":
                        sum -= double.Parse(edtUserEntry.Text);
                        edtCalculations.Text = sum.ToString() + " " + selectedOperator.Text;
                        currentOperator = selectedOperator.Text;
                        edtUserEntry.Text = "";
                        break;
                    case "x":
                        sum *= double.Parse(edtUserEntry.Text);
                        edtCalculations.Text = sum.ToString() + " " + selectedOperator.Text;
                        currentOperator = selectedOperator.Text;
                        edtUserEntry.Text = "";
                        break;
                    case "/":
                        sum /= double.Parse(edtUserEntry.Text);
                        edtCalculations.Text = sum.ToString() + " " + selectedOperator.Text;
                        currentOperator = selectedOperator.Text;
                        edtUserEntry.Text = "";
                        break;


                }
            }

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            equalToClicked = true;
            switch (currentOperator)
            {
                case "+":
                    sum += double.Parse(edtUserEntry.Text);
                    edtCalculations.Text = "= " + sum.ToString();
                    break;
                case "-":
                    sum -= double.Parse(edtUserEntry.Text);
                    edtCalculations.Text = "= " + sum.ToString();
                    break;
                case "x":
                    sum *= double.Parse(edtUserEntry.Text);
                    edtCalculations.Text = "= " + sum.ToString();
                    break;
                case "/":
                    sum /= double.Parse(edtUserEntry.Text);
                    edtCalculations.Text = "= " + sum.ToString();
                    break;


            }
        }

        private void ClearButtonsClick(object sender, EventArgs e)
        {
            Button selectedButton = (Button)sender;
            switch (selectedButton.Text)
            {
                case "CE":
                    edtUserEntry.Text = "";
                    break;
                case "C":
                    edtUserEntry.Text = "";
                    edtCalculations.Text = "";
                    sum = 0;
                    isFirstOperator = true;
                    isFirstValue = true;
                    equalToClicked = false;
                    userInputValue = 0;
                    currentOperator = "";
                    break;
                case "←":
                    if (edtUserEntry.Text != "")
                    {
                        edtUserEntry.Text = edtUserEntry.Text.Remove(edtUserEntry.Text.Length - 1);
                    }
                    break;


            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (isSeparatoClicked == false)
            {

                edtUserEntry.Text += ",";
                isSeparatoClicked = true;
            }
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            edtUserEntry.Text = (double.Parse(edtUserEntry.Text) * -1).ToString();
            userInputValue = double.Parse(edtUserEntry.Text);
        }
    }
}

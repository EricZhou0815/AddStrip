using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Windows.Forms;


namespace AddStripForm
{
    public class Calculation
    {
        private ArrayList theCals;
        //to store the CalcLine objects that make up the lines of the calculation

        private ListBox lstDisplay;
        //holds a reference to a listbox component on the main form so that the data 
        //in the calculation object can be displayed in the listbox
        private CalcLine CalcLine;

        /// <summary> method Calculation
        /// initializes the reference to the listbox and starts a new ArrayList.
        /// </summary>
        public Calculation(ListBox lb)
        {
            lstDisplay=lb;
            theCals = new ArrayList();
        }

        /// <summary> method Add
        /// add a CalcLine object to the ArrayList then redisplay the calculations.
        /// </summary>
        public void Add(CalcLine cl)
        {
            theCals.Add(cl);
            Redisplay();
        }

        /// <summary> method Clear
        /// clear the ArrayList and the listbox.
        /// </summary>
        public void Clear()
        {
            theCals.Clear();
            lstDisplay.Items.Clear();
        }

        /// <summary> method Redisplay
        /// Clear the listbox and then for each line in the calculation, if the line is 
        /// an ordinary calculation add the text version of the CalcLine to the listbox 
        /// and calculate the result of the calculation so far. If the line is for a total 
        /// or subtotal add the text for the total or subtotal to the listbox. If the line 
        /// is for a total, the result of the calculation so far is reset to zero.
        /// </summary>
        public void Redisplay()
        {
            lstDisplay.Items.Clear();
            double ResultSoFar = 0;
            foreach (CalcLine calcline in theCals)
            {
                if (calcline.Op==Operator.plus ||calcline.Op == Operator.times|| calcline.Op == Operator.minus|| calcline.Op == Operator.divide)
                {
                    //add text version of CalcLine to listbox
                    lstDisplay.Items.Add(calcline.ToString());
                    //calculate the calculation sofar ResultsSoFar
                    ResultSoFar=calcline.NextResult(ResultSoFar);
                }
                else if (calcline.Op == Operator.subtotal)
                {
                    //add text of total or subtotal to the listbox
                    lstDisplay.Items.Add(calcline.ToString()+ResultSoFar.ToString()+"<subtotal");
                    //calculate the calculation sofar ResultsSoFar
                    ResultSoFar = calcline.NextResult(ResultSoFar);
                }
                else if(calcline.Op == Operator.total)
                {
                    //add text of total or subtotal to the listbox
                    lstDisplay.Items.Add(calcline.ToString()+ResultSoFar.ToString() + "<<total");
                    //set ResultsSoFar to 0
                    ResultSoFar = 0;
                }
               
            }

        }

        /// <summary> method Find
        /// return a reference to the nth CalcLine object in the ArrayList. 
        /// </summary>
        public CalcLine Find(int n)
        {
            return (CalcLine)theCals[n];
        }


        /// <summary> method Replace
        /// replace the nth CalcLine object in the ArrayList with the newCalc 
        /// object, and then redisplay the calculations.
        /// </summary>
        public void Replace(CalcLine newCalc, int n)
        {
            theCals[n] = newCalc;
            Redisplay();
        }

        /// <summary> method Insert
        /// insert the newCalc CalcLine object in the ArrayList immediately 
        /// before the nth object, and then redisplay the calculations.
        /// </summary>
        public void Insert(CalcLine newCalc, int n)
        {
            theCals.Insert(n, newCalc);
            Redisplay();
        }

        /// <summary> method Delete
        /// delete the nth CalcLine object in the ArrayList, and then redisplay the calculations. 
        /// </summary>
        public void Delete(int n)
        {
            theCals.RemoveAt(n);
            Redisplay();
        }

        /// <summary> method SaveToFile
        /// save all the CalcLine objects in the ArrayList as lines of text in the given file. 
        /// </summary>
        public void SaveToFile(string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            for (int i = 0; i < theCals.Count; i++)
            {                 
                sw.WriteLine(theCals[i]);  
            }
            sw.Close();
        }

        /// <summary> method LoadFormFile
        /// clear the ArrayList and then open the given file and convert the lines 
        /// of the file to a set of CalcLine objects held in the ArrayList. Then redisplay 
        /// the calculations.
        /// </summary>
        public void LoadFormFile(string filename)
        {
            Clear();
            StreamReader sr = new StreamReader(filename);
            string temp = sr.ReadLine();
            while (temp != null)
            {
                CalcLine = new CalcLine(temp);
                theCals.Add(CalcLine);
                temp = sr.ReadLine();
            }
            sr.Close();
            Redisplay();
        }
    }
}

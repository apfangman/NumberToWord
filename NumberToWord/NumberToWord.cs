//Number to word chain finder thing.  Written by Austin Fangman
//Please don't roast me too hard if you find some dumb things in here.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace NumberToWord
{
    public partial class NumberToWord : Form
    {
        public NumberToWord()
        {
            InitializeComponent();
        }

        private Tuple<int, string> getChain(string number)
        {
            string toReturn = "";
            int chainLength = 0;
            NumberWord nw = new NumberWord(number);
            toReturn += nw.Number;
            chainLength++;
            number = nw.ToString();
            bool keepGoing = true;
            while (keepGoing)
            {
                number = number.Replace(" ", "");
                nw = new NumberWord(number.Length.ToString());
                toReturn += " -> " + nw.Number;
                chainLength++;
                number = nw.ToString();
                if (nw.ToString() == "four")
                {
                    keepGoing = false;
                }
            }
            return new Tuple<int, string>(chainLength, toReturn);
        } 

        private void uxConvertButton_Click(object sender, EventArgs e)
        {
            if(uxInputBox.Text != "")
            {
                NumberWord nw = new NumberWord(uxInputBox.Text);
                uxOutputBox.Text = nw.ToString();
            }
            else
            {
                uxOutputBox.Text = "";
            }
        }

        private void uxChainButton_Click(object sender, EventArgs e)
        {
            if (uxInputBox.Text != "")
            {
                uxActualChainLabel.Text = "";
                Tuple<int, string> results = getChain(uxInputBox.Text);
                uxActualChainLabel.Text = results.Item2;
                uxActualChainLengthLabel.Text = results.Item1.ToString();
            }
            else
            {
                uxActualChainLabel.Text = "";
            }
        }

        private void uxLongestChainButton_Click(object sender, EventArgs e)
        {
            int chainLength = Int16.Parse(uxActualChainLengthLabel.Text);
            Tuple<int, string> results;
            uxActualChainLabel.Text = "";
            uxActualChainLengthLabel.Text = "";
            for (ulong i = 1; i <= ulong.MaxValue; i++)
            {
                results = getChain(i.ToString());
                uxActualCurrentLabel.Text = i.ToString();
                uxActualCurrentLabel.Refresh();
                if(results.Item1 > chainLength)
                {
                    chainLength = results.Item1;
                    uxActualChainLabel.Text = results.Item2;
                    uxActualChainLengthLabel.Text = results.Item1.ToString();
                    uxActualChainLabel.Refresh();
                    uxActualChainLengthLabel.Refresh();
                }
            }
        }
    }
}

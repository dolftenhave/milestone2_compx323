using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooApp
{
    public partial class FeedForm : Form
    {
        // Constants that provide the min and max for what an animal could be fed
        private const decimal MIN = 0.01M;
        private const decimal MAX = 99999.99M;
        // The aIDs of the animals to be fed
        private int[] aids;
        // Boolean to allow nuds to change each other
        private Boolean isFirstChange;

        public FeedForm(int[] aid)
        {
            isFirstChange = true;
            aids = aid;
            InitializeComponent();
        }

        private void FeedForm_Load(object sender, EventArgs e)
        {
            int length = aids.Length;
            labelTitle.Text = $"Feeding {length} Animals";

            // M for deciMal
            // Set the min/max for numeric up downs
            numericUpDownPerAnimal.Minimum = MIN;
            numericUpDownPerAnimal.Maximum = MAX;
            numericUpDownTotalAmount.Minimum = MIN * length;

            // ENSURE that the max does not exceed the decimal max (it shouldn't)
            decimal maxTotal;
            try
            {
                maxTotal = MAX * length;
            }
            catch (Exception ex)
            {
                maxTotal = Decimal.MaxValue;
            }

            numericUpDownTotalAmount.Maximum = maxTotal;

            // Set initial value
            numericUpDownPerAnimal.Value = 1M;
        }

        private void numericUpDownPerAnimal_ValueChanged(object sender, EventArgs e)
        {
            if (isFirstChange)
            {
                isFirstChange = false;
                numericUpDownTotalAmount.Value = numericUpDownPerAnimal.Value * aids.Length;
            }
            isFirstChange = true;
        }

        private void numericUpDownTotalAmount_ValueChanged(object sender, EventArgs e)
        {
            if (isFirstChange)
            {
                isFirstChange = false;
                numericUpDownPerAnimal.Value = numericUpDownTotalAmount.Value / aids.Length;
            }
            isFirstChange = true;
        }
    }
}

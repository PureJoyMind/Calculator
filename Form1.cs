using System.Data;
using System.Xml;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        bool idle = true;
        private int pointCount = 0;

        private void genericButton_click(object sender, EventArgs e)
        {
            if (idle) resultBox.Clear();

            resultBox.Text += (sender as Button)?.Text;
            idle = false;
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            var res = Calculate(resultBox.Text);
            answerBox.Text = res.ToString();
            idle = true;
        }

        public object Calculate(string exp)
        {
            var dc = new DataTable(exp, "");
            var res = new object();

            try
            {
                res = dc.Compute(exp, "");
            }
            catch (Exception e)
            {
                res = "NaN";
            }

            return res;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultBox.Clear();
            answerBox.Clear();
        }
    }
}
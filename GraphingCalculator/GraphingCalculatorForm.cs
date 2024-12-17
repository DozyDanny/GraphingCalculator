namespace GraphingCalculator
{
    public partial class GrapingCalculatorForm : Form
    {
        // Equation:
        // y=mx^exp+b

        // variables of that equation
        private float m = 0.1F; // x multiplier
        private float exp = 2; // exponent on the x
        private float b = -100; // constant at the end
        private int w = 922; // width of the panel that the graph is drawn on
        private int h = 758; // height "
        private int detail = 5; // higher numbers render faster but have lower quality

        public GrapingCalculatorForm()
        {
            InitializeComponent();
        }

        private void panel1Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen redPen = new Pen(Color.Red, 5);
            Pen grayPen = new Pen(Color.Gray, 1);

            // Draw the margins
            PointF hMarginPnt1 = new PointF(0, h / 2);
            PointF hMarginPnt2 = new PointF(w, h / 2);
            e.Graphics.DrawLine(grayPen, hMarginPnt1, hMarginPnt2);

            PointF vMarginPnt1 = new PointF(w / 2, 0);
            PointF vMarginPnt2 = new PointF(w / 2, h);
            e.Graphics.DrawLine(grayPen, vMarginPnt1, vMarginPnt2);

            // This loop draws the curve
            for (int i = 0; i < w; i += detail)
            {
                if (exp > -1 && exp < 1 && i < w / 2)
                {
                    i = w / 2 - 1;
                    // the left side of the graph DNE for these inverted porabolas so we skip to the middle
                }

                try
                {
                    PointF pnt1 = new PointF((float)i, (float)(-Math.Pow((m * (i - (0.5 * w))), exp) - b + (0.5 * h)));
                    PointF pnt2 = new PointF((float)(i + detail), (float)(-Math.Pow((m * ((i + detail) - (0.5 * w))), exp) - b + (0.5 * h)));

                    e.Graphics.DrawLine(redPen, pnt1, pnt2);
                }
                catch
                {
                    // This shouldn't happen but I didn't think it through that hard lol
                    // Should've paid more attention in math
                }
            }
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            // Here, we parse bad input because we can't allow strings as our X, exponent or constant
            // value, it must all be real numbers to do the calculation properly.

            // Grab m value
            bool mSuccess = float.TryParse(xTextBox.Text, out m);
            if (mSuccess)
                errorText.Text = "Graph Loaded";
            else
                errorText.Text = "X must be a number!";

            // Grab exponent value
            bool expSuccess = float.TryParse(exponentTextBox.Text, out exp);
            if (expSuccess)
                errorText.Text = "Graph Loaded";
            else
                errorText.Text = "Exponent must be a number!";

            // Grab constant value
            bool constSuccess = float.TryParse(constantTextBox.Text, out b);
            if (constSuccess)
                errorText.Text = "Graph Loaded";
            else
                errorText.Text = "Constant must be a number!";

            // Update grpah
            if (mSuccess && expSuccess && constSuccess)
                panel1.Invalidate();
        }
    }
}

namespace FunctionUse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            Pen lijnkleur = Pens.Black;
            Brush vulKleur = Brushes.Red;
            
            g.DrawRectangle(lijnkleur, 0, 0, 50, 50);
            g.FillRectangle(vulKleur, 60, 60, 30, 30);

           
            g.FillRectangle(vulKleur, 100, 100, 40, 40);
            g.DrawLine(lijnkleur, 150, 50, 100, 0);
            g.DrawLine(lijnkleur, 100, 0, 50, 50);

            g.DrawLine(lijnkleur, 50, 50, 150, 50); 

            
            g.DrawEllipse(lijnkleur, 200, 200, 50, 50); 
        }
    }
}

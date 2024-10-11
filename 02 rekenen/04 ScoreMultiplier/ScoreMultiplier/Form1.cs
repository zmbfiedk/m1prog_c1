
namespace UpAndDown
{
    public partial class Form1 : Form
    {
       
        int score = 0;
        int multiplier = 1;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                
                score += 1 * multiplier; 
            }

            
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(Color.Black);

            // Display multiplier and score
            e.Graphics.DrawString("Multiplier: " + multiplier, Font, Brushes.White, 50, 40);
            e.Graphics.DrawString("Score: " + score, Font, Brushes.White, 50, 50);
       
        }

        public void DoLogic(float frametime)
        {
            
            score += 2 * multiplier; 
        }
    }
}


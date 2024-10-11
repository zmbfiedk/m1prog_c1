
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MovePlayer
{
    public partial class Form1 : Form
    {
        private const int size = 16;
        Square player = new Square();
        float playerSpeed = 100;

        bool left, right, down, up;
        private Timer gameTimer;
        private DateTime lastFrameTime;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;

            player.x = 10;
            player.y = 10;
            player.color = Brushes.Red;

            
            gameTimer = new Timer();
            gameTimer.Interval = 16; 
            gameTimer.Tick += GameLoop;
            gameTimer.Start();

            lastFrameTime = DateTime.Now;
        }

        private void GameLoop(object sender, EventArgs e)
        {
            float frametime = (float)(DateTime.Now - lastFrameTime).TotalSeconds;
            lastFrameTime = DateTime.Now;
            DoLogic(frametime);
            Invalidate(); 
        }

        private void Form1_KeyUp(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) up = false;
            if (e.KeyCode == Keys.S) down = false;
            if (e.KeyCode == Keys.A) left = false;
            if (e.KeyCode == Keys.D) right = false;
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) up = true;
            if (e.KeyCode == Keys.S) down = true;
            if (e.KeyCode == Keys.A) left = true;
            if (e.KeyCode == Keys.D) right = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.Clear(Color.Black);
            g.FillRectangle(player.color, player.x, player.y, size, size);
        }

        internal void DoLogic(float frametime)
        {
            if (up)
            {
                player.y -= playerSpeed * frametime; 
            }
            if (down)
            {
                player.y += playerSpeed * frametime; 
            }
            if (left)
            {
                player.x -= playerSpeed * frametime; 
            }
            if (right)
            {
                player.x += playerSpeed * frametime; 
            }

            player.x = Math.Max(0, Math.Min(player.x, this.ClientSize.Width - size));
            player.y = Math.Max(0, Math.Min(player.y, this.ClientSize.Height - size));
        
        }
    }

    
    public class Square
    {
        public float x;
        public float y;
        public Brush color;
    }
}

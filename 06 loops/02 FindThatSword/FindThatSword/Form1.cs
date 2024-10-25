

namespace MenuDraw
{
    public partial class Form1 : Form
    {
        Equipment[] inventory;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            
            inventory = new Equipment[]
            {
                new Equipment("The minotaur", EquipmentType.Axe),
                new Equipment("The Grandfather", EquipmentType.Sword),
                new Equipment("corpsemourn", EquipmentType.ChestArmor),
                new Equipment("immortal kings pillar", EquipmentType.LegArmor)
           
            };
       
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            
            base.OnPaint(e);
           
            e.Graphics.Clear(Color.Black);


            
            for (int i = 0; i < inventory.Length; i++)
            {
                
                Equipment item = inventory[i];

                
                if (item.Type == EquipmentType.Sword || item.Type == EquipmentType.Axe)
                {
                    e.Graphics.DrawImage(item.Image, 0, i * 50);
                }
            }
        }

        internal void DoLogic(float frametime)
        {
            // Not used currently
        }
    }
}



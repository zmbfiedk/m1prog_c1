namespace Winkelen
{
    public partial class Form1 : Form
    {
        int sponge = 0;
        double spongePrice = 49.99;
        int elden = 0;
        double eldenPrice = 79.99;
        int spiderman = 0;
        double spidermanPrice = 60.99;
        int ps5s = 0;
        double ps5Price = 499.99;
        int controllers = 0;
        double controllerPrice = 69.99;
public Form1()
        
        {
            InitializeComponent();
        }

        private void calculateTotal_Click(object sender, EventArgs e)
        {
            // 1) Reken hier de totaal prijs uit
            double total = (ps5s * ps5Price) + (controllers * controllerPrice) +
                           (sponge * spongePrice) + (spiderman * spidermanPrice) + 
                           (elden * eldenPrice);

            
            totalPrice.Text = total.ToString("C"); 
        }

        private void koopPs5_Click(object sender, EventArgs e)
        {
            ps5s++;
            labelPs5Amount.Text = ps5s.ToString();
        }

        private void koopController_Click(object sender, EventArgs e)
        {
            controllers++;
            labelCtrlAmount.Text = controllers.ToString();
        }

        private void koopSponge_Click(object sender, EventArgs e)
        {
            sponge++;
            labelSpongeAmount.Text = sponge.ToString();
        }

        private void koopSpiderman_Click(object sender, EventArgs e)
        {
            spiderman++;
            labelSpiderAmount.Text = spiderman.ToString();
        }

        private void koopElden_Click(object sender, EventArgs e)
        {
            elden++;
            labelEldenAmount.Text = elden.ToString();
        }
    }
}


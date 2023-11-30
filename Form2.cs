
using Microsoft.VisualBasic;
using Stripe;
using Stripe.Terminal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kassaapparat_app
{
    public partial class Form2 : Form
    {
        public Form1 form1;

        private List<Vara> butikslista = new List<Vara>();
        private List<Vara> varukorgslista = new List<Vara>();
        private int budget = 1000;     // Ange din budget här
        private string path = "vara.csv";
      
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

            butikslista.Add(new Vara("tröja", 200));
            butikslista.Add(new Vara("byxor", 250));
            butikslista.Add(new Vara("klänning", 300));
            butikslista.Add(new Vara("jeans", 270));
            butikslista.Add(new Vara("skjorta", 200));
            butikslista.Add(new Vara("kofta", 260));
            butikslista.Add(new Vara("blus", 200));


            foreach (Vara vara in butikslista)
            {
                butikslistabox.Items.Add(vara.Name + " " + vara.Price + "kr");
            }

        }

        private void startbutton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Välkommen till online shopping");
        }

        private void inköpbutton_Click(object sender, EventArgs e)
        {
            // Logik för att lägga till varor i varukorgen

            if (butikslistabox.SelectedItem != null)
            {
                varukorgslistabox.Items.Add((string)butikslistabox.SelectedItem);
                varukorgslista.Add(butikslista[butikslistabox.SelectedIndex]);

                int totalCost = 0;
                foreach (Vara vara in varukorgslista)
                {
                    totalCost += vara.Price;
                    totalcostlabel1.Text = "Total Cost:" + totalCost + "kr";
                }

                double discountRate = 0.30; // 30% rabatt
                double discountAmount = totalCost * discountRate;
                double discountedTotal = totalCost - discountAmount;

                //total kostnad med rabatt
                totalcostlabel1.Text = "Total Cost (med rabatt): " + discountedTotal.ToString("C");

                //visa återstående budget
                int remainingBudget = budget - (int)discountedTotal;
                budgetlabel1.Text = "Återstående budget: " + remainingBudget.ToString("C");
            }
        }

        private void tabortbutton1_Click(object sender, EventArgs e)
        {
            {
                if (varukorgslistabox.SelectedItem != null)
                {
                    // Hämta det valda objektet
                    string selectedItem = (string)varukorgslistabox.SelectedItem;

                    // Splitta det valda objektet för att få namn och pris
                    string[] selectedParts = selectedItem.Split(' ');
                    string itemName = selectedParts[0];
                    int itemPrice = int.Parse(selectedParts[1].Replace("kr", ""));

                    // Hitta och ta bort objektet från varukorgslista
                    Vara selectedVara = varukorgslista.FirstOrDefault(vara => vara.Name == itemName && vara.Price == itemPrice);
                    if (selectedVara != null)
                    {
                        varukorgslista.Remove(selectedVara);

                        // Uppdatera varukorgslistabox med de återstående objekten
                        varukorgslistabox.Items.Clear();
                        foreach (Vara vara in varukorgslista)
                        {
                          varukorgslistabox.Items.Add(vara.Name + " " + vara.Price + "kr");
                        }

                        // Uppdatera den totala kostnaden
                        int totalCost = varukorgslista.Sum(vara => vara.Price);
                        double discountRate = 0.30;
                        double discountAmount = totalCost * discountRate;
                        double discountedTotal = totalCost - discountAmount;

                        totalcostlabel1.Text = "Total kostnad (med rabatt): " + discountedTotal.ToString("C");

                        // Uppdatera och visa den återstående budgeten
                        int remainingBudget = budget - (int)discountedTotal;
                        budgetlabel1.Text = "Återstående budget: " + remainingBudget.ToString("C");
                    }
                }
            }
        }

        private void sparabutton2_Click(object sender, EventArgs e)
        {
            // Spara varukorgen i en CSV-fil
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (Vara vara in varukorgslista)
                {
                    sw.WriteLine(vara.GetCSV());
                }
            }
        }

        private void laddabutton3_Click(object sender, EventArgs e)
        {
            // Ladda varukorgen från en CSV-fil
            varukorgslistabox.Items.Clear();
            int totalcost = 0;
            double discountRate = 0.30; // 30% rabatt
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {

                        string[] strings = line.Split(",");

                        string name = strings[0];
                        int price = Convert.ToInt32(strings[1]);

                        Vara vara = new Vara(name, price);
                        varukorgslistabox.Items.Add(vara.Name + " " + vara.Price + "kr");
                        totalcost += vara.Price;
                        totalcostlabel1.Text = "Total kostnad: " + totalcost + "kr";


                        line = reader.ReadLine();
                    }
                }
                double discountAmount = totalcost * discountRate;
                double discountedTotal = totalcost - discountAmount;

                // Uppdatera total kostnad med rabatt
                totalcostlabel1.Text = "Total kostnad (med rabatt): " + discountedTotal.ToString("C");

            }
            catch (Exception ex)
            {
                // Hantera exception här
                MessageBox.Show("Ett fel inträffade: " + ex.Message, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            int totalCost = varukorgslista.Sum(vara => vara.Price);

            // Lägg till 30% rabatt här

            double discountRate = 0.30;
            double discountAmount = totalCost * discountRate;
            double discountedTotal = totalCost - discountAmount;

            // Uppdatera och visa återstående budget

            int remainingBudget = budget - (int)discountedTotal;

            if (remainingBudget < 0)
            {
              MessageBox.Show("Tyvärr, du har inte tillräckligt med pengar för dessa inköp. Justera din varukorg eller öka din budget.");
            }
            else
            {
                // Skriv ett meddelande till användaren om inköpen och återstående budget

               string purchasedItems = string.Join(", ", varukorgslista.Select(vara => vara.Name));
               string message = $"Tack för ditt köp!\nDu har handlat: {purchasedItems}\nTotal kostnad: {discountedTotal:C}\nÅterstående budget: {remainingBudget:C}";
               MessageBox.Show(message);
            }

            // Stäng formuläret

            form1.Close();
        }

      
    }
}
    

    

















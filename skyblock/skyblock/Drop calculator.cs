using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skyblock
{


    public partial class Form1 : Form
    {
        public string selectedItem;
        public string DropChance;
        public double magicFind;
        public double myVariable;
        public double selectedValue;
        public Dictionary<string, float> Drops = new Dictionary<string, float>() {
    { "Beheaded Horror", 0.14f },
    { "Scythe Blade", 0.1f },
    { "Smite VI Book", 0.14f },
    { "Shard of the Shredded", 0.06f },
    { "Warden Heart", 0.01f },
    { "Fly Catcher", 0.17f },
    { "Tarantula Talisman", 0.17f },
    { "Digested Mosquito", 0.06f },
    { "Red Claw Egg", 0.12f },
    { "Couture Rune", 0.24f },
    { "Grizzly Bait", 0.06f },
    { "Overflux Capacitor", 0.04f },
    { "Depresso Machine", 0.39f },
    { "Chalice", 0.18f },
    { "Ender Artifact Upgrader", 0.03f },
    { "Void Conqueror Skin", 0.18f },
    { "Judgement Core", 0.06f },
    { "Enchant Rune", 0.05f },
    { "Ender Slayer VII", 0.01f },
    { "Smite VII Book", 0.05f },
    { "Ghoul Pet", 0.001f },
    { "Hound Pet", 0.001f },
    { "Phoenix Pet", 0.000003f },
    { "Scatha Pet", 0.04f },
    { "Enderman Pet", 0.0006f },
    { "Tarantula Pet",  0.001f },
    { "Golem Pet", 0.6f },
    { "Squid Pet", 0.44f },
    { "Magma Cube Pet", 0.4f },
    { "Guardian Pet", 0.0005f },
    { "Rat Pet", 0.2f },
    { "Enderman Cortex Rewriter", 0.1f },
    { "Epic Combat Exp Boost", 0.0033f },
    { "Foraging Exp Boost", 0.01f },
    { "Epic Fishing Exp Boost", 0.02f },
    { "Weak Wolf Catalyst", 0.5f },
    { "Travel Scroll to The Nest/Howling Cave", 0.02f },
    { "Recall Potion", 0.08f },
    { "Sorrow", 0.12f },
    { "Volta", 0.2f },
    { "Plasma", 0.1f },
    { "Ghostly Boots", 0.01f },
    {"Minos Relic", 0.02f },
    { "Daedalus Stick", 0.08f },
    { "Chimera", 1f },
    { "Golden Powder", 0.05f },
    { "Exp Share Core", 0.01f },
    { "Baby Yeti Pet", 0.8f },
    { "Lucky Clover Core", 0.66f}
        };
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(Drops.Keys.ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            selectedValue = Drops[selectedItem];
            double DropChance = selectedValue;
            string displayValue1 = DropChance.ToString("0.######");
            MessageBox.Show("The selected item's drop chance is: " + displayValue1 + "%");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double adjustedDropRate = selectedValue * (1 + (magicFind / 100));
            string displayValue = adjustedDropRate.ToString("0.##########");
            MessageBox.Show("The chance for the drop is " + displayValue + "%");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(textBox1.Text, out magicFind))
            {

            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }
    }
}
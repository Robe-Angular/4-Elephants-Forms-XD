using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Elephants_Forms_XD
{
    public partial class Form1 : Form
    {
        Elephant lucinda = new Elephant() { Name = "Lucinda" , EarSize = 33};
        Elephant lloyd = new Elephant() { Name = "Lloyd" , EarSize = 40};
        
        public Form1()
        {
            InitializeComponent();
            lloyd.TellMe("Hi", lucinda);
            lucinda.SpeakTo(lloyd, "Hello");
        }

        private void LloydButton_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void LucindaButton_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void SwapButton_Click(object sender, EventArgs e)
        {
            Elephant swappingElephant = lucinda;
            lucinda = lloyd;
            lloyd = swappingElephant;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd = lucinda;
            lloyd.EarSize = 4321;
            lloyd.WhoAmI();
        }
    }
}

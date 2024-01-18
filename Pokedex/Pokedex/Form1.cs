using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex
{
    enum attack {Attack, SP_Attack, Defense, SP_Defense}
    struct Struct
    {
        string Name;
        string Type;
        int Level;
        attack AttackType;
        int HP;
        int EXP;
        bool Legendary;
        bool Shiny;
        int Generation;
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Pokemon.txt"))
            {
                StreamReader inFile = new StreamReader("Pokemon.txt");
                string S = inFile.ReadToEnd();
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            DebugBox.Clear();
            DebugBox.Text += NameBox.Text;
            DebugBox.Text += " | ";
            DebugBox.Text += TypeBox.Text;
            DebugBox.Text += " | ";
            DebugBox.Text += LevelUp.Value;
            DebugBox.Text += " | ";
            DebugBox.Text += HpUp.Value;
            DebugBox.Text += " | ";
            DebugBox.Text += EXPUp.Value;
            DebugBox.Text += " | ";
            DebugBox.Text += GenerationUp.Value;
            DebugBox.Text += " | ";
            DebugBox.Text += AttackCombo.Text;
            DebugBox.Text += " | ";
            if (LegendaryCheck.Checked == true)
            {
                DebugBox.Text += LegendaryCheck.Text;
            }
            DebugBox.Text += " | ";
            if (ShinyCheck.Checked == true)
            {
                DebugBox.Text += ShinyCheck.Text;
            }
        }
    }
}

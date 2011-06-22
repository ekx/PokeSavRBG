using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PokeSavRBG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String SAV;

        private void button2_Click_1(object sender, EventArgs e)
        {
            Party party = new Party(Offsets.PartyPokemon1, true, 0, 1, this);
            party.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Party party = new Party(Offsets.PartyPokemon2, true, 0, 2, this);
            party.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Party party = new Party(Offsets.PartyPokemon3, true, 0, 3, this);
            party.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Party party = new Party(Offsets.PartyPokemon4, true, 0, 4, this);
            party.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Party party = new Party(Offsets.PartyPokemon5, true, 0, 5, this);
            party.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Party party = new Party(Offsets.PartyPokemon6, true, 0, 6, this);
            party.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            //Now set the file type
            fd.Filter = "save files (*.sav)|*.sav|All files (*.*)|*.*";

            //Set the starting directory and the title.
            fd.InitialDirectory = "K:\\Emulators\\VisualBoyAdvanceM956\\SRAM\\"; fd.Title = "Select a save file";

            //Present to the user.
            if (fd.ShowDialog() == DialogResult.OK)
                SAV = fd.FileName;

            if (SAV == String.Empty)
                return;

            FileInfo fileInfo = new FileInfo(SAV);
            save.data = new byte[fileInfo.Length];
            FileStream fileStream = fileInfo.OpenRead();
            fileStream.Read(save.data, 0, save.data.Length);
            fileStream.Close();

            updateData();
        }

        public void updateData()
        {
            textBox1.Text = save.data[Offsets.PartyHeader].ToString();
            label1.Text = ((Pokemon)save.data[Offsets.PartyHeader + 1]).ToString();
            label2.Text = ((Pokemon)save.data[Offsets.PartyHeader + 2]).ToString();
            label3.Text = ((Pokemon)save.data[Offsets.PartyHeader + 3]).ToString();
            label4.Text = ((Pokemon)save.data[Offsets.PartyHeader + 4]).ToString();
            label5.Text = ((Pokemon)save.data[Offsets.PartyHeader + 5]).ToString();
            label6.Text = ((Pokemon)save.data[Offsets.PartyHeader + 6]).ToString();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ushort hl = 0x2598;
            ushort bc = 0x0F8B;
            byte a = 0x01;
            byte d = 0x00;


            while (true)
            {
                a = save.data[hl];
                hl++;

                a = (byte)(a + d);

                d = a;

                bc--;

                byte[] temp = BitConverter.GetBytes(bc);
                a = temp[1];

                if ((a | temp[0]) == 0) break;
            }

            a = d;

            a = (byte)(a ^ 0xFF);

            save.data[0x3523] = a;

            FileInfo fileInfo = new FileInfo(SAV);
            FileStream fileStream = fileInfo.OpenWrite();
            fileStream.Write(save.data, 0, save.data.Length);
            fileStream.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*FolderBrowserDialog fb = new FolderBrowserDialog();

            //fb.RootFolder = "K:\\TEST\\";
            //Now set the file type

            if (fb.ShowDialog() == DialogResult.OK)
                SAV = fb.SelectedPath;

            if (SAV == String.Empty)
                return;

            /*FileInfo fileInfo = new FileInfo(SAV);
            save.data = new byte[fileInfo.Length];
            FileStream fileStream = fileInfo.OpenRead();
            fileStream.Read(save.data, 0, save.data.Length);
            fileStream.Close();

            updateData();*/

            string[] temp = Directory.GetFiles("K:\\TEST\\final\\");
            string[] temp2 = Directory.GetFiles("K:\\TEST\\final\\");
            MessageBox.Show(temp[0]);
            MessageBox.Show(temp[1]);

            for (int c = 0; c < temp.Length; c++)
            {
                temp2[c] = temp[c].Substring(14, 2);
                Directory.CreateDirectory("K:\\TEST\\final\\" + temp2[c] + "\\");
                File.Move(temp[c], "K:\\TEST\\final\\" + temp2[c] + "\\" + temp[c].Substring(14, 6));
            }

            MessageBox.Show(temp2[0]);
            MessageBox.Show(temp2[1]);
        }
    }
}

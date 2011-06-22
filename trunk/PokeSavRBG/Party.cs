using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PokeSavRBG
{
    public partial class Party : Form
    {
        public Party(int offset, bool isParty, int box, int pkmnnr, Form1 parent)
        {
            InitializeComponent();

            pkmnoffset = offset;
            this.isParty = isParty;
            this.box = box;
            this.pkmnnr = pkmnnr;
            this.parent = parent;

            comboBox1.DataSource = System.Enum.GetNames(typeof(Pokemon));
            comboBox2.DataSource = System.Enum.GetNames(typeof(Status));
            comboBox3.DataSource = System.Enum.GetNames(typeof(Type));
            comboBox4.DataSource = System.Enum.GetNames(typeof(Type));
            comboBox5.DataSource = System.Enum.GetNames(typeof(Moves));
            comboBox6.DataSource = System.Enum.GetNames(typeof(Moves));
            comboBox7.DataSource = System.Enum.GetNames(typeof(Moves));
            comboBox8.DataSource = System.Enum.GetNames(typeof(Moves));

            if (!isParty)
            {
                textBoxHP.Enabled = false;
                textBoxATT.Enabled = false;
                textBoxDEF.Enabled = false;
                textBoxSPD.Enabled = false;
                textBoxSPC.Enabled = false;
            }

            populate();
        }

        int pkmnoffset;
        bool isParty;
        int box;
        int pkmnnr;
        Form1 parent;

        public void populate()
        {
            comboBox1.Text = ((Pokemon)save.data[pkmnoffset]).ToString();

            textBox1.Text = ((((int)save.data[pkmnoffset + Offsets.CurrentHP]) << 8) | save.data[pkmnoffset + Offsets.CurrentHP + 1]).ToString();

            comboBox2.Text = ((Status)save.data[pkmnoffset + Offsets.Status]).ToString();
            comboBox3.Text = ((Type)save.data[pkmnoffset + Offsets.Typ1]).ToString();
            comboBox4.Text = ((Type)save.data[pkmnoffset + Offsets.Typ2]).ToString();

            comboBox5.Text = ((Moves)save.data[pkmnoffset + Offsets.Move1]).ToString();
            comboBox6.Text = ((Moves)save.data[pkmnoffset + Offsets.Move2]).ToString();
            comboBox7.Text = ((Moves)save.data[pkmnoffset + Offsets.Move3]).ToString();
            comboBox8.Text = ((Moves)save.data[pkmnoffset + Offsets.Move4]).ToString();

            textBox10.Text = ((((int)save.data[pkmnoffset + Offsets.TrainerID]) << 8) | save.data[pkmnoffset + Offsets.TrainerID + 1]).ToString();
            textBox11.Text = ((((int)save.data[pkmnoffset + Offsets.Experience]) << 16) | (save.data[pkmnoffset + Offsets.Experience + 1] << 8) | save.data[pkmnoffset + Offsets.Experience + 2]).ToString();

            textBoxHPEV.Text = ((((int)save.data[pkmnoffset + Offsets.HPEV]) << 8) | save.data[pkmnoffset + Offsets.HPEV + 1]).ToString();
            textBoxATTEV.Text = ((((int)save.data[pkmnoffset + Offsets.ATTEV]) << 8) | save.data[pkmnoffset + Offsets.ATTEV + 1]).ToString();
            textBoxDEFEV.Text = ((((int)save.data[pkmnoffset + Offsets.DEFEV]) << 8) | save.data[pkmnoffset + Offsets.DEFEV + 1]).ToString();
            textBoxSPDEV.Text = ((((int)save.data[pkmnoffset + Offsets.SPDEV]) << 8) | save.data[pkmnoffset + Offsets.SPDEV + 1]).ToString();
            textBoxSPCEV.Text = ((((int)save.data[pkmnoffset + Offsets.SPCEV]) << 8) | save.data[pkmnoffset + Offsets.SPCEV + 1]).ToString();

            string temp = ToBinary(save.data[pkmnoffset + Offsets.ADIV]);
            temp = temp.PadLeft(8, '0');
            string attiv = temp.Substring(0, 4);
            string defiv = temp.Substring(4, 4);
            temp = ToBinary(save.data[pkmnoffset + Offsets.SSIV]);
            temp = temp.PadLeft(8, '0');
            string spdiv = temp.Substring(0, 4);
            string spciv = temp.Substring(4, 4);
            string hpiv = attiv.Substring(3, 1) + defiv.Substring(3, 1) + spdiv.Substring(3, 1) + spciv.Substring(3, 1);

            textBoxHPIV.Text = hpiv;
            textBoxATTIV.Text = attiv;
            textBoxDEFIV.Text = defiv;
            textBoxSPDIV.Text = spdiv;
            textBoxSPCIV.Text = spciv;

            temp = ToBinary(save.data[pkmnoffset + Offsets.PP1]);
            temp = temp.PadLeft(8, '0');
            textBoxPPU1.Text = Convert.ToInt64(temp.Substring(0, 2), 2).ToString();
            textBoxPPR1.Text = Convert.ToInt64(temp.Substring(2, 6), 2).ToString();
            temp = ToBinary(save.data[pkmnoffset + Offsets.PP2]);
            temp = temp.PadLeft(8, '0');
            textBoxPPU2.Text = Convert.ToInt64(temp.Substring(0, 2), 2).ToString();
            textBoxPPR2.Text = Convert.ToInt64(temp.Substring(2, 6), 2).ToString();
            temp = ToBinary(save.data[pkmnoffset + Offsets.PP3]);
            temp = temp.PadLeft(8, '0');
            textBoxPPU3.Text = Convert.ToInt64(temp.Substring(0, 2), 2).ToString();
            textBoxPPR3.Text = Convert.ToInt64(temp.Substring(2, 6), 2).ToString();
            temp = ToBinary(save.data[pkmnoffset + Offsets.PP4]);
            temp = temp.PadLeft(8, '0');
            textBoxPPU4.Text = Convert.ToInt64(temp.Substring(0, 2), 2).ToString();
            textBoxPPR4.Text = Convert.ToInt64(temp.Substring(2, 6), 2).ToString();

            //textBox12.Text = save.data[pkmnoffset + Offsets.LVL1].ToString();

            if (isParty)
            {
                textBox12.Text = save.data[pkmnoffset + Offsets.LVL2].ToString();
                textBoxHP.Text = ((((int)save.data[pkmnoffset + Offsets.HP]) << 8) | save.data[pkmnoffset + Offsets.HP + 1]).ToString();
                textBoxATT.Text = ((((int)save.data[pkmnoffset + Offsets.ATT]) << 8) | save.data[pkmnoffset + Offsets.ATT + 1]).ToString();
                textBoxDEF.Text = ((((int)save.data[pkmnoffset + Offsets.DEF]) << 8) | save.data[pkmnoffset + Offsets.DEF + 1]).ToString();
                textBoxSPD.Text = ((((int)save.data[pkmnoffset + Offsets.SPD]) << 8) | save.data[pkmnoffset + Offsets.SPD + 1]).ToString();
                textBoxSPC.Text = ((((int)save.data[pkmnoffset + Offsets.SPC]) << 8) | save.data[pkmnoffset + Offsets.SPC + 1]).ToString();

                switch (pkmnnr)
                {
                    case 1:
                        textBox2.Text = Conv.pStringToString(Offsets.PartyPokemon1Trainer, 11);
                        textBox3.Text = Conv.pStringToString(Offsets.PartyPokemon1Nick, 11);
                        break;
                    case 2:
                        textBox2.Text = Conv.pStringToString(Offsets.PartyPokemon2Trainer, 11);
                        textBox3.Text = Conv.pStringToString(Offsets.PartyPokemon2Nick, 11);
                        break;
                    case 3:
                        textBox2.Text = Conv.pStringToString(Offsets.PartyPokemon3Trainer, 11);
                        textBox3.Text = Conv.pStringToString(Offsets.PartyPokemon3Nick, 11);
                        break;
                    case 4:
                        textBox2.Text = Conv.pStringToString(Offsets.PartyPokemon4Trainer, 11);
                        textBox3.Text = Conv.pStringToString(Offsets.PartyPokemon4Nick, 11);
                        break;
                    case 5:
                        textBox2.Text = Conv.pStringToString(Offsets.PartyPokemon5Trainer, 11);
                        textBox3.Text = Conv.pStringToString(Offsets.PartyPokemon5Nick, 11);
                        break;
                    case 6:
                        textBox2.Text = Conv.pStringToString(Offsets.PartyPokemon6Trainer, 11);
                        textBox3.Text = Conv.pStringToString(Offsets.PartyPokemon6Nick, 11);
                        break;
                }
            }
        }

        private string ToBinary(Int64 Decimal)
        {
            Int64 BinaryHolder;
            char[] BinaryArray;
            string BinaryResult = "";
            while (Decimal > 0)
            {
                BinaryHolder = Decimal % 2;
                BinaryResult += BinaryHolder;
                Decimal = Decimal / 2;
            }
            BinaryArray = BinaryResult.ToCharArray();
            Array.Reverse(BinaryArray);
            BinaryResult = new string(BinaryArray);
            return BinaryResult;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            save.data[pkmnoffset] = (byte)Enum.Parse(typeof(Pokemon), comboBox1.Text).GetHashCode();
            
            byte[] temp = BitConverter.GetBytes(ushort.Parse(textBox1.Text));
            save.data[pkmnoffset + Offsets.CurrentHP] = temp[1];
            save.data[pkmnoffset + Offsets.CurrentHP + 1] = temp[0];

            save.data[pkmnoffset + Offsets.Status] = (byte)Enum.Parse(typeof(Status), comboBox2.Text).GetHashCode();
            save.data[pkmnoffset + Offsets.Typ1] = (byte)Enum.Parse(typeof(Type), comboBox3.Text).GetHashCode();
            save.data[pkmnoffset + Offsets.Typ2] = (byte)Enum.Parse(typeof(Type), comboBox4.Text).GetHashCode();

            save.data[pkmnoffset + Offsets.Move1] = (byte)Enum.Parse(typeof(Moves), comboBox5.Text).GetHashCode();
            save.data[pkmnoffset + Offsets.Move2] = (byte)Enum.Parse(typeof(Moves), comboBox6.Text).GetHashCode();
            save.data[pkmnoffset + Offsets.Move3] = (byte)Enum.Parse(typeof(Moves), comboBox7.Text).GetHashCode();
            save.data[pkmnoffset + Offsets.Move4] = (byte)Enum.Parse(typeof(Moves), comboBox8.Text).GetHashCode();

            temp = BitConverter.GetBytes(ushort.Parse(textBox10.Text));
            save.data[pkmnoffset + Offsets.TrainerID] = temp[1];
            save.data[pkmnoffset + Offsets.TrainerID + 1] = temp[0];
            temp = BitConverter.GetBytes(int.Parse(textBox11.Text));
            save.data[pkmnoffset + Offsets.Experience] = temp[2];
            save.data[pkmnoffset + Offsets.Experience + 1] = temp[1];
            save.data[pkmnoffset + Offsets.Experience + 2] = temp[0];

            temp = BitConverter.GetBytes(ushort.Parse(textBoxHPEV.Text));
            save.data[pkmnoffset + Offsets.HPEV] = temp[1];
            save.data[pkmnoffset + Offsets.HPEV + 1] = temp[0];
            temp = BitConverter.GetBytes(ushort.Parse(textBoxATTEV.Text));
            save.data[pkmnoffset + Offsets.ATTEV] = temp[1];
            save.data[pkmnoffset + Offsets.ATTEV + 1] = temp[0];
            temp = BitConverter.GetBytes(ushort.Parse(textBoxDEFEV.Text));
            save.data[pkmnoffset + Offsets.DEFEV] = temp[1];
            save.data[pkmnoffset + Offsets.DEFEV + 1] = temp[0];
            temp = BitConverter.GetBytes(ushort.Parse(textBoxSPDEV.Text));
            save.data[pkmnoffset + Offsets.SPDEV] = temp[1];
            save.data[pkmnoffset + Offsets.SPDEV + 1] = temp[0];
            temp = BitConverter.GetBytes(ushort.Parse(textBoxSPCEV.Text));
            save.data[pkmnoffset + Offsets.SPCEV] = temp[1];
            save.data[pkmnoffset + Offsets.SPCEV + 1] = temp[0];

            save.data[pkmnoffset + Offsets.ADIV] = Convert.ToByte(textBoxATTIV.Text + textBoxDEFIV.Text, 2);
            save.data[pkmnoffset + Offsets.SSIV] = Convert.ToByte(textBoxSPDIV.Text + textBoxSPCIV.Text, 2);

            string temp2 = ToBinary(int.Parse(textBoxPPU1.Text)).PadLeft(2, '0') + ToBinary(int.Parse(textBoxPPR1.Text)).PadLeft(6, '0');
            save.data[pkmnoffset + Offsets.PP1] = Convert.ToByte(temp2, 2);
            temp2 = ToBinary(int.Parse(textBoxPPU2.Text)).PadLeft(2, '0') + ToBinary(int.Parse(textBoxPPR2.Text)).PadLeft(6, '0');
            save.data[pkmnoffset + Offsets.PP2] = Convert.ToByte(temp2, 2);
            temp2 = ToBinary(int.Parse(textBoxPPU3.Text)).PadLeft(2, '0') + ToBinary(int.Parse(textBoxPPR3.Text)).PadLeft(6, '0');
            save.data[pkmnoffset + Offsets.PP3] = Convert.ToByte(temp2, 2);
            temp2 = ToBinary(int.Parse(textBoxPPU4.Text)).PadLeft(2, '0') + ToBinary(int.Parse(textBoxPPR4.Text)).PadLeft(6, '0');
            save.data[pkmnoffset + Offsets.PP4] = Convert.ToByte(temp2, 2);

            //save.data[pkmnoffset + Offsets.LVL1] = byte.Parse(textBox12.Text);

            if (isParty)
            {
                save.data[pkmnoffset + Offsets.LVL2] = byte.Parse(textBox12.Text);

                temp = BitConverter.GetBytes(ushort.Parse(textBoxHP.Text));
                save.data[pkmnoffset + Offsets.HP] = temp[1];
                save.data[pkmnoffset + Offsets.HP + 1] = temp[0];
                temp = BitConverter.GetBytes(ushort.Parse(textBoxATT.Text));
                save.data[pkmnoffset + Offsets.ATT] = temp[1];
                save.data[pkmnoffset + Offsets.ATT + 1] = temp[0];
                temp = BitConverter.GetBytes(ushort.Parse(textBoxDEF.Text));
                save.data[pkmnoffset + Offsets.DEF] = temp[1];
                save.data[pkmnoffset + Offsets.DEF + 1] = temp[0];
                temp = BitConverter.GetBytes(ushort.Parse(textBoxSPD.Text));
                save.data[pkmnoffset + Offsets.SPD] = temp[1];
                save.data[pkmnoffset + Offsets.SPD + 1] = temp[0];
                temp = BitConverter.GetBytes(ushort.Parse(textBoxSPC.Text));
                save.data[pkmnoffset + Offsets.SPC] = temp[1];
                save.data[pkmnoffset + Offsets.SPC + 1] = temp[0];

                switch (pkmnnr)
                {
                    case 1:
                        Conv.stringToPString(textBox2.Text, Offsets.PartyPokemon1Trainer, textBox2.Text.Length + 1);
                        Conv.stringToPString(textBox3.Text, Offsets.PartyPokemon1Nick, 11);
                        break;
                    case 2:
                        Conv.stringToPString(textBox2.Text, Offsets.PartyPokemon2Trainer, textBox2.Text.Length + 1);
                        Conv.stringToPString(textBox3.Text, Offsets.PartyPokemon2Nick, 11);
                        break;
                    case 3:
                        Conv.stringToPString(textBox2.Text, Offsets.PartyPokemon3Trainer, textBox2.Text.Length + 1);
                        Conv.stringToPString(textBox3.Text, Offsets.PartyPokemon3Nick, 11);
                        break;
                    case 4:
                        Conv.stringToPString(textBox2.Text, Offsets.PartyPokemon4Trainer, textBox2.Text.Length + 1);
                        Conv.stringToPString(textBox3.Text, Offsets.PartyPokemon4Nick, 11);
                        break;
                    case 5:
                        Conv.stringToPString(textBox2.Text, Offsets.PartyPokemon5Trainer, textBox2.Text.Length + 1);
                        Conv.stringToPString(textBox3.Text, Offsets.PartyPokemon5Nick, 11);
                        break;
                    case 6:
                        Conv.stringToPString(textBox2.Text, Offsets.PartyPokemon6Trainer, textBox2.Text.Length + 1);
                        Conv.stringToPString(textBox3.Text, Offsets.PartyPokemon6Nick, 11);
                        break;
                }

                if (save.data[Offsets.PartyHeader] < pkmnnr)
                {
                    save.data[Offsets.PartyHeader] = (byte)pkmnnr;
                }
                save.data[Offsets.PartyHeader + pkmnnr] = (byte)Enum.Parse(typeof(Pokemon), comboBox1.Text).GetHashCode();
                save.data[Offsets.PartyHeader + pkmnnr + 1] = 0xFF;
            }

            parent.updateData();
            this.Close();
        }
    }
}

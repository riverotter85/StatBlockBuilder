using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatBlockBuilder
{
    public partial class StatBlockForm : Form
    {
        public StatBlockForm()
        {
            InitializeComponent();

            nameBox.Text = "Creature Name";
            nameBox.ForeColor = Color.Gray;
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            this.nameBox.Enter += new System.EventHandler(this.nameBox_Enter);

            armorTypeBox.Text = "Armor Type";
            armorTypeBox.ForeColor = Color.Gray;
            this.armorTypeBox.Leave += new System.EventHandler(this.armorTypeBox_Leave);
            this.armorTypeBox.Enter += new System.EventHandler(this.armorTypeBox_Enter);

            sizeBox.Text = "Medium";
            typeBox.Text = "Humanoid";
            alignmentBox.Text = "Unaligned";

            crBox.Text = "0";

            tmTypeBox.Text = "Immunities";
            pbBox.Text = "+2";
            spellAttrBox.Text = "Intelligence";
        }

        private void nameBox_Leave(object sender, EventArgs e)
        {
            if (nameBox.Text == "")
            {
                nameBox.Text = "Creature Name";
                nameBox.ForeColor = Color.Gray;
            }
        }

        private void nameBox_Enter(object sender, EventArgs e)
        {
            if (nameBox.Text == "Creature Name")
            {
                nameBox.Text = "";
                nameBox.ForeColor = Color.Black;
            }
        }

        private void armorTypeBox_Leave(object sender, EventArgs e)
        {
            if (armorTypeBox.Text == "")
            {
                armorTypeBox.Text = "Armor Type";
                armorTypeBox.ForeColor = Color.Gray;
            }
        }

        private void armorTypeBox_Enter(object sender, EventArgs e)
        {
            if (armorTypeBox.Text == "Armor Type")
            {
                armorTypeBox.Text = "";
                armorTypeBox.ForeColor = Color.Black;
            }
        }

        private void sizeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (sizeBox.Text)
            {
                case "Tiny":
                    hitDieTypeLabel.Text = "d4";
                    break;
                case "Small":
                    hitDieTypeLabel.Text = "d6";
                    break;
                case "Medium":
                    hitDieTypeLabel.Text = "d8";
                    break;
                case "Large":
                    hitDieTypeLabel.Text = "d10";
                    break;
                case "Huge":
                    hitDieTypeLabel.Text = "d12";
                    break;
                case "Gargantuan":
                    hitDieTypeLabel.Text = "d20";
                    break;
            }
        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //stuff
        }

        private string attrToMod(decimal attr)
        {
            string str;
            int modVal = (int) Math.Floor((attr - 10) / (decimal) 2);
            if (modVal >= 0)
            {
                str = "(+" + modVal + ")";
            }
            else
            {
                str = "(" + modVal + ")";
            }

            return str;
        }

        private void strAttrBox_ValueChanged(object sender, EventArgs e)
        {
            strModLabel.Text = attrToMod(strAttrBox.Value);
        }

        private void dexAttrBox_ValueChanged(object sender, EventArgs e)
        {
            dexModLabel.Text = attrToMod(dexAttrBox.Value);
        }

        private void conAttrBox_ValueChanged(object sender, EventArgs e)
        {
            conModLabel.Text = attrToMod(conAttrBox.Value);
        }

        private void intAttrBox_ValueChanged(object sender, EventArgs e)
        {
            intModLabel.Text = attrToMod(intAttrBox.Value);
        }

        private void wisAttrBox_ValueChanged(object sender, EventArgs e)
        {
            wisModLabel.Text = attrToMod(wisAttrBox.Value);
        }

        private void chaAttrBox_ValueChanged(object sender, EventArgs e)
        {
            chaModLabel.Text = attrToMod(chaAttrBox.Value);
        }
    }
}

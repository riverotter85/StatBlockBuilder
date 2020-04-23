using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;

namespace StatBlockBuilder
{
    public partial class StatBlockForm : Form
    {
        private bool[][] toughnessMods = new bool[][]
        {
            new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false }, // Immunities
            new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false }, // Resistances
            new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false }  // Vulnerabilities
        };
        private int prev = 0;

        public StatBlockForm()
        {
            InitializeComponent();

            nameBox.Text = "Creature Name";
            nameBox.ForeColor = Color.Gray;
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            this.nameBox.Enter += new System.EventHandler(this.nameBox_Enter);

            raceTypeBox.Text = "Race (optional)";
            raceTypeBox.ForeColor = Color.Gray;
            this.raceTypeBox.Leave += new System.EventHandler(this.raceTypeBox_Leave);
            this.raceTypeBox.Enter += new System.EventHandler(this.raceTypeBox_Enter);

            armorTypeBox.Text = "Natural Armor";
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

            saLabel.ForeColor = Color.Gray;
            spellSaveDcLabel.ForeColor = Color.Gray;
            spellAttackLabel.ForeColor = Color.Gray;
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

        private void raceTypeBox_Leave(object sender, EventArgs e)
        {
            if (raceTypeBox.Text == "")
            {
                raceTypeBox.Text = "Race (optional)";
                raceTypeBox.ForeColor = Color.Gray;
            }
        }

        private void raceTypeBox_Enter(object sender, EventArgs e)
        {
            if (raceTypeBox.Text == "Race (optional)")
            {
                raceTypeBox.Text = "";
                raceTypeBox.ForeColor = Color.Black;
            }
        }

        private void armorTypeBox_Leave(object sender, EventArgs e)
        {
            if (armorTypeBox.Text == "")
            {
                armorTypeBox.Text = "Natural Armor";
                armorTypeBox.ForeColor = Color.Gray;
            }
        }

        private void armorTypeBox_Enter(object sender, EventArgs e)
        {
            if (armorTypeBox.Text == "Natural Armor")
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
            calculateHitPoints();
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

        private void calculateHitPoints()
        {
            int numHitDice = (int) numHitDiceBox.Value;
            int hitDieTypeVal = int.Parse(hitDieTypeLabel.Text.Trim('d'));
            int conModVal = int.Parse(conModLabel.Text.Trim(new Char[] { '(', ')', '+' }));

            decimal average = (decimal) Math.Floor(numHitDice * (hitDieTypeVal / 2.0 + 0.5)) + conModVal;
            hitPointsBox.Value = average;
        }

        private void calculateSpellAttackAndSaveDc()
        {
            int proficiencyBonus;
            if (manualPbCheckbox.Checked == true)
            {
                proficiencyBonus = int.Parse(pbBox.Text.Trim(new Char[] { '(', ')', '+' }));
            }
            else
            {
                proficiencyBonus = int.Parse(pbValLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            }

            int attrModVal = 0;
            switch (spellAttrBox.Text)
            {
                case "Strength":
                    attrModVal = int.Parse(strModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
                    break;
                case "Dexterity":
                    attrModVal = int.Parse(dexModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
                    break;
                case "Constitution":
                    attrModVal = int.Parse(conModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
                    break;
                case "Intelligence":
                    attrModVal = int.Parse(intModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
                    break;
                case "Wisdom":
                    attrModVal = int.Parse(wisModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
                    break;
                case "Charisma":
                    attrModVal = int.Parse(chaModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
                    break;
            }

            int spellSaveDc = 8 + proficiencyBonus + attrModVal;
            int spellAttack = proficiencyBonus + attrModVal;
            spellSaveDcLabel.Text = "Spell Save DC (" + spellSaveDc + ")";
            if (spellAttack >= 0)
            {
                spellAttackLabel.Text = "Spell Attack (+" + spellAttack + ")";
            }
            else
            {
                spellAttackLabel.Text = "Spell Attack (" + spellAttack + ")";
            }
        }

        private void strAttrBox_ValueChanged(object sender, EventArgs e)
        {
            strModLabel.Text = attrToMod(strAttrBox.Value);
            if (spellAttrBox.Text == "Strength")
            {
                calculateSpellAttackAndSaveDc();
            }
        }

        private void dexAttrBox_ValueChanged(object sender, EventArgs e)
        {
            dexModLabel.Text = attrToMod(dexAttrBox.Value);
            if (spellAttrBox.Text == "Dexterity")
            {
                calculateSpellAttackAndSaveDc();
            }
        }

        private void conAttrBox_ValueChanged(object sender, EventArgs e)
        {
            conModLabel.Text = attrToMod(conAttrBox.Value);
            calculateHitPoints();
            if (spellAttrBox.Text == "Constitution")
            {
                calculateSpellAttackAndSaveDc();
            }
        }

        private void intAttrBox_ValueChanged(object sender, EventArgs e)
        {
            intModLabel.Text = attrToMod(intAttrBox.Value);
            if (spellAttrBox.Text == "Intelligence")
            {
                calculateSpellAttackAndSaveDc();
            }
        }

        private void wisAttrBox_ValueChanged(object sender, EventArgs e)
        {
            wisModLabel.Text = attrToMod(wisAttrBox.Value);
            if (spellAttrBox.Text == "Wisdom")
            {
                calculateSpellAttackAndSaveDc();
            }
        }

        private void chaAttrBox_ValueChanged(object sender, EventArgs e)
        {
            chaModLabel.Text = attrToMod(chaAttrBox.Value);
            if (spellAttrBox.Text == "Charisma")
            {
                calculateSpellAttackAndSaveDc();
            }
        }

        private void crBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (crBox.Text)
            {
                case "0":
                    pbValLabel.Text = "(+2)";
                    xpValueLabel.Text = "(10 XP)";
                    break;
                case "1/8":
                    pbValLabel.Text = "(+2)";
                    xpValueLabel.Text = "(25 XP)";
                    break;
                case "1/4":
                    pbValLabel.Text = "(+2)";
                    xpValueLabel.Text = "(50 XP)";
                    break;
                case "1/2":
                    pbValLabel.Text = "(+2)";
                    xpValueLabel.Text = "(100 XP)";
                    break;
                case "1":
                    pbValLabel.Text = "(+2)";
                    xpValueLabel.Text = "(200 XP)";
                    break;
                case "2":
                    pbValLabel.Text = "(+2)";
                    xpValueLabel.Text = "(450 XP)";
                    break;
                case "3":
                    pbValLabel.Text = "(+2)";
                    xpValueLabel.Text = "(700 XP)";
                    break;
                case "4":
                    pbValLabel.Text = "(+2)";
                    xpValueLabel.Text = "(1,100 XP)";
                    break;
                case "5":
                    pbValLabel.Text = "(+3)";
                    xpValueLabel.Text = "(1,800 XP)";
                    break;
                case "6":
                    pbValLabel.Text = "(+3)";
                    xpValueLabel.Text = "(2,300 XP)";
                    break;
                case "7":
                    pbValLabel.Text = "(+3)";
                    xpValueLabel.Text = "(2,900 XP)";
                    break;
                case "8":
                    pbValLabel.Text = "(+3)";
                    xpValueLabel.Text = "(3,900 XP)";
                    break;
                case "9":
                    pbValLabel.Text = "(+4)";
                    xpValueLabel.Text = "(5,000 XP)";
                    break;
                case "10":
                    pbValLabel.Text = "(+4)";
                    xpValueLabel.Text = "(5,900 XP)";
                    break;
                case "11":
                    pbValLabel.Text = "(+4)";
                    xpValueLabel.Text = "(7,200 XP)";
                    break;
                case "12":
                    pbValLabel.Text = "(+4)";
                    xpValueLabel.Text = "(8,400 XP)";
                    break;
                case "13":
                    pbValLabel.Text = "(+5)";
                    xpValueLabel.Text = "(10,000 XP)";
                    break;
                case "14":
                    pbValLabel.Text = "(+5)";
                    xpValueLabel.Text = "(11,500 XP)";
                    break;
                case "15":
                    pbValLabel.Text = "(+5)";
                    xpValueLabel.Text = "(13,000 XP)";
                    break;
                case "16":
                    pbValLabel.Text = "(+5)";
                    xpValueLabel.Text = "(15,000 XP)";
                    break;
                case "17":
                    pbValLabel.Text = "(+6)";
                    xpValueLabel.Text = "(18,000 XP)";
                    break;
                case "18":
                    pbValLabel.Text = "(+6)";
                    xpValueLabel.Text = "(20,000 XP)";
                    break;
                case "19":
                    pbValLabel.Text = "(+6)";
                    xpValueLabel.Text = "(22,000 XP)";
                    break;
                case "20":
                    pbValLabel.Text = "(+6)";
                    xpValueLabel.Text = "(25,000 XP)";
                    break;
                case "21":
                    pbValLabel.Text = "(+7)";
                    xpValueLabel.Text = "(33,000 XP)";
                    break;
                case "22":
                    pbValLabel.Text = "(+7)";
                    xpValueLabel.Text = "(41,000 XP)";
                    break;
                case "23":
                    pbValLabel.Text = "(+7)";
                    xpValueLabel.Text = "(50,000 XP)";
                    break;
                case "24":
                    pbValLabel.Text = "(+7)";
                    xpValueLabel.Text = "(62,000 XP)";
                    break;
                case "25":
                    pbValLabel.Text = "(+8)";
                    xpValueLabel.Text = "(75,000 XP)";
                    break;
                case "26":
                    pbValLabel.Text = "(+8)";
                    xpValueLabel.Text = "(90,000 XP)";
                    break;
                case "27":
                    pbValLabel.Text = "(+8)";
                    xpValueLabel.Text = "(100,000 XP)";
                    break;
                case "28":
                    pbValLabel.Text = "(+8)";
                    xpValueLabel.Text = "(120,000 XP)";
                    break;
                case "29":
                    pbValLabel.Text = "(+9)";
                    xpValueLabel.Text = "(135,000 XP)";
                    break;
                case "30":
                    pbValLabel.Text = "(+9)";
                    xpValueLabel.Text = "(155,000 XP)";
                    break;
            }

            calculateSpellAttackAndSaveDc();
        }

        private void armorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (armorCheckBox.Checked == true)
            {
                armorTypeBox.Enabled = true;
            }
            else
            {
                armorTypeBox.Text = "Natural Armor";
                armorTypeBox.ForeColor = Color.Gray;
                armorTypeBox.Enabled = false;
            }
        }

        private void manualPbCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (manualPbCheckbox.Checked == true)
            {
                pbBox.Enabled = true;
            }
            else
            {
                pbBox.Enabled = false;
            }

            calculateSpellAttackAndSaveDc();
        }

        private void spellcasterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (spellcasterCheckBox.Checked == true)
            {
                saLabel.ForeColor = Color.Black;
                spellAttrBox.Enabled = true;
                spellsListView.Enabled = true;
                editSpellsButton.Enabled = true;
                spellSaveDcLabel.ForeColor = Color.Black;
                spellAttackLabel.ForeColor = Color.Black;
            }
            else
            {
                saLabel.ForeColor = Color.Gray;
                spellAttrBox.Enabled = false;
                spellsListView.Enabled = false;
                editSpellsButton.Enabled = false;
                spellSaveDcLabel.ForeColor = Color.Gray;
                spellAttackLabel.ForeColor = Color.Gray;
            }
        }

        private void numHitDiceBox_ValueChanged(object sender, EventArgs e)
        {
            calculateHitPoints();
        }

        private void tmTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 13; i++)
            {
                toughnessMods[prev][i] = damageTypeListBox.GetItemChecked(i);
            }

            prev = tmTypeBox.SelectedIndex;
            for (int i = 0; i < 13; i++)
            {
                damageTypeListBox.SetItemChecked(i, toughnessMods[prev][i]);
            }
        }

        private void pbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateSpellAttackAndSaveDc();
        }

        private void spellAttrBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateSpellAttackAndSaveDc();
        }
    }
}

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
        private EditSpellsForm esf = new EditSpellsForm();

        // Store settings when switching between toughness mod menus
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

            // Name Text Box
            nameBox.Text = "Creature Name";
            nameBox.ForeColor = Color.Gray;
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            this.nameBox.Enter += new System.EventHandler(this.nameBox_Enter);

            // Race Text Box
            raceTypeBox.Text = "Race (optional)";
            raceTypeBox.ForeColor = Color.Gray;
            this.raceTypeBox.Leave += new System.EventHandler(this.raceTypeBox_Leave);
            this.raceTypeBox.Enter += new System.EventHandler(this.raceTypeBox_Enter);

            // Natural Armor Text Box
            armorTypeBox.Text = "Natural Armor";
            armorTypeBox.ForeColor = Color.Gray;
            this.armorTypeBox.Leave += new System.EventHandler(this.armorTypeBox_Leave);
            this.armorTypeBox.Enter += new System.EventHandler(this.armorTypeBox_Enter);

            sizeBox.Text = "Medium";
            typeBox.Text = "Humanoid";
            alignmentBox.Text = "Unaligned";
            hpCalcBox.Text = "Average";

            crBox.Text = "0";

            tmTypeBox.Text = "Resistances";
            pbBox.Text = "+2";
            spellAttrBox.Text = "Intelligence";

            // Visually display that the spellcasting feature is disabled by default
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
            // Set hit die type based on the size picked
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

        // Derives the modifier value (in string form) from the given attribute
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
            if (hpCalcBox.Text == "Custom")
            {
                return;
            }

            int numHitDice = (int) numHitDiceBox.Value;
            int hitDieTypeVal = int.Parse(hitDieTypeLabel.Text.Trim('d'));
            int conModVal = int.Parse(conModLabel.Text.Trim(new Char[] { '(', ')', '+' }));

            // Depending on what is chosen, calculate the creature's total hit points differently
            decimal hpVal = (decimal) 0.0;
            switch (hpCalcBox.Text)
            {
                case "Average":
                    hpVal = (decimal) (hitDieTypeVal / 2.0 + 0.5);
                    break;
                case "Max":
                    hpVal = hitDieTypeVal;
                    break;
                case "Min":
                    hpVal = 1;
                    break;
            }

            // Determine the final hit point value
            decimal average = (decimal) Math.Floor(numHitDice * (hpVal + conModVal));
            hitPointsBox.Value = average;
        }

        private int getProficiencyBonus()
        {
            int proficiencyBonus;
            // Get custom proficiency bonus value
            if (manualPbCheckbox.Checked == true)
            {
                proficiencyBonus = int.Parse(pbBox.Text.Trim(new Char[] { '(', ')', '+' }));
            }
            // Otherwise, go with value derived from creature's challenge rating
            else
            {
                proficiencyBonus = int.Parse(pbValLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            }

            return proficiencyBonus;
        }

        private void calculateSpellAttackAndSaveDc()
        {
            int proficiencyBonus = getProficiencyBonus();

            // Derive the spellcasting modifier based on the chosen attribute
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

            // Calculate the final spell save DC and spell attack bonus values in string form
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

        // Modify all saves and skills tied to Strength
        private void strAttrBox_ValueChanged(object sender, EventArgs e)
        {
            strModLabel.Text = attrToMod(strAttrBox.Value);

            int strMod = int.Parse(strModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();

            setSkillOrSave(strCheckbox, "Strength", strMod, profMod);
            setSkillOrSave(athleticsCheckbox, "Athletics", strMod, profMod);

            if (spellAttrBox.Text == "Strength")
            {
                calculateSpellAttackAndSaveDc();
            }
        }

        // Modify all saves and skills tied to Dexterity
        private void dexAttrBox_ValueChanged(object sender, EventArgs e)
        {
            dexModLabel.Text = attrToMod(dexAttrBox.Value);

            int dexMod = int.Parse(dexModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();

            setSkillOrSave(dexCheckbox, "Dexterity", dexMod, profMod);
            setSkillOrSave(acrobaticsCheckbox, "Acrobatics", dexMod, profMod);
            setSkillOrSave(sohCheckbox, "Sleight of Hand", dexMod, profMod);
            setSkillOrSave(stealthCheckbox, "Stealth", dexMod, profMod);

            calculateBaseArmorClass();

            if (spellAttrBox.Text == "Dexterity")
            {
                calculateSpellAttackAndSaveDc();
            }
        }

        // Modify all saves and skills tied to Constitution
        private void conAttrBox_ValueChanged(object sender, EventArgs e)
        {
            conModLabel.Text = attrToMod(conAttrBox.Value);
            calculateHitPoints();

            int conMod = int.Parse(conModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();

            setSkillOrSave(conCheckbox, "Constitution", conMod, profMod);

            if (spellAttrBox.Text == "Constitution")
            {
                calculateSpellAttackAndSaveDc();
            }
        }

        // Modify all saves and skills tied to Intelligence
        private void intAttrBox_ValueChanged(object sender, EventArgs e)
        {
            intModLabel.Text = attrToMod(intAttrBox.Value);

            int intMod = int.Parse(intModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();

            setSkillOrSave(intCheckbox, "Intelligence", intMod, profMod);
            setSkillOrSave(arcanaCheckbox, "Arcana", intMod, profMod);
            setSkillOrSave(historyCheckbox, "History", intMod, profMod);
            setSkillOrSave(investigationCheckbox, "Investigation", intMod, profMod);
            setSkillOrSave(natureCheckbox, "Nature", intMod, profMod);
            setSkillOrSave(religionCheckbox, "Religion", intMod, profMod);

            if (spellAttrBox.Text == "Intelligence")
            {
                calculateSpellAttackAndSaveDc();
            }
        }

        // Modify all saves and skills tied to Wisdom
        private void wisAttrBox_ValueChanged(object sender, EventArgs e)
        {
            wisModLabel.Text = attrToMod(wisAttrBox.Value);

            int wisMod = int.Parse(wisModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();

            setSkillOrSave(wisCheckbox, "Wisdom", wisMod, profMod);
            setSkillOrSave(ahCheckbox, "Animal Handling", wisMod, profMod);
            setSkillOrSave(insightCheckbox, "Insight", wisMod, profMod);
            setSkillOrSave(medicineCheckbox, "Medicine", wisMod, profMod);
            setSkillOrSave(perceptionCheckbox, "Perception", wisMod, profMod);
            setSkillOrSave(survivalCheckbox, "Survival", wisMod, profMod);

            if (spellAttrBox.Text == "Wisdom")
            {
                calculateSpellAttackAndSaveDc();
            }
        }

        // Modify all saves and skills tied to Charisma
        private void chaAttrBox_ValueChanged(object sender, EventArgs e)
        {
            chaModLabel.Text = attrToMod(chaAttrBox.Value);

            int chaMod = int.Parse(chaModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();

            setSkillOrSave(chaCheckbox, "Charisma", chaMod, profMod);
            setSkillOrSave(deceptionCheckbox, "Deception", chaMod, profMod);
            setSkillOrSave(intimidationCheckbox, "Intimidation", chaMod, profMod);
            setSkillOrSave(performanceCheckbox, "Performance", chaMod, profMod);
            setSkillOrSave(persuasionCheckbox, "Persuasion", chaMod, profMod);

            if (spellAttrBox.Text == "Charisma")
            {
                calculateSpellAttackAndSaveDc();
            }
        }

        private void crBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Derive proficiency bonus and XP amount by chosen challenge rating
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

            calculateSavesAndSkills();
            calculateSpellAttackAndSaveDc();
        }

        private void manualPbCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // Allow manual proficiency bonus to be changed if the manual checkbox is checked
            if (manualPbCheckbox.Checked == true)
            {
                pbBox.Enabled = true;
            }
            else
            {
                pbBox.Enabled = false;
            }

            calculateSavesAndSkills();
            calculateSpellAttackAndSaveDc();
        }

        private void spellcasterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Change spellcasting visuals and allow boxes to be changed if spellcaster box is checked
            if (spellcasterCheckBox.Checked == true)
            {
                saLabel.ForeColor = Color.Black;
                spellAttrBox.Enabled = true;
                spellsListView.Enabled = true;
                editSpellsButton.Enabled = true;
                spellSaveDcLabel.ForeColor = Color.Black;
                spellAttackLabel.ForeColor = Color.Black;
            }
            // ...And vice-versa
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
            // Store current toughness mod settings
            for (int i = 0; i < 13; i++)
            {
                toughnessMods[prev][i] = damageTypeListBox.GetItemChecked(i);
            }

            // Allow access to toughness mod being switched to
            prev = tmTypeBox.SelectedIndex;
            for (int i = 0; i < 13; i++)
            {
                damageTypeListBox.SetItemChecked(i, toughnessMods[prev][i]);
            }
        }

        private void pbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateSavesAndSkills();
            calculateSpellAttackAndSaveDc();
        }

        private void spellAttrBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateSpellAttackAndSaveDc();
        }

        private void hpCalcBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Disable hit dice and automatic hit point calculations if 'Custom'
            if (hpCalcBox.Text == "Custom")
            {
                hitDiceLabel.ForeColor = Color.Gray;
                numHitDiceBox.Enabled = false;
                hitDieTypeLabel.ForeColor = Color.Gray;
            }
            else
            {
                hitDiceLabel.ForeColor = Color.Black;
                numHitDiceBox.Enabled = true;
                hitDieTypeLabel.ForeColor = Color.Black;
            }

            calculateHitPoints();
        }

        private void calculateBaseArmorClass()
        {
            // Let user manually change armor class if checked, no need to change their settings
            if (armorCheckBox.Checked == true)
            {
                return;
            }

            // Otherwise, use default AC value of 10 + DEX_MOD
            int dexMod = int.Parse(dexModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            armorClassBox.Value = 10 + dexMod;
        }

        private void armorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // If using armor, allow the user to specify what kind of armor
            // the creature is wearing
            if (armorCheckBox.Checked == true)
            {
                armorTypeBox.Enabled = true;
            }
            else
            {
                armorTypeBox.Enabled = false;
            }
            calculateBaseArmorClass();
        }

        private void setSkillOrSave(CheckBox checkBox, string sName, int modVal, int profMod)
        {
            int totalMod = modVal;
            if (checkBox.Checked == true) // Add proficiency bonus if proficient with skills or save
            {
                totalMod += profMod;
            }

            // Set string value of skill or save
            string str = sName;
            if (totalMod >= 0)
            {
                str += " (+" + totalMod + ")";
            }
            else
            {
                str += " (" + totalMod + ")";
            }
            checkBox.Text = str;
        }

        private void calculateSavesAndSkills()
        {
            int strMod = int.Parse(strModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int dexMod = int.Parse(dexModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int conMod = int.Parse(conModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int intMod = int.Parse(intModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int wisMod = int.Parse(wisModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int chaMod = int.Parse(chaModLabel.Text.Trim(new Char[] { '(', ')', '+' }));

            int profMod = getProficiencyBonus();

            // Update all saving throws
            setSkillOrSave(strCheckbox, "Strength", strMod, profMod);
            setSkillOrSave(dexCheckbox, "Dexterity", dexMod, profMod);
            setSkillOrSave(conCheckbox, "Constitution", conMod, profMod);
            setSkillOrSave(intCheckbox, "Intelligence", intMod, profMod);
            setSkillOrSave(wisCheckbox, "Wisdom", wisMod, profMod);
            setSkillOrSave(chaCheckbox, "Charisma", chaMod, profMod);

            // Update strength-based skills
            setSkillOrSave(athleticsCheckbox, "Athletics", strMod, profMod);

            // Update dexterity-based skills
            setSkillOrSave(acrobaticsCheckbox, "Acrobatics", dexMod, profMod);
            setSkillOrSave(sohCheckbox, "Sleight of Hand", dexMod, profMod);
            setSkillOrSave(stealthCheckbox, "Stealth", dexMod, profMod);

            // Update intelligence-based skills
            setSkillOrSave(arcanaCheckbox, "Arcana", intMod, profMod);
            setSkillOrSave(historyCheckbox, "History", intMod, profMod);
            setSkillOrSave(investigationCheckbox, "Investigation", intMod, profMod);
            setSkillOrSave(natureCheckbox, "Nature", intMod, profMod);
            setSkillOrSave(religionCheckbox, "Religion", intMod, profMod);

            // Update wisdom-based skills
            setSkillOrSave(ahCheckbox, "Animal Handling", wisMod, profMod);
            setSkillOrSave(insightCheckbox, "Insight", wisMod, profMod);
            setSkillOrSave(medicineCheckbox, "Medicine", wisMod, profMod);
            setSkillOrSave(perceptionCheckbox, "Perception", wisMod, profMod);
            setSkillOrSave(survivalCheckbox, "Survival", wisMod, profMod);

            // Update charisma-based skills
            setSkillOrSave(deceptionCheckbox, "Deception", chaMod, profMod);
            setSkillOrSave(intimidationCheckbox, "Intimidation", chaMod, profMod);
            setSkillOrSave(performanceCheckbox, "Performance", chaMod, profMod);
            setSkillOrSave(persuasionCheckbox, "Persuasion", chaMod, profMod);
        }

        private void strCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // Update Strength saving throw
            int strMod = int.Parse(strModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();
            setSkillOrSave(strCheckbox, "Strength", strMod, profMod);
        }

        private void dexCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // Update Dexterity saving throw
            int dexMod = int.Parse(dexModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();
            setSkillOrSave(dexCheckbox, "Dexterity", dexMod, profMod);
        }

        private void conCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // Update Constitution saving throw
            int conMod = int.Parse(conModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();
            setSkillOrSave(conCheckbox, "Constitution", conMod, profMod);
        }

        private void intCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // Update Intelligence saving throw
            int intMod = int.Parse(intModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();
            setSkillOrSave(intCheckbox, "Intelligence", intMod, profMod);
        }

        private void wisCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // Update Wisdom saving throw
            int wisMod = int.Parse(wisModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();
            setSkillOrSave(wisCheckbox, "Wisdom", wisMod, profMod);
        }

        private void chaCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // Update Charisma saving throw
            int chaMod = int.Parse(chaModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();
            setSkillOrSave(chaCheckbox, "Charisma", chaMod, profMod);
        }

        private void acrobaticsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            int dexMod = int.Parse(dexModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();
            setSkillOrSave(acrobaticsCheckbox, "Acrobatics", dexMod, profMod);
        }

        private void ahCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            int wisMod = int.Parse(wisModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();
            setSkillOrSave(ahCheckbox, "Animal Handling", wisMod, profMod);
        }

        private void arcanaCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            int intMod = int.Parse(intModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();
            setSkillOrSave(arcanaCheckbox, "Arcana", intMod, profMod);
        }

        private void athleticsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            int strMod = int.Parse(strModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();
            setSkillOrSave(athleticsCheckbox, "Athletics", strMod, profMod);
        }

        private void deceptionCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            int chaMod = int.Parse(chaModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();
            setSkillOrSave(deceptionCheckbox, "Deception", chaMod, profMod);
        }

        private void historyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            int intMod = int.Parse(intModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();
            setSkillOrSave(historyCheckbox, "History", intMod, profMod);
        }

        private void insightCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            int wisMod = int.Parse(wisModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();
            setSkillOrSave(insightCheckbox, "Insight", wisMod, profMod);
        }

        private void intimidationCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            int chaMod = int.Parse(chaModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();
            setSkillOrSave(intimidationCheckbox, "Intimidation", chaMod, profMod);
        }

        private void investigationCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            int intMod = int.Parse(intModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();
            setSkillOrSave(investigationCheckbox, "Investigation", intMod, profMod);
        }

        private void medicineCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            int wisMod = int.Parse(wisModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();
            setSkillOrSave(medicineCheckbox, "Medicine", wisMod, profMod);
        }

        private void natureCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            int intMod = int.Parse(intModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();
            setSkillOrSave(natureCheckbox, "Nature", intMod, profMod);
        }

        private void perceptionCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            int wisMod = int.Parse(wisModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();
            setSkillOrSave(perceptionCheckbox, "Perception", wisMod, profMod);
        }

        private void performanceCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            int chaMod = int.Parse(chaModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();
            setSkillOrSave(performanceCheckbox, "Performance", chaMod, profMod);
        }

        private void persuasionCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            int chaMod = int.Parse(chaModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();
            setSkillOrSave(persuasionCheckbox, "Persuasion", chaMod, profMod);
        }

        private void religionCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            int intMod = int.Parse(intModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();
            setSkillOrSave(religionCheckbox, "Religion", intMod, profMod);
        }

        private void sohCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            int dexMod = int.Parse(dexModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();
            setSkillOrSave(sohCheckbox, "Sleight of Hand", dexMod, profMod);
        }

        private void stealthCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            int dexMod = int.Parse(dexModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();
            setSkillOrSave(stealthCheckbox, "Stealth", dexMod, profMod);
        }

        private void survivalCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            int wisMod = int.Parse(wisModLabel.Text.Trim(new Char[] { '(', ')', '+' }));
            int profMod = getProficiencyBonus();
            setSkillOrSave(survivalCheckbox, "Survival", wisMod, profMod);
        }

        private void editSpellsButton_Click(object sender, EventArgs e)
        {
            if (esf.IsDisposed == true) // Create new form if opened and closed before
            {
                esf = new EditSpellsForm();
            }
            esf.ShowDialog();
        }
    }
}

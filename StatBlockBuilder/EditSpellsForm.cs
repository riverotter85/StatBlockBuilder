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
    public partial class EditSpellsForm : Form
    {
        private class Spell
        {
            public string name;

            public string components;
            public string componentsDescription;

            public string level;
            public string type;
            public bool ritual;

            public string range;

            public string castingTime;
            public string castingTimeComments;

            public string duration;

            public string description;

            public Spell(EditSpellsForm f)
            {
                name = f.spellNameBox.Text;

                int componentsCount = 0;
                components = "";
                if (f.somaticCheckBox.Checked == true)
                {
                    components += "S";
                    componentsCount++;
                }
                if (f.verbalCheckBox.Checked == true)
                {
                    if (componentsCount != 0)
                    {
                        components += ", ";
                    }
                    components += "V";
                    componentsCount++;
                }
                if (f.materialCheckBox.Checked == true)
                {
                    if (componentsCount != 0)
                    {
                        components += ", ";
                    }
                    components += "M";
                }
                componentsDescription = f.materialComponentsBox.Text;

                level = f.spellLevelBox.Text;
                type = f.spellTypeBox.Text;
                ritual = f.ritualCheckBox.Checked;

                int distance = (int) f.distanceBox.Value;
                string distanceUnit = f.distanceUnitBox.Text;
                if (f.rangeBox.Text == "Range")
                {
                    range = distance + " " + distanceUnit;
                }
                else if (f.rangeBox.Text == "Self")
                {
                    range = "Self (" + distance + " " + distanceUnit + ")";
                }
                else
                {
                    range = f.rangeBox.Text;
                }

                int castingTimeNum = (int) f.castingTimeNumBox.Value;
                string castingTimeUnit = f.castingTimeUnitBox.Text;
                if (f.castingTimeBox.Text == "Time")
                {
                    castingTime = castingTimeNum + " " + castingTimeUnit;
                }
                else
                {
                    castingTime = f.castingTimeBox.Text;
                }

                castingTimeComments = f.commentsBox.Text;

                int durationTime = (int) f.durationNumBox.Value;
                string durationUnit = f.durationUnitBox.Text;
                if (f.durationTypeBox.Text == "Time")
                {
                    duration = durationTime + " " + durationUnit;
                }
                else if (f.durationTypeBox.Text == "Concentration")
                {
                    duration = "Concentration, up to " + durationTime + " " + durationUnit;
                }
                else
                {
                    duration = f.durationTypeBox.Text;
                }

                description = f.descriptionBox.Text;
            }
        }

        private List<Spell> addedSpellsList = new List<Spell>();
        private List<Spell> spellCollectionList = new List<Spell>();

        public EditSpellsForm()
        {
            InitializeComponent();

            spellNameBox.Text = "Spell Name";
            spellNameBox.ForeColor = Color.Gray;
            this.spellNameBox.Leave += new System.EventHandler(this.spellNameBox_Leave);
            this.spellNameBox.Enter += new System.EventHandler(this.spellNameBox_Enter);

            materialComponentsBox.Text = "Materials";
            materialComponentsBox.ForeColor = Color.Gray;
            this.materialComponentsBox.Leave += new System.EventHandler(this.materialComponentsBox_Leave);
            this.materialComponentsBox.Enter += new System.EventHandler(this.materialComponentsBox_Enter);

            commentsBox.Text = "Comments (optional)";
            commentsBox.ForeColor = Color.Gray;
            this.commentsBox.Leave += new System.EventHandler(this.commentsBox_Leave);
            this.commentsBox.Enter += new System.EventHandler(this.commentsBox_Enter);

            spellLevelBox.Text = "Cantrip";
            spellTypeBox.Text = "Abjuration";
            rangeBox.Text = "Range";
            distanceUnitBox.Text = "Feet";
            castingTimeBox.Text = "1 Action";
            castingTimeUnitBox.Text = "Minutes";
            durationTypeBox.Text = "Instantaneous";
            durationUnitBox.Text = "Minutes";
        }

        private void spellNameBox_Leave(object sender, EventArgs e)
        {
            if (spellNameBox.Text == "")
            {
                spellNameBox.Text = "Spell Name";
                spellNameBox.ForeColor = Color.Gray;
            }
        }

        private void spellNameBox_Enter(object sender, EventArgs e)
        {
            if (spellNameBox.Text == "Spell Name")
            {
                spellNameBox.Text = "";
                spellNameBox.ForeColor = Color.Black;
            }
        }

        private void materialComponentsBox_Leave(object sender, EventArgs e)
        {
            if (materialComponentsBox.Text == "")
            {
                materialComponentsBox.Text = "Materials";
                materialComponentsBox.ForeColor = Color.Gray;
            }
        }

        private void materialComponentsBox_Enter(object sender, EventArgs e)
        {
            if (materialComponentsBox.Text == "Materials")
            {
                materialComponentsBox.Text = "";
                materialComponentsBox.ForeColor = Color.Black;
            }
        }

        private void commentsBox_Leave(object sender, EventArgs e)
        {
            if (commentsBox.Text == "")
            {
                commentsBox.Text = "Comments (optional)";
                commentsBox.ForeColor = Color.Gray;
            }
        }

        private void commentsBox_Enter(object sender, EventArgs e)
        {
            if (commentsBox.Text == "Comments (optional)")
            {
                commentsBox.Text = "";
                commentsBox.ForeColor = Color.Black;
            }
        }

        private void materialCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckBox.Checked == true)
            {
                materialComponentsBox.Enabled = true;
            }
            else
            {
                materialComponentsBox.Enabled = false;
            }
        }

        private void rangeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rangeBox.Text == "Range" || rangeBox.Text == "Self")
            {
                distanceBox.Enabled = true;
                distanceUnitBox.Enabled = true;
            }
            else
            {
                distanceBox.Enabled = false;
                distanceUnitBox.Enabled = false;
            }
        }

        private void castingTimeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (castingTimeBox.Text == "Time")
            {
                castingTimeNumBox.Enabled = true;
                castingTimeUnitBox.Enabled = true;
            }
            else
            {
                castingTimeNumBox.Enabled = false;
                castingTimeUnitBox.Enabled = false;
            }
        }

        private void durationTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (durationTypeBox.Text == "Time" || durationTypeBox.Text == "Concentration")
            {
                durationNumBox.Enabled = true;
                durationUnitBox.Enabled = true;
            }
            else
            {
                durationNumBox.Enabled = false;
                durationUnitBox.Enabled = false;
            }
        }

        private Spell createNewSpell()
        {
            if (spellNameBox.Text == "" || descriptionBox.Text == "")
            {
                return null;
            }

            if (materialCheckBox.Checked == true && materialComponentsBox.Text == "")
            {
                return null;
            }

            return new Spell(this);
        }

        private void addSpellButton_Click(object sender, EventArgs e)
        {
            Spell spell = createNewSpell();
            if (spell == null)
            {
                return;
            }

            addedSpellsList.Add(spell);

            ListViewItem item = new ListViewItem(spell.level);
            item.SubItems.Add(spell.name);
            addedSpellsListView.Items.Add(item);
        }

        private void addToCollectionButton_Click(object sender, EventArgs e)
        {
            Spell spell = createNewSpell();
            if (spell == null)
            {
                return;
            }

            spellCollectionList.Add(spell);

            ListViewItem item = new ListViewItem(spell.name);
            item.SubItems.Add(spell.level);
            item.SubItems.Add(spell.castingTime);
            item.SubItems.Add(spell.range);
            item.SubItems.Add(spell.components);
            item.SubItems.Add(spell.duration);
            item.SubItems.Add(spell.description);
            spellsListView.Items.Add(item);
        }
    }
}

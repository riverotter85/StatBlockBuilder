using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Newtonsoft.Json;

namespace StatBlockBuilder
{
    public partial class EditSpellsForm : Form
    {
        public class Spell
        {
            public string name;

            public bool somaticComponents;
            public bool verbalComponents;
            public bool materialComponents;
            public string componentsDescription;
            public bool componentsDescriptionEnabled;

            public string level;
            public string type;
            public bool ritual;

            public string rangeType;
            public int distance;
            public bool distanceEnabled;
            public string distanceUnit;
            public bool distanceUnitEnabled;

            public string castingTimeType;
            public int castingTimeNum;
            public bool castingTimeNumEnabled;
            public string castingTimeUnit;
            public bool castingTimeUnitEnabled;
            public string castingTimeComments;

            public string durationType;
            public int durationTime;
            public bool durationTimeEnabled;
            public string durationUnit;
            public bool durationUnitEnabled;

            public string description;
            public string atHigherLevels;

            public Spell()
            {
                // default constructor
            }

            public Spell(EditSpellsForm f)
            {
                name = f.spellNameBox.Text;

                // Components
                somaticComponents = f.somaticCheckBox.Checked;
                verbalComponents = f.verbalCheckBox.Checked;
                materialComponents = f.materialCheckBox.Checked;
                componentsDescription = f.materialComponentsBox.Text;
                componentsDescriptionEnabled = f.materialComponentsBox.Enabled;

                level = f.spellLevelBox.Text;
                type = f.spellTypeBox.Text;
                ritual = f.ritualCheckBox.Checked;

                // Range
                rangeType = f.rangeBox.Text;
                distance = (int)f.distanceBox.Value;
                distanceEnabled = f.distanceBox.Enabled;
                distanceUnit = f.distanceUnitBox.Text;
                distanceUnitEnabled = f.distanceUnitBox.Enabled;

                // Casting Time
                castingTimeType = f.castingTimeBox.Text;
                castingTimeNum = (int)f.castingTimeNumBox.Value;
                castingTimeNumEnabled = f.castingTimeNumBox.Enabled;
                castingTimeUnit = f.castingTimeUnitBox.Text;
                castingTimeUnitEnabled = f.castingTimeUnitBox.Enabled;
                castingTimeComments = f.commentsBox.Text;

                // Duration
                durationType = f.durationTypeBox.Text;
                durationTime = (int)f.durationNumBox.Value;
                durationTimeEnabled = f.durationNumBox.Enabled;
                durationUnit = f.durationUnitBox.Text;
                durationUnitEnabled = f.durationUnitBox.Enabled;

                description = f.descriptionBox.Text;
                atHigherLevels = f.atHigherLevelsBox.Text;
            }

            // Convert components to string value
            public string getComponents()
            {
                bool first = true;
                string components = "";
                if (somaticComponents == true)
                {
                    components += "S";
                    first = false;
                }
                if (verbalComponents == true)
                {
                    if (first == false)
                    {
                        components += ", ";
                    }
                    components += "V";
                    first = false;
                }
                if (materialComponents == true)
                {
                    if (first == false)
                    {
                        components += ", ";
                    }
                    components += "M";
                }

                return components;
            }

            // Convert range to string value
            public string getRange()
            {
                string range = "";
                if (rangeType == "Range")
                {
                    range = distance + " " + distanceUnit;
                }
                else if (rangeType == "Self")
                {
                    range = "Self (" + distance + " " + distanceUnit + ")";
                }
                else
                {
                    range = rangeType;
                }

                return range;
            }

            // Convert casting time to string value
            public string getCastingTime()
            {
                string castingTime = "";
                if (castingTimeType == "Time")
                {
                    castingTime = castingTimeNum + " " + castingTimeUnit;
                }
                else
                {
                    castingTime = castingTimeType;
                }

                // Add any casting time comments specified by the user
                if (castingTimeComments != "Comments (optional)")
                {
                    castingTime += ", " + castingTimeComments;
                }

                return castingTime;
            }

            // Convert duration to string value
            public string getDuration()
            {
                string duration = "";
                if (durationType == "Time")
                {
                    duration = durationTime + " " + durationUnit;
                }
                else if (durationType == "Concentration")
                {
                    duration = "Concentration, up to " + durationTime + " " + durationUnit;
                }
                else
                {
                    duration = durationType;
                }

                return duration;
            }
        }

        public event Action updateStatBlockForm;

        // Spells for both listviews are stored here
        private List<Spell> addedSpellsList;
        private List<Spell> spellCollectionList;

        public EditSpellsForm()
        {
            InitializeComponent();

            addedSpellsList = StatBlockForm.addedSpellsList;

            if (File.Exists("spells.json"))
            {
                using (StreamReader r = new StreamReader("spells.json"))
                {
                    string json = r.ReadToEnd();
                    spellCollectionList = JsonConvert.DeserializeObject<List<Spell>>(json);
                }

                foreach (Spell spell in spellCollectionList)
                {
                    ListViewItem item = new ListViewItem(spell.name);
                    item.SubItems.Add(spell.level);
                    item.SubItems.Add(spell.getCastingTime());
                    item.SubItems.Add(spell.getRange());
                    item.SubItems.Add(spell.getComponents());
                    item.SubItems.Add(spell.getDuration());
                    item.SubItems.Add(spell.description);
                    spellsListView.Items.Add(item);
                }
            }
            else
            {
                spellCollectionList = new List<Spell>();
            }

            // Spell Name Text Box
            spellNameBox.Text = "Spell Name";
            spellNameBox.ForeColor = Color.Gray;
            this.spellNameBox.Leave += new System.EventHandler(this.spellNameBox_Leave);
            this.spellNameBox.Enter += new System.EventHandler(this.spellNameBox_Enter);

            // Materials Text Box
            materialComponentsBox.Text = "Materials";
            materialComponentsBox.ForeColor = Color.Gray;
            this.materialComponentsBox.Leave += new System.EventHandler(this.materialComponentsBox_Leave);
            this.materialComponentsBox.Enter += new System.EventHandler(this.materialComponentsBox_Enter);

            // Comments Text Box
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

        private void clearForm()
        {
            // Spell Name Text Box
            spellNameBox.Text = "Spell Name";
            spellNameBox.ForeColor = Color.Gray;

            // Components Checkboxes
            somaticCheckBox.Checked = false;
            verbalCheckBox.Checked = false;
            materialCheckBox.Checked = false;

            // Material Components Text Box
            materialComponentsBox.Text = "Materials";
            materialComponentsBox.ForeColor = Color.Gray;
            materialComponentsBox.Enabled = false;

            // Comments Text Box
            commentsBox.Text = "Comments (optional)";
            commentsBox.ForeColor = Color.Gray;

            spellLevelBox.Text = "Cantrip";
            spellTypeBox.Text = "Abjuration";
            ritualCheckBox.Checked = false;

            // Range
            rangeBox.Text = "Range";
            distanceBox.Value = 0;
            distanceBox.Enabled = true;
            distanceUnitBox.Text = "Feet";
            distanceUnitBox.Enabled = true;

            // Casting Time
            castingTimeBox.Text = "1 Action";
            castingTimeNumBox.Value = 1;
            castingTimeNumBox.Enabled = false;
            castingTimeUnitBox.Text = "Minutes";
            castingTimeUnitBox.Enabled = false;

            // Duration
            durationTypeBox.Text = "Instantaneous";
            durationNumBox.Value = 1;
            durationNumBox.Enabled = false;
            durationUnitBox.Text = "Minutes";
            durationUnitBox.Enabled = false;

            descriptionBox.Text = "";
            atHigherLevelsBox.Text = "";
        }

        private void fillFormWithSpell(Spell spell)
        {
            // Spell Name Text Box
            spellNameBox.Text = spell.name;
            if (spellNameBox.Text == "Spell Name")
            {
                spellNameBox.ForeColor = Color.Gray;
            }
            else
            {
                spellNameBox.ForeColor = Color.Black;
            }

            // Components Checkboxes
            somaticCheckBox.Checked = spell.somaticComponents;
            verbalCheckBox.Checked = spell.verbalComponents;
            materialCheckBox.Checked = spell.materialComponents;

            // Material Components Text Box
            materialComponentsBox.Text = spell.componentsDescription;
            if (materialComponentsBox.Text == "Materials")
            {
                materialComponentsBox.ForeColor = Color.Gray;
            }
            else
            {
                materialComponentsBox.ForeColor = Color.Black;
            }
            materialComponentsBox.Enabled = spell.componentsDescriptionEnabled;

            // Comments Text Box
            commentsBox.Text = spell.castingTimeComments;
            if (commentsBox.Text == "Comments (optional)")
            {
                commentsBox.ForeColor = Color.Gray;
            }
            else
            {
                commentsBox.ForeColor = Color.Black;
            }

            spellLevelBox.Text = spell.level;
            spellTypeBox.Text = spell.type;
            ritualCheckBox.Checked = spell.ritual;

            // Range
            rangeBox.Text = spell.rangeType;
            distanceBox.Value = spell.distance;
            distanceBox.Enabled = spell.distanceEnabled;
            distanceUnitBox.Text = spell.distanceUnit;
            distanceUnitBox.Enabled = spell.distanceUnitEnabled;

            // Casting Time
            castingTimeBox.Text = spell.castingTimeType;
            castingTimeNumBox.Value = spell.castingTimeNum;
            castingTimeNumBox.Enabled = spell.castingTimeNumEnabled;
            castingTimeUnitBox.Text = spell.castingTimeUnit;
            castingTimeUnitBox.Enabled = spell.castingTimeUnitEnabled;

            // Duration
            durationTypeBox.Text = spell.durationType;
            durationNumBox.Value = spell.durationTime;
            durationNumBox.Enabled = spell.durationTimeEnabled;
            durationUnitBox.Text = spell.durationUnit;
            durationUnitBox.Enabled = spell.durationUnitEnabled;

            descriptionBox.Text = spell.description;
            atHigherLevelsBox.Text = spell.atHigherLevels;
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
            // Allow user to specify range for the 'Range' and 'Self' options
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
            // Allow user to specify the exact time if 'Time' is chosen
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
            // Allow user to specify duration time if 'Time' or 'Concentration' is chosen
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
            // Spell Name and Description are required
            if (spellNameBox.Text == "Spell Name" || descriptionBox.Text == "")
            {
                return null;
            }

            // Material components must be specified if the materials checkbox is checked
            if (materialCheckBox.Checked == true && materialComponentsBox.Text == "Materials")
            {
                return null;
            }

            return new Spell(this);
        }

        private bool removeDuplicates(Spell matchSpell, List<Spell> spellsList, ListView spellsListView, bool nameFirst)
        {
            // Check for duplicates
            // NOTE: May want to restructure this!
            foreach (Spell spell in spellsList)
            {
                if (matchSpell.name == spell.name)
                {
                    // Duplicate found! Prompt user if they want to overwrite.
                    // Quit if they choose not to
                    DialogResult dr = MessageBox.Show("Are you sure you want to overwrite \"" + matchSpell.name + "\"?",
                        "Overwrite Spell", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.No)
                    {
                        return false;
                    }

                    // Remove duplicate from both added spells list and listview
                    spellsList.Remove(spell);
                    foreach (ListViewItem lvi in spellsListView.Items)
                    {
                        if (nameFirst == true)
                        {
                            if (matchSpell.name == lvi.Text)
                            {
                                spellsListView.Items.Remove(lvi);
                            }
                        }
                        else
                        {
                            if (matchSpell.name == lvi.SubItems[1].Text)
                            {
                                spellsListView.Items.Remove(lvi);
                            }
                        }
                    }

                    break;
                }
            }

            return true;
        }

        private void addSpellButton_Click(object sender, EventArgs e)
        {
            Spell spell = createNewSpell();
            if (spell == null) // Spell is not completely filled out
            {
                return;
            }

            bool removeDupSuccess = removeDuplicates(spell, addedSpellsList, addedSpellsListView, false);
            if (removeDupSuccess == false)
            {
                return;
            }

            clearForm();

            // Add spell to added spells list
            addedSpellsList.Add(spell);

            // And then to listview
            ListViewItem item = new ListViewItem(spell.level);
            item.SubItems.Add(spell.name);
            addedSpellsListView.Items.Add(item);
        }

        private void addToCollectionButton_Click(object sender, EventArgs e)
        {
            Spell spell = createNewSpell();
            if (spell == null) // Spell is not completely filled out
            {
                return;
            }

            bool removeDupSuccess = removeDuplicates(spell, spellCollectionList, spellsListView, true);
            if (removeDupSuccess == false)
            {
                return;
            }

            clearForm();

            // Add spell to collection list
            spellCollectionList.Add(spell);

            // And then to listview
            ListViewItem item = new ListViewItem(spell.name);
            item.SubItems.Add(spell.level);
            item.SubItems.Add(spell.getCastingTime());
            item.SubItems.Add(spell.getRange());
            item.SubItems.Add(spell.getComponents());
            item.SubItems.Add(spell.getDuration());
            item.SubItems.Add(spell.description);
            spellsListView.Items.Add(item);
        }

        private void addSpellsCollectionButton_Click(object sender, EventArgs e)
        {
            if (spellsListView.SelectedItems.Count == 0) // No listview entry was selected
            {
                return;
            }

            // Find spell name in collection list
            ListViewItem spellCollectionItem = spellsListView.SelectedItems[0];
            Spell collectionSpell = null;
            foreach (Spell spell in spellCollectionList)
            {
                if (spell.name == spellCollectionItem.Text)
                {
                    collectionSpell = spell;
                    break;
                }
            }

            bool removeDupSuccess = removeDuplicates(collectionSpell, addedSpellsList, addedSpellsListView, false);
            if (removeDupSuccess == false)
            {
                return;
            }

            // Add to added spells list
            addedSpellsList.Add(collectionSpell);

            // And then listview
            ListViewItem item = new ListViewItem(collectionSpell.level);
            item.SubItems.Add(collectionSpell.name);
            addedSpellsListView.Items.Add(item);
        }

        private void editCollectionButton_Click(object sender, EventArgs e)
        {
            if (spellsListView.SelectedItems.Count == 0) // No listview entry was selected
            {
                return;
            }

            // Find spell name in collection list
            ListViewItem spellCollectionItem = spellsListView.SelectedItems[0];
            Spell collectionSpell = null;
            foreach (Spell spell in spellCollectionList)
            {
                if (spell.name == spellCollectionItem.Text)
                {
                    collectionSpell = spell;
                    break;
                }
            }

            fillFormWithSpell(collectionSpell);
        }

        private void removeCollectionButton_Click(object sender, EventArgs e)
        {
            if (spellsListView.SelectedItems.Count == 0) // No listview entry was selected
            {
                return;
            }

            // Find spell name in collection list
            ListViewItem spellCollectionItem = spellsListView.SelectedItems[0];
            foreach (Spell spell in spellCollectionList)
            {
                if (spell.name == spellCollectionItem.Text)
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to remove the spell \"" + spell.name +
                        "\" from the collection? This action cannot be undone.", "Remove Spell from Collection", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.No)
                    {
                        return;
                    }

                    spellCollectionList.Remove(spell);
                    break;
                }
            }

            spellsListView.Items.Remove(spellCollectionItem);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (addedSpellsListView.SelectedItems.Count == 0) // No listview entry was selected
            {
                return;
            }

            // Find spell name in added spells list
            ListViewItem addedSpellItem = addedSpellsListView.SelectedItems[0];
            Spell addedSpell = null;
            foreach (Spell spell in addedSpellsList)
            {
                if (spell.name == addedSpellItem.SubItems[1].Text)
                {
                    addedSpell = spell;
                    break;
                }
            }

            // Fill out form entries with spell info
            fillFormWithSpell(addedSpell);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (addedSpellsListView.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem addedSpellItem = addedSpellsListView.SelectedItems[0];
            foreach (Spell spell in addedSpellsList)
            {
                if (spell.name == addedSpellItem.SubItems[1].Text)
                {
                    addedSpellsList.Remove(spell);
                    break;
                }
            }

            addedSpellsListView.Items.Remove(addedSpellItem);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            //File.Create("spells.json"); // e_e
            using (StreamWriter w = new StreamWriter("spells.json"))
            {
                string json = JsonConvert.SerializeObject(spellCollectionList, Formatting.Indented);
                w.Write(json);
            }

            StatBlockForm.addedSpellsList = addedSpellsList;
            updateStatBlockForm();
            this.Close();
        }
    }
}

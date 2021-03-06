﻿using System;
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
                    ListViewItem item = new ListViewItem(spell.Name);
                    item.SubItems.Add(spell.Level);
                    item.SubItems.Add(spell.getCastingTime());
                    item.SubItems.Add(spell.getRange());
                    item.SubItems.Add(spell.getComponents());
                    item.SubItems.Add(spell.getDuration());
                    item.SubItems.Add(spell.Description);
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
            spellNameBox.Text = spell.Name;
            if (spellNameBox.Text == "Spell Name")
            {
                spellNameBox.ForeColor = Color.Gray;
            }
            else
            {
                spellNameBox.ForeColor = Color.Black;
            }

            // Casting Time
            castingTimeBox.Text = spell.CastingTimeType;
            castingTimeNumBox.Value = spell.CastingTimeNum;
            castingTimeNumBox.Enabled = spell.CastingTimeNumEnabled;
            castingTimeUnitBox.Text = spell.CastingTimeUnit;
            castingTimeUnitBox.Enabled = spell.CastingTimeUnitEnabled;

            // Comments Text Box
            if (spell.CastingTimeComments == "")
            {
                commentsBox.Text = "Comments (optional)";
                commentsBox.ForeColor = Color.Gray;
            }
            else
            {
                commentsBox.Text = spell.CastingTimeComments;
                commentsBox.ForeColor = Color.Black;
            }

            spellLevelBox.Text = spell.Level;
            spellTypeBox.Text = spell.Type;
            ritualCheckBox.Checked = spell.Ritual;

            // Range
            rangeBox.Text = spell.RangeType;
            distanceBox.Value = spell.Distance;
            distanceBox.Enabled = spell.DistanceEnabled;
            distanceUnitBox.Text = spell.DistanceUnit;
            distanceUnitBox.Enabled = spell.DistanceUnitEnabled;

            // Components Checkboxes
            somaticCheckBox.Checked = spell.SomaticComponents;
            verbalCheckBox.Checked = spell.VerbalComponents;
            materialCheckBox.Checked = spell.MaterialComponents;

            // Material Components Text Box
            materialComponentsBox.Text = spell.ComponentsDescription;
            if (materialComponentsBox.Text == "Materials")
            {
                materialComponentsBox.ForeColor = Color.Gray;
            }
            else
            {
                materialComponentsBox.ForeColor = Color.Black;
            }
            materialComponentsBox.Enabled = spell.ComponentsDescriptionEnabled;

            // Duration
            durationTypeBox.Text = spell.DurationType;
            durationNumBox.Value = spell.DurationTime;
            durationNumBox.Enabled = spell.DurationTimeEnabled;
            durationUnitBox.Text = spell.DurationUnit;
            durationUnitBox.Enabled = spell.DurationUnitEnabled;

            descriptionBox.Text = spell.Description;
            atHigherLevelsBox.Text = spell.AtHigherLevels;
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

            string castingTimeComments = "";
            if (commentsBox.Text != "Comments (optional)")
            {
                castingTimeComments = commentsBox.Text;
            }

            return new Spell(spellNameBox.Text, somaticCheckBox.Checked, verbalCheckBox.Checked, materialCheckBox.Checked,
                             materialComponentsBox.Text, materialComponentsBox.Enabled, spellLevelBox.Text, spellTypeBox.Text,
                             ritualCheckBox.Checked, rangeBox.Text, (int)distanceBox.Value, distanceBox.Enabled, 
                             distanceUnitBox.Text, distanceUnitBox.Enabled, castingTimeBox.Text, (int)castingTimeNumBox.Value,
                             castingTimeNumBox.Enabled, castingTimeUnitBox.Text, castingTimeUnitBox.Enabled, castingTimeComments,
                             durationTypeBox.Text, (int)durationNumBox.Value, durationNumBox.Enabled, durationUnitBox.Text,
                             durationUnitBox.Enabled, descriptionBox.Text, atHigherLevelsBox.Text);
        }

        private bool removeDuplicates(Spell matchSpell, List<Spell> spellsList, ListView spellsListView, bool nameFirst)
        {
            // Check for duplicates
            // NOTE: May want to restructure this!
            foreach (Spell spell in spellsList)
            {
                if (matchSpell.Name == spell.Name)
                {
                    // Duplicate found! Prompt user if they want to overwrite.
                    // Quit if they choose not to
                    DialogResult dr = MessageBox.Show("Are you sure you want to overwrite \"" + matchSpell.Name + "\"?",
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
                            if (matchSpell.Name == lvi.Text)
                            {
                                spellsListView.Items.Remove(lvi);
                            }
                        }
                        else
                        {
                            if (matchSpell.Name == lvi.SubItems[1].Text)
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

        private int findSpellIndex(Spell spell, List<Spell> spellsList)
        {
            int i = 0;
            while (i < spellsList.Count && spellsList[i].Name.CompareTo(spell.Name) < 0)
            {
                i++;
            }

            return i;
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

            int index = findSpellIndex(spell, addedSpellsList);

            // Add spell to added spells list
            addedSpellsList.Insert(index, spell);

            // And then to listview
            ListViewItem item = new ListViewItem(spell.Level);
            item.SubItems.Add(spell.Name);
            addedSpellsListView.Items.Insert(index, item);
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

            int index = findSpellIndex(spell, spellCollectionList);

            // Add spell to collection list
            spellCollectionList.Insert(index, spell);

            // And then to listview
            ListViewItem item = new ListViewItem(spell.Name);
            item.SubItems.Add(spell.Level);
            item.SubItems.Add(spell.getCastingTime());
            item.SubItems.Add(spell.getRange());
            item.SubItems.Add(spell.getComponents());
            item.SubItems.Add(spell.getDuration());
            item.SubItems.Add(spell.Description);
            spellsListView.Items.Insert(index, item);
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
                if (spell.Name == spellCollectionItem.Text)
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

            int index = findSpellIndex(collectionSpell, addedSpellsList);

            // Add to added spells list
            addedSpellsList.Insert(index, collectionSpell);

            // And then listview
            ListViewItem item = new ListViewItem(collectionSpell.Level);
            item.SubItems.Add(collectionSpell.Name);
            addedSpellsListView.Items.Insert(index, item);
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
                if (spell.Name == spellCollectionItem.Text)
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
                if (spell.Name == spellCollectionItem.Text)
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to remove the spell \"" + spell.Name +
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
                if (spell.Name == addedSpellItem.SubItems[1].Text)
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
                if (spell.Name == addedSpellItem.SubItems[1].Text)
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

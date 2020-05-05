namespace StatBlockBuilder
{
    partial class EditSpellsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.spellsListView = new System.Windows.Forms.ListView();
            this.spellNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellLevelHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellCastingTimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellRangeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellComponentsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellDurationHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellDescriptionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newSpellLabel = new System.Windows.Forms.Label();
            this.addedSpellsListView = new System.Windows.Forms.ListView();
            this.addedSpellLevelHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addSpellsButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.spellNameBox = new System.Windows.Forms.TextBox();
            this.castingTimeBox = new System.Windows.Forms.ComboBox();
            this.castingTimeNumBox = new System.Windows.Forms.NumericUpDown();
            this.castingTimeUnitBox = new System.Windows.Forms.ComboBox();
            this.spellLevelBox = new System.Windows.Forms.ComboBox();
            this.spellTypeBox = new System.Windows.Forms.ComboBox();
            this.ritualCheckBox = new System.Windows.Forms.CheckBox();
            this.rangeBox = new System.Windows.Forms.ComboBox();
            this.distanceBox = new System.Windows.Forms.NumericUpDown();
            this.distanceUnitBox = new System.Windows.Forms.ComboBox();
            this.durationTypeBox = new System.Windows.Forms.ComboBox();
            this.durationUnitBox = new System.Windows.Forms.ComboBox();
            this.durationNumBox = new System.Windows.Forms.NumericUpDown();
            this.castingTimeLabel = new System.Windows.Forms.Label();
            this.rangeLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.spellTypeLabel = new System.Windows.Forms.Label();
            this.componentsLabel = new System.Windows.Forms.Label();
            this.materialCheckBox = new System.Windows.Forms.CheckBox();
            this.somaticCheckBox = new System.Windows.Forms.CheckBox();
            this.verbalCheckBox = new System.Windows.Forms.CheckBox();
            this.materialComponentsBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.commentsBox = new System.Windows.Forms.TextBox();
            this.addToCollectionButton = new System.Windows.Forms.Button();
            this.addSpellButton = new System.Windows.Forms.Button();
            this.addedSpellNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.atHigherLevelsLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.castingTimeNumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationNumBox)).BeginInit();
            this.SuspendLayout();
            // 
            // spellsListView
            // 
            this.spellsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.spellNameHeader,
            this.spellLevelHeader,
            this.spellCastingTimeHeader,
            this.spellRangeHeader,
            this.spellComponentsHeader,
            this.spellDurationHeader,
            this.spellDescriptionHeader});
            this.spellsListView.HideSelection = false;
            this.spellsListView.Location = new System.Drawing.Point(12, 12);
            this.spellsListView.Name = "spellsListView";
            this.spellsListView.Size = new System.Drawing.Size(597, 137);
            this.spellsListView.TabIndex = 0;
            this.spellsListView.UseCompatibleStateImageBehavior = false;
            this.spellsListView.View = System.Windows.Forms.View.Details;
            // 
            // spellNameHeader
            // 
            this.spellNameHeader.Text = "Name";
            this.spellNameHeader.Width = 118;
            // 
            // spellLevelHeader
            // 
            this.spellLevelHeader.Text = "Level";
            this.spellLevelHeader.Width = 40;
            // 
            // spellCastingTimeHeader
            // 
            this.spellCastingTimeHeader.Text = "Casting Time";
            this.spellCastingTimeHeader.Width = 90;
            // 
            // spellRangeHeader
            // 
            this.spellRangeHeader.Text = "Range";
            this.spellRangeHeader.Width = 62;
            // 
            // spellComponentsHeader
            // 
            this.spellComponentsHeader.Text = "Components";
            this.spellComponentsHeader.Width = 73;
            // 
            // spellDurationHeader
            // 
            this.spellDurationHeader.Text = "Duration";
            this.spellDurationHeader.Width = 68;
            // 
            // spellDescriptionHeader
            // 
            this.spellDescriptionHeader.Text = "Description";
            this.spellDescriptionHeader.Width = 119;
            // 
            // newSpellLabel
            // 
            this.newSpellLabel.AutoSize = true;
            this.newSpellLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newSpellLabel.Location = new System.Drawing.Point(359, 159);
            this.newSpellLabel.Name = "newSpellLabel";
            this.newSpellLabel.Size = new System.Drawing.Size(69, 16);
            this.newSpellLabel.TabIndex = 1;
            this.newSpellLabel.Text = "New Spell";
            // 
            // addedSpellsListView
            // 
            this.addedSpellsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.addedSpellLevelHeader,
            this.addedSpellNameHeader});
            this.addedSpellsListView.HideSelection = false;
            this.addedSpellsListView.Location = new System.Drawing.Point(12, 199);
            this.addedSpellsListView.Name = "addedSpellsListView";
            this.addedSpellsListView.Size = new System.Drawing.Size(200, 266);
            this.addedSpellsListView.TabIndex = 2;
            this.addedSpellsListView.UseCompatibleStateImageBehavior = false;
            this.addedSpellsListView.View = System.Windows.Forms.View.Details;
            // 
            // addedSpellLevelHeader
            // 
            this.addedSpellLevelHeader.Text = "Level";
            this.addedSpellLevelHeader.Width = 51;
            // 
            // addSpellsButton
            // 
            this.addSpellsButton.Location = new System.Drawing.Point(13, 156);
            this.addSpellsButton.Name = "addSpellsButton";
            this.addSpellsButton.Size = new System.Drawing.Size(75, 23);
            this.addSpellsButton.TabIndex = 3;
            this.addSpellsButton.Text = "Add Spells";
            this.addSpellsButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(12, 471);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(56, 23);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // spellNameBox
            // 
            this.spellNameBox.Location = new System.Drawing.Point(239, 199);
            this.spellNameBox.Name = "spellNameBox";
            this.spellNameBox.Size = new System.Drawing.Size(143, 20);
            this.spellNameBox.TabIndex = 5;
            // 
            // castingTimeBox
            // 
            this.castingTimeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.castingTimeBox.FormattingEnabled = true;
            this.castingTimeBox.Items.AddRange(new object[] {
            "1 Action",
            "1 Bonus Action",
            "1 Reaction",
            "Time"});
            this.castingTimeBox.Location = new System.Drawing.Point(239, 318);
            this.castingTimeBox.Name = "castingTimeBox";
            this.castingTimeBox.Size = new System.Drawing.Size(113, 21);
            this.castingTimeBox.TabIndex = 6;
            this.castingTimeBox.SelectedIndexChanged += new System.EventHandler(this.castingTimeBox_SelectedIndexChanged);
            // 
            // castingTimeNumBox
            // 
            this.castingTimeNumBox.Enabled = false;
            this.castingTimeNumBox.Location = new System.Drawing.Point(359, 318);
            this.castingTimeNumBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.castingTimeNumBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.castingTimeNumBox.Name = "castingTimeNumBox";
            this.castingTimeNumBox.Size = new System.Drawing.Size(40, 20);
            this.castingTimeNumBox.TabIndex = 7;
            this.castingTimeNumBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // castingTimeUnitBox
            // 
            this.castingTimeUnitBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.castingTimeUnitBox.Enabled = false;
            this.castingTimeUnitBox.FormattingEnabled = true;
            this.castingTimeUnitBox.Items.AddRange(new object[] {
            "Minutes",
            "Hours",
            "Days",
            "Weeks",
            "Months",
            "Years"});
            this.castingTimeUnitBox.Location = new System.Drawing.Point(405, 318);
            this.castingTimeUnitBox.Name = "castingTimeUnitBox";
            this.castingTimeUnitBox.Size = new System.Drawing.Size(78, 21);
            this.castingTimeUnitBox.TabIndex = 8;
            // 
            // spellLevelBox
            // 
            this.spellLevelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spellLevelBox.FormattingEnabled = true;
            this.spellLevelBox.Items.AddRange(new object[] {
            "Cantrip",
            "1st-level",
            "2nd-level",
            "3rd-level",
            "4th-level",
            "5th-level",
            "6th-level",
            "7th-level",
            "8th-level",
            "9th-level"});
            this.spellLevelBox.Location = new System.Drawing.Point(239, 238);
            this.spellLevelBox.Name = "spellLevelBox";
            this.spellLevelBox.Size = new System.Drawing.Size(80, 21);
            this.spellLevelBox.TabIndex = 9;
            // 
            // spellTypeBox
            // 
            this.spellTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spellTypeBox.FormattingEnabled = true;
            this.spellTypeBox.Items.AddRange(new object[] {
            "Abjuration",
            "Conjuration",
            "Divination",
            "Enchantment",
            "Evocation",
            "Illusion",
            "Necromancy",
            "Transmutation"});
            this.spellTypeBox.Location = new System.Drawing.Point(326, 238);
            this.spellTypeBox.Name = "spellTypeBox";
            this.spellTypeBox.Size = new System.Drawing.Size(91, 21);
            this.spellTypeBox.TabIndex = 10;
            // 
            // ritualCheckBox
            // 
            this.ritualCheckBox.AutoSize = true;
            this.ritualCheckBox.Location = new System.Drawing.Point(424, 238);
            this.ritualCheckBox.Name = "ritualCheckBox";
            this.ritualCheckBox.Size = new System.Drawing.Size(59, 17);
            this.ritualCheckBox.TabIndex = 11;
            this.ritualCheckBox.Text = "Ritual?";
            this.ritualCheckBox.UseVisualStyleBackColor = true;
            // 
            // rangeBox
            // 
            this.rangeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rangeBox.FormattingEnabled = true;
            this.rangeBox.Items.AddRange(new object[] {
            "Range",
            "Self",
            "Touch",
            "Sight",
            "Unlimited"});
            this.rangeBox.Location = new System.Drawing.Point(239, 278);
            this.rangeBox.Name = "rangeBox";
            this.rangeBox.Size = new System.Drawing.Size(80, 21);
            this.rangeBox.TabIndex = 12;
            this.rangeBox.SelectedIndexChanged += new System.EventHandler(this.rangeBox_SelectedIndexChanged);
            // 
            // distanceBox
            // 
            this.distanceBox.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.distanceBox.Location = new System.Drawing.Point(326, 279);
            this.distanceBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.distanceBox.Name = "distanceBox";
            this.distanceBox.Size = new System.Drawing.Size(40, 20);
            this.distanceBox.TabIndex = 13;
            // 
            // distanceUnitBox
            // 
            this.distanceUnitBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.distanceUnitBox.FormattingEnabled = true;
            this.distanceUnitBox.Items.AddRange(new object[] {
            "Feet",
            "Miles"});
            this.distanceUnitBox.Location = new System.Drawing.Point(372, 279);
            this.distanceUnitBox.Name = "distanceUnitBox";
            this.distanceUnitBox.Size = new System.Drawing.Size(78, 21);
            this.distanceUnitBox.TabIndex = 14;
            // 
            // durationTypeBox
            // 
            this.durationTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.durationTypeBox.FormattingEnabled = true;
            this.durationTypeBox.Items.AddRange(new object[] {
            "Instantaneous",
            "Time",
            "Concentration",
            "Until Dispelled",
            "Until Dispelled/Triggered"});
            this.durationTypeBox.Location = new System.Drawing.Point(239, 358);
            this.durationTypeBox.Name = "durationTypeBox";
            this.durationTypeBox.Size = new System.Drawing.Size(143, 21);
            this.durationTypeBox.TabIndex = 15;
            this.durationTypeBox.SelectedIndexChanged += new System.EventHandler(this.durationTypeBox_SelectedIndexChanged);
            // 
            // durationUnitBox
            // 
            this.durationUnitBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.durationUnitBox.Enabled = false;
            this.durationUnitBox.FormattingEnabled = true;
            this.durationUnitBox.Items.AddRange(new object[] {
            "Minutes",
            "Hours",
            "Days",
            "Weeks",
            "Months",
            "Years"});
            this.durationUnitBox.Location = new System.Drawing.Point(434, 359);
            this.durationUnitBox.Name = "durationUnitBox";
            this.durationUnitBox.Size = new System.Drawing.Size(79, 21);
            this.durationUnitBox.TabIndex = 17;
            // 
            // durationNumBox
            // 
            this.durationNumBox.Enabled = false;
            this.durationNumBox.Location = new System.Drawing.Point(388, 359);
            this.durationNumBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.durationNumBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.durationNumBox.Name = "durationNumBox";
            this.durationNumBox.Size = new System.Drawing.Size(40, 20);
            this.durationNumBox.TabIndex = 16;
            this.durationNumBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // castingTimeLabel
            // 
            this.castingTimeLabel.AutoSize = true;
            this.castingTimeLabel.Location = new System.Drawing.Point(250, 302);
            this.castingTimeLabel.Name = "castingTimeLabel";
            this.castingTimeLabel.Size = new System.Drawing.Size(68, 13);
            this.castingTimeLabel.TabIndex = 19;
            this.castingTimeLabel.Text = "Casting Time";
            // 
            // rangeLabel
            // 
            this.rangeLabel.AutoSize = true;
            this.rangeLabel.Location = new System.Drawing.Point(258, 262);
            this.rangeLabel.Name = "rangeLabel";
            this.rangeLabel.Size = new System.Drawing.Size(39, 13);
            this.rangeLabel.TabIndex = 20;
            this.rangeLabel.Text = "Range";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(271, 342);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(47, 13);
            this.durationLabel.TabIndex = 21;
            this.durationLabel.Text = "Duration";
            // 
            // spellTypeLabel
            // 
            this.spellTypeLabel.AutoSize = true;
            this.spellTypeLabel.Location = new System.Drawing.Point(250, 222);
            this.spellTypeLabel.Name = "spellTypeLabel";
            this.spellTypeLabel.Size = new System.Drawing.Size(57, 13);
            this.spellTypeLabel.TabIndex = 22;
            this.spellTypeLabel.Text = "Spell Type";
            // 
            // componentsLabel
            // 
            this.componentsLabel.AutoSize = true;
            this.componentsLabel.Location = new System.Drawing.Point(385, 183);
            this.componentsLabel.Name = "componentsLabel";
            this.componentsLabel.Size = new System.Drawing.Size(66, 13);
            this.componentsLabel.TabIndex = 30;
            this.componentsLabel.Text = "Components";
            // 
            // materialCheckBox
            // 
            this.materialCheckBox.AutoSize = true;
            this.materialCheckBox.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.materialCheckBox.Location = new System.Drawing.Point(436, 199);
            this.materialCheckBox.Name = "materialCheckBox";
            this.materialCheckBox.Size = new System.Drawing.Size(20, 31);
            this.materialCheckBox.TabIndex = 29;
            this.materialCheckBox.Text = "M";
            this.materialCheckBox.UseVisualStyleBackColor = true;
            this.materialCheckBox.CheckedChanged += new System.EventHandler(this.materialCheckBox_CheckedChanged);
            // 
            // somaticCheckBox
            // 
            this.somaticCheckBox.AutoSize = true;
            this.somaticCheckBox.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.somaticCheckBox.Location = new System.Drawing.Point(412, 199);
            this.somaticCheckBox.Name = "somaticCheckBox";
            this.somaticCheckBox.Size = new System.Drawing.Size(18, 31);
            this.somaticCheckBox.TabIndex = 28;
            this.somaticCheckBox.Text = "S";
            this.somaticCheckBox.UseVisualStyleBackColor = true;
            // 
            // verbalCheckBox
            // 
            this.verbalCheckBox.AutoSize = true;
            this.verbalCheckBox.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.verbalCheckBox.Location = new System.Drawing.Point(388, 199);
            this.verbalCheckBox.Name = "verbalCheckBox";
            this.verbalCheckBox.Size = new System.Drawing.Size(18, 31);
            this.verbalCheckBox.TabIndex = 27;
            this.verbalCheckBox.Text = "V";
            this.verbalCheckBox.UseVisualStyleBackColor = true;
            // 
            // materialComponentsBox
            // 
            this.materialComponentsBox.Enabled = false;
            this.materialComponentsBox.Location = new System.Drawing.Point(462, 199);
            this.materialComponentsBox.Name = "materialComponentsBox";
            this.materialComponentsBox.Size = new System.Drawing.Size(147, 20);
            this.materialComponentsBox.TabIndex = 31;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.Location = new System.Drawing.Point(239, 398);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(370, 96);
            this.descriptionBox.TabIndex = 32;
            this.descriptionBox.Text = "";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(259, 382);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 33;
            this.descriptionLabel.Text = "Description";
            // 
            // commentsBox
            // 
            this.commentsBox.Location = new System.Drawing.Point(489, 318);
            this.commentsBox.Name = "commentsBox";
            this.commentsBox.Size = new System.Drawing.Size(120, 20);
            this.commentsBox.TabIndex = 34;
            // 
            // addToCollectionButton
            // 
            this.addToCollectionButton.Location = new System.Drawing.Point(513, 592);
            this.addToCollectionButton.Name = "addToCollectionButton";
            this.addToCollectionButton.Size = new System.Drawing.Size(96, 23);
            this.addToCollectionButton.TabIndex = 35;
            this.addToCollectionButton.Text = "Add to Collection";
            this.addToCollectionButton.UseVisualStyleBackColor = true;
            this.addToCollectionButton.Click += new System.EventHandler(this.addToCollectionButton_Click);
            // 
            // addSpellButton
            // 
            this.addSpellButton.Location = new System.Drawing.Point(436, 592);
            this.addSpellButton.Name = "addSpellButton";
            this.addSpellButton.Size = new System.Drawing.Size(71, 23);
            this.addSpellButton.TabIndex = 36;
            this.addSpellButton.Text = "Add Spell";
            this.addSpellButton.UseVisualStyleBackColor = true;
            this.addSpellButton.Click += new System.EventHandler(this.addSpellButton_Click);
            // 
            // addedSpellNameHeader
            // 
            this.addedSpellNameHeader.Text = "Name";
            this.addedSpellNameHeader.Width = 137;
            // 
            // atHigherLevelsLabel
            // 
            this.atHigherLevelsLabel.AutoSize = true;
            this.atHigherLevelsLabel.Location = new System.Drawing.Point(250, 497);
            this.atHigherLevelsLabel.Name = "atHigherLevelsLabel";
            this.atHigherLevelsLabel.Size = new System.Drawing.Size(85, 13);
            this.atHigherLevelsLabel.TabIndex = 37;
            this.atHigherLevelsLabel.Text = "At Higher Levels";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(239, 513);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(370, 73);
            this.richTextBox1.TabIndex = 38;
            this.richTextBox1.Text = "";
            // 
            // EditSpellsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 628);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.atHigherLevelsLabel);
            this.Controls.Add(this.addSpellButton);
            this.Controls.Add(this.addToCollectionButton);
            this.Controls.Add(this.commentsBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.materialComponentsBox);
            this.Controls.Add(this.componentsLabel);
            this.Controls.Add(this.materialCheckBox);
            this.Controls.Add(this.somaticCheckBox);
            this.Controls.Add(this.verbalCheckBox);
            this.Controls.Add(this.spellTypeLabel);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.rangeLabel);
            this.Controls.Add(this.castingTimeLabel);
            this.Controls.Add(this.durationUnitBox);
            this.Controls.Add(this.durationNumBox);
            this.Controls.Add(this.durationTypeBox);
            this.Controls.Add(this.distanceUnitBox);
            this.Controls.Add(this.distanceBox);
            this.Controls.Add(this.rangeBox);
            this.Controls.Add(this.ritualCheckBox);
            this.Controls.Add(this.spellTypeBox);
            this.Controls.Add(this.spellLevelBox);
            this.Controls.Add(this.castingTimeUnitBox);
            this.Controls.Add(this.castingTimeNumBox);
            this.Controls.Add(this.castingTimeBox);
            this.Controls.Add(this.spellNameBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addSpellsButton);
            this.Controls.Add(this.addedSpellsListView);
            this.Controls.Add(this.newSpellLabel);
            this.Controls.Add(this.spellsListView);
            this.Name = "EditSpellsForm";
            this.Text = "Edit Spells";
            ((System.ComponentModel.ISupportInitialize)(this.castingTimeNumBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationNumBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView spellsListView;
        private System.Windows.Forms.ColumnHeader spellNameHeader;
        private System.Windows.Forms.ColumnHeader spellLevelHeader;
        private System.Windows.Forms.ColumnHeader spellCastingTimeHeader;
        private System.Windows.Forms.ColumnHeader spellRangeHeader;
        private System.Windows.Forms.ColumnHeader spellComponentsHeader;
        private System.Windows.Forms.ColumnHeader spellDurationHeader;
        private System.Windows.Forms.ColumnHeader spellDescriptionHeader;
        private System.Windows.Forms.Label newSpellLabel;
        private System.Windows.Forms.ListView addedSpellsListView;
        private System.Windows.Forms.ColumnHeader addedSpellLevelHeader;
        private System.Windows.Forms.Button addSpellsButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox spellNameBox;
        private System.Windows.Forms.ComboBox castingTimeBox;
        private System.Windows.Forms.NumericUpDown castingTimeNumBox;
        private System.Windows.Forms.ComboBox castingTimeUnitBox;
        private System.Windows.Forms.ComboBox spellLevelBox;
        private System.Windows.Forms.ComboBox spellTypeBox;
        private System.Windows.Forms.CheckBox ritualCheckBox;
        private System.Windows.Forms.ComboBox rangeBox;
        private System.Windows.Forms.NumericUpDown distanceBox;
        private System.Windows.Forms.ComboBox distanceUnitBox;
        private System.Windows.Forms.ComboBox durationTypeBox;
        private System.Windows.Forms.ComboBox durationUnitBox;
        private System.Windows.Forms.NumericUpDown durationNumBox;
        private System.Windows.Forms.Label castingTimeLabel;
        private System.Windows.Forms.Label rangeLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label spellTypeLabel;
        private System.Windows.Forms.Label componentsLabel;
        private System.Windows.Forms.CheckBox materialCheckBox;
        private System.Windows.Forms.CheckBox somaticCheckBox;
        private System.Windows.Forms.CheckBox verbalCheckBox;
        private System.Windows.Forms.TextBox materialComponentsBox;
        private System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox commentsBox;
        private System.Windows.Forms.Button addToCollectionButton;
        private System.Windows.Forms.Button addSpellButton;
        private System.Windows.Forms.ColumnHeader addedSpellNameHeader;
        private System.Windows.Forms.Label atHigherLevelsLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
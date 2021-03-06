﻿namespace StatBlockBuilder
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
            this.addedSpellNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addSpellsCollectionButton = new System.Windows.Forms.Button();
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
            this.atHigherLevelsLabel = new System.Windows.Forms.Label();
            this.atHigherLevelsBox = new System.Windows.Forms.RichTextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.previewButton = new System.Windows.Forms.Button();
            this.editCollectionButton = new System.Windows.Forms.Button();
            this.removeCollectionButton = new System.Windows.Forms.Button();
            this.addedSpellsLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveChangesButton = new System.Windows.Forms.Button();
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
            this.spellsListView.FullRowSelect = true;
            this.spellsListView.HideSelection = false;
            this.spellsListView.Location = new System.Drawing.Point(12, 12);
            this.spellsListView.MultiSelect = false;
            this.spellsListView.Name = "spellsListView";
            this.spellsListView.Size = new System.Drawing.Size(606, 137);
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
            this.spellLevelHeader.Width = 57;
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
            this.newSpellLabel.Location = new System.Drawing.Point(356, 178);
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
            this.addedSpellsListView.FullRowSelect = true;
            this.addedSpellsListView.HideSelection = false;
            this.addedSpellsListView.Location = new System.Drawing.Point(12, 208);
            this.addedSpellsListView.MultiSelect = false;
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
            // addedSpellNameHeader
            // 
            this.addedSpellNameHeader.Text = "Name";
            this.addedSpellNameHeader.Width = 137;
            // 
            // addSpellsCollectionButton
            // 
            this.addSpellsCollectionButton.Location = new System.Drawing.Point(12, 155);
            this.addSpellsCollectionButton.Name = "addSpellsCollectionButton";
            this.addSpellsCollectionButton.Size = new System.Drawing.Size(55, 23);
            this.addSpellsCollectionButton.TabIndex = 3;
            this.addSpellsCollectionButton.Text = "Add";
            this.addSpellsCollectionButton.UseVisualStyleBackColor = true;
            this.addSpellsCollectionButton.Click += new System.EventHandler(this.addSpellsCollectionButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(12, 480);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(56, 23);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // spellNameBox
            // 
            this.spellNameBox.Location = new System.Drawing.Point(239, 208);
            this.spellNameBox.Name = "spellNameBox";
            this.spellNameBox.Size = new System.Drawing.Size(178, 20);
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
            this.castingTimeBox.Location = new System.Drawing.Point(239, 287);
            this.castingTimeBox.Name = "castingTimeBox";
            this.castingTimeBox.Size = new System.Drawing.Size(113, 21);
            this.castingTimeBox.TabIndex = 6;
            this.castingTimeBox.SelectedIndexChanged += new System.EventHandler(this.castingTimeBox_SelectedIndexChanged);
            // 
            // castingTimeNumBox
            // 
            this.castingTimeNumBox.Enabled = false;
            this.castingTimeNumBox.Location = new System.Drawing.Point(359, 287);
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
            this.castingTimeUnitBox.Location = new System.Drawing.Point(405, 287);
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
            this.spellLevelBox.Location = new System.Drawing.Point(239, 247);
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
            this.spellTypeBox.Location = new System.Drawing.Point(326, 247);
            this.spellTypeBox.Name = "spellTypeBox";
            this.spellTypeBox.Size = new System.Drawing.Size(91, 21);
            this.spellTypeBox.TabIndex = 10;
            // 
            // ritualCheckBox
            // 
            this.ritualCheckBox.AutoSize = true;
            this.ritualCheckBox.Location = new System.Drawing.Point(424, 247);
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
            this.rangeBox.Location = new System.Drawing.Point(239, 327);
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
            this.distanceBox.Location = new System.Drawing.Point(326, 328);
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
            this.distanceUnitBox.Location = new System.Drawing.Point(372, 328);
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
            this.durationTypeBox.Location = new System.Drawing.Point(239, 417);
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
            this.durationUnitBox.Location = new System.Drawing.Point(434, 418);
            this.durationUnitBox.Name = "durationUnitBox";
            this.durationUnitBox.Size = new System.Drawing.Size(79, 21);
            this.durationUnitBox.TabIndex = 17;
            // 
            // durationNumBox
            // 
            this.durationNumBox.Enabled = false;
            this.durationNumBox.Location = new System.Drawing.Point(388, 418);
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
            this.castingTimeLabel.Location = new System.Drawing.Point(250, 271);
            this.castingTimeLabel.Name = "castingTimeLabel";
            this.castingTimeLabel.Size = new System.Drawing.Size(68, 13);
            this.castingTimeLabel.TabIndex = 19;
            this.castingTimeLabel.Text = "Casting Time";
            // 
            // rangeLabel
            // 
            this.rangeLabel.AutoSize = true;
            this.rangeLabel.Location = new System.Drawing.Point(258, 311);
            this.rangeLabel.Name = "rangeLabel";
            this.rangeLabel.Size = new System.Drawing.Size(39, 13);
            this.rangeLabel.TabIndex = 20;
            this.rangeLabel.Text = "Range";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(271, 401);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(47, 13);
            this.durationLabel.TabIndex = 21;
            this.durationLabel.Text = "Duration";
            // 
            // spellTypeLabel
            // 
            this.spellTypeLabel.AutoSize = true;
            this.spellTypeLabel.Location = new System.Drawing.Point(250, 231);
            this.spellTypeLabel.Name = "spellTypeLabel";
            this.spellTypeLabel.Size = new System.Drawing.Size(57, 13);
            this.spellTypeLabel.TabIndex = 22;
            this.spellTypeLabel.Text = "Spell Type";
            // 
            // componentsLabel
            // 
            this.componentsLabel.AutoSize = true;
            this.componentsLabel.Location = new System.Drawing.Point(236, 351);
            this.componentsLabel.Name = "componentsLabel";
            this.componentsLabel.Size = new System.Drawing.Size(66, 13);
            this.componentsLabel.TabIndex = 30;
            this.componentsLabel.Text = "Components";
            // 
            // materialCheckBox
            // 
            this.materialCheckBox.AutoSize = true;
            this.materialCheckBox.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.materialCheckBox.Location = new System.Drawing.Point(287, 367);
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
            this.somaticCheckBox.Location = new System.Drawing.Point(263, 367);
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
            this.verbalCheckBox.Location = new System.Drawing.Point(239, 367);
            this.verbalCheckBox.Name = "verbalCheckBox";
            this.verbalCheckBox.Size = new System.Drawing.Size(18, 31);
            this.verbalCheckBox.TabIndex = 27;
            this.verbalCheckBox.Text = "V";
            this.verbalCheckBox.UseVisualStyleBackColor = true;
            // 
            // materialComponentsBox
            // 
            this.materialComponentsBox.Enabled = false;
            this.materialComponentsBox.Location = new System.Drawing.Point(313, 367);
            this.materialComponentsBox.Name = "materialComponentsBox";
            this.materialComponentsBox.Size = new System.Drawing.Size(143, 20);
            this.materialComponentsBox.TabIndex = 31;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.Location = new System.Drawing.Point(239, 457);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(379, 96);
            this.descriptionBox.TabIndex = 32;
            this.descriptionBox.Text = "";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(259, 441);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 33;
            this.descriptionLabel.Text = "Description";
            // 
            // commentsBox
            // 
            this.commentsBox.Location = new System.Drawing.Point(489, 287);
            this.commentsBox.Name = "commentsBox";
            this.commentsBox.Size = new System.Drawing.Size(120, 20);
            this.commentsBox.TabIndex = 34;
            // 
            // addToCollectionButton
            // 
            this.addToCollectionButton.Location = new System.Drawing.Point(524, 651);
            this.addToCollectionButton.Name = "addToCollectionButton";
            this.addToCollectionButton.Size = new System.Drawing.Size(96, 23);
            this.addToCollectionButton.TabIndex = 35;
            this.addToCollectionButton.Text = "Add to Collection";
            this.addToCollectionButton.UseVisualStyleBackColor = true;
            this.addToCollectionButton.Click += new System.EventHandler(this.addToCollectionButton_Click);
            // 
            // addSpellButton
            // 
            this.addSpellButton.Location = new System.Drawing.Point(447, 651);
            this.addSpellButton.Name = "addSpellButton";
            this.addSpellButton.Size = new System.Drawing.Size(71, 23);
            this.addSpellButton.TabIndex = 36;
            this.addSpellButton.Text = "Add Spell";
            this.addSpellButton.UseVisualStyleBackColor = true;
            this.addSpellButton.Click += new System.EventHandler(this.addSpellButton_Click);
            // 
            // atHigherLevelsLabel
            // 
            this.atHigherLevelsLabel.AutoSize = true;
            this.atHigherLevelsLabel.Location = new System.Drawing.Point(250, 556);
            this.atHigherLevelsLabel.Name = "atHigherLevelsLabel";
            this.atHigherLevelsLabel.Size = new System.Drawing.Size(85, 13);
            this.atHigherLevelsLabel.TabIndex = 37;
            this.atHigherLevelsLabel.Text = "At Higher Levels";
            // 
            // atHigherLevelsBox
            // 
            this.atHigherLevelsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atHigherLevelsBox.Location = new System.Drawing.Point(239, 572);
            this.atHigherLevelsBox.Name = "atHigherLevelsBox";
            this.atHigherLevelsBox.Size = new System.Drawing.Size(379, 73);
            this.atHigherLevelsBox.TabIndex = 38;
            this.atHigherLevelsBox.Text = "";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(74, 480);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(56, 23);
            this.editButton.TabIndex = 39;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(103, 652);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(56, 23);
            this.previewButton.TabIndex = 40;
            this.previewButton.Text = "Preview";
            this.previewButton.UseVisualStyleBackColor = true;
            // 
            // editCollectionButton
            // 
            this.editCollectionButton.Location = new System.Drawing.Point(135, 155);
            this.editCollectionButton.Name = "editCollectionButton";
            this.editCollectionButton.Size = new System.Drawing.Size(56, 23);
            this.editCollectionButton.TabIndex = 42;
            this.editCollectionButton.Text = "Edit";
            this.editCollectionButton.UseVisualStyleBackColor = true;
            this.editCollectionButton.Click += new System.EventHandler(this.editCollectionButton_Click);
            // 
            // removeCollectionButton
            // 
            this.removeCollectionButton.Location = new System.Drawing.Point(73, 155);
            this.removeCollectionButton.Name = "removeCollectionButton";
            this.removeCollectionButton.Size = new System.Drawing.Size(56, 23);
            this.removeCollectionButton.TabIndex = 41;
            this.removeCollectionButton.Text = "Remove";
            this.removeCollectionButton.UseVisualStyleBackColor = true;
            this.removeCollectionButton.Click += new System.EventHandler(this.removeCollectionButton_Click);
            // 
            // addedSpellsLabel
            // 
            this.addedSpellsLabel.AutoSize = true;
            this.addedSpellsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedSpellsLabel.Location = new System.Drawing.Point(61, 189);
            this.addedSpellsLabel.Name = "addedSpellsLabel";
            this.addedSpellsLabel.Size = new System.Drawing.Size(90, 16);
            this.addedSpellsLabel.TabIndex = 43;
            this.addedSpellsLabel.Text = "Added Spells";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(239, 652);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(58, 23);
            this.clearButton.TabIndex = 44;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesButton.Location = new System.Drawing.Point(12, 652);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(85, 23);
            this.saveChangesButton.TabIndex = 45;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // EditSpellsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 682);
            this.ControlBox = false;
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addedSpellsLabel);
            this.Controls.Add(this.editCollectionButton);
            this.Controls.Add(this.removeCollectionButton);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.atHigherLevelsBox);
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
            this.Controls.Add(this.addSpellsCollectionButton);
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
        private System.Windows.Forms.Button addSpellsCollectionButton;
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
        private System.Windows.Forms.RichTextBox atHigherLevelsBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.Button editCollectionButton;
        private System.Windows.Forms.Button removeCollectionButton;
        private System.Windows.Forms.Label addedSpellsLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button saveChangesButton;
    }
}
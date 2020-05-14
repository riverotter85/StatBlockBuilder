namespace StatBlockBuilder
{
    partial class EditTraitsForm
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
            this.addedTraitsLabel = new System.Windows.Forms.Label();
            this.editCollectionButton = new System.Windows.Forms.Button();
            this.removeCollectionButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addTraitsCollectionButton = new System.Windows.Forms.Button();
            this.addedTraitsListView = new System.Windows.Forms.ListView();
            this.addedTraitsNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.traitsListView = new System.Windows.Forms.ListView();
            this.traitsNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.traitsDescriptionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newTraitLabel = new System.Windows.Forms.Label();
            this.traitNameBox = new System.Windows.Forms.TextBox();
            this.traitDescriptionBox = new System.Windows.Forms.RichTextBox();
            this.traitDescriptionLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.addTraitButton = new System.Windows.Forms.Button();
            this.addToCollectionButton = new System.Windows.Forms.Button();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addedTraitsLabel
            // 
            this.addedTraitsLabel.AutoSize = true;
            this.addedTraitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedTraitsLabel.Location = new System.Drawing.Point(32, 189);
            this.addedTraitsLabel.Name = "addedTraitsLabel";
            this.addedTraitsLabel.Size = new System.Drawing.Size(86, 16);
            this.addedTraitsLabel.TabIndex = 51;
            this.addedTraitsLabel.Text = "Added Traits";
            // 
            // editCollectionButton
            // 
            this.editCollectionButton.Location = new System.Drawing.Point(135, 155);
            this.editCollectionButton.Name = "editCollectionButton";
            this.editCollectionButton.Size = new System.Drawing.Size(56, 23);
            this.editCollectionButton.TabIndex = 50;
            this.editCollectionButton.Text = "Edit";
            this.editCollectionButton.UseVisualStyleBackColor = true;
            // 
            // removeCollectionButton
            // 
            this.removeCollectionButton.Location = new System.Drawing.Point(73, 155);
            this.removeCollectionButton.Name = "removeCollectionButton";
            this.removeCollectionButton.Size = new System.Drawing.Size(56, 23);
            this.removeCollectionButton.TabIndex = 49;
            this.removeCollectionButton.Text = "Remove";
            this.removeCollectionButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(74, 357);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(56, 23);
            this.editButton.TabIndex = 48;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(12, 357);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(56, 23);
            this.removeButton.TabIndex = 47;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // addTraitsCollectionButton
            // 
            this.addTraitsCollectionButton.Location = new System.Drawing.Point(12, 155);
            this.addTraitsCollectionButton.Name = "addTraitsCollectionButton";
            this.addTraitsCollectionButton.Size = new System.Drawing.Size(55, 23);
            this.addTraitsCollectionButton.TabIndex = 46;
            this.addTraitsCollectionButton.Text = "Add";
            this.addTraitsCollectionButton.UseVisualStyleBackColor = true;
            // 
            // addedTraitsListView
            // 
            this.addedTraitsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.addedTraitsNameHeader});
            this.addedTraitsListView.FullRowSelect = true;
            this.addedTraitsListView.HideSelection = false;
            this.addedTraitsListView.Location = new System.Drawing.Point(12, 208);
            this.addedTraitsListView.MultiSelect = false;
            this.addedTraitsListView.Name = "addedTraitsListView";
            this.addedTraitsListView.Size = new System.Drawing.Size(135, 143);
            this.addedTraitsListView.TabIndex = 45;
            this.addedTraitsListView.UseCompatibleStateImageBehavior = false;
            this.addedTraitsListView.View = System.Windows.Forms.View.Details;
            // 
            // addedTraitsNameHeader
            // 
            this.addedTraitsNameHeader.Text = "Name";
            this.addedTraitsNameHeader.Width = 113;
            // 
            // traitsListView
            // 
            this.traitsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.traitsNameHeader,
            this.traitsDescriptionHeader});
            this.traitsListView.FullRowSelect = true;
            this.traitsListView.HideSelection = false;
            this.traitsListView.Location = new System.Drawing.Point(12, 12);
            this.traitsListView.MultiSelect = false;
            this.traitsListView.Name = "traitsListView";
            this.traitsListView.Size = new System.Drawing.Size(466, 137);
            this.traitsListView.TabIndex = 44;
            this.traitsListView.UseCompatibleStateImageBehavior = false;
            this.traitsListView.View = System.Windows.Forms.View.Details;
            // 
            // traitsNameHeader
            // 
            this.traitsNameHeader.Text = "Name";
            this.traitsNameHeader.Width = 118;
            // 
            // traitsDescriptionHeader
            // 
            this.traitsDescriptionHeader.Text = "Description";
            this.traitsDescriptionHeader.Width = 303;
            // 
            // newTraitLabel
            // 
            this.newTraitLabel.AutoSize = true;
            this.newTraitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTraitLabel.Location = new System.Drawing.Point(277, 179);
            this.newTraitLabel.Name = "newTraitLabel";
            this.newTraitLabel.Size = new System.Drawing.Size(65, 16);
            this.newTraitLabel.TabIndex = 52;
            this.newTraitLabel.Text = "New Trait";
            // 
            // traitNameBox
            // 
            this.traitNameBox.Location = new System.Drawing.Point(183, 208);
            this.traitNameBox.Name = "traitNameBox";
            this.traitNameBox.Size = new System.Drawing.Size(135, 20);
            this.traitNameBox.TabIndex = 53;
            // 
            // traitDescriptionBox
            // 
            this.traitDescriptionBox.Location = new System.Drawing.Point(183, 255);
            this.traitDescriptionBox.Name = "traitDescriptionBox";
            this.traitDescriptionBox.Size = new System.Drawing.Size(295, 125);
            this.traitDescriptionBox.TabIndex = 54;
            this.traitDescriptionBox.Text = "";
            // 
            // traitDescriptionLabel
            // 
            this.traitDescriptionLabel.AutoSize = true;
            this.traitDescriptionLabel.Location = new System.Drawing.Point(183, 236);
            this.traitDescriptionLabel.Name = "traitDescriptionLabel";
            this.traitDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.traitDescriptionLabel.TabIndex = 55;
            this.traitDescriptionLabel.Text = "Description";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(183, 399);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(58, 23);
            this.clearButton.TabIndex = 58;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // addTraitButton
            // 
            this.addTraitButton.Location = new System.Drawing.Point(305, 399);
            this.addTraitButton.Name = "addTraitButton";
            this.addTraitButton.Size = new System.Drawing.Size(71, 23);
            this.addTraitButton.TabIndex = 57;
            this.addTraitButton.Text = "Add Trait";
            this.addTraitButton.UseVisualStyleBackColor = true;
            // 
            // addToCollectionButton
            // 
            this.addToCollectionButton.Location = new System.Drawing.Point(382, 399);
            this.addToCollectionButton.Name = "addToCollectionButton";
            this.addToCollectionButton.Size = new System.Drawing.Size(96, 23);
            this.addToCollectionButton.TabIndex = 56;
            this.addToCollectionButton.Text = "Add to Collection";
            this.addToCollectionButton.UseVisualStyleBackColor = true;
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesButton.Location = new System.Drawing.Point(12, 399);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(85, 23);
            this.saveChangesButton.TabIndex = 59;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            // 
            // EditTraitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 434);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addTraitButton);
            this.Controls.Add(this.addToCollectionButton);
            this.Controls.Add(this.traitDescriptionLabel);
            this.Controls.Add(this.traitDescriptionBox);
            this.Controls.Add(this.traitNameBox);
            this.Controls.Add(this.newTraitLabel);
            this.Controls.Add(this.addedTraitsLabel);
            this.Controls.Add(this.editCollectionButton);
            this.Controls.Add(this.removeCollectionButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addTraitsCollectionButton);
            this.Controls.Add(this.addedTraitsListView);
            this.Controls.Add(this.traitsListView);
            this.Name = "EditTraitsForm";
            this.Text = "Edit Traits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addedTraitsLabel;
        private System.Windows.Forms.Button editCollectionButton;
        private System.Windows.Forms.Button removeCollectionButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addTraitsCollectionButton;
        private System.Windows.Forms.ListView addedTraitsListView;
        private System.Windows.Forms.ColumnHeader addedTraitsNameHeader;
        private System.Windows.Forms.ListView traitsListView;
        private System.Windows.Forms.ColumnHeader traitsNameHeader;
        private System.Windows.Forms.ColumnHeader traitsDescriptionHeader;
        private System.Windows.Forms.Label newTraitLabel;
        private System.Windows.Forms.TextBox traitNameBox;
        private System.Windows.Forms.RichTextBox traitDescriptionBox;
        private System.Windows.Forms.Label traitDescriptionLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addTraitButton;
        private System.Windows.Forms.Button addToCollectionButton;
        private System.Windows.Forms.Button saveChangesButton;
    }
}
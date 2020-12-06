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
    public partial class EditTraitsForm : Form
    {
        public event Action updateStatBlockForm;

        // Traits for both listviews are stored here
        private List<Trait> addedTraitsList;
        private List<Trait> traitCollectionList;

        public EditTraitsForm()
        {
            InitializeComponent();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter w = new StreamWriter("traits.json"))
            {
                string json = JsonConvert.SerializeObject(traitCollectionList, Formatting.Indented);
                w.Write(json);
            }

            StatBlockForm.addedTraitsList = addedTraitsList;
            updateStatBlockForm();
            this.Close();
        }
    }
}

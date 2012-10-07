using Orchard.ContentManagement;

namespace Orchard.Core.Common.Models {
    public class BodyPart : ContentPart<BodyPartRecord> {
        public string Text {
            get { return Record.Text; }
            set { Record.Text = value; }
        }


        public string Choice
        {
            get { return Record.Choice; }
            set { Record.Choice = value; }
        }
        public string Choice2
        {
            get { return Record.Choice2; }
            set { Record.Choice2 = value; }
        }

    }
}

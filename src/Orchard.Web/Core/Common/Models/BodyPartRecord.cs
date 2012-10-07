using Orchard.ContentManagement.Records;
using Orchard.Data.Conventions;

namespace Orchard.Core.Common.Models {
    public class BodyPartRecord : ContentPartVersionRecord {
        [StringLengthMax]
        public virtual string Text { get; set; }
<<<<<<< .mine
        public virtual string Choice { get; set; }
=======
        public virtual string Choice { get; set; }
        public virtual string Choice2 { get; set; }
>>>>>>> .r27

        public virtual string Format { get; set; }
    }
}
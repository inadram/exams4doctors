using Orchard.ContentManagement.Records;
using Orchard.Data.Conventions;

namespace Orchard.Core.Common.Models {
    public class BodyPartRecord : ContentPartVersionRecord {
        [StringLengthMax]
        public virtual string Text { get; set; }
        public virtual string Choice { get; set; }
        public virtual string Choice2 { get; set; }
        public virtual string Format { get; set; }
    }
}
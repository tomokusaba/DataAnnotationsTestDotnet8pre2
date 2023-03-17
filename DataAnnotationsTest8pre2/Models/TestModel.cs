using System.ComponentModel.DataAnnotations;

namespace DataAnnotationsTest8pre2.Models
{
    public class TestModel
    {
        [Required(DisallowAllDefaultValues = true)]
        public DateOnly Col1 { get; set; } //= DateOnly.FromDateTime(DateTime.Now);
        [Range(0, 10, MinimumIsExclusive = false, MaximumIsExclusive = false)]
        public int Col2 { get; set; }
        [Range(0, 10, MinimumIsExclusive = true, MaximumIsExclusive = true)]
        public int Col3 { get; set; }
        [Length(8,20)]
        public string Col4 { get; set; } = "password";
        [AllowedValues("Microsoft","Apple","Amazon","Facebook","Google")]
        public string Col5 { get; set; } = "Microsoft";
        [DeniedValues("Excel", "Word")]
        public string Col6 { get; set; } = "PowerPoint";
    }
}

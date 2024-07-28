namespace ApsiyonKasif.Core.DTOs.RequestDto
{
    public record BillDto
    {
        public string BillType { get; set; }
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }
    }
}

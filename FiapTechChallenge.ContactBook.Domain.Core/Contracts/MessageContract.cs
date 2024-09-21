namespace FiapTechChallenge.ContactBook.Domain.Core.Contracts
{
    public record MessageContract
    {
        public Guid Id { get; init; } = Guid.NewGuid();

        public DateTime CreationDate { get; init; } = DateTime.UtcNow;
        public string Phone { get; init; } = "";
        public string Message { get; init; } = "";
    }
}

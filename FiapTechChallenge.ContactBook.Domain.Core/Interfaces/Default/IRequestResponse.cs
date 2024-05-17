namespace FiapTechChallenge.ContactBook.Domain.Core.Interfaces.Default
{
    public interface IRequestResponse<T>
    {
        public T Data { get; set; }
        public bool IsPaginated { get; set; }
    }
}

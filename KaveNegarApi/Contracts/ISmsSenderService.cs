using Kavenegar;
using Kavenegar.Models;

namespace KaveNegarApi.Contracts
{
    public interface ISmsSenderService
    {
        public KavenegarApi KavenegarApi { get; set; }
    }
}

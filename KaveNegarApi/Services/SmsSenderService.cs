using Kavenegar;
using KaveNegarApi.Contracts;
using Microsoft.Extensions.Options;

namespace KaveNegarApi.Services
{
    public class SmsSenderService : ISmsSenderService
    {
        public SmsSenderService(IOptions<KaveNegarOption> option)
        {
            KavenegarApi = new KavenegarApi(option.Value.ApiKey);
        }

        public KavenegarApi KavenegarApi { get; set; }
    }
}

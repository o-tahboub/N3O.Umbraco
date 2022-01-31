using Refit;
using System.Threading.Tasks;

namespace N3O.Umbraco.Payments.Opayo.Client {
    public interface IOpayoClient {
        [Post("/api/v1/merchant-session-keys")]
        Task<ApiMerchantSessionKeyRes> GetMerchantSessionKeyAsync(ApiMerchantSessionKeyReq req);
        
        [Get("/api/v1/transactions/{transactionId}")]
        Task<ApiTransactionRes> GetTransactionByIdAsync(string transactionId);

        [Post("/api/v1/transactions/{req.TransactionId}/3d-secure-challenge/")]
        Task<ApiTransactionRes> ThreeDSecureChallengeAsync(ApiThreeDSecureChallenge req);
        
        [Post("/api/v1/transactions")]
        Task<ApiTransactionRes> TransactionAsync(ApiPaymentTransactionReq req);
    }
}
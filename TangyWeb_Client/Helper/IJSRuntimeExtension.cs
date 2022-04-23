using Microsoft.JSInterop;

namespace TangyWeb_Client.Helper
{
    public static class IJSRuntimeExtension
    {
        public static async ValueTask ToastrSuccess(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowToastr", "success", message);
        }

        public static async ValueTask ToastrError(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowToastr", "error", message);
        }

        public static async ValueTask StripePayment(this IJSRuntime jsRuntime, string sessionId)
        {
            await jsRuntime.InvokeVoidAsync("redirectToCheckout", sessionId);
        }
    }
}

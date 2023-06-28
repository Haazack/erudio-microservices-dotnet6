using GeekShopping.MessageBus;

namespace GeekShopping.OrderAPI.Messages
{
    public class UpdatePaymentResultVO : BaseMessage
    {
        public Guid OrderId { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
    }
}

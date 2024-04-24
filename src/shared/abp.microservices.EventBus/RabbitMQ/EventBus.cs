namespace abp.microservices.EventBus.RabbitMQ;

public class EventBus
{
    public const string Channel = "abp.microservervice.{0}";
    public const string DeadLetterChannel = "abp.microservervice.deadletter.{0}";
}
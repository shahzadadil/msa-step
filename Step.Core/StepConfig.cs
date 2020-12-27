namespace Step.Core
{
    public abstract class StepConfig
    {
        public StepConfig(RetryConfig retryConfig)
        {
            // This can be null, so no validations here
            this.RetryConfig = retryConfig ?? new RetryConfig(1, 0);
        }

        public RetryConfig RetryConfig { get; private set; }
    }
}
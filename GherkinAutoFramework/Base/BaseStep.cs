using GherkinAutoFramework.Config;

namespace GherkinAutoFramework.Base
{
    public abstract class BaseStep : BasePage
    {
        private readonly ParallelConfig _parallel;

        public BaseStep(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallel = parellelConfig;
        }

        public virtual void NavigateSite()
        {
            _parallel.Driver.Url = Settings.AUT;
            _parallelConfig.Log.Info("Browser started!!");
        }
    }
}
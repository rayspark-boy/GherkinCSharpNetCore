using GherkinAutoFramework.Base;
using TechTalk.SpecFlow;

namespace GherkinTestProject.Steps
{
    [Binding]
    public sealed class ExampleSteps : BaseStep
    {
        public ExampleSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

    }
}
using GherkinAutoFramework.Base;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using GherkinTestProject.Pages;

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
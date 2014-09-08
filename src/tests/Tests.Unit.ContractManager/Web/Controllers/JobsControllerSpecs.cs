using ContractManager.Web.Controllers;
using NUnit.Framework;
using SpecsFor;
using TestStack.FluentMVCTesting;

namespace Tests.Unit.ContractManager.Web.Controllers
{
    public class JobsControllerSpecs : SpecsFor<JobsController>
    {
        private ControllerResultTest<JobsController> Result;
        
        protected override void When()
        {
             Result = SUT.WithCallTo(c => c.Index());
        }

        [Test]
        public void Then_should_render_default_view()
        {
            Result.ShouldRenderDefaultView();
        }
    }
}

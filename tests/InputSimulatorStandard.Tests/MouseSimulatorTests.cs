namespace InputSimulatorStandard.Tests
{
    using System;

    using Moq;

    using Xunit;

    public class MouseSimulatorTests
    {
        private IMouseSimulator mouseSimulator;

        public MouseSimulatorTests()
        {
            this.mouseSimulator = new MouseSimulator(Mock.Of<IInputMessageDispatcher>());
        }

        public class Constructor : MouseSimulatorTests
        {
            [Fact]
            public void NullMessageDispatcherThrowsInvalidOperationException()
            {
                Assert.Throws<InvalidOperationException>(() => this.mouseSimulator = new MouseSimulator(null));
            }
        }
    }
}

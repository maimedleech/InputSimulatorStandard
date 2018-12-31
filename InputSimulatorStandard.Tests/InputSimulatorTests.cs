namespace InputSimulatorStandard.Tests
{
    using System;

    using Moq;

    using Xunit;

    public class InputSimulatorTests
    {
        private IInputSimulator inputSimulator;

        public InputSimulatorTests()
        {
            this.inputSimulator = new InputSimulator(Mock.Of<IKeyboardSimulator>(), Mock.Of<IMouseSimulator>(), Mock.Of<IInputDeviceStateAdapter>());
        }

        public class Constructor : InputSimulatorTests
        {
            [Fact]
            public void NullKeyboardSimulatorThrowsArgumentNullException()
            {
                Assert.Throws<ArgumentNullException>("keyboardSimulator", () =>
                {
                    this.inputSimulator = new InputSimulator(null, Mock.Of<IMouseSimulator>(), Mock.Of<IInputDeviceStateAdapter>());
                });
            }

            [Fact]
            public void NullMouseSimulatorThrowsArgumentNullException()
            {
                Assert.Throws<ArgumentNullException>("mouseSimulator", () =>
                {
                    this.inputSimulator = new InputSimulator(Mock.Of<IKeyboardSimulator>(), null, Mock.Of<IInputDeviceStateAdapter>());
                });
            }

            [Fact]
            public void NullInputDeviceStateAdapterThrowsArgumentNullException()
            {
                Assert.Throws<ArgumentNullException>("inputDeviceStateAdapter", () =>
                {
                    this.inputSimulator = new InputSimulator(Mock.Of<IKeyboardSimulator>(), Mock.Of<IMouseSimulator>(), null);
                });
            }
        }
    }
}

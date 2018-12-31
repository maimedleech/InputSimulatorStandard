namespace InputSimulatorStandard.Tests
{
    using Native;

    using Xunit;

    public class InputBuilderTests
    {
        [Fact]
        public void AddKeyDown()
        {
            var builder = new InputBuilder();
            Assert.Empty(builder.ToArray());
            builder.AddKeyDown(VirtualKeyCode.VK_A);
            Assert.Single(builder);
            Assert.Equal((uint)InputType.Keyboard, builder[0].Type);
            Assert.Equal((ushort)VirtualKeyCode.VK_A, builder[0].Data.Keyboard.KeyCode);
        }
    }
}

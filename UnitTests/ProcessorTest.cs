using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculators;
using Xunit;
using Moq;
using FluentAssertions;

namespace UnitTests
{
    public class ProcessorTest
    {
        [Fact]
        public void WhenAddingATaskThenFinishCalled()
        {
            var testee = new Processor();
            testee.MonitorEvents();
            var taskMock = new TaskMock(true);

            testee.Execute(taskMock);

            testee.ShouldRaise("Finished");
        }

        [Fact]
        public void WhenAddingATaskThatFailsThenFinishIsNotCalled()
        {
            var testee = new Processor();
            testee.MonitorEvents();
            var taskMock = new Mock<ITask>();
            taskMock
                .Setup(task => task.WasSuccessful())
                .Returns(false);


            testee.Execute(taskMock.Object);

            testee.ShouldNotRaise("Finished");
        }

        [Fact]
        public void WhenAddingATaskThenDoShouldBeCalledWithHello()
        {
            var testee = new Processor();
            var taskMock = new Mock<ITask>();

            testee.Execute(taskMock.Object);

            taskMock.Verify(task => task.Do("Hello"));
        }
    }

    internal class TaskMock : ITask
    {
        public TaskMock(bool value)
        {
            Value = value;
        }

        public bool Value { get; }

        public void Do(string val)
        {
            throw new NotImplementedException();
        }

        public bool WasSuccessful()
        {
            return Value;
        }
    }
}

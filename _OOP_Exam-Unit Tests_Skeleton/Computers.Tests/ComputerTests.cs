namespace Computers.Tests
{
    using NUnit.Framework;
    using System;

    public class ComputerTests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TestConstructorWorksProperly()
        {
            string expectedName = "Pesho";

            Computer computer = new Computer("Pesho");

            Assert.AreEqual(expectedName, computer.Name);
        }

        [Test]
        public void TestConstructorThrowsExceptionIfNameEmptyWhispace()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                Computer computer = new Computer("");
                Computer computer2 = new Computer("          ");
            });
        }
        [Test]
        public void ComputerAddsPartProperly()
        {
            Computer computer = new Computer("Pesho");

            Part part1 = new Part("CPU", 10.5m);            

            computer.AddPart(part1);

            int expectedCount = 1;            

            Assert.AreEqual(expectedCount, computer.Parts.Count);
        }

        [Test]
        public void ComputerAddPartThrowsExceptionIfNull()
        {
            Computer computer = new Computer("Pesho");


            Assert.Throws<InvalidOperationException>(() =>
            {
                computer.AddPart(null);
            });            
        }

        [Test]
        public void TestComputerReturnsTotalPriceProperly()
        {
            Computer computer = new Computer("Pesho");

            Part part1 = new Part("CPU", 10.5m);
            Part part2 = new Part("MB", 10.44m);

            computer.AddPart(part1);
            computer.AddPart(part2);

            decimal expectedSum = part1.Price + part2.Price;

            Assert.AreEqual(expectedSum, computer.TotalPrice);
        }

        [Test]
        public void ComputerRemovesPartProperly()
        {
            Computer computer = new Computer("Pesho");

            Part part1 = new Part("CPU", 10.5m);

            computer.AddPart(part1);

            computer.RemovePart(part1);

            int expectedCount = 0;

            Assert.AreEqual(expectedCount, computer.Parts.Count);
        }

        [Test]
        public void ComputerTriesToRemoveNonExistingPartReturnsFalse()
        {
            Computer computer = new Computer("Pesho");

            Part part1 = new Part("CPU", 10.5m);

            bool actualState = computer.RemovePart(part1);

            bool expectedState = false;

            Assert.AreEqual(expectedState, actualState);
        }


        [Test]
        public void ComputerReturnsPartProperly()
        {
            Computer computer = new Computer("Pesho");

            Part part1 = new Part("CPU", 10.5m);

            computer.AddPart(part1);

            Assert.AreEqual(part1, computer.GetPart("CPU"));
        }
    }
}
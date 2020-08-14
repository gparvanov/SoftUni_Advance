namespace Presents.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    public class PresentsTests
    {
        [Test]
        public void CreatePresentShouldWorkProperly()
        {
            Bag bag = new Bag();

            Present present = new Present("Vapa", 10.5);

            string expectedString = $"Successfully added present {present.Name}.";

            string actualString = bag.Create(present);

            Assert.AreEqual(expectedString, actualString);
        }

        [Test]
        public void CreatePresentShouldThrowsExceptionIfNullPresent()
        {
            Bag bag = new Bag();

            Assert.Throws<ArgumentNullException>(() =>
            {
                bag.Create(null);
            });
        }

        [Test]
        public void CreatePresentThrowsExceptionIfPresentExists()
        {
            Bag bag = new Bag();

            Present present = new Present("Vapa", 10.5);
            bag.Create(present);

            Assert.Throws<InvalidOperationException>(() =>
            {
                bag.Create(present);
            });
        }

        [Test]

        public void RemovePresentWorkProperly()
        {
            Bag bag = new Bag();

            Present present = new Present("Vapa", 10.5);
            bag.Create(present);

            bool expectedState = true;

            bool actualState = bag.Remove(present);

            Assert.AreEqual(expectedState, actualState);
        }

        [Test]

        public void RemovePresentWorkProperlyIfPresentNotExists()
        {
            Bag bag = new Bag();

            Present present = new Present("Vapa", 10.5);            

            bool expectedState = false;

            bool actualState = bag.Remove(present);

            Assert.AreEqual(expectedState, actualState);
        }

        [Test]
        public void GetPresentWithleastMagicReturnsSmallestMagicProperly()
        {
            Bag bag = new Bag();

            Present present = new Present("Vapa", 10.5);
            Present present1 = new Present("Vapa2", 11.5);
            Present present2 = new Present("Vapa1", 8.5);
            Present present3 = new Present("Vapa3", 21.5);


            bag.Create(present);
            bag.Create(present1);
            bag.Create(present2);
            bag.Create(present3);

            Assert.AreEqual(present2, bag.GetPresentWithLeastMagic());
        }


        [Test]
        public void GetPresentReturnsFirstElement()
        {
            Bag bag = new Bag();

            Present present = new Present("Vapa", 10.5);
            Present present1 = new Present("Vapa2", 11.5);

            bag.Create(present);
            bag.Create(present1);           

            Assert.AreEqual(present1, bag.GetPresent("Vapa2"));
        }

        [Test]

        public void GetPresentsReturnsColletionAsReadOnly()
        {
            Bag bag = new Bag();

            Present present = new Present("Vapa", 10.5);
            Present present1 = new Present("Vapa2", 11.5);

            bag.Create(present);
            bag.Create(present1);

            var returnedCollection = bag.GetPresents();

            Assert.That(returnedCollection is IReadOnlyCollection<Present>);
        }
    }
}

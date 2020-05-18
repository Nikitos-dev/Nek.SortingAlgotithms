using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructure.Tests
{
    [TestClass()]
    public class SortTests
    {
        Random rnd = new Random();
        List<int> Items = new List<int>();
        List<int> Sorted = new List<int>();

        [TestInitialize]
        public void Init()
        {
            Items.Clear();
            for (int i = 0; i < 10000; i++)
            {
                Items.Add(rnd.Next(0, 100));

            }

            Sorted.Clear();
            Sorted.AddRange(Items.OrderBy(n => n).ToArray());
        }


        [TestMethod()]
        public void BubbleSortTest()
        {
            // Arrange
            var bubble = new BubbleSort<int>();
            bubble.Items.AddRange(Items);

            // Act
            bubble.Sort();

            // Assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], bubble.Items[i]);

            }

        }
        [TestMethod()]
        public void CocktailSortTest()
        {
            // Arrange
            var cocktail = new CocktailSort<int>();
            cocktail.Items.AddRange(Items);

            // Act
            cocktail.Sort();

            // Assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], cocktail.Items[i]);

            }

        }
        [TestMethod()]
        public void InsertSortTest()
        {
            // Arrange
            var insert = new InsertSort<int>();
            insert.Items.AddRange(Items);

            // Act
            insert.Sort();

            // Assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], insert.Items[i]);

            }

        }
        [TestMethod()]
        public void ShellSortTest()
        {
            // Arrange
            var shell = new ShellSort<int>();
            shell.Items.AddRange(Items);

            // Act
            shell.Sort();

            // Assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], shell.Items[i]);

            }

        }

        [TestMethod()]
        public void BaseSortTest()
        {
            // Arrange
            var bases = new AlgorithmBase<int>();
            bases.Items.AddRange(Items);

            // Act
            bases.Sort();

            // Assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], bases.Items[i]);

            }

        }
        [TestMethod()]
        public void TreeSortTest()
        {
            // Arrange
            var tree = new Tree<int>(Items);

            // Act
            tree.Sort();

            // Assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], tree.Items[i]);

            }

        }

        [TestMethod()]
        public void HeapSortTest()
        {
            // Arrange
            var heap = new Heap<int>(Items);

            // Act
            heap.Sort();

            // Assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], heap.Items[i]);

            }

        }

        [TestMethod()]
        public void SelectionSortTest()
        {
            // Arrange
            var select = new SelectionSort<int>();
            select.Items.AddRange(Items);

            // Act
            select.Sort();

            // Assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], select.Items[i]);

            }

        }

        [TestMethod()]
        public void GnomeSortTest()
        {
            // Arrange
            var gnome = new GnomeSort<int>();
            gnome.Items.AddRange(Items);

            // Act
            gnome.Sort();

            // Assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], gnome.Items[i]);

            }

        }

        [TestMethod()]
        public void LSDRadixSortTest()
        {
            // Arrange
            var lsdRadix = new LSDRadixSort<int>();
            lsdRadix.Items.AddRange(Items);

            // Act
            lsdRadix.Sort();

            // Assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], lsdRadix.Items[i]);

            }

        }

        [TestMethod()]
        public void MSDRadixSortTest()
        {
            // Arrange
            var msdRadix = new MSDRadixSort<int>();
            msdRadix.Items.AddRange(Items);

            // Act
            msdRadix.Sort();

            // Assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], msdRadix.Items[i]);

            }

        }

        [TestMethod()]
        public void MergeSortTest()
        {
            // Arrange
            var merge = new MergeSort<int>();
            merge.Items.AddRange(Items);

            // Act
            merge.Sort();

            // Assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], merge.Items[i]);

            }

        }

        [TestMethod()]
        public void QuickSortTest()
        {
            // Arrange
            var quick = new QuickSort<int>();
            quick.Items.AddRange(Items);

            // Act
            quick.Sort();

            // Assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], quick.Items[i]);

            }

        }
    }
}
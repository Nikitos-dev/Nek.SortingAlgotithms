using Algorithm;
using Algorithm.DataStructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nek.Sortings
{
    public partial class Form1 : Form
    {

        private List<SortedItem> items = new List<SortedItem>();
        
        public int Sleep { get => (int)numericUpDown1.Value; set => numericUpDown1.Value = value; }

        public Form1()
        {
            InitializeComponent();
        }



        private void AddButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AddTextBox.Text, out int value))
            {
                var item = new SortedItem(value, items.Count);
                items.Add(item);
            }

            RefreshItems();
            AddTextBox.Text = "";
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(FillTextBox.Text, out int value))
            {
                var rnd = new Random();
                
                for (int i = 0; i < value; i++)
                {

                    var item = new SortedItem(rnd.Next(0, 100), items.Count);
                    items.Add(item);
                }

                DrawItems(items);
                

            }

            AddTextBox.Text = "";
        }

        private void DrawItems(List<SortedItem> items)
        {
            panel3.Controls.Clear();

            foreach (var item in items)
            {
                panel3.Controls.Add(item.ProgressBar);
                panel3.Controls.Add(item.Label);
            }
        }

        private void BubbleSortButton_Click(object sender, EventArgs e)
        {
            var bubble = new BubbleSort<SortedItem>(items);
            BtnClick(bubble);
            
        }

        private void AlgorithmSwapEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            var temp = e.Item1.Number;
            e.Item1.SetPosition(e.Item2.Number);
            e.Item2.SetPosition(temp);
            e.Item1.SetColor(Color.Green);
            e.Item2.SetColor(Color.Green);
            panel3.Refresh();

            Thread.Sleep(Sleep);

            e.Item1.SetColor(Color.Blue);
            e.Item2.SetColor(Color.Blue);
            panel3.Refresh();

        }

        private void RefreshItems()
        {
            foreach(var item in items)
            {
                item.Refresh();
            }

            DrawItems(items);
        }

        private void AlgorithmCompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Red);
            panel3.Refresh();

            Thread.Sleep(Sleep);

            e.Item1.SetColor(Color.Blue);
            e.Item2.SetColor(Color.Blue);
            panel3.Refresh();
        }

        private void AlgorithmSetEvent(object sender, Tuple<int, SortedItem> e)
        {
            e.Item2.SetColor(Color.Green);
            panel3.Refresh();

            Thread.Sleep(Sleep);

            e.Item2.SetPosition(e.Item1);
            panel3.Refresh();

            Thread.Sleep(Sleep);

            e.Item2.SetColor(Color.Blue);
            panel3.Refresh();

            Thread.Sleep(Sleep);
        }
        private void CocktailSortButton_Click(object sender, EventArgs e)
        {
            var cocktail = new CocktailSort<SortedItem>(items);
            BtnClick(cocktail);
        }

        private void BtnClick(AlgorithmBase<SortedItem> algorithm)
        {
            RefreshItems();
            for (int i = 0; i < algorithm.Items.Count; i++)
            {
                algorithm.Items[i].SetPosition(i);
            }

            panel3.Refresh();

            algorithm.CompareEvent += AlgorithmCompareEvent;
            algorithm.SwapEvent += AlgorithmSwapEvent;
            algorithm.SetEvent += AlgorithmSetEvent;
            var time = algorithm.Sort();

            TimeLabel.Text = "Время: " + time.Seconds;
            SwapLabel.Text = "Количество обменов: " + algorithm.SwapCount;
            CompareLabel.Text = "Количесвто сравнений: " + algorithm.ComparisonCount;

            
        }

        private void InsertSortButton_Click(object sender, EventArgs e)
        {
            var insert = new InsertSort<SortedItem>(items);
            BtnClick(insert);
        }

        private void ShellSortButton_Click(object sender, EventArgs e)
        {
            var shell = new ShellSort<SortedItem>(items);
            BtnClick(shell);
        }

        private void SelectionSortButton_Click(object sender, EventArgs e)
        {
            var selection = new SelectionSort<SortedItem>(items);
            BtnClick(selection);
        }

        private void HeapSortButton_Click(object sender, EventArgs e)
        {
            var heap = new Heap<SortedItem>(items);

            BtnClick(heap);
        }

        private void GnomeSortButton_Click(object sender, EventArgs e)
        {
            var gnome = new GnomeSort<SortedItem>(items);

            BtnClick(gnome);
        }

        private void TreeSortButton_Click(object sender, EventArgs e)
        {
            var tree = new Tree<SortedItem>(items);

            BtnClick(tree);
        }

        private void LSDRadixSortButton_Click(object sender, EventArgs e)
        {
            var lsd = new LSDRadixSort<SortedItem>(items);

            BtnClick(lsd);
        }

        private void MSDRadixSortButton_Click(object sender, EventArgs e)
        {
            var msd = new MSDRadixSort<SortedItem>(items);

            BtnClick(msd);
        }

        private void MergeSortButton_Click(object sender, EventArgs e)
        {
            var merge = new MergeSort<SortedItem>(items);

            BtnClick(merge);
        }

        private void QuickSortButton_Click(object sender, EventArgs e)
        {
            var quick = new QuickSort<SortedItem>(items);

            BtnClick(quick);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Sleep = (int)numericUpDown1.Value;
        }

        private void BaseSortButton_Click(object sender, EventArgs e)
        {
            var bases = new AlgorithmBase<SortedItem>(items);

            BtnClick(bases);
        }
    }
}

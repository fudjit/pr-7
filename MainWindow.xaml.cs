using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pr_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Triad firstTriad = new();
        Triad secondTriad = new();
        Date firstDate;
        Date secondDate;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void compare_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (firstTriad > secondTriad)
                    MessageBox.Show("Первая тройка больше второй");
                else MessageBox.Show("Первая тройка не больше второй");
            }
            catch
            {
                MessageBox.Show("Создайте тройки", "Ошибка");
            }
        }

        private void increase10Times_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                firstTriad++;
                inputFnFirst.Text = firstTriad.First.ToString();
                inputFnSecond.Text = firstTriad.Second.ToString();
                inputFnThird.Text = firstTriad.Third.ToString();
                secondTriad++;
                inputSnFirst.Text = secondTriad.First.ToString();
                inputSnSecond.Text = secondTriad.Second.ToString();
                inputSnThird.Text = secondTriad.Third.ToString();
            }
            catch
            {

                MessageBox.Show("Создайте тройки", "Ошибка");
            }

        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №5\n" +
                "Даанов Шахмар  ИСП-34\n" +
                "Создать класс Triad (тройка чисел). Создать необходимые методы и свойства. Определить метод сравнения триад: " +
                "триада p1 больше триады р2, если (first.pl > first.р2) или (first.pl = first.р2) и (second.pl > second.р2) и (three.pl > three.р2)." +
                " Создать перегруженные методы SetParams, для установки параметров объекта, в том числе увеличения всех чисел на 10.", "О программе", MessageBoxButton.OK);
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            firstTriad.Clear();
            secondTriad.Clear();
            inputFnFirst.Clear();
            inputFnSecond.Clear();
            inputFnThird.Clear();
            inputSnFirst.Clear();
            inputSnSecond.Clear();
            inputSnThird.Clear();

        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void create_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int fFirst = int.Parse(inputFnFirst.Text);
                int fSecond = int.Parse(inputFnSecond.Text);
                int fThird = int.Parse(inputFnThird.Text);
                firstTriad.SetParams(fFirst, fSecond, fThird);
                int sFirst = int.Parse(inputSnFirst.Text);
                int sSecond = int.Parse(inputSnSecond.Text);
                int sThird = int.Parse(inputSnThird.Text);
                secondTriad.SetParams(sFirst, sSecond, sThird);
                MessageBox.Show("Создано");
            }
            catch
            {
                MessageBox.Show("Проверьте введенные значения", "Ошибка");
            }
        }

        private void createDate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                firstDate = new(firstTriad.First, firstTriad.Second, firstTriad.Third);
                firstDateOutput.Text = $"{firstDate.Day}.{firstDate.Month}.{firstDate.Year}г.";
                secondDate = new(secondTriad.First, secondTriad.Second, secondTriad.Third);
                secondDateOutput.Text = $"{secondDate.Day}.{secondDate.Month}.{secondDate.Year}г.";
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Чтобы создать дату, необходми ввести положительные целые числа(разумные)", "Ошибка");
            }
            catch { }
            
        }

        private void compareDates_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (firstDate > secondDate)
                    MessageBox.Show("Первая дата больше второй");
                else MessageBox.Show("Первая дата меньше второй");
            }
            catch
            {
                MessageBox.Show("Создайте даты", "Ошибка");
            }
        }
    }
}

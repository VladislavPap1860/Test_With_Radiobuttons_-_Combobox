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

namespace Test_With_Radiobuttons___Combobox
{
    public partial class MainWindow : Window
    {
        public int Score = 0;
        private RadioButton[] AllButtons;
        public MainWindow()
        {
            InitializeComponent();
            AllButtons = new RadioButton[]
            {
                q_1_1_W, q_1_2_C, q_1_3_W, q_1_4_W,

                q_2_1_W, q_2_2_W, q_2_3_C, q_2_4_W,

                q_3_1_W, q_3_2_C, q_3_3_W, q_3_4_W,

                q_4_1_W, q_4_2_W, q_4_3_W, q_4_4_C,

                q_5_1_W, q_5_2_W, q_5_3_C, q_5_4_W,

                q_6_1_W, q_6_2_C, q_6_3_W, q_6_4_W,

                q_7_1_W, q_7_2_W, q_7_3_W, q_7_4_C,

                q_8_1_W, q_8_2_W, q_8_3_C, q_8_4_W,

                q_9_1_C, q_9_2_W, q_9_3_W, q_9_4_W,

                q_10_1_W, q_10_2_W, q_10_3_C, q_10_4_W
            };
        }

        private void Check_test(object sender, RoutedEventArgs e)
        {
            if (AreAllQuestionsAnswered() == false) return;
            if (q_1_2_C.IsChecked == true) Score += 1;
            if (q_2_3_C.IsChecked == true) Score += 1;
            if (q_3_2_C.IsChecked == true) Score += 1;
            if (q_4_4_C.IsChecked == true) Score += 1;
            if (q_5_3_C.IsChecked == true) Score += 1;
            if (q_6_2_C.IsChecked == true) Score += 1;
            if (q_7_4_C.IsChecked == true) Score += 1;
            if (q_8_3_C.IsChecked == true) Score += 1;
            if (q_9_1_C.IsChecked == true) Score += 1;
            if (q_10_3_C.IsChecked == true) Score += 1;
            if(q_11.SelectedIndex == 2) Score += 1;
            if (q_12.SelectedIndex == 0) Score += 1;
            if (q_13.SelectedIndex == 1) Score += 1;
            if (q_14.SelectedIndex == 2) Score += 1;
            if (q_15.SelectedIndex == 3) Score += 1;


            q_1_2_C.Background = Brushes.Green;
            q_2_3_C.Background = Brushes.Green;
            q_3_2_C.Background = Brushes.Green;
            q_4_4_C.Background = Brushes.Green;
            q_5_3_C.Background = Brushes.Green;
            q_6_2_C.Background = Brushes.Green;
            q_7_4_C.Background = Brushes.Green;
            q_8_3_C.Background = Brushes.Green;
            q_9_1_C.Background = Brushes.Green;
            q_10_3_C.Background = Brushes.Green;


            foreach (var radio in AllButtons)
            {
                if (radio.IsChecked == true && radio.Background != Brushes.Green)
                {
                    radio.Background = Brushes.Red;
                }
                radio.IsHitTestVisible = false;
            }

            Counter.Text = $"{Score}/15";
            Проверить.IsHitTestVisible = false;






        }

        private void Start_again(object sender, RoutedEventArgs e)
        {
            foreach (var radio in AllButtons)
            {
                radio.Background = Brushes.Transparent;
                radio.IsHitTestVisible = true;
                radio.IsChecked = false;
            }

            q_11.SelectedIndex = 0;
            q_12.SelectedIndex = 0;
            q_13.SelectedIndex = 0;
            q_14.SelectedIndex = 0;
            q_15.SelectedIndex = 0;

            Score = 0;
            Counter.Text = string.Empty;

        }

        private bool AreAllQuestionsAnswered()
        {

            if (!(q_1_1_W.IsChecked == true || q_1_2_C.IsChecked == true ||
                  q_1_3_W.IsChecked == true || q_1_4_W.IsChecked == true))
            {
                MessageBox.Show("Выберите ответ на вопрос 1!");
                return false;
            }

            if (!(q_2_1_W.IsChecked == true || q_2_2_W.IsChecked == true ||
                  q_2_3_C.IsChecked == true || q_2_4_W.IsChecked == true))
            {
                MessageBox.Show("Выберите ответ на вопрос 2!");
                return false;
            }

            if (!(q_3_1_W.IsChecked == true || q_3_2_C.IsChecked == true ||
                  q_3_3_W.IsChecked == true || q_3_4_W.IsChecked == true))
            {
                MessageBox.Show("Выберите ответ на вопрос 3!");
                return false;
            }

            if (!(q_4_1_W.IsChecked == true || q_4_2_W.IsChecked == true ||
                  q_4_3_W.IsChecked == true || q_4_4_C.IsChecked == true))
            {
                MessageBox.Show("Выберите ответ на вопрос 4!");
                return false;
            }

            if (!(q_5_1_W.IsChecked == true || q_5_2_W.IsChecked == true ||
                  q_5_3_C.IsChecked == true || q_5_4_W.IsChecked == true))
            {
                MessageBox.Show("Выберите ответ на вопрос 5!");
                return false;
            }

            if (!(q_6_1_W.IsChecked == true || q_6_2_C.IsChecked == true ||
                  q_6_3_W.IsChecked == true || q_6_4_W.IsChecked == true))
            {
                MessageBox.Show("Выберите ответ на вопрос 6!");
                return false;
            }

            if (!(q_7_1_W.IsChecked == true || q_7_2_W.IsChecked == true ||
                  q_7_3_W.IsChecked == true || q_7_4_C.IsChecked == true))
            {
                MessageBox.Show("Выберите ответ на вопрос 7!");
                return false;
            }

            if (!(q_8_1_W.IsChecked == true || q_8_2_W.IsChecked == true ||
                 q_8_3_C.IsChecked == true || q_8_4_W.IsChecked == true))
            {
                MessageBox.Show("Выберите ответ на вопрос 8!");
                return false;
            }

            if (!(q_9_1_C.IsChecked == true || q_9_2_W.IsChecked == true ||
                 q_9_3_W.IsChecked == true || q_9_4_W.IsChecked == true))
            {
                MessageBox.Show("Выберите ответ на вопрос 9!");
                return false;
            }

            if (!(q_10_1_W.IsChecked == true || q_10_2_W.IsChecked == true ||
                 q_10_3_C.IsChecked == true || q_10_4_W.IsChecked == true))
            {
                MessageBox.Show("Выберите ответ на вопрос 10!");
                return false;
            } 

            return true;
        }

    }
}

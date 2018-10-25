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

namespace vp_lab_10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавляем возможность изменять расположение окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        /// <summary>
        /// Событие при нажатие на кнопку "Close"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Событие при нажатие на кнопку "Delete"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            // Удаление выделенного элемента, если кол-во элементов в списке > 1
            if (listView.Items.Count > 1 && listView.SelectedItem != null) listView.Items.Remove(listView.SelectedItem);
            // Отключаем кнопку удаления, если в списке последний элемент
            if (listView.Items.Count == 1) btn_Delete.IsEnabled = false;
        }

        /// <summary>
        /// Событие при нажатие на кнопку "Copy..."
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Copy_Click(object sender, RoutedEventArgs e)
        {
            // Копируем выделенный элемент
            if (listView.SelectedItem != null)
            {
                listView.Items.Add(listView.SelectedItem);

                // Включаем кнопку удаления
                btn_Delete.IsEnabled = true;
            }
        }

        /// <summary>
        /// Событие при нажатие на кнопку "Rename..."
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Rename_Click(object sender, RoutedEventArgs e)
        {
            if (listView.SelectedItem != null)
            {
                RenameForm renameForm = new RenameForm(listView.SelectedIndex, listView.SelectedItem.ToString(), this);
                renameForm.Show();
            }
        }

        public void Rename(int id, string newValue)
        {
            listView.Items[id] = newValue;
        }
    }
}

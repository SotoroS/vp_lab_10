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
using System.Windows.Shapes;

namespace vp_lab_10
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class RenameForm : Window
    {
        // Главное окно
        MainWindow main;

        // Номер записи в списке
        int id;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="id">Номер записи в списке</param>
        /// <param name="oldValue">Старое значение записи</param>
        /// <param name="main">Ссылка на главное окно</param>
        public RenameForm(int id, string oldValue, MainWindow main)
        {
            InitializeComponent();

            tb_OldValue.Text = oldValue;

            this.main = main;
            this.id = id;
        }

        /// <summary>
        /// Событие при нажатии кнопки "Rename"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Rename_Click(object sender, RoutedEventArgs e)
        {
            main.Rename(id, tb_NewValue.Text);
            Close();
        }
    }
}

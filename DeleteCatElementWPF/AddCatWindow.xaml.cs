using DataContext;
using DataContextEntities;
using DeleteCatElementWPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DeleteCatElementWPF
{
    /// <summary>
    /// Interaction logic for AddCatWindow.xaml
    /// </summary>
    public partial class AddCatWindow : Window
    {
        private EFDataContext _context;
        public ObservableCollection<CatModel> _cats { get; set; }
        public AddCatWindow(EFDataContext context, ObservableCollection<CatModel> cats)
        {
            InitializeComponent();
            _context = context;
            _cats = cats;
            this.txtName.TextChanged += TextChanged;
            this.txtImgUrl.TextChanged += TextChanged;
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtName.Text))
            {
                this.brdName.BorderBrush = Brushes.Red;
            }
            else 
            {
                this.brdName.BorderBrush = Brushes.LimeGreen;
            }

            if (string.IsNullOrEmpty(this.txtImgUrl.Text) || !this.txtImgUrl.Text.StartsWith("http"))
            {
                this.brdImgUrl.BorderBrush = Brushes.Red;
            }
            else
            {
                this.brdImgUrl.BorderBrush = Brushes.LimeGreen;
            }
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string name = this.txtName.Text;
            string url = this.txtImgUrl.Text;
            DateTime date;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Заповніть усі поля!");
                return;
            }
            if (this.DateBirthday.SelectedDate.HasValue)
            {
                date = this.DateBirthday.SelectedDate.Value;
            }
            else 
            {
                date = DateTime.Now;
            }
            if (!url.StartsWith("http")) 
            {
                MessageBox.Show("Некоректно введена силка!");
                return;
            }
            var el = new AppCat
            {
                Name = name,
                ImgUrl = url,
                Birthday = date
            };
            this._context.Add(el);

            this._context.SaveChanges();
            _cats.Add(new CatModel { 
            Name = name,
            Birthday = date,
            ImgUrl = url,
            Id = el.Id
            });

            this.Close();

        }
    }
}

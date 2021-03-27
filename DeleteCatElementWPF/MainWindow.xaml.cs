using DataContext;
using DataContext.Services;
using DeleteCatElementWPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DeleteCatElementWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public EFDataContext _context { get; set; }
        public ObservableCollection<CatModel> _cats { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            _context = new EFDataContext();
            DbSeeder.SeedAll(_context);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.dgCats.CanUserAddRows = false;
            FillData();
        }

        private void FillData() 
        {
            this.dgCats.Items.Clear();
            var list = _context.cats.Select(x => new CatModel
            {
                Name = x.Name,
                ImgUrl = x.ImgUrl,
                Birthday = x.Birthday,
                Id = x.Id
            }).ToList();
            _cats = new ObservableCollection<CatModel>(list);
            this.dgCats.ItemsSource = _cats;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddCatWindow dlg = new AddCatWindow(_context, _cats);
            dlg.ShowDialog();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            if (dgCats.SelectedItems.Count > 0)
            {
                foreach (var item in dgCats.SelectedItems)
                {
                    if (item is CatModel)
                    {
                        CatModel cat = item as CatModel;
                        _cats = new ObservableCollection<CatModel>(_cats.Where(x => x.Id != cat.Id).ToList());
                        _context.cats.Remove(_context.cats.FirstOrDefault(x => x.Id == cat.Id));
                        _context.SaveChanges();
                        GC.Collect();
                    }
                }
                this.dgCats.ItemsSource = _cats;
            }
            else 
            {
                MessageBox.Show("Оберіть елемент, який ви хочете видалити!");
            }
        }

    }
}

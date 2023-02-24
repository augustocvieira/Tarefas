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
using Tarefas.Application.Interfaces.Services;

namespace Tarefas.Presentation.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ITarefaService _trefaService;

        public MainWindow(ITarefaService trefaService) : base()
        {
            _trefaService = trefaService;
            InitializeComponent();
            TestaTarefas();
        }

        private async void TestaTarefas()
        {
            await _trefaService.ObterTarefasAsync();
        }
    }
}

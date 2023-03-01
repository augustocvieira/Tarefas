using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using Tarefas.Domain.Interfaces.Repositories;
using Tarefas.Domain.Interfaces.Services;

namespace Tarefas.Presentation.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ITarefaService _trefaService;
        private readonly IRepositoryManager _repositoryManager;

        public MainWindow(ITarefaService trefaService, IRepositoryManager repositoryManager)
        {
            _trefaService = trefaService;
            _repositoryManager = repositoryManager;
            InitializeComponent();
            TestaIoC();
        }

        private async void TestaIoC()
        {
            var repo = _repositoryManager.StatusRepository;
            var result = await repo.GetAll(CancellationToken.None);
            Console.WriteLine("Tes");
        }
    }
}

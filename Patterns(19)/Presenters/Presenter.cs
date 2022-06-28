using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns_19_.Data;
using Patterns_19_.Models;

namespace Patterns_19_.Presenters
{
    internal class Presenter
    {
        #region Поля

        private MainWindow mainWindow;
        private AnimalFactory animalFactory;
        private Repository repository;
        private Model model;

        #endregion

        public Presenter(MainWindow m)
        {
            mainWindow = m;
            animalFactory = new AnimalFactory();
            repository = new Repository();
            model = new Model();

            //Небольшой список, чтобы не вводить данные
            repository.animals.Add(new Mammal("Олень"));
            repository.animals.Add(new Bird("Синичка"));

            mainWindow.CreateEvent += Handler;
            mainWindow.ShowListEvent += Show;
            mainWindow.SaveTxtEvent += SaveTxtHandler;
            mainWindow.SaveDocxEvent += SaveDocxHandler;

        }


        #region Методы
        public void Handler()
        {
            repository.animals.Add(animalFactory.
                                   Create(mainWindow.animalType.Text,
                                          mainWindow.animalName.Text));

            mainWindow.animalType.Text = "";
            mainWindow.animalName.Text = "";
        }

        public void Show()
        {
            mainWindow.dataGrid.ItemsSource = repository.animals.ToList();
        }

        public void SaveTxtHandler()
        {
            model.SaveTxt(repository.animals);
        }

        public void SaveDocxHandler()
        {
            model.SaveDocx(repository.animals);
        }

        #endregion

    }
}

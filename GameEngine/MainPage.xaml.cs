using Microsoft.Maui.Controls;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Views;

namespace GameEngine
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

        }

        private void Button_Clicked1(object sender, EventArgs e)
        {
            HandleButtonClicked((Button)sender);
            stack1.IsVisible = false;
            Navigation.PushAsync(new ProfilPage());

        }

        private void Button_Clicked2(object sender, EventArgs e)
        {
            HandleButtonClicked((Button)sender);
            Navigation.PushAsync(new ProjectsPage());
        }

        private void Button_Clicked3(object sender, EventArgs e)
        {
            HandleButtonClicked((Button)sender);
            Navigation.PushAsync(new ParametrsPage());
        }

        private void Button_Clicked4(object sender, EventArgs e)
        {
            HandleButtonClicked((Button)sender);
            stack1.IsVisible = true;
        }

        // Общий метод для обработки нажатия кнопок
        private void HandleButtonClicked(Button clickedButton)
        {
            // Сброс цвета для всех кнопок
            color1.TextColor = Color.FromHex("#707070");
            color2.TextColor = Color.FromHex("#707070");
            color3.TextColor = Color.FromHex("#707070");
            color4.TextColor = Color.FromHex("#707070");

            // Установка белого цвета текста для нажатой кнопки
            clickedButton.TextColor = Color.FromHex("#FFFFFF");
        }

        private async void SelectProjectButton_Clicked(object sender, EventArgs e)
        {
            string folderPath = @"C:\Users\User"; // Путь к папке, которую нужно просмотреть

            try
            {
                string[] files = Directory.GetFiles(folderPath); // Получаем список файлов из папки

                if (files.Any()) // Если в папке есть файлы
                {
                    // Создаем строку, содержащую имена файлов, разделенные символом новой строки
                    string fileList = string.Join(Environment.NewLine, files.Select(Path.GetFileName));

                    // Отображаем список файлов в сообщении
                    string selectedFile = await DisplayActionSheet("Выберите файл", "Отмена", null, files.Select(Path.GetFileName).ToArray());

                    if (!string.IsNullOrEmpty(selectedFile))
                    {
                        // Пользователь выбрал файл
                        await DisplayAlert("Выбранный файл", $"Вы выбрали файл: {selectedFile}", "OK");
                    }
                    else
                    {
                        // Пользователь ничего не выбрал
                        await DisplayAlert("Предупреждение", "Вы не выбрали файл", "OK");
                    }
                }
                else
                {
                    // В папке нет файлов
                    await DisplayAlert("Предупреждение", "В папке нет файлов", "OK");
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибок
                await DisplayAlert("Ошибка", $"Произошла ошибка: {ex.Message}", "OK");
            }
        }
    


    private void CreateProjectButton_Clicked(object sender, EventArgs e)
        {
            var popup = new SimplePopup();

            this.ShowPopup(popup);
        }
    }

}

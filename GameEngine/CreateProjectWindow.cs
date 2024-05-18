using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace GameEngine
{
    public class CreateProjectWindow : ContentPage
    {
        public CreateProjectWindow()
        {
            Content = new StackLayout
            {
                Children = {
                    // Добавьте элементы управления для создания проекта (например, поля ввода, кнопки и т. д.)
                    new Label { Text = "Введите данные для создания проекта" },
                    // Добавьте остальные элементы UI здесь
                }
            };
        }
    }
}

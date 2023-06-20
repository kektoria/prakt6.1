using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prac6_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        string _login;
        public Page2(string login)
        {
            InitializeComponent();
            _login = login;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Name_Text.Text = $"Добро пожаловать, {_login}!" ;
        }

        private async void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Stihi.SelectedIndex == 0)
            {
                string vecher = "\tМихаил Лермонтов \n\n\tВечер\n\n" +
                                "Когда садится алый день \n" +
                                "За синий край земли,\n" +
                                "Когда туман встает, и тень\n " +
                                "Скрывает все вдали,\n " +
                                "Тогда я мыслю в тишине \n" +
                                "Про вечность и любовь, \n" +
                                "И чей-то голос шепчет мне: \n" +
                                "Не будешь счастлив вновь. \n" +
                                "И я гляжу на небеса \n" +
                                "С покорною душой, \n" +
                                "Они свершали чудеса, \n" +
                                "Но не для нас с тобой, \n" +
                                "Не для ничтожного глупца, \n" +
                                "Которому твой взгляд \n" +
                                "Дороже будет до конца \n" +
                                "Небесных всех наград.";
                await Navigation.PushAsync(new Page3(vecher));
            }

            else if (Stihi.SelectedIndex == 1)
            {
                string stars = "\tМихаил Лермонтов \n\n\tНебо и звёзды.\n\n" +
                               "Чисто вечернее небо,\n" +
                               "Ясны далекие звезды,\n" +
                               "Ясны как счастье ребенка;\n" +
                               "О! для чего мне нельзя и подумать:\n" +
                               "Звезды, вы ясны, как счастье мое!\n";
                await Navigation.PushAsync(new Page3(stars));
            }

            else if (Stihi.SelectedIndex == 2)
            {
                string sun = "\tМихаил Лермонтов \n\n\tСолнце\n\n" +
                             "Как солнце зимнее прекрасно,\n" +
                             "Когда, бродя меж серых туч, \n" +
                             "На белые снега напрасно \n" +
                             "Оно кидает слабый луч!..\n\n" +
                             "Так точно, дева молодая, \n" +
                             "Твой образ предо мной блестит; \n" +
                             "Но взор твой, счастье обещая, \n" +
                             "Мою ли душу оживит?";
                await Navigation.PushAsync(new Page3(sun));
            }

            else if (Stihi.SelectedIndex == 3)
            {
                string utes = "\tМихаил Лермонтов \n\n\tУтёс\n\n" +
                              "Ночевала тучка золотая \n" +
                              "На груди утеса-великана; \n" +
                              "Утром в путь она умчалась рано, \n" +
                              "По лазури весело играя;\n\n" +
                              "Но остался влажный след в морщине \n" +
                              "Старого утеса. Одиноко \n" +
                              "Он стоит, задумался глубоко, \n" +
                              "И тихонько плачет он в пустыне.";
                await Navigation.PushAsync(new Page3(utes));
            }
        }
    }
}
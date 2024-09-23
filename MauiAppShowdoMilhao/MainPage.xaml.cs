using MauiAppShowdoMilhao.Models;
using Plugin.Maui.Audio;

namespace MauiAppShowdoMilhao
{
    public partial class MainPage : ContentPage
    {
        double premio = 1000;
        int pergunta_count = 1;
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = App.getRandomPerguntaFacil();

            lbl_nivel.Text = "Fácil:";
            lbl_premio.Text = premio.ToString("C");
            lbl_pergunta_numero.Text = pergunta_count.ToString();

            Stream track = FileSystem.OpenAppPackageFileAsync("0.mp3").Result;
            AudioManager.Current.CreatePlayer(track).Play();
        }

        private void toca_som()
        {
            string track = "";

            switch(pergunta_count)
            {
                case 1:
                    track = "1.wav";
                break;

                case 2:
                    track = "2.wav";
                break;

                case 3:
                    track = "3.wav";
                break;

                case 4:
                    track = "4.wav";
                break;

                case 5:
                    track = "5.wav";
                    break;

                case 6:
                    track = "6.wav";
                    break;

                case 7:
                    track = "7.wav";
                    break;

                case 8:
                    track = "8.wav";
                    break;

                case 9:
                    track = "9.wav";
                    break;

                case 10:
                    track = "10.wav";
                    break;

                case 11:
                    track = "11.wav";
                    break;

                case 12:
                    track = "12.wav";
                    break;

                case 13:
                    track = "13.wav";
                    break;

                case 14:
                    track = "14.wav";
                    break;

                case 15:
                    track = "15.wav";
                    break;

                case 16:
                    track = "16.wav";
                    break;

            }

            AudioManager.Current.CreatePlayer(FileSystem.OpenAppPackageFileAsync(track).Result).Play();
        }
        
    }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.BindingContext = App.getRandomPerguntaFacil();
        }

        private void Button_Clicked_Proxima(object sender, EventArgs e)
        {
            bool acertou = false;
            string resp = "";
            bool valor;

            if (alt0.IsChecked)
            {
                if ((bool)alt0.Value)
                {
                    acertou = true;
                    resp = alt0.Content.ToString();
                }
            }

            if (alt1.IsChecked)
            {
                if ((bool)alt1.Value)
                {
                    acertou = true;
                    resp = alt1.Content.ToString();
                }
            }
            if (alt2.IsChecked)
            {
                if ((bool)alt2.Value)
                {
                    acertou = true;
                    resp = alt2.Content.ToString();
                }
            }
            if (alt3.IsChecked)
            {
                if ((bool)alt3.Value)
                {
                    acertou = true;
                    resp = alt3.Content.ToString();
                }
            }

            if (acertou)
            {
            Stream track = FileSystem.OpenAppPackageFileAsync("parabens.wav").Result;
            AudioManager.Current.CreatePlayer(track).Play();

            await DisplayAlert("ACERTOU!", resp, "OK");
            pergunta_count++;
            toca_som();
            avanca_pergunta();

            }
        }
        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
        void avanca_pergunta()
        {
            if (pergunta_count <= 5)
            {
                premio = premio + 1000;
                this.BindingContext = App.getRandomPerguntaFacil();
                lbl_nivel.Text = "Fácil";
            }

            if (pergunta_count > 5 && pergunta_count <= 10)
            {
                premio = premio + 10000;
                this.BindingContext = App.getRandomPerguntaFacil();
                lbl_nivel.Text = "Média";
            }

            if (pergunta_count > 10 && pergunta_count <= 15)
            {
                premio = premio + 100000;
                this.BindingContext = App.getRandomPerguntaFacil();
                lbl_nivel.Text = "Difícil";
            }
        }
    }

}

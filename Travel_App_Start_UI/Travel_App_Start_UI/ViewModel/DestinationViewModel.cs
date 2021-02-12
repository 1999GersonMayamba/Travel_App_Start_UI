using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Travel_App_Start_UI.ViewModel
{
    public class DestinationViewModel : INotifyPropertyChanged
    {
        private string title, description, textbottom, imagesource, buttontext;
        private Color stateColorFrame1, stateColorFrame2, stateColorFrame3;
        public event PropertyChangedEventHandler PropertyChanged;
        public Command NextCommand { get; } int cnt;

        public DestinationViewModel()
        {
            NextCommand = new Command(NextPage);
            OnLodingPage();
        }

        public string Title
        {
            get => title;
            set
            {
                title = value;
                var args = new PropertyChangedEventArgs(nameof(Title));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public string Description
        {
            get => description;
            set
            {
                description = value;
                var args = new PropertyChangedEventArgs(nameof(Description));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public string TextBottom
        {
            get => textbottom;
            set
            {
                textbottom = value;
                var args = new PropertyChangedEventArgs(nameof(TextBottom));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public string ImageSource
        {
            get => imagesource;
            set
            {
                imagesource = value;
                var args = new PropertyChangedEventArgs(nameof(ImageSource));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public string ButtonText
        {
            get => buttontext;
            set
            {
                buttontext = value;
                var args = new PropertyChangedEventArgs(nameof(ButtonText));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public Color StateColorFrame1
        {
            get => stateColorFrame1;
            set
            {
                stateColorFrame1 = value;
                var args = new PropertyChangedEventArgs(nameof(StateColorFrame1));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public Color StateColorFrame2
        {
            get => stateColorFrame2;
            set
            {
                stateColorFrame2 = value;
                var args = new PropertyChangedEventArgs(nameof(StateColorFrame2));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public Color StateColorFrame3
        {
            get => stateColorFrame3;
            set
            {
                stateColorFrame3 = value;
                var args = new PropertyChangedEventArgs(nameof(StateColorFrame3));
                PropertyChanged?.Invoke(this, args);
            }
        }


        /// <summary>
        /// Quando a pagina carregar
        /// </summary>
        private void OnLodingPage()
        {
            StateColorFrame1 = Color.FromHex("#6771e2");
            StateColorFrame2 = Color.FromHex("#DFECF4");
            StateColorFrame3 = Color.FromHex("#DFECF4");
            ButtonText = "Next";
            ImageSource = "Destination.png";
            Title = "Destination";
            TextBottom = "Skipe";
            Description = "There are many variarions of passages of lorem ipsum available, " +
                "but the majority have sufferes alteration in some form";

            cnt = 1;
        }


        private void NextPage()
        {

            if (cnt == 0)
            {
                StateColorFrame1 = Color.FromHex("#6771e2");
                StateColorFrame2 = Color.FromHex("#DFECF4");
                StateColorFrame3 = Color.FromHex("#DFECF4");
                ButtonText = "Next";
                ImageSource = "Destination.png";
                Title = "Destination";
                TextBottom = "Skipe";
                Description = "There are many variarions of passages of lorem ipsum available, " +
                    "but the majority have sufferes alteration in some form";

                cnt = 1;
            }
            else if (cnt == 1)
            {
                StateColorFrame1 = Color.FromHex("#DFECF4");
                StateColorFrame2 = Color.FromHex("#6771e2");
                StateColorFrame3 = Color.FromHex("#DFECF4");
                ButtonText = "Get Started";
                ImageSource = "EnjoyYourHoliday.png";
                Title = "Enjoy Your Holiday";
                TextBottom = "";
                Description = "There are many variarions of passages of lorem ipsum available, " +
                    "but the majority have sufferes alteration in some form";

                cnt = 2;
            }
            else 
            {
                StateColorFrame1 = Color.FromHex("#DFECF4");
                StateColorFrame2 = Color.FromHex("#DFECF4");
                StateColorFrame3 = Color.FromHex("#6771e2");
                Title = "Ticket Booking";
                ImageSource = "TicketBooking.png";
                ButtonText = "Next";
                TextBottom = "Skipe";
                Description = "Contrary to popular belief, Lorem ipsum is not simply radom text. It has roots " +
                    "in a piece of classical Latin literature from 45 BC, making it over 2000 years old.";

                cnt = 0;
            }
        }
    }
}

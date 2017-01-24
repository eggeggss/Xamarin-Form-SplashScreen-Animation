using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CommonView.Custom
{
    public class AnimatedButton : ContentView
    {
        private Label _textLabel;
        private StackLayout _layout;

        public event EventHandler Click;
        public String Text
        {
            set
            {
                this._textLabel.Text = value;
            }
            get
            {
                if (this._textLabel == null)
                    CreateLabel();
                return this._textLabel.Text;
            }
        }



        private Label CreateLabel()
        {
            return new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),

                TextColor = Color.White,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                XAlign = TextAlignment.Center
            };
        }

        public Action CallBack { set; get; }
        /// <summary>
        /// Creates a new instance of the animation button
        /// </summary>
        /// <param name="text">the text to set</param>
        /// <param name="callback">action to call when the animation is complete</param>
        public AnimatedButton()
        {
            // create the layout
            _layout = new StackLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Orientation = StackOrientation.Horizontal,
                Padding = 5,
                WidthRequest = 10
            };

            // create the label

            _textLabel = CreateLabel();

            _layout.Children.Add(_textLabel);

            // add a gester reco
            this.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(async (o) =>
                {

                    ViewExtensions.CancelAnimations(this);
                    await this.ScaleTo(0.95, 50, Easing.CubicOut);
                    await this.ScaleTo(1, 50, Easing.CubicIn);

                    if (Click != null)
                        Click(this, null);
                    /*
                    if (this.CallBack != null)
                        this.CallBack.Invoke();*/
                })
            });

            // set the content
            this.Content = _layout;

        }

        /// <summary>
        /// Gets or sets the font size for the text
        /// </summary>
        public virtual double FontSize
        {
            get { return this._textLabel.FontSize; }
            set
            {
                this._textLabel.FontSize = value;
            }
        }

        /// <summary>
        /// Gets or sets the text color for the text
        /// </summary>
        public virtual Color TextColor
        {
            get
            {
                return _textLabel.TextColor;
            }
            set
            {
                _textLabel.TextColor = value;
            }
        }
    }

}

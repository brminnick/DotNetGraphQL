using DotNetGraphQL.Common;
using ImageCircle.Forms.Plugin.Abstractions;
using Xamarin.Forms;

namespace DotNetGraphQL.Mobile
{
    public class DogImageListDataTemplate : DataTemplate
    {


        public DogImageListDataTemplate() : base(CreateImageLayout)
        {
        }

        static Grid CreateImageLayout()
        {
            const int circleImageHeight = 90;
            const int _smallFontSize = 12;
            const int emojiColumnSize = 15;
            const int countColumnSize = 30;

            var avatarImage = new CircleImage
            {
                HeightRequest = circleImageHeight,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center,
            };
            avatarImage.SetBinding(CircleImage.SourceProperty, nameof(DogImagesModel.AvatarUrl));

            var dogNameTitleLabel = new DarkBlueLabel
            {
                FontAttributes = FontAttributes.Bold,
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalTextAlignment = TextAlignment.Start,
                LineBreakMode = LineBreakMode.TailTruncation,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            dogNameTitleLabel.SetBinding(Label.TextProperty, nameof(DogImagesModel.Title));

            var breedEmojiSpan = new Span { Text = "🐶 " };
            var breedDetailsSpan = new Span();
            breedDetailsSpan.SetBinding(Span.TextProperty, nameof(DogImagesModel.Breed));

            var dogBreedLabel = new DarkBlueLabel(_smallFontSize)
            {
                FormattedText = new FormattedString
                {
                    Spans = { breedEmojiSpan, breedDetailsSpan }
                }
            };

            var coatColorEmojiSpan = new Span { Text = "🎨 " };
            var coatColorDetailsSpan = new Span();
            coatColorDetailsSpan.SetBinding(Span.TextProperty, nameof(DogImagesModel.CoatColor));

            var coatColorLabel = new DarkBlueLabel(_smallFontSize)
            {
                FormattedText = new FormattedString
                {
                    Spans = { coatColorEmojiSpan, coatColorDetailsSpan }
                }
            };

            var birthDateEmojiSpan = new Span { Text = "🎂 " };
            var birthDateDetailsSpan = new Span();
            coatColorDetailsSpan.SetBinding(Span.TextProperty, nameof(DogImagesModel.BirthDate));

            var birthDateLabel = new DarkBlueLabel(_smallFontSize)
            {
                FormattedText = new FormattedString
                {
                    Spans = { birthDateEmojiSpan, birthDateDetailsSpan }
                }
            };

            var grid = new Grid
            {
                BackgroundColor = Color.Transparent,

                Padding = new Thickness(2, 0, 5, 0),
                RowSpacing = 2,
                ColumnSpacing = 3,

                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.StartAndExpand,

                RowDefinitions = {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Absolute) },
                    new RowDefinition { Height = new GridLength(20, GridUnitType.Absolute) },
                    new RowDefinition { Height = new GridLength(_smallFontSize + 5, GridUnitType.Absolute) },
                    new RowDefinition { Height = new GridLength(_smallFontSize + 5, GridUnitType.Absolute) },
                    new RowDefinition { Height = new GridLength(_smallFontSize + 5, GridUnitType.Absolute) },
                    new RowDefinition { Height = new GridLength(5, GridUnitType.Absolute) },
                },
                ColumnDefinitions = {
                    new ColumnDefinition { Width = new GridLength(circleImageHeight, GridUnitType.Absolute) },
                    new ColumnDefinition { Width = new GridLength(2, GridUnitType.Absolute) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                }
            };

            grid.Children.Add(avatarImage, 0, 0);
            Grid.SetRowSpan(avatarImage, 6);

            grid.Children.Add(dogNameTitleLabel, 2, 1);
            Grid.SetColumnSpan(dogNameTitleLabel, 7);

            grid.Children.Add(dogBreedLabel, 2, 2);
            grid.Children.Add(coatColorLabel, 2, 3);
            grid.Children.Add(birthDateLabel, 2, 4);

            return grid;
        }

        class DarkBlueLabel : Label
        {
            public DarkBlueLabel(in double fontSize) : this() => FontSize = fontSize;

            public DarkBlueLabel()
            {
                HorizontalTextAlignment = TextAlignment.Start;
                VerticalTextAlignment = TextAlignment.End;
            }
        }
    }
}

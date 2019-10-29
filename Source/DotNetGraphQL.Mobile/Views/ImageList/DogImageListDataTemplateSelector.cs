using DotNetGraphQL.Common;
using ImageCircle.Forms.Plugin.Abstractions;
using Xamarin.Forms;

namespace DotNetGraphQL.Mobile
{
    class DogImageListDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container) => new DogImageListDataTemplate((DogImagesModel)item);

        class DogImageListDataTemplate : DataTemplate
        {
            public DogImageListDataTemplate(DogImagesModel dogImagesModel) : base(() => CreateImageLayout(dogImagesModel))
            {
            }

            static Grid CreateImageLayout(DogImagesModel dogImagesModel)
            {
                const int circleImageHeight = 90;
                const int fontSize = 12;

                var avatarImage = new CircleImage
                {
                    Source = dogImagesModel.AvatarUrl,
                    HeightRequest = circleImageHeight,
                    HorizontalOptions = LayoutOptions.Start,
                    VerticalOptions = LayoutOptions.Center,
                };

                var dogNameTitleLabel = new DarkBlueLabel
                {
                    Text = dogImagesModel.Title,
                    FontAttributes = FontAttributes.Bold,
                    HorizontalTextAlignment = TextAlignment.Start,
                    VerticalTextAlignment = TextAlignment.Start,
                    LineBreakMode = LineBreakMode.TailTruncation,
                    HorizontalOptions = LayoutOptions.FillAndExpand
                };

                var dogBreedLabel = new DarkBlueLabel(fontSize)
                {
                    Text = $"🐶 {dogImagesModel.Breed}"
                };

                var coatColorLabel = new DarkBlueLabel(fontSize)
                {
                    Text = $"🎨 {dogImagesModel.CoatColor}"
                };

                var birthDateLabel = new DarkBlueLabel(fontSize)
                {
                    Text = $"🎂 {dogImagesModel.BirthDate?.ToString("MMMM dd yyyy") ?? "Unknown"}"
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
                        new RowDefinition { Height = new GridLength(fontSize + 5, GridUnitType.Absolute) },
                        new RowDefinition { Height = new GridLength(fontSize + 5, GridUnitType.Absolute) },
                        new RowDefinition { Height = new GridLength(fontSize + 5, GridUnitType.Absolute) },
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
                    TextColor = Color.Navy;
                    HorizontalTextAlignment = TextAlignment.Start;
                    VerticalTextAlignment = TextAlignment.Center;
                }
            }
        }
    }
}
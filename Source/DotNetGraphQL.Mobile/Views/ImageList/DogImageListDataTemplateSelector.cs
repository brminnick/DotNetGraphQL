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

            static Layout CreateImageLayout(DogImagesModel dogImagesModel)
            {
                const int circleImageHeight = 90;
                const int fontSize = 16;
                const int padding = 5;

                var avatarImage = new CircleImage
                {
                    Source = dogImagesModel.AvatarUrl,
                    HeightRequest = circleImageHeight,
                    HorizontalOptions = LayoutOptions.Start,
                    VerticalOptions = LayoutOptions.Center,
                    Aspect = Aspect.AspectFill
                };

                var dogNameTitleLabel = new DarkBlueLabel
                {
                    Text = dogImagesModel.Title,
                    FontSize = fontSize * 4 / 3,
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

                var contentGrid = new Grid
                {
                    BackgroundColor = Color.Transparent,

                    RowSpacing = 2,
                    ColumnSpacing = 3,

                    HorizontalOptions = LayoutOptions.Start,
                    VerticalOptions = LayoutOptions.StartAndExpand,

                    RowDefinitions = {
                        new RowDefinition { Height = new GridLength(1, GridUnitType.Absolute) },
                        new RowDefinition { Height = new GridLength(fontSize * 4/3 + 5, GridUnitType.Absolute) },
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

                contentGrid.Children.Add(avatarImage, 0, 0);
                Grid.SetRowSpan(avatarImage, 6);

                contentGrid.Children.Add(dogNameTitleLabel, 2, 1);
                contentGrid.Children.Add(dogBreedLabel, 2, 2);
                contentGrid.Children.Add(coatColorLabel, 2, 3);
                contentGrid.Children.Add(birthDateLabel, 2, 4);

                var contentFrame = new Frame
                {
                    CornerRadius = 7,
                    Padding = new Thickness(5, 10),
                    BackgroundColor = Color.FromHex("8BB6D6"),
                    Content = contentGrid
                };

                var rowGrid = new Grid
                {
                    RowDefinitions = {
                        new RowDefinition { Height = new GridLength(padding, GridUnitType.Absolute) },
                        new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    },
                    ColumnDefinitions = {
                        new ColumnDefinition { Width = new GridLength(padding / 2, GridUnitType.Absolute) },
                        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                        new ColumnDefinition { Width = new GridLength(padding / 2, GridUnitType.Absolute) }
                    }
                };

                rowGrid.Children.Add(contentFrame, 1, 1);

                return rowGrid;
            }

            class DarkBlueLabel : Label
            {
                public DarkBlueLabel(in double fontSize) : this() => FontSize = fontSize;

                public DarkBlueLabel()
                {
                    TextColor = Color.FromHex("1F2B2E");
                    HorizontalTextAlignment = TextAlignment.Start;
                    VerticalTextAlignment = TextAlignment.Center;
                }
            }
        }
    }
}
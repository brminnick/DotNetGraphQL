using DotNetGraphQL.Common;
using ImageCircle.Forms.Plugin.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Markup;
using static Xamarin.Forms.Markup.GridRowsColumns;

namespace DotNetGraphQL.Mobile
{
    class DogImageListDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container) => new DogImageListDataTemplate((DogImagesModel)item);

        class DogImageListDataTemplate : DataTemplate
        {
            const int circleImageHeight = 90;
            const int fontSize = 16;
            const int padding = 5;

            public DogImageListDataTemplate(DogImagesModel dogImagesModel) : base(() => CreateContentFrame(dogImagesModel))
            {
            }

            enum ContentFrameRow { TopPadding, Content }
            enum ContentFrameColumn { LeftPadding, Content, RightPadding }

            enum ImageLayoutRow { TopPadding, Name, Breed, Coat, Birthday, BottomPadding }
            enum ImageLayoutColumn { Avatar, MiddlePadding, Text }

            static Grid CreateContentFrame(DogImagesModel dogImagesModel) => new Grid
            {
                RowDefinitions = Rows.Define(
                    (ContentFrameRow.TopPadding, new GridLength(padding, GridUnitType.Absolute)),
                    (ContentFrameRow.Content, new GridLength(1, GridUnitType.Star))),

                ColumnDefinitions = Columns.Define(
                    (ContentFrameColumn.LeftPadding, new GridLength(padding / 2, GridUnitType.Absolute)),
                    (ContentFrameColumn.Content, new GridLength(1, GridUnitType.Star)),
                    (ContentFrameColumn.RightPadding, new GridLength(padding / 2, GridUnitType.Absolute))),

                Children =
                {
                    new ContentFrame(CreateImageLayout(dogImagesModel)).Row(ContentFrameRow.Content).Column(ContentFrameColumn.Content)
                }
            };

            static Grid CreateImageLayout(DogImagesModel dogImagesModel) => new Grid
            {
                BackgroundColor = Color.Transparent,

                RowSpacing = 2,
                ColumnSpacing = 3,

                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.StartAndExpand,

                RowDefinitions = Rows.Define(
                    (ImageLayoutRow.TopPadding, new GridLength(1, GridUnitType.Absolute)),
                    (ImageLayoutRow.Name, new GridLength(fontSize * 4 / 3 + 5, GridUnitType.Absolute)),
                    (ImageLayoutRow.Breed, new GridLength(fontSize + 5, GridUnitType.Absolute)),
                    (ImageLayoutRow.Coat, new GridLength(fontSize + 5, GridUnitType.Absolute)),
                    (ImageLayoutRow.Birthday, new GridLength(fontSize + 5, GridUnitType.Absolute)),
                    (ImageLayoutRow.BottomPadding, new GridLength(5, GridUnitType.Absolute))),

                ColumnDefinitions = Columns.Define(
                    (ImageLayoutColumn.Avatar, new GridLength(circleImageHeight, GridUnitType.Absolute)),
                    (ImageLayoutColumn.MiddlePadding, new GridLength(2, GridUnitType.Absolute)),
                    (ImageLayoutColumn.Text, new GridLength(1, GridUnitType.Star))),

                Children =
                {
                    new AvatarImage(dogImagesModel.AvatarUrl).Row(ImageLayoutRow.Name).Column(ImageLayoutColumn.Avatar).RowSpan(All<ImageLayoutRow>()),
                    new DogNameLabel(dogImagesModel.Title).Row(ImageLayoutRow.Name).Column(ImageLayoutColumn.Text),
                    new DarkBlueLabel(fontSize, $"🐶 {dogImagesModel.Breed}").Row(ImageLayoutRow.Breed).Column(ImageLayoutColumn.Text),
                    new DarkBlueLabel(fontSize, $"🎨 {dogImagesModel.CoatColor}").Row(ImageLayoutRow.Coat).Column(ImageLayoutColumn.Text),
                    new DarkBlueLabel(fontSize, $"🎂 {dogImagesModel.BirthDate?.ToString("MMMM dd yyyy") ?? "Unknown"}").Row(ImageLayoutRow.Birthday).Column(ImageLayoutColumn.Text),
                }
            };

            class DogNameLabel : DarkBlueLabel
            {
                public DogNameLabel(string text) : base(fontSize * 4 / 3, text)
                {
                    FontAttributes = FontAttributes.Bold;
                    HorizontalTextAlignment = TextAlignment.Start;
                    VerticalTextAlignment = TextAlignment.Start;
                    LineBreakMode = LineBreakMode.TailTruncation;
                    HorizontalOptions = LayoutOptions.FillAndExpand;
                }
            }

            class DarkBlueLabel : Label
            {
                public DarkBlueLabel(in double fontSize, in string text) : this(text)
                {
                    FontSize = fontSize;
                }

                public DarkBlueLabel(in string text)
                {
                    Text = text;
                    TextColor = Color.FromHex("1F2B2E");
                    HorizontalTextAlignment = TextAlignment.Start;
                    VerticalTextAlignment = TextAlignment.Center;
                }
            }

            class ContentFrame : Frame
            {
                public ContentFrame(in View content)
                {
                    CornerRadius = 7;
                    Padding = new Thickness(5, 10);
                    BackgroundColor = Color.FromHex("8BB6D6");
                    Content = content;
                }
            }

            class AvatarImage : CircleImage
            {
                public AvatarImage(string source)
                {
                    Source = source;
                    HeightRequest = circleImageHeight;
                    HorizontalOptions = LayoutOptions.Start;
                    VerticalOptions = LayoutOptions.Center;
                    Aspect = Aspect.AspectFill;
                }
            }
        }
    }
}
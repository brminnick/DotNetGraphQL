using DotNetGraphQL.Common;
using ImageCircle.Forms.Plugin.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Markup;
using static Xamarin.Forms.Markup.GridRowsColumns;
using static DotNetGraphQL.Mobile.GridLengths;

namespace DotNetGraphQL.Mobile
{
    class DogImageListDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container) => new DogImageListDataTemplate((DogImagesModel)item);

        class DogImageListDataTemplate : DataTemplate
        {
            const int _padding = 5;
            const int _fontSize = 16;
            const int _circleImageHeight = 90;
            const double _titleFontSize = 21.333;

            public DogImageListDataTemplate(DogImagesModel dogImagesModel) : base(() => CreateContentFrame(dogImagesModel))
            {
            }

            enum ContentFrameRow { TopPadding, Content }
            enum ContentFrameColumn { LeftPadding, Content, RightPadding }

            enum ImageLayoutRow { TopPadding, Name, Breed, Coat, Birthday, BottomPadding }
            enum ImageLayoutColumn { Avatar, MiddlePadding, Text }

            static Grid CreateContentFrame(DogImagesModel dogImagesModel) => new()
            {
                RowDefinitions = Rows.Define(
                    (ContentFrameRow.TopPadding, AbsoluteGridLength(_padding)),
                    (ContentFrameRow.Content, StarGridLength(1))),

                ColumnDefinitions = Columns.Define(
                    (ContentFrameColumn.LeftPadding, AbsoluteGridLength(_padding / 2)),
                    (ContentFrameColumn.Content, StarGridLength(1)),
                    (ContentFrameColumn.RightPadding, AbsoluteGridLength(_padding / 2))),

                Children =
                {
                    new ContentFrame(CreateImageLayout(dogImagesModel)).Row(ContentFrameRow.Content).Column(ContentFrameColumn.Content)
                }
            };

            static Grid CreateImageLayout(DogImagesModel dogImagesModel) => new()
            {
                BackgroundColor = Color.Transparent,

                RowSpacing = 2,
                ColumnSpacing = 3,

                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.StartAndExpand,

                RowDefinitions = Rows.Define(
                    (ImageLayoutRow.TopPadding, AbsoluteGridLength(1)),
                    (ImageLayoutRow.Name, AbsoluteGridLength(_titleFontSize + _padding)),
                    (ImageLayoutRow.Breed, AbsoluteGridLength(_fontSize + _padding)),
                    (ImageLayoutRow.Coat, AbsoluteGridLength(_fontSize + _padding)),
                    (ImageLayoutRow.Birthday, AbsoluteGridLength(_fontSize)),
                    (ImageLayoutRow.BottomPadding, AbsoluteGridLength(_padding))),

                ColumnDefinitions = Columns.Define(
                    (ImageLayoutColumn.Avatar, AbsoluteGridLength(_circleImageHeight)),
                    (ImageLayoutColumn.MiddlePadding, AbsoluteGridLength(2)),
                    (ImageLayoutColumn.Text, StarGridLength(1))),

                Children =
                {
                    new AvatarImage(dogImagesModel.AvatarUrl).Row(ImageLayoutRow.Name).Column(ImageLayoutColumn.Avatar).RowSpan(All<ImageLayoutRow>()),
                    new DogNameLabel(dogImagesModel.Title).Row(ImageLayoutRow.Name).Column(ImageLayoutColumn.Text),
                    new DarkBlueLabel(_fontSize, $"🐶 {dogImagesModel.Breed}").Row(ImageLayoutRow.Breed).Column(ImageLayoutColumn.Text),
                    new DarkBlueLabel(_fontSize, $"🎨 {dogImagesModel.CoatColor}").Row(ImageLayoutRow.Coat).Column(ImageLayoutColumn.Text),
                    new DarkBlueLabel(_fontSize, $"🎂 {dogImagesModel.BirthDate?.ToString("MMMM dd yyyy") ?? "Unknown"}").Row(ImageLayoutRow.Birthday).Column(ImageLayoutColumn.Text),
                }
            };

            class DogNameLabel : DarkBlueLabel
            {
                public DogNameLabel(string text) : base(_titleFontSize, text)
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
                public AvatarImage(in string source)
                {
                    Source = source;
                    HeightRequest = _circleImageHeight;
                    HorizontalOptions = LayoutOptions.Start;
                    VerticalOptions = LayoutOptions.Center;
                    Aspect = Aspect.AspectFill;
                }
            }
        }
    }

    static class GridLengths
    {
        public static GridLength AbsoluteGridLength(double value) => new(value, GridUnitType.Absolute);
        public static GridLength StarGridLength(double value) => new(value, GridUnitType.Star);
    }
}
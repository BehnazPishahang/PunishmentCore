using MudBlazor;


namespace Anu.PunishmentOrg.Client.Infrastructure.Settings
{
    public class Theme135
    {
        public static MudBlazor.Color _iconColor = Color.Primary;
        public static MudBlazor.Color _LogoColor = Color.Success;


        private static Typography DefaultTypography = new Typography()
        {
            Default = new Default()
            {
                FontFamily = new[] { "Shabnam" },
                FontSize = ".875rem",
                FontWeight = 400,
                LineHeight = 1.43,
                LetterSpacing = ".01071em"
            },
            H1 = new H1()
            {
                FontFamily = new[] { "Shabnam" },
                FontSize = "6rem",
                FontWeight = 400,
                LineHeight = 1.167,
                LetterSpacing = "-.01562em"
            },
            H2 = new H2()
            {
                 FontFamily = new[] { "Shabnam" },
                FontSize = "3.75rem",
                FontWeight = 400,
                LineHeight = 1.2,
                LetterSpacing = "-.00833em"
            },
            H3 = new H3()
            {
                FontFamily = new[] { "Shabnam" },
                FontSize = "3rem",
                FontWeight = 400,
                LineHeight = 1.167,
                LetterSpacing = "0"
            },
            H4 = new H4()
            {
                FontFamily = new[] { "Shabnam" },
                FontSize = "2.125rem",
                FontWeight = 400,
                LineHeight = 1.235,
                LetterSpacing = ".00735em"
            },
            H5 = new H5()
            {
                FontFamily = new[] { "Shabnam" },
                FontSize = "1.5rem",
                FontWeight = 400,
                LineHeight = 1.334,
                LetterSpacing = "0"
            },
            H6 = new H6()
            {
                FontFamily = new[] { "Shabnam" },
                FontSize = "1.25rem",
                FontWeight = 600,
                LineHeight = 1.6,
                LetterSpacing = ".0075em"
            },
            Button = new Button()
            {
                FontFamily = new[] { "Shabnam" },
                FontSize = ".875rem",
                FontWeight = 500,
                LineHeight = 1.75,
                LetterSpacing = ".02857em"
            },
            Body1 = new Body1()
            {
                FontFamily = new[] { "Shabnam" },
                FontSize = "1rem",
                FontWeight = 400,
                LineHeight = 1.5,
                LetterSpacing = ".00938em"
            },
            Body2 = new Body2()
            {
                FontFamily = new[] { "Shabnam" },
                FontSize = ".875rem",
                FontWeight = 400,
                LineHeight = 1.43,
                LetterSpacing = ".01071em"
            },
            Caption = new Caption()
            {
                FontFamily = new[] { "Shabnam" },
                FontSize = ".75rem",
                FontWeight = 400,
                LineHeight = 1.66,
                LetterSpacing = ".03333em"
            },
            Subtitle2 = new Subtitle2()
            {
                FontFamily = new[] { "Shabnam" },
                FontSize = ".875rem",
                FontWeight = 500,
                LineHeight = 1.57,
                LetterSpacing = ".00714em"
            }
        };

        private static LayoutProperties DefaultLayoutProperties = new LayoutProperties()
        {
            DefaultBorderRadius = "3px"
        };

        public static MudTheme DefaultTheme = new MudTheme()
        {
            Palette = new Palette()
            {
                Primary = " #2596be",
                Secondary = Colors.Green.Accent1,
                AppbarBackground = "#1E88E5",
                Background = Colors.Grey.Lighten5,

                //TextPrimary = "rgba(0,0,0, 0.70)",
                //TextSecondary = "rgba(0,0,0, 0.50)",
                //DrawerBackground = "#FFF",
                //DrawerText = "rgba(0,0,0, 0.7)",
                Success = "#007E33"
            },
            Typography = DefaultTypography,
            LayoutProperties = DefaultLayoutProperties
        };

        public static MudTheme DarkTheme = new MudTheme()
        {
            Palette = new Palette()
            { 
               Primary=" #2596be",
                Secondary = Colors.Green.Accent1,
                Success = "#007E33",
                Black = "#27272f",
                Background = "#32333d",
                BackgroundGrey = "#27272f",
                Surface = "#373740",
                DrawerBackground = "#27272f",
                DrawerText = "rgba(255,255,255, 0.50)",
                AppbarBackground = "#373740",
                AppbarText = "rgba(0,0,0, 0.70)",
                TextPrimary = "rgba(0,0,0, 0.70)",
                TextSecondary = "rgba(0,0,0, 0.50)",
                ActionDefault = "#adadb1",
                ActionDisabled = "rgba(255,255,255, 0.26)",
                ActionDisabledBackground = "rgba(255,255,255, 0.12)",
                DrawerIcon = "rgba(255,255,255, 0.50)"
            },
            Typography = DefaultTypography,
            LayoutProperties = DefaultLayoutProperties
        };
    }

    public class ButtonStyle
    {
        public string Height { get; set; }

        public string Width { get; set; }

        public string FontSize { get; set; }

        public string ForegroundColor { get; set; }

        public string BackgroundColor { get; set; }

        public string Content { get; set; }
    }
}

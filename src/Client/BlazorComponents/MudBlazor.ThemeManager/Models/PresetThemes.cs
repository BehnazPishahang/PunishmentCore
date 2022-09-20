namespace MudBlazor.ThemeManager.Models;

internal static class PresetThemes
{
    public const string Custom = "سفارشی ";
    public const string MuiDark = "زمینه آبی ";
    public const string Weak = "زمینه سبز ";


    public static Palette GetDefaultLightPalette()
    {
        var theme = new MudTheme()
        {
            Palette = new Palette()
            {
                Secondary = "#376662",
                Black = "#19191c",
                Background = "#f7f9ff",
                TextPrimary = "#19191c",
                TextSecondary = "#19191c",
            },
            LayoutProperties = new LayoutProperties()
            {
                DefaultBorderRadius = "14px",
            },

            Typography = new Typography()
            {
                Default = new Default()
                {
                    FontFamily = new[] { "Shabnam", "Shabnam", "Shabnam", "Shabnam" }
                }
            }
        };

        return theme.Palette;
    }




    public static Palette GetDefaultDarkPalette()
    {
        var theme = new MudTheme()
        {
            Palette = new Palette()
            {
                Black = "#27272f",
                Secondary = "#556289",
                Background = "rgb(21,27,34)",
                BackgroundGrey = "#27272f",
                Surface = "#212B36",
                DrawerBackground = "rgb(21,27,34)",
                DrawerText = "rgba(255,255,255, 0.50)",
                DrawerIcon = "rgba(255,255,255, 0.50)",
                AppbarBackground = "#27272f",
                AppbarText = "rgba(255,255,255, 0.70)",
                TextPrimary = "#ffffffb2",
                TextSecondary = "#cac7db",
                ActionDefault = "#adadb1",
                ActionDisabled = "rgba(255,255,255, 0.26)",
                ActionDisabledBackground = "rgba(255,255,255, 0.12)",
                Divider = "rgba(255,255,255, 0.12)",
                DividerLight = "rgba(255,255,255, 0.06)",
                TableLines = "rgba(255,255,255, 0.12)",
                LinesDefault = "rgba(255,255,255, 0.12)",
                LinesInputs = "rgba(255,255,255, 0.3)",
                TextDisabled = "rgba(255,255,255, 0.2)"
            },
            LayoutProperties = new LayoutProperties()
            {
                DefaultBorderRadius = "14px",
            },

            Typography = new Typography()
            {
                Default = new Default()
                {
                    FontFamily = new[] { "Shabnam", "Shabnam", "Shabnam", "Shabnam" }
                }
            }
        };

        return theme.Palette;
    }

    public static MudTheme GetMuiDarkTheme()
    {
        var theme = new MudTheme()
        {
            Palette = new Palette()
            {
                Primary = "#007fff",
                Secondary = "#556289",
                Tertiary = "#594AE2",
                Black = "#27272f",
                Background = "#0a1929",
                BackgroundGrey = "#007fff42",
                Surface = "#192f46",
                DrawerBackground = "#0a1929",
                DrawerText = "rgba(255,255,255, 0.50)",
                DrawerIcon = "rgba(255,255,255, 0.50)",
                AppbarBackground = "rgb(10, 25, 41)",
                AppbarText = "rgba(255,255,255, 0.70)",
                TextPrimary = "rgba(255,255,255, 0.70)",
                TextSecondary = "rgba(255,255,255, 0.50)",
                ActionDefault = "rgb(173, 173, 177)",
                ActionDisabled = "rgba(0, 127, 255, 0.40)",
                ActionDisabledBackground = "#001e3c",
                Divider = "rgba(0, 127, 255, 0.12)",
                DividerLight = "rgba(20, 127, 255, 0.06)",
                TableLines = "rgba(0, 127, 255, 0.12)",
                LinesDefault = "rgba(0, 127, 255, 0.12)",
                LinesInputs = "rgba(0, 127, 255, 0.3)",
                TextDisabled = "rgba(0, 127, 255, 0.2)"
            },
            LayoutProperties = new LayoutProperties()
            {
                DefaultBorderRadius = "14px",
            },

            Typography = new Typography()
            {
                Default = new Default()
                {
                    FontFamily = new[] { "Shabnam", "Shabnam", "Shabnam", "Shabnam" }
                }
            }
        };

        return theme;
    }


    public static MudTheme GetWeakTheme()
    {
        var theme = new MudTheme()
        {
            Palette = new Palette()
            {
                Primary = "#35765b",
                Secondary = "#26a69a",
                Tertiary = "#594AE2",
                Black = "#27272f",
                White = "#e8ebcd",
                Background = "#afb9a9e6",
                BackgroundGrey = "#515e49",
                Surface = "#b3cba4",
                DrawerBackground = "#e5fff9",
                DrawerText = "#8ac9af",
                DrawerIcon = "#1b4433",
                AppbarBackground = "rgb(10, 25, 41)",
                AppbarText = "rgba(255,255,255, 0.70)",
                TextPrimary = "#27272f",
                TextSecondary = "#27272f",
                ActionDefault = "rgb(173, 173, 177)",
                ActionDisabled = "rgba(0, 127, 255, 0.40)",
                ActionDisabledBackground = "#819991",
                Divider = "rgba(0, 127, 255, 0.12)",
                DividerLight = "rgba(20, 127, 255, 0.06)",
                TableLines = "rgba(0, 127, 255, 0.12)",
                LinesDefault = "rgba(0, 127, 255, 0.12)",
                LinesInputs = "rgba(0, 127, 255, 0.3)",
                TextDisabled = "rgba(0, 127, 255, 0.2)"
            },
            LayoutProperties = new LayoutProperties()
            {
                DefaultBorderRadius = "12px",
            },
            Typography = new Typography()
            {
                Default = new Default()
                {
                    FontFamily = new[] { "Shabnam", "Shabnam", "Shabnam", "Shabnam" }
                }
            }
        };

        return theme;
    }
}
namespace MudBlazor.ThemeManager.Models;

internal static class PresetThemes
{
    public const string Custom = "سفارشی ";
    public const string MuiDark = "زمینه آبی ";
    public const string Weak    = "زمینه سبز ";
    

    public static Palette GetDefaultLightPalette()
    {
        var palette = new Palette
        {
           Secondary = "#376662",
            Black = "#19191c",
            Background = "#dfe0e5",
            TextPrimary = "#19191c",
            TextSecondary = "#19191c",
        };

        return palette;
    }

   


    public static Palette GetDefaultDarkPalette()
    {
        var palette = new Palette
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
            TextSecondary = "#251c56",
            ActionDefault = "#adadb1",
            ActionDisabled = "rgba(255,255,255, 0.26)",
            ActionDisabledBackground = "rgba(255,255,255, 0.12)",
            Divider = "rgba(255,255,255, 0.12)",
            DividerLight = "rgba(255,255,255, 0.06)",
            TableLines = "rgba(255,255,255, 0.12)",
            LinesDefault = "rgba(255,255,255, 0.12)",
            LinesInputs = "rgba(255,255,255, 0.3)",
            TextDisabled = "rgba(255,255,255, 0.2)"
        };

        return palette;
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
                BackgroundGrey = "#001e3c",
                Surface = "#001e3c",
                DrawerBackground = "#0a1929",
                DrawerText = "rgba(255,255,255, 0.50)",
                DrawerIcon = "rgba(255,255,255, 0.50)",
                AppbarBackground = "rgb(10, 25, 41)",
                AppbarText = "rgba(255,255,255, 0.70)",
                TextPrimary = "rgba(255,255,255, 0.70)",
                TextSecondary = "rgba(255,255,255, 0.50)",
                ActionDefault = "rgb(173, 173, 177)",
                ActionDisabled = "rgba(0, 127, 255, 0.40)",
                ActionDisabledBackground = "rgba(0, 127, 255, 0.26)",
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
                    FontFamily = new[] { "Shabnam", "Shabnam", "Shabnam", "sans-serif" }
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
                Primary = "#1b4433",
                Secondary = "#26a69a",
                Tertiary = "#594AE2",
                Black = "#27272f",
                Background = "#afb9a9",
                BackgroundGrey = "#515e49",
                Surface = "#515e49",
                DrawerBackground = "#0a1929",
                DrawerText = "#1b4433",
                DrawerIcon = "#1b4433",
                AppbarBackground = "rgb(10, 25, 41)",
                AppbarText = "rgba(255,255,255, 0.70)",
                TextPrimary = "#27272f",
                TextSecondary = "#27272f",
                ActionDefault = "rgb(173, 173, 177)",
                ActionDisabled = "rgba(0, 127, 255, 0.40)",
                ActionDisabledBackground = "rgba(0, 127, 255, 0.26)",
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
                    FontFamily = new[] { "Shabnam", "Shabnam", "Shabnam", "sans-serif" }
                }
            }
        };

        return theme;
    }
}
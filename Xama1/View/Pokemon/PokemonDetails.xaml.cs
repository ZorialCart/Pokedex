using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xama1.Model;
using Xama1.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xama1.View.Pokemon
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PokemonDetails : ContentPage
	{
		public PokemonDetails (MPokemon parameters)
		{
			InitializeComponent ();
			BindingContext = new VMDetailsPokemon(Navigation,parameters);
            ActualizarFondo();
		}

        private void ActualizarFondo()
        {
            var powerColor = (BindingContext as VMDetailsPokemon)?.PowerColor;
            var background = (BindingContext as VMDetailsPokemon)?.Background;

            // Convertir los valores a colores, manejando hexadecimales y nombres de colores
            Color PowerColorf = ConvertToColor(powerColor);
            Color Backgroundf = ConvertToColor(background);

            a.Background = new LinearGradientBrush
            {
                StartPoint = new Point(1, 0),
                GradientStops = new GradientStopCollection
        {
        new GradientStop
            {
             Color = PowerColorf,
             Offset = 0.1F
            },
        new GradientStop
            {
             Color = Backgroundf,
             Offset = 0.8F
            }
        }
            };
        }

        private Color ConvertToColor(string colorValue)
        {
            // Intentar primero con hexadecimal
            if (IsValidHexColor(colorValue))
            {
                return Color.FromHex(colorValue);
            }

            // Si no es hexadecimal, intentar convertir por nombre
            return GetColorFromName(colorValue) ?? Color.Transparent; // Color predeterminado si no se encuentra
        }

        // Método para obtener el color a partir del nombre
        private Color? GetColorFromName(string colorName)
        {
            var colorNames = new Dictionary<string, Color>
     {
         { "red", Color.Red },
         { "green", Color.Green },
         { "blue", Color.Blue },
         { "yellow", Color.Yellow },
         { "black", Color.Black },
         { "white", Color.White },
         { "purple", Color.Purple },
         { "orange", Color.Orange },
         { "pink", Color.FromRgb(255, 192, 203) }, // Color rosa
         // Agrega más colores según sea necesario
     };

            // Intenta obtener el color por nombre
            return colorNames.TryGetValue(colorName.ToLower(), out var color) ? color : (Color?)null;
        }

        // Método para validar si la cadena es un color hexadecimal válido
        private bool IsValidHexColor(string hexColor)
        {
            return !string.IsNullOrEmpty(hexColor) &&
                   (hexColor.Length == 7 || hexColor.Length == 9) && // #RRGGBB o #RRGGBBAA
                   hexColor.StartsWith("#");
        }
    }
}
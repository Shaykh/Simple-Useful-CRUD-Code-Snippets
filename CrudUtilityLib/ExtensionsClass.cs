using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudUtilityLib
{
    public static class ExtensionsClass
    {
        public static string Afficher(this DateTime? date)
        {
            return date.HasValue ? date.Value.ToString("dd-MM-yyyy") : "Non Défini";
        }

        public static string AfficherTemps(this DateTime? date)
        {
            return date.HasValue ? date.Value.ToString("dd-MM-yyyy HH:mm") : "Non Défini";
        }

        public static string Afficher(this double? nombre)
        {
            if (nombre.HasValue)
                return nombre.Value.ToString("### ### ### ### ##0.###");
            else return "Non Défini";
        }

        public static string Afficher(this decimal? nombre)
        {
            if (nombre.HasValue)
                return nombre.Value.ToString("### ### ### ### ##0.###");
            else return "Non Défini";
        }
    }
}

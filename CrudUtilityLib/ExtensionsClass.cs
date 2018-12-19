using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudUtilityLib
{
    public static class ExtensionsClass
    {
        /// <summary>
        /// Extension function to display date object at dd-MM-yyyy format
        /// </summary>
        /// <param name="date">Nullable DateTime object</param>
        /// <returns>Formated date or Non Défini</returns>
        public static string Afficher(this DateTime? date)
        {
            return date.HasValue ? date.Value.ToString("dd-MM-yyyy") : "Non Défini";
        }
        /// <summary>
        /// Extension function to display date object at dd-MM-yyyy HH:mm format
        /// </summary>
        /// <param name="date">Nullable DateTime object</param>
        /// <returns>Formated date or Non Défini</returns>
        public static string AfficherTemps(this DateTime? date)
        {
            return date.HasValue ? date.Value.ToString("dd-MM-yyyy HH:mm") : "Non Défini";
        }
        /// <summary>
        /// Extension function to display double number to french number format
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>formated number or Non Défini</returns>
        public static string Afficher(this double? nombre)
        {
            if (nombre.HasValue)
                return nombre.Value.ToString("### ### ### ### ##0.###");
            else return "Non Défini";
        }
        /// <summary>
        /// Extension function to display decimal number to french number format
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>formated number or Non Défini</returns>
        public static string Afficher(this decimal? nombre)
        {
            if (nombre.HasValue)
                return nombre.Value.ToString("### ### ### ### ##0.###");
            else return "Non Défini";
        }
    }
}

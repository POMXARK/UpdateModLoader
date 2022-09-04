using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using YamlDotNet.Core.Tokens;

namespace DownloadLinksExtantions
{
    static class DownloadLinksExtantions
    {
        /// <summary>
        /// Возвращает часть адреса на страницу с модом
        /// </summary>
        /// <param name="url"></param>
        /// <returns>string</returns>
        public static string ModsfireDownloadLink(this string url)
        {
            var uri = new Uri(url);
            return string.Join("", uri.Segments.Skip(1));
        }

        /// <summary>
        /// Возвращает полный адресс для авто загрузки
        /// </summary>
        /// <param name="url"></param>
        /// <returns>string</returns>
        public static string FullModsfireDownloadLink(this string url)
        {
            return "https://modsfire.com/d/" + url;
        }
    }
}
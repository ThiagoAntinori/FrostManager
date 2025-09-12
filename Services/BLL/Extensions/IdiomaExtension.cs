using Services.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL.Extensions
{
    public static class IdiomaExtension
    {
        public static string Traducir(this string word)
        {
            return IdiomaService.Current.Traducir(word);
        }
    }
}

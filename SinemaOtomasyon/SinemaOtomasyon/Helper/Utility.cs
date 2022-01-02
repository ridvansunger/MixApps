using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyon.Helper
{
    public static class Utility
    {
        private readonly static string appName = "Sinema Otomasyon";
        /// <summary>
        /// uyguşmada error mesajı vermek için bu method kullılacak
        /// </summary>
        /// <param name="message">verilen hata mesajını bu parametrede gönder</param>
        public static void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, appName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Uygulama içeriisnde başarılı mesajşar bu method ile gösterilecek
        /// </summary>
        /// <param name="message">başarılı mesak parametresi</param>
        public static void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, appName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public static DialogResult ShowDialogInformationMessage(string message)
        {
            DialogResult result = MessageBox.Show(message, appName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            return result;
        }

    }
}

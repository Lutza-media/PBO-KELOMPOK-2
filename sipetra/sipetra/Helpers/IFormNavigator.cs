using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sipetra.Models;

namespace sipetra.Helpers
{
    public interface IFormNavigator
    {
        /// <summary>
        /// Menampilkan form
        /// </summary>
        void ShowForm();

        /// <summary>
        /// Menyembunyikan form
        /// </summary>
        void HideForm();

        /// <summary>
        /// Mengirim data user ke form
        /// </summary>
        /// <param name="user">Objek UserModel yang berisi data pengguna</param>
        void SetUserData(UserModel user);

        /// <summary>
        /// Navigasi ke form lain
        /// </summary>
        /// <param name="targetForm">Form tujuan</param>
        void NavigateTo(Form targetForm);

        /// <summary>
        /// Kembali ke form sebelumnya
        /// </summary>
        void GoBack();
    }
}
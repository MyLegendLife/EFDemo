using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Client
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                DevExpress.UserSkins.OfficeSkins.Register();
                DevExpress.Skins.SkinManager.EnableFormSkins();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                //自动更新
                if ((args == null || args.Length == 0 || args[0] != "StartNormal") && File.Exists("RDAutoGradeNew.exe"))
                {
                    Process.Start("RDAutoGradeNew.exe", "StartAutoGrade");
                    return;
                }


                FmLoading fmLoading = new FmLoading();
                fmLoading.ShowDialog();

                FmLogin fmLogin = fmLoading.fmLogin;
                DialogResult res = fmLogin.ShowDialog();
                if (res != DialogResult.OK)
                    return;

                Application.Run(new FmMain());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

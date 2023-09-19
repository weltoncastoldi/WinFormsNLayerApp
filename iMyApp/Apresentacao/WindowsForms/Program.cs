using WindowsForms.Telas.Cargos;

namespace WindowsForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.


                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);


                SplashSreen frmSplash = new SplashSreen();
                frmSplash.ShowDialog();

                MDIPrincipal frmMDI = new MDIPrincipal();
                Application.Run(frmMDI);
            }
            catch (Exception ex)
            {
                //Log it
                MessageBox.Show(ex.Message);
            }
        }
    }
}